using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace CalculatorUI
{
    public partial class CalculatorForm : Form
    {HistoryForm HistoryForm;
        CalculatorBLL bll;
        CalculatorDAL dal;
        double result = 0;
        bool optSit = false;
        string nm1 = "", nm2 = "";
        bool isFirst = true;
        string opt = "";
        public CalculatorForm()
        {
            InitializeComponent();
            bll = new CalculatorBLL();
            dal = new CalculatorDAL();
        }

        private void Actions(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (!optSit)
            {
                opt = clickedButton.Text;
                return;
            }
            optSit = false;
            if (isFirst)
            {
                nm1 = txtValue.Text;
                lblValue.Text = nm1;
                isFirst = false;
                txtValue.Text = "";
                opt = clickedButton.Text;
            }
            else
            {
                nm2 = txtValue.Text;
                nm1 = bll.EqualResult(nm1, nm2, opt);
                opt = clickedButton.Text;
                txtValue.Text = "";
                nm2 = "";
            }

            lblValue.Text = nm1; //+ opt;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "" && lblValue.Text != "")
            {
                nm2 = txtValue.Text;
                if (nm1 != "" && nm2 != "" && opt != "")
                {
                    lblResult.Text = bll.EqualResult(nm1, nm2, opt);
                }
                lstEquals.Items.Add(lblResult.Text);
                bll.databaseConnection(opt,Double.Parse(lblValue.Text),Double.Parse(txtValue.Text),Double.Parse(lblResult.Text));
                txtValue.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
            lblValue.Text = "";
            isFirst = true;
            optSit = false;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" || txtValue.Text == "-")
                txtValue.Clear();
            optSit = false;
            Button b = sender as Button;
            txtValue.Text += "-";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int lenght = txtValue.Text.Length;
            if (lenght > 0)
            {
                txtValue.Text = txtValue.Text.Substring(0, lenght - 1);
            }
            txtValue.Focus();
            txtValue.SelectionStart = txtValue.Text.Length;
            txtValue.SelectionLength = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Text += ",";
            }
            else if (txtValue.Text == "")
            {
                txtValue.Text = ("");
            }
            else if (txtValue.Text != "0")
            {
                txtValue.Text += (",");
            }
            return;
        }

        private void Btnhistory_Click(object sender, EventArgs e)
        {
            HistoryForm = new HistoryForm();
            HistoryForm.Show();
            HistoryForm.Owner = this;
            HistoryForm.lstHistory.DataSource = lstEquals.Items;
         
        }

        private void Numbers(object sender, EventArgs e)
        {
            if (txtValue.Text == "0") txtValue.Clear();
            Button clickedButton = sender as Button;
            string sonuc = bll.AddNumber(txtValue.Text, clickedButton.Text);
            txtValue.Text = sonuc;
            optSit= true;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 265; // 859
           txtValue.Width = 215;
         
        }
        private void scientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 530; // 859
            txtValue.Width = 470;
           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientifique Cal",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtValue.Text = "3.141592653589976323";
            lblValue.Text = "0";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("log" + "(" + (txtValue.Text) + ")" + "=");
            optSit = true;
            double logg = Convert.ToDouble(txtValue.Text);
            logg = Math.Log10(logg);
            lblResult.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("sqrt" + "(" + (txtValue.Text) + ")" + "=");
            optSit = true;
            double sq = Convert.ToDouble(txtValue.Text);
            sq = Math.Sqrt(sq);
            lblResult.Text = Convert.ToString(sq);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString((txtValue.Text) + "²" + "=");

            optSit = true;
            double x;

            x = Convert.ToDouble(txtValue.Text) * Convert.ToDouble(txtValue.Text);
            lblResult.Text = Convert.ToString(x);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString((txtValue.Text) + "³" + "=");

            optSit = true;
            double x, q, p, m;

            q = Convert.ToDouble(txtValue.Text);
            p = Convert.ToDouble(txtValue.Text);
            m = Convert.ToDouble(txtValue.Text);

            x = (q * p * m);
            lblResult.Text = Convert.ToString(x);
        }

        private void btnHsin_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("hsin" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double sh = Convert.ToDouble(txtValue.Text);
            sh = Math.Sinh(sh);
            lblResult.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("sin" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double sin = Convert.ToDouble(txtValue.Text);
            sin = Math.Sin(sin);
            lblResult.Text = Convert.ToString(sin);
        }

        private void btnHcos_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("hcos" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double ch = Convert.ToDouble(txtValue.Text);
            ch = Math.Cosh(ch);
            lblResult.Text = Convert.ToString(ch);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("cos" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double cos = Convert.ToDouble(txtValue.Text);
            cos = Math.Cos(cos);
            lblResult.Text = Convert.ToString(cos);
        }

        private void btnHtan_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("htan" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double th = Convert.ToDouble(txtValue.Text);
            th = Math.Tanh(th);
            lblResult.Text = Convert.ToString(th);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("tan" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double tan = Convert.ToDouble(txtValue.Text);
            tan = Math.Tan(tan);
            lblResult.Text = Convert.ToString(tan);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("1" + "/" + (txtValue.Text) + "=");

            optSit = true;
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtValue.Text));
            lblResult.Text = Convert.ToString(a);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("ln" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double ln = Convert.ToDouble(txtValue.Text);
            ln = Math.Log(ln);
            lblResult.Text = Convert.ToString(ln);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("%" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double a;
            a = Convert.ToDouble(txtValue.Text) / Convert.ToDouble(100);
            lblResult.Text = Convert.ToString(a);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("Dec" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            double dec = Convert.ToDouble(txtValue.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            lblResult.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("Bin" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            int a = int.Parse(txtValue.Text);
            lblResult.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("Hex" + "(" + (txtValue.Text) + ")" + "=");

            optSit = true;
            int a = int.Parse(txtValue.Text);
            lblResult.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            lblValue.Text = System.Convert.ToString("Oct" + "(" + (txtValue.Text) + ")" + "=");
            optSit = true;
            int a = int.Parse(txtValue.Text);
            lblResult.Text = Convert.ToString(a, 8);
            
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm = new HistoryForm();
            HistoryForm.Show();
            HistoryForm.Owner = this;
            HistoryForm.lstHistory.DataSource = lstEquals.Items;
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 265; // 859
            txtValue.Width = 215;
        }






    }
}
