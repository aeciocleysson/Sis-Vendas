namespace Sis_Vendas_Mega
{
    partial class frm_usuario
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
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.dg_usuario = new System.Windows.Forms.DataGridView();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_atualizar);
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_pesquisar);
            this.groupBox1.Controls.Add(this.txt_cod);
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.dg_usuario);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.Navy;
            this.btn_atualizar.Image = global::Sis_Vendas_Mega.Properties.Resources.atualizar2;
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atualizar.Location = new System.Drawing.Point(237, 446);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(100, 48);
            this.btn_atualizar.TabIndex = 20;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Image = global::Sis_Vendas_Mega.Properties.Resources.sair_32x32;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(767, 446);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 48);
            this.btn_sair.TabIndex = 19;
            this.btn_sair.Text = "   Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.Navy;
            this.btn_novo.Image = global::Sis_Vendas_Mega.Properties.Resources.novo;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(343, 446);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 48);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "   Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_editar.Image = global::Sis_Vendas_Mega.Properties.Resources.editar;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(449, 446);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 48);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click_1);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_excluir.Image = global::Sis_Vendas_Mega.Properties.Resources.lixeira;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(555, 446);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 48);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "     Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sis_Vendas_Mega.Properties.Resources.lupa_2;
            this.pictureBox1.Location = new System.Drawing.Point(409, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(35, 28);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(370, 26);
            this.txt_pesquisar.TabIndex = 17;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_cod.Location = new System.Drawing.Point(35, 99);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.ReadOnly = true;
            this.txt_cod.Size = new System.Drawing.Size(119, 26);
            this.txt_cod.TabIndex = 16;
            // 
            // txt_tipo
            // 
            this.txt_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_tipo.Location = new System.Drawing.Point(487, 157);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(245, 26);
            this.txt_tipo.TabIndex = 15;
            // 
            // dg_usuario
            // 
            this.dg_usuario.AllowUserToAddRows = false;
            this.dg_usuario.AllowUserToDeleteRows = false;
            this.dg_usuario.BackgroundColor = System.Drawing.Color.White;
            this.dg_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_usuario.Location = new System.Drawing.Point(32, 205);
            this.dg_usuario.Name = "dg_usuario";
            this.dg_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_usuario.Size = new System.Drawing.Size(820, 215);
            this.dg_usuario.TabIndex = 14;
            this.dg_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usuario_CellClick);
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(175, 99);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(401, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Image = global::Sis_Vendas_Mega.Properties.Resources.cancelar;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(661, 446);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 48);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(261, 157);
            this.txt_senha.MaxLength = 20;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(220, 26);
            this.txt_senha.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(483, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo  de Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(31, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(171, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(31, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login *";
            // 
            // txt_login
            // 
            this.txt_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(35, 157);
            this.txt_login.MaxLength = 20;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(220, 26);
            this.txt_login.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(257, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha *";
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 524);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_usuario;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;

    }
}