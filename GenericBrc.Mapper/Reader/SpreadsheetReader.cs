namespace GenericBrc.Mapper.Reader
{
    public abstract class SpreadsheetReader<T> : Reader<T> where T : class
    {
        public SpreadsheetReader(string filePath) : base(filePath)
        {
        }
    }
}
