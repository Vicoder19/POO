using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();
            formFuncionario.ShowDialog();
        }

        public void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda formAgenda = new FormAgenda();
            formAgenda.ShowDialog();            
        }
        
    }
}
