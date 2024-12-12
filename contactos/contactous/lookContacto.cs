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
    public partial class lookContacto : Form
    {
        private List<contacto> contactos;
        
        public lookContacto(List<contacto> contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
        }


        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Nombre del contacto")
            {
                textBoxName.Text = string.Empty;
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.ForeColor = Color.DarkGray;
                textBoxName.Text = "Nombre del contacto";
            }
        }

        private void textBoxNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "Telefono del contacto")
            {
                textBoxNumber.Text = string.Empty;
                textBoxNumber.ForeColor = Color.Black;
            }
        }

        private void textBoxNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                textBoxNumber.ForeColor = Color.DarkGray;
                textBoxNumber.Text = "Telefono del contacto";
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
        private void lookContacto_Load(object sender, EventArgs e)
        {
            UpdateContactList();
            textBoxName.ForeColor = Color.DarkGray;
            textBoxName.Text = "Nombre del contacto";
            textBoxNumber.ForeColor = Color.DarkGray;
            textBoxNumber.Text = "Telefono del contacto";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 mainPaige = Application.OpenForms["Form1"] as Form1;

            mainPaige.Show();

            this.Hide();
        }

        private void addConfirmBut_Click(object sender, EventArgs e)
        {
            var filtered = contactos;
            string buscador;
            string buscador2;
            if (textBoxName.Text!="Nombre del contacto" || textBoxNumber.Text!="Telefono del contacto")
            {

                buscador = textBoxName.Text;
                buscador2 = textBoxNumber.Text;
                filtered = (List<contacto>)contactos.Where(contacto => contacto.name.ToLower().StartsWith(buscador.ToLower()) || contacto.number.StartsWith(buscador2)).ToList();

                actualizar(filtered);

            } else if(textBoxName.Text != "Nombre del contacto" && textBoxNumber.Text != "Telefono del contacto")
            {
                buscador = textBoxName.Text;
                buscador2 = textBoxNumber.Text;
                filtered = (List<contacto>)contactos.Where(contacto => contacto.name.ToLower().StartsWith(buscador.ToLower()) && contacto.number.StartsWith(buscador2)).ToList();

                actualizar(filtered);
            } else
            {
                UpdateContactList();
            }
            
        }

        private void actualizar(List<contacto> filteredList) {

            listBoxContacts.Items.Clear();
            foreach (var contact in filteredList)
            {
                listBoxContacts.Items.Add(contact);
            }
        }
    }
}
