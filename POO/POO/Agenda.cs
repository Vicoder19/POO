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
    public partial class FormAgenda : Form
    {
        string Message = "Ainda em produção";
        List<Pessoa> ListaPessoas = new List<Pessoa>();
        public FormAgenda()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Pessoa Pessoa = new Pessoa(tbName.Text, tbEndereço.Text, Convert.ToInt32(tbTelefone.Text), tbEmail.Text);
                ListViewItem item = new ListViewItem(new[] { Pessoa.Nome, Pessoa.Endereco, Convert.ToString(Pessoa.Telefone), Pessoa.Email});
                lvAgenda.Items.Add(item);
                ListaPessoas.Add(Pessoa);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
                
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message, "Atenção");
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message, "Atenção");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int itemList = lvAgenda.SelectedItems.Count - 1; itemList >= 0; itemList--) 
            {
                ListViewItem lista = lvAgenda.SelectedItems[itemList];
                lvAgenda.Items.Remove(lista);
            }

        }
        bool ValidarCampos()
        {
            if (tbName.Text == "" || tbName.Text.Length < 3)
            {
                MessageBox.Show("Nome Inválido", "Atenção");
                return false;
            }
            else if (tbEndereço.Text == "")
            {
                MessageBox.Show("Endereço Inválido", "Atenção");
                return false;
            }
            else if (tbTelefone.Text == "")
            {
                MessageBox.Show("Telefone invalido", "Atenção");
                return false;
            }
            else if(tbEmail.Text == "")
            {
                MessageBox.Show("Email invalido", "Atenção");
                return false;
            }
                return true;
        }
    }
}
