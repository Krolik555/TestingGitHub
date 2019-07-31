namespace SnakeAttempt
{
    partial class Display
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aLabelGameOver = new System.Windows.Forms.Label();
            this.AppleBody = new System.Windows.Forms.PictureBox();
            this.aPictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.aLabelScoreLabel = new System.Windows.Forms.Label();
            this.aLabelBodySizeLabel = new System.Windows.Forms.Label();
            this.aLabelScore = new System.Windows.Forms.Label();
            this.aLabelBodySize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppleBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // aLabelGameOver
            // 
            this.aLabelGameOver.AutoSize = true;
            this.aLabelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelGameOver.ForeColor = System.Drawing.Color.Red;
            this.aLabelGameOver.Location = new System.Drawing.Point(178, 102);
            this.aLabelGameOver.Name = "aLabelGameOver";
            this.aLabelGameOver.Size = new System.Drawing.Size(235, 46);
            this.aLabelGameOver.TabIndex = 1;
            this.aLabelGameOver.Text = "Game Over!";
            this.aLabelGameOver.Visible = false;
            // 
            // AppleBody
            // 
            this.AppleBody.BackColor = System.Drawing.Color.OrangeRed;
            this.AppleBody.Location = new System.Drawing.Point(112, 271);
            this.AppleBody.Name = "AppleBody";
            this.AppleBody.Size = new System.Drawing.Size(18, 18);
            this.AppleBody.TabIndex = 2;
            this.AppleBody.TabStop = false;
            // 
            // aPictureBoxDisplay
            // 
            this.aPictureBoxDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aPictureBoxDisplay.Location = new System.Drawing.Point(0, 0);
            this.aPictureBoxDisplay.Name = "aPictureBoxDisplay";
            this.aPictureBoxDisplay.Size = new System.Drawing.Size(584, 562);
            this.aPictureBoxDisplay.TabIndex = 4;
            this.aPictureBoxDisplay.TabStop = false;
            this.aPictureBoxDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.APictureBoxDisplay_Paint);
            // 
            // aLabelScoreLabel
            // 
            this.aLabelScoreLabel.AutoSize = true;
            this.aLabelScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelScoreLabel.Location = new System.Drawing.Point(647, 40);
            this.aLabelScoreLabel.Name = "aLabelScoreLabel";
            this.aLabelScoreLabel.Size = new System.Drawing.Size(221, 46);
            this.aLabelScoreLabel.TabIndex = 5;
            this.aLabelScoreLabel.Text = "Your Score";
            // 
            // aLabelBodySizeLabel
            // 
            this.aLabelBodySizeLabel.AutoSize = true;
            this.aLabelBodySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelBodySizeLabel.Location = new System.Drawing.Point(611, 161);
            this.aLabelBodySizeLabel.Name = "aLabelBodySizeLabel";
            this.aLabelBodySizeLabel.Size = new System.Drawing.Size(296, 46);
            this.aLabelBodySizeLabel.TabIndex = 7;
            this.aLabelBodySizeLabel.Text = "Your Body Size";
            // 
            // aLabelScore
            // 
            this.aLabelScore.AutoSize = true;
            this.aLabelScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aLabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelScore.Location = new System.Drawing.Point(829, 86);
            this.aLabelScore.Name = "aLabelScore";
            this.aLabelScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aLabelScore.Size = new System.Drawing.Size(25, 27);
            this.aLabelScore.TabIndex = 8;
            this.aLabelScore.Text = "0";
            // 
            // aLabelBodySize
            // 
            this.aLabelBodySize.AutoSize = true;
            this.aLabelBodySize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aLabelBodySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelBodySize.Location = new System.Drawing.Point(829, 207);
            this.aLabelBodySize.Name = "aLabelBodySize";
            this.aLabelBodySize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aLabelBodySize.Size = new System.Drawing.Size(25, 27);
            this.aLabelBodySize.TabIndex = 9;
            this.aLabelBodySize.Text = "0";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(919, 561);
            this.Controls.Add(this.aLabelBodySize);
            this.Controls.Add(this.aLabelScore);
            this.Controls.Add(this.aLabelBodySizeLabel);
            this.Controls.Add(this.aLabelScoreLabel);
            this.Controls.Add(this.AppleBody);
            this.Controls.Add(this.aLabelGameOver);
            this.Controls.Add(this.aPictureBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Attempt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AppleBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label aLabelGameOver;
        private System.Windows.Forms.PictureBox AppleBody;
        private System.Windows.Forms.PictureBox aPictureBoxDisplay;
        private System.Windows.Forms.Label aLabelScoreLabel;
        private System.Windows.Forms.Label aLabelBodySizeLabel;
        private System.Windows.Forms.Label aLabelScore;
        private System.Windows.Forms.Label aLabelBodySize;
    }
}

