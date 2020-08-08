namespace DND_Dice_Roller
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
            this.d20Button = new System.Windows.Forms.Button();
            this.d12Button = new System.Windows.Forms.Button();
            this.d10Button = new System.Windows.Forms.Button();
            this.d8Button = new System.Windows.Forms.Button();
            this.d6Button = new System.Windows.Forms.Button();
            this.d4Button = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.rollResultValue = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // d20Button
            // 
            this.d20Button.Location = new System.Drawing.Point(39, 117);
            this.d20Button.Name = "d20Button";
            this.d20Button.Size = new System.Drawing.Size(78, 34);
            this.d20Button.TabIndex = 0;
            this.d20Button.Text = "d20 roll";
            this.d20Button.UseVisualStyleBackColor = true;
            this.d20Button.Click += new System.EventHandler(this.d20Button_Click);
            // 
            // d12Button
            // 
            this.d12Button.Location = new System.Drawing.Point(149, 117);
            this.d12Button.Name = "d12Button";
            this.d12Button.Size = new System.Drawing.Size(78, 34);
            this.d12Button.TabIndex = 1;
            this.d12Button.Text = "d12 roll";
            this.d12Button.UseVisualStyleBackColor = true;
            this.d12Button.Click += new System.EventHandler(this.d12Button_Click);
            // 
            // d10Button
            // 
            this.d10Button.Location = new System.Drawing.Point(259, 117);
            this.d10Button.Name = "d10Button";
            this.d10Button.Size = new System.Drawing.Size(78, 34);
            this.d10Button.TabIndex = 2;
            this.d10Button.Text = "d10 roll";
            this.d10Button.UseVisualStyleBackColor = true;
            this.d10Button.Click += new System.EventHandler(this.d10Button_Click);
            // 
            // d8Button
            // 
            this.d8Button.Location = new System.Drawing.Point(369, 117);
            this.d8Button.Name = "d8Button";
            this.d8Button.Size = new System.Drawing.Size(78, 34);
            this.d8Button.TabIndex = 3;
            this.d8Button.Text = "d8 roll";
            this.d8Button.UseVisualStyleBackColor = true;
            this.d8Button.Click += new System.EventHandler(this.d8Button_Click);
            // 
            // d6Button
            // 
            this.d6Button.Location = new System.Drawing.Point(479, 117);
            this.d6Button.Name = "d6Button";
            this.d6Button.Size = new System.Drawing.Size(78, 34);
            this.d6Button.TabIndex = 4;
            this.d6Button.Text = "d6 roll";
            this.d6Button.UseVisualStyleBackColor = true;
            this.d6Button.Click += new System.EventHandler(this.d6Button_Click);
            // 
            // d4Button
            // 
            this.d4Button.Location = new System.Drawing.Point(589, 117);
            this.d4Button.Name = "d4Button";
            this.d4Button.Size = new System.Drawing.Size(78, 34);
            this.d4Button.TabIndex = 5;
            this.d4Button.Text = "d4 roll";
            this.d4Button.UseVisualStyleBackColor = true;
            this.d4Button.Click += new System.EventHandler(this.d4Button_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(268, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(178, 39);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "DND Dice Roller";
            // 
            // rollResultValue
            // 
            this.rollResultValue.Location = new System.Drawing.Point(275, 262);
            this.rollResultValue.Name = "rollResultValue";
            this.rollResultValue.Size = new System.Drawing.Size(152, 26);
            this.rollResultValue.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(313, 294);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 34);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 337);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rollResultValue);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.d4Button);
            this.Controls.Add(this.d6Button);
            this.Controls.Add(this.d8Button);
            this.Controls.Add(this.d10Button);
            this.Controls.Add(this.d12Button);
            this.Controls.Add(this.d20Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button d20Button;
        private System.Windows.Forms.Button d12Button;
        private System.Windows.Forms.Button d10Button;
        private System.Windows.Forms.Button d8Button;
        private System.Windows.Forms.Button d6Button;
        private System.Windows.Forms.Button d4Button;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox rollResultValue;
        private System.Windows.Forms.Button clearButton;
    }
}

