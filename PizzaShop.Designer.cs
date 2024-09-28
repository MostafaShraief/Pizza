namespace Pizza
{
    partial class PizzaShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaShop));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_large_size = new System.Windows.Forms.RadioButton();
            this.rb_medium_size = new System.Windows.Forms.RadioButton();
            this.rb_small_size = new System.Windows.Forms.RadioButton();
            this.gb_crust = new System.Windows.Forms.GroupBox();
            this.rb_thick_crust = new System.Windows.Forms.RadioButton();
            this.rb_thin_crust = new System.Windows.Forms.RadioButton();
            this.lbl_price_txt = new System.Windows.Forms.Label();
            this.lbl_price_amount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_crust_order = new System.Windows.Forms.Label();
            this.lbl_crust_type_txt = new System.Windows.Forms.Label();
            this.lbl_toppings_order = new System.Windows.Forms.Label();
            this.lbl_toppings_txt = new System.Windows.Forms.Label();
            this.lbl_size_order = new System.Windows.Forms.Label();
            this.lbl_size_txt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_mushrooms_order = new System.Windows.Forms.CheckBox();
            this.cb_ex_cheese_order = new System.Windows.Forms.CheckBox();
            this.cb_tomatoes_order = new System.Windows.Forms.CheckBox();
            this.cb_order_onions = new System.Windows.Forms.CheckBox();
            this.cb_order_olives = new System.Windows.Forms.CheckBox();
            this.cb_order_green_peppers = new System.Windows.Forms.CheckBox();
            this.gb_eat_place = new System.Windows.Forms.GroupBox();
            this.rb_eat_place_eat_in = new System.Windows.Forms.RadioButton();
            this.rb_eat_place_outside = new System.Windows.Forms.RadioButton();
            this.lb_summary_eat_place_choice = new System.Windows.Forms.Label();
            this.lb_summary_eat_place_txt = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_crust.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_eat_place.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_large_size);
            this.groupBox1.Controls.Add(this.rb_medium_size);
            this.groupBox1.Controls.Add(this.rb_small_size);
            this.groupBox1.Font = new System.Drawing.Font("IOS 15 R SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rb_large_size
            // 
            this.rb_large_size.AutoSize = true;
            this.rb_large_size.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_large_size.Location = new System.Drawing.Point(16, 143);
            this.rb_large_size.Name = "rb_large_size";
            this.rb_large_size.Size = new System.Drawing.Size(109, 39);
            this.rb_large_size.TabIndex = 3;
            this.rb_large_size.TabStop = true;
            this.rb_large_size.Text = "Large";
            this.rb_large_size.UseVisualStyleBackColor = true;
            this.rb_large_size.CheckedChanged += new System.EventHandler(this.rb_large_size_CheckedChanged);
            // 
            // rb_medium_size
            // 
            this.rb_medium_size.AutoSize = true;
            this.rb_medium_size.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_medium_size.Location = new System.Drawing.Point(16, 90);
            this.rb_medium_size.Name = "rb_medium_size";
            this.rb_medium_size.Size = new System.Drawing.Size(147, 39);
            this.rb_medium_size.TabIndex = 2;
            this.rb_medium_size.TabStop = true;
            this.rb_medium_size.Text = "Medium";
            this.rb_medium_size.UseVisualStyleBackColor = true;
            this.rb_medium_size.CheckedChanged += new System.EventHandler(this.rb_medium_size_CheckedChanged);
            // 
            // rb_small_size
            // 
            this.rb_small_size.AutoSize = true;
            this.rb_small_size.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_small_size.Location = new System.Drawing.Point(16, 37);
            this.rb_small_size.Name = "rb_small_size";
            this.rb_small_size.Size = new System.Drawing.Size(107, 39);
            this.rb_small_size.TabIndex = 1;
            this.rb_small_size.TabStop = true;
            this.rb_small_size.Text = "Small";
            this.rb_small_size.UseVisualStyleBackColor = true;
            this.rb_small_size.CheckedChanged += new System.EventHandler(this.rb_small_size_CheckedChanged);
            // 
            // gb_crust
            // 
            this.gb_crust.BackColor = System.Drawing.Color.Transparent;
            this.gb_crust.Controls.Add(this.rb_thick_crust);
            this.gb_crust.Controls.Add(this.rb_thin_crust);
            this.gb_crust.Font = new System.Drawing.Font("IOS 15 R SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_crust.ForeColor = System.Drawing.Color.White;
            this.gb_crust.Location = new System.Drawing.Point(30, 286);
            this.gb_crust.Name = "gb_crust";
            this.gb_crust.Size = new System.Drawing.Size(199, 164);
            this.gb_crust.TabIndex = 1;
            this.gb_crust.TabStop = false;
            this.gb_crust.Text = "Crust Pizza";
            // 
            // rb_thick_crust
            // 
            this.rb_thick_crust.AutoSize = true;
            this.rb_thick_crust.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_thick_crust.Location = new System.Drawing.Point(16, 101);
            this.rb_thick_crust.Name = "rb_thick_crust";
            this.rb_thick_crust.Size = new System.Drawing.Size(181, 39);
            this.rb_thick_crust.TabIndex = 5;
            this.rb_thick_crust.TabStop = true;
            this.rb_thick_crust.Text = "Thick Crust";
            this.rb_thick_crust.UseVisualStyleBackColor = true;
            this.rb_thick_crust.CheckedChanged += new System.EventHandler(this.rd_thick_crust_CheckedChanged);
            // 
            // rb_thin_crust
            // 
            this.rb_thin_crust.AutoSize = true;
            this.rb_thin_crust.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_thin_crust.Location = new System.Drawing.Point(16, 50);
            this.rb_thin_crust.Name = "rb_thin_crust";
            this.rb_thin_crust.Size = new System.Drawing.Size(169, 39);
            this.rb_thin_crust.TabIndex = 4;
            this.rb_thin_crust.TabStop = true;
            this.rb_thin_crust.Text = "Thin Crust";
            this.rb_thin_crust.UseVisualStyleBackColor = true;
            this.rb_thin_crust.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_price_txt
            // 
            this.lbl_price_txt.AutoSize = true;
            this.lbl_price_txt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price_txt.Font = new System.Drawing.Font("IOS 15 R SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_txt.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_price_txt.Location = new System.Drawing.Point(851, 517);
            this.lbl_price_txt.Name = "lbl_price_txt";
            this.lbl_price_txt.Size = new System.Drawing.Size(112, 50);
            this.lbl_price_txt.TabIndex = 2;
            this.lbl_price_txt.Text = "Price";
            // 
            // lbl_price_amount
            // 
            this.lbl_price_amount.AutoSize = true;
            this.lbl_price_amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price_amount.Font = new System.Drawing.Font("IOS 15 R SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_amount.ForeColor = System.Drawing.Color.Red;
            this.lbl_price_amount.Location = new System.Drawing.Point(880, 458);
            this.lbl_price_amount.Name = "lbl_price_amount";
            this.lbl_price_amount.Size = new System.Drawing.Size(55, 58);
            this.lbl_price_amount.TabIndex = 3;
            this.lbl_price_amount.Text = "0";
            this.lbl_price_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lb_summary_eat_place_choice);
            this.groupBox2.Controls.Add(this.lb_summary_eat_place_txt);
            this.groupBox2.Controls.Add(this.lbl_crust_order);
            this.groupBox2.Controls.Add(this.lbl_crust_type_txt);
            this.groupBox2.Controls.Add(this.lbl_toppings_order);
            this.groupBox2.Controls.Add(this.lbl_toppings_txt);
            this.groupBox2.Controls.Add(this.lbl_size_order);
            this.groupBox2.Controls.Add(this.lbl_size_txt);
            this.groupBox2.Font = new System.Drawing.Font("IOS 15 R SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(770, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 417);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // lbl_crust_order
            // 
            this.lbl_crust_order.AutoSize = true;
            this.lbl_crust_order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crust_order.Location = new System.Drawing.Point(23, 284);
            this.lbl_crust_order.Name = "lbl_crust_order";
            this.lbl_crust_order.Size = new System.Drawing.Size(142, 36);
            this.lbl_crust_order.TabIndex = 5;
            this.lbl_crust_order.Tag = "Unknown";
            this.lbl_crust_order.Text = "Unknown";
            // 
            // lbl_crust_type_txt
            // 
            this.lbl_crust_type_txt.AutoSize = true;
            this.lbl_crust_type_txt.Location = new System.Drawing.Point(23, 239);
            this.lbl_crust_type_txt.Name = "lbl_crust_type_txt";
            this.lbl_crust_type_txt.Size = new System.Drawing.Size(159, 35);
            this.lbl_crust_type_txt.TabIndex = 4;
            this.lbl_crust_type_txt.Text = "Crust Type:";
            this.lbl_crust_type_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_toppings_order
            // 
            this.lbl_toppings_order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toppings_order.Location = new System.Drawing.Point(24, 135);
            this.lbl_toppings_order.Name = "lbl_toppings_order";
            this.lbl_toppings_order.Size = new System.Drawing.Size(228, 104);
            this.lbl_toppings_order.TabIndex = 3;
            this.lbl_toppings_order.Tag = "Unknown";
            this.lbl_toppings_order.Text = "Unknown";
            // 
            // lbl_toppings_txt
            // 
            this.lbl_toppings_txt.AutoSize = true;
            this.lbl_toppings_txt.Location = new System.Drawing.Point(23, 88);
            this.lbl_toppings_txt.Name = "lbl_toppings_txt";
            this.lbl_toppings_txt.Size = new System.Drawing.Size(137, 35);
            this.lbl_toppings_txt.TabIndex = 2;
            this.lbl_toppings_txt.Text = "Toppings:";
            this.lbl_toppings_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_size_order
            // 
            this.lbl_size_order.AutoSize = true;
            this.lbl_size_order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size_order.Location = new System.Drawing.Point(91, 53);
            this.lbl_size_order.Name = "lbl_size_order";
            this.lbl_size_order.Size = new System.Drawing.Size(142, 36);
            this.lbl_size_order.TabIndex = 1;
            this.lbl_size_order.Tag = "Unknown";
            this.lbl_size_order.Text = "Unknown";
            this.lbl_size_order.Click += new System.EventHandler(this.lbl_size_order_Click);
            // 
            // lbl_size_txt
            // 
            this.lbl_size_txt.AutoSize = true;
            this.lbl_size_txt.Location = new System.Drawing.Point(23, 53);
            this.lbl_size_txt.Name = "lbl_size_txt";
            this.lbl_size_txt.Size = new System.Drawing.Size(75, 35);
            this.lbl_size_txt.TabIndex = 0;
            this.lbl_size_txt.Text = "Size:";
            this.lbl_size_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cb_order_green_peppers);
            this.groupBox3.Controls.Add(this.cb_order_olives);
            this.groupBox3.Controls.Add(this.cb_order_onions);
            this.groupBox3.Controls.Add(this.cb_tomatoes_order);
            this.groupBox3.Controls.Add(this.cb_mushrooms_order);
            this.groupBox3.Controls.Add(this.cb_ex_cheese_order);
            this.groupBox3.Font = new System.Drawing.Font("IOS 15 R SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(312, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // cb_mushrooms_order
            // 
            this.cb_mushrooms_order.AutoSize = true;
            this.cb_mushrooms_order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mushrooms_order.Location = new System.Drawing.Point(24, 99);
            this.cb_mushrooms_order.Name = "cb_mushrooms_order";
            this.cb_mushrooms_order.Size = new System.Drawing.Size(196, 40);
            this.cb_mushrooms_order.TabIndex = 8;
            this.cb_mushrooms_order.Text = "Mushrooms";
            this.cb_mushrooms_order.UseVisualStyleBackColor = true;
            this.cb_mushrooms_order.CheckedChanged += new System.EventHandler(this.cb_mushrooms_order_CheckedChanged);
            // 
            // cb_ex_cheese_order
            // 
            this.cb_ex_cheese_order.AutoSize = true;
            this.cb_ex_cheese_order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ex_cheese_order.Location = new System.Drawing.Point(24, 53);
            this.cb_ex_cheese_order.Name = "cb_ex_cheese_order";
            this.cb_ex_cheese_order.Size = new System.Drawing.Size(205, 40);
            this.cb_ex_cheese_order.TabIndex = 6;
            this.cb_ex_cheese_order.Text = "Extra Cheese";
            this.cb_ex_cheese_order.UseVisualStyleBackColor = true;
            this.cb_ex_cheese_order.CheckedChanged += new System.EventHandler(this.cb_ex_cheese_order_CheckedChanged);
            // 
            // cb_tomatoes_order
            // 
            this.cb_tomatoes_order.AutoSize = true;
            this.cb_tomatoes_order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tomatoes_order.Location = new System.Drawing.Point(24, 147);
            this.cb_tomatoes_order.Name = "cb_tomatoes_order";
            this.cb_tomatoes_order.Size = new System.Drawing.Size(169, 40);
            this.cb_tomatoes_order.TabIndex = 10;
            this.cb_tomatoes_order.Text = "Tomatoes";
            this.cb_tomatoes_order.UseVisualStyleBackColor = true;
            this.cb_tomatoes_order.CheckedChanged += new System.EventHandler(this.cb_tomatoes_order_CheckedChanged);
            // 
            // cb_order_onions
            // 
            this.cb_order_onions.AutoSize = true;
            this.cb_order_onions.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_order_onions.Location = new System.Drawing.Point(235, 53);
            this.cb_order_onions.Name = "cb_order_onions";
            this.cb_order_onions.Size = new System.Drawing.Size(132, 40);
            this.cb_order_onions.TabIndex = 7;
            this.cb_order_onions.Text = "Onions";
            this.cb_order_onions.UseVisualStyleBackColor = true;
            this.cb_order_onions.CheckedChanged += new System.EventHandler(this.cb_order_onions_CheckedChanged);
            // 
            // cb_order_olives
            // 
            this.cb_order_olives.AutoSize = true;
            this.cb_order_olives.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_order_olives.Location = new System.Drawing.Point(235, 103);
            this.cb_order_olives.Name = "cb_order_olives";
            this.cb_order_olives.Size = new System.Drawing.Size(117, 40);
            this.cb_order_olives.TabIndex = 9;
            this.cb_order_olives.Text = "Olives";
            this.cb_order_olives.UseVisualStyleBackColor = true;
            this.cb_order_olives.CheckedChanged += new System.EventHandler(this.cb_order_olives_CheckedChanged);
            // 
            // cb_order_green_peppers
            // 
            this.cb_order_green_peppers.AutoSize = true;
            this.cb_order_green_peppers.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_order_green_peppers.Location = new System.Drawing.Point(235, 154);
            this.cb_order_green_peppers.Name = "cb_order_green_peppers";
            this.cb_order_green_peppers.Size = new System.Drawing.Size(171, 29);
            this.cb_order_green_peppers.TabIndex = 11;
            this.cb_order_green_peppers.Text = "Green Peppers";
            this.cb_order_green_peppers.UseVisualStyleBackColor = true;
            this.cb_order_green_peppers.CheckedChanged += new System.EventHandler(this.cb_order_green_peppers_CheckedChanged);
            // 
            // gb_eat_place
            // 
            this.gb_eat_place.BackColor = System.Drawing.Color.Transparent;
            this.gb_eat_place.Controls.Add(this.rb_eat_place_eat_in);
            this.gb_eat_place.Controls.Add(this.rb_eat_place_outside);
            this.gb_eat_place.Font = new System.Drawing.Font("IOS 15 R SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_eat_place.ForeColor = System.Drawing.Color.White;
            this.gb_eat_place.Location = new System.Drawing.Point(312, 286);
            this.gb_eat_place.Name = "gb_eat_place";
            this.gb_eat_place.Size = new System.Drawing.Size(421, 164);
            this.gb_eat_place.TabIndex = 3;
            this.gb_eat_place.TabStop = false;
            this.gb_eat_place.Text = "Where To Eat";
            // 
            // rb_eat_place_eat_in
            // 
            this.rb_eat_place_eat_in.AutoSize = true;
            this.rb_eat_place_eat_in.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eat_place_eat_in.Location = new System.Drawing.Point(16, 101);
            this.rb_eat_place_eat_in.Name = "rb_eat_place_eat_in";
            this.rb_eat_place_eat_in.Size = new System.Drawing.Size(108, 39);
            this.rb_eat_place_eat_in.TabIndex = 13;
            this.rb_eat_place_eat_in.TabStop = true;
            this.rb_eat_place_eat_in.Text = "Eat In";
            this.rb_eat_place_eat_in.UseVisualStyleBackColor = true;
            this.rb_eat_place_eat_in.CheckedChanged += new System.EventHandler(this.rb_eat_place_eat_in_CheckedChanged);
            // 
            // rb_eat_place_outside
            // 
            this.rb_eat_place_outside.AutoSize = true;
            this.rb_eat_place_outside.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eat_place_outside.Location = new System.Drawing.Point(16, 50);
            this.rb_eat_place_outside.Name = "rb_eat_place_outside";
            this.rb_eat_place_outside.Size = new System.Drawing.Size(140, 39);
            this.rb_eat_place_outside.TabIndex = 12;
            this.rb_eat_place_outside.TabStop = true;
            this.rb_eat_place_outside.Text = "Outside";
            this.rb_eat_place_outside.UseVisualStyleBackColor = true;
            this.rb_eat_place_outside.CheckedChanged += new System.EventHandler(this.rb_eat_place_outside_CheckedChanged);
            // 
            // lb_summary_eat_place_choice
            // 
            this.lb_summary_eat_place_choice.AutoSize = true;
            this.lb_summary_eat_place_choice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_summary_eat_place_choice.Location = new System.Drawing.Point(23, 375);
            this.lb_summary_eat_place_choice.Name = "lb_summary_eat_place_choice";
            this.lb_summary_eat_place_choice.Size = new System.Drawing.Size(142, 36);
            this.lb_summary_eat_place_choice.TabIndex = 7;
            this.lb_summary_eat_place_choice.Tag = "Unknown";
            this.lb_summary_eat_place_choice.Text = "Unknown";
            this.lb_summary_eat_place_choice.Click += new System.EventHandler(this.lb_summary_eat_place_choice_Click);
            // 
            // lb_summary_eat_place_txt
            // 
            this.lb_summary_eat_place_txt.AutoSize = true;
            this.lb_summary_eat_place_txt.Location = new System.Drawing.Point(23, 330);
            this.lb_summary_eat_place_txt.Name = "lb_summary_eat_place_txt";
            this.lb_summary_eat_place_txt.Size = new System.Drawing.Size(187, 35);
            this.lb_summary_eat_place_txt.TabIndex = 6;
            this.lb_summary_eat_place_txt.Text = "Where To Eat:";
            this.lb_summary_eat_place_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.DarkRed;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(328, 479);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(131, 66);
            this.btn_order.TabIndex = 14;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkRed;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(587, 479);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(131, 66);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // PizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza.Properties.Resources.julian_rojas_dattwyler_LppAkC7s6u4_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 596);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.gb_eat_place);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_price_amount);
            this.Controls.Add(this.lbl_price_txt);
            this.Controls.Add(this.gb_crust);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PizzaShop";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_crust.ResumeLayout(false);
            this.gb_crust.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_eat_place.ResumeLayout(false);
            this.gb_eat_place.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_large_size;
        private System.Windows.Forms.RadioButton rb_medium_size;
        private System.Windows.Forms.RadioButton rb_small_size;
        private System.Windows.Forms.GroupBox gb_crust;
        private System.Windows.Forms.RadioButton rb_thin_crust;
        private System.Windows.Forms.RadioButton rb_thick_crust;
        private System.Windows.Forms.Label lbl_price_txt;
        private System.Windows.Forms.Label lbl_price_amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_size_txt;
        private System.Windows.Forms.Label lbl_size_order;
        private System.Windows.Forms.Label lbl_toppings_order;
        private System.Windows.Forms.Label lbl_toppings_txt;
        private System.Windows.Forms.Label lbl_crust_type_txt;
        private System.Windows.Forms.Label lbl_crust_order;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_mushrooms_order;
        private System.Windows.Forms.CheckBox cb_ex_cheese_order;
        private System.Windows.Forms.CheckBox cb_tomatoes_order;
        private System.Windows.Forms.CheckBox cb_order_onions;
        private System.Windows.Forms.CheckBox cb_order_olives;
        private System.Windows.Forms.CheckBox cb_order_green_peppers;
        private System.Windows.Forms.Label lb_summary_eat_place_choice;
        private System.Windows.Forms.Label lb_summary_eat_place_txt;
        private System.Windows.Forms.GroupBox gb_eat_place;
        private System.Windows.Forms.RadioButton rb_eat_place_eat_in;
        private System.Windows.Forms.RadioButton rb_eat_place_outside;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_reset;
    }
}