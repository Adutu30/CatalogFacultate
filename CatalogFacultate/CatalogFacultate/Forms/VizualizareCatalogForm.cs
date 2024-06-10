using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogFacultate.Forms
{
    public partial class VizualizareCatalogForm : Form
    {
        public VizualizareCatalogForm()
        {
            InitializeComponent();
        }

        private void VizualizareCatalogForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string[] lines = File.ReadAllLines("catalog.txt");
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');
                foreach (string headerWord in headerLabels)
                {
                    dataTable.Columns.Add(new DataColumn(headerWord));
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dataTable.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dataTable.Rows.Add(dr);
                }
            }
            if (dataTable.Rows.Count > 0)
            {
                dataGridViewCatalog.DataSource = dataTable;
            }
        }
    }
}
