using System;
using System.IO;

namespace GenericBrc.Mapper.Reader
{
    public abstract class FileReader<T>
    {
        protected string FilePath { get; }

        protected FileReader(string filePath)
        {
            FilePath = filePath ?? throw new ArgumentNullException();
        }

        public abstract T ReadDataFromFile();

        public T ReadData()
        {
            EnsureFileExists();
            return ReadDataFromFile();
        }

        void EnsureFileExists()
        {
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException();
            }
        }
    }
}
