using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hologramv1
{
    public partial class Form1 : Form
    {
        bool[] Bit = new bool[2288];
        int[] Sutun = new int[286];
        int SayfaNumarasi = 1;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 2227; i++)
            {
                Bit[i] = false;
            }
        }

        void DiziDoldurma(object sender)
        {
            Button btn = (sender as Button);
            int Indis = 0;
            string ButonNumarasi = "";
            if (btn.Name.Length == 7)
            {
                ButonNumarasi = Convert.ToString(btn.Name[6]);
            }
            if (btn.Name.Length == 8)
            {
                ButonNumarasi = Convert.ToString(btn.Name[6]);
                ButonNumarasi = ButonNumarasi + Convert.ToString(btn.Name[7]);
            }
            if (btn.Name.Length == 9)
            {
                ButonNumarasi = Convert.ToString(btn.Name[6]);
                ButonNumarasi = ButonNumarasi + Convert.ToString(btn.Name[7]);
                ButonNumarasi = ButonNumarasi + Convert.ToString(btn.Name[8]);
            }
            Indis = 208 * (SayfaNumarasi-1) + Convert.ToInt16(ButonNumarasi);

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Green;
                Bit[Indis - 1] = true;
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.White;
                Bit[Indis - 1] = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button104_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button103_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button102_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button101_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button112_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button111_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button110_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button109_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button108_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button107_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button106_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button105_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button120_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button119_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button118_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button117_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button115_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button114_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button113_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button128_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button127_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button126_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button125_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button124_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button123_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button122_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button121_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button136_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button135_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button134_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button133_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button132_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button131_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button130_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button129_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button144_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button143_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button142_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button141_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button140_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button139_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button138_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button137_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button152_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button151_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button150_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button149_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button148_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button147_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button146_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button145_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button160_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button159_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button158_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button157_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button156_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button155_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button154_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button153_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button168_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button167_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button166_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button165_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button164_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button163_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button162_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button161_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button176_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button175_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button174_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button173_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button172_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button171_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button170_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button169_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button184_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button183_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button182_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button181_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button180_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button179_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button178_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button177_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button192_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button191_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button190_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button189_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button188_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button187_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button186_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button185_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button200_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button199_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button198_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button197_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button196_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button195_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button194_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button193_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button208_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button207_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button206_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button205_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button204_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button203_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button202_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button201_Click(object sender, EventArgs e)
        {
            DiziDoldurma(sender);
        }

        private void button209_Click(object sender, EventArgs e)
        {
            Color Renk = Color.White;
            button1.BackColor = Renk;
            button2.BackColor = Renk;
            button3.BackColor = Renk;
            button4.BackColor = Renk;
            button5.BackColor = Renk;
            button6.BackColor = Renk;
            button7.BackColor = Renk;
            button8.BackColor = Renk;
            button9.BackColor = Renk;
            button10.BackColor = Renk;
            button11.BackColor = Renk;
            button12.BackColor = Renk;
            button13.BackColor = Renk;
            button14.BackColor = Renk;
            button15.BackColor = Renk;
            button16.BackColor = Renk;
            button17.BackColor = Renk;
            button18.BackColor = Renk;
            button19.BackColor = Renk;
            button20.BackColor = Renk;
            button21.BackColor = Renk;
            button22.BackColor = Renk;
            button23.BackColor = Renk;
            button24.BackColor = Renk;
            button25.BackColor = Renk;
            button26.BackColor = Renk;
            button27.BackColor = Renk;
            button28.BackColor = Renk;
            button29.BackColor = Renk;
            button30.BackColor = Renk;
            button31.BackColor = Renk;
            button32.BackColor = Renk;
            button33.BackColor = Renk;
            button34.BackColor = Renk;
            button35.BackColor = Renk;
            button36.BackColor = Renk;
            button37.BackColor = Renk;
            button38.BackColor = Renk;
            button39.BackColor = Renk;
            button40.BackColor = Renk;
            button41.BackColor = Renk;
            button42.BackColor = Renk;
            button43.BackColor = Renk;
            button44.BackColor = Renk;
            button45.BackColor = Renk;
            button46.BackColor = Renk;
            button47.BackColor = Renk;
            button48.BackColor = Renk;
            button49.BackColor = Renk;
            button50.BackColor = Renk;
            button51.BackColor = Renk;
            button52.BackColor = Renk;
            button53.BackColor = Renk;
            button54.BackColor = Renk;
            button55.BackColor = Renk;
            button56.BackColor = Renk;
            button57.BackColor = Renk;
            button58.BackColor = Renk;
            button59.BackColor = Renk;
            button60.BackColor = Renk;
            button61.BackColor = Renk;
            button62.BackColor = Renk;
            button63.BackColor = Renk;
            button64.BackColor = Renk;
            button65.BackColor = Renk;
            button66.BackColor = Renk;
            button67.BackColor = Renk;
            button68.BackColor = Renk;
            button69.BackColor = Renk;
            button70.BackColor = Renk;
            button71.BackColor = Renk;
            button72.BackColor = Renk;
            button73.BackColor = Renk;
            button74.BackColor = Renk;
            button75.BackColor = Renk;
            button76.BackColor = Renk;
            button77.BackColor = Renk;
            button78.BackColor = Renk;
            button79.BackColor = Renk;
            button80.BackColor = Renk;
            button81.BackColor = Renk;
            button82.BackColor = Renk;
            button83.BackColor = Renk;
            button84.BackColor = Renk;
            button85.BackColor = Renk;
            button86.BackColor = Renk;
            button87.BackColor = Renk;
            button88.BackColor = Renk;
            button89.BackColor = Renk;
            button90.BackColor = Renk;
            button91.BackColor = Renk;
            button92.BackColor = Renk;
            button93.BackColor = Renk;
            button94.BackColor = Renk;
            button95.BackColor = Renk;
            button96.BackColor = Renk;
            button97.BackColor = Renk;
            button98.BackColor = Renk;
            button99.BackColor = Renk;
            button100.BackColor = Renk;
            button101.BackColor = Renk;
            button102.BackColor = Renk;
            button103.BackColor = Renk;
            button104.BackColor = Renk;
            button105.BackColor = Renk;
            button106.BackColor = Renk;
            button107.BackColor = Renk;
            button108.BackColor = Renk;
            button109.BackColor = Renk;
            button110.BackColor = Renk;
            button111.BackColor = Renk;
            button112.BackColor = Renk;
            button113.BackColor = Renk;
            button114.BackColor = Renk;
            button115.BackColor = Renk;
            button116.BackColor = Renk;
            button117.BackColor = Renk;
            button118.BackColor = Renk;
            button119.BackColor = Renk;
            button120.BackColor = Renk;
            button121.BackColor = Renk;
            button122.BackColor = Renk;
            button123.BackColor = Renk;
            button124.BackColor = Renk;
            button125.BackColor = Renk;
            button126.BackColor = Renk;
            button127.BackColor = Renk;
            button128.BackColor = Renk;
            button129.BackColor = Renk;
            button130.BackColor = Renk;
            button131.BackColor = Renk;
            button132.BackColor = Renk;
            button133.BackColor = Renk;
            button134.BackColor = Renk;
            button135.BackColor = Renk;
            button136.BackColor = Renk;
            button137.BackColor = Renk;
            button138.BackColor = Renk;
            button139.BackColor = Renk;
            button140.BackColor = Renk;
            button141.BackColor = Renk;
            button142.BackColor = Renk;
            button143.BackColor = Renk;
            button144.BackColor = Renk;
            button145.BackColor = Renk;
            button146.BackColor = Renk;
            button147.BackColor = Renk;
            button148.BackColor = Renk;
            button149.BackColor = Renk;
            button150.BackColor = Renk;
            button151.BackColor = Renk;
            button152.BackColor = Renk;
            button153.BackColor = Renk;
            button154.BackColor = Renk;
            button155.BackColor = Renk;
            button156.BackColor = Renk;
            button157.BackColor = Renk;
            button158.BackColor = Renk;
            button159.BackColor = Renk;
            button160.BackColor = Renk;
            button161.BackColor = Renk;
            button162.BackColor = Renk;
            button163.BackColor = Renk;
            button164.BackColor = Renk;
            button165.BackColor = Renk;
            button166.BackColor = Renk;
            button167.BackColor = Renk;
            button168.BackColor = Renk;
            button169.BackColor = Renk;
            button170.BackColor = Renk;
            button171.BackColor = Renk;
            button172.BackColor = Renk;
            button173.BackColor = Renk;
            button174.BackColor = Renk;
            button175.BackColor = Renk;
            button176.BackColor = Renk;
            button177.BackColor = Renk;
            button178.BackColor = Renk;
            button179.BackColor = Renk;
            button180.BackColor = Renk;
            button181.BackColor = Renk;
            button182.BackColor = Renk;
            button183.BackColor = Renk;
            button184.BackColor = Renk;
            button185.BackColor = Renk;
            button186.BackColor = Renk;
            button187.BackColor = Renk;
            button188.BackColor = Renk;
            button189.BackColor = Renk;
            button190.BackColor = Renk;
            button191.BackColor = Renk;
            button192.BackColor = Renk;
            button193.BackColor = Renk;
            button194.BackColor = Renk;
            button195.BackColor = Renk;
            button196.BackColor = Renk;
            button197.BackColor = Renk;
            button198.BackColor = Renk;
            button199.BackColor = Renk;
            button200.BackColor = Renk;
            button201.BackColor = Renk;
            button202.BackColor = Renk;
            button203.BackColor = Renk;
            button204.BackColor = Renk;
            button205.BackColor = Renk;
            button206.BackColor = Renk;
            button207.BackColor = Renk;
            button208.BackColor = Renk;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color Renk = Color.White;
            button1.BackColor = Renk;
            button2.BackColor = Renk;
            button3.BackColor = Renk;
            button4.BackColor = Renk;
            button5.BackColor = Renk;
            button6.BackColor = Renk;
            button7.BackColor = Renk;
            button8.BackColor = Renk;
            button9.BackColor = Renk;
            button10.BackColor = Renk;
            button11.BackColor = Renk;
            button12.BackColor = Renk;
            button13.BackColor = Renk;
            button14.BackColor = Renk;
            button15.BackColor = Renk;
            button16.BackColor = Renk;
            button17.BackColor = Renk;
            button18.BackColor = Renk;
            button19.BackColor = Renk;
            button20.BackColor = Renk;
            button21.BackColor = Renk;
            button22.BackColor = Renk;
            button23.BackColor = Renk;
            button24.BackColor = Renk;
            button25.BackColor = Renk;
            button26.BackColor = Renk;
            button27.BackColor = Renk;
            button28.BackColor = Renk;
            button29.BackColor = Renk;
            button30.BackColor = Renk;
            button31.BackColor = Renk;
            button32.BackColor = Renk;
            button33.BackColor = Renk;
            button34.BackColor = Renk;
            button35.BackColor = Renk;
            button36.BackColor = Renk;
            button37.BackColor = Renk;
            button38.BackColor = Renk;
            button39.BackColor = Renk;
            button40.BackColor = Renk;
            button41.BackColor = Renk;
            button42.BackColor = Renk;
            button43.BackColor = Renk;
            button44.BackColor = Renk;
            button45.BackColor = Renk;
            button46.BackColor = Renk;
            button47.BackColor = Renk;
            button48.BackColor = Renk;
            button49.BackColor = Renk;
            button50.BackColor = Renk;
            button51.BackColor = Renk;
            button52.BackColor = Renk;
            button53.BackColor = Renk;
            button54.BackColor = Renk;
            button55.BackColor = Renk;
            button56.BackColor = Renk;
            button57.BackColor = Renk;
            button58.BackColor = Renk;
            button59.BackColor = Renk;
            button60.BackColor = Renk;
            button61.BackColor = Renk;
            button62.BackColor = Renk;
            button63.BackColor = Renk;
            button64.BackColor = Renk;
            button65.BackColor = Renk;
            button66.BackColor = Renk;
            button67.BackColor = Renk;
            button68.BackColor = Renk;
            button69.BackColor = Renk;
            button70.BackColor = Renk;
            button71.BackColor = Renk;
            button72.BackColor = Renk;
            button73.BackColor = Renk;
            button74.BackColor = Renk;
            button75.BackColor = Renk;
            button76.BackColor = Renk;
            button77.BackColor = Renk;
            button78.BackColor = Renk;
            button79.BackColor = Renk;
            button80.BackColor = Renk;
            button81.BackColor = Renk;
            button82.BackColor = Renk;
            button83.BackColor = Renk;
            button84.BackColor = Renk;
            button85.BackColor = Renk;
            button86.BackColor = Renk;
            button87.BackColor = Renk;
            button88.BackColor = Renk;
            button89.BackColor = Renk;
            button90.BackColor = Renk;
            button91.BackColor = Renk;
            button92.BackColor = Renk;
            button93.BackColor = Renk;
            button94.BackColor = Renk;
            button95.BackColor = Renk;
            button96.BackColor = Renk;
            button97.BackColor = Renk;
            button98.BackColor = Renk;
            button99.BackColor = Renk;
            button100.BackColor = Renk;
            button101.BackColor = Renk;
            button102.BackColor = Renk;
            button103.BackColor = Renk;
            button104.BackColor = Renk;
            button105.BackColor = Renk;
            button106.BackColor = Renk;
            button107.BackColor = Renk;
            button108.BackColor = Renk;
            button109.BackColor = Renk;
            button110.BackColor = Renk;
            button111.BackColor = Renk;
            button112.BackColor = Renk;
            button113.BackColor = Renk;
            button114.BackColor = Renk;
            button115.BackColor = Renk;
            button116.BackColor = Renk;
            button117.BackColor = Renk;
            button118.BackColor = Renk;
            button119.BackColor = Renk;
            button120.BackColor = Renk;
            button121.BackColor = Renk;
            button122.BackColor = Renk;
            button123.BackColor = Renk;
            button124.BackColor = Renk;
            button125.BackColor = Renk;
            button126.BackColor = Renk;
            button127.BackColor = Renk;
            button128.BackColor = Renk;
            button129.BackColor = Renk;
            button130.BackColor = Renk;
            button131.BackColor = Renk;
            button132.BackColor = Renk;
            button133.BackColor = Renk;
            button134.BackColor = Renk;
            button135.BackColor = Renk;
            button136.BackColor = Renk;
            button137.BackColor = Renk;
            button138.BackColor = Renk;
            button139.BackColor = Renk;
            button140.BackColor = Renk;
            button141.BackColor = Renk;
            button142.BackColor = Renk;
            button143.BackColor = Renk;
            button144.BackColor = Renk;
            button145.BackColor = Renk;
            button146.BackColor = Renk;
            button147.BackColor = Renk;
            button148.BackColor = Renk;
            button149.BackColor = Renk;
            button150.BackColor = Renk;
            button151.BackColor = Renk;
            button152.BackColor = Renk;
            button153.BackColor = Renk;
            button154.BackColor = Renk;
            button155.BackColor = Renk;
            button156.BackColor = Renk;
            button157.BackColor = Renk;
            button158.BackColor = Renk;
            button159.BackColor = Renk;
            button160.BackColor = Renk;
            button161.BackColor = Renk;
            button162.BackColor = Renk;
            button163.BackColor = Renk;
            button164.BackColor = Renk;
            button165.BackColor = Renk;
            button166.BackColor = Renk;
            button167.BackColor = Renk;
            button168.BackColor = Renk;
            button169.BackColor = Renk;
            button170.BackColor = Renk;
            button171.BackColor = Renk;
            button172.BackColor = Renk;
            button173.BackColor = Renk;
            button174.BackColor = Renk;
            button175.BackColor = Renk;
            button176.BackColor = Renk;
            button177.BackColor = Renk;
            button178.BackColor = Renk;
            button179.BackColor = Renk;
            button180.BackColor = Renk;
            button181.BackColor = Renk;
            button182.BackColor = Renk;
            button183.BackColor = Renk;
            button184.BackColor = Renk;
            button185.BackColor = Renk;
            button186.BackColor = Renk;
            button187.BackColor = Renk;
            button188.BackColor = Renk;
            button189.BackColor = Renk;
            button190.BackColor = Renk;
            button191.BackColor = Renk;
            button192.BackColor = Renk;
            button193.BackColor = Renk;
            button194.BackColor = Renk;
            button195.BackColor = Renk;
            button196.BackColor = Renk;
            button197.BackColor = Renk;
            button198.BackColor = Renk;
            button199.BackColor = Renk;
            button200.BackColor = Renk;
            button201.BackColor = Renk;
            button202.BackColor = Renk;
            button203.BackColor = Renk;
            button204.BackColor = Renk;
            button205.BackColor = Renk;
            button206.BackColor = Renk;
            button207.BackColor = Renk;
            button208.BackColor = Renk;
        }

        private void button212_Click(object sender, EventArgs e)
        {
            if (SayfaNumarasi > 1)
            {
                SayfaNumarasi = SayfaNumarasi - 1;
                label1.Text = Convert.ToString(SayfaNumarasi);
            }
            else
            {
                MessageBox.Show("Minimum Sayfa Sayısına Ulaştınız");
            }
            

            
        }

        private void button211_Click(object sender, EventArgs e)
        {
            if (SayfaNumarasi < 11)
            {
                SayfaNumarasi = SayfaNumarasi + 1;
                label1.Text = Convert.ToString(SayfaNumarasi);
            }
            else
            {
                MessageBox.Show("Maksimum Sayfa Sayısına Ulaştınız");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button210_Click(object sender, EventArgs e)
        {
            int SutunDegeri = 0;
            for(int i=0;i<2288;i=i+8)
            {
                SutunDegeri = 0;
                if (Bit[i]==true)
                {
                    SutunDegeri = SutunDegeri + 1;
                }
                if (Bit[i+1] == true)
                {
                    SutunDegeri = SutunDegeri + 2;
                }
                if (Bit[i+2] == true)
                {
                    SutunDegeri = SutunDegeri + 4;
                }
                if (Bit[i+3] == true)
                {
                    SutunDegeri = SutunDegeri + 8;
                }
                if (Bit[i+4] == true)
                {
                    SutunDegeri = SutunDegeri + 16;
                }
                if (Bit[i+5] == true)
                {
                    SutunDegeri = SutunDegeri + 32;
                }
                if (Bit[i+6] == true)
                {
                    SutunDegeri = SutunDegeri + 64;
                }
                if (Bit[i+7] == true)
                {
                    SutunDegeri = SutunDegeri + 128;
                }
                Sutun[i / 8] = SutunDegeri;
                   

            }
        }

        private void button213_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("lütfen beklemeyi giriniz");
            }
            else
            {
                FolderBrowserDialog Klasor = new FolderBrowserDialog();

                if (Klasor.ShowDialog() == DialogResult.OK)
                {
                    string dosya_yolu = "";
                    dosya_yolu = Klasor.SelectedPath + "\\Hologram.txt";
                    //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
                    FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                    //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
                    //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
                    //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
                    StreamWriter sw = new StreamWriter(fs);
                    //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
                    string[] YazdirilacakSatir = { "" };
                    YazdirilacakSatir[0] =
                        "uint8_t Sutun[286]={"
                        + Environment.NewLine;
                    for (int i = 0; i < 286; i++)
                    {
                        YazdirilacakSatir[0] = YazdirilacakSatir[0] + Convert.ToString(Sutun[i]) + ",";
                        if (i >= 9)
                        {
                            if (i % 10 == 0)
                            {
                                YazdirilacakSatir[0] = YazdirilacakSatir[0] + Environment.NewLine;
                            }
                        }

                    }

                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "};" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "void setup() {                     //Setup Fonksiyonu" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "DDRD=B11111111;                    //D portunun 8 bitini çıkış olarak atar" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "pinMode(A4,INPUT);                 //A4 pini giriş olarak atanır;" + Environment.NewLine; ;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "pinMode(A2,OUTPUT);                //Hall effect sensörünün 5 volt çıkışı a2 çıkışı ile sağlanmıştır(enerji tasarrufu için)" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "digitalWrite(A2,HIGH);             //A2 çıkışı aktif edilerek sensör aktif hale getirilir" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "PORTD=0;                           //D portunun tüm çıkışları 0 volta çekilir" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "}" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "int Bekleme=" + textBox1.Text + "; //iki sütün arasındahi gecikme süresi mikrosaniye cinsinden" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "void loop() {" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + " if(analogRead(A4)<500)            //hall effect sensörü mıknatısın üzerinde ise  başlangıç verir" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + " {" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "     for(int i=0;i<50;i++)         // Sütun dizisinin tüm elemanlarını  tarayan döngü" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "     {" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "     PORTD=Sutun[i];               //Sütun dizisinin elemanlarını portd ye aktarır" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "     delayMicroseconds(Bekleme);   //Bir sütunun görünürlük süresi" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "     }" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + " }" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "PORTD=0;" + Environment.NewLine;
                    YazdirilacakSatir[0] = YazdirilacakSatir[0] + "}" + Environment.NewLine;

                    sw.WriteLine(YazdirilacakSatir[0]);
                    //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
                    sw.Flush();
                    //Veriyi tampon bölgeden dosyaya aktardık.
                    sw.Close();
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Kayıt edilecek dosya yolunu seçiniz");
                }
            }
        }

        private void button214_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asdasdasasdasd");
        }
    }
}
