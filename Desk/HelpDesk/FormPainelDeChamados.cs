using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class FormPainelDeChamados : Form
    {
        public int Serie;
        public string Usuario;
        public string DescricaoProblema;
        public string Status;

        // Torne a lista estática para persistir enquanto o programa estiver aberto
        public static BindingList<Chamado> ListadeChamadas { get; set; } = new BindingList<Chamado>();

        public FormPainelDeChamados()
        {
            InitializeComponent();
            this.Load += FormPainelDeChamados_Load;
        }

        public void AdicionarChamado(Chamado chamado)
        {
            int Id = 1;

            if (ListadeChamadas.Any())
                Id = ListadeChamadas.Max(lp => lp.Id) + 1;

            chamado.Id = Id;
            chamado.DataCriacao = DateTime.Now;

            ListadeChamadas.Add(chamado);
        }

        private void FormPainelDeChamados_Load(object sender, EventArgs e)
        {
            gdbChamados.AutoGenerateColumns = true;
            gdbChamados.DataSource = ListadeChamadas;
        }

        public Chamado DescricaoChamado { get; set; }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.HeaderText = "Status";
            comboColumn.Name = "comboOpcao";

            comboColumn.Items.AddRange("Pendente", "Em andamento", "Concluído");

            gdbChamados.Columns.Add(comboColumn);
        }
    }
}
