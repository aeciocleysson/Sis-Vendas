namespace Sis_Vendas_Mega
{
    partial class PosicaoEstoque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_produto = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dg_posicao = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_posicao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dg_produto);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.dg_posicao);
            this.groupBox1.Controls.Add(this.txt_pesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 684);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Location = new System.Drawing.Point(945, 613);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 48);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(828, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produtos em Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o código do Produto da Tabela ao lado";
            // 
            // dg_produto
            // 
            this.dg_produto.AllowUserToAddRows = false;
            this.dg_produto.AllowUserToDeleteRows = false;
            this.dg_produto.BackgroundColor = System.Drawing.Color.White;
            this.dg_produto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_produto.Location = new System.Drawing.Point(761, 99);
            this.dg_produto.Name = "dg_produto";
            this.dg_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_produto.Size = new System.Drawing.Size(284, 484);
            this.dg_produto.TabIndex = 3;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.Navy;
            this.btn_pesquisar.Location = new System.Drawing.Point(418, 40);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 37);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // dg_posicao
            // 
            this.dg_posicao.AllowUserToAddRows = false;
            this.dg_posicao.AllowUserToDeleteRows = false;
            this.dg_posicao.BackgroundColor = System.Drawing.Color.White;
            this.dg_posicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_posicao.Location = new System.Drawing.Point(6, 99);
            this.dg_posicao.Name = "dg_posicao";
            this.dg_posicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_posicao.Size = new System.Drawing.Size(749, 484);
            this.dg_posicao.TabIndex = 1;
            this.dg_posicao.DoubleClick += new System.EventHandler(this.dg_posicao_DoubleClick);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(333, 45);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(79, 26);
            this.txt_pesquisar.TabIndex = 0;
            this.txt_pesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisar_KeyPress);
            // 
            // PosicaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 708);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PosicaoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PosicaoEstoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_posicao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_posicao;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dg_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label2;
    }
}