using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaJogosForms.Classes;

namespace BibliotecaJogosForms
{
    public partial class Form1 : Form
    {
        static List<Jogo> listaJogos = new List<Jogo>();
        String listagem = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            String titulo = textTitulo.Text;
            String genero = textGenero.Text;
            int lancamento = Convert.ToInt32(textLancamento.Text);
            int maxJogadores = Convert.ToInt32(textMaxJogadores.Text);
            int metacritic = Convert.ToInt32(textMetacritic.Text);

            Jogo jogo = new Jogo(titulo, genero, lancamento, maxJogadores, metacritic);
            listaJogos.Add(jogo);
            MessageBox.Show("Jogo adicionado com sucesso!");
            
            textTitulo.Text = "";
            textGenero.Text = "";
            textLancamento.Text = "";
            textMaxJogadores.Text = "";
            textMetacritic.Text = "";
        }

        private void adicionarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelEnunciado.Visible = false;
            labelListagem.Visible = false;

            labelTitulo.Visible = true;
            textTitulo.Visible = true;
            labelGenero.Visible = true;
            textGenero.Visible = true;
            labelLancamento.Visible = true;
            textLancamento.Visible = true;
            labelMaxJogadores.Visible = true;
            textMaxJogadores.Visible = true;
            labelMetacritic.Visible = true;
            textMetacritic.Visible = true;
            buttonCadastrar.Visible = true;
        }

        private void listarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTitulo.Visible = false;
            textTitulo.Visible = false;
            labelGenero.Visible = false;
            textGenero.Visible = false;
            labelLancamento.Visible = false;
            textLancamento.Visible = false;
            labelMaxJogadores.Visible = false;
            textMaxJogadores.Visible = false;
            labelMetacritic.Visible = false;
            textMetacritic.Visible = false;
            buttonCadastrar.Visible = false;

            labelEnunciado.Visible = true;
            labelListagem.Visible = true;

            foreach (Jogo jogo in listaJogos)
            {
                listagem += "Título: "+ jogo.getTitulo();
                listagem += "\nGênero: " + jogo.getGenero();
                listagem += "\nLançamento: " + jogo.getAno();
                listagem += "\nMáximo de jogadore: " + jogo.getMaxJogadores();
                listagem += "\nMetacritic: " + jogo.getMetaCritic()+"\n\n";
            }
            labelListagem.Text = listagem;
        }

        private void alterarInformaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível no momento! \n;(");
        }

        private void deletarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível no momento! \n;(");
        }
    }
}
