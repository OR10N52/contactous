using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactous
{
    public partial class updateContacto : Form
    {
        private List<contacto> contactos;
        private contacto selected;

        public updateContacto(List<contacto> contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
        }

        private void updateContacto_Load(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        public void UpdateContactList()
        {
            listBoxContacts.Items.Clear();

            foreach (var contact in contactos)
            {
                listBoxContacts.Items.Add(contact);
            }
        }

        private void listBoxContacts_Click(object sender, EventArgs e)
        {
            selected = (contacto) listBoxContacts.SelectedItem;
        
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 mainPaige = Application.OpenForms["Form1"] as Form1;

            mainPaige.Show();

            this.Hide();
        }

        private void editBut_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxNumber.Text = string.Empty;
            if (listBoxContacts.SelectedItems.Count > 0) {
                textBoxName.Text = selected.name;
                textBoxNumber.Text = selected.number;
            } else
            {
                MessageBox.Show("Primero seleccione el contacto que desea modificar, y luego pulse \"Editar\"");
            }
        }

        private void ConfirmBut_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedItems.Count > 0) { 
                if(textBoxNumber.Text.Length == 9 && !string.IsNullOrEmpty(textBoxName.Text))
                {
                    selected.name = textBoxName.Text;
                    selected.number = textBoxNumber.Text;

                    UpdateContactList();
                    textBoxName.Clear();
                    textBoxNumber.Clear();

                    MessageBox.Show("Contacto actualizado correctamente");
                } else
                {
                    MessageBox.Show("Datos invalidos. Por favor, asegurese de rellenar ambos campos y que el numero de telefono contiene 9 digitos.");
                }
            } else
            {
                MessageBox.Show("Primero seleccione el contacto que desea modificar, y luego pulse \"Editar\"");
            }
            
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
