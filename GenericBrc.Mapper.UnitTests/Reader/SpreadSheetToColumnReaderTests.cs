using GenericBrc.Mapper.Reader;
using NUnit.Framework;
using System.IO;
using System.Linq;

namespace GenericBrc.Mapper.UnitTests.Reader
{
    [TestFixture()]
    public class SpreadSheetToColumnReaderTests
    {
        [TestCase]
        public void ReadDataFromFile_Called_ReturnsData()
        {
            // Arrange
            var a = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            a = a.Replace("/bin/Debug", "/Resources/Test.xlsx");
            var reader = new SpreadsheetToColumnReader(a);

            // Act
            var result = reader.ReadData();

            // Assert
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Forenames", result.ToArray()[0]);
            Assert.AreEqual("Surname", result.ToArray()[1]);
        }
    }
}
