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
    public partial class FormFuncionario : Form
    {
        List<Funcionario> ListaFuncionarios = new List<Funcionario>();
        public FormFuncionario()
        {
            InitializeComponent();         
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            if (tbDesconto.Enabled == false || tbDesconto.Text == "")
            {
                tbDesconto.Text = Convert.ToString(0);
            }
                if (ValidarCampos()) {
            if (tbCargo.Text == "Gerente" || tbCargo.Text == "gerente")
                {
                Gerente Gerente = new Gerente(tbNome.Text, float.Parse(tbSalario.Text), float.Parse(tbDesconto.Text), float.Parse(tbAdicional.Text), tbCargo.Text);
                Gerente.Liquido = Gerente.calculaLiquido(Gerente.Salario, Gerente.Desconto, Gerente.Adicional);
                Gerente.CalcularBonus(Gerente.Liquido);
                ListViewItem item = new ListViewItem(new[] { Convert.ToString(Gerente.Nome), Convert.ToString(Gerente.Salario), Convert.ToString(Gerente.Desconto), Convert.ToString(Gerente.Adicional), Convert.ToString(Gerente.Liquido), Convert.ToString(Gerente.Cargo) });
                Listview.Items.Add(item);
                ListaFuncionarios.Add(Gerente);
                }
            else
                {
                Funcionario Funcionario = new Funcionario(tbNome.Text, float.Parse(tbSalario.Text), float.Parse(tbDesconto.Text), float.Parse(tbAdicional.Text), tbCargo.Text);
                Funcionario.Liquido = Funcionario.calculaLiquido(Funcionario.Salario, Funcionario.Desconto, Funcionario.Adicional);
                Funcionario.CalcularBonus(Funcionario.Liquido);
                ListViewItem item = new ListViewItem(new[] { Convert.ToString(Funcionario.Nome), Convert.ToString(Funcionario.Salario), Convert.ToString(Funcionario.Desconto), Convert.ToString(Funcionario.Adicional), Convert.ToString(Funcionario.Liquido), Convert.ToString(Funcionario.Cargo) });
                Listview.Items.Add(item);
                ListaFuncionarios.Add(Funcionario);
                }
            }
            LimparCampos();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbSemDesconto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSemDesconto.Checked == true)
            {
                tbDesconto.Enabled = false;
                tbDesconto.Text = "";
            }
            else {
                tbDesconto.Enabled = true;
            }
        }
        bool ValidarCampos()
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Nome Inválido", "Atenção");
                return false;
            }
            else if (tbSalario.Text == "0")
            {
                MessageBox.Show("Salário Inválido", "Atenção");
                return false;
            } else if(tbAdicional.Text == "")
            {
                MessageBox.Show("Adicional não pode ficar em branco");
                return false;
            }else
            return true;
        }
        void LimparCampos()
        {
            tbNome.Text = "";
            tbSalario.Text = "0";
            tbDesconto.Text = "0";
            tbAdicional.Text = "0";
            tbLiquido.Text = "0";
            tbCargo.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int itemList = Listview.SelectedItems.Count - 1; itemList >= 0; itemList--)
            {
                ListViewItem lista = Listview.SelectedItems[itemList];
                Listview.Items.Remove(lista);
            }
        }
    }
}
