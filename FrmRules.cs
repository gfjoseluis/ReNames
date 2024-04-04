using ReNames.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReNames
{
    public partial class FrmRules : Form
    {
        public string ValorEliminar { get; private set; }

        public FrmRules()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            // Encuentra el UserControl que está actualmente visible
            UserControl userControlVisible = null;
            foreach (Control control in SCoptions.Panel2.Controls)
            {
                if (control is UserControl && control.Visible)
                {
                    userControlVisible = (UserControl)control;
                    break;
                }
            }

            // Si encontramos un UserControl visible, obtenemos el valor
            if (userControlVisible != null)
            {
                // Supongamos que todos tus UserControls tienen una propiedad 'ValorDelTextBox'
                ValorEliminar = ((dynamic)userControlVisible).ValorDelTextBox;
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void LvOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvOptions.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = LvOptions.SelectedItems[0];
                UserControl userControl;
                switch (selectedItem.Text)
                {
                    case "Eliminar":
                        userControl = new UCEliminar();
                        break;
                    case "Reemplazar":
                        userControl = new UCReemplazar();
                        break;
                    case "Añadir Inicio":
                        userControl = new UCPrefix();
                        break;
                    case "Añadir Final":
                        userControl = new UCSufix();
                        break;
                    default:
                        return;
                }
                // Limpia el Panel2 antes de agregar el nuevo UserControl
                SCoptions.Panel2.Controls.Clear();
                // Ajusta el UserControl para que llene el Panel2
                userControl.Dock = DockStyle.Fill;
                // Agrega el UserControl al Panel2
                SCoptions.Panel2.Controls.Add(userControl);
            }
        }
    }
}
