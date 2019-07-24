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
            this.Player1Body = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aLabelGameOver = new System.Windows.Forms.Label();
            this.AppleBody = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppleBody)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Body
            // 
            this.Player1Body.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player1Body.Location = new System.Drawing.Point(283, 271);
            this.Player1Body.Name = "Player1Body";
            this.Player1Body.Size = new System.Drawing.Size(18, 18);
            this.Player1Body.TabIndex = 0;
            this.Player1Body.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
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
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.AppleBody);
            this.Controls.Add(this.aLabelGameOver);
            this.Controls.Add(this.Player1Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Display";
            this.Text = "Snake Attempt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player1Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppleBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1Body;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label aLabelGameOver;
        private System.Windows.Forms.PictureBox AppleBody;
    }
}

