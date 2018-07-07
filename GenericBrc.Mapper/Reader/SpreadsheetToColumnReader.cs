using LinqToExcel;
using System.Collections.Generic;
using System.Linq;

namespace GenericBrc.Mapper.Reader
{
    public class SpreadsheetToColumnReader : SpreadsheetReader<IEnumerable<string>>
    {
        public SpreadsheetToColumnReader(string filePath) : base(filePath)
        {
        }

        public override IEnumerable<string> Read()
        {
            var data = new ExcelQueryFactory(FilePath);
            var firstWorksheetName = data.GetWorksheetNames().ToList()[0];
            return data.GetColumnNames(firstWorksheetName);
        }
    }
}
