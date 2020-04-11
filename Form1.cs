using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;                              // Para Impressão (PrintDocument)

namespace Windows_Forms___Impressão
{
    public partial class frmImprimir : Form
    {
        public frmImprimir()
        {
            InitializeComponent();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            // Cria um Documento com 250 Linhas
            string[] TextoParaImpressão = new string[250];

            for (int i = 0; i < 250; i++)
            {
                TextoParaImpressão[i] += "Pontifícia Universidade Católica de Minas Gerais - PUC Minas - Curso de Sistemas de Informação";
            }

            // Chama o Construtor da Classe
            // Como a Classe Impressão tem Herança com PrintDocument, Doc terá acesso a PrintDocument também...
            PrintDocument Doc = new Impressão(TextoParaImpressão);              
            
            Doc.PrintPage += this.Doc_PrintPage;                            // Adiciona o Evento... Quando a Página for Impressa, chamar o Evento Doc_PrintPage !

            PrintDialog Diálogo = new PrintDialog();                        // Mostra a Caixa de Diálogo de Impressão
            Diálogo.Document = Doc;

            //  OK do Usuário?
            if (Diálogo.ShowDialog() == DialogResult.OK)
            {
                if (chkVisualizar.Checked)                                  // É para Visualizar?        
                {
                    PrintPreviewDialog PPDLG = new PrintPreviewDialog();    // Mostra
                    PPDLG.Document = Doc;
                    PPDLG.ShowDialog();
                }
                else
                {
                    Doc.Print();                                            // Imprime (Isso chamará o Evento Doc_PrintPage. É ele quem vai imprimir...)
                }
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)     // Página a ser Impressa...
        {
            // Recupera o Documento que enviou este Evento...
            Impressão Doc = (Impressão)sender;

            // Define a Fonte e Determina a Altura da Linha
            using (Font Fonte = new Font("Calibri", 10))
            {
                float AlturaLinha = Fonte.GetHeight(e.Graphics);

                // Cria as Variáveis para Tratar a Posição de Impressão na Página
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                // Incrementa o Contador de Páginas
                Doc.NúmeroPágina ++;

                // Imprime os Dados que cabem na Página
                // O Loop termina quando a Próxima Linha irá passar a Borda da Margem ou quando não há mais Linhas a Imprimir
                while ((y + AlturaLinha) < e.MarginBounds.Bottom && Doc.Offset <= Doc.Texto.GetUpperBound(0))
                {
                    e.Graphics.DrawString(Doc.Texto[Doc.Offset], 
                                          Fonte, Brushes.Black, x, y);           // Imprime!
                    
                    // Move para a Próxima Linha
                    Doc.Offset ++;

                    // Move uma Linha para baixo (Próxima Linha)
                    y += AlturaLinha;
                }

                if (Doc.Offset < Doc.Texto.GetUpperBound(0))            // Compara
                {
                    // Havendo ainda pelo menos mais uma Página, sinaliza o Evento para disparar novamente...
                    e.HasMorePages = true;
                }
                else
                {
                    // A impressão Terminou
                    Doc.Offset = 0;
                }
            }
        }
    }
}
