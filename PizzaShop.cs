using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class PizzaShop : Form
    {
        public PizzaShop()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_crust_order.Text = "Thin Crust";
        }

        private void rb_small_size_CheckedChanged(object sender, EventArgs e)
        {

            int Price = Convert.ToInt32(lbl_price_amount.Text);

            if (rb_small_size.Checked)
                Price += 5;
            else
                Price -= 5;

            lbl_price_amount.Text = Price.ToString();

            lbl_size_order.Text = "Small";

        }

        private void rb_medium_size_CheckedChanged(object sender, EventArgs e)
        {

            int Price = Convert.ToInt32(lbl_price_amount.Text);

            if (rb_medium_size.Checked)
                Price += 10;
            else
                Price -= 10;

            lbl_price_amount.Text = Price.ToString();

            lbl_size_order.Text = "Medium";

        }

        private void rb_large_size_CheckedChanged(object sender, EventArgs e)
        {

            int Price = Convert.ToInt32(lbl_price_amount.Text);

            if (rb_large_size.Checked)
                Price += 15;
            else
                Price -= 15;

            lbl_price_amount.Text = Price.ToString();

            lbl_size_order.Text = "Large";

        }

        private void rd_thick_crust_CheckedChanged(object sender, EventArgs e)
        {
            lbl_crust_order.Text = "Thick Crust";
        }

        private void Topping_Order(string Topping, bool cb_Checked)
        {

            int Price = Convert.ToInt32(lbl_price_amount.Text);

            if (cb_Checked)
            {

                Price += 5;

                if (lbl_toppings_order.Text == "Unknown")
                    lbl_toppings_order.Text = "";

                lbl_toppings_order.Text = lbl_toppings_order.Text.Replace(".", ", ");

                lbl_toppings_order.Text += Topping + '.';

            }
            else
            {

                Price -= 5;

                int Index = lbl_toppings_order.Text.IndexOf(Topping);

                int LengthRemove = Topping.Length;

                if (lbl_toppings_order.Text[Index + LengthRemove] == ',')
                    LengthRemove += 2;
                else if (Index > 0)
                {
                    Index -= 2;
                    LengthRemove += 2;
                }
                else
                    ++LengthRemove;

                lbl_toppings_order.Text = lbl_toppings_order.Text.
                    Remove(Index, LengthRemove);

            }

            if (lbl_toppings_order.Text == "")
                lbl_toppings_order.Text = lbl_toppings_order.Tag.ToString();

            lbl_price_amount.Text = Price.ToString();

        }

        private void cb_ex_cheese_order_CheckedChanged(object sender, EventArgs e)
        {
            Topping_Order("Extra Cheese", cb_ex_cheese_order.Checked);
        }

        private void cb_mushrooms_order_CheckedChanged(object sender, EventArgs e)
        {
            Topping_Order("Mushrooms", cb_mushrooms_order.Checked);
        }

        private void cb_tomatoes_order_CheckedChanged(object sender, EventArgs e)
        {
            Topping_Order("Tomatoes", cb_tomatoes_order.Checked);
        }

        private void cb_order_onions_CheckedChanged(object sender, EventArgs e)
        {
            Topping_Order("Onions", cb_order_onions.Checked);
        }

        private void cb_order_olives_CheckedChanged(object sender, EventArgs e)
        {
            Topping_Order("Olives", cb_order_olives.Checked);
        }

        private void cb_order_green_peppers_CheckedChanged(object sender, EventArgs e)
        {
            Topping_Order("Green Peppers", cb_order_green_peppers.Checked);
        }

        private void lb_summary_eat_place_choice_Click(object sender, EventArgs e)
        {

        }

        private void rb_eat_place_outside_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_eat_place_outside.Checked)
                lb_summary_eat_place_choice.Text = "Outside";
        }

        private void lbl_size_order_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {

            if (lbl_crust_order.Text != lbl_crust_order.Tag.ToString() &&
                lb_summary_eat_place_choice.Text != lb_summary_eat_place_choice.Tag.ToString() &&
                lbl_toppings_order.Text != lbl_toppings_order.Tag.ToString() &&
                lbl_size_order.Text != lbl_size_order.Tag.ToString())
            MessageBox.Show("Ordered Successfully!", "Succeessful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ordered Failed!\nSomething Is Missing In Your Order.", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            rb_small_size.Checked = false;

            rb_medium_size.Checked = false;

            rb_large_size.Checked = false;

            rb_eat_place_outside.Checked = false;

            rb_eat_place_eat_in.Checked = false;

            rb_thin_crust.Checked = false;

            rb_thick_crust.Checked = false;

            cb_ex_cheese_order.Checked = false;

            cb_mushrooms_order.Checked = false;

            cb_order_green_peppers.Checked = false;

            cb_order_olives.Checked = false;

            cb_order_onions.Checked = false;

            cb_tomatoes_order.Checked = false;

            lbl_size_order.Text = lbl_size_order.Tag.ToString();

            lbl_toppings_order.Text = lbl_toppings_order.Tag.ToString();

            lbl_crust_order.Text = lbl_crust_order.Tag.ToString();

            lb_summary_eat_place_choice.Text = lb_summary_eat_place_choice.Tag.ToString();

        }

        private void rb_eat_place_eat_in_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_eat_place_eat_in.Checked == true)
                lb_summary_eat_place_choice.Text = "Eat In";
        }

    }

}
