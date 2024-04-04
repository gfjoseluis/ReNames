using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReNames
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                foreach (string file in files)
                {
                    int rowId = DgvArchivos.Rows.Add();
                    DataGridViewRow row = DgvArchivos.Rows[rowId];

                    row.Cells["Status"].Value = true; // Estado
                    row.Cells["OldName"].Value = Path.GetFileName(file); // Nombre
                    // Los campos "Nuevo Nombre" y "Error" se dejan vacíos por ahora
                }
            }
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            FrmRules frmRules = new();
            if (frmRules.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(frmRules.Valor);
            }
        }
    }
}
