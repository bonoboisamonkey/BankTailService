using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankService
{
    public partial class Bank : Form
    {
        private generateCheck _check;
        public Bank()
        {
            InitializeComponent();
            _check = new generateCheck();

        }    
        private void Btn_A_Click(object sender, EventArgs e)
        {
            lbl_check.Text = _check.createCheck("A");
        
        }
        private void Btn_B_Click(object sender, EventArgs e)
        {
            lbl_check.Text = _check.createCheck("B");
        }
        private void Btn_C_Click(object sender, EventArgs e)
        {
            lbl_check.Text = _check.createCheck("C");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_user.Text = _check.deleteCheck();
        }
    }
}
