using _19011337_PROG7311_ACT1.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19011337_PROG7311_ACT1
{
    public partial class MainForm : Form
    {      
        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Button that will open a JOptionPane, and edit the text of the label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterTxtBtn_Click(object sender, EventArgs e)
        {
            OptionPaneClone msgBox = new OptionPaneClone();
            
            if(msgBox.ShowDialog(this) == DialogResult.OK)
            {
                TextLbl.Text = msgBox.GetText;
            }
            else
            {

            }
        }
    }
}
//-------------------------------------------end of file-------------------------------------------------
