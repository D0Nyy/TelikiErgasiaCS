﻿
namespace Chess_Game
{
    partial class Form_Chess_Menu
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
            this.textBox_Player1 = new System.Windows.Forms.TextBox();
            this.label_chess = new System.Windows.Forms.Label();
            this.pictureBox_Menu = new System.Windows.Forms.PictureBox();
            this.label_Player1 = new System.Windows.Forms.Label();
            this.label_Player2 = new System.Windows.Forms.Label();
            this.textBox_Player2 = new System.Windows.Forms.TextBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Player1
            // 
            this.textBox_Player1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Player1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Player1.Location = new System.Drawing.Point(268, 146);
            this.textBox_Player1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Player1.Name = "textBox_Player1";
            this.textBox_Player1.Size = new System.Drawing.Size(258, 28);
            this.textBox_Player1.TabIndex = 1;
            // 
            // label_chess
            // 
            this.label_chess.AutoSize = true;
            this.label_chess.BackColor = System.Drawing.Color.Peru;
            this.label_chess.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_chess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_chess.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_chess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_chess.Location = new System.Drawing.Point(340, 28);
            this.label_chess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_chess.Name = "label_chess";
            this.label_chess.Size = new System.Drawing.Size(112, 47);
            this.label_chess.TabIndex = 2;
            this.label_chess.Text = "Chess";
            // 
            // pictureBox_Menu
            // 
            this.pictureBox_Menu.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.pictureBox_Menu.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Menu.Name = "pictureBox_Menu";
            this.pictureBox_Menu.Size = new System.Drawing.Size(810, 538);
            this.pictureBox_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Menu.TabIndex = 0;
            this.pictureBox_Menu.TabStop = false;
            // 
            // label_Player1
            // 
            this.label_Player1.AutoSize = true;
            this.label_Player1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Player1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Player1.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Player1.Location = new System.Drawing.Point(352, 102);
            this.label_Player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Player1.Name = "label_Player1";
            this.label_Player1.Size = new System.Drawing.Size(92, 29);
            this.label_Player1.TabIndex = 3;
            this.label_Player1.Text = "Player 1";
            // 
            // label_Player2
            // 
            this.label_Player2.AutoSize = true;
            this.label_Player2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Player2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Player2.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Player2.Location = new System.Drawing.Point(352, 189);
            this.label_Player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Player2.Name = "label_Player2";
            this.label_Player2.Size = new System.Drawing.Size(92, 29);
            this.label_Player2.TabIndex = 4;
            this.label_Player2.Text = "Player 2";
            // 
            // textBox_Player2
            // 
            this.textBox_Player2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Player2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Player2.Location = new System.Drawing.Point(268, 233);
            this.textBox_Player2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Player2.Name = "textBox_Player2";
            this.textBox_Player2.Size = new System.Drawing.Size(258, 28);
            this.textBox_Player2.TabIndex = 5;
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Play.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_Play.Location = new System.Drawing.Point(341, 281);
            this.button_Play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(105, 42);
            this.button_Play.TabIndex = 6;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonExit.Location = new System.Drawing.Point(341, 331);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 42);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form_Chess_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 529);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.textBox_Player2);
            this.Controls.Add(this.label_Player2);
            this.Controls.Add(this.label_Player1);
            this.Controls.Add(this.label_chess);
            this.Controls.Add(this.textBox_Player1);
            this.Controls.Add(this.pictureBox_Menu);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Chess_Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Chess_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Menu;
        private System.Windows.Forms.TextBox textBox_Player1;
        private System.Windows.Forms.Label label_chess;
        private System.Windows.Forms.Label label_Player1;
        private System.Windows.Forms.Label label_Player2;
        private System.Windows.Forms.TextBox textBox_Player2;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button buttonExit;
    }
}

