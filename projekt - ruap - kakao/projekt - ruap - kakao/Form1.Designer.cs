namespace projekt___ruap___kakao
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
            this.txt_rev_date = new System.Windows.Forms.TextBox();
            this.txt_comp_loc = new System.Windows.Forms.TextBox();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.txt_coc_perc = new System.Windows.Forms.TextBox();
            this.lbl_rev_date = new System.Windows.Forms.Label();
            this.lbl_com_loc = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_coc_per = new System.Windows.Forms.Label();
            this.btn_predict = new System.Windows.Forms.Button();
            this.lbl_pred_coc = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_perc = new System.Windows.Forms.Label();
            this.lbl_score_perc = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txt_rev_date
            // 
            this.txt_rev_date.Location = new System.Drawing.Point(34, 42);
            this.txt_rev_date.Name = "txt_rev_date";
            this.txt_rev_date.Size = new System.Drawing.Size(100, 20);
            this.txt_rev_date.TabIndex = 0;
            // 
            // txt_comp_loc
            // 
            this.txt_comp_loc.Location = new System.Drawing.Point(205, 41);
            this.txt_comp_loc.Name = "txt_comp_loc";
            this.txt_comp_loc.Size = new System.Drawing.Size(100, 20);
            this.txt_comp_loc.TabIndex = 1;
            // 
            // txt_rating
            // 
            this.txt_rating.Location = new System.Drawing.Point(341, 42);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(100, 20);
            this.txt_rating.TabIndex = 2;
            // 
            // txt_coc_perc
            // 
            this.txt_coc_perc.Location = new System.Drawing.Point(474, 41);
            this.txt_coc_perc.Name = "txt_coc_perc";
            this.txt_coc_perc.Size = new System.Drawing.Size(100, 20);
            this.txt_coc_perc.TabIndex = 3;
            // 
            // lbl_rev_date
            // 
            this.lbl_rev_date.AutoSize = true;
            this.lbl_rev_date.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_rev_date.Location = new System.Drawing.Point(48, 24);
            this.lbl_rev_date.Name = "lbl_rev_date";
            this.lbl_rev_date.Size = new System.Drawing.Size(69, 13);
            this.lbl_rev_date.TabIndex = 4;
            this.lbl_rev_date.Text = "Review Date";
            this.lbl_rev_date.Click += new System.EventHandler(this.lbl_rev_date_Click);
            // 
            // lbl_com_loc
            // 
            this.lbl_com_loc.AutoSize = true;
            this.lbl_com_loc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_com_loc.Location = new System.Drawing.Point(187, 25);
            this.lbl_com_loc.Name = "lbl_com_loc";
            this.lbl_com_loc.Size = new System.Drawing.Size(135, 13);
            this.lbl_com_loc.TabIndex = 5;
            this.lbl_com_loc.Text = "Company Location (Nation)";
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_rating.Location = new System.Drawing.Point(372, 25);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(38, 13);
            this.lbl_rating.TabIndex = 6;
            this.lbl_rating.Text = "Rating";
            // 
            // lbl_coc_per
            // 
            this.lbl_coc_per.AutoSize = true;
            this.lbl_coc_per.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_coc_per.Location = new System.Drawing.Point(482, 24);
            this.lbl_coc_per.Name = "lbl_coc_per";
            this.lbl_coc_per.Size = new System.Drawing.Size(78, 13);
            this.lbl_coc_per.TabIndex = 7;
            this.lbl_coc_per.Text = "Cocoa Percent";
            // 
            // btn_predict
            // 
            this.btn_predict.Location = new System.Drawing.Point(625, 38);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(75, 23);
            this.btn_predict.TabIndex = 8;
            this.btn_predict.Text = "Predict!";
            this.btn_predict.UseVisualStyleBackColor = true;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // lbl_pred_coc
            // 
            this.lbl_pred_coc.AutoSize = true;
            this.lbl_pred_coc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_pred_coc.Location = new System.Drawing.Point(552, 80);
            this.lbl_pred_coc.Name = "lbl_pred_coc";
            this.lbl_pred_coc.Size = new System.Drawing.Size(81, 13);
            this.lbl_pred_coc.TabIndex = 9;
            this.lbl_pred_coc.Text = "Cocoa Percent:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_score.Location = new System.Drawing.Point(552, 110);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(73, 13);
            this.lbl_score.TabIndex = 10;
            this.lbl_score.Text = "Scored Label:";
            // 
            // lbl_perc
            // 
            this.lbl_perc.AutoSize = true;
            this.lbl_perc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_perc.Location = new System.Drawing.Point(639, 80);
            this.lbl_perc.Name = "lbl_perc";
            this.lbl_perc.Size = new System.Drawing.Size(21, 13);
            this.lbl_perc.TabIndex = 11;
            this.lbl_perc.Text = "0%";
            // 
            // lbl_score_perc
            // 
            this.lbl_score_perc.AutoSize = true;
            this.lbl_score_perc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_score_perc.Location = new System.Drawing.Point(632, 110);
            this.lbl_score_perc.Name = "lbl_score_perc";
            this.lbl_score_perc.Size = new System.Drawing.Size(21, 13);
            this.lbl_score_perc.TabIndex = 12;
            this.lbl_score_perc.Text = "0%";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(34, 110);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(478, 328);
            this.webBrowser1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbl_score_perc);
            this.Controls.Add(this.lbl_perc);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_pred_coc);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.lbl_coc_per);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.lbl_com_loc);
            this.Controls.Add(this.lbl_rev_date);
            this.Controls.Add(this.txt_coc_perc);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.txt_comp_loc);
            this.Controls.Add(this.txt_rev_date);
            this.Name = "Form1";
            this.Text = "Cocoa Percent Predictor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rev_date;
        private System.Windows.Forms.TextBox txt_comp_loc;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.TextBox txt_coc_perc;
        private System.Windows.Forms.Label lbl_rev_date;
        private System.Windows.Forms.Label lbl_com_loc;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_coc_per;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label lbl_pred_coc;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_perc;
        private System.Windows.Forms.Label lbl_score_perc;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

