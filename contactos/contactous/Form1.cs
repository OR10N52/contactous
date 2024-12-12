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
    public partial class Form1 : Form
    {
        private List<contacto> contacts = new List<contacto>();
        private AgregarContacto addContact;
        private RemoveContacto removeContact;
        private updateContacto updateContacto;
        private lookContacto lookContacto;

        public Form1()
        {
            InitializeComponent();
            addContact = new AgregarContacto(contacts);
            removeContact = new RemoveContacto(contacts);
            updateContacto = new updateContacto(contacts);
            lookContacto = new lookContacto(contacts);
           
        }

        

        private void AñadirContactoBut_Click(object sender, EventArgs e)
        {
            addContact.UpdateContactList();
            addContact.Show();
            this.Hide();
        }

        private void RemoveContactoBut_Click(object sender, EventArgs e)
        {
            removeContact.UpdateContactList();
            removeContact.Show();
            this.Hide();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estas seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateContactoBut_Click(object sender, EventArgs e)
        {
            updateContacto.UpdateContactList();
            updateContacto.Show();
            this.Hide();
        }

        private void LookContactoBut_Click(object sender, EventArgs e)
        {
            lookContacto.UpdateContactList();
            lookContacto.Show();
            this.Hide();
        }
    }
}
