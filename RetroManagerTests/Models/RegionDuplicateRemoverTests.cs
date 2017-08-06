using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace RetroManager.Models.Tests
{
    [TestClass()]
    public class RegionDuplicateRemoverTests
    {
        [TestMethod()]
        public void RegionDuplicateRemoverTest()
        {
            var priority = new List<string>()
            {
                "(EU)",
                "(USA)",
                "[E]"
            };

            var files = new List<string>()
            {
                "Game2 (EU)",
                "Mario Party DS (EU)",
                "Mario Party DS (USA)",
                "Mario Party DS [E]"
            };

            var expectedFiles = new List<string>()
            {
                "Mario Party DS (USA)",
                "Mario Party DS [E]"
            };

            var rd = new RegionDuplicateRemover();
            rd.dryRun(files, priority);

            Assert.IsTrue(rd.FilesToDelete.SequenceEqual(expectedFiles));
        }
    }
}