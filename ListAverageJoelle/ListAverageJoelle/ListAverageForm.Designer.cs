namespace ListAverageJoelle
{
    partial class frmListAverage
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
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblIntructions = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(43, 140);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(480, 160);
            this.lstMarks.TabIndex = 0;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAverage.Location = new System.Drawing.Point(43, 329);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(102, 43);
            this.btnCalculateAverage.TabIndex = 1;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblIntructions
            // 
            this.lblIntructions.AutoSize = true;
            this.lblIntructions.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntructions.Location = new System.Drawing.Point(38, 50);
            this.lblIntructions.Name = "lblIntructions";
            this.lblIntructions.Size = new System.Drawing.Size(315, 26);
            this.lblIntructions.TabIndex = 2;
            this.lblIntructions.Text = "Enter a mark between 1-100";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(402, 50);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(43, 91);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(102, 30);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(207, 349);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(146, 23);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "The average is: ";
            // 
            // frmListAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 412);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblIntructions);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.lstMarks);
            this.Name = "frmListAverage";
            this.Text = "List Average                  by:  Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblIntructions;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblAverage;
    }
}

