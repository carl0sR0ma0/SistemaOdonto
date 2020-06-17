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
    public partial class Consultas : Form
    {
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();

        private Dictionary<int, DataGridView> DataGridViews = new Dictionary<int, DataGridView>();

        public Consultas()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            var listaD = serviceD.Listar();
            foreach (var dentista in listaD)
            {
                tabControlAgenda.TabPages.Add(dentista.Id.ToString(), dentista.Nome);
                DataGridView dgv = new DataGridView();
                DataGridViews.Add(dentista.Id, dgv);
                GerarTabela(dgv);
                tabControlAgenda.TabPages[dentista.Id.ToString()].Controls.Add(dgv);
            }
        }

        private void GerarTabela(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.Columns.Add("ColunaCodigoConsulta", "CodigoConsulta");
            dgv.Columns[0].Visible = false;
            dgv.Columns.Add("ColunaHora", "");

            DataGridViewLinkColumn colPaciente = new DataGridViewLinkColumn();
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "ColunaNomePaciente";
            dgv.Columns.Add(colPaciente);

            dgv.Columns.Add("ColunaStatus", "Status");

            DataGridViewLinkColumn colConsulta = new DataGridViewLinkColumn();
            colConsulta.HeaderText = "";
            colConsulta.Name = "ColunaVerConsulta";
            dgv.Columns.AddRange(colConsulta);
        }
    }
}
