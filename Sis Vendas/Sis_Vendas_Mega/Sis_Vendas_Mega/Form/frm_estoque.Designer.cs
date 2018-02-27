namespace Sis_Vendas_Mega
{
    partial class frm_cad_produto
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
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dg_produto = new System.Windows.Forms.DataGridView();
            this.data_cad = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maxi = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_mini = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_atualizar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_pesquisar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.dg_produto);
            this.groupBox1.Controls.Add(this.data_cad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_maxi);
            this.groupBox1.Controls.Add(this.txt_cod);
            this.groupBox1.Controls.Add(this.txt_mini);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Image = global::Sis_Vendas_Mega.Properties.Resources.sair_32x32;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(746, 435);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 48);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "     Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.Navy;
            this.btn_novo.Image = global::Sis_Vendas_Mega.Properties.Resources.novo;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(321, 435);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 48);
            this.btn_novo.TabIndex = 8;
            this.btn_novo.Text = "      Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.Navy;
            this.btn_atualizar.Image = global::Sis_Vendas_Mega.Properties.Resources.atualizar2;
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atualizar.Location = new System.Drawing.Point(215, 435);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(100, 48);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sis_Vendas_Mega.Properties.Resources.lupa_2;
            this.pictureBox1.Location = new System.Drawing.Point(393, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(18, 28);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(370, 26);
            this.txt_pesquisar.TabIndex = 13;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_editar.Image = global::Sis_Vendas_Mega.Properties.Resources.editar;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(427, 435);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 48);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_excluir.Image = global::Sis_Vendas_Mega.Properties.Resources.lixeira;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(533, 435);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 48);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dg_produto
            // 
            this.dg_produto.AllowUserToAddRows = false;
            this.dg_produto.AllowUserToDeleteRows = false;
            this.dg_produto.BackgroundColor = System.Drawing.Color.White;
            this.dg_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_produto.Location = new System.Drawing.Point(6, 218);
            this.dg_produto.Name = "dg_produto";
            this.dg_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_produto.Size = new System.Drawing.Size(851, 211);
            this.dg_produto.TabIndex = 10;
            this.dg_produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_produto_CellClick);
            // 
            // data_cad
            // 
            this.data_cad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_cad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_cad.Location = new System.Drawing.Point(646, 179);
            this.data_cad.Name = "data_cad";
            this.data_cad.Size = new System.Drawing.Size(200, 26);
            this.data_cad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(642, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Cadastro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(510, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estoque Máximo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(14, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(376, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estoque Mínimo";
            // 
            // txt_maxi
            // 
            this.txt_maxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxi.Location = new System.Drawing.Point(514, 179);
            this.txt_maxi.Name = "txt_maxi";
            this.txt_maxi.Size = new System.Drawing.Size(119, 26);
            this.txt_maxi.TabIndex = 5;
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.Location = new System.Drawing.Point(18, 179);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.ReadOnly = true;
            this.txt_cod.Size = new System.Drawing.Size(119, 26);
            this.txt_cod.TabIndex = 7;
            // 
            // txt_mini
            // 
            this.txt_mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mini.Location = new System.Drawing.Point(380, 179);
            this.txt_mini.Name = "txt_mini";
            this.txt_mini.Size = new System.Drawing.Size(119, 26);
            this.txt_mini.TabIndex = 4;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(265, 179);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 26);
            this.txt_valor.TabIndex = 3;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(150, 179);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 26);
            this.txt_quantidade.TabIndex = 2;
            // 
            // txt_desc
            // 
            this.txt_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(18, 104);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(692, 26);
            this.txt_desc.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Image = global::Sis_Vendas_Mega.Properties.Resources.cancelar;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(639, 435);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 48);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(146, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(270, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição do Produto";
            // 
            // frm_cad_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 516);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_cad_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DateTimePicker data_cad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maxi;
        private System.Windows.Forms.TextBox txt_mini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dg_produto;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;

    }
}