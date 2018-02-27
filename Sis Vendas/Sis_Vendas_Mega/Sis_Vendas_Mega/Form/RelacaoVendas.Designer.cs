namespace Sis_Vendas_Mega
{
    partial class RelacaoVendas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.dg_venda = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.dg_venda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 637);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sis_Vendas_Mega.Properties.Resources.lupa_2;
            this.pictureBox1.Location = new System.Drawing.Point(386, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txt_cliente
            // 
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(6, 46);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(374, 26);
            this.txt_cliente.TabIndex = 2;
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Location = new System.Drawing.Point(758, 556);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(98, 48);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // dg_venda
            // 
            this.dg_venda.BackgroundColor = System.Drawing.Color.White;
            this.dg_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_venda.Location = new System.Drawing.Point(6, 78);
            this.dg_venda.Name = "dg_venda";
            this.dg_venda.Size = new System.Drawing.Size(859, 456);
            this.dg_venda.TabIndex = 0;
            // 
            // RelacaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 661);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "RelacaoVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relacao de Vendas";
            this.Load += new System.EventHandler(this.RelacaoVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_venda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_venda;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}