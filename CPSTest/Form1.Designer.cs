namespace CPSTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWynik = new System.Windows.Forms.Label();
            this.tmrCzas = new System.Windows.Forms.Timer(this.components);
            this.tmrTest = new System.Windows.Forms.Timer(this.components);
            this.lblCzas = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblChooseTime = new System.Windows.Forms.Label();
            this.tbxCzas = new System.Windows.Forms.TextBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblCps = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWynik
            // 
            this.lblWynik.BackColor = System.Drawing.Color.Transparent;
            this.lblWynik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWynik.Location = new System.Drawing.Point(20, 20);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(135, 38);
            this.lblWynik.TabIndex = 0;
            this.lblWynik.Text = "SCORE: 0";
            this.lblWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCzas
            // 
            this.tmrCzas.Interval = 1000;
            this.tmrCzas.Tick += new System.EventHandler(this.tmrCzas_Tick_1);
            // 
            // tmrTest
            // 
            this.tmrTest.Tick += new System.EventHandler(this.tmrTest_Tick);
            // 
            // lblCzas
            // 
            this.lblCzas.BackColor = System.Drawing.Color.Transparent;
            this.lblCzas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCzas.Location = new System.Drawing.Point(20, 278);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(135, 42);
            this.lblCzas.TabIndex = 1;
            this.lblCzas.Text = "TIME: 0";
            this.lblCzas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(20, 146);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(135, 106);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "CLICK!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click_1);
            // 
            // lblChooseTime
            // 
            this.lblChooseTime.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseTime.Location = new System.Drawing.Point(203, 20);
            this.lblChooseTime.Name = "lblChooseTime";
            this.lblChooseTime.Size = new System.Drawing.Size(160, 38);
            this.lblChooseTime.TabIndex = 3;
            this.lblChooseTime.Text = "Choose a time";
            this.lblChooseTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChooseTime.Click += new System.EventHandler(this.lblChooseTime_Click);
            // 
            // tbxCzas
            // 
            this.tbxCzas.Location = new System.Drawing.Point(203, 86);
            this.tbxCzas.Name = "tbxCzas";
            this.tbxCzas.Size = new System.Drawing.Size(102, 23);
            this.tbxCzas.TabIndex = 4;
            this.tbxCzas.TextChanged += new System.EventHandler(this.tbxCzas_TextChanged);
            // 
            // lblSec
            // 
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSec.Location = new System.Drawing.Point(311, 76);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(100, 33);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "seconds";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSec.Click += new System.EventHandler(this.lblSec_Click);
            // 
            // lblCps
            // 
            this.lblCps.BackColor = System.Drawing.Color.Transparent;
            this.lblCps.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCps.Location = new System.Drawing.Point(20, 76);
            this.lblCps.Name = "lblCps";
            this.lblCps.Size = new System.Drawing.Size(135, 33);
            this.lblCps.TabIndex = 6;
            this.lblCps.Text = "CPS: 0";
            this.lblCps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank
            // 
            this.lblRank.BackColor = System.Drawing.Color.Transparent;
            this.lblRank.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRank.Location = new System.Drawing.Point(397, 20);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(430, 38);
            this.lblRank.TabIndex = 7;
            this.lblRank.Text = "previous attempts (resets after shutdown):";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRank.Click += new System.EventHandler(this.lblRank_Click);
            // 
            // lblRanking
            // 
            this.lblRanking.BackColor = System.Drawing.Color.Transparent;
            this.lblRanking.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRanking.Location = new System.Drawing.Point(429, 76);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(366, 244);
            this.lblRanking.TabIndex = 8;
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRanking.Click += new System.EventHandler(this.lblRanking_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(203, 177);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(203, 214);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(102, 109);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "After completing the test, click the reset button";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPSTest.Properties.Resources.GradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 335);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblCps);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.tbxCzas);
            this.Controls.Add(this.lblChooseTime);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblCzas);
            this.Controls.Add(this.lblWynik);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CPS Test";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWynik;
        private System.Windows.Forms.Timer tmrCzas;
        private System.Windows.Forms.Timer tmrTest;
        private Label lblCzas;
        private Button btnClick;
        private Label lblChooseTime;
        private TextBox tbxCzas;
        private Label lblSec;
        private Label lblCps;
        private Label lblRank;
        private Label lblRanking;
        private Button btnReset;
        private Label lblText;
    }
}