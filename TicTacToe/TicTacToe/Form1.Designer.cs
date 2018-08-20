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
            this.btnTL = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnBM = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOWins = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTL
            // 
            this.btnTL.Location = new System.Drawing.Point(3, 7);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(75, 70);
            this.btnTL.TabIndex = 0;
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.button_click);
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(84, 7);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(75, 70);
            this.btnTM.TabIndex = 1;
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.button_click);
            // 
            // btnTR
            // 
            this.btnTR.Location = new System.Drawing.Point(165, 7);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(75, 70);
            this.btnTR.TabIndex = 2;
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.button_click);
            // 
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(3, 83);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(75, 70);
            this.btnCL.TabIndex = 3;
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.button_click);
            // 
            // btnCM
            // 
            this.btnCM.Location = new System.Drawing.Point(84, 83);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(75, 70);
            this.btnCM.TabIndex = 4;
            this.btnCM.UseVisualStyleBackColor = true;
            this.btnCM.Click += new System.EventHandler(this.button_click);
            // 
            // btnCR
            // 
            this.btnCR.Location = new System.Drawing.Point(165, 83);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(75, 70);
            this.btnCR.TabIndex = 5;
            this.btnCR.UseVisualStyleBackColor = true;
            this.btnCR.Click += new System.EventHandler(this.button_click);
            // 
            // btnBL
            // 
            this.btnBL.Location = new System.Drawing.Point(3, 159);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(75, 70);
            this.btnBL.TabIndex = 6;
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.button_click);
            // 
            // btnBM
            // 
            this.btnBM.Location = new System.Drawing.Point(84, 159);
            this.btnBM.Name = "btnBM";
            this.btnBM.Size = new System.Drawing.Size(75, 70);
            this.btnBM.TabIndex = 7;
            this.btnBM.UseVisualStyleBackColor = true;
            this.btnBM.Click += new System.EventHandler(this.button_click);
            // 
            // btnBR
            // 
            this.btnBR.Location = new System.Drawing.Point(165, 159);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(75, 70);
            this.btnBR.TabIndex = 8;
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.button_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOWins);
            this.groupBox1.Controls.Add(this.lblXWins);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Location = new System.Drawing.Point(140, 25);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(13, 13);
            this.lblOWins.TabIndex = 3;
            this.lblOWins.Text = "0";
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Location = new System.Drawing.Point(59, 25);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(13, 13);
            this.lblXWins.TabIndex = 2;
            this.lblXWins.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "O:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X: ";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(15, 315);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(96, 315);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset Score";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(177, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gameBoard
            // 
            this.gameBoard.Controls.Add(this.btnBL);
            this.gameBoard.Controls.Add(this.btnBM);
            this.gameBoard.Controls.Add(this.btnBR);
            this.gameBoard.Controls.Add(this.btnCL);
            this.gameBoard.Controls.Add(this.btnCM);
            this.gameBoard.Controls.Add(this.btnTR);
            this.gameBoard.Controls.Add(this.btnCR);
            this.gameBoard.Controls.Add(this.btnTM);
            this.gameBoard.Controls.Add(this.btnTL);
            this.gameBoard.Location = new System.Drawing.Point(12, 71);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(244, 235);
            this.gameBoard.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 354);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gameBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Button btnCR;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnBM;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOWins;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel gameBoard;
    }
}

