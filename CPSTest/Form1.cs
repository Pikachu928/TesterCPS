namespace CPSTest
{
    using System;
    using System.IO;

    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
            

            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string path = Path.Combine(folder, "CPSTest");
                Directory.CreateDirectory(path);
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            finally { }





            /*public static System.IO.DirectoryInfo CreateDirectory(string path);*/
        }


        int _czas;
        int _testczas;
        double _wynik;
        double _cps;
        string _last;



        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrCzas.Stop();

            _wynik = 0;
            _cps = 0;
            lblWynik.Text = "SCORE: " + _wynik.ToString();
            lblCzas.Text = "TIME: 0";
            lblCps.Text = "CPS: " + _cps.ToString();
            /*tbxCzas.Text*/
            btnClick.Enabled = true;
            tbxCzas.Enabled = true;
            /*tbxCzas.Text = "";*/

        }

        private void tbxCzas_TextChanged(object sender, EventArgs e)
        {
            btnClick.Enabled = true;
        }

   



        private void btnClick_Click_1(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbxCzas.Text, out _testczas))
            {
                if (_testczas > 60)
                {
                    MessageBox.Show("Enter a time less than or equal to a minute");
                }
                else
                {
                    if (tmrCzas.Enabled == false)
                    {
                        _wynik = 0;
                        _cps = 0;
                        lblCps.Text = "CPS: " + _cps.ToString();
                        lblWynik.Text = "SCORE: " + _wynik.ToString();
                        _czas = _testczas;
                        tmrCzas.Start();
                        tbxCzas.Enabled = true;

                    }
                    if (tmrCzas.Enabled == true)
                    {

                        _wynik++;
                        lblWynik.Text = "SCORE: " + _wynik.ToString();
                        tbxCzas.Enabled = false;

                    }

                }
            }
            else
            {
                MessageBox.Show("Enter time in seconds!");
            }
        }

        private void tmrCzas_Tick_1(object sender, EventArgs e)
        {
            _czas--;
            lblCzas.Text = "TIME: " + _czas.ToString();
            if (_czas == 0)
            {
                tmrCzas.Stop();
                btnClick.Enabled = false;

                if (Int32.TryParse(tbxCzas.Text, out _testczas))
                {
                    _cps = _wynik / _testczas - _czas;
                    lblCps.Text = "CPS: " + _cps;
                    _last = "Score: " + _wynik + ", CPS: " + Math.Round(_cps, 1) + ", Time: " + _testczas + "\n";
                    lblRanking.Text = lblRanking.Text + _last;
                    /*System.IO.StreamWriter writer = new System.IO.StreamWriter("path to file"); //open the file for writing.
                    writer.Write(DateTime.Now.ToString()); //write the current date to the file. change this with your date or something.
                    writer.Close(); //remember to close the file again.
                    writer.Dispose(); //remember to dispose it from the memory.
*/


                }

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tmrTest.Start();
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            if (btnClick.Enabled == false && tmrCzas.Enabled == false)
            {
                tbxCzas.Enabled = true;
            }
        }

        private void lblRank_Click(object sender, EventArgs e)
        {

        }

        private void lblRanking_Click(object sender, EventArgs e)
        {

        }

        private void lblSec_Click(object sender, EventArgs e)
        {

        }

        private void lblChooseTime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}