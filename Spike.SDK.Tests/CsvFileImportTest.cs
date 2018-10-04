using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spike.SDK.Tests
{
    [TestClass]
    public class CsvFileImportTest
    {
        /* Start: Required structures for an import */

        public enum CsvColumns
        {
            Name = 0,
            Surname = 1
        }

        public class CsvLineItem
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }

        /* End: Required structures for an import */


        [TestMethod]
        public void GenerateSampleFile()
        {
        }

        [TestMethod]
        public void ImportCsvFile()
        {
        }


    }
}
