using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cache_num0, cache_num1;

        private bool IsNumValid()
        {
            bool success0, success1;
            success0 = int.TryParse(tbNum1.Text, out cache_num0);
            success1 = int.TryParse(tbNum2.Text, out cache_num1);

            return success0 && success1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsNumValid())
            {
                tbResult.Text = (cache_num0 + cache_num1).ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (IsNumValid())
            {
                tbResult.Text = (cache_num0 - cache_num1).ToString();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (IsNumValid())
            {
                tbResult.Text = (cache_num0 * cache_num1).ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumValid())
                {
                    tbResult.Text = (cache_num0 / cache_num1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                string error_message = string.Empty;
                error_message += ex.Message + "\r\n";
                error_message += ex.StackTrace + "\r\n";
                error_message += ex.Source + "\r\n";
                File.WriteAllText("error.log", error_message);
            }
            finally
            {

            }
            
        }
    }
}
