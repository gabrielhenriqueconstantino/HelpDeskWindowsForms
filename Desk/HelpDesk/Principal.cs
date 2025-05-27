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
    public partial class Principal : Form
    {
        // Adicione um campo para manter a instância única do painel de chamados
        private FormPainelDeChamados painelChamados = new FormPainelDeChamados();

        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroDaMáquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var login = new frmLoginPainel())
            {
                login.ShowDialog();
                if (!login.Autenticado)
                    return;
            }

            if (painelChamados == null || painelChamados.IsDisposed)
            {
                painelChamados = new FormPainelDeChamados();
                painelChamados.MdiParent = this;
            }
            painelChamados.Show();
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Passe a instância do painel para o próximo formulário
            FormCadastroUsuario formUsuario = new FormCadastroUsuario(painelChamados);
            formUsuario.MdiParent = this;
            formUsuario.Show();
        }
    }
}
