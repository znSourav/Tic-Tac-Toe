namespace Tic_Tac_Toe
{
    partial class TicHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicHome));
            this.StartButton = new System.Windows.Forms.Button();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1GB = new System.Windows.Forms.GroupBox();
            this.Player1RBO = new System.Windows.Forms.RadioButton();
            this.Player1RBX = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Player2RBO = new System.Windows.Forms.RadioButton();
            this.Player2RBX = new System.Windows.Forms.RadioButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayerP = new System.Windows.Forms.Label();
            this.SignLabel = new System.Windows.Forms.Label();
            this.Player1GB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(411, 363);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 46);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(138, 352);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(77, 24);
            this.Player1Label.TabIndex = 1;
            this.Player1Label.Text = "Player 1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Label.Location = new System.Drawing.Point(609, 351);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(77, 24);
            this.Player2Label.TabIndex = 2;
            this.Player2Label.Text = "Player 2";
            // 
            // Player1GB
            // 
            this.Player1GB.BackColor = System.Drawing.Color.Transparent;
            this.Player1GB.Controls.Add(this.Player1RBO);
            this.Player1GB.Controls.Add(this.Player1RBX);
            this.Player1GB.Location = new System.Drawing.Point(142, 392);
            this.Player1GB.Name = "Player1GB";
            this.Player1GB.Size = new System.Drawing.Size(99, 67);
            this.Player1GB.TabIndex = 3;
            this.Player1GB.TabStop = false;
            // 
            // Player1RBO
            // 
            this.Player1RBO.AutoSize = true;
            this.Player1RBO.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1RBO.Location = new System.Drawing.Point(7, 36);
            this.Player1RBO.Name = "Player1RBO";
            this.Player1RBO.Size = new System.Drawing.Size(41, 28);
            this.Player1RBO.TabIndex = 1;
            this.Player1RBO.TabStop = true;
            this.Player1RBO.Text = "O";
            this.Player1RBO.UseVisualStyleBackColor = true;
            // 
            // Player1RBX
            // 
            this.Player1RBX.AutoSize = true;
            this.Player1RBX.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1RBX.Location = new System.Drawing.Point(7, 12);
            this.Player1RBX.Name = "Player1RBX";
            this.Player1RBX.Size = new System.Drawing.Size(39, 28);
            this.Player1RBX.TabIndex = 0;
            this.Player1RBX.TabStop = true;
            this.Player1RBX.Text = "X";
            this.Player1RBX.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Player2RBO);
            this.groupBox1.Controls.Add(this.Player2RBX);
            this.groupBox1.Location = new System.Drawing.Point(613, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Player2RBO
            // 
            this.Player2RBO.AutoSize = true;
            this.Player2RBO.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2RBO.Location = new System.Drawing.Point(6, 36);
            this.Player2RBO.Name = "Player2RBO";
            this.Player2RBO.Size = new System.Drawing.Size(41, 28);
            this.Player2RBO.TabIndex = 1;
            this.Player2RBO.TabStop = true;
            this.Player2RBO.Text = "O";
            this.Player2RBO.UseVisualStyleBackColor = true;
            // 
            // Player2RBX
            // 
            this.Player2RBX.AutoSize = true;
            this.Player2RBX.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2RBX.Location = new System.Drawing.Point(7, 12);
            this.Player2RBX.Name = "Player2RBX";
            this.Player2RBX.Size = new System.Drawing.Size(39, 28);
            this.Player2RBX.TabIndex = 0;
            this.Player2RBX.TabStop = true;
            this.Player2RBX.Text = "X";
            this.Player2RBX.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.TTT1;
            this.gamePanel.Controls.Add(this.SignLabel);
            this.gamePanel.Controls.Add(this.PlayerP);
            this.gamePanel.Controls.Add(this.ExitButton);
            this.gamePanel.Controls.Add(this.ReplayButton);
            this.gamePanel.Controls.Add(this.button9);
            this.gamePanel.Controls.Add(this.button8);
            this.gamePanel.Controls.Add(this.button7);
            this.gamePanel.Controls.Add(this.button6);
            this.gamePanel.Controls.Add(this.button5);
            this.gamePanel.Controls.Add(this.button4);
            this.gamePanel.Controls.Add(this.button3);
            this.gamePanel.Controls.Add(this.button2);
            this.gamePanel.Controls.Add(this.button1);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(894, 491);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(594, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 131);
            this.button9.TabIndex = 8;
            this.button9.Text = "         ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(444, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 131);
            this.button8.TabIndex = 7;
            this.button8.Text = "        ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(294, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 131);
            this.button7.TabIndex = 6;
            this.button7.Text = "       ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(594, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 131);
            this.button6.TabIndex = 5;
            this.button6.Text = "      ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(444, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 131);
            this.button5.TabIndex = 4;
            this.button5.Text = "     ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(294, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 131);
            this.button4.TabIndex = 3;
            this.button4.Text = "    ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(594, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 131);
            this.button3.TabIndex = 2;
            this.button3.Text = "   ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(444, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 131);
            this.button2.TabIndex = 1;
            this.button2.Text = "  ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Button;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(294, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 131);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ReplayButton
            // 
            this.ReplayButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReplayButton.Enabled = false;
            this.ReplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReplayButton.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.Location = new System.Drawing.Point(23, 356);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(167, 42);
            this.ReplayButton.TabIndex = 9;
            this.ReplayButton.Text = "Play Again";
            this.ReplayButton.UseVisualStyleBackColor = false;
            this.ReplayButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(23, 411);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 42);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // PlayerP
            // 
            this.PlayerP.AutoSize = true;
            this.PlayerP.BackColor = System.Drawing.Color.Transparent;
            this.PlayerP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerP.Location = new System.Drawing.Point(55, 52);
            this.PlayerP.Name = "PlayerP";
            this.PlayerP.Size = new System.Drawing.Size(100, 29);
            this.PlayerP.TabIndex = 11;
            this.PlayerP.Text = "Player 1";
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.Location = new System.Drawing.Point(80, 102);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(27, 37);
            this.SignLabel.TabIndex = 12;
            this.SignLabel.Text = " ";
            // 
            // TicHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.cover_start;
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Player1GB);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicHome";
            this.Text = "Tic Tac Toe";
            this.Player1GB.ResumeLayout(false);
            this.Player1GB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.GroupBox Player1GB;
        private System.Windows.Forms.RadioButton Player1RBO;
        private System.Windows.Forms.RadioButton Player1RBX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Player2RBO;
        private System.Windows.Forms.RadioButton Player2RBX;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.Label PlayerP;
    }
}

