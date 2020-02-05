namespace RecipeHelper
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtMillilitres = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.btnConvertToFahrenheit = new System.Windows.Forms.Button();
            this.btnConvertToCups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Millilitres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fahrenheit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cups";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(135, 60);
            this.txtCelsius.Margin = new System.Windows.Forms.Padding(5);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(123, 30);
            this.txtCelsius.TabIndex = 4;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            // 
            // txtMillilitres
            // 
            this.txtMillilitres.AcceptsReturn = true;
            this.txtMillilitres.Location = new System.Drawing.Point(511, 60);
            this.txtMillilitres.Margin = new System.Windows.Forms.Padding(5);
            this.txtMillilitres.Name = "txtMillilitres";
            this.txtMillilitres.Size = new System.Drawing.Size(123, 30);
            this.txtMillilitres.TabIndex = 5;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(135, 205);
            this.txtFahrenheit.Margin = new System.Windows.Forms.Padding(5);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(123, 30);
            this.txtFahrenheit.TabIndex = 6;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(511, 208);
            this.txtCups.Margin = new System.Windows.Forms.Padding(5);
            this.txtCups.Name = "txtCups";
            this.txtCups.ReadOnly = true;
            this.txtCups.Size = new System.Drawing.Size(123, 30);
            this.txtCups.TabIndex = 7;
            // 
            // btnConvertToFahrenheit
            // 
            this.btnConvertToFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToFahrenheit.Location = new System.Drawing.Point(57, 115);
            this.btnConvertToFahrenheit.Margin = new System.Windows.Forms.Padding(5);
            this.btnConvertToFahrenheit.Name = "btnConvertToFahrenheit";
            this.btnConvertToFahrenheit.Size = new System.Drawing.Size(151, 56);
            this.btnConvertToFahrenheit.TabIndex = 8;
            this.btnConvertToFahrenheit.Text = "&Convert to Fahrenheit";
            this.btnConvertToFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertToFahrenheit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvertToCups
            // 
            this.btnConvertToCups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToCups.Location = new System.Drawing.Point(358, 115);
            this.btnConvertToCups.Margin = new System.Windows.Forms.Padding(5);
            this.btnConvertToCups.Name = "btnConvertToCups";
            this.btnConvertToCups.Size = new System.Drawing.Size(140, 56);
            this.btnConvertToCups.TabIndex = 9;
            this.btnConvertToCups.Text = "&Convert to Cups";
            this.btnConvertToCups.UseVisualStyleBackColor = true;
            this.btnConvertToCups.Click += new System.EventHandler(this.btnConvertToCups_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvertToFahrenheit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 275);
            this.Controls.Add(this.btnConvertToCups);
            this.Controls.Add(this.btnConvertToFahrenheit);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtMillilitres);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtMillilitres;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCups;
        private System.Windows.Forms.Button btnConvertToFahrenheit;
        private System.Windows.Forms.Button btnConvertToCups;
    }
}

