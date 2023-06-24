namespace Wordle
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtRemaining = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.txtGuesses = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.Label();
            this.txtChar1 = new System.Windows.Forms.Label();
            this.txtChar4 = new System.Windows.Forms.Label();
            this.txtChar3 = new System.Windows.Forms.Label();
            this.txtChar2 = new System.Windows.Forms.Label();
            this.txtChar5 = new System.Windows.Forms.Label();
            this.green1 = new System.Windows.Forms.PictureBox();
            this.grey1 = new System.Windows.Forms.PictureBox();
            this.yellow1 = new System.Windows.Forms.PictureBox();
            this.yellow2 = new System.Windows.Forms.PictureBox();
            this.yellow3 = new System.Windows.Forms.PictureBox();
            this.yellow5 = new System.Windows.Forms.PictureBox();
            this.yellow4 = new System.Windows.Forms.PictureBox();
            this.grey5 = new System.Windows.Forms.PictureBox();
            this.grey4 = new System.Windows.Forms.PictureBox();
            this.grey2 = new System.Windows.Forms.PictureBox();
            this.grey3 = new System.Windows.Forms.PictureBox();
            this.green3 = new System.Windows.Forms.PictureBox();
            this.green5 = new System.Windows.Forms.PictureBox();
            this.green4 = new System.Windows.Forms.PictureBox();
            this.green2 = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(466, 291);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(95, 38);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtRemaining
            // 
            this.txtRemaining.AutoSize = true;
            this.txtRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.Location = new System.Drawing.Point(15, 300);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(236, 29);
            this.txtRemaining.TabIndex = 2;
            this.txtRemaining.Text = "Guesses Remaining:";
            // 
            // txtGuess
            // 
            this.txtGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(315, 291);
            this.txtGuess.MaxLength = 5;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(142, 38);
            this.txtGuess.TabIndex = 3;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGuesses
            // 
            this.txtGuesses.AutoSize = true;
            this.txtGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuesses.Location = new System.Drawing.Point(257, 300);
            this.txtGuesses.Name = "txtGuesses";
            this.txtGuesses.Size = new System.Drawing.Size(26, 29);
            this.txtGuesses.TabIndex = 4;
            this.txtGuesses.Text = "6";
            // 
            // txtInstructions
            // 
            this.txtInstructions.AutoSize = true;
            this.txtInstructions.Location = new System.Drawing.Point(3, 9);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(523, 176);
            this.txtInstructions.TabIndex = 5;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            // 
            // txtChar1
            // 
            this.txtChar1.AutoSize = true;
            this.txtChar1.BackColor = System.Drawing.Color.Transparent;
            this.txtChar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtChar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChar1.Location = new System.Drawing.Point(128, 207);
            this.txtChar1.Name = "txtChar1";
            this.txtChar1.Size = new System.Drawing.Size(0, 36);
            this.txtChar1.TabIndex = 6;
            // 
            // txtChar4
            // 
            this.txtChar4.AutoSize = true;
            this.txtChar4.BackColor = System.Drawing.Color.Transparent;
            this.txtChar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChar4.Location = new System.Drawing.Point(340, 207);
            this.txtChar4.Name = "txtChar4";
            this.txtChar4.Size = new System.Drawing.Size(0, 36);
            this.txtChar4.TabIndex = 7;
            // 
            // txtChar3
            // 
            this.txtChar3.AutoSize = true;
            this.txtChar3.BackColor = System.Drawing.Color.Transparent;
            this.txtChar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChar3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtChar3.Location = new System.Drawing.Point(273, 207);
            this.txtChar3.Name = "txtChar3";
            this.txtChar3.Size = new System.Drawing.Size(0, 36);
            this.txtChar3.TabIndex = 8;
            // 
            // txtChar2
            // 
            this.txtChar2.AutoSize = true;
            this.txtChar2.BackColor = System.Drawing.Color.Transparent;
            this.txtChar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChar2.Location = new System.Drawing.Point(199, 207);
            this.txtChar2.Name = "txtChar2";
            this.txtChar2.Size = new System.Drawing.Size(0, 36);
            this.txtChar2.TabIndex = 9;
            // 
            // txtChar5
            // 
            this.txtChar5.AutoSize = true;
            this.txtChar5.BackColor = System.Drawing.Color.Transparent;
            this.txtChar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChar5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtChar5.Location = new System.Drawing.Point(411, 207);
            this.txtChar5.Name = "txtChar5";
            this.txtChar5.Size = new System.Drawing.Size(0, 36);
            this.txtChar5.TabIndex = 10;
            this.txtChar5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // green1
            // 
            this.green1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green1.BackgroundImage")));
            this.green1.Location = new System.Drawing.Point(117, 192);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(64, 66);
            this.green1.TabIndex = 11;
            this.green1.TabStop = false;
            this.green1.Visible = false;
            // 
            // grey1
            // 
            this.grey1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grey1.BackgroundImage")));
            this.grey1.Location = new System.Drawing.Point(116, 192);
            this.grey1.Name = "grey1";
            this.grey1.Size = new System.Drawing.Size(64, 66);
            this.grey1.TabIndex = 12;
            this.grey1.TabStop = false;
            this.grey1.Visible = false;
            // 
            // yellow1
            // 
            this.yellow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow1.BackgroundImage")));
            this.yellow1.Location = new System.Drawing.Point(116, 192);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(64, 66);
            this.yellow1.TabIndex = 13;
            this.yellow1.TabStop = false;
            this.yellow1.Visible = false;
            // 
            // yellow2
            // 
            this.yellow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow2.BackgroundImage")));
            this.yellow2.Location = new System.Drawing.Point(186, 192);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(64, 66);
            this.yellow2.TabIndex = 14;
            this.yellow2.TabStop = false;
            this.yellow2.Visible = false;
            // 
            // yellow3
            // 
            this.yellow3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow3.BackgroundImage")));
            this.yellow3.Location = new System.Drawing.Point(256, 192);
            this.yellow3.Name = "yellow3";
            this.yellow3.Size = new System.Drawing.Size(64, 66);
            this.yellow3.TabIndex = 15;
            this.yellow3.TabStop = false;
            this.yellow3.Visible = false;
            // 
            // yellow5
            // 
            this.yellow5.BackColor = System.Drawing.Color.Transparent;
            this.yellow5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow5.BackgroundImage")));
            this.yellow5.Location = new System.Drawing.Point(396, 192);
            this.yellow5.Name = "yellow5";
            this.yellow5.Size = new System.Drawing.Size(64, 66);
            this.yellow5.TabIndex = 16;
            this.yellow5.TabStop = false;
            this.yellow5.Visible = false;
            // 
            // yellow4
            // 
            this.yellow4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow4.BackgroundImage")));
            this.yellow4.Location = new System.Drawing.Point(326, 192);
            this.yellow4.Name = "yellow4";
            this.yellow4.Size = new System.Drawing.Size(64, 66);
            this.yellow4.TabIndex = 17;
            this.yellow4.TabStop = false;
            this.yellow4.Visible = false;
            // 
            // grey5
            // 
            this.grey5.BackColor = System.Drawing.Color.Transparent;
            this.grey5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grey5.BackgroundImage")));
            this.grey5.Location = new System.Drawing.Point(396, 192);
            this.grey5.Name = "grey5";
            this.grey5.Size = new System.Drawing.Size(64, 66);
            this.grey5.TabIndex = 18;
            this.grey5.TabStop = false;
            this.grey5.Visible = false;
            // 
            // grey4
            // 
            this.grey4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grey4.BackgroundImage")));
            this.grey4.Location = new System.Drawing.Point(326, 192);
            this.grey4.Name = "grey4";
            this.grey4.Size = new System.Drawing.Size(64, 66);
            this.grey4.TabIndex = 19;
            this.grey4.TabStop = false;
            this.grey4.Visible = false;
            // 
            // grey2
            // 
            this.grey2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grey2.BackgroundImage")));
            this.grey2.Location = new System.Drawing.Point(186, 192);
            this.grey2.Name = "grey2";
            this.grey2.Size = new System.Drawing.Size(64, 66);
            this.grey2.TabIndex = 20;
            this.grey2.TabStop = false;
            this.grey2.Visible = false;
            // 
            // grey3
            // 
            this.grey3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grey3.BackgroundImage")));
            this.grey3.Location = new System.Drawing.Point(256, 192);
            this.grey3.Name = "grey3";
            this.grey3.Size = new System.Drawing.Size(64, 66);
            this.grey3.TabIndex = 21;
            this.grey3.TabStop = false;
            this.grey3.Visible = false;
            // 
            // green3
            // 
            this.green3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green3.BackgroundImage")));
            this.green3.Location = new System.Drawing.Point(256, 192);
            this.green3.Name = "green3";
            this.green3.Size = new System.Drawing.Size(64, 66);
            this.green3.TabIndex = 22;
            this.green3.TabStop = false;
            this.green3.Visible = false;
            // 
            // green5
            // 
            this.green5.BackColor = System.Drawing.Color.Transparent;
            this.green5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green5.BackgroundImage")));
            this.green5.Location = new System.Drawing.Point(396, 192);
            this.green5.Name = "green5";
            this.green5.Size = new System.Drawing.Size(64, 66);
            this.green5.TabIndex = 23;
            this.green5.TabStop = false;
            this.green5.Visible = false;
            // 
            // green4
            // 
            this.green4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green4.BackgroundImage")));
            this.green4.Location = new System.Drawing.Point(326, 192);
            this.green4.Name = "green4";
            this.green4.Size = new System.Drawing.Size(64, 66);
            this.green4.TabIndex = 24;
            this.green4.TabStop = false;
            this.green4.Visible = false;
            // 
            // green2
            // 
            this.green2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green2.BackgroundImage")));
            this.green2.Location = new System.Drawing.Point(186, 192);
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(64, 66);
            this.green2.TabIndex = 25;
            this.green2.TabStop = false;
            this.green2.Visible = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(422, 25);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(159, 36);
            this.btnNewGame.TabIndex = 27;
            this.btnNewGame.Text = "Play Again";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 354);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtChar2);
            this.Controls.Add(this.txtChar5);
            this.Controls.Add(this.txtChar3);
            this.Controls.Add(this.txtChar4);
            this.Controls.Add(this.green3);
            this.Controls.Add(this.txtChar1);
            this.Controls.Add(this.green2);
            this.Controls.Add(this.green4);
            this.Controls.Add(this.green5);
            this.Controls.Add(this.grey3);
            this.Controls.Add(this.grey4);
            this.Controls.Add(this.grey5);
            this.Controls.Add(this.yellow4);
            this.Controls.Add(this.yellow5);
            this.Controls.Add(this.yellow3);
            this.Controls.Add(this.txtGuesses);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.grey2);
            this.Controls.Add(this.yellow2);
            this.Controls.Add(this.green1);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.grey1);
            this.Controls.Add(this.txtInstructions);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label txtRemaining;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label txtGuesses;
        private System.Windows.Forms.Label txtInstructions;
        private System.Windows.Forms.Label txtChar1;
        private System.Windows.Forms.Label txtChar4;
        private System.Windows.Forms.Label txtChar3;
        private System.Windows.Forms.Label txtChar2;
        private System.Windows.Forms.Label txtChar5;
        private System.Windows.Forms.PictureBox green1;
        private System.Windows.Forms.PictureBox grey1;
        private System.Windows.Forms.PictureBox yellow1;
        private System.Windows.Forms.PictureBox yellow2;
        private System.Windows.Forms.PictureBox yellow3;
        private System.Windows.Forms.PictureBox yellow5;
        private System.Windows.Forms.PictureBox yellow4;
        private System.Windows.Forms.PictureBox grey5;
        private System.Windows.Forms.PictureBox grey4;
        private System.Windows.Forms.PictureBox grey2;
        private System.Windows.Forms.PictureBox grey3;
        private System.Windows.Forms.PictureBox green3;
        private System.Windows.Forms.PictureBox green5;
        private System.Windows.Forms.PictureBox green4;
        private System.Windows.Forms.PictureBox green2;
        private System.Windows.Forms.Button btnNewGame;
    }
}