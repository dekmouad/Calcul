using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace BLL
{
    public class CalculatorBLL
    {
        CalculatorDAL dal = new CalculatorDAL();
        bool optSit= false;
        double nm1 = 0;
        public void databaseConnection(string opt,double num1,double num2,double result)
        {
            dal.InsertResult(opt,num1,num2,result);
        }
        public string AddNumber(string num1, string num2)
        {
            return num1 + num2;
        }
        public string ActionMade(string num1, string num2, string opt)
        {
            optSit = true;
            Button btn = new Button();
            string newOpt = btn.Text;
            switch (opt)
            {
                case "+": num1 = (nm1 + Double.Parse(num1)).ToString(); break;
                case "-": num1 = (nm1 - Double.Parse(num1)).ToString(); break;
                case "*": num1 = (nm1 * Double.Parse(num1)).ToString(); break;
                case "/": num1 = (nm1 / Double.Parse(num1)).ToString(); break;    
            }
            opt = newOpt;
            return num1 + opt + num2;
        }
        public string EqualResult(string num1, string num2, string opt)
        {
            switch (opt)
            {
                case "+":
                    nm1 = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                    break;
                case "-":
                    nm1 = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                    break;
                case "*":
                    nm1 = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                    break; ;
                case "/":
                    nm1 = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    break;
                default: return nm1.ToString();
            }
            return nm1.ToString();
        }
    }
}
