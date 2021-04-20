namespace Laba1
{
    partial class DialogForm_Size
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.OtherSize = new System.Windows.Forms.CheckBox();
            this.Large_Size_Button = new System.Windows.Forms.RadioButton();
            this.Mid_Size_Button = new System.Windows.Forms.RadioButton();
            this.Small_Size_Button = new System.Windows.Forms.RadioButton();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HeightLabel);
            this.groupBox1.Controls.Add(this.WidthLabel);
            this.groupBox1.Controls.Add(this.HeightText);
            this.groupBox1.Controls.Add(this.WidthText);
            this.groupBox1.Controls.Add(this.OtherSize);
            this.groupBox1.Controls.Add(this.Large_Size_Button);
            this.groupBox1.Controls.Add(this.Mid_Size_Button);
            this.groupBox1.Controls.Add(this.Small_Size_Button);
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Enabled = false;
            this.HeightLabel.Location = new System.Drawing.Point(101, 140);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(80, 13);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "По вертикали:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Enabled = false;
            this.WidthLabel.Location = new System.Drawing.Point(101, 77);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(74, 26);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "По\r\nгоризонтали:";
            // 
            // HeightText
            // 
            this.HeightText.Enabled = false;
            this.HeightText.Location = new System.Drawing.Point(187, 133);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(100, 20);
            this.HeightText.TabIndex = 5;
            // 
            // WidthText
            // 
            this.WidthText.Enabled = false;
            this.WidthText.Location = new System.Drawing.Point(187, 83);
            this.WidthText.Name = "WidthText";
            this.WidthText.Size = new System.Drawing.Size(100, 20);
            this.WidthText.TabIndex = 4;
            // 
            // OtherSize
            // 
            this.OtherSize.AutoSize = true;
            this.OtherSize.Location = new System.Drawing.Point(187, 42);
            this.OtherSize.Name = "OtherSize";
            this.OtherSize.Size = new System.Drawing.Size(86, 17);
            this.OtherSize.TabIndex = 3;
            this.OtherSize.Text = "Свой выбор";
            this.OtherSize.UseVisualStyleBackColor = true;
            this.OtherSize.CheckedChanged += new System.EventHandler(this.OtherSize_CheckedChanged);
            // 
            // Large_Size_Button
            // 
            this.Large_Size_Button.AutoSize = true;
            this.Large_Size_Button.Location = new System.Drawing.Point(18, 136);
            this.Large_Size_Button.Margin = new System.Windows.Forms.Padding(15);
            this.Large_Size_Button.Name = "Large_Size_Button";
            this.Large_Size_Button.Size = new System.Drawing.Size(72, 17);
            this.Large_Size_Button.TabIndex = 2;
            this.Large_Size_Button.TabStop = true;
            this.Large_Size_Button.Text = "800 x 600";
            this.Large_Size_Button.UseVisualStyleBackColor = true;
            // 
            // Mid_Size_Button
            // 
            this.Mid_Size_Button.AutoSize = true;
            this.Mid_Size_Button.Location = new System.Drawing.Point(18, 89);
            this.Mid_Size_Button.Margin = new System.Windows.Forms.Padding(15);
            this.Mid_Size_Button.Name = "Mid_Size_Button";
            this.Mid_Size_Button.Size = new System.Drawing.Size(72, 17);
            this.Mid_Size_Button.TabIndex = 1;
            this.Mid_Size_Button.TabStop = true;
            this.Mid_Size_Button.Text = "640 x 480";
            this.Mid_Size_Button.UseVisualStyleBackColor = true;
            // 
            // Small_Size_Button
            // 
            this.Small_Size_Button.AutoSize = true;
            this.Small_Size_Button.Location = new System.Drawing.Point(18, 42);
            this.Small_Size_Button.Margin = new System.Windows.Forms.Padding(15);
            this.Small_Size_Button.Name = "Small_Size_Button";
            this.Small_Size_Button.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Small_Size_Button.Size = new System.Drawing.Size(82, 17);
            this.Small_Size_Button.TabIndex = 0;
            this.Small_Size_Button.TabStop = true;
            this.Small_Size_Button.Text = "320 x 240";
            this.Small_Size_Button.UseVisualStyleBackColor = true;
            // 
            // Ok_Button
            // 
            this.Ok_Button.Location = new System.Drawing.Point(88, 254);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(75, 23);
            this.Ok_Button.TabIndex = 1;
            this.Ok_Button.Text = "OK";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(240, 254);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // DialogForm_Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm_Size";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 100, 100);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить размер";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Large_Size_Button;
        private System.Windows.Forms.RadioButton Mid_Size_Button;
        private System.Windows.Forms.RadioButton Small_Size_Button;
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.CheckBox OtherSize;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox WidthText;
    }
}