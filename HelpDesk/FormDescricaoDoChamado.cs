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
    public partial class FormDescricaoDoChamado : Form
    {
        public int Serie;
        // ...existing code...
        private FormPainelDeChamados _painelChamados;

        public FormDescricaoDoChamado()
        {
            InitializeComponent();
        }

        // Adicione um construtor que recebe o painel de chamados
        public FormDescricaoDoChamado(FormPainelDeChamados painelChamados)
        {
            InitializeComponent();
            _painelChamados = painelChamados;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public BindingList<Chamado> chamados = new BindingList<Chamado>();

        public FormPainelDeChamados PainelDeChamados { get; set; }

        // Added a property for ListadeChamadas
        public FormPainelDeChamados ListadeChamadas { get; set; }

        // ...existing code...
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            Chamado chamado = new Chamado();
            chamado.Usuario = txtUsuario.Text;
            chamado.DescricaoProblema = txtDescricao.Text;
            chamado.Serie = Serie;

            if (txtUsuario.Text == "" || txtUsuario.Text == null)
            {
                MessageBox.Show("Usuário não informado");
            }
            else if (txtDescricao.Text == "" || txtDescricao.Text == null)
            {
                MessageBox.Show("A descrição do problema não foi informado");
            }
            else
            {
                if (_painelChamados != null)
                {
                    _painelChamados.AdicionarChamado(chamado);
                    MessageBox.Show("Descrição enviada com sucesso");
                }
                else
                {
                    MessageBox.Show("Painel de chamados não disponível.");
                }
                this.Close();
            }
        }

        private void FormDescricaoDoChamado_Load(object sender, EventArgs e)
        {
            txtSerie.Text = Serie.ToString();

            txtSerie.Enabled = false;
            dateChamado.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = null;
            txtUsuario.Text = null;
        }
    }
}