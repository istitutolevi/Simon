namespace Simon
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(227, 12);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(141, 127);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.TabStop = false;
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.button_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(412, 192);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(141, 127);
            this.btnRed.TabIndex = 2;
            this.btnRed.TabStop = false;
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(227, 357);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(141, 127);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.TabStop = false;
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.button_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(49, 192);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(141, 127);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.TabStop = false;
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.button_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(227, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(46, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 496);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
    }
}

