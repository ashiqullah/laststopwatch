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
using System.Threading;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stp = new Stopwatch();
            stp.Start();
            Thread.Sleep(2000);
            stp.Stop();
            MessageBox.Show(stp.ElapsedMilliseconds.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            var user = from usr in ctx.Tables select usr;
            Table tbl = new Table()
            {
                name = "ashiqullah",
                email = "ashiqullah.sahibzai@yahoo.com",
                Id = 2

            };
            ctx.Tables.InsertOnSubmit(tbl);
            ctx.SubmitChanges();
            MessageBox.Show("value insserted");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
