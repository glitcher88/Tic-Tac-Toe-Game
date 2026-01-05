namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblOWins = new System.Windows.Forms.Label();
            this.btnResetWinsCounters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 96);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(132, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Lime;
            this.lblTurn.Location = new System.Drawing.Point(132, 208);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(183, 58);
            this.lblTurn.TabIndex = 11;
            this.lblTurn.Text = "Player X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(132, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 58);
            this.label3.TabIndex = 12;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(132, 405);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(240, 58);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "In Progress";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Navy;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Lime;
            this.btnReset.Location = new System.Drawing.Point(84, 499);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(288, 77);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(454, 483);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 95);
            this.button7.TabIndex = 8;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(454, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 95);
            this.button1.TabIndex = 7;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(454, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 95);
            this.button4.TabIndex = 6;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(686, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 95);
            this.button2.TabIndex = 5;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(918, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 95);
            this.button3.TabIndex = 4;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(918, 483);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 95);
            this.button9.TabIndex = 3;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(686, 483);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 95);
            this.button8.TabIndex = 2;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(918, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 95);
            this.button6.TabIndex = 1;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(686, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 95);
            this.button5.TabIndex = 0;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXWins.ForeColor = System.Drawing.Color.Red;
            this.lblXWins.Location = new System.Drawing.Point(241, 13);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(157, 45);
            this.lblXWins.TabIndex = 16;
            this.lblXWins.Text = "X wins: 0";
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOWins.ForeColor = System.Drawing.Color.Aqua;
            this.lblOWins.Location = new System.Drawing.Point(241, 62);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(162, 45);
            this.lblOWins.TabIndex = 17;
            this.lblOWins.Text = "O wins: 0";
            // 
            // btnResetWinsCounters
            // 
            this.btnResetWinsCounters.BackColor = System.Drawing.Color.Navy;
            this.btnResetWinsCounters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetWinsCounters.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetWinsCounters.ForeColor = System.Drawing.Color.Lime;
            this.btnResetWinsCounters.Location = new System.Drawing.Point(12, 21);
            this.btnResetWinsCounters.Name = "btnResetWinsCounters";
            this.btnResetWinsCounters.Size = new System.Drawing.Size(196, 96);
            this.btnResetWinsCounters.TabIndex = 18;
            this.btnResetWinsCounters.Text = "Reset Wins Counters";
            this.btnResetWinsCounters.UseVisualStyleBackColor = false;
            this.btnResetWinsCounters.Click += new System.EventHandler(this.btnResetWinsCounters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1224, 636);
            this.Controls.Add(this.btnResetWinsCounters);
            this.Controls.Add(this.lblOWins);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game Powered by - Glitcher";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblOWins;
        private System.Windows.Forms.Button btnResetWinsCounters;
    }
}

