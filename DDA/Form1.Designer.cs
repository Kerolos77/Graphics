
namespace DDA
{
    partial class Form1
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
            this.btn_draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_startx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_starty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_endx = new System.Windows.Forms.TextBox();
            this.txt_endy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxChooseAlgo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_rx = new System.Windows.Forms.TextBox();
            this.txt_ry = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_tx = new System.Windows.Forms.TextBox();
            this.txt_ty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_theta = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panal = new System.Windows.Forms.PictureBox();
            this.txt_sx = new System.Windows.Forms.TextBox();
            this.txt_sy = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.rdx = new System.Windows.Forms.RadioButton();
            this.rdxy = new System.Windows.Forms.RadioButton();
            this.rdy = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_sh = new System.Windows.Forms.TextBox();
            this.shrdx = new System.Windows.Forms.RadioButton();
            this.shrdy = new System.Windows.Forms.RadioButton();
            this.btnds = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_draw
            // 
            this.btn_draw.BackColor = System.Drawing.Color.Silver;
            this.btn_draw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_draw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_draw.FlatAppearance.BorderSize = 0;
            this.btn_draw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_draw.Location = new System.Drawing.Point(1082, 665);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(75, 25);
            this.btn_draw.TabIndex = 0;
            this.btn_draw.Text = "Draw ";
            this.btn_draw.UseVisualStyleBackColor = false;
            this.btn_draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1006, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Line Start Point";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_startx
            // 
            this.txt_startx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_startx.Location = new System.Drawing.Point(1032, 60);
            this.txt_startx.Name = "txt_startx";
            this.txt_startx.Size = new System.Drawing.Size(72, 25);
            this.txt_startx.TabIndex = 3;
            this.txt_startx.Text = "0";
            this.txt_startx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_startx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_startx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1006, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1111, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
            // 
            // txt_starty
            // 
            this.txt_starty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_starty.Location = new System.Drawing.Point(1137, 60);
            this.txt_starty.Name = "txt_starty";
            this.txt_starty.Size = new System.Drawing.Size(74, 25);
            this.txt_starty.TabIndex = 7;
            this.txt_starty.Text = "0";
            this.txt_starty.TextChanged += new System.EventHandler(this.txt_starty_TextChanged);
            this.txt_starty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_starty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1006, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Line End Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1006, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_endx
            // 
            this.txt_endx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_endx.Location = new System.Drawing.Point(1032, 110);
            this.txt_endx.Name = "txt_endx";
            this.txt_endx.Size = new System.Drawing.Size(73, 25);
            this.txt_endx.TabIndex = 10;
            this.txt_endx.Text = "0";
            this.txt_endx.TextChanged += new System.EventHandler(this.txt_endx_TextChanged);
            this.txt_endx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_endx_KeyPress);
            // 
            // txt_endy
            // 
            this.txt_endy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_endy.Location = new System.Drawing.Point(1139, 110);
            this.txt_endy.Name = "txt_endy";
            this.txt_endy.Size = new System.Drawing.Size(72, 25);
            this.txt_endy.TabIndex = 11;
            this.txt_endy.Text = "0";
            this.txt_endy.TextChanged += new System.EventHandler(this.txt_endy_TextChanged);
            this.txt_endy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_endy_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1111, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // comboBoxChooseAlgo
            // 
            this.comboBoxChooseAlgo.FormattingEnabled = true;
            this.comboBoxChooseAlgo.Items.AddRange(new object[] {
            "Bresenham Line (Blue)",
            "Circle (Brown)",
            "DDA Line (Red)",
            "Elipse (green)",
            "Reflection (DarkGreen)",
            "Rotation (DarkGray)",
            "Scale (Chocolate)",
            "Shear (Purple)",
            "Translation (Aqua)"});
            this.comboBoxChooseAlgo.Location = new System.Drawing.Point(1009, 12);
            this.comboBoxChooseAlgo.MaxLength = 50;
            this.comboBoxChooseAlgo.Name = "comboBoxChooseAlgo";
            this.comboBoxChooseAlgo.Size = new System.Drawing.Size(202, 23);
            this.comboBoxChooseAlgo.Sorted = true;
            this.comboBoxChooseAlgo.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1005, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Center Point";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1005, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "X";
            // 
            // txt_cx
            // 
            this.txt_cx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_cx.Location = new System.Drawing.Point(1031, 160);
            this.txt_cx.Name = "txt_cx";
            this.txt_cx.Size = new System.Drawing.Size(73, 25);
            this.txt_cx.TabIndex = 21;
            this.txt_cx.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1111, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Y";
            // 
            // txt_cy
            // 
            this.txt_cy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_cy.Location = new System.Drawing.Point(1139, 160);
            this.txt_cy.Name = "txt_cy";
            this.txt_cy.Size = new System.Drawing.Size(72, 25);
            this.txt_cy.TabIndex = 21;
            this.txt_cy.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1006, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Radius";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(1006, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 21);
            this.label15.TabIndex = 25;
            this.label15.Text = "Rx";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(1111, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 21);
            this.label16.TabIndex = 25;
            this.label16.Text = "Ry";
            // 
            // txt_rx
            // 
            this.txt_rx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_rx.Location = new System.Drawing.Point(1031, 210);
            this.txt_rx.Name = "txt_rx";
            this.txt_rx.Size = new System.Drawing.Size(73, 25);
            this.txt_rx.TabIndex = 26;
            this.txt_rx.Text = "0";
            // 
            // txt_ry
            // 
            this.txt_ry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ry.Location = new System.Drawing.Point(1139, 210);
            this.txt_ry.Name = "txt_ry";
            this.txt_ry.Size = new System.Drawing.Size(73, 25);
            this.txt_ry.TabIndex = 26;
            this.txt_ry.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1005, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 19);
            this.label17.TabIndex = 27;
            this.label17.Text = "Translation";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(1006, 264);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 21);
            this.label18.TabIndex = 28;
            this.label18.Text = "Tx";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(1111, 264);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 21);
            this.label19.TabIndex = 29;
            this.label19.Text = "Ty";
            // 
            // txt_tx
            // 
            this.txt_tx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_tx.Location = new System.Drawing.Point(1031, 260);
            this.txt_tx.Name = "txt_tx";
            this.txt_tx.Size = new System.Drawing.Size(73, 25);
            this.txt_tx.TabIndex = 30;
            this.txt_tx.Text = "0";
            // 
            // txt_ty
            // 
            this.txt_ty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ty.Location = new System.Drawing.Point(1137, 260);
            this.txt_ty.Name = "txt_ty";
            this.txt_ty.Size = new System.Drawing.Size(73, 25);
            this.txt_ty.TabIndex = 31;
            this.txt_ty.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(1004, 288);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 19);
            this.label20.TabIndex = 32;
            this.label20.Text = "Rotation";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(1004, 314);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 21);
            this.label21.TabIndex = 33;
            this.label21.Text = "θ";
            // 
            // txt_theta
            // 
            this.txt_theta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_theta.Location = new System.Drawing.Point(1032, 310);
            this.txt_theta.Name = "txt_theta";
            this.txt_theta.Size = new System.Drawing.Size(73, 25);
            this.txt_theta.TabIndex = 34;
            this.txt_theta.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(1004, 338);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 19);
            this.label22.TabIndex = 35;
            this.label22.Text = "Scale";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(1006, 364);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 21);
            this.label23.TabIndex = 36;
            this.label23.Text = "Sx";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // panal
            // 
            this.panal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panal.Location = new System.Drawing.Point(-5, 1);
            this.panal.Name = "panal";
            this.panal.Size = new System.Drawing.Size(1003, 700);
            this.panal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panal.TabIndex = 13;
            this.panal.TabStop = false;
            this.panal.Click += new System.EventHandler(this.panal_Click);
            // 
            // txt_sx
            // 
            this.txt_sx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_sx.Location = new System.Drawing.Point(1032, 360);
            this.txt_sx.Name = "txt_sx";
            this.txt_sx.Size = new System.Drawing.Size(73, 25);
            this.txt_sx.TabIndex = 37;
            this.txt_sx.Text = "0";
            // 
            // txt_sy
            // 
            this.txt_sy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_sy.Location = new System.Drawing.Point(1139, 360);
            this.txt_sy.Name = "txt_sy";
            this.txt_sy.Size = new System.Drawing.Size(73, 25);
            this.txt_sy.TabIndex = 38;
            this.txt_sy.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(1111, 364);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 21);
            this.label24.TabIndex = 39;
            this.label24.Text = "Sy";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(1004, 388);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 19);
            this.label25.TabIndex = 40;
            this.label25.Text = "Reflaction";
            // 
            // rdx
            // 
            this.rdx.AutoSize = true;
            this.rdx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdx.Location = new System.Drawing.Point(1010, 410);
            this.rdx.Name = "rdx";
            this.rdx.Size = new System.Drawing.Size(36, 23);
            this.rdx.TabIndex = 41;
            this.rdx.TabStop = true;
            this.rdx.Text = "X";
            this.rdx.UseVisualStyleBackColor = true;
            // 
            // rdxy
            // 
            this.rdxy.AutoSize = true;
            this.rdxy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdxy.Location = new System.Drawing.Point(1095, 410);
            this.rdxy.Name = "rdxy";
            this.rdxy.Size = new System.Drawing.Size(49, 23);
            this.rdxy.TabIndex = 42;
            this.rdxy.TabStop = true;
            this.rdxy.Text = "X,Y";
            this.rdxy.UseVisualStyleBackColor = true;
            // 
            // rdy
            // 
            this.rdy.AutoSize = true;
            this.rdy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdy.Location = new System.Drawing.Point(1170, 410);
            this.rdy.Name = "rdy";
            this.rdy.Size = new System.Drawing.Size(36, 23);
            this.rdy.TabIndex = 43;
            this.rdy.TabStop = true;
            this.rdy.Text = "Y";
            this.rdy.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(1004, 436);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 19);
            this.label26.TabIndex = 44;
            this.label26.Text = "Shear";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(1004, 467);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 21);
            this.label27.TabIndex = 45;
            this.label27.Text = "Sh";
            // 
            // txt_sh
            // 
            this.txt_sh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_sh.Location = new System.Drawing.Point(1031, 463);
            this.txt_sh.Name = "txt_sh";
            this.txt_sh.Size = new System.Drawing.Size(73, 25);
            this.txt_sh.TabIndex = 46;
            this.txt_sh.Text = "0";
            // 
            // shrdx
            // 
            this.shrdx.AutoSize = true;
            this.shrdx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shrdx.Location = new System.Drawing.Point(1121, 465);
            this.shrdx.Name = "shrdx";
            this.shrdx.Size = new System.Drawing.Size(36, 23);
            this.shrdx.TabIndex = 47;
            this.shrdx.TabStop = true;
            this.shrdx.Text = "X";
            this.shrdx.UseVisualStyleBackColor = true;
            // 
            // shrdy
            // 
            this.shrdy.AutoSize = true;
            this.shrdy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shrdy.Location = new System.Drawing.Point(1170, 463);
            this.shrdy.Name = "shrdy";
            this.shrdy.Size = new System.Drawing.Size(36, 23);
            this.shrdy.TabIndex = 48;
            this.shrdy.TabStop = true;
            this.shrdy.Text = "Y";
            this.shrdy.UseVisualStyleBackColor = true;
            // 
            // btnds
            // 
            this.btnds.BackColor = System.Drawing.Color.Silver;
            this.btnds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnds.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnds.FlatAppearance.BorderSize = 0;
            this.btnds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnds.Location = new System.Drawing.Point(1006, 508);
            this.btnds.Name = "btnds";
            this.btnds.Size = new System.Drawing.Size(200, 25);
            this.btnds.TabIndex = 49;
            this.btnds.Text = "Draw Square";
            this.btnds.UseVisualStyleBackColor = false;
            this.btnds.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1006, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 25);
            this.button1.TabIndex = 50;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1218, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnds);
            this.Controls.Add(this.shrdy);
            this.Controls.Add(this.shrdx);
            this.Controls.Add(this.txt_sh);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.rdy);
            this.Controls.Add(this.rdxy);
            this.Controls.Add(this.rdx);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txt_sy);
            this.Controls.Add(this.txt_sx);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panal);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_theta);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_ty);
            this.Controls.Add(this.txt_tx);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_rx);
            this.Controls.Add(this.txt_ry);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_cy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_cx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxChooseAlgo);
            this.Controls.Add(this.txt_endy);
            this.Controls.Add(this.txt_endx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_starty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_startx);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Graphics Packages";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_startx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_starty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_endx;
        private System.Windows.Forms.TextBox txt_endy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxChooseAlgo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_rx;
        private System.Windows.Forms.TextBox txt_ry;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_tx;
        private System.Windows.Forms.TextBox txt_ty;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_theta;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox panal;
        private System.Windows.Forms.TextBox txt_sx;
        private System.Windows.Forms.TextBox txt_sy;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton rdx;
        private System.Windows.Forms.RadioButton rdxy;
        private System.Windows.Forms.RadioButton rdy;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_sh;
        private System.Windows.Forms.RadioButton shrdx;
        private System.Windows.Forms.RadioButton shrdy;
        private System.Windows.Forms.Button btnds;
        private System.Windows.Forms.Button button1;
    }
}

