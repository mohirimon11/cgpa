using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CgpaApp
{
    public partial class Form1 : Form
    {
        List<int> Ids = new List<int>();
        List<string> Names = new List<string>();
        List<int> Mobiles = new List<int>();
        List<int> Ages = new List<int>();
        List<string> AddressAll = new List<string>();
        List<double> Gpas = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Ids.Add(Convert.ToInt32(idTextBox.Text));
            Names.Add(nameTextBox.Text);
            Mobiles.Add(Convert.ToInt32(mobileTextBox.Text));
            AddressAll.Add(addressTextBox.Text);
            Gpas.Add(Convert.ToDouble(gpaTextBox.Text));
            MessageBox.Show("save success");
             displayTextBox.Text = "information is:\n id: " + Ids + "\nName: " + Names + "\nMobile no: "
                + Mobiles + "\nAddress: " + AddressAll + "\nGpa: " + Gpas + "\n\n\n";

        }
        public void message()
        {
            string message = " ";
            for (int i=0;i<Ids.Count;i++)
            {
                message += "information is:\n id: " + Ids[i] + "\nName: " + Names[i] + "\nMobile no: "
                + Mobiles[i] + "\nAddress: " + AddressAll[i] + "\nGpa: " + Gpas[i] + "\n\n\n";
            }
            displayTextBox.Text = message;
            
        }
    }
}
