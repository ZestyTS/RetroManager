using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RetroManager.Models.Tests
{
    [TestClass]
    public class RegionDuplicateRemoverTests
    {
        [TestMethod]
        public void RegionDuplicateRemoverTest()
        {
            var priority = new List<string>
            {
                "(USA, Europe)",
                "(EU)",
                "(USA)",
                "[E]"
            };

            var files = new List<string>
            {
                "Game2 (EU)",
                "Game2 (USA, Europe)",
                "Mario Party DS (EU)",
                "Mario Party DS (USA)",
                "Mario Party DS [E]",
                "Mario Party DS",
                "Game1",
                "Game1 [J]"
            };

            var expectedFiles = new List<string>
            {
                "Game2 (EU)",
                "Mario Party DS (USA)",
                "Mario Party DS [E]",
                "Mario Party DS",
                "Game1 [J]" //this is removed over the non region game only because both of them aren't in the priority list so the first one is taken and all other ones will be removed
            };

            var rd = new RegionDuplicateRemover();
            rd.dryRun(files, priority);

            Assert.IsTrue(rd.FilesToDelete.SequenceEqual(expectedFiles));
        }
    }
}