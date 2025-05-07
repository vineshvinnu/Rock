namespace RockPaperScissorsWinForms
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

            this.btnRock = new Button();
            this.btnPaper = new Button();
            this.btnScissors = new Button();
            this.btnReset = new Button();
            this.picUser = new PictureBox();
            this.picComputer = new PictureBox();
            this.lblResult = new Label();
            this.lblUserScore = new Label();
            this.lblComputerScore = new Label();

            SuspendLayout();

            // 
            // btnRock
            // 
            this.btnRock.Location = new Point(50, 350); // Adjust position as needed
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new Size(100, 50);
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new EventHandler(this.btnRock_Click);

            // 
            // btnPaper
            // 
            this.btnPaper.Location = new Point(200, 350);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new Size(100, 50);
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new EventHandler(this.btnPaper_Click);

            // 
            // btnScissors
            // 
            this.btnScissors.Location = new Point(350, 350);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new Size(100, 50);
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new EventHandler(this.btnScissors_Click);

            // 
            // btnReset
            // 
            this.btnReset.Location = new Point(500, 350);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(100, 50);
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new EventHandler(this.btnReset_Click);

            // 
            // picUser
            // 
            this.picUser.Location = new Point(50, 100);
            this.picUser.Name = "picUser";
            this.picUser.Size = new Size(100, 100);
            this.picUser.SizeMode = PictureBoxSizeMode.StretchImage;

            // 
            // picComputer
            // 
            this.picComputer.Location = new Point(350, 100);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new Size(100, 100);
            this.picComputer.SizeMode = PictureBoxSizeMode.StretchImage;

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new Point(50, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Size(50, 20);
            this.lblResult.Text = "Result";

            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new Point(50, 50);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new Size(100, 20);
            this.lblUserScore.Text = "You: 0";

            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new Point(350, 50);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new Size(130, 20);
            this.lblComputerScore.Text = "Computer: 0";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ControlLight;
            this.ClientSize = new Size(876, 494);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblComputerScore);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
