namespace DiceWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2Game = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4Wins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6Loses = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8Roll = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10Point = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game";
            // 
            // label2Game
            // 
            this.label2Game.AutoSize = true;
            this.label2Game.Location = new System.Drawing.Point(39, 34);
            this.label2Game.Name = "label2Game";
            this.label2Game.Size = new System.Drawing.Size(13, 13);
            this.label2Game.TabIndex = 1;
            this.label2Game.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wins";
            // 
            // label4Wins
            // 
            this.label4Wins.AutoSize = true;
            this.label4Wins.Location = new System.Drawing.Point(107, 34);
            this.label4Wins.Name = "label4Wins";
            this.label4Wins.Size = new System.Drawing.Size(13, 13);
            this.label4Wins.TabIndex = 3;
            this.label4Wins.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loses";
            // 
            // label6Loses
            // 
            this.label6Loses.AutoSize = true;
            this.label6Loses.Location = new System.Drawing.Point(175, 38);
            this.label6Loses.Name = "label6Loses";
            this.label6Loses.Size = new System.Drawing.Size(13, 13);
            this.label6Loses.TabIndex = 5;
            this.label6Loses.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Roll:";
            // 
            // label8Roll
            // 
            this.label8Roll.AutoSize = true;
            this.label8Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8Roll.Location = new System.Drawing.Point(80, 157);
            this.label8Roll.Name = "label8Roll";
            this.label8Roll.Size = new System.Drawing.Size(14, 20);
            this.label8Roll.TabIndex = 7;
            this.label8Roll.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Point:";
            // 
            // label10Point
            // 
            this.label10Point.AutoSize = true;
            this.label10Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10Point.Location = new System.Drawing.Point(235, 157);
            this.label10Point.Name = "label10Point";
            this.label10Point.Size = new System.Drawing.Size(14, 20);
            this.label10Point.TabIndex = 9;
            this.label10Point.Text = "-";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "ROLL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Click Here To Roll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10Point);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8Roll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6Loses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4Wins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2Game);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2Game;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4Wins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6Loses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8Roll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10Point;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

