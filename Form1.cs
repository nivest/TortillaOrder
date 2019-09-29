using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Tortilla_Order
{
    public partial class Form1 : Form
    {
        
        const double Price_checkBox6 = 3;
        const double Price_checkBox7 = 3;
        const double Price_checkBox8 = 3;
        const double Price_checkBox9 = 3;
        const double Price_checkBox10 = 3;
        const double Price_checkBox17 = 3;
        const double Price_checkBox16 = 3;
        const double Price_checkBox15 = 3;
        const double Price_checkBox14 = 3;
        const double Price_checkBox13 = 3;
        const double Price_checkBox5 = 3;
        const double Price_checkBox4 = 3;
        const double Price_checkBox3 = 3;
        const double Price_checkBox2 = 3;
        const double Price_checkBox1 = 3;
        const double Price_checkBox11 = 3;
        const double Price_checkBox12 = 3;

  
        double Tax, SubTotal, Total;

        public double Tax_Rate = 25;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e) //Exit button
        {
            DialogResult button3;

            button3 = MessageBox.Show("Confirm you want to Exit the System", "Tortilla Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (button3 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void RestTextBoxes() //Reset na 0
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void RestCheckBoxes() //Reset na prazno checkbox
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();

        }

        private void Form1_Load(object sender, EventArgs e) //Promjena nacina placanja
        {
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Amex");

            EnableTextBoxes();


        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)//check-pisanje,maknuti check sve je maknuto (Chicken Tortilla)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();

            }

            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) //Sea Tortilla
        {
            if (checkBox7.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();

            }

            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) //Vegetables Tortilla
        {
            if (checkBox8.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();

            }

            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)//Chili Peppers Tortilla
        {
            if (checkBox9.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();

            }

            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)//Pizza Tortilla
        {
            if (checkBox10.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();

            }

            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)//Fruit Burritos
        {
            if (checkBox17.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();

            }

            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)//Caramel Tortilla
        {
            if (checkBox16.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();

            }

            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)//Nutella Tortilla
        {
            if (checkBox15.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();

            }

            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)//Ice Cream Tortilla
        {
            if (checkBox14.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();

            }

            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)//Cheesecake Tortilla
        {
            if (checkBox13.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();

            }

            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)//Orange Juice
        {
            if (checkBox5.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();

            }

            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)//Apple Juice
        {
            if (checkBox4.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();

            }

            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//Blueberry Juice
        {
            if (checkBox3.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();

            }

            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//Cherry Juice
        {
            if (checkBox2.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();

            }

            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//Aronia Juice
        {
            if (checkBox1.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();

            }

            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Mogucnost odabira Cash - Payment method
        {
            if (comboBox1.Text == "Cash")
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[] itemcost = new double[17];
            itemcost[0] = Convert.ToDouble(textBox6.Text) * Price_checkBox6;
            itemcost[1] = Convert.ToDouble(textBox3.Text) * Price_checkBox7;
            itemcost[2] = Convert.ToDouble(textBox1.Text) * Price_checkBox8;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * Price_checkBox9;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * Price_checkBox10;
            itemcost[5] = Convert.ToDouble(textBox15.Text) * Price_checkBox17;
            itemcost[6] = Convert.ToDouble(textBox18.Text) * Price_checkBox16;
            itemcost[7] = Convert.ToDouble(textBox20.Text) * Price_checkBox15;
            itemcost[8] = Convert.ToDouble(textBox17.Text) * Price_checkBox14;
            itemcost[9] = Convert.ToDouble(textBox16.Text) * Price_checkBox13;
            itemcost[10] = Convert.ToDouble(textBox7.Text) * Price_checkBox5;
            itemcost[11] = Convert.ToDouble(textBox10.Text) * Price_checkBox4;
            itemcost[12] = Convert.ToDouble(textBox12.Text) * Price_checkBox3;
            itemcost[13] = Convert.ToDouble(textBox9.Text) * Price_checkBox2;
            itemcost[14] = Convert.ToDouble(textBox8.Text) * Price_checkBox1;
            itemcost[15] = Convert.ToDouble(textBox13.Text) * Price_checkBox11;
            itemcost[16] = Convert.ToDouble(textBox14.Text) * Price_checkBox12;

            double cost, Change;
            if (comboBox1.Text == "Cash")
            {
                SubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16];
                textBox21.Text = Convert.ToString(SubTotal);

                Tax = (SubTotal * Tax_Rate) / 100;
           
                textBox19.Text = Convert.ToString(Tax);

                Total = (SubTotal + Tax);
                textBox22.Text = Convert.ToString(Total);

                Change = Convert.ToDouble(textBox2.Text);
                cost = Change - (Tax + Total);
                textBox11.Text = Convert.ToString(cost);
                textBox11.Text = String.Format("{0:C}", cost);
                textBox19.Text = String.Format("{0:C}", Tax);
                textBox21.Text = String.Format("{0:C}", SubTotal);
                textBox22.Text = String.Format("{0:C}", Total);
            }
            else
            {
                SubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16];

                textBox21.Text = Convert.ToString(SubTotal);

                Tax = SubTotal * Tax_Rate / 100;
                textBox19.Text = Convert.ToString(Tax);
                Total = SubTotal + Tax;
                textBox22.Text = Convert.ToString(Total);


                textBox19.Text = String.Format("{0:C}", Tax);
                textBox21.Text = String.Format("{0:C}", SubTotal);
                textBox22.Text = String.Format("{0:C}", Total);

                string conn = "URI=file:tortilla.db";
                SQLiteConnection databaseConnection = new SQLiteConnection(conn);
                databaseConnection.Open();

                SQLiteCommand command = databaseConnection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS TOTAL(ID INTEGER PRIMARY KEY, TOTAL NUMERIC NOT NULL, TAX NUMERIC NOT NULL);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO TOTAL(total, tax) VALUES('" + Total + "', '" + Tax + "');";
                command.ExecuteNonQuery();
                command.Dispose();
                databaseConnection.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)//Green Smoothie
        {
            if (checkBox11.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();

            }

            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)//Water
        {
            if (checkBox12.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();

            }

            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }

        }


        internal class Method
        {
            public Method()
            {
            }
        }
    }
}
    
