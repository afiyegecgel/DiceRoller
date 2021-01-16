namespace DiceRoller
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblFirstPlayerMoney = new System.Windows.Forms.Label();
            this.lblSecondPlayerMoney = new System.Windows.Forms.Label();
            this.lblPlayersBet = new System.Windows.Forms.Label();
            this.txtFirsPlayerBet = new System.Windows.Forms.TextBox();
            this.txtSecondPlayerBet = new System.Windows.Forms.TextBox();
            this.btnFirstPlayerConfirmBet = new System.Windows.Forms.Button();
            this.btnSecondPlayerConfirmBet = new System.Windows.Forms.Button();
            this.btnFirstPlayerPlay = new System.Windows.Forms.Button();
            this.btnSecondPlayerPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.lblFirstPlayerDiceValue = new System.Windows.Forms.Label();
            this.lblSecondPlayerDiceValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(55, 9);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(141, 26);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Roll The Dice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer1.Location = new System.Drawing.Point(90, 63);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(57, 16);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer2.Location = new System.Drawing.Point(250, 63);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(57, 16);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.Location = new System.Drawing.Point(12, 97);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(49, 16);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "Money";
            // 
            // lblFirstPlayerMoney
            // 
            this.lblFirstPlayerMoney.AutoSize = true;
            this.lblFirstPlayerMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstPlayerMoney.Location = new System.Drawing.Point(90, 100);
            this.lblFirstPlayerMoney.Name = "lblFirstPlayerMoney";
            this.lblFirstPlayerMoney.Size = new System.Drawing.Size(0, 16);
            this.lblFirstPlayerMoney.TabIndex = 2;
            // 
            // lblSecondPlayerMoney
            // 
            this.lblSecondPlayerMoney.AutoSize = true;
            this.lblSecondPlayerMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecondPlayerMoney.Location = new System.Drawing.Point(250, 100);
            this.lblSecondPlayerMoney.Name = "lblSecondPlayerMoney";
            this.lblSecondPlayerMoney.Size = new System.Drawing.Size(0, 16);
            this.lblSecondPlayerMoney.TabIndex = 2;
            // 
            // lblPlayersBet
            // 
            this.lblPlayersBet.AutoSize = true;
            this.lblPlayersBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayersBet.Location = new System.Drawing.Point(12, 143);
            this.lblPlayersBet.Name = "lblPlayersBet";
            this.lblPlayersBet.Size = new System.Drawing.Size(28, 16);
            this.lblPlayersBet.TabIndex = 2;
            this.lblPlayersBet.Text = "Bet";
            // 
            // txtFirsPlayerBet
            // 
            this.txtFirsPlayerBet.Location = new System.Drawing.Point(93, 141);
            this.txtFirsPlayerBet.Name = "txtFirsPlayerBet";
            this.txtFirsPlayerBet.Size = new System.Drawing.Size(75, 20);
            this.txtFirsPlayerBet.TabIndex = 0;
            // 
            // txtSecondPlayerBet
            // 
            this.txtSecondPlayerBet.Location = new System.Drawing.Point(253, 141);
            this.txtSecondPlayerBet.Name = "txtSecondPlayerBet";
            this.txtSecondPlayerBet.Size = new System.Drawing.Size(75, 20);
            this.txtSecondPlayerBet.TabIndex = 1;
            // 
            // btnFirstPlayerConfirmBet
            // 
            this.btnFirstPlayerConfirmBet.Location = new System.Drawing.Point(93, 184);
            this.btnFirstPlayerConfirmBet.Name = "btnFirstPlayerConfirmBet";
            this.btnFirstPlayerConfirmBet.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPlayerConfirmBet.TabIndex = 2;
            this.btnFirstPlayerConfirmBet.Text = "Confirm";
            this.btnFirstPlayerConfirmBet.UseVisualStyleBackColor = true;
            this.btnFirstPlayerConfirmBet.Click += new System.EventHandler(this.btnFirstPlayerConfirmBet_Click);
            // 
            // btnSecondPlayerConfirmBet
            // 
            this.btnSecondPlayerConfirmBet.Location = new System.Drawing.Point(253, 184);
            this.btnSecondPlayerConfirmBet.Name = "btnSecondPlayerConfirmBet";
            this.btnSecondPlayerConfirmBet.Size = new System.Drawing.Size(75, 23);
            this.btnSecondPlayerConfirmBet.TabIndex = 3;
            this.btnSecondPlayerConfirmBet.Text = "Confirm";
            this.btnSecondPlayerConfirmBet.UseVisualStyleBackColor = true;
            this.btnSecondPlayerConfirmBet.Click += new System.EventHandler(this.btnSecondPlayerConfirmBet_Click);
            // 
            // btnFirstPlayerPlay
            // 
            this.btnFirstPlayerPlay.Location = new System.Drawing.Point(93, 240);
            this.btnFirstPlayerPlay.Name = "btnFirstPlayerPlay";
            this.btnFirstPlayerPlay.Size = new System.Drawing.Size(75, 37);
            this.btnFirstPlayerPlay.TabIndex = 4;
            this.btnFirstPlayerPlay.Text = "Player 1 Play";
            this.btnFirstPlayerPlay.UseVisualStyleBackColor = true;
            this.btnFirstPlayerPlay.Click += new System.EventHandler(this.btnFirstPlayerPlay_Click);
            // 
            // btnSecondPlayerPlay
            // 
            this.btnSecondPlayerPlay.Location = new System.Drawing.Point(253, 240);
            this.btnSecondPlayerPlay.Name = "btnSecondPlayerPlay";
            this.btnSecondPlayerPlay.Size = new System.Drawing.Size(75, 37);
            this.btnSecondPlayerPlay.TabIndex = 5;
            this.btnSecondPlayerPlay.Text = "Player 2 Play";
            this.btnSecondPlayerPlay.UseVisualStyleBackColor = true;
            this.btnSecondPlayerPlay.Click += new System.EventHandler(this.btnSecondPlayerPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(12, 348);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameResult.Location = new System.Drawing.Point(90, 348);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(0, 16);
            this.lblGameResult.TabIndex = 2;
            // 
            // lblFirstPlayerDiceValue
            // 
            this.lblFirstPlayerDiceValue.AutoSize = true;
            this.lblFirstPlayerDiceValue.Location = new System.Drawing.Point(90, 300);
            this.lblFirstPlayerDiceValue.Name = "lblFirstPlayerDiceValue";
            this.lblFirstPlayerDiceValue.Size = new System.Drawing.Size(0, 13);
            this.lblFirstPlayerDiceValue.TabIndex = 6;
            // 
            // lblSecondPlayerDiceValue
            // 
            this.lblSecondPlayerDiceValue.AutoSize = true;
            this.lblSecondPlayerDiceValue.Location = new System.Drawing.Point(250, 300);
            this.lblSecondPlayerDiceValue.Name = "lblSecondPlayerDiceValue";
            this.lblSecondPlayerDiceValue.Size = new System.Drawing.Size(0, 13);
            this.lblSecondPlayerDiceValue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 397);
            this.Controls.Add(this.lblSecondPlayerDiceValue);
            this.Controls.Add(this.lblFirstPlayerDiceValue);
            this.Controls.Add(this.btnSecondPlayerPlay);
            this.Controls.Add(this.btnFirstPlayerPlay);
            this.Controls.Add(this.btnSecondPlayerConfirmBet);
            this.Controls.Add(this.btnFirstPlayerConfirmBet);
            this.Controls.Add(this.txtSecondPlayerBet);
            this.Controls.Add(this.txtFirsPlayerBet);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblSecondPlayerMoney);
            this.Controls.Add(this.lblFirstPlayerMoney);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPlayersBet);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblFirstPlayerMoney;
        private System.Windows.Forms.Label lblSecondPlayerMoney;
        private System.Windows.Forms.Label lblPlayersBet;
        private System.Windows.Forms.TextBox txtFirsPlayerBet;
        private System.Windows.Forms.TextBox txtSecondPlayerBet;
        private System.Windows.Forms.Button btnFirstPlayerConfirmBet;
        private System.Windows.Forms.Button btnSecondPlayerConfirmBet;
        private System.Windows.Forms.Button btnFirstPlayerPlay;
        private System.Windows.Forms.Button btnSecondPlayerPlay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.Label lblFirstPlayerDiceValue;
        private System.Windows.Forms.Label lblSecondPlayerDiceValue;
    }
}

