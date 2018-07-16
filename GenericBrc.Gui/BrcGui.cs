using GenericBrc.Mapper.Generator;
using GenericBrc.Mapper.Reader;
using GenericBrc.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GenericBrc.Gui
{
    public partial class BrcGui : Form
    {
        private const string ExcelFileFilter = "Spreadsheets|*.xlsx; *.xls";

        private List<SpreadsheetMap> SpreadsheetMaps { get; set; }

        public BrcGui()
        {
            InitializeComponent();
            SpreadsheetMaps = new List<SpreadsheetMap>();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = ExcelFileFilter };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = ofd.FileName;

                try
                {
                    var mapper = new SpreadsheetToColumnReader(ofd.FileName);
                    mapper.ReadDataFromFile().ToList().ForEach(columnName => SpreadSheetColumns.Items.Add(columnName));
                }
                catch
                {
                    // log it & inform user
                }
            }
        }

        private void ConnectToDatabase_Click(object sender, EventArgs e)
        {
            // Data Source=Omar\SQLEXPRESS;Initial Catalog=SCHOOL;User ID=SUPERUSER;Password=SUPERUSER;
            if (!string.IsNullOrWhiteSpace(ConnectionString.Text))
            {
                // this is SQL server only
                try
                {
                    using (var connection = new SqlConnection(ConnectionString.Text))
                    {
                        connection.Open();

                        var dt = connection.GetSchema("Tables");
                        var tableNames = new List<String>();
                        foreach (DataRow row in dt.Rows)
                        {
                            tableNames.Add((string)row["TABLE_NAME"]);
                        }

                        TableNames.Items.Clear();
                        tableNames.ForEach(tableName => TableNames.Items.Add(tableName));
                    }
                }
                catch
                {
                    // Log it
                }
            }
        }

        private void TableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumnMappingButtonEnabled();
            if (TableNames.SelectedIndex > -1)
            {
                using (var connection = new SqlConnection(ConnectionString.Text))
                {
                    connection.Open();

                    var sql = $"SELECT TOP 0 * FROM {TableNames.SelectedItem.ToString()}";
                    var command = connection.CreateCommand();
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        var table = reader.GetSchemaTable();
                        DatabaseColumnNames.Items.Clear();
                        foreach (DataRow row in table.Rows)
                        {
                            DatabaseColumnNames.Items.Add(row["ColumnName"]);
                        }
                    }
                }
            }
        }

        private void AddColumnMapping_Click(object sender, EventArgs e)
        {
            if (SpreadSheetColumns.SelectedIndex > -1 && TableNames.SelectedIndex > -1 && DatabaseColumnNames.SelectedIndex > -1)
            {
                var map = new SpreadsheetMap()
                {
                    SpreadSheetColumn = SpreadSheetColumns.SelectedItem.ToString(),
                    TableName = TableNames.SelectedItem.ToString(),
                    ColumnName = DatabaseColumnNames.SelectedItem.ToString()
                };

                SpreadsheetMaps.Add(map);
                ColumnMappings.Items.Add(map.ToString());
                GenerateXmlMap.Enabled = SpreadsheetMaps.Any();
            }
        }

        private void GenerateXmlMap_Click(object sender, EventArgs e)
        {

            if (SpreadsheetMaps.Any())
            {
                var cofd = new FolderBrowserDialog();

                if (cofd.ShowDialog() == DialogResult.OK)
                {
                    var generator = new XmlGenerator(SpreadsheetMaps, cofd.SelectedPath);
                    generator.GenerateXml();
                    MessageBox.Show($"The mapping document has been created at {cofd.SelectedPath}\test.xml", "Mapping Document Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ConnectionString_TextChanged(object sender, EventArgs e)
        {
            ConnectToDatabase.Enabled = !string.IsNullOrWhiteSpace(ConnectionString.Text);
        }

        private void FilePath_TextChanged(object sender, EventArgs e)
        {
            RefreshColumnList.Enabled = !string.IsNullOrWhiteSpace(FilePath.Text);
        }

        private void SpreadSheetColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumnMappingButtonEnabled();
        }

        private void DatabaseColumnNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumnMappingButtonEnabled();
        }

        private void SetColumnMappingButtonEnabled() => AddColumnMapping.Enabled = SpreadSheetColumns.SelectedIndex >= 0 && TableNames.SelectedIndex >= 0 && DatabaseColumnNames.SelectedIndex >= 0;
    }
}
