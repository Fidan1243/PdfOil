using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        double hb = 0; double fp = 0; double cc = 0;
        double total1 = 0;
        double total1m = 0;
        double total2 = 0;
        double total3 = 0;
        public double Price { get; set; }
        List<Oils> Oils = new List<Oils>
        {
            new Oils
            {
                Name = "A-76",
                Price = 3.45
            },
            new Oils
            {
                Name = "A-92",
                Price = 4.45
            },
            new Oils
            {
                Name = "Premium",
                Price = 6.45
            }
        };
        List<FastFood> Foods = new List<FastFood>
        {
            new FastFood
            {
                Name = "Hotdog",
                Price = 3.20
            },
            new FastFood
            {
                Name = "Hamburger",
                Price = 7.40
            },
            new FastFood
            {
                Name = "Fried Potato",
                Price = 5.90
            },
            new FastFood
            {
                Name = "Coca-Cola",
                Price = 1.25
            }
        };
        public Form1()
        {
            InitializeComponent();
            oilCombo.Items.AddRange(Oils.ToArray());
            oilCombo.DisplayMember = "Name";

        }
        private void oilCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Oils)
            {
                if (item.Name == oilCombo.SelectedItem.ToString())
                {
                    textBox1.Text = item.Price.ToString();
                    Price = item.Price;
                    litr.Enabled = true;
                    money.Enabled = true;
                    break;
                }
            }
        }

        private void litr_CheckedChanged(object sender, EventArgs e)
        {
            litrbox.Enabled = true;
            if (moneybox.Enabled)
            {
                moneybox.Enabled = false;
            }
        }

        private void money_CheckedChanged(object sender, EventArgs e)
        {
            moneybox.Enabled = true;
            if (litrbox.Enabled)
            {
                litrbox.Enabled = false;
            }
        }

        private void litrbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            total1 = Convert.ToDouble(litrbox.Text);
            total1 *= Price;
            T1.Visible = true;
            azn1.Visible = true;
            T1.Text = total1.ToString();
        }

        private void litrbox_MouseLeave(object sender, EventArgs e)
        {
            if (litrbox.Enabled && litrbox.Text != string.Empty)
            {
                total1 = Convert.ToDouble(litrbox.Text);
                total1 *= Price;
                T1.Visible = true;
                azn1.Visible = true;
                T1.Text = total1.ToString();
                if (lt.Visible)
                {
                    lt.Visible = false;
                }
            }

        }

        private void moneybox_MouseLeave(object sender, EventArgs e)
        {
            if (moneybox.Enabled && moneybox.Text != string.Empty)
            {
                total1m = Convert.ToDouble(moneybox.Text);
                total1m /= Price;
                total1 = Convert.ToDouble(moneybox.Text);
                T1.Text = Convert.ToInt32(total1m).ToString();
                T1.Visible = true;
                lt.Visible = true;
                if (azn1.Visible)
                {
                    azn1.Visible = false;
                }
            }
        }

        private void lt_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Foods)
            {
                if (item.Name == checkBox2.Text && checkBox2.Checked != false)
                {
                    HB.Text = item.Price.ToString();
                    HB2.Enabled = true;
                    break;
                }
                else if (item.Name == checkBox2.Text && checkBox2.Checked == false)
                {
                    HB.Text = string.Empty;
                    HB2.Enabled = false;
                    break;
                }
            }
        }
        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Foods)
            {
                if (item.Name == checkBox3.Text && checkBox3.Checked != false)
                {
                    FP.Text = item.Price.ToString();
                    FP2.Enabled = true;
                    break;
                }
                else if (item.Name == checkBox3.Text && checkBox3.Checked == false)
                {
                    FP.Text = string.Empty;
                    FP2.Enabled = false;
                    break;
                }
            }
        }
        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Foods)
            {
                if (item.Name == checkBox4.Text && checkBox4.Checked != false)
                {
                    CC.Text = item.Price.ToString();
                    CC2.Enabled = true;
                    break;
                }
                else if (item.Name == checkBox4.Text && checkBox4.Checked == false)
                {
                    CC.Text = string.Empty;
                    CC2.Enabled = false;
                    break;
                }
            }
        }

        private void hdTextBox10_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            total3 = Convert.ToDouble(total1 + total2);
            T3.Text = total3.ToString();
            T3.Visible = true;
            azn3.Visible = true;

        }

        private void groupBox4_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HB2.Text != string.Empty)
            {
                int n = Convert.ToInt32(HB2.Text);
                hb = n * Convert.ToDouble(HB.Text);
                total2 += hb;
                
            }
            if (FP2.Text != string.Empty)
            {
                int n = Convert.ToInt32(FP2.Text);
                fp = n * Convert.ToDouble(FP.Text);
                total2 += n;
            }
            if (CC2.Text != string.Empty)
            {
                int n = Convert.ToInt32(CC2.Text);
                cc = n * Convert.ToDouble(CC.Text);
                total2 += cc;
            }
            T2.Text = total2.ToString();
            T2.Visible = true;
            azn2.Visible = true;
            cbutton.Enabled = true;

        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            total3 = Convert.ToDouble(T1.Text) + Convert.ToDouble(T2.Text);
            T3.Text = total3.ToString();
            azn3.Visible = true;
            T3.Visible = true;
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"C:Total.pdf", FileMode.Create));
            try
            {
                document.Open();
                document.Add(new Paragraph($@"Oil
----------
{oilCombo.SelectedItem} - {T1.Text} azn

Meal(Fast Food)
----------
Hamburger - {hb} azn
Fried Potato - {fp} azn
Coca-Cola - {cc} azn

Meal total: {T2.Text} azn
----------

Total: {T3.Text} azn"));
                document.Close();
                MessageBox.Show("Your total wrote in C:.../bin/Debug/Total.pdf file");
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }
    }
}
