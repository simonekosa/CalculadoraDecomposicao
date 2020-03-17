using System;
using System.Windows.Forms;

namespace Decomposicao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            //PORCENTAGEM PRODUTO

            double pesodocorte, pesototaldapeca, porcentproduto, fatorcusto, precovenda, precototalvenda, porcentvenda;

            if (string.IsNullOrEmpty(txtCorte.Text))
            {
                MessageBox.Show("Campo corte é obrigatório!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorte.Focus();
                return;

            }

            if (string.IsNullOrEmpty(txtTotalPeca.Text))
            {
                MessageBox.Show("Campo Total da Peca é obrigatório!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPeca.Focus();
                return;

            }

            try
            {
                pesodocorte = Convert.ToDouble(txtCorte.Text);
                pesototaldapeca = Convert.ToDouble(txtTotalPeca.Text);

                porcentproduto = Math.Round(pesodocorte * 100 / pesototaldapeca, 4);
                txtporcentagemproduto.Text = porcentproduto.ToString();
            }

            catch
            {
                MessageBox.Show("Favor Verificar dados informados!! Letras ou simbolos não são aceitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            


            //FATOR DE CUSTO

            if (string.IsNullOrEmpty(txtCorte.Text))
            {
                MessageBox.Show("Campo Peso Corte é obrigatório!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorte.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTotalPeca.Text))
            {
                MessageBox.Show("Campo Peso total da peça é obrigatório!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPeca.Focus();
                return;
            }

            try
            {
                fatorcusto = Math.Round(1 + ((100 - porcentproduto) / 100), 4);
                txtfatorcusto.Text = fatorcusto.ToString();
            }

            catch
            {
                MessageBox.Show("Favor Verificar dados informados!! Letras ou simbolos não são aceitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            //PORCENTAGEM VENDA

            if (string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                MessageBox.Show("Campo Preco de Venda é obrigatório!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPrecoTotalVenda.Text))
            {
                MessageBox.Show("Campo Preco Total de Venda é obrigatório!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoTotalVenda.Focus();
                return;
            }

            try
            {
                precovenda = Convert.ToDouble(txtPrecoVenda.Text);
                precototalvenda = Convert.ToDouble(txtPrecoTotalVenda.Text);

                porcentvenda = Math.Round((precovenda / precototalvenda) * 100, 3);
                txtporcentvenda.Text = porcentvenda.ToString();
            }

            catch
            {
                MessageBox.Show("Favor Verificar dados informados!! Letras ou simbolos não são aceitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }





    }
}

