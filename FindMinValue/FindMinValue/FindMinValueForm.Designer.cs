namespace FindMinValue
{
    partial class frmFindMinValue
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lstArrayOfValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(328, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 42);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinValue.Location = new System.Drawing.Point(242, 369);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(51, 18);
            this.lblMinValue.TabIndex = 5;
            this.lblMinValue.Text = "label1";
            // 
            // lstArrayOfValues
            // 
            this.lstArrayOfValues.FormattingEnabled = true;
            this.lstArrayOfValues.Location = new System.Drawing.Point(177, 155);
            this.lstArrayOfValues.Name = "lstArrayOfValues";
            this.lstArrayOfValues.Size = new System.Drawing.Size(402, 173);
            this.lstArrayOfValues.TabIndex = 4;
            // 
            // frmFindMinValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.lstArrayOfValues);
            this.Controls.Add(this.btnStart);
            this.Name = "frmFindMinValue";
            this.Text = "Find Minimum Value     by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.ListBox lstArrayOfValues;
    }
}

