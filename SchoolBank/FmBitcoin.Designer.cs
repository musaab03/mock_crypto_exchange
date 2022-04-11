namespace SchoolBank
{
    partial class FmBitcoin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.name_txt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbbal = new System.Windows.Forms.Label();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.order_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.RichTextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.btcgraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcgraph)).BeginInit();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.SkyBlue;
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(261, 12);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(237, 45);
            this.name_txt.TabIndex = 3;
            this.name_txt.Text = "Crypto Exchange";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.rbSell);
            this.groupBox1.Controls.Add(this.lbbal);
            this.groupBox1.Controls.Add(this.order_btn);
            this.groupBox1.Controls.Add(this.rbBuy);
            this.groupBox1.Controls.Add(this.amount_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 335);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitcoin";
            // 
            // lbbal
            // 
            this.lbbal.AutoSize = true;
            this.lbbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbal.Location = new System.Drawing.Point(106, 85);
            this.lbbal.Name = "lbbal";
            this.lbbal.Size = new System.Drawing.Size(105, 25);
            this.lbbal.TabIndex = 1;
            this.lbbal.Text = "lbbalance";
            // 
            // rbSell
            // 
            this.rbSell.AutoSize = true;
            this.rbSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSell.Location = new System.Drawing.Point(204, 152);
            this.rbSell.Name = "rbSell";
            this.rbSell.Size = new System.Drawing.Size(53, 24);
            this.rbSell.TabIndex = 19;
            this.rbSell.TabStop = true;
            this.rbSell.Text = "Sell";
            this.rbSell.UseVisualStyleBackColor = true;
            // 
            // rbBuy
            // 
            this.rbBuy.AutoSize = true;
            this.rbBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbBuy.Location = new System.Drawing.Point(63, 152);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(54, 24);
            this.rbBuy.TabIndex = 18;
            this.rbBuy.TabStop = true;
            this.rbBuy.Text = "Buy";
            this.rbBuy.UseVisualStyleBackColor = true;
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.Location = new System.Drawing.Point(111, 271);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(98, 43);
            this.order_btn.TabIndex = 13;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter amount: ";
            // 
            // amount_txt
            // 
            this.amount_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_txt.Location = new System.Drawing.Point(165, 204);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(117, 41);
            this.amount_txt.TabIndex = 9;
            this.amount_txt.Text = "";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(704, 26);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(56, 20);
            this.lbDate.TabIndex = 20;
            this.lbDate.Text = "lbDate";
            // 
            // btcgraph
            // 
            chartArea1.Name = "ChartArea1";
            this.btcgraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.btcgraph.Legends.Add(legend1);
            this.btcgraph.Location = new System.Drawing.Point(390, 95);
            this.btcgraph.Name = "btcgraph";
            this.btcgraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.btcgraph.Series.Add(series1);
            this.btcgraph.Size = new System.Drawing.Size(387, 328);
            this.btcgraph.TabIndex = 21;
            this.btcgraph.Text = "chart1";
            this.btcgraph.Click += new System.EventHandler(this.btcgraph_Click);
            // 
            // FmBitcoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btcgraph);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name_txt);
            this.Name = "FmBitcoin";
            this.Text = "FmBitcoin";
            this.Load += new System.EventHandler(this.FmBitcoin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcgraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox name_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbbal;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.RichTextBox amount_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart btcgraph;
    }
}