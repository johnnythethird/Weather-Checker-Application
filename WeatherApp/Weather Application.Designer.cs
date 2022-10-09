using System;

namespace WeatherApp
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
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.lebel22 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.lebel30 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TempF = new System.Windows.Forms.Label();
            this.TempC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(151, 84);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(253, 29);
            this.TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(432, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(98, 292);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(90, 22);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(98, 337);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(68, 22);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(428, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sunrise:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(513, 292);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(41, 22);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(428, 338);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 22);
            this.label20.TabIndex = 7;
            this.label20.Text = "Sunset:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(513, 338);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(41, 22);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(555, 246);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(41, 22);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // lebel22
            // 
            this.lebel22.AutoSize = true;
            this.lebel22.BackColor = System.Drawing.Color.Transparent;
            this.lebel22.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel22.ForeColor = System.Drawing.Color.White;
            this.lebel22.Location = new System.Drawing.Point(428, 246);
            this.lebel22.Name = "lebel22";
            this.lebel22.Size = new System.Drawing.Size(92, 22);
            this.lebel22.TabIndex = 11;
            this.lebel22.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(555, 200);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(41, 22);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // lebel30
            // 
            this.lebel30.AutoSize = true;
            this.lebel30.BackColor = System.Drawing.Color.Transparent;
            this.lebel30.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel30.ForeColor = System.Drawing.Color.White;
            this.lebel30.Location = new System.Drawing.Point(428, 200);
            this.lebel30.Name = "lebel30";
            this.lebel30.Size = new System.Drawing.Size(121, 22);
            this.lebel30.TabIndex = 9;
            this.lebel30.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(102, 135);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(79, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 60);
            this.label2.TabIndex = 15;
            this.label2.Text = "WEATHER CHECKER APPLICATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(513, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter any city to get the forcast!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temperature in Fahrenheit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Temperature in Celcius:";
            // 
            // TempF
            // 
            this.TempF.AutoSize = true;
            this.TempF.BackColor = System.Drawing.Color.Transparent;
            this.TempF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempF.ForeColor = System.Drawing.Color.White;
            this.TempF.Location = new System.Drawing.Point(336, 246);
            this.TempF.Name = "TempF";
            this.TempF.Size = new System.Drawing.Size(41, 22);
            this.TempF.TabIndex = 20;
            this.TempF.Text = "N/A";
            // 
            // TempC
            // 
            this.TempC.AutoSize = true;
            this.TempC.BackColor = System.Drawing.Color.Transparent;
            this.TempC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempC.ForeColor = System.Drawing.Color.White;
            this.TempC.Location = new System.Drawing.Point(336, 200);
            this.TempC.Name = "TempC";
            this.TempC.Size = new System.Drawing.Size(41, 22);
            this.TempC.TabIndex = 19;
            this.TempC.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TempF);
            this.Controls.Add(this.TempC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.lebel22);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.lebel30);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label lebel22;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label lebel30;
        private System.Windows.Forms.PictureBox picIcon;
        private EventHandler label4_Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TempF;
        private System.Windows.Forms.Label TempC;
    }
}

