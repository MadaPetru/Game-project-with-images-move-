using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShootTargets
{
    public partial class Form1 : Form
    {
        int punctaj = 0;
        int punctajMaxim = -1;
        int pasTun = 1;
        int pasJokerDeGalati = 10;
        int pasBatman = -10;
        int pasBomb = -50;
        bool btnStartClicked = false;
        public Form1()
        {
            InitializeComponent();
            btnShoot.Enabled = false;
            btnStop.Enabled = false;
            txtPunctaj.Text = "0";
        }
        void pornimJocul()
        {
            if (btnStartClicked == true) 
            {
                timerTun.Start();
                timerBatman.Start();
                timerJokerDeGalati.Start();
            }
        }

        void oprimJocul()
        {
            punctaj = 0;
            txtPunctaj.Text = punctaj.ToString();
            btnShoot.Enabled = false;
            btnStart.Enabled = true;
            timerBatman.Stop();
            timerJokerDeGalati.Stop();
            timerTun.Stop();
            pctBatman.SetBounds(1, 488 - 135, pctBatman.Width, pctBatman.Height);
            pctJokerGalati.SetBounds(1, 0, pctJokerGalati.Width, pctJokerGalati.Height);
            pctTun.SetBounds(1049 - 214 - 40, 1, pctTun.Width, pctTun.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timerTun_Tick(object sender, EventArgs e)
        {
            int valoareY = pctTun.Location.Y+pasTun;
            pctTun.SetBounds(pctTun.Location.X,valoareY,pctTun.Width,pctTun.Height);
            if (valoareY + 60 + 56 +10 >= this.Size.Height) pasTun = -pasTun;
            else if(pasTun<0 && valoareY<=0) pasTun = -pasTun;
        }

        private void timerBatman_Tick(object sender, EventArgs e)
        {
            int valoareY=pctBatman.Location.Y+pasBatman;
            pctBatman.SetBounds(pctBatman.Location.X,valoareY,pctBatman.Width,pctBatman.Height);
            if (valoareY + 135>= this.Size.Height) pasBatman = -pasBatman;
            else if (pasBatman < 0 && valoareY <= 0) pasBatman = -pasBatman;
        }

        private void timerJokerDeGalati_Tick(object sender, EventArgs e)
        {
            int valoareY=pctJokerGalati.Location.Y+pasJokerDeGalati;
            pctJokerGalati.SetBounds(pctJokerGalati.Location.X,valoareY,pctJokerGalati.Width,pctJokerGalati.Height);
            if (valoareY + 135 >= this.Height) pasJokerDeGalati = -pasJokerDeGalati;
            else if (valoareY <= 0 && pasJokerDeGalati < 0) pasJokerDeGalati = -pasJokerDeGalati;
        }

        private void pctJokerGalati_Click(object sender, EventArgs e)
        {

        }

        private void pctBatman_Click(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            Image imageBomb = Properties.Resources.bomba;
            PictureBox pctBomb = new PictureBox();
            pctBomb.Parent = this;
            pctBomb.BringToFront();
            pctBomb.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBomb.Width = 15;
            pctBomb.Height = 15;
            int positionTunX = pctTun.Location.X;
            int positionTunY = pctTun.Location.Y;
            pctBomb.SetBounds(positionTunX,positionTunY,pctBomb.Width,pctBomb.Height);
            pctBomb.Image = imageBomb;
            Timer timerBomb = new Timer();
            timerBomb.Interval = 1;
            timerBomb.Tick += (object sender1, EventArgs eventArgs) =>
            {
                int valoareX = pctBomb.Location.X + pasBomb;
                pctBomb.SetBounds(valoareX,pctBomb.Location.Y,pctBomb.Width,pctBomb.Height);
                if(valoareX<=0) timerBomb.Stop();
                if (bombaIntersecteazaCuBatman(pctBomb, pctBatman,timerBomb))
                {
                    if (punctaj > punctajMaxim)
                    {
                        punctajMaxim = punctaj;
                        txtScorMaxim.Text =punctajMaxim.ToString();
                    }
                    oprimJocul();
                    MessageBox.Show("Ai piedrdut,scorul tau este de: " + punctaj);
                }
                if (bombaIntersecteazaCuJokerDeGalati(pctBomb, pctJokerGalati,timerBomb))
                {
                    punctaj++;
                    string scor = punctaj.ToString();
                    txtPunctaj.Text = scor;
                }
                if(bombaIntersecteazaCuBatman(pctBomb,pctBatman,timerBomb)==false &&
                bombaIntersecteazaCuJokerDeGalati(pctBomb, pctJokerGalati, timerBomb) == false &&
                bombaDepasesteObstacolele(pctBomb)==true)
                {
                    pctBomb.Hide();
                }
            };
            timerBomb.Start();
        }

        private void pctBomba_Click(object sender, EventArgs e)
        {

        }
        bool bombaDepasesteObstacolele(PictureBox pctBomb)
        {
            if (pctBomb.Location.X <= 0) return true;
            return false;
        }

        bool bombaIntersecteazaCuBatman(PictureBox pctBomb,PictureBox pctBatman,Timer timerBomb)
        {
            int coordonataXBomba = pctBomb.Location.X;
            int coordonataYBomba = pctBomb.Location.Y;
            int coordonataXBatman = pctBatman.Location.X;
            int coordonataYBatman = pctBatman.Location.Y;
            int latimepctBatman = pctBatman.Width;
            int inaltimepctBatman = pctBatman.Height;
            if(coordonataYBomba>=coordonataYBatman && coordonataYBomba <= coordonataYBatman + inaltimepctBatman)
            {
                if (coordonataXBomba <= latimepctBatman)
                {
                    timerBomb.Stop();
                    pctBomb.Hide();
                    return true;
                }
            }
            return false;
        }
        bool bombaIntersecteazaCuJokerDeGalati(PictureBox pctBomb,PictureBox pctJokcerDeGalati,Timer timerBomb)
        {
            int coordonataXBomba = pctBomb.Location.X;
            int coordonataYBomba = pctBomb.Location.Y;
            int coordonataXJokerDeGalati = pctJokcerDeGalati.Location.X;
            int coordonataYJokerDeGalati = pctJokcerDeGalati.Location.Y;
            int latimepctJokerDeGalati = pctJokcerDeGalati.Width;
            int inaltimepctJokerDeGalati = pctJokcerDeGalati.Height;
            if(coordonataYBomba>=coordonataYJokerDeGalati && coordonataYBomba <= coordonataYJokerDeGalati + inaltimepctJokerDeGalati)
            {
                if (coordonataXBomba <= latimepctJokerDeGalati)
                {
                    timerBomb.Stop();
                    pctBomb.Hide();
                    return true;
                }
            }
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnStartClicked = true;
            btnShoot.Enabled = true;
            pornimJocul();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnShoot.Enabled=false;
            btnStop.Enabled = false;
            timerBatman.Stop();
            timerJokerDeGalati.Stop();
            timerTun.Stop();
            Button btnResume =new Button();
            btnResume.Parent = this;
            btnResume.Text = "Resume";
            btnResume.SetBounds(this.Width / 2-50, this.Height / 2-50, 100, 100);
            btnResume.Click += (object obj,EventArgs e1) =>
            {
                timerBatman.Start();
                timerJokerDeGalati.Start();
                timerTun.Start();
                btnResume.Visible=false;
                btnShoot.Enabled = true;
                btnStop.Enabled = true;
            };
        }
    }
}
