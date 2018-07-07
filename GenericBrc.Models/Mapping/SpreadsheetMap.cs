namespace GenericBrc.Models.Mapping
{
    public class SpreadsheetMap
    {
        public string SpreadSheetColumn { get; set; }

        public string TableName { get; set; }

        public string ColumnName { get; set; }

        public override string ToString()
        {
            return $"SpreadSheet column {SpreadSheetColumn} - maps to table: {TableName}, column {ColumnName}";
        }
    }
}
