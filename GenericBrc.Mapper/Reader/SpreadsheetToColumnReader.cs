using LinqToExcel;
using System.Collections.Generic;
using System.Linq;

namespace GenericBrc.Mapper.Reader
{
    public class SpreadsheetToColumnReader : FileReader<IEnumerable<string>>
    {
        public SpreadsheetToColumnReader(string filePath) : base(filePath)
        {
        }

        public override IEnumerable<string> ReadDataFromFile()
        {
            var data = new ExcelQueryFactory(FilePath);
            var workSheetNames = data.GetWorksheetNames();
            var firstWorksheetName = workSheetNames.ToList()[0];
            return data.GetColumnNames(firstWorksheetName);
        }
    }
}
