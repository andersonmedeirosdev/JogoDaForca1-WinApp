using System.Linq;

namespace JogoDaForca1.WinApp
{
    public partial class Form1 : Form
    {
        Forca forca = null;
        int posicaoImg = 1;
        public Form1()
        {
            InitializeComponent();

            InicializarJogo();

            btnA.Click += ReceberPalpite;
            btnB.Click += ReceberPalpite;
            btnC.Click += ReceberPalpite;
            btnD.Click += ReceberPalpite;
            btnE.Click += ReceberPalpite;
            btnF.Click += ReceberPalpite;
            btnG.Click += ReceberPalpite;
            btnH.Click += ReceberPalpite;
            btnI.Click += ReceberPalpite;
            btnJ.Click += ReceberPalpite;
            btnK.Click += ReceberPalpite;
            btnL.Click += ReceberPalpite;
            btnM.Click += ReceberPalpite;
            btnN.Click += ReceberPalpite;
            btnO.Click += ReceberPalpite;
            btnP.Click += ReceberPalpite;
            btnQ.Click += ReceberPalpite;
            btnR.Click += ReceberPalpite;
            btnS.Click += ReceberPalpite;
            btnT.Click += ReceberPalpite;
            btnU.Click += ReceberPalpite;
            btnV.Click += ReceberPalpite;
            btnW.Click += ReceberPalpite;
            btnX.Click += ReceberPalpite;
            btnY.Click += ReceberPalpite;
            btnZ.Click += ReceberPalpite;
            btn«.Click += ReceberPalpite;
        }

        private void PreencherPalavra()
        {
            textoForca.Text = string.Empty;
            foreach (var item in forca.PalavraParcial)
            {
                textoForca.Text += item.ToString() + " ";
            }
        }


        private void ReceberPalpite(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool acertou = forca.JogadorAcertou(Convert.ToChar(btn.Text));
            PreencherPalavra();

            if(acertou || forca.JogadorPerdeu())
            {
                MessageBox.Show(forca.mensagemFinal);
            }
            else if (forca.letrasEncontradas.Contains(Convert.ToChar(btn.Text)) == false)
            {
                pictureBox1.Image = imageList1.Images[posicaoImg++];
            }
        }

        private void InicializarJogo()
        {
            forca = new Forca();

            PreencherPalavra();

            posicaoImg = 1;

            pictureBox1.Image = imageList1.Images[0];
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            InicializarJogo();
        }
    }
}