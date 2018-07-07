namespace GenericBrc.Gui
{
    partial class BrcGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.RefreshColumnList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectToDatabase = new System.Windows.Forms.Button();
            this.ConnectionString = new System.Windows.Forms.TextBox();
            this.SpreadSheetColumns = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DatabaseColumnNames = new System.Windows.Forms.ListBox();
            this.TableNames = new System.Windows.Forms.ListBox();
            this.AddColumnMapping = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ColumnMappings = new System.Windows.Forms.ListBox();
            this.GenerateXmlMap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectFile);
            this.groupBox1.Controls.Add(this.FilePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Path";
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(660, 17);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(109, 23);
            this.SelectFile.TabIndex = 1;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(7, 20);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(647, 20);
            this.FilePath.TabIndex = 0;
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // RefreshColumnList
            // 
            this.RefreshColumnList.Enabled = false;
            this.RefreshColumnList.Location = new System.Drawing.Point(12, 129);
            this.RefreshColumnList.Name = "RefreshColumnList";
            this.RefreshColumnList.Size = new System.Drawing.Size(133, 23);
            this.RefreshColumnList.TabIndex = 2;
            this.RefreshColumnList.Text = "Refresh Column List";
            this.RefreshColumnList.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConnectToDatabase);
            this.groupBox2.Controls.Add(this.ConnectionString);
            this.groupBox2.Location = new System.Drawing.Point(13, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection String";
            // 
            // ConnectToDatabase
            // 
            this.ConnectToDatabase.Enabled = false;
            this.ConnectToDatabase.Location = new System.Drawing.Point(660, 17);
            this.ConnectToDatabase.Name = "ConnectToDatabase";
            this.ConnectToDatabase.Size = new System.Drawing.Size(109, 23);
            this.ConnectToDatabase.TabIndex = 2;
            this.ConnectToDatabase.Text = "Connect";
            this.ConnectToDatabase.UseVisualStyleBackColor = true;
            this.ConnectToDatabase.Click += new System.EventHandler(this.ConnectToDatabase_Click);
            // 
            // ConnectionString
            // 
            this.ConnectionString.Location = new System.Drawing.Point(7, 19);
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.Size = new System.Drawing.Size(647, 20);
            this.ConnectionString.TabIndex = 2;
            this.ConnectionString.TextChanged += new System.EventHandler(this.ConnectionString_TextChanged);
            // 
            // SpreadSheetColumns
            // 
            this.SpreadSheetColumns.FormattingEnabled = true;
            this.SpreadSheetColumns.Location = new System.Drawing.Point(12, 159);
            this.SpreadSheetColumns.Name = "SpreadSheetColumns";
            this.SpreadSheetColumns.Size = new System.Drawing.Size(254, 199);
            this.SpreadSheetColumns.TabIndex = 4;
            this.SpreadSheetColumns.SelectedIndexChanged += new System.EventHandler(this.SpreadSheetColumns_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DatabaseColumnNames);
            this.groupBox3.Controls.Add(this.TableNames);
            this.groupBox3.Location = new System.Drawing.Point(272, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 242);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database";
            // 
            // DatabaseColumnNames
            // 
            this.DatabaseColumnNames.FormattingEnabled = true;
            this.DatabaseColumnNames.Location = new System.Drawing.Point(269, 17);
            this.DatabaseColumnNames.Name = "DatabaseColumnNames";
            this.DatabaseColumnNames.Size = new System.Drawing.Size(241, 212);
            this.DatabaseColumnNames.TabIndex = 1;
            this.DatabaseColumnNames.SelectedIndexChanged += new System.EventHandler(this.DatabaseColumnNames_SelectedIndexChanged);
            // 
            // TableNames
            // 
            this.TableNames.FormattingEnabled = true;
            this.TableNames.Location = new System.Drawing.Point(7, 17);
            this.TableNames.Name = "TableNames";
            this.TableNames.Size = new System.Drawing.Size(256, 212);
            this.TableNames.TabIndex = 0;
            this.TableNames.SelectedIndexChanged += new System.EventHandler(this.TableNames_SelectedIndexChanged);
            // 
            // AddColumnMapping
            // 
            this.AddColumnMapping.Enabled = false;
            this.AddColumnMapping.Location = new System.Drawing.Point(648, 387);
            this.AddColumnMapping.Name = "AddColumnMapping";
            this.AddColumnMapping.Size = new System.Drawing.Size(140, 23);
            this.AddColumnMapping.TabIndex = 7;
            this.AddColumnMapping.Text = "Add Column Mapping";
            this.AddColumnMapping.UseVisualStyleBackColor = true;
            this.AddColumnMapping.Click += new System.EventHandler(this.AddColumnMapping_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ColumnMappings);
            this.groupBox4.Location = new System.Drawing.Point(12, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 122);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Column Maps";
            // 
            // ColumnMappings
            // 
            this.ColumnMappings.FormattingEnabled = true;
            this.ColumnMappings.Location = new System.Drawing.Point(8, 19);
            this.ColumnMappings.Name = "ColumnMappings";
            this.ColumnMappings.Size = new System.Drawing.Size(616, 95);
            this.ColumnMappings.TabIndex = 0;
            // 
            // GenerateXmlMap
            // 
            this.GenerateXmlMap.Enabled = false;
            this.GenerateXmlMap.Location = new System.Drawing.Point(648, 468);
            this.GenerateXmlMap.Name = "GenerateXmlMap";
            this.GenerateXmlMap.Size = new System.Drawing.Size(143, 23);
            this.GenerateXmlMap.TabIndex = 9;
            this.GenerateXmlMap.Text = "Generate XML Document";
            this.GenerateXmlMap.UseVisualStyleBackColor = true;
            this.GenerateXmlMap.Click += new System.EventHandler(this.GenerateXmlMap_Click);
            // 
            // BrcGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.GenerateXmlMap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AddColumnMapping);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SpreadSheetColumns);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RefreshColumnList);
            this.Controls.Add(this.groupBox1);
            this.Name = "BrcGui";
            this.Text = "BRC Mapper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button RefreshColumnList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConnectToDatabase;
        private System.Windows.Forms.TextBox ConnectionString;
        private System.Windows.Forms.ListBox SpreadSheetColumns;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddColumnMapping;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox DatabaseColumnNames;
        private System.Windows.Forms.ListBox TableNames;
        private System.Windows.Forms.ListBox ColumnMappings;
        private System.Windows.Forms.Button GenerateXmlMap;
    }
}

