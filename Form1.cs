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
            try
            {

                double pesodocorte, pesototaldapeca, porcentproduto, fatorcusto, precovenda, precototalvenda, porcentvenda;


                //PORCENTAGEM PRODUTO

                pesodocorte = Convert.ToDouble(txtCorte.Text);
                pesototaldapeca = Convert.ToDouble(txtTotalPeca.Text);

                porcentproduto = Math.Round(pesodocorte * 100 / pesototaldapeca, 4);
                txtporcentagemproduto.Text = porcentproduto.ToString();

                //FATOR DE CUSTO

                fatorcusto = Math.Round(1 + ((100 - porcentproduto) / 100), 4);
                txtfatorcusto.Text = fatorcusto.ToString();

                //PORCENTAGEM VENDA

                precovenda = Convert.ToDouble(txtPrecoVenda.Text);
                precototalvenda = Convert.ToDouble(txtPrecoTotalVenda.Text);

                porcentvenda = Math.Round((precovenda / precototalvenda)*100,3);
                txtporcentvenda.Text = porcentvenda.ToString();

            }

            catch
            {
                MessageBox.Show("VALORES NAO PODEM FICAR VAZIOS!!!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
