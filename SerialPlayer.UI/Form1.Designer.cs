namespace SerialPlayer.UI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnSkip);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CMD";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(169, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EQU";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(325, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Album";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.txtResp);
            this.groupBox4.Location = new System.Drawing.Point(498, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 236);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(7, 20);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(44, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(57, 20);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(54, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(7, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(66, 78);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(54, 23);
            this.btnSkip.TabIndex = 0;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(6, 78);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(54, 23);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtResp
            // 
            this.txtResp.Enabled = false;
            this.txtResp.Location = new System.Drawing.Point(6, 20);
            this.txtResp.Multiline = true;
            this.txtResp.Name = "txtResp";
            this.txtResp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResp.Size = new System.Drawing.Size(192, 177);
            this.txtResp.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 261);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Button btnClear;
    }
}

