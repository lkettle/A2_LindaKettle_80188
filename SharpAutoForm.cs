using System;
using System.Windows.Forms;

/// <summary>
/// Assignment 2:  Car Cost Calculator by Linda Kettle 200380188 created Feb 17, 2020
///  This app takes user input for car upgrades to finish & features, and, with trade in allowance
///  calculates the final cost of car including sales tax.  
/// </summary>
/// 

namespace A2_LindaKettle_80188
{
    public partial class SharpAutoForm : Form
    {
        // constant values
        private const double _STEREO = 425.76;
        private const double _LEATHER= 987.41;
        private const double _GIS = 1741.23;
        private const double _STANDARD = 0.0;                   // unneeded
        private const double _PEARLIZED = 345.72;
        private const double _CUSTOM_DETAIL  = 599.99;
        private const double _TAX_RATE_MULTIPLIER = 1.13;
        private const double _TAX_RATE = 0.13;
        private const double _PRICE_DEFAULT = 0.0;

        // class variables   
        public double basePrice = 0.0;
        public double tradeinPrice = 0.0;
        private double _addons = 0.0;
        private double _subTotal = 0.0;
        private double _salesTax = 0.0;
        private double _total = 0.0;
        private double _amountDue = 0.0;
        private double _userNumber;
        bool myFlag = false;

        //
        // Initialize & Load
        //
        public SharpAutoForm() { InitializeComponent(); }

        private void SharpAutoForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }


        //
        // USER INPUT VALIDATION
        //
        private Boolean CheckInput(String userText)
        {
            // validates user entered text can be converted to a positive number
            // 
            // I feel like this is really clumsy & I should learn the validating option better

                try
                {
                    _userNumber = Convert.ToDouble(userText);
                    myFlag = true;
                }
                catch
                {
                    myFlag = false;
                }


            if (myFlag == true )  // using && did not work so I had to nest
            {
                if (_userNumber >= 0.0) { return true; }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
        

        //
        // Input Validation on leaving box
        //

        private void txt_base_price_Leave(object sender, EventArgs e)
        {
            // on leaving box by TAB or ENTER should check box contents

            if (!CheckInput(txt_base_price.Text))
            {
                txt_base_price.Text = "error: enter a positive number";
            }
            else
            {
                basePrice = _userNumber;
                txt_base_price.Text = basePrice.ToString("C");
            }
        }

        private void txt_tradein_Leave(object sender, EventArgs e)
        {
            if (!CheckInput(txt_tradein.Text))
            {
                txt_tradein.Text = "error: enter positive number";
            }
            else
            {
                tradeinPrice = _userNumber;
                txt_tradein.Text = tradeinPrice.ToString("C");
            }
        }

        //
        // CALCULATOR BUTTONS
        //
        private void btn_Calculate_Click(object sender, EventArgs e) { ShowResults(); }

        private void btn_Clear_Click(object sender, EventArgs e) { ClearForm(); }

        private void btn_Exit_Click(object sender, EventArgs e) { Application.Exit(); }

        //
        // FORM METHODS
        //
        private void ClearForm()
        {
            // clears form of all values, re-enters default values
            // not clear to me why addons shows "C" zero

            txt_addons.Clear();
            txt_amountDue.Clear();
            txt_sales_tax.Clear();
            txt_subtotal.Clear();
            txt_total.Clear();
            rbn_standard.Checked = true;
            cbx_GIS.Checked = false;
            cbx_leather.Checked = false;
            cbx_stereo.Checked = false;
            txt_tradein.Text = _PRICE_DEFAULT.ToString();
            txt_base_price.Text = _PRICE_DEFAULT.ToString();
        }

        private void ShowAddons()
        {
     
            txt_addons.Text = _addons.ToString("C");
        }

        private void ShowSalesTax()
        {
            //  calculates sales tax to display, to nearest penny  
            //  in Canada sales tax should be rounded to nearest nickel.

            _salesTax = (basePrice + _addons) * _TAX_RATE;
            txt_sales_tax.Text = _salesTax.ToString("C");

         }
        
        private void ShowSubtotal()
        {
            // takes internal subtotal and shows on form

            _subTotal = basePrice + _addons;
            txt_subtotal.Text = _subTotal.ToString("C");

        }

        private void ShowTotal()
        {
            // shows Total of all input prices & shows on form

             _total = _subTotal * _TAX_RATE_MULTIPLIER;
            txt_total.Text = _total.ToString("C");
            
        }

        private void ShowAmountDue()
        {
            // checks input of trade in price
            _amountDue = _total - tradeinPrice;
            txt_amountDue.Text = _amountDue.ToString("C");
         
        }

        private void ShowResults()
        {
            ShowAddons();
            ShowSalesTax();
            ShowSubtotal();
            ShowTotal();
            ShowAmountDue();        
        }

        //
        // CHECK BOXES
        //
        private void cbx_stereo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_stereo.Checked)
            {
                _addons += _STEREO;
            }
            else if (!cbx_stereo.Checked)
            {
                _addons -= _STEREO;
            }
            ShowAddons();
        }

        private void cbx_leather_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_leather.Checked)
            {
                _addons += _LEATHER;
            }
            else if (!cbx_leather.Checked)
            {
                _addons -= _LEATHER;
            }
            ShowAddons();
        }

        private void cbx_GIS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_GIS.Checked)
            {
                _addons += _GIS;
            }
            else if (!cbx_GIS.Checked)
            {
                _addons -= _GIS;
            }
            ShowAddons();
        }
        
        //
        // RADIO BUTTONS
        //
        private void rbn_standard_CheckedChanged(object sender, EventArgs e)
        {
            ShowAddons();
        }

        private void rbn_pearlized_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn_pearlized.Checked)
            {
                _addons += _PEARLIZED;
            }
            else if (!rbn_pearlized.Checked)
            {
                _addons -= _PEARLIZED;
            }
            ShowAddons();
        }

        private void rbn_custom_detail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn_custom_detail.Checked)
            {
                _addons += _CUSTOM_DETAIL;
            }
            else if (!rbn_custom_detail.Checked)
            {
                _addons -= _CUSTOM_DETAIL;
            }
            ShowAddons();
        }

        //
        // MENU OPTIONS
        //
        // file menu
        //
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        // edit menu
        //
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "I was told there would be no font requested.";
            const string caption = "About Font";
            var result = MessageBox.Show(message, caption);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "I was told there would be no color requested.";
            const string caption = "About Color";
            var result = MessageBox.Show(message, caption);
        }
        //
        // help menu
        //
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "This program calculates the amount due on a new or used vehicle.";
            const string caption = "About this Form";
            var result = MessageBox.Show(message, caption);
        }
        //
        // make ENTER act as a TAB in Base Price & Trade-In Price text boxes
        //
        private void txt_base_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_tradein_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        //
        // clears text box on mouse entry
        //
        private void txt_base_price_Click(object sender, EventArgs e)
        {
            txt_base_price.Clear();
        }

        private void txt_tradein_Click(object sender, EventArgs e)
        {
            txt_tradein.Clear();
        }
    }
}
