using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrimesWindows
{
    public partial class Form1 : Form
    {

        Int64 NoOfPrimes;
        List<Int64> Primes = new List<Int64>();
        Stopwatch StopWatch = new Stopwatch();


        public Form1()
        {
            InitializeComponent();
        }

        private void NumberSelection_ValueChanged(object sender, EventArgs e)
        {
            NoOfPrimes = (Int64)NumberSelection.Value;
            progressBar1.Value = 0;
            Primes.Clear();
            progressBar1.Maximum = (int)NoOfPrimes;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            FindPrimes();
        }

        bool IsPrime(Int64 numberamount)
        {
            bool yorn = true;
            for (int i = 2; i < numberamount - 1; i++)
            {
                if (numberamount % i == 0)
                {
                    yorn = false;
                    break;
                }
            }
            return yorn;
        }

        void FindPrimes()
        {

            StopWatch.Start();

            for (int x = 2; Primes.Count() != NoOfPrimes; x++)
            {
                if (IsPrime(x) == true)
                {
                    Primes.Add(x);
                    progressBar1.Value = Primes.Count();
                    TimeLabel.Text = StopWatch.Elapsed.ToString();
                    richTextBox1.AppendText(x.ToString());
                    richTextBox1.AppendText("\n");
                }
            }

            StopWatch.Stop();

            progressBar1.Value = 0;

        }


    }
}