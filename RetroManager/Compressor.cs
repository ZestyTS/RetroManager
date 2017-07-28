using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SevenZip.Compression.LZMA;
using System.IO;
using SevenZip;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Archives.Zip;
using SharpCompress.Readers;
using System.Diagnostics;

namespace RetroManager
{
    public static class Compressor
    {
        public static void CompressFile(string inFile, string outputPath)
        {
            Debug.WriteLine("About to Compress: " + inFile);
            bool markForDeletion = false;

            if (!Path.GetDirectoryName(inFile).Contains("RetroManagerExtract"))
            {
                outputPath += @"\" + "RetroManagerExtract";
            }
            else
            {
                outputPath = Path.GetDirectoryName(inFile);
                markForDeletion = true;
            }

            if (RedudantHelper.isUnixBased)
            {
                outputPath = outputPath.Replace(@"\", @"/");
            }

            Directory.CreateDirectory(outputPath);

            string outputFileName = Path.GetFileName(inFile);
            string outFile = Path.Combine(outputPath, outputFileName + ".zip");

            Int32 dictionary = 1 << 23;
            Int32 posStateBits = 2;
            Int32 litContextBits = 3; // for normal files
                                      // UInt32 litContextBits = 0; // for 32-bit data
            Int32 litPosBits = 0;
            // UInt32 litPosBits = 2; // for 32-bit data
            Int32 algorithm = 2;
            Int32 numFastBytes = 128;

            string mf = "bt4";
            bool eos = true;
            bool stdInMode = false;


            CoderPropID[] propIDs =  {
                CoderPropID.DictionarySize,
                CoderPropID.PosStateBits,
                CoderPropID.LitContextBits,
                CoderPropID.LitPosBits,
                CoderPropID.Algorithm,
                CoderPropID.NumFastBytes,
                CoderPropID.MatchFinder,
                CoderPropID.EndMarker
            };

            object[] properties = {
                (Int32)(dictionary),
                (Int32)(posStateBits),
                (Int32)(litContextBits),
                (Int32)(litPosBits),
                (Int32)(algorithm),
                (Int32)(numFastBytes),
                mf,
                eos
            };

            using (FileStream inStream = new FileStream(inFile, FileMode.Open))
            {
                using (FileStream outStream = new FileStream(outFile, FileMode.Create))
                {
                    SevenZip.Compression.LZMA.Encoder encoder = new SevenZip.Compression.LZMA.Encoder();
                    encoder.SetCoderProperties(propIDs, properties);
                    encoder.WriteCoderProperties(outStream);
                    Int64 fileSize;
                    if (eos || stdInMode)
                        fileSize = -1;
                    else
                        fileSize = inStream.Length;
                    for (int i = 0; i < 8; i++)
                        outStream.WriteByte((Byte)(fileSize >> (8 * i)));
                    encoder.Code(inStream, outStream, -1, -1, null);
                }
            }

            if (markForDeletion)
            {
                File.Delete(inFile);
            }
        }

        public static void DecompressFile(string inFile, string outputPath)
        {
            Debug.WriteLine("About to Decompress: " + inFile);
            outputPath += @"\" + "RetroManagerExtract";

            if (RedudantHelper.isUnixBased)
            {
                outputPath = outputPath.Replace(@"\", @"/");
            }
            Directory.CreateDirectory(outputPath);


            if (Path.GetExtension(inFile) == ".7z")
            {
                using (FileStream inStream = new FileStream(inFile, FileMode.Open))
                {
                    using (var archive = SevenZipArchive.Open(inStream))
                    {
                        IReader reader = archive.ExtractAllEntries();
                        while (reader.MoveToNextEntry())
                        {
                            if (!reader.Entry.IsDirectory)
                                reader.WriteEntryToDirectory(outputPath, new ExtractionOptions() { ExtractFullPath = false, Overwrite = true });
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (FileStream inStream = new FileStream(inFile, FileMode.Open))
                    {
                        using (var archive = ZipArchive.Open(inStream))
                        {
                            IReader reader = archive.ExtractAllEntries();
                            while (reader.MoveToNextEntry())
                            {
                                if (!reader.Entry.IsDirectory)
                                    reader.WriteEntryToDirectory(outputPath, new ExtractionOptions() { ExtractFullPath = false, Overwrite = true });
                            }
                        }
                    }
                }
                catch
				{
                    string outFileName = Path.ChangeExtension(Path.GetFileName(inFile), string.Empty);
                    string outFileWithoutExt = outFileName.Substring(0,outFileName.Length - 1);
					string outFile = outputPath + @"\" + outFileWithoutExt;
                    if (RedudantHelper.isUnixBased)
					{
						outFile = outFile.Replace(@"\", @"/");
					}

                    Debug.WriteLine(outFile);
                    using (FileStream inStream = new FileStream(inFile, FileMode.Open))
                    {
                        using (FileStream output = new FileStream(outFile, FileMode.Create))
                        {
                            SevenZip.Compression.LZMA.Decoder decoder = new SevenZip.Compression.LZMA.Decoder();

                            byte[] properties = new byte[5];
                            if (inStream.Read(properties, 0, 5) != 5)
                                throw (new Exception("input .lzma is too short"));
                            decoder.SetDecoderProperties(properties);

                            long outSize = 0;
                            for (int i = 0; i < 8; i++)
                            {
                                int v = inStream.ReadByte();
                                if (v < 0)
                                    throw (new Exception("Can't Read 1"));
                                outSize |= ((long)(byte)v) << (8 * i);
                            }
                            long compressedSize = inStream.Length - inStream.Position;

                            decoder.Code(inStream, output, compressedSize, outSize, null);
                        }
                    }
                }
            }

        }

    }
}