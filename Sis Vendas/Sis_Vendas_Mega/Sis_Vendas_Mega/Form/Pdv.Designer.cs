namespace Sis_Vendas_Mega
{
    partial class frm_pdv
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
            this.btn_cont_venda = new System.Windows.Forms.Button();
            this.btn_abrir_venda = new System.Windows.Forms.Button();
            this.txt_cod_venda = new System.Windows.Forms.TextBox();
            this.txt_id_usuario = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_total_venda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_efet_venda = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_produto = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.dg_venda = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_cod_prod = new System.Windows.Forms.TextBox();
            this.txt_nome_cli = new System.Windows.Forms.TextBox();
            this.txt_cod_cli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cont_venda);
            this.groupBox1.Controls.Add(this.btn_abrir_venda);
            this.groupBox1.Controls.Add(this.txt_cod_venda);
            this.groupBox1.Controls.Add(this.txt_id_usuario);
            this.groupBox1.Controls.Add(this.txt_vendedor);
            this.groupBox1.Controls.Add(this.lbl_data);
            this.groupBox1.Controls.Add(this.txt_total_venda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.btn_efet_venda);
            this.groupBox1.Controls.Add(this.btn_deletar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_produto);
            this.groupBox1.Controls.Add(this.btn_cliente);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_incluir);
            this.groupBox1.Controls.Add(this.dg_venda);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(this.txt_preco);
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.txt_cod_prod);
            this.groupBox1.Controls.Add(this.txt_nome_cli);
            this.groupBox1.Controls.Add(this.txt_cod_cli);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 611);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponto de Venda ";
            // 
            // btn_cont_venda
            // 
            this.btn_cont_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cont_venda.ForeColor = System.Drawing.Color.Navy;
            this.btn_cont_venda.Location = new System.Drawing.Point(6, 545);
            this.btn_cont_venda.Name = "btn_cont_venda";
            this.btn_cont_venda.Size = new System.Drawing.Size(92, 48);
            this.btn_cont_venda.TabIndex = 23;
            this.btn_cont_venda.Text = "Continuar Venda";
            this.btn_cont_venda.UseVisualStyleBackColor = true;
            this.btn_cont_venda.Click += new System.EventHandler(this.btn_cont_venda_Click);
            // 
            // btn_abrir_venda
            // 
            this.btn_abrir_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_venda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_abrir_venda.Location = new System.Drawing.Point(417, 112);
            this.btn_abrir_venda.Name = "btn_abrir_venda";
            this.btn_abrir_venda.Size = new System.Drawing.Size(92, 48);
            this.btn_abrir_venda.TabIndex = 22;
            this.btn_abrir_venda.Text = "Abrir Venda";
            this.btn_abrir_venda.UseVisualStyleBackColor = true;
            this.btn_abrir_venda.Click += new System.EventHandler(this.btn_abrir_venda_Click);
            // 
            // txt_cod_venda
            // 
            this.txt_cod_venda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cod_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_venda.Location = new System.Drawing.Point(538, 62);
            this.txt_cod_venda.Name = "txt_cod_venda";
            this.txt_cod_venda.ReadOnly = true;
            this.txt_cod_venda.Size = new System.Drawing.Size(68, 26);
            this.txt_cod_venda.TabIndex = 21;
            this.txt_cod_venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.Location = new System.Drawing.Point(538, 32);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.ReadOnly = true;
            this.txt_id_usuario.Size = new System.Drawing.Size(42, 26);
            this.txt_id_usuario.TabIndex = 21;
            this.txt_id_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendedor.ForeColor = System.Drawing.Color.Maroon;
            this.txt_vendedor.Location = new System.Drawing.Point(151, 32);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.ReadOnly = true;
            this.txt_vendedor.Size = new System.Drawing.Size(218, 26);
            this.txt_vendedor.TabIndex = 20;
            this.txt_vendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_data.Location = new System.Drawing.Point(825, 32);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(35, 16);
            this.lbl_data.TabIndex = 19;
            this.lbl_data.Text = "data";
            // 
            // txt_total_venda
            // 
            this.txt_total_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_total_venda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_venda.ForeColor = System.Drawing.Color.Green;
            this.txt_total_venda.Location = new System.Drawing.Point(789, 561);
            this.txt_total_venda.Name = "txt_total_venda";
            this.txt_total_venda.ReadOnly = true;
            this.txt_total_venda.Size = new System.Drawing.Size(100, 24);
            this.txt_total_venda.TabIndex = 18;
            this.txt_total_venda.TextChanged += new System.EventHandler(this.txt_total_venda_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(728, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total:";
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Image = global::Sis_Vendas_Mega.Properties.Resources.sair_32x32;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(632, 545);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(92, 48);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "     Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_efet_venda
            // 
            this.btn_efet_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_efet_venda.ForeColor = System.Drawing.Color.Navy;
            this.btn_efet_venda.Image = global::Sis_Vendas_Mega.Properties.Resources.money;
            this.btn_efet_venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_efet_venda.Location = new System.Drawing.Point(496, 545);
            this.btn_efet_venda.Name = "btn_efet_venda";
            this.btn_efet_venda.Size = new System.Drawing.Size(130, 48);
            this.btn_efet_venda.TabIndex = 14;
            this.btn_efet_venda.Text = "Efetuar Venda";
            this.btn_efet_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_efet_venda.UseVisualStyleBackColor = true;
            this.btn_efet_venda.Click += new System.EventHandler(this.btn_efet_venda_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.Navy;
            this.btn_deletar.Image = global::Sis_Vendas_Mega.Properties.Resources.lixeira;
            this.btn_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletar.Location = new System.Drawing.Point(398, 545);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(92, 48);
            this.btn_deletar.TabIndex = 13;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.Navy;
            this.btn_novo.Image = global::Sis_Vendas_Mega.Properties.Resources.novo;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(300, 545);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(92, 48);
            this.btn_novo.TabIndex = 12;
            this.btn_novo.Text = "     Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_produto
            // 
            this.btn_produto.Enabled = false;
            this.btn_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.ForeColor = System.Drawing.Color.Navy;
            this.btn_produto.Image = global::Sis_Vendas_Mega.Properties.Resources.produto;
            this.btn_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produto.Location = new System.Drawing.Point(202, 545);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(92, 48);
            this.btn_produto.TabIndex = 11;
            this.btn_produto.Text = "Produto";
            this.btn_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_produto.UseVisualStyleBackColor = true;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.Navy;
            this.btn_cliente.Image = global::Sis_Vendas_Mega.Properties.Resources.cliente;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(104, 545);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(92, 48);
            this.btn_cliente.TabIndex = 10;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Sis_Vendas_Mega.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(665, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 110);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_incluir.Image = global::Sis_Vendas_Mega.Properties.Resources.cesta;
            this.btn_incluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_incluir.Location = new System.Drawing.Point(799, 181);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(80, 33);
            this.btn_incluir.TabIndex = 9;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            this.btn_incluir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_incluir_KeyPress);
            // 
            // dg_venda
            // 
            this.dg_venda.AllowUserToDeleteRows = false;
            this.dg_venda.BackgroundColor = System.Drawing.Color.White;
            this.dg_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_descricao,
            this.col_preco,
            this.col_quanti,
            this.col_total});
            this.dg_venda.Location = new System.Drawing.Point(6, 219);
            this.dg_venda.Name = "dg_venda";
            this.dg_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_venda.Size = new System.Drawing.Size(889, 310);
            this.dg_venda.TabIndex = 2;
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.Name = "col_codigo";
            // 
            // col_descricao
            // 
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 400;
            // 
            // col_preco
            // 
            this.col_preco.HeaderText = "Preço";
            this.col_preco.Name = "col_preco";
            this.col_preco.Width = 110;
            // 
            // col_quanti
            // 
            this.col_quanti.HeaderText = "Quantidade";
            this.col_quanti.Name = "col_quanti";
            this.col_quanti.Width = 110;
            // 
            // col_total
            // 
            this.col_total.HeaderText = "Total";
            this.col_total.Name = "col_total";
            this.col_total.Width = 120;
            // 
            // txt_valor
            // 
            this.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(665, 188);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(121, 26);
            this.txt_valor.TabIndex = 8;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.ForeColor = System.Drawing.Color.Green;
            this.txt_quantidade.Location = new System.Drawing.Point(525, 188);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(121, 26);
            this.txt_quantidade.TabIndex = 7;
            this.txt_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantidade_KeyPress);
            this.txt_quantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txt_quantidade_Validating);
            // 
            // txt_preco
            // 
            this.txt_preco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.ForeColor = System.Drawing.Color.Teal;
            this.txt_preco.Location = new System.Drawing.Point(388, 188);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.ReadOnly = true;
            this.txt_preco.Size = new System.Drawing.Size(121, 26);
            this.txt_preco.TabIndex = 6;
            this.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_preco.TextChanged += new System.EventHandler(this.txt_preco_TextChanged);
            // 
            // txt_descricao
            // 
            this.txt_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(134, 188);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ReadOnly = true;
            this.txt_descricao.Size = new System.Drawing.Size(235, 26);
            this.txt_descricao.TabIndex = 5;
            // 
            // txt_cod_prod
            // 
            this.txt_cod_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cod_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_prod.Location = new System.Drawing.Point(21, 188);
            this.txt_cod_prod.Name = "txt_cod_prod";
            this.txt_cod_prod.Size = new System.Drawing.Size(102, 26);
            this.txt_cod_prod.TabIndex = 4;
            this.txt_cod_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cod_prod.DoubleClick += new System.EventHandler(this.txt_cod_prod_DoubleClick);
            // 
            // txt_nome_cli
            // 
            this.txt_nome_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cli.Location = new System.Drawing.Point(151, 124);
            this.txt_nome_cli.Name = "txt_nome_cli";
            this.txt_nome_cli.ReadOnly = true;
            this.txt_nome_cli.Size = new System.Drawing.Size(259, 26);
            this.txt_nome_cli.TabIndex = 3;
            // 
            // txt_cod_cli
            // 
            this.txt_cod_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cod_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_cli.Location = new System.Drawing.Point(151, 81);
            this.txt_cod_cli.Name = "txt_cod_cli";
            this.txt_cod_cli.ReadOnly = true;
            this.txt_cod_cli.Size = new System.Drawing.Size(95, 26);
            this.txt_cod_cli.TabIndex = 2;
            this.txt_cod_cli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(699, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(534, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(423, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(209, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cód. Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cód Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(394, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cód Venda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(394, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cód Vendedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor:";
            // 
            // frm_pdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 635);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_pdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.Load += new System.EventHandler(this.frm_pdv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_venda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_cod_prod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_efet_venda;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.DataGridView dg_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quanti;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        public System.Windows.Forms.TextBox txt_cod_cli;
        public System.Windows.Forms.TextBox txt_nome_cli;
        private System.Windows.Forms.TextBox txt_total_venda;
        private System.Windows.Forms.Label lbl_data;
        public System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.TextBox txt_id_usuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_cod_venda;
        private System.Windows.Forms.Button btn_abrir_venda;
        private System.Windows.Forms.Button btn_cont_venda;
    }
}