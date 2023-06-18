namespace Controle_G_
{
    partial class Frm_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.dt_grid = new System.Windows.Forms.DataGridView();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigoAlterar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricaoAlterar = new System.Windows.Forms.RichTextBox();
            this.txt_qtdAlterar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vlrAlterar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_alterarok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tool_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_sair = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_descricao.Location = new System.Drawing.Point(168, 35);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 13);
            this.lbl_descricao.TabIndex = 0;
            this.lbl_descricao.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(232, 32);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(276, 20);
            this.txt_descricao.TabIndex = 2;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(584, 32);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(54, 20);
            this.txt_qtd.TabIndex = 3;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_quantidade.Location = new System.Drawing.Point(516, 35);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(65, 13);
            this.lbl_quantidade.TabIndex = 2;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_valor.Location = new System.Drawing.Point(648, 35);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_valor.TabIndex = 4;
            this.lbl_valor.Text = "Valor:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(685, 32);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(67, 20);
            this.txt_valor.TabIndex = 4;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(84, 121);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(74, 50);
            this.btn_novo.TabIndex = 7;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(5, 121);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(74, 50);
            this.btn_consultar.TabIndex = 7;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(5, 65);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(74, 50);
            this.btn_exibir.TabIndex = 7;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(84, 65);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(74, 50);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(13, 228);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(146, 26);
            this.btn_alterar.TabIndex = 9;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // dt_grid
            // 
            this.dt_grid.AllowUserToAddRows = false;
            this.dt_grid.AllowUserToDeleteRows = false;
            this.dt_grid.AllowUserToResizeColumns = false;
            this.dt_grid.AllowUserToResizeRows = false;
            this.dt_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_grid.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dt_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_grid.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dt_grid.Location = new System.Drawing.Point(171, 65);
            this.dt_grid.Name = "dt_grid";
            this.dt_grid.Size = new System.Drawing.Size(579, 380);
            this.dt_grid.TabIndex = 11;
            this.dt_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_grid_CellContentClick);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(55, 32);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(103, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Location = new System.Drawing.Point(9, 35);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 20;
            this.lbl_codigo.Text = "Codigo";
            // 
            // txt_codigoAlterar
            // 
            this.txt_codigoAlterar.Location = new System.Drawing.Point(56, 202);
            this.txt_codigoAlterar.Name = "txt_codigoAlterar";
            this.txt_codigoAlterar.Size = new System.Drawing.Size(103, 20);
            this.txt_codigoAlterar.TabIndex = 21;
            this.txt_codigoAlterar.TextChanged += new System.EventHandler(this.txt_codigoAlterar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo";
            // 
            // txt_descricaoAlterar
            // 
            this.txt_descricaoAlterar.Location = new System.Drawing.Point(13, 260);
            this.txt_descricaoAlterar.Name = "txt_descricaoAlterar";
            this.txt_descricaoAlterar.Size = new System.Drawing.Size(146, 72);
            this.txt_descricaoAlterar.TabIndex = 23;
            this.txt_descricaoAlterar.Text = "";
            this.txt_descricaoAlterar.TextChanged += new System.EventHandler(this.txt_descricaoAlterar_TextChanged);
            // 
            // txt_qtdAlterar
            // 
            this.txt_qtdAlterar.Location = new System.Drawing.Point(92, 341);
            this.txt_qtdAlterar.Name = "txt_qtdAlterar";
            this.txt_qtdAlterar.Size = new System.Drawing.Size(67, 20);
            this.txt_qtdAlterar.TabIndex = 25;
            this.txt_qtdAlterar.TextChanged += new System.EventHandler(this.txt_qtdAlterar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantidade:";
            // 
            // txt_vlrAlterar
            // 
            this.txt_vlrAlterar.Location = new System.Drawing.Point(92, 367);
            this.txt_vlrAlterar.Name = "txt_vlrAlterar";
            this.txt_vlrAlterar.Size = new System.Drawing.Size(67, 20);
            this.txt_vlrAlterar.TabIndex = 26;
            this.txt_vlrAlterar.TextChanged += new System.EventHandler(this.txt_vlrAlterar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Valor:";
            // 
            // btn_alterarok
            // 
            this.btn_alterarok.Location = new System.Drawing.Point(13, 393);
            this.btn_alterarok.Name = "btn_alterarok";
            this.btn_alterarok.Size = new System.Drawing.Size(146, 36);
            this.btn_alterarok.TabIndex = 28;
            this.btn_alterarok.Text = "Confirmar";
            this.btn_alterarok.UseVisualStyleBackColor = true;
            this.btn_alterarok.Click += new System.EventHandler(this.btn_alterarok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 259);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tool_menu
            // 
            this.tool_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_sair});
            this.tool_menu.Name = "tool_menu";
            this.tool_menu.Size = new System.Drawing.Size(50, 20);
            this.tool_menu.Text = "Menu";
            // 
            // tool_sair
            // 
            this.tool_sair.Name = "tool_sair";
            this.tool_sair.Size = new System.Drawing.Size(180, 22);
            this.tool_sair.Text = "Sair";
            this.tool_sair.Click += new System.EventHandler(this.tool_sair_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(762, 454);
            this.Controls.Add(this.btn_alterarok);
            this.Controls.Add(this.txt_vlrAlterar);
            this.Controls.Add(this.txt_qtdAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricaoAlterar);
            this.Controls.Add(this.txt_codigoAlterar);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.dt_grid);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GhControl";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridView dt_grid;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigoAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_descricaoAlterar;
        private System.Windows.Forms.TextBox txt_qtdAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vlrAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_alterarok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tool_menu;
        private System.Windows.Forms.ToolStripMenuItem tool_sair;
    }
}

