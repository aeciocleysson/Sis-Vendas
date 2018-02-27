namespace Sis_Vendas_Mega
{
    partial class frm_manu_cliente
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_cel = new System.Windows.Forms.MaskedTextBox();
            this.mtb_tel = new System.Windows.Forms.MaskedTextBox();
            this.dg_cliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtb_cel);
            this.groupBox1.Controls.Add(this.mtb_tel);
            this.groupBox1.Controls.Add(this.dg_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_end);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_pesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_cod
            // 
            this.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_cod.Location = new System.Drawing.Point(33, 97);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.ReadOnly = true;
            this.txt_cod.Size = new System.Drawing.Size(119, 26);
            this.txt_cod.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(29, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Código";
            // 
            // mtb_cel
            // 
            this.mtb_cel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cel.Location = new System.Drawing.Point(220, 219);
            this.mtb_cel.Mask = "(00) 00000-0000";
            this.mtb_cel.Name = "mtb_cel";
            this.mtb_cel.Size = new System.Drawing.Size(181, 26);
            this.mtb_cel.TabIndex = 18;
            this.mtb_cel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb_tel
            // 
            this.mtb_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_tel.Location = new System.Drawing.Point(33, 219);
            this.mtb_tel.Mask = "(00) 0000-0000";
            this.mtb_tel.Name = "mtb_tel";
            this.mtb_tel.Size = new System.Drawing.Size(181, 26);
            this.mtb_tel.TabIndex = 17;
            this.mtb_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dg_cliente
            // 
            this.dg_cliente.AllowUserToAddRows = false;
            this.dg_cliente.AllowUserToDeleteRows = false;
            this.dg_cliente.BackgroundColor = System.Drawing.Color.White;
            this.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cliente.Location = new System.Drawing.Point(12, 260);
            this.dg_cliente.Name = "dg_cliente";
            this.dg_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cliente.Size = new System.Drawing.Size(861, 215);
            this.dg_cliente.TabIndex = 22;
            this.dg_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cliente_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(216, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Celular";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Image = global::Sis_Vendas_Mega.Properties.Resources.atualizar2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(343, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 21;
            this.button4.Text = "Atualizar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(29, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefone";
            // 
            // txt_end
            // 
            this.txt_end.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_end.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_end.Location = new System.Drawing.Point(31, 157);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(630, 26);
            this.txt_end.TabIndex = 16;
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_editar.Image = global::Sis_Vendas_Mega.Properties.Resources.editar;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(449, 481);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 48);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Endereço";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(158, 97);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(401, 26);
            this.txt_cliente.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Image = global::Sis_Vendas_Mega.Properties.Resources.sair_32x32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(767, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 48);
            this.button5.TabIndex = 21;
            this.button5.Text = "     Sair";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Image = global::Sis_Vendas_Mega.Properties.Resources.cancelar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(661, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_excluir.Image = global::Sis_Vendas_Mega.Properties.Resources.lixeira;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(555, 481);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 48);
            this.btn_excluir.TabIndex = 21;
            this.btn_excluir.Text = "     Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(154, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sis_Vendas_Mega.Properties.Resources.lupa_2;
            this.pictureBox1.Location = new System.Drawing.Point(405, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(31, 28);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(370, 26);
            this.txt_pesquisar.TabIndex = 19;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // frm_manu_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 559);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_manu_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dg_cliente;
        private System.Windows.Forms.MaskedTextBox mtb_cel;
        private System.Windows.Forms.MaskedTextBox mtb_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label5;
    }
}