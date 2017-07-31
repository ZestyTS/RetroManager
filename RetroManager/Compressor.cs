﻿﻿﻿﻿using System;
using System.Diagnostics;
using System.IO;
using RetroManager._7zip;
using RetroManager._7zip.Compress.LZMA;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Archives.Zip;
using SharpCompress.Readers;

namespace RetroManager
{
    public static class Compressor
    {
        public static void CompressFile(string inFile, string outputPath, int mode, bool markForDeletion)
        {
            Debug.WriteLine("About to Compress: " + inFile);

            outputPath = Path.GetDirectoryName(inFile);

			if (RedudantHelper.IsUnixBased)
			{
				outputPath = outputPath.Replace(@"\", @"/");
			}
			Directory.CreateDirectory(outputPath);

			var outputFileName = Path.GetFileName(inFile);
			var outFile = Path.Combine(outputPath, outputFileName);

            using (var inStream = new FileStream(inFile, FileMode.Open))
            {
                if (mode == 0)
                {
                    using (var outStream = new FileStream(outFile + ".zip", FileMode.Create))
                    {
                        using (var archive = ZipArchive.Create())
                        {
                                archive.AddEntry(outputFileName, inStream);
                                archive.SaveTo(outStream);
                        }
                    }
                }
                else
                {
                    const int dictionary = 1 << 23;
                    const int posStateBits = 2;
                    const int litContextBits = 3;
                    const int litPosBits = 0;
                    const int algorithm = 2;
                    const int numFastBytes = 128;

                    const string mf = "bt4";
                    const bool eos = true;

                    CoderPropID[] propIDs =
                    {
                        CoderPropID.DictionarySize,
                        CoderPropID.PosStateBits,
                        CoderPropID.LitContextBits,
                        CoderPropID.LitPosBits,
                        CoderPropID.Algorithm,
                        CoderPropID.NumFastBytes,
                        CoderPropID.MatchFinder,
                        CoderPropID.EndMarker
                    };

                    object[] properties =
                    {
                        dictionary,
                        posStateBits,
                        litContextBits,
                        litPosBits,
                        algorithm,
                        numFastBytes,
                        mf,
                        eos
                    };

                    using (inStream)
                    {
                        using (var outStream = new FileStream(outFile + ".7z", FileMode.Create))
                        {
                            var encoder = new Encoder();
                            encoder.SetCoderProperties(propIDs, properties);
                            encoder.WriteCoderProperties(outStream);
                            long fileSize = -1;
                            for (var i = 0; i < 8; i++)
                                outStream.WriteByte((byte) (fileSize >> (8 * i)));
                            encoder.Code(inStream, outStream, -1, -1, null);
                        }
                    }
                }
            }

            if (outputPath.Contains("RetroManagerExtract")) {
                markForDeletion = true;
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

            if (RedudantHelper.IsUnixBased)
            {
                outputPath = outputPath.Replace(@"\", @"/");
            }
            Directory.CreateDirectory(outputPath);


            if (Path.GetExtension(inFile) == ".7z")
            {
                try {
					using (var inStream = new FileStream(inFile, FileMode.Open))
					{
						using (var archive = SevenZipArchive.Open(inStream))
						{
							var reader = archive.ExtractAllEntries();
							while (reader.MoveToNextEntry())
							{
								if (!reader.Entry.IsDirectory)
									reader.WriteEntryToDirectory(outputPath, new ExtractionOptions { ExtractFullPath = false, Overwrite = true });
							}
						}
					}
				}
				catch
				{
					var outFileName = Path.ChangeExtension(Path.GetFileName(inFile), string.Empty);
					var outFileWithoutExt = outFileName.Substring(0, outFileName.Length - 1);
					var outFile = outputPath + @"\" + outFileWithoutExt;
					if (RedudantHelper.IsUnixBased)
					{
						outFile = outFile.Replace(@"\", @"/");
					}

					using (var inStream = new FileStream(inFile, FileMode.Open))
					{
						using (var output = new FileStream(outFile, FileMode.Create))
						{
							var decoder = new Decoder();

							var properties = new byte[5];
							if (inStream.Read(properties, 0, 5) != 5)
								throw (new Exception("input .lzma is too short"));
							decoder.SetDecoderProperties(properties);

							long outSize = 0;
							for (var i = 0; i < 8; i++)
							{
								var v = inStream.ReadByte();
								if (v < 0)
									throw (new Exception("Can't Read 1"));
								outSize |= ((long)(byte)v) << (8 * i);
							}
							var compressedSize = inStream.Length - inStream.Position;

							decoder.Code(inStream, output, compressedSize, outSize, null);
						}
					}
				}

            }
            else
            {
                try
                {
                    using (var inStream = new FileStream(inFile, FileMode.Open))
                    {
                        using (var archive = ZipArchive.Open(inStream))
                        {
                            var reader = archive.ExtractAllEntries();
                            while (reader.MoveToNextEntry())
                            {
                                if (!reader.Entry.IsDirectory)
                                    reader.WriteEntryToDirectory(outputPath, new ExtractionOptions { ExtractFullPath = false, Overwrite = true });
                            }
                        }
                    }
                }
                catch
				{
                    var outFileName = Path.ChangeExtension(Path.GetFileName(inFile), string.Empty);
                    var outFileWithoutExt = outFileName.Substring(0,outFileName.Length - 1);
					var outFile = outputPath + @"\" + outFileWithoutExt;
                    if (RedudantHelper.IsUnixBased)
					{
						outFile = outFile.Replace(@"\", @"/");
					}

                    Debug.WriteLine(outFile);
                    using (var inStream = new FileStream(inFile, FileMode.Open))
                    {
                        using (var output = new FileStream(outFile, FileMode.Create))
                        {
                            var decoder = new Decoder();

                            var properties = new byte[5];
                            if (inStream.Read(properties, 0, 5) != 5)
                                throw (new Exception("input .lzma is too short"));
                            decoder.SetDecoderProperties(properties);

                            long outSize = 0;
                            for (var i = 0; i < 8; i++)
                            {
                                var v = inStream.ReadByte();
                                if (v < 0)
                                    throw (new Exception("Can't Read 1"));
                                outSize |= ((long)(byte)v) << (8 * i);
                            }
                            var compressedSize = inStream.Length - inStream.Position;

                            decoder.Code(inStream, output, compressedSize, outSize, null);
                        }
                    }
                }
            }

        }

    }
}