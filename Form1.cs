using System.Windows.Forms;
namespace Grafica_Gioco_del_impiccato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> parole = new List<string>();
        Random random = new Random();
        int tentativi = 0;
        string par, lettera, trattini = "";
        char scelta;
        private void GeneraParola_Click(object sender, EventArgs e)
        {
            string[] arrayT;
            if (parole.Count == 0)
            {
                using (StreamReader sr = new StreamReader("parole_gioco_dell'impiccato.csv"))
                {
                    sr.ReadLine();
                    string riga = sr.ReadLine();
                    while (riga != null)
                    {
                        arrayT = riga.Split(',');
                        for (int i = 0; i < arrayT.Length; i++)
                        {
                            parole.Add(arrayT[i]);
                        }
                        riga = sr.ReadLine();
                    }
                }
                par = parole[random.Next(parole.Count)];
                for (int i = 0; i < par.Length; i++)
                {
                    trattini = trattini + " _ ";
                    lblTrattini.Text = "";
                    lblTrattini.Text = trattini;

                }
            }
            else
            {
                par = parole[random.Next(0, parole.Count)];
                for (int i = 0; i < par.Length; i++)
                {
                    trattini = trattini + " _ ";
                }
                lblTrattini.Text = "";
                lblTrattini.Text = trattini;
            }
        }
        private void VisualGrafica(bool vis)
        {
            if (vis == true)
            {
                lblTITOLO.Visible = true;
                CATEGORIA.Visible = true;
                CALCIO.Visible = true;
                COLORI.Visible = true;
                PAESI.Visible = true;
                GeneraParola.Visible = false;
                lblTrattini.Visible = false;
                DIFFICOLTA.Visible = false;
                FACILE.Visible = false;
                MEDIA.Visible = false;
                DIFFICILE.Visible = false;
                lblTASTIERA.Visible = false;
                bntA.Visible = false;
                bntB.Visible = false;
                bntC.Visible = false;
                bntD.Visible = false;
                bntE.Visible = false;
                bntF.Visible = false;
                bntJ.Visible = false;
                bntH.Visible = false;
                bntI.Visible = false;
                bntJ.Visible = false;
                bntK.Visible = false;
                bntL.Visible = false;
                bntM.Visible = false;
                bntN.Visible = false;
                bntO.Visible = false;
                bntP.Visible = false;
                bntQ.Visible = false;
                bntR.Visible = false;
                bntS.Visible = false;
                bntT.Visible = false;
                bntU.Visible = false;
                bntV.Visible = false;
                bntW.Visible = false;
                bntX.Visible = false;
                bntY.Visible = false;
                bntZ.Visible = false;
            }
            else
            {
                lblTITOLO.Visible = true;
                CATEGORIA.Visible = false;
                CALCIO.Visible = false;
                COLORI.Visible = false;
                PAESI.Visible = false;
                GeneraParola.Visible = true;
                lblTrattini.Visible = true;
                DIFFICOLTA.Visible = true;
                FACILE.Visible = true;
                MEDIA.Visible = true;
                DIFFICILE.Visible = true;
                lblTASTIERA.Visible = true;
                bntA.Visible = true;
                bntB.Visible = true;
                bntC.Visible = true;
                bntD.Visible = true;
                bntE.Visible = true;
                bntF.Visible = true;
                bntJ.Visible = true;
                bntH.Visible = true;
                bntI.Visible = true;
                bntJ.Visible = true;
                bntK.Visible = true;
                bntL.Visible = true;
                bntM.Visible = true;
                bntN.Visible = true;
                bntO.Visible = true;
                bntP.Visible = true;
                bntQ.Visible = true;
                bntR.Visible = true;
                bntS.Visible = true;
                bntT.Visible = true;
                bntU.Visible = true;
                bntV.Visible = true;
                bntW.Visible = true;
                bntX.Visible = true;
                bntY.Visible = true;
                bntZ.Visible = true;
            }
        }
        private void RiempimentoTrat(string trattini, char lettera, string scelta)
        {
            char[] sosTrat = trattini.ToCharArray();
            if (scelta.Contains(lettera) == true)
            {
                for (int i = 0; i < scelta.Length; i++)
                {
                    if (scelta[i] == lettera)
                    {
                        sosTrat[i] = lettera;
                    }
                }
            }
            lblTrattini.Text = new string(sosTrat);
        }
        private void FACILE_Click(object sender, EventArgs e)
        {
            tentativi = 12;
            VisualGrafica(true);
        }
        private void MEDIA_Click(object sender, EventArgs e)
        {
            tentativi = 9;
            VisualGrafica(true);
        }
        private void DIFFICILE_Click(object sender, EventArgs e)
        {
            tentativi = 7;
            VisualGrafica(true);
        }
        private void bntA_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "A");
        }
        private void bntB_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "B");
        }
        private void bntC_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "C");
        }
        private void bntD_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "D");
        }
        private void bntE_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "E");
        }
        private void bntF_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "F");
        }
        private void bntG_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "G");
        }
        private void bntH_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "H");
        }
        private void bntI_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "I");
        }
        private void bntJ_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "J");
        }
        private void bntK_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "K");
        }
        private void bntL_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "L");
        }
        private void bntM_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "M");
        }
        private void bntN_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "N");
        }
        private void bntO_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "O");
        }
        private void bntP_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "P");
        }
        private void bntQ_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "Q");

        }
        private void bntR_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "R");

        }
        private void bntS_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "S");

        }
        private void bntT_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "T");

        }
        private void bntU_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "U");

        }
        private void bntV_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "V");

        }
        private void bntW_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "W");

        }
        private void bntX_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "X");

        }
        private void bntY_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "Y");

        }
        private void bntZ_Click(object sender, EventArgs e)
        {
            RiempimentoTrat(trattini, scelta, "Z");

        }
    }
}
