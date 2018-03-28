//Program: Comic Character Conventon Tickets
//Developer: Anthony Milisci
//Date: 12-6-2017
//Purpose: To calculate the cost of convention ticket

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chptr5_Case3_ComicCharacterConvention
{
    public partial class frmComicCharacterConvention : Form
    {
        public frmComicCharacterConvention()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Declaring variables
            Decimal decConvention = 199M;
            Decimal decAutographs = 225M;
            Decimal decSuperhero = 330M;
            Decimal decPreview = 59M;
            Decimal decGroupSize;
            Decimal decFinalCost;

            try
            {
                //Assign decimal value
                decGroupSize = Convert.ToDecimal(txtGroupSize.Text);

                //Is the group size greater than 0 and less than 20
                if (decGroupSize > 0 || decGroupSize <= 20)
                {
                    //Determine type of badge selected, determine if preview was selected, and calculate then display cost
                    if (radConvention.Checked)
                    {
                        decFinalCost = decConvention* decGroupSize;
                        if (chkPreview.Checked)
                        {
                            decFinalCost = decFinalCost + decPreview;
                        }
                        lblTotalCost.Text = "Registration Cost: " + Convert.ToString(decFinalCost);
                    }
                    else if (radAutographs.Checked) {
                        decFinalCost = decAutographs * decGroupSize;
                        if (chkPreview.Checked)
                        {
                            decFinalCost = decFinalCost + decPreview;
                        }
                        lblTotalCost.Text = "Registration Cost: " + Convert.ToString(decFinalCost);
                    }   
                    else if (radSuperheroExperience.Checked) {
                        decFinalCost = decSuperhero * decGroupSize;
                        if (chkPreview.Checked)
                        {
                            decFinalCost = decFinalCost + decPreview;
                        }
                        lblTotalCost.Text = "Registration Cost: " + Convert.ToString(decFinalCost);
                    } 
                }
                else
                {
                    //Prompt the user to enter a valid numeric value
                    MessageBox.Show("You entered " + txtGroupSize.Text + ", please enter a numeric value greater than 0 and less than 20");
                }

            }
            catch
            {
                //Prompt the user to enter a valid numeric value
                MessageBox.Show("You entered " + txtGroupSize.Text + ", please enter a numeric value greater than 0 and less than 20");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all inputed and outputted data
            lblTotalCost.Text = "Registration Cost:";
            txtGroupSize.Text = "";
            chkPreview.Checked = false;
            radConvention.Checked = true;
        }
    }
}
