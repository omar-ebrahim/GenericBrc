namespace GenericBrc.Mapper.Reader
{
    public abstract class Reader<T>
    {
        protected string FilePath { get; }

        public Reader(string filePath)
        {
            FilePath = filePath;
        }

        public abstract T Read();
    }
}
