namespace Activity8App
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
            this.fatInGramsLabel1 = new System.Windows.Forms.Label();
            this.carbohydratesInGramsLabel2 = new System.Windows.Forms.Label();
            this.caloriesFromFatLabel3 = new System.Windows.Forms.Label();
            this.caloriesFromCarbsLabel4 = new System.Windows.Forms.Label();
            this.fatInGramsInputTextBox1 = new System.Windows.Forms.TextBox();
            this.carbohydratesInGramsInputTextBox2 = new System.Windows.Forms.TextBox();
            this.calculateFatButton1 = new System.Windows.Forms.Button();
            this.calculateCarbsButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatInGramsLabel1
            // 
            this.fatInGramsLabel1.AutoSize = true;
            this.fatInGramsLabel1.Location = new System.Drawing.Point(28, 46);
            this.fatInGramsLabel1.Name = "fatInGramsLabel1";
            this.fatInGramsLabel1.Size = new System.Drawing.Size(106, 15);
            this.fatInGramsLabel1.TabIndex = 0;
            this.fatInGramsLabel1.Text = "Enter Fat in Grams:";
            // 
            // carbohydratesInGramsLabel2
            // 
            this.carbohydratesInGramsLabel2.AutoSize = true;
            this.carbohydratesInGramsLabel2.Location = new System.Drawing.Point(28, 147);
            this.carbohydratesInGramsLabel2.Name = "carbohydratesInGramsLabel2";
            this.carbohydratesInGramsLabel2.Size = new System.Drawing.Size(167, 15);
            this.carbohydratesInGramsLabel2.TabIndex = 1;
            this.carbohydratesInGramsLabel2.Text = "Enter Carbohydrates in Grams:";
            // 
            // caloriesFromFatLabel3
            // 
            this.caloriesFromFatLabel3.AutoSize = true;
            this.caloriesFromFatLabel3.Location = new System.Drawing.Point(201, 101);
            this.caloriesFromFatLabel3.Name = "caloriesFromFatLabel3";
            this.caloriesFromFatLabel3.Size = new System.Drawing.Size(0, 15);
            this.caloriesFromFatLabel3.TabIndex = 2;
            // 
            // caloriesFromCarbsLabel4
            // 
            this.caloriesFromCarbsLabel4.AutoSize = true;
            this.caloriesFromCarbsLabel4.Location = new System.Drawing.Point(201, 214);
            this.caloriesFromCarbsLabel4.Name = "caloriesFromCarbsLabel4";
            this.caloriesFromCarbsLabel4.Size = new System.Drawing.Size(0, 15);
            this.caloriesFromCarbsLabel4.TabIndex = 3;
            // 
            // fatInGramsInputTextBox1
            // 
            this.fatInGramsInputTextBox1.Location = new System.Drawing.Point(201, 46);
            this.fatInGramsInputTextBox1.Name = "fatInGramsInputTextBox1";
            this.fatInGramsInputTextBox1.Size = new System.Drawing.Size(100, 23);
            this.fatInGramsInputTextBox1.TabIndex = 4;
            // 
            // carbohydratesInGramsInputTextBox2
            // 
            this.carbohydratesInGramsInputTextBox2.Location = new System.Drawing.Point(201, 139);
            this.carbohydratesInGramsInputTextBox2.Name = "carbohydratesInGramsInputTextBox2";
            this.carbohydratesInGramsInputTextBox2.Size = new System.Drawing.Size(100, 23);
            this.carbohydratesInGramsInputTextBox2.TabIndex = 5;
            // 
            // calculateFatButton1
            // 
            this.calculateFatButton1.BackColor = System.Drawing.Color.Yellow;
            this.calculateFatButton1.Location = new System.Drawing.Point(28, 74);
            this.calculateFatButton1.Name = "calculateFatButton1";
            this.calculateFatButton1.Size = new System.Drawing.Size(106, 42);
            this.calculateFatButton1.TabIndex = 6;
            this.calculateFatButton1.Text = "Calculate Fat";
            this.calculateFatButton1.UseVisualStyleBackColor = false;
            this.calculateFatButton1.Click += new System.EventHandler(this.calculateFatButton1_Click);
            // 
            // calculateCarbsButton2
            // 
            this.calculateCarbsButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calculateCarbsButton2.Location = new System.Drawing.Point(28, 183);
            this.calculateCarbsButton2.Name = "calculateCarbsButton2";
            this.calculateCarbsButton2.Size = new System.Drawing.Size(106, 46);
            this.calculateCarbsButton2.TabIndex = 7;
            this.calculateCarbsButton2.Text = "Calculate Carbs";
            this.calculateCarbsButton2.UseVisualStyleBackColor = false;
            this.calculateCarbsButton2.Click += new System.EventHandler(this.calculateCarbsButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(412, 312);
            this.Controls.Add(this.calculateCarbsButton2);
            this.Controls.Add(this.calculateFatButton1);
            this.Controls.Add(this.carbohydratesInGramsInputTextBox2);
            this.Controls.Add(this.fatInGramsInputTextBox1);
            this.Controls.Add(this.caloriesFromCarbsLabel4);
            this.Controls.Add(this.caloriesFromFatLabel3);
            this.Controls.Add(this.carbohydratesInGramsLabel2);
            this.Controls.Add(this.fatInGramsLabel1);
            this.Name = "Form1";
            this.Text = "FatCalories & CarbCalories ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fatInGramsLabel1;
        private Label carbohydratesInGramsLabel2;
        private Label caloriesFromFatLabel3;
        private Label caloriesFromCarbsLabel4;
        private TextBox fatInGramsInputTextBox1;
        private TextBox carbohydratesInGramsInputTextBox2;
        private Button calculateFatButton1;
        private Button calculateCarbsButton2;
    }
}