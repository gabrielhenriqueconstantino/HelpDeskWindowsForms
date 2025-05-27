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
    public partial class FormCadastroDeMaquina : Form
    {
        private FormPainelDeChamados _painelChamados;

        public FormCadastroDeMaquina()
        {
            InitializeComponent();
        }

        // Adicione um construtor que recebe o painel de chamados
        public FormCadastroDeMaquina(FormPainelDeChamados painelChamados)
        {
            InitializeComponent();
            _painelChamados = painelChamados;
        }

        private void FormCadastroDeMaquina_Load(object sender, EventArgs e)
        {

        }
        public BindingList<Maquina> maquinas = new BindingList<Maquina>();

        private async void btnContinuar_Click(object sender, EventArgs e)
        {

            Maquina maquina = new Maquina();

            maquina.Serie = Convert.ToInt32(txtSerie.Text); 
            maquina.Patrimonio = txtPatrimonio.Text;
            maquina.Modelo = txtModelo.Text;
            maquina.SistemaOperacional = txtSistemaOperacional.Text;
            maquina.Localizacao = txtLocalizacao.Text;
            maquina.UsuarioResponsavel = txtUsuarioResponsavel.Text;


            if (txtSerie.Text == "" || txtSerie.Text == null)
            {
                MessageBox.Show("Número de Série não informado");
            }
            else if (txtModelo.Text == "" || txtModelo.Text == null)
            {
                MessageBox.Show("Modelo não informado");
            }
            else if (txtLocalizacao.Text == "" || txtLocalizacao.Text == null)
            {
                MessageBox.Show("Localização não informado");
            }
            else if (txtPatrimonio.Text == "" || txtPatrimonio.Text == null)
            {
                MessageBox.Show("N° de Patrimônio não informado");
            }
            else if (txtSistemaOperacional.Text == "" || txtSistemaOperacional.Text == null)
            {
                MessageBox.Show("Sistema Operacional não informado");
            }
            else if (txtUsuarioResponsavel.Text == "" || txtUsuarioResponsavel.Text == null)
            {
                MessageBox.Show("Usuário Responsável não informado");
            }
            else
            { 

                await Task.Delay(2000);

                // Passe a instância do painel para o próximo formulário
                FormDescricaoDoChamado CadastroDescricao = new FormDescricaoDoChamado(_painelChamados);
                CadastroDescricao.Serie = Convert.ToInt32(txtSerie.Text);
                CadastroDescricao.Show();

                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLocalizacao.Text = null;
            txtPatrimonio.Text = null;
            txtModelo.Text = null;
            txtSerie.Text = null;
            txtSistemaOperacional.Text = null;
            txtUsuarioResponsavel.Text = null;

        }
    }
}
