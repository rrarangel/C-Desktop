namespace ViewProject
{
    partial class FormNotaEntrada
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDNotaEntrada = new System.Windows.Forms.TextBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGravarNota = new System.Windows.Forms.Button();
            this.btnNovoNota = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoverNota = new System.Windows.Forms.Button();
            this.btnCancelarNota = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNotasEntrada = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68085F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31915F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produtos comprados";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corpo da nota";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtIDNotaEntrada, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxFornecedor, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNumero, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpEmissao, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dtpEntrada, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 525);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fornecedor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Número";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Emissão";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Entrada";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIDNotaEntrada
            // 
            this.txtIDNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDNotaEntrada.Enabled = false;
            this.txtIDNotaEntrada.Location = new System.Drawing.Point(228, 27);
            this.txtIDNotaEntrada.Name = "txtIDNotaEntrada";
            this.txtIDNotaEntrada.ReadOnly = true;
            this.txtIDNotaEntrada.Size = new System.Drawing.Size(200, 20);
            this.txtIDNotaEntrada.TabIndex = 5;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFornecedor.DisplayMember = "Nome";
            this.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(228, 56);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(200, 21);
            this.cbxFornecedor.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumero.Location = new System.Drawing.Point(228, 85);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(228, 114);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(200, 20);
            this.dtpEmissao.TabIndex = 8;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(228, 142);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrada.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnGravarNota, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNovoNota, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 169);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(219, 28);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // btnGravarNota
            // 
            this.btnGravarNota.Location = new System.Drawing.Point(112, 3);
            this.btnGravarNota.Name = "btnGravarNota";
            this.btnGravarNota.Size = new System.Drawing.Size(103, 22);
            this.btnGravarNota.TabIndex = 1;
            this.btnGravarNota.Text = "Gravar";
            this.btnGravarNota.UseVisualStyleBackColor = true;
            this.btnGravarNota.Click += new System.EventHandler(this.btnGravarNota_Click);
            // 
            // btnNovoNota
            // 
            this.btnNovoNota.Location = new System.Drawing.Point(3, 3);
            this.btnNovoNota.Name = "btnNovoNota";
            this.btnNovoNota.Size = new System.Drawing.Size(103, 22);
            this.btnNovoNota.TabIndex = 0;
            this.btnNovoNota.Text = "Novo";
            this.btnNovoNota.UseVisualStyleBackColor = true;
            this.btnNovoNota.Click += new System.EventHandler(this.btnNovoNota_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnRemoverNota, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCancelarNota, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(228, 169);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(219, 28);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // btnRemoverNota
            // 
            this.btnRemoverNota.Location = new System.Drawing.Point(112, 3);
            this.btnRemoverNota.Name = "btnRemoverNota";
            this.btnRemoverNota.Size = new System.Drawing.Size(103, 22);
            this.btnRemoverNota.TabIndex = 2;
            this.btnRemoverNota.Text = "Remover";
            this.btnRemoverNota.UseVisualStyleBackColor = true;
            this.btnRemoverNota.Click += new System.EventHandler(this.btnRemoverNota_Click);
            // 
            // btnCancelarNota
            // 
            this.btnCancelarNota.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarNota.Name = "btnCancelarNota";
            this.btnCancelarNota.Size = new System.Drawing.Size(103, 22);
            this.btnCancelarNota.TabIndex = 1;
            this.btnCancelarNota.Text = "Cancelar";
            this.btnCancelarNota.UseVisualStyleBackColor = true;
            this.btnCancelarNota.Click += new System.EventHandler(this.btnCancelarNota_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.dgvNotasEntrada, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(444, 319);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // dgvNotasEntrada
            // 
            this.dgvNotasEntrada.AllowUserToAddRows = false;
            this.dgvNotasEntrada.AllowUserToDeleteRows = false;
            this.dgvNotasEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotasEntrada.Location = new System.Drawing.Point(3, 3);
            this.dgvNotasEntrada.Name = "dgvNotasEntrada";
            this.dgvNotasEntrada.ReadOnly = true;
            this.dgvNotasEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasEntrada.Size = new System.Drawing.Size(438, 313);
            this.dgvNotasEntrada.TabIndex = 0;
            this.dgvNotasEntrada.SelectionChanged += new System.EventHandler(this.dgvNotasEntrada_SelectionChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbxProduto, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(469, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.92966F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 525);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.dgvProdutos, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 201);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(458, 321);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 3);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(452, 315);
            this.dgvProdutos.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Id";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Produto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Custo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Quantidade";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 169);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(226, 26);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(235, 169);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(226, 26);
            this.tableLayoutPanel9.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 20);
            this.button4.TabIndex = 2;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Location = new System.Drawing.Point(235, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 7;
            // 
            // cbxProduto
            // 
            this.cbxProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxProduto.DisplayMember = "Descricao";
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(235, 55);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(200, 21);
            this.cbxProduto.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.Location = new System.Drawing.Point(235, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.Location = new System.Drawing.Point(235, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 20);
            this.textBox5.TabIndex = 10;
            // 
            // FormNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormNotaEntrada";
            this.Text = "FormNotaEntrada";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDNotaEntrada;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnGravarNota;
        private System.Windows.Forms.Button btnNovoNota;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnRemoverNota;
        private System.Windows.Forms.Button btnCancelarNota;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvNotasEntrada;
    }
}