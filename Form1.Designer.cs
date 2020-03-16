namespace Decomposicao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorte = new System.Windows.Forms.TextBox();
            this.txtTotalPeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtporcentagemproduto = new System.Windows.Forms.TextBox();
            this.txtfatorcusto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtporcentvenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtPrecoTotalVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso do Corte";
            // 
            // txtCorte
            // 
            this.txtCorte.Location = new System.Drawing.Point(25, 32);
            this.txtCorte.Name = "txtCorte";
            this.txtCorte.Size = new System.Drawing.Size(100, 20);
            this.txtCorte.TabIndex = 1;
            // 
            // txtTotalPeca
            // 
            this.txtTotalPeca.Location = new System.Drawing.Point(149, 32);
            this.txtTotalPeca.Name = "txtTotalPeca";
            this.txtTotalPeca.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPeca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso Total da Peca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "% Produto";
            // 
            // txtporcentagemproduto
            // 
            this.txtporcentagemproduto.Location = new System.Drawing.Point(25, 32);
            this.txtporcentagemproduto.Name = "txtporcentagemproduto";
            this.txtporcentagemproduto.Size = new System.Drawing.Size(100, 20);
            this.txtporcentagemproduto.TabIndex = 5;
            // 
            // txtfatorcusto
            // 
            this.txtfatorcusto.Location = new System.Drawing.Point(25, 84);
            this.txtfatorcusto.Name = "txtfatorcusto";
            this.txtfatorcusto.Size = new System.Drawing.Size(100, 20);
            this.txtfatorcusto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fator de Custo";
            // 
            // txtporcentvenda
            // 
            this.txtporcentvenda.Location = new System.Drawing.Point(25, 137);
            this.txtporcentvenda.Name = "txtporcentvenda";
            this.txtporcentvenda.Size = new System.Drawing.Size(100, 20);
            this.txtporcentvenda.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(22, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "% Venda";
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(103, 79);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calculadora";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtporcentagemproduto);
            this.panel1.Controls.Add(this.txtporcentvenda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtfatorcusto);
            this.panel1.Location = new System.Drawing.Point(271, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 205);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 179);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtPrecoVenda);
            this.panel3.Controls.Add(this.txtPrecoTotalVenda);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Controls.Add(this.txtCorte);
            this.panel3.Controls.Add(this.txtTotalPeca);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 204);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(22, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço de Venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(25, 137);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda.TabIndex = 12;
            // 
            // txtPrecoTotalVenda
            // 
            this.txtPrecoTotalVenda.Location = new System.Drawing.Point(149, 137);
            this.txtPrecoTotalVenda.Name = "txtPrecoTotalVenda";
            this.txtPrecoTotalVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoTotalVenda.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(146, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Peso Total Venda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(566, 179);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Decomposicao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorte;
        private System.Windows.Forms.TextBox txtTotalPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtporcentagemproduto;
        private System.Windows.Forms.TextBox txtfatorcusto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtporcentvenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoTotalVenda;
        private System.Windows.Forms.Label label7;
    }
}

