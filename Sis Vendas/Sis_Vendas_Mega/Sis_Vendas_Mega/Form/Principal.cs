using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sis_Vendas_Mega
{
    public partial class Principal : Form
    {
        private string p;

  
        public Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public Principal(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
     
        private void cad_clientes_Click(object sender, EventArgs e)
        {
            frm_cad_cli frmCliente = new frm_cad_cli();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o sistema?", "Fechar o sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void manu_produtos_Click(object sender, EventArgs e)
        {
            frm_cad_produto produto = new frm_cad_produto();
            produto.MdiParent = this;
            produto.Show();
        }

        private void manu_usuarios_Click(object sender, EventArgs e)
        {
            frm_usuario usuario = new frm_usuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void cad_produtos_Click(object sender, EventArgs e)
        {
            frm_pesquisar_prod frmProduto = new frm_pesquisar_prod();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void manu_clientes_Click(object sender, EventArgs e)
        {
            frm_manu_cliente frmClinte = new frm_manu_cliente();
            frmClinte.MdiParent = this;
            frmClinte.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler.DisableCloseButton(this.Handle.ToInt32());
        }

        private void pdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pdv pdv = new frm_pdv();
            pdv.MdiParent = this;
            pdv.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caixa frmCaixa = new Caixa();
            frmCaixa.MdiParent = this;
            frmCaixa.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimentoEstoque frmMovimentoEstoque = new MovimentoEstoque();
            frmMovimentoEstoque.MdiParent = this;
            frmMovimentoEstoque.Show();
        }

        private void mn_vendas_Click(object sender, EventArgs e)
        {
            RelacaoVendas relVenda = new RelacaoVendas();
            relVenda.MdiParent = this;
            relVenda.Show();
        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void posiçãoDoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosicaoEstoque posiEstoque = new PosicaoEstoque();
            posiEstoque.MdiParent = this;
            posiEstoque.Show();
        }

       
    }
}
