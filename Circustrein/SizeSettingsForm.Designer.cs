namespace Circustrein
{
    partial class SizeSettingsForm
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
            this.lblWagonSize = new System.Windows.Forms.Label();
            this.nmrcWagonSize = new System.Windows.Forms.NumericUpDown();
            this.nmrcSmallAnimalSize = new System.Windows.Forms.NumericUpDown();
            this.lblSmallAnimalSize = new System.Windows.Forms.Label();
            this.nmrcMediumAnimalSize = new System.Windows.Forms.NumericUpDown();
            this.lblMediumAnimalSize = new System.Windows.Forms.Label();
            this.nmrcLargeAnimalSize = new System.Windows.Forms.NumericUpDown();
            this.lblLargeAnimalSize = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWagonSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcSmallAnimalSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMediumAnimalSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLargeAnimalSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWagonSize
            // 
            this.lblWagonSize.AutoSize = true;
            this.lblWagonSize.Location = new System.Drawing.Point(12, 9);
            this.lblWagonSize.Name = "lblWagonSize";
            this.lblWagonSize.Size = new System.Drawing.Size(106, 17);
            this.lblWagonSize.TabIndex = 0;
            this.lblWagonSize.Text = "Wagon grootte:";
            // 
            // nmrcWagonSize
            // 
            this.nmrcWagonSize.Location = new System.Drawing.Point(202, 8);
            this.nmrcWagonSize.Name = "nmrcWagonSize";
            this.nmrcWagonSize.Size = new System.Drawing.Size(120, 22);
            this.nmrcWagonSize.TabIndex = 1;
            // 
            // nmrcSmallAnimalSize
            // 
            this.nmrcSmallAnimalSize.Location = new System.Drawing.Point(202, 36);
            this.nmrcSmallAnimalSize.Name = "nmrcSmallAnimalSize";
            this.nmrcSmallAnimalSize.ReadOnly = true;
            this.nmrcSmallAnimalSize.Size = new System.Drawing.Size(120, 22);
            this.nmrcSmallAnimalSize.TabIndex = 3;
            // 
            // lblSmallAnimalSize
            // 
            this.lblSmallAnimalSize.AutoSize = true;
            this.lblSmallAnimalSize.Location = new System.Drawing.Point(12, 37);
            this.lblSmallAnimalSize.Name = "lblSmallAnimalSize";
            this.lblSmallAnimalSize.Size = new System.Drawing.Size(181, 21);
            this.lblSmallAnimalSize.TabIndex = 2;
            this.lblSmallAnimalSize.Text = "Kleine dieren waarde:";
            // 
            // nmrcMediumAnimalSize
            // 
            this.nmrcMediumAnimalSize.Location = new System.Drawing.Point(202, 64);
            this.nmrcMediumAnimalSize.Name = "nmrcMediumAnimalSize";
            this.nmrcMediumAnimalSize.ReadOnly = true;
            this.nmrcMediumAnimalSize.Size = new System.Drawing.Size(120, 22);
            this.nmrcMediumAnimalSize.TabIndex = 5;
            // 
            // lblMediumAnimalSize
            // 
            this.lblMediumAnimalSize.AutoSize = true;
            this.lblMediumAnimalSize.Location = new System.Drawing.Point(12, 65);
            this.lblMediumAnimalSize.Name = "lblMediumAnimalSize";
            this.lblMediumAnimalSize.Size = new System.Drawing.Size(228, 21);
            this.lblMediumAnimalSize.TabIndex = 4;
            this.lblMediumAnimalSize.Text = "Gemiddelde dieren waarde:";
            // 
            // nmrcLargeAnimalSize
            // 
            this.nmrcLargeAnimalSize.Location = new System.Drawing.Point(202, 92);
            this.nmrcLargeAnimalSize.Name = "nmrcLargeAnimalSize";
            this.nmrcLargeAnimalSize.ReadOnly = true;
            this.nmrcLargeAnimalSize.Size = new System.Drawing.Size(120, 22);
            this.nmrcLargeAnimalSize.TabIndex = 7;
            // 
            // lblLargeAnimalSize
            // 
            this.lblLargeAnimalSize.AutoSize = true;
            this.lblLargeAnimalSize.Location = new System.Drawing.Point(12, 93);
            this.lblLargeAnimalSize.Name = "lblLargeAnimalSize";
            this.lblLargeAnimalSize.Size = new System.Drawing.Size(178, 21);
            this.lblLargeAnimalSize.TabIndex = 6;
            this.lblLargeAnimalSize.Text = "Grote dieren waarde:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(93, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SizeSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 149);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nmrcLargeAnimalSize);
            this.Controls.Add(this.lblLargeAnimalSize);
            this.Controls.Add(this.nmrcMediumAnimalSize);
            this.Controls.Add(this.lblMediumAnimalSize);
            this.Controls.Add(this.nmrcSmallAnimalSize);
            this.Controls.Add(this.lblSmallAnimalSize);
            this.Controls.Add(this.nmrcWagonSize);
            this.Controls.Add(this.lblWagonSize);
            this.Name = "SizeSettingsForm";
            this.Text = "Wagon size settings";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWagonSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcSmallAnimalSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMediumAnimalSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLargeAnimalSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWagonSize;
        private System.Windows.Forms.NumericUpDown nmrcWagonSize;
        private System.Windows.Forms.NumericUpDown nmrcSmallAnimalSize;
        private System.Windows.Forms.Label lblSmallAnimalSize;
        private System.Windows.Forms.NumericUpDown nmrcMediumAnimalSize;
        private System.Windows.Forms.Label lblMediumAnimalSize;
        private System.Windows.Forms.NumericUpDown nmrcLargeAnimalSize;
        private System.Windows.Forms.Label lblLargeAnimalSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}