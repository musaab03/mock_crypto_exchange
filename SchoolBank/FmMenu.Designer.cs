namespace SchoolBank
{
    partial class FmMenu
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
            this.name_txt = new System.Windows.Forms.RichTextBox();
            this.act_btn = new System.Windows.Forms.Button();
            this.transact_btn = new System.Windows.Forms.Button();
            this.stats_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.gbxPass = new System.Windows.Forms.GroupBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.RichTextBox();
            this.pass_txt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regbtn = new System.Windows.Forms.Button();
            this.logbtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.gbxreg = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailreg = new System.Windows.Forms.RichTextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passtxt2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userreg = new System.Windows.Forms.RichTextBox();
            this.passtext1 = new System.Windows.Forms.RichTextBox();
            this.gbxexchange = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btcbtn = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.ethbtn = new System.Windows.Forms.Button();
            this.dogebtn = new System.Windows.Forms.Button();
            this.gbxPass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxreg.SuspendLayout();
            this.gbxexchange.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.SkyBlue;
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(290, 12);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(233, 45);
            this.name_txt.TabIndex = 1;
            this.name_txt.Text = "Crypto Exchange";
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // act_btn
            // 
            this.act_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.act_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.act_btn.ForeColor = System.Drawing.Color.Black;
            this.act_btn.Location = new System.Drawing.Point(302, 107);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(194, 48);
            this.act_btn.TabIndex = 2;
            this.act_btn.Text = "Exchange";
            this.act_btn.UseVisualStyleBackColor = false;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // transact_btn
            // 
            this.transact_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.transact_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transact_btn.ForeColor = System.Drawing.Color.Black;
            this.transact_btn.Location = new System.Drawing.Point(302, 238);
            this.transact_btn.Name = "transact_btn";
            this.transact_btn.Size = new System.Drawing.Size(194, 48);
            this.transact_btn.TabIndex = 3;
            this.transact_btn.Text = "Settings";
            this.transact_btn.UseVisualStyleBackColor = false;
            this.transact_btn.Click += new System.EventHandler(this.transact_btn_Click);
            // 
            // stats_btn
            // 
            this.stats_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.stats_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_btn.ForeColor = System.Drawing.Color.Black;
            this.stats_btn.Location = new System.Drawing.Point(302, 173);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(194, 48);
            this.stats_btn.TabIndex = 4;
            this.stats_btn.Text = "Wallet";
            this.stats_btn.UseVisualStyleBackColor = false;
            this.stats_btn.Click += new System.EventHandler(this.stats_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(302, 349);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(194, 48);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // gbxPass
            // 
            this.gbxPass.BackColor = System.Drawing.Color.SkyBlue;
            this.gbxPass.Controls.Add(this.btnback);
            this.gbxPass.Controls.Add(this.btnLogin);
            this.gbxPass.Controls.Add(this.richTextBox1);
            this.gbxPass.Controls.Add(this.label1);
            this.gbxPass.Controls.Add(this.label2);
            this.gbxPass.Controls.Add(this.user_txt);
            this.gbxPass.Controls.Add(this.pass_txt);
            this.gbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPass.Location = new System.Drawing.Point(148, 107);
            this.gbxPass.Name = "gbxPass";
            this.gbxPass.Size = new System.Drawing.Size(517, 296);
            this.gbxPass.TabIndex = 16;
            this.gbxPass.TabStop = false;
            this.gbxPass.Enter += new System.EventHandler(this.gbxPass_Enter);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.SkyBlue;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(451, 253);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(60, 27);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(209, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 43);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(83, 7);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(351, 41);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Enter Username and Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // user_txt
            // 
            this.user_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.user_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Location = new System.Drawing.Point(133, 88);
            this.user_txt.Multiline = false;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(327, 41);
            this.user_txt.TabIndex = 11;
            this.user_txt.Text = "";
            this.user_txt.TextChanged += new System.EventHandler(this.user_txt_TextChanged);
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.pass_txt.Location = new System.Drawing.Point(133, 160);
            this.pass_txt.Multiline = false;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(327, 41);
            this.pass_txt.TabIndex = 8;
            this.pass_txt.Text = "";
            this.pass_txt.TextChanged += new System.EventHandler(this.pass_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.regbtn);
            this.groupBox1.Controls.Add(this.logbtn);
            this.groupBox1.Controls.Add(this.quitbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(387, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 409);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.Location = new System.Drawing.Point(194, 113);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(131, 43);
            this.regbtn.TabIndex = 19;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(194, 54);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(131, 45);
            this.logbtn.TabIndex = 18;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbtn.Location = new System.Drawing.Point(194, 227);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(128, 38);
            this.quitbtn.TabIndex = 20;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // gbxreg
            // 
            this.gbxreg.BackColor = System.Drawing.Color.SkyBlue;
            this.gbxreg.Controls.Add(this.label6);
            this.gbxreg.Controls.Add(this.emailreg);
            this.gbxreg.Controls.Add(this.backbtn);
            this.gbxreg.Controls.Add(this.label5);
            this.gbxreg.Controls.Add(this.passtxt2);
            this.gbxreg.Controls.Add(this.button1);
            this.gbxreg.Controls.Add(this.richTextBox2);
            this.gbxreg.Controls.Add(this.label3);
            this.gbxreg.Controls.Add(this.label4);
            this.gbxreg.Controls.Add(this.userreg);
            this.gbxreg.Controls.Add(this.passtext1);
            this.gbxreg.Controls.Add(this.groupBox1);
            this.gbxreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxreg.Location = new System.Drawing.Point(11, 0);
            this.gbxreg.Name = "gbxreg";
            this.gbxreg.Size = new System.Drawing.Size(517, 409);
            this.gbxreg.TabIndex = 17;
            this.gbxreg.TabStop = false;
            this.gbxreg.Enter += new System.EventHandler(this.gbxreg_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Enter Email";
            // 
            // emailreg
            // 
            this.emailreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailreg.Location = new System.Drawing.Point(179, 223);
            this.emailreg.Multiline = false;
            this.emailreg.Name = "emailreg";
            this.emailreg.Size = new System.Drawing.Size(327, 41);
            this.emailreg.TabIndex = 22;
            this.emailreg.Text = "";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(446, 363);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(60, 27);
            this.backbtn.TabIndex = 21;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Re-Enter Password";
            // 
            // passtxt2
            // 
            this.passtxt2.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.passtxt2.Location = new System.Drawing.Point(179, 167);
            this.passtxt2.Multiline = false;
            this.passtxt2.Name = "passtxt2";
            this.passtxt2.Size = new System.Drawing.Size(327, 41);
            this.passtxt2.TabIndex = 19;
            this.passtxt2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(83, 7);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(351, 41);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "Register";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Username";
            // 
            // userreg
            // 
            this.userreg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userreg.Location = new System.Drawing.Point(179, 63);
            this.userreg.Multiline = false;
            this.userreg.Name = "userreg";
            this.userreg.Size = new System.Drawing.Size(327, 41);
            this.userreg.TabIndex = 11;
            this.userreg.Text = "";
            this.userreg.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // passtext1
            // 
            this.passtext1.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.passtext1.Location = new System.Drawing.Point(179, 114);
            this.passtext1.Multiline = false;
            this.passtext1.Name = "passtext1";
            this.passtext1.Size = new System.Drawing.Size(327, 41);
            this.passtext1.TabIndex = 8;
            this.passtext1.Text = "";
            // 
            // gbxexchange
            // 
            this.gbxexchange.BackColor = System.Drawing.Color.SkyBlue;
            this.gbxexchange.Controls.Add(this.dogebtn);
            this.gbxexchange.Controls.Add(this.ethbtn);
            this.gbxexchange.Controls.Add(this.button2);
            this.gbxexchange.Controls.Add(this.btcbtn);
            this.gbxexchange.Controls.Add(this.richTextBox5);
            this.gbxexchange.Controls.Add(this.gbxreg);
            this.gbxexchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxexchange.Location = new System.Drawing.Point(148, 90);
            this.gbxexchange.Name = "gbxexchange";
            this.gbxexchange.Size = new System.Drawing.Size(517, 409);
            this.gbxexchange.TabIndex = 24;
            this.gbxexchange.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(446, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btcbtn
            // 
            this.btcbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.btcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcbtn.Location = new System.Drawing.Point(154, 78);
            this.btcbtn.Name = "btcbtn";
            this.btcbtn.Size = new System.Drawing.Size(153, 67);
            this.btcbtn.TabIndex = 18;
            this.btcbtn.Text = "Bitcoin";
            this.btcbtn.UseVisualStyleBackColor = false;
            this.btcbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox5.Enabled = false;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(83, 7);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(351, 41);
            this.richTextBox5.TabIndex = 17;
            this.richTextBox5.Text = "Choose Currency";
            // 
            // ethbtn
            // 
            this.ethbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ethbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethbtn.Location = new System.Drawing.Point(155, 167);
            this.ethbtn.Name = "ethbtn";
            this.ethbtn.Size = new System.Drawing.Size(153, 67);
            this.ethbtn.TabIndex = 22;
            this.ethbtn.Text = "Ethereum";
            this.ethbtn.UseVisualStyleBackColor = false;
            this.ethbtn.Click += new System.EventHandler(this.ethbtn_Click);
            // 
            // dogebtn
            // 
            this.dogebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.dogebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogebtn.Location = new System.Drawing.Point(155, 255);
            this.dogebtn.Name = "dogebtn";
            this.dogebtn.Size = new System.Drawing.Size(153, 67);
            this.dogebtn.TabIndex = 23;
            this.dogebtn.Text = "Dogecoin";
            this.dogebtn.UseVisualStyleBackColor = false;
            this.dogebtn.Click += new System.EventHandler(this.dogebtn_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(834, 595);
            this.Controls.Add(this.gbxPass);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.act_btn);
            this.Controls.Add(this.transact_btn);
            this.Controls.Add(this.stats_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.gbxexchange);
            this.Name = "FmMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FmMenu_Load);
            this.gbxPass.ResumeLayout(false);
            this.gbxPass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbxreg.ResumeLayout(false);
            this.gbxreg.PerformLayout();
            this.gbxexchange.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox name_txt;
        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.Button transact_btn;
        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.GroupBox gbxPass;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox pass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox user_txt;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.GroupBox gbxreg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox userreg;
        private System.Windows.Forms.RichTextBox passtext1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox passtxt2;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox emailreg;
        private System.Windows.Forms.GroupBox gbxexchange;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btcbtn;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button dogebtn;
        private System.Windows.Forms.Button ethbtn;
    }
}

