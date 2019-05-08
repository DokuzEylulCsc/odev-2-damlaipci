using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteSistemi
{
    public partial class Baslangıc : Form
    {
        public Baslangıc()
        {
            InitializeComponent();
        }
        Universite universite = new Universite();
        public static int FakulteNo;
        bool flag;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NoTxtBox.Text != "")
            {
                FakulteNo = Convert.ToInt32(NoTxtBox.Text);
                foreach (int no in Universite.Fakulte.Keys)
                {
                    if (NoTxtBox == no)
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    this.Hide();
                    b.Show();
                }
            }
            else
            {
                MessageBox.Show("Once bir ID girmeniz gerekiyor", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
