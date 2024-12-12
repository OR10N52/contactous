using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactous
{
    public partial class AgregarContacto : Form
    {
        private List<contacto> contactos;
        public AgregarContacto(List<contacto> contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
        }


        private void AgregarContacto_Load(object sender, EventArgs e)
        {
            UpdateContactList();
            textBoxName.ForeColor = Color.DarkGray;
            textBoxName.Text = "Nombre del contacto";
            textBoxNumber.ForeColor = Color.DarkGray;
            textBoxNumber.Text = "Telefono del contacto";
        }

        private void addConfirmBut_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxNumber.Text))
            {
                if (textBoxName.Text == "Nombre del contacto" || textBoxNumber.Text == "Telefono del contacto")
                {
                    MessageBox.Show("Por favor, rellena ambos campos");
                }
                else
                {
                    if (textBoxNumber.Text.Length == 9)
                    {
                        var newContact = new contacto(textBoxName.Text, textBoxNumber.Text);
                        contactos.Add(newContact);

                        listBoxContacts.Items.Add(newContact);
                        textBoxName.Clear();
                        textBoxNumber.Clear();
                        MessageBox.Show("Contacto agregado.");
                    }
                    else
                    {
                        MessageBox.Show("El numero introducido no es válido. Asegurese que el numero contiene 9 cifras");
                    }

                }

            }
            else
            {
                MessageBox.Show("Por favor, rellena ambos campos antes de continuar", "Advertencia");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 mainPaige = Application.OpenForms["Form1"] as Form1;

            mainPaige.Show();

            this.Hide();
        }

        private void textBoxName_Enter_1(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Nombre del contacto")
            {
                textBoxName.Text = string.Empty;
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.ForeColor = Color.DarkGray;
                textBoxName.Text = "Nombre del contacto";
            }
        }

        private void textBoxNumber_Enter_1(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "Telefono del contacto")
            {
                textBoxNumber.Text = string.Empty;
                textBoxNumber.ForeColor = Color.Black;
            }
        }

        private void textBoxNumber_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                textBoxNumber.ForeColor = Color.DarkGray;
                textBoxNumber.Text = "Telefono del contacto";
            }
        }

        private void textBoxNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void UpdateContactList()
        {
            listBoxContacts.Items.Clear();

            foreach (var contact in contactos)
            {
                listBoxContacts.Items.Add(contact);
            }
        }
    }
}
