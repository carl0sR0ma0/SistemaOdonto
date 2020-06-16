using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdonto
{
    public partial class CadPaciente : Form
    {
        PacienteService service = new PacienteService();

        public CadPaciente()
        {
            InitializeComponent();
            cbSexo.Text = "Masculino";
        }

        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o campo Telefone";
            }
            else if (txtCEP.Text == string.Empty)
            {
                return "Preencha o campo CEP";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Cadastro Efetuado com Sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        public Paciente objGerado()
        {
            Paciente obj = new Paciente();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.CEP = txtCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Complemento = txtComplemento.Text;
            obj.Nascimento = Convert.ToDateTime(dtDataNasc.Value);
            obj.Sexo = cbSexo.Text;

            return obj;
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            cbSexo.SelectedItem = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConDentista frm = new ConDentista();
            frm.ShowDialog();
        }
    }
}
