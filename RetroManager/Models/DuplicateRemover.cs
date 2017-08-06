using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RetroManager.Models
{
    public interface IDuplicateRemover
    {
        void delete();
        List<string> dryRun(IEnumerable<string> files, List<string> priority);
    }

    public class SerializedFile
    {
        public string src;
        public string identifier;
        public string title;

        public SerializedFile(string file, Regex pattern)
        {
            var untrimmedIdentifier = pattern.Matches(file)
                .Cast<Match>()
                .Aggregate("", (current, match) => current + match.Value);

            title = Path.GetFileName(string.IsNullOrWhiteSpace(untrimmedIdentifier) ?
                file : file.Replace(untrimmedIdentifier, string.Empty));
            src = file;
            identifier = untrimmedIdentifier.Trim();
        }
    }

    public abstract class DuplicateRemover : IDuplicateRemover
    {
        protected List<string> filesToDelete = new List<string>();
        protected Dictionary<string, SerializedFile> identifierMap = new Dictionary<string, SerializedFile>();
        protected List<string> identifiers;

        public abstract void analyze(IEnumerable<string> files);

        public List<string> FilesToDelete
        {
            get
            {
                return filesToDelete;
            }
        }

        public virtual void delete()
        {
            // Benchmark against Parallel.ForEach()
            filesToDelete.ForEach(file => File.Delete(file));
            filesToDelete.Clear();
        }

        public virtual List<string> dryRun(IEnumerable<string> files, List<string> identifiers = null)
        {
            this.identifiers = identifiers;
            analyze(files);
            return filesToDelete;
        }
    }

    public class RegionDuplicateRemover : DuplicateRemover
    {
        private Dictionary<string, int> serializedPriority = new Dictionary<string, int>();
        private Regex pattern = new Regex(@"\s*?(?:\(.*?\)|\[.*?\]|\{.*?\})");

        public override void analyze(IEnumerable<string> files)
        {
            var priority = 0;

            foreach (var identifier in identifiers)
            {
                serializedPriority.Add(identifier, priority);
                priority++;
            }

            var serializedFiles = files.Select(file => new SerializedFile(file, pattern));

            foreach (var file in serializedFiles)
            {
                if (!identifierMap.ContainsKey(file.title))
                {
                    identifierMap[file.title] = file;
                    continue;
                }

                var mappedFile = identifierMap[file.title];
                
                if (serializedPriority[file.identifier] < serializedPriority[mappedFile.identifier])
                {
                    identifierMap[file.title] = file;
                    filesToDelete.Add(mappedFile.src);
                    continue;
                }

                filesToDelete.Add(file.src);
            }
        }
    }

    public class RevisionDuplicateRemover : DuplicateRemover
    {
        private Regex pattern = new Regex(@"REV\d\d");

        public override void analyze(IEnumerable<string> files)
        {
            var serializedFiles = files.Select(file => new SerializedFile(file, pattern));

            foreach (var file in serializedFiles)
            {
                if (String.IsNullOrWhiteSpace(file.identifier))
                {
                    continue;
                }

                if (!identifierMap.ContainsKey(file.title))
                {
                    identifierMap[file.title] = file;
                    continue;
                }

                var mappedFile = identifierMap[file.title];
                var mappedIdentifier = mappedFile.identifier;
                var currentIdentifier = file.identifier;

                if (String.CompareOrdinal(mappedIdentifier, currentIdentifier) < 0)
                {
                    identifierMap[file.title] = file;
                    filesToDelete.Add(mappedFile.src);
                    continue;
                }

                filesToDelete.Add(file.src);
            }
        }
    }
}
