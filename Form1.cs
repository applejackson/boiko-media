using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIA
{
    public partial class Form1 : Form
    {
        private Int32 step;
        private Int32 temp;
        public Form1()
        {
            InitializeComponent();
            MP2.BringToFront();
            step = 10;
            temp = label1.Text.Length;
        }
        string[] paths, files;
        int Startindex = 0;
        string[] FileName, FilePath;
        Boolean playnext = false;
        int sx = 1, sy = 1;







        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            bunifuLabel4.Visible = true;
            MP2.Visible = true;
            listBox1.Visible = false;
            bunifuLabel2.Visible = false;

        }

        private void btnExplore_Click(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            MP2.Visible = false;
            bunifuLabel4.Visible = false;
            listBox1.Visible = true;
            bunifuLabel2.Visible = true;
        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            //axWindowsMediaPlayer2.settings.volume = bunifuHSlider1.Value;
            myMet();
        }
        public void myMet()
        {
            if (bunifuLabel1.Text == "0")
            {
                MP2.settings.volume = 0;
                bunifuImageButton6.Image = Image.FromFile("mute.png");
            }
            else
            {
                MP2.settings.volume = Convert.ToInt32(bunifuLabel1.Text);
                bunifuImageButton6.Image = Image.FromFile("звук.png");
            }
        } 
        private void bunifuHSlider2_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            MP2.settings.volume = bunifuHSlider1.Value;
            bunifuLabel1.Text = bunifuHSlider2.Value.ToString();

        }
        public void StopPlayer()
        {


            MP2.Ctlcontrols.stop();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = listBox1.SelectedIndex;

            playfile(Startindex);
            bunifuLabel2.Text = listBox1.Text;
            bunifuLabel4.Text = listBox1.Text;
            timer1.Start();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            OpenFileDialog opnFileDlg = new OpenFileDialog();
            opnFileDlg.Multiselect = true;
            opnFileDlg.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*";
            if (opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                FileName = opnFileDlg.SafeFileNames;
                FilePath = opnFileDlg.FileNames;
                for (int i = 0; i < FileName.Length; i++)
                {
                    listBox1.Items.Add(FileName[i]);
                }
                Startindex = 0;
                //playfile(0);
            }

        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            MP2.Ctlcontrols.currentPosition = bunifuHSlider1.Value;
        }

        private void play_Click(object sender, EventArgs e)
        {
            MP2.Ctlcontrols.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            MP2.Ctlcontrols.pause();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MP2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuHSlider1.Maximum = (int)MP2.Ctlcontrols.currentItem.duration;
                bunifuHSlider1.Value = (int)MP2.Ctlcontrols.currentPosition;
            }
            startTrackLBL.Text = MP2.Ctlcontrols.currentPositionString;
            if (listBox1.Items.Count!=0)
            {
                endlblTrack.Text = MP2.Ctlcontrols.currentItem.durationString;
            }
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }

        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Startindex = listBox1.SelectedIndex;

            playfile(Startindex);
            bunifuLabel2.Text = listBox1.Text;
            bunifuLabel4.Text = listBox1.Text;
            timer1.Start();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_ZoomedIn(object sender, EventArgs e)
        {
            bunifuImageButton1.Width = 40;
            bunifuImageButton1.Height = 40;
        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            string message = "Если у вас возникли трудности с программой  пишите по адресу 1122003smalzer@mail.ru";
            string title = "Help";
            MessageBox.Show(message, title);
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            bunifuHSlider2.Value--;
            myMet();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            bunifuHSlider2.Value--;
            myMet();
        }

        private void buttonminus_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Start();
        }

        private void buttonminus_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Stop();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            bunifuHSlider2.Value++;
            myMet();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            bunifuHSlider2.Value++;
            myMet();
        }

        private void buttonplus_MouseDown(object sender, MouseEventArgs e)
        {
            timer4.Start();
        }

        private void buttonplus_MouseUp(object sender, MouseEventArgs e)
        {
            timer4.Stop();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bunifuLabel2.Text = "";
            MP2.Ctlcontrols.stop();
            MP2.currentPlaylist.clear();

        }

        private void bunifuHSlider1_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            if (bunifuHSlider1.Value== bunifuHSlider1.Maximum && listBox1.Items.Count!=0)
            {
                listBox1.SelectedIndex += 1;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (bunifuLabel2.Location.X < panel1.Width)
            {
                //вправо
                if (bunifuLabel2.Location.X <= panel1.Width )
                {
                    bunifuLabel2.Location = new Point(bunifuLabel2.Location.X + step, bunifuLabel2.Location.Y);
                    temp = bunifuLabel2.Text.Length;
                    bunifuLabel2.TextAlignment = ContentAlignment.TopRight;
                }
            }


            else
            {
    
                    bunifuLabel2.Location = new Point(22, 31);
         
            }
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            StopPlayer();
            
        }
        public  void playfile(int playlistindex)
        {
            if(listBox1.Items.Count<=0)
            {
                return;
            }
            if (playlistindex <0)
            {
                return;
            }
            MP2.settings.autoStart = true;
            MP2.URL = FilePath[playlistindex];
            MP2.Ctlcontrols.next();
            MP2.Ctlcontrols.play();

        }

    }
   
     
}
