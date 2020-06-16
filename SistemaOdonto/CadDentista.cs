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
    public partial class CadDentista : Form
    {
        DentistaService service = new DentistaService();

        public CadDentista()
        {
            InitializeComponent();
            txtNome.Text = txtCelular.Text;
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
            else if (txtCRO.Text == string.Empty)
            {
                return "Preencha o campo CRO";
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

        public Dentista objGerado()
        {
            Dentista obj = new Dentista();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.CRO = txtCRO.Text;

            return obj;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConDentista frm = new ConDentista();
            frm.ShowDialog();
        }   

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCRO.Text = string.Empty;
        }
    }
}
