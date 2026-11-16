using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestButtonLibrary;


namespace TestButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        TestForm testForm;

        private void button1_Click(object sender, EventArgs e)
        {
            testForm = new StandardTestForm();
            MessageBox.Show(testForm.ShowTest());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testForm = new SingleChoiceTestForm();
            MessageBox.Show(testForm.ShowTest());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testForm = new MultipleChoiceTestForm();
            MessageBox.Show(testForm.ShowTest());
        }

    }
}
