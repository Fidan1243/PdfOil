
namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.litrbox = new System.Windows.Forms.MaskedTextBox();
            this.moneybox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oilCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lt = new System.Windows.Forms.Label();
            this.azn1 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.litr = new System.Windows.Forms.RadioButton();
            this.money = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.azn2 = new System.Windows.Forms.Label();
            this.T2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbutton = new System.Windows.Forms.Button();
            this.azn3 = new System.Windows.Forms.Label();
            this.T3 = new System.Windows.Forms.Label();
            this.HB2 = new System.Windows.Forms.MaskedTextBox();
            this.FP2 = new System.Windows.Forms.MaskedTextBox();
            this.CC2 = new System.Windows.Forms.MaskedTextBox();
            this.CC = new System.Windows.Forms.TextBox();
            this.FP = new System.Windows.Forms.TextBox();
            this.HB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.litrbox);
            this.groupBox1.Controls.Add(this.moneybox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.oilCombo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // litrbox
            // 
            this.litrbox.Enabled = false;
            this.litrbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litrbox.Location = new System.Drawing.Point(203, 173);
            this.litrbox.Mask = "00000";
            this.litrbox.Name = "litrbox";
            this.litrbox.Size = new System.Drawing.Size(100, 28);
            this.litrbox.TabIndex = 5;
            this.litrbox.ValidatingType = typeof(int);
            this.litrbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.litrbox_MaskInputRejected);
            this.litrbox.MouseLeave += new System.EventHandler(this.litrbox_MouseLeave);
            // 
            // moneybox
            // 
            this.moneybox.Enabled = false;
            this.moneybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneybox.Location = new System.Drawing.Point(203, 219);
            this.moneybox.Mask = "00000";
            this.moneybox.Name = "moneybox";
            this.moneybox.Size = new System.Drawing.Size(100, 28);
            this.moneybox.TabIndex = 3;
            this.moneybox.ValidatingType = typeof(int);
            this.moneybox.MouseLeave += new System.EventHandler(this.moneybox_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oil Type";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 28);
            this.textBox1.TabIndex = 1;
            // 
            // oilCombo
            // 
            this.oilCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilCombo.FormattingEnabled = true;
            this.oilCombo.Location = new System.Drawing.Point(103, 40);
            this.oilCombo.Name = "oilCombo";
            this.oilCombo.Size = new System.Drawing.Size(121, 30);
            this.oilCombo.TabIndex = 1;
            this.oilCombo.SelectedIndexChanged += new System.EventHandler(this.oilCombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lt);
            this.groupBox3.Controls.Add(this.azn1);
            this.groupBox3.Controls.Add(this.T1);
            this.groupBox3.Location = new System.Drawing.Point(6, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lt
            // 
            this.lt.AutoSize = true;
            this.lt.Location = new System.Drawing.Point(224, 70);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(15, 17);
            this.lt.TabIndex = 2;
            this.lt.Text = "lt";
            this.lt.Visible = false;
            // 
            // azn1
            // 
            this.azn1.AutoSize = true;
            this.azn1.Location = new System.Drawing.Point(224, 70);
            this.azn1.Name = "azn1";
            this.azn1.Size = new System.Drawing.Size(31, 17);
            this.azn1.TabIndex = 1;
            this.azn1.Text = "azn";
            this.azn1.Visible = false;
            // 
            // T1
            // 
            this.T1.AutoSize = true;
            this.T1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1.Location = new System.Drawing.Point(88, 35);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(118, 51);
            this.T1.TabIndex = 1;
            this.T1.Text = "Total";
            this.T1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.litr);
            this.groupBox2.Controls.Add(this.money);
            this.groupBox2.Location = new System.Drawing.Point(6, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // litr
            // 
            this.litr.AutoSize = true;
            this.litr.Enabled = false;
            this.litr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litr.Location = new System.Drawing.Point(14, 21);
            this.litr.Name = "litr";
            this.litr.Size = new System.Drawing.Size(81, 33);
            this.litr.TabIndex = 1;
            this.litr.TabStop = true;
            this.litr.Text = "Litre";
            this.litr.UseVisualStyleBackColor = true;
            this.litr.CheckedChanged += new System.EventHandler(this.litr_CheckedChanged);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Enabled = false;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(14, 69);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(98, 30);
            this.money.TabIndex = 2;
            this.money.TabStop = true;
            this.money.Text = "Money";
            this.money.UseVisualStyleBackColor = true;
            this.money.CheckedChanged += new System.EventHandler(this.money_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HB);
            this.groupBox4.Controls.Add(this.FP);
            this.groupBox4.Controls.Add(this.CC);
            this.groupBox4.Controls.Add(this.HB2);
            this.groupBox4.Controls.Add(this.FP2);
            this.groupBox4.Controls.Add(this.CC2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(412, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 398);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(87, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Total! (U have 1 chance)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(2, 160);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(119, 24);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Coca-Cola";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.guna2CheckBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(2, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(134, 24);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Fried Potato";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.guna2CheckBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(2, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Hamburger";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.azn2);
            this.groupBox5.Controls.Add(this.T2);
            this.groupBox5.Location = new System.Drawing.Point(6, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 120);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.MouseHover += new System.EventHandler(this.groupBox4_MouseHover);
            // 
            // azn2
            // 
            this.azn2.AutoSize = true;
            this.azn2.Location = new System.Drawing.Point(224, 70);
            this.azn2.Name = "azn2";
            this.azn2.Size = new System.Drawing.Size(31, 17);
            this.azn2.TabIndex = 1;
            this.azn2.Text = "azn";
            this.azn2.Visible = false;
            // 
            // T2
            // 
            this.T2.AutoSize = true;
            this.T2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2.Location = new System.Drawing.Point(88, 35);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(118, 51);
            this.T2.TabIndex = 1;
            this.T2.Text = "Total";
            this.T2.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.cbutton);
            this.groupBox6.Controls.Add(this.azn3);
            this.groupBox6.Controls.Add(this.T3);
            this.groupBox6.Location = new System.Drawing.Point(24, 436);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(740, 149);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources._1f4b0;
            this.pictureBox1.Location = new System.Drawing.Point(20, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cbutton
            // 
            this.cbutton.Enabled = false;
            this.cbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton.Location = new System.Drawing.Point(137, 38);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(137, 86);
            this.cbutton.TabIndex = 4;
            this.cbutton.Text = "Calculate";
            this.cbutton.UseVisualStyleBackColor = true;
            this.cbutton.Click += new System.EventHandler(this.cbutton_Click);
            // 
            // azn3
            // 
            this.azn3.AutoSize = true;
            this.azn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azn3.Location = new System.Drawing.Point(604, 89);
            this.azn3.Name = "azn3";
            this.azn3.Size = new System.Drawing.Size(36, 20);
            this.azn3.TabIndex = 2;
            this.azn3.Text = "azn";
            this.azn3.Visible = false;
            // 
            // T3
            // 
            this.T3.AutoSize = true;
            this.T3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T3.Location = new System.Drawing.Point(425, 49);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(164, 69);
            this.T3.TabIndex = 3;
            this.T3.Text = "Total";
            this.T3.Visible = false;
            // 
            // HB2
            // 
            this.HB2.Enabled = false;
            this.HB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HB2.Location = new System.Drawing.Point(267, 58);
            this.HB2.Mask = "00000";
            this.HB2.Name = "HB2";
            this.HB2.Size = new System.Drawing.Size(100, 28);
            this.HB2.TabIndex = 7;
            this.HB2.ValidatingType = typeof(int);
            // 
            // FP2
            // 
            this.FP2.Enabled = false;
            this.FP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FP2.Location = new System.Drawing.Point(267, 102);
            this.FP2.Mask = "00000";
            this.FP2.Name = "FP2";
            this.FP2.Size = new System.Drawing.Size(100, 28);
            this.FP2.TabIndex = 8;
            this.FP2.ValidatingType = typeof(int);
            // 
            // CC2
            // 
            this.CC2.Enabled = false;
            this.CC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC2.Location = new System.Drawing.Point(267, 156);
            this.CC2.Mask = "00000";
            this.CC2.Name = "CC2";
            this.CC2.Size = new System.Drawing.Size(100, 28);
            this.CC2.TabIndex = 9;
            this.CC2.ValidatingType = typeof(int);
            // 
            // CC
            // 
            this.CC.Enabled = false;
            this.CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC.Location = new System.Drawing.Point(161, 156);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(100, 28);
            this.CC.TabIndex = 17;
            // 
            // FP
            // 
            this.FP.Enabled = false;
            this.FP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FP.Location = new System.Drawing.Point(161, 102);
            this.FP.Name = "FP";
            this.FP.Size = new System.Drawing.Size(100, 28);
            this.FP.TabIndex = 18;
            // 
            // HB
            // 
            this.HB.Enabled = false;
            this.HB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HB.Location = new System.Drawing.Point(161, 58);
            this.HB.Name = "HB";
            this.HB.Size = new System.Drawing.Size(100, 28);
            this.HB.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 597);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox oilCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox litrbox;
        private System.Windows.Forms.MaskedTextBox moneybox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lt;
        private System.Windows.Forms.Label azn1;
        private System.Windows.Forms.Label T1;
        private System.Windows.Forms.RadioButton litr;
        private System.Windows.Forms.RadioButton money;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label azn2;
        private System.Windows.Forms.Label T2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.Label azn3;
        private System.Windows.Forms.Label T3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox HB2;
        private System.Windows.Forms.MaskedTextBox FP2;
        private System.Windows.Forms.MaskedTextBox CC2;
        private System.Windows.Forms.TextBox HB;
        private System.Windows.Forms.TextBox FP;
        private System.Windows.Forms.TextBox CC;
    }
}

