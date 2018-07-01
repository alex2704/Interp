using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyntaxTree;

namespace Interpritator
{
    public partial class InterpForm : Form
    {
        public InterpForm()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Tree tree = new Tree(Input.Text);
                Output.Text = tree.GetValue().ToString();
            }
            catch (Exception)
            {
                Output.Text = " ";
            }
        }
    }
}
