namespace ArduinoUNO
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.lbRed = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DigiP10 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            this.SuspendLayout();
            // 
            // trackRed
            // 
            this.trackRed.Location = new System.Drawing.Point(166, 48);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(135, 69);
            this.trackRed.SmallChange = 30;
            this.trackRed.TabIndex = 0;
            this.trackRed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(330, 9);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(16, 18);
            this.lbRed.TabIndex = 1;
            this.lbRed.Text = "0";
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(307, 48);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(58, 35);
            this.panelColor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digital-Pin 13";
            // 
            // DigiP10
            // 
            this.DigiP10.AutoSize = true;
            this.DigiP10.Location = new System.Drawing.Point(54, 48);
            this.DigiP10.Name = "DigiP10";
            this.DigiP10.Size = new System.Drawing.Size(58, 22);
            this.DigiP10.TabIndex = 5;
            this.DigiP10.Text = "Off";
            this.DigiP10.UseVisualStyleBackColor = true;
            this.DigiP10.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "PWM Pin 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get I2C Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DigiP10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.trackRed);
            this.Name = "Form1";
            this.Text = "Arduino UNO - COM 7( Andy Chen )";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DigiP10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

