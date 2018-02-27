namespace Sis_Vendas_Mega
{
    partial class frm_cad_cli
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
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.dg_cliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_selecionar);
            this.groupBox1.Controls.Add(this.btn_atualizar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_pesquisar);
            this.groupBox1.Controls.Add(this.dg_cliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 432);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionar.ForeColor = System.Drawing.Color.Navy;
            this.btn_selecionar.Image = global::Sis_Vendas_Mega.Properties.Resources.selecionar;
            this.btn_selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_selecionar.Location = new System.Drawing.Point(420, 378);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(100, 48);
            this.btn_selecionar.TabIndex = 19;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.Navy;
            this.btn_atualizar.Image = global::Sis_Vendas_Mega.Properties.Resources.atualizar;
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atualizar.Location = new System.Drawing.Point(526, 378);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(100, 48);
            this.btn_atualizar.TabIndex = 18;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.Navy;
            this.btn_novo.Image = global::Sis_Vendas_Mega.Properties.Resources.novo;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(632, 378);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 48);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.Text = "     Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Image = global::Sis_Vendas_Mega.Properties.Resources.sair_32x32;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(738, 378);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 48);
            this.btn_sair.TabIndex = 16;
            this.btn_sair.Text = "     Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sis_Vendas_Mega.Properties.Resources.lupa_2;
            this.pictureBox1.Location = new System.Drawing.Point(379, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(6, 19);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(370, 26);
            this.txt_pesquisar.TabIndex = 1;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // dg_cliente
            // 
            this.dg_cliente.AllowUserToAddRows = false;
            this.dg_cliente.AllowUserToDeleteRows = false;
            this.dg_cliente.BackgroundColor = System.Drawing.Color.White;
            this.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cliente.Location = new System.Drawing.Point(6, 52);
            this.dg_cliente.Name = "dg_cliente";
            this.dg_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cliente.Size = new System.Drawing.Size(833, 320);
            this.dg_cliente.TabIndex = 7;
            // 
            // frm_cad_cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 456);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cad_cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.frm_cad_cli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_atualizar;
        public System.Windows.Forms.DataGridView dg_cliente;
        private System.Windows.Forms.Button btn_selecionar;
    }
}