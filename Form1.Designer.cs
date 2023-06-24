namespace Wordle
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
            this.btnAnimals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnPlaces = new System.Windows.Forms.Button();
            this.btnVerbs = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnimals
            // 
            this.btnAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimals.Location = new System.Drawing.Point(56, 69);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(199, 54);
            this.btnAnimals.TabIndex = 0;
            this.btnAnimals.Text = "Animals";
            this.btnAnimals.UseVisualStyleBackColor = true;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Catagory";
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(57, 143);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(199, 55);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnPlaces
            // 
            this.btnPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaces.Location = new System.Drawing.Point(57, 217);
            this.btnPlaces.Name = "btnPlaces";
            this.btnPlaces.Size = new System.Drawing.Size(198, 58);
            this.btnPlaces.TabIndex = 4;
            this.btnPlaces.Text = "Places";
            this.btnPlaces.UseVisualStyleBackColor = true;
            this.btnPlaces.Click += new System.EventHandler(this.btnPlaces_Click);
            // 
            // btnVerbs
            // 
            this.btnVerbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerbs.Location = new System.Drawing.Point(57, 298);
            this.btnVerbs.Name = "btnVerbs";
            this.btnVerbs.Size = new System.Drawing.Size(198, 59);
            this.btnVerbs.TabIndex = 5;
            this.btnVerbs.Text = "Verbs";
            this.btnVerbs.UseVisualStyleBackColor = true;
            this.btnVerbs.Click += new System.EventHandler(this.btnVerbs_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(58, 376);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(198, 60);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 448);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnVerbs);
            this.Controls.Add(this.btnPlaces);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnimals);
            this.Name = "Form1";
            this.Text = "Start Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnimals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnPlaces;
        private System.Windows.Forms.Button btnVerbs;
        private System.Windows.Forms.Button btnRandom;
    }
}

