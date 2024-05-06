namespace PizzaApp
{
    partial class PizzaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            CLBxToppings = new CheckedListBox();
            label6 = new Label();
            label5 = new Label();
            CBxSpecialtyPizzas = new ComboBox();
            label4 = new Label();
            CBxSauce = new ComboBox();
            label3 = new Label();
            CBxCrust = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lbName = new Label();
            CBxSize = new ComboBox();
            tabPage2 = new TabPage();
            label12 = new Label();
            TBxWater = new TextBox();
            TBxSoda = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabPage3 = new TabPage();
            CBxOtherItems = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            tabPage4 = new TabPage();
            TBxEmail = new TextBox();
            TBxPhone = new TextBox();
            TBxDeliveryAddress = new TextBox();
            TBxName = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            BTNxResetOrder = new Button();
            BTNxPlaceOrder = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 362);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(CLBxToppings);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(CBxSpecialtyPizzas);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(CBxSauce);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(CBxCrust);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lbName);
            tabPage1.Controls.Add(CBxSize);
            tabPage1.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 334);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pizza";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CLBxToppings
            // 
            CLBxToppings.CheckOnClick = true;
            CLBxToppings.FormattingEnabled = true;
            CLBxToppings.Location = new Point(472, 106);
            CLBxToppings.Name = "CLBxToppings";
            CLBxToppings.Size = new Size(194, 144);
            CLBxToppings.Sorted = true;
            CLBxToppings.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(529, 78);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 11;
            label6.Text = "Toppings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(316, 285);
            label5.Name = "label5";
            label5.Size = new Size(168, 34);
            label5.TabIndex = 9;
            label5.Text = "Pizza Selections";
            // 
            // CBxSpecialtyPizzas
            // 
            CBxSpecialtyPizzas.FormattingEnabled = true;
            CBxSpecialtyPizzas.Items.AddRange(new object[] { "Moutain of Meat", "BBQ Chicken", "Buffalo Chicken", "Veggie", "Thai Pie" });
            CBxSpecialtyPizzas.Location = new Point(83, 245);
            CBxSpecialtyPizzas.Name = "CBxSpecialtyPizzas";
            CBxSpecialtyPizzas.Size = new Size(171, 27);
            CBxSpecialtyPizzas.TabIndex = 8;
            CBxSpecialtyPizzas.SelectedIndexChanged += CBxSpecialtyPizzas_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(96, 223);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 7;
            label4.Text = "Specialty Pizzas";
            // 
            // CBxSauce
            // 
            CBxSauce.DropDownStyle = ComboBoxStyle.DropDownList;
            CBxSauce.FormattingEnabled = true;
            CBxSauce.Items.AddRange(new object[] { "Red Sauce", "Pesto", "Alfredo", "Buffalo" });
            CBxSauce.Location = new Point(83, 193);
            CBxSauce.Name = "CBxSauce";
            CBxSauce.Size = new Size(171, 27);
            CBxSauce.TabIndex = 6;
            CBxSauce.SelectedIndexChanged += CBxSauce_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 171);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 5;
            label3.Text = "Sauce";
            // 
            // CBxCrust
            // 
            CBxCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            CBxCrust.FormattingEnabled = true;
            CBxCrust.Items.AddRange(new object[] { "Pan Crust", "Thin Crust", "Garlic Crust", "Detroit Crust" });
            CBxCrust.Location = new Point(83, 139);
            CBxCrust.Name = "CBxCrust";
            CBxCrust.Size = new Size(171, 27);
            CBxCrust.TabIndex = 4;
            CBxCrust.SelectedIndexChanged += CBxCrust_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 117);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 3;
            label2.Text = "Crust";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 56);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 2;
            label1.Text = "Size";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = SystemColors.ActiveCaptionText;
            lbName.Location = new Point(294, 16);
            lbName.Name = "lbName";
            lbName.Size = new Size(201, 34);
            lbName.TabIndex = 1;
            lbName.Text = "D & B Pizza Express";
            // 
            // CBxSize
            // 
            CBxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            CBxSize.FormattingEnabled = true;
            CBxSize.Location = new Point(83, 78);
            CBxSize.Name = "CBxSize";
            CBxSize.Size = new Size(171, 27);
            CBxSize.TabIndex = 0;
            CBxSize.SelectedIndexChanged += CBxSize_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(TBxWater);
            tabPage2.Controls.Add(TBxSoda);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.ForeColor = Color.Red;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 334);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Beverages";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(289, 230);
            label12.Name = "label12";
            label12.Size = new Size(204, 19);
            label12.TabIndex = 16;
            label12.Text = "Soda cost is $1.75 - Water is Free!";
            // 
            // TBxWater
            // 
            TBxWater.Location = new Point(367, 166);
            TBxWater.Name = "TBxWater";
            TBxWater.Size = new Size(66, 23);
            TBxWater.TabIndex = 15;
            TBxWater.TextAlign = HorizontalAlignment.Center;
            TBxWater.TextChanged += TBxWater_TextChanged;
            // 
            // TBxSoda
            // 
            TBxSoda.Location = new Point(367, 127);
            TBxSoda.Name = "TBxSoda";
            TBxSoda.Size = new Size(66, 23);
            TBxSoda.TabIndex = 14;
            TBxSoda.TextAlign = HorizontalAlignment.Center;
            TBxSoda.TextChanged += TBxSoda_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(289, 170);
            label11.Name = "label11";
            label11.Size = new Size(60, 19);
            label11.TabIndex = 13;
            label11.Text = "Water(s)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(297, 131);
            label10.Name = "label10";
            label10.Size = new Size(52, 19);
            label10.TabIndex = 12;
            label10.Text = "Soda(s)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Chiller", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(367, 92);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 11;
            label9.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(277, 283);
            label8.Name = "label8";
            label8.Size = new Size(166, 34);
            label8.TabIndex = 10;
            label8.Text = "Drink Selections";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(260, 20);
            label7.Name = "label7";
            label7.Size = new Size(201, 34);
            label7.TabIndex = 2;
            label7.Text = "D & B Pizza Express";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Controls.Add(CBxOtherItems);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(789, 334);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Other Items";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CBxOtherItems
            // 
            CBxOtherItems.DropDownStyle = ComboBoxStyle.DropDownList;
            CBxOtherItems.Font = new Font("Chiller", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CBxOtherItems.FormattingEnabled = true;
            CBxOtherItems.Location = new Point(294, 124);
            CBxOtherItems.Name = "CBxOtherItems";
            CBxOtherItems.Size = new Size(182, 28);
            CBxOtherItems.TabIndex = 6;
            CBxOtherItems.SelectedIndexChanged += CBxOtherItems_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Chiller", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(335, 88);
            label15.Name = "label15";
            label15.Size = new Size(118, 20);
            label15.TabIndex = 5;
            label15.Text = "Choose Other Items";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(313, 286);
            label14.Name = "label14";
            label14.Size = new Size(163, 34);
            label14.TabIndex = 4;
            label14.Text = "Specialty Items";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(294, 26);
            label13.Name = "label13";
            label13.Size = new Size(201, 34);
            label13.TabIndex = 3;
            label13.Text = "D & B Pizza Express";
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.Controls.Add(TBxEmail);
            tabPage4.Controls.Add(TBxPhone);
            tabPage4.Controls.Add(TBxDeliveryAddress);
            tabPage4.Controls.Add(TBxName);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label16);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(789, 334);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Customer Info";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // TBxEmail
            // 
            TBxEmail.Location = new Point(249, 176);
            TBxEmail.Name = "TBxEmail";
            TBxEmail.Size = new Size(155, 23);
            TBxEmail.TabIndex = 13;
            TBxEmail.TextChanged += TBxEmail_TextChanged;
            // 
            // TBxPhone
            // 
            TBxPhone.Location = new Point(249, 145);
            TBxPhone.Name = "TBxPhone";
            TBxPhone.Size = new Size(100, 23);
            TBxPhone.TabIndex = 12;
            TBxPhone.TextChanged += TBxPhone_TextChanged;
            // 
            // TBxDeliveryAddress
            // 
            TBxDeliveryAddress.Location = new Point(304, 116);
            TBxDeliveryAddress.Name = "TBxDeliveryAddress";
            TBxDeliveryAddress.Size = new Size(157, 23);
            TBxDeliveryAddress.TabIndex = 11;
            TBxDeliveryAddress.TextChanged += TBxDeliveryAddress_TextChanged;
            // 
            // TBxName
            // 
            TBxName.Location = new Point(249, 88);
            TBxName.Name = "TBxName";
            TBxName.Size = new Size(100, 23);
            TBxName.TabIndex = 10;
            TBxName.TextChanged += TBxName_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(201, 179);
            label21.Name = "label21";
            label21.Size = new Size(39, 15);
            label21.TabIndex = 9;
            label21.Text = "Email:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(201, 145);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 8;
            label20.Text = "Phone:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(201, 116);
            label19.Name = "label19";
            label19.Size = new Size(97, 15);
            label19.TabIndex = 7;
            label19.Text = "Delivery Address:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(201, 88);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
            label18.TabIndex = 6;
            label18.Text = "Name:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(260, 289);
            label17.Name = "label17";
            label17.Size = new Size(222, 34);
            label17.TabIndex = 5;
            label17.Text = "Delivery Contact Info";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Chiller", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(260, 13);
            label16.Name = "label16";
            label16.Size = new Size(201, 34);
            label16.TabIndex = 4;
            label16.Text = "D & B Pizza Express";
            // 
            // BTNxResetOrder
            // 
            BTNxResetOrder.ForeColor = SystemColors.ActiveCaptionText;
            BTNxResetOrder.Location = new Point(118, 399);
            BTNxResetOrder.Name = "BTNxResetOrder";
            BTNxResetOrder.Size = new Size(143, 23);
            BTNxResetOrder.TabIndex = 1;
            BTNxResetOrder.Text = "Reset Order";
            BTNxResetOrder.UseVisualStyleBackColor = true;
            BTNxResetOrder.Click += BTNxResetOrder_Click;
            // 
            // BTNxPlaceOrder
            // 
            BTNxPlaceOrder.ForeColor = SystemColors.ActiveCaptionText;
            BTNxPlaceOrder.Location = new Point(499, 400);
            BTNxPlaceOrder.Name = "BTNxPlaceOrder";
            BTNxPlaceOrder.Size = new Size(143, 23);
            BTNxPlaceOrder.TabIndex = 2;
            BTNxPlaceOrder.Text = "Place Order";
            BTNxPlaceOrder.UseVisualStyleBackColor = true;
            BTNxPlaceOrder.Click += BTNxPlaceOrder_Click;
            // 
            // PizzaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(BTNxPlaceOrder);
            Controls.Add(BTNxResetOrder);
            Controls.Add(tabControl1);
            ForeColor = Color.Red;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PizzaForm";
            Text = "D &  B Pizza Express";
            Load += PizzaForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ComboBox CBxSize;
        private ComboBox CBxSauce;
        private Label label3;
        private ComboBox CBxCrust;
        private Label label2;
        private Label label1;
        private Label lbName;
        private Label label5;
        private ComboBox CBxSpecialtyPizzas;
        private Label label4;
        private Label label6;
        private Label label12;
        private TextBox TBxWater;
        private TextBox TBxSoda;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox CBxOtherItems;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox TBxEmail;
        private TextBox TBxPhone;
        private TextBox TBxDeliveryAddress;
        private TextBox TBxName;
        private Button BTNxResetOrder;
        private Button BTNxPlaceOrder;
        private CheckedListBox CLBxToppings;
    }
}