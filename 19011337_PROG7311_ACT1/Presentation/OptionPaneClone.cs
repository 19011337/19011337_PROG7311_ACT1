using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19011337_PROG7311_ACT1.Presentation
{
    public partial class OptionPaneClone : Form
    {
        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Get/set method to retrieve the text
        /// </summary>
        public String GetText { get; set; }

        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        public OptionPaneClone()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to accept text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterNewTxtBtn_Click(object sender, EventArgs e)
        {
            //making the enter text button, the 'ok' result.
            this.EnterNewTxtBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            //setting the text
            GetText = NewTxtBox.Text;
        }
    }
}
//-------------------------------------------end of file-------------------------------------------------
