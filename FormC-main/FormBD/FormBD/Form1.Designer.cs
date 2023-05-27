namespace FormBD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSexo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBairro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCEP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrabalho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTelefoneFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControleSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcessoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTelefoneLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTelefoneFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompraProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParcelaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSituacao = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.pessoasToolStripMenuItem,
            this.dadosToolStripMenuItem,
            this.lojaToolStripMenuItem1,
            this.mnuFornecedor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCliente,
            this.mnuFuncionarios});
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // mnuCliente
            // 
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(180, 22);
            this.mnuCliente.Text = "Cliente";
            this.mnuCliente.Click += new System.EventHandler(this.mnuCliente_Click);
            // 
            // mnuFuncionarios
            // 
            this.mnuFuncionarios.Name = "mnuFuncionarios";
            this.mnuFuncionarios.Size = new System.Drawing.Size(180, 22);
            this.mnuFuncionarios.Text = "Funcionarios";
            this.mnuFuncionarios.Click += new System.EventHandler(this.mnuFuncionarios_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSexo,
            this.mnuRua,
            this.mnuBairro,
            this.mnuCEP,
            this.mnuCidade,
            this.mnuTrabalho,
            this.mnuTelefoneFuncionario,
            this.mnuLogin,
            this.mnuControleSistema,
            this.mnuAcesso,
            this.mnuAcessoLogin,
            this.mnuLoja,
            this.mnuTelefoneLoja});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // mnuSexo
            // 
            this.mnuSexo.Name = "mnuSexo";
            this.mnuSexo.Size = new System.Drawing.Size(181, 22);
            this.mnuSexo.Text = "Sexo";
            this.mnuSexo.Click += new System.EventHandler(this.mnuSexo_Click);
            // 
            // mnuRua
            // 
            this.mnuRua.Name = "mnuRua";
            this.mnuRua.Size = new System.Drawing.Size(181, 22);
            this.mnuRua.Text = "Rua";
            this.mnuRua.Click += new System.EventHandler(this.mnuRua_Click);
            // 
            // mnuBairro
            // 
            this.mnuBairro.Name = "mnuBairro";
            this.mnuBairro.Size = new System.Drawing.Size(181, 22);
            this.mnuBairro.Text = "Bairro";
            this.mnuBairro.Click += new System.EventHandler(this.mnuBairro_Click);
            // 
            // mnuCEP
            // 
            this.mnuCEP.Name = "mnuCEP";
            this.mnuCEP.Size = new System.Drawing.Size(181, 22);
            this.mnuCEP.Text = "CEP";
            this.mnuCEP.Click += new System.EventHandler(this.mnuCEP_Click);
            // 
            // mnuCidade
            // 
            this.mnuCidade.Name = "mnuCidade";
            this.mnuCidade.Size = new System.Drawing.Size(181, 22);
            this.mnuCidade.Text = "Cidade";
            this.mnuCidade.Click += new System.EventHandler(this.mnuCidade_Click);
            // 
            // mnuTrabalho
            // 
            this.mnuTrabalho.Name = "mnuTrabalho";
            this.mnuTrabalho.Size = new System.Drawing.Size(181, 22);
            this.mnuTrabalho.Text = "Trabalho";
            this.mnuTrabalho.Click += new System.EventHandler(this.mnuTrabalho_Click);
            // 
            // mnuTelefoneFuncionario
            // 
            this.mnuTelefoneFuncionario.Name = "mnuTelefoneFuncionario";
            this.mnuTelefoneFuncionario.Size = new System.Drawing.Size(181, 22);
            this.mnuTelefoneFuncionario.Text = "TelefoneFuncionario";
            this.mnuTelefoneFuncionario.Click += new System.EventHandler(this.mnuTelefoneFuncionario_Click);
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(181, 22);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuControleSistema
            // 
            this.mnuControleSistema.Name = "mnuControleSistema";
            this.mnuControleSistema.Size = new System.Drawing.Size(181, 22);
            this.mnuControleSistema.Text = "ControleSistema";
            this.mnuControleSistema.Click += new System.EventHandler(this.mnuControleSistema_Click);
            // 
            // mnuAcesso
            // 
            this.mnuAcesso.Name = "mnuAcesso";
            this.mnuAcesso.Size = new System.Drawing.Size(181, 22);
            this.mnuAcesso.Text = "Acesso";
            this.mnuAcesso.Click += new System.EventHandler(this.mnuAcesso_Click);
            // 
            // mnuAcessoLogin
            // 
            this.mnuAcessoLogin.Name = "mnuAcessoLogin";
            this.mnuAcessoLogin.Size = new System.Drawing.Size(181, 22);
            this.mnuAcessoLogin.Text = "AcessoLogin";
            this.mnuAcessoLogin.Click += new System.EventHandler(this.mnuAcessoLogin_Click);
            // 
            // mnuLoja
            // 
            this.mnuLoja.Name = "mnuLoja";
            this.mnuLoja.Size = new System.Drawing.Size(181, 22);
            this.mnuLoja.Text = "Loja";
            this.mnuLoja.Click += new System.EventHandler(this.mnuLoja_Click);
            // 
            // mnuTelefoneLoja
            // 
            this.mnuTelefoneLoja.Name = "mnuTelefoneLoja";
            this.mnuTelefoneLoja.Size = new System.Drawing.Size(181, 22);
            this.mnuTelefoneLoja.Text = "TelefoneLoja";
            this.mnuTelefoneLoja.Click += new System.EventHandler(this.mnuTelefoneLoja_Click);
            // 
            // lojaToolStripMenuItem1
            // 
            this.lojaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.tipoToolStripMenuItem,
            this.vendaProdutoToolStripMenuItem,
            this.itensVendaToolStripMenuItem,
            this.parcelaVendaToolStripMenuItem});
            this.lojaToolStripMenuItem1.Name = "lojaToolStripMenuItem1";
            this.lojaToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.lojaToolStripMenuItem1.Text = "Loja";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoToolStripMenuItem.Text = "Tipo";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.tipoToolStripMenuItem_Click);
            // 
            // vendaProdutoToolStripMenuItem
            // 
            this.vendaProdutoToolStripMenuItem.Name = "vendaProdutoToolStripMenuItem";
            this.vendaProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendaProdutoToolStripMenuItem.Text = "Venda Produto";
            this.vendaProdutoToolStripMenuItem.Click += new System.EventHandler(this.vendaProdutoToolStripMenuItem_Click);
            // 
            // itensVendaToolStripMenuItem
            // 
            this.itensVendaToolStripMenuItem.Name = "itensVendaToolStripMenuItem";
            this.itensVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itensVendaToolStripMenuItem.Text = "Itens venda";
            this.itensVendaToolStripMenuItem.Click += new System.EventHandler(this.itensVendaToolStripMenuItem_Click);
            // 
            // parcelaVendaToolStripMenuItem
            // 
            this.parcelaVendaToolStripMenuItem.Name = "parcelaVendaToolStripMenuItem";
            this.parcelaVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parcelaVendaToolStripMenuItem.Text = "Parcela Venda";
            this.parcelaVendaToolStripMenuItem.Click += new System.EventHandler(this.parcelaVendaToolStripMenuItem_Click);
            // 
            // mnuFornecedor
            // 
            this.mnuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem1,
            this.mnuTelefoneFornecedor,
            this.mnuCompraProduto,
            this.mnuParcelaCompra,
            this.mnuSituacao});
            this.mnuFornecedor.Name = "mnuFornecedor";
            this.mnuFornecedor.Size = new System.Drawing.Size(79, 20);
            this.mnuFornecedor.Text = "Fornecedor";
            this.mnuFornecedor.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // mnuTelefoneFornecedor
            // 
            this.mnuTelefoneFornecedor.Name = "mnuTelefoneFornecedor";
            this.mnuTelefoneFornecedor.Size = new System.Drawing.Size(181, 22);
            this.mnuTelefoneFornecedor.Text = "Telefone Fornecedor";
            this.mnuTelefoneFornecedor.Click += new System.EventHandler(this.mnuTelefoneFornecedor_Click);
            // 
            // mnuCompraProduto
            // 
            this.mnuCompraProduto.Name = "mnuCompraProduto";
            this.mnuCompraProduto.Size = new System.Drawing.Size(181, 22);
            this.mnuCompraProduto.Text = "Compra Produto";
            this.mnuCompraProduto.Click += new System.EventHandler(this.mnuCompraProduto_Click);
            // 
            // mnuParcelaCompra
            // 
            this.mnuParcelaCompra.Name = "mnuParcelaCompra";
            this.mnuParcelaCompra.Size = new System.Drawing.Size(181, 22);
            this.mnuParcelaCompra.Text = "Parcela Compra";
            this.mnuParcelaCompra.Click += new System.EventHandler(this.mnuParcelaCompra_Click);
            // 
            // mnuSituacao
            // 
            this.mnuSituacao.Name = "mnuSituacao";
            this.mnuSituacao.Size = new System.Drawing.Size(181, 22);
            this.mnuSituacao.Text = "Situação";
            this.mnuSituacao.Click += new System.EventHandler(this.mnuSituacao_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema De Controle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnuSexo;
        private System.Windows.Forms.ToolStripMenuItem mnuRua;
        private System.Windows.Forms.ToolStripMenuItem mnuBairro;
        private System.Windows.Forms.ToolStripMenuItem mnuCEP;
        private System.Windows.Forms.ToolStripMenuItem mnuCidade;
        private System.Windows.Forms.ToolStripMenuItem mnuTrabalho;
        private System.Windows.Forms.ToolStripMenuItem mnuTelefoneFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuControleSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcesso;
        private System.Windows.Forms.ToolStripMenuItem mnuAcessoLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLoja;
        private System.Windows.Forms.ToolStripMenuItem mnuTelefoneLoja;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcelaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuTelefoneFornecedor;
        private System.Windows.Forms.ToolStripMenuItem mnuCompraProduto;
        private System.Windows.Forms.ToolStripMenuItem mnuParcelaCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuSituacao;
        private System.Windows.Forms.Label label1;
    }
}

