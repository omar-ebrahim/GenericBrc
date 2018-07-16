using System;
using System.IO;
using GenericBrc.Mapper.Reader;
using NUnit.Framework;

namespace GenericBrc.Mapper.UnitTests.Reader
{
    [TestFixture()]
    public class FileReaderTests
    {
        [Test()]
        public void Constructor_FilePathNotGiven_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => new TestableReader(null));
        }

        [Test]
        public void ReadDataFromFile_FilePathDoesNotExists_Throws()
        {
            // Arrange
            var reader = new TestableReader("~/test.txt");

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => reader.ReadData());
        }

        class TestableReader : FileReader<object>
        {
            public TestableReader(string filePath) : base(filePath)
            {
            }

            public override object ReadDataFromFile()
            {
                return new object();
            }
        }
    }
}
