using GenericBrc.Models.Mapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GenericBrc.Mapper.Generator
{
    public class XmlGenerator
    {
        private List<SpreadsheetMap> spreadsheetMaps;
        private string filePath;

        public XmlGenerator(List<SpreadsheetMap> spreadsheetMaps, string filePath)
        {
            this.filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            this.spreadsheetMaps = spreadsheetMaps ?? throw new ArgumentNullException(nameof(spreadsheetMaps));
        }

        public void GenerateXml()
        {
            var serialiser = new XmlSerializer(typeof(List<SpreadsheetMap>));
            var file = File.Create(Path.Combine(filePath, "test.xml"));
            serialiser.Serialize(file, spreadsheetMaps);
            file.Close();
        }
    }
}
