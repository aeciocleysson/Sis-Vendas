namespace Sis_Vendas_Mega
{
    partial class frm_cliente
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
            this.mtb_cel = new System.Windows.Forms.MaskedTextBox();
            this.mtb_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.mtb_cel);
            this.groupBox1.Controls.Add(this.mtb_tel);
            this.groupBox1.Controls.Add(this.txt_end);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mtb_cel
            // 
            this.mtb_cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cel.Location = new System.Drawing.Point(200, 142);
            this.mtb_cel.Mask = "(00) 00000-0000";
            this.mtb_cel.Name = "mtb_cel";
            this.mtb_cel.Size = new System.Drawing.Size(181, 26);
            this.mtb_cel.TabIndex = 4;
            this.mtb_cel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb_tel
            // 
            this.mtb_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_tel.Location = new System.Drawing.Point(13, 142);
            this.mtb_tel.Mask = "(00) 0000-0000";
            this.mtb_tel.Name = "mtb_tel";
            this.mtb_tel.Size = new System.Drawing.Size(181, 26);
            this.mtb_tel.TabIndex = 3;
            this.mtb_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_end
            // 
            this.txt_end.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_end.Location = new System.Drawing.Point(13, 90);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(630, 26);
            this.txt_end.TabIndex = 2;
            // 
            // txt_cliente
            // 
            this.txt_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(13, 37);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(401, 26);
            this.txt_cliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(196, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.Navy;
            this.btn_cadastrar.Image = global::Sis_Vendas_Mega.Properties.Resources.salvar;
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(398, 190);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(100, 48);
            this.btn_cadastrar.TabIndex = 5;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Image = global::Sis_Vendas_Mega.Properties.Resources.cancelar;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(504, 190);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 48);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Image = global::Sis_Vendas_Mega.Properties.Resources.sair_32x32;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(610, 190);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 48);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "     Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 268);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.MaskedTextBox mtb_cel;
        private System.Windows.Forms.MaskedTextBox mtb_tel;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}