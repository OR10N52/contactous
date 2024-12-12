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
    public partial class RemoveContacto : Form
    {
        private List<contacto> contacts;
        public RemoveContacto(List<contacto> contacts)
        {
            InitializeComponent();
            this.contacts = contacts;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedItems.Count > 0)
            {

                int selected = listBoxContacts.SelectedIndex;

                contacts.RemoveAt(selected);

                listBoxContacts.Items.RemoveAt(selected);


                MessageBox.Show("Contacto eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún contacto.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 mainPaige = Application.OpenForms["Form1"] as Form1;

            mainPaige.Show();

            this.Hide();
        }

        private void RemoveContacto_Load(object sender, EventArgs e)
        {
            UpdateContactList();
        }
        public void UpdateContactList()
        {
            listBoxContacts.Items.Clear();

            foreach (var contact in contacts)
            {
                listBoxContacts.Items.Add(contact);
            }
        }

    }
}
