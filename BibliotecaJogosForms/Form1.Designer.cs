
namespace BibliotecaJogosForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textLancamento = new System.Windows.Forms.TextBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelLancamento = new System.Windows.Forms.Label();
            this.labelMaxJogadores = new System.Windows.Forms.Label();
            this.textMaxJogadores = new System.Windows.Forms.TextBox();
            this.textMetacritic = new System.Windows.Forms.TextBox();
            this.labelMetacritic = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarInformaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.labelListagem = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.Location = new System.Drawing.Point(190, 529);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(404, 38);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Visible = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.btCadastar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(189, 280);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(66, 28);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Título:";
            this.labelTitulo.Visible = false;
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(261, 285);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(332, 23);
            this.textTitulo.TabIndex = 0;
            this.textTitulo.Visible = false;
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(275, 331);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(318, 23);
            this.textGenero.TabIndex = 2;
            this.textGenero.Visible = false;
            // 
            // textLancamento
            // 
            this.textLancamento.Location = new System.Drawing.Point(317, 379);
            this.textLancamento.Name = "textLancamento";
            this.textLancamento.Size = new System.Drawing.Size(276, 23);
            this.textLancamento.TabIndex = 3;
            this.textLancamento.Visible = false;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenero.Location = new System.Drawing.Point(189, 326);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(80, 28);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Genêro:";
            this.labelGenero.Visible = false;
            // 
            // labelLancamento
            // 
            this.labelLancamento.AutoSize = true;
            this.labelLancamento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLancamento.Location = new System.Drawing.Point(189, 374);
            this.labelLancamento.Name = "labelLancamento";
            this.labelLancamento.Size = new System.Drawing.Size(122, 28);
            this.labelLancamento.TabIndex = 5;
            this.labelLancamento.Text = "Lançamento:";
            this.labelLancamento.Visible = false;
            // 
            // labelMaxJogadores
            // 
            this.labelMaxJogadores.AutoSize = true;
            this.labelMaxJogadores.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxJogadores.Location = new System.Drawing.Point(189, 420);
            this.labelMaxJogadores.Name = "labelMaxJogadores";
            this.labelMaxJogadores.Size = new System.Drawing.Size(209, 28);
            this.labelMaxJogadores.TabIndex = 6;
            this.labelMaxJogadores.Text = "Máximo de Jogadores:";
            this.labelMaxJogadores.Visible = false;
            // 
            // textMaxJogadores
            // 
            this.textMaxJogadores.Location = new System.Drawing.Point(404, 425);
            this.textMaxJogadores.Name = "textMaxJogadores";
            this.textMaxJogadores.Size = new System.Drawing.Size(189, 23);
            this.textMaxJogadores.TabIndex = 7;
            this.textMaxJogadores.Visible = false;
            // 
            // textMetacritic
            // 
            this.textMetacritic.Location = new System.Drawing.Point(298, 471);
            this.textMetacritic.Name = "textMetacritic";
            this.textMetacritic.Size = new System.Drawing.Size(295, 23);
            this.textMetacritic.TabIndex = 9;
            this.textMetacritic.Visible = false;
            // 
            // labelMetacritic
            // 
            this.labelMetacritic.AutoSize = true;
            this.labelMetacritic.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMetacritic.Location = new System.Drawing.Point(189, 466);
            this.labelMetacritic.Name = "labelMetacritic";
            this.labelMetacritic.Size = new System.Drawing.Size(103, 28);
            this.labelMetacritic.TabIndex = 8;
            this.labelMetacritic.Text = "Metacritic:";
            this.labelMetacritic.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarJogoToolStripMenuItem,
            this.listarJogosToolStripMenuItem,
            this.alterarInformaçãoToolStripMenuItem,
            this.deletarJogoToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // adicionarJogoToolStripMenuItem
            // 
            this.adicionarJogoToolStripMenuItem.Name = "adicionarJogoToolStripMenuItem";
            this.adicionarJogoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarJogoToolStripMenuItem.Text = "Adicionar jogo";
            this.adicionarJogoToolStripMenuItem.Click += new System.EventHandler(this.adicionarJogoToolStripMenuItem_Click);
            // 
            // listarJogosToolStripMenuItem
            // 
            this.listarJogosToolStripMenuItem.Name = "listarJogosToolStripMenuItem";
            this.listarJogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarJogosToolStripMenuItem.Text = "Listar jogos";
            this.listarJogosToolStripMenuItem.Click += new System.EventHandler(this.listarJogosToolStripMenuItem_Click);
            // 
            // alterarInformaçãoToolStripMenuItem
            // 
            this.alterarInformaçãoToolStripMenuItem.Name = "alterarInformaçãoToolStripMenuItem";
            this.alterarInformaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarInformaçãoToolStripMenuItem.Text = "Alterar informação";
            this.alterarInformaçãoToolStripMenuItem.Click += new System.EventHandler(this.alterarInformaçãoToolStripMenuItem_Click);
            // 
            // deletarJogoToolStripMenuItem
            // 
            this.deletarJogoToolStripMenuItem.Name = "deletarJogoToolStripMenuItem";
            this.deletarJogoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarJogoToolStripMenuItem.Text = "Deletar jogo";
            this.deletarJogoToolStripMenuItem.Click += new System.EventHandler(this.deletarJogoToolStripMenuItem_Click);
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnunciado.Location = new System.Drawing.Point(189, 254);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(181, 28);
            this.labelEnunciado.TabIndex = 11;
            this.labelEnunciado.Text = "Jogos Adicionados:";
            this.labelEnunciado.Visible = false;
            // 
            // labelListagem
            // 
            this.labelListagem.AutoSize = true;
            this.labelListagem.Location = new System.Drawing.Point(189, 293);
            this.labelListagem.Name = "labelListagem";
            this.labelListagem.Size = new System.Drawing.Size(0, 15);
            this.labelListagem.TabIndex = 12;
            this.labelListagem.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelListagem);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.textMetacritic);
            this.Controls.Add(this.labelMetacritic);
            this.Controls.Add(this.textMaxJogadores);
            this.Controls.Add(this.labelMaxJogadores);
            this.Controls.Add(this.labelLancamento);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.textLancamento);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Biblioteca de Jogos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textLancamento;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelLancamento;
        private System.Windows.Forms.Label labelMaxJogadores;
        private System.Windows.Forms.TextBox textMaxJogadores;
        private System.Windows.Forms.TextBox textMetacritic;
        private System.Windows.Forms.Label labelMetacritic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarInformaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarJogoToolStripMenuItem;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.Label labelListagem;
    }
}

