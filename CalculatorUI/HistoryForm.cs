using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorDataSet.Calculator_Table' table. You can move, or remove it, as needed.
            this.calculator_TableTableAdapter.Fill(this.calculatorDataSet.Calculator_Table);

        }
    }
}
