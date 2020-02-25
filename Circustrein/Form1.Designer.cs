namespace Circustrein
{
    partial class CircustreinForm
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
            this.lstbxAnimals = new System.Windows.Forms.ListBox();
            this.grpbxAddAnimal = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.nmrcTotal = new System.Windows.Forms.NumericUpDown();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpbxEater = new System.Windows.Forms.GroupBox();
            this.rdbtnHerbivore = new System.Windows.Forms.RadioButton();
            this.rdbtnMeatEater = new System.Windows.Forms.RadioButton();
            this.grpbxAnimalSize = new System.Windows.Forms.GroupBox();
            this.rdbtnLarge = new System.Windows.Forms.RadioButton();
            this.rdbtnMedium = new System.Windows.Forms.RadioButton();
            this.rdbtnSmall = new System.Windows.Forms.RadioButton();
            this.lstvwAnimalPairs = new System.Windows.Forms.ListView();
            this.grpbxAddAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcTotal)).BeginInit();
            this.grpbxEater.SuspendLayout();
            this.grpbxAnimalSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxAnimals
            // 
            this.lstbxAnimals.FormattingEnabled = true;
            this.lstbxAnimals.ItemHeight = 16;
            this.lstbxAnimals.Location = new System.Drawing.Point(17, 16);
            this.lstbxAnimals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbxAnimals.Name = "lstbxAnimals";
            this.lstbxAnimals.Size = new System.Drawing.Size(288, 516);
            this.lstbxAnimals.TabIndex = 0;
            // 
            // grpbxAddAnimal
            // 
            this.grpbxAddAnimal.Controls.Add(this.btnOrder);
            this.grpbxAddAnimal.Controls.Add(this.nmrcTotal);
            this.grpbxAddAnimal.Controls.Add(this.btnAddAnimal);
            this.grpbxAddAnimal.Controls.Add(this.btnRemove);
            this.grpbxAddAnimal.Controls.Add(this.grpbxEater);
            this.grpbxAddAnimal.Controls.Add(this.grpbxAnimalSize);
            this.grpbxAddAnimal.Location = new System.Drawing.Point(316, 16);
            this.grpbxAddAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAddAnimal.Name = "grpbxAddAnimal";
            this.grpbxAddAnimal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAddAnimal.Size = new System.Drawing.Size(267, 517);
            this.grpbxAddAnimal.TabIndex = 1;
            this.grpbxAddAnimal.TabStop = false;
            this.grpbxAddAnimal.Text = "Nieuw Dier Toevoegen";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(9, 373);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(250, 28);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Beste wagon combinatie";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // nmrcTotal
            // 
            this.nmrcTotal.Location = new System.Drawing.Point(0, 283);
            this.nmrcTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcTotal.Name = "nmrcTotal";
            this.nmrcTotal.Size = new System.Drawing.Size(259, 22);
            this.nmrcTotal.TabIndex = 8;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(8, 336);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(123, 28);
            this.btnAddAnimal.TabIndex = 7;
            this.btnAddAnimal.Text = "Voeg Toe";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(136, 336);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 28);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpbxEater
            // 
            this.grpbxEater.Controls.Add(this.rdbtnHerbivore);
            this.grpbxEater.Controls.Add(this.rdbtnMeatEater);
            this.grpbxEater.Location = new System.Drawing.Point(9, 151);
            this.grpbxEater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxEater.Name = "grpbxEater";
            this.grpbxEater.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxEater.Size = new System.Drawing.Size(249, 123);
            this.grpbxEater.TabIndex = 4;
            this.grpbxEater.TabStop = false;
            this.grpbxEater.Text = "....-eter";
            // 
            // rdbtnHerbivore
            // 
            this.rdbtnHerbivore.AutoSize = true;
            this.rdbtnHerbivore.Location = new System.Drawing.Point(7, 54);
            this.rdbtnHerbivore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnHerbivore.Name = "rdbtnHerbivore";
            this.rdbtnHerbivore.Size = new System.Drawing.Size(102, 21);
            this.rdbtnHerbivore.TabIndex = 7;
            this.rdbtnHerbivore.TabStop = true;
            this.rdbtnHerbivore.Text = "Planteneter";
            this.rdbtnHerbivore.UseVisualStyleBackColor = true;
            // 
            // rdbtnMeatEater
            // 
            this.rdbtnMeatEater.AutoSize = true;
            this.rdbtnMeatEater.Location = new System.Drawing.Point(7, 23);
            this.rdbtnMeatEater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnMeatEater.Name = "rdbtnMeatEater";
            this.rdbtnMeatEater.Size = new System.Drawing.Size(89, 21);
            this.rdbtnMeatEater.TabIndex = 6;
            this.rdbtnMeatEater.TabStop = true;
            this.rdbtnMeatEater.Text = "Vleeseter";
            this.rdbtnMeatEater.UseVisualStyleBackColor = true;
            // 
            // grpbxAnimalSize
            // 
            this.grpbxAnimalSize.Controls.Add(this.rdbtnLarge);
            this.grpbxAnimalSize.Controls.Add(this.rdbtnMedium);
            this.grpbxAnimalSize.Controls.Add(this.rdbtnSmall);
            this.grpbxAnimalSize.Location = new System.Drawing.Point(8, 23);
            this.grpbxAnimalSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAnimalSize.Name = "grpbxAnimalSize";
            this.grpbxAnimalSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAnimalSize.Size = new System.Drawing.Size(251, 119);
            this.grpbxAnimalSize.TabIndex = 3;
            this.grpbxAnimalSize.TabStop = false;
            this.grpbxAnimalSize.Text = "Diergrootte";
            // 
            // rdbtnLarge
            // 
            this.rdbtnLarge.AutoSize = true;
            this.rdbtnLarge.Location = new System.Drawing.Point(8, 85);
            this.rdbtnLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnLarge.Name = "rdbtnLarge";
            this.rdbtnLarge.Size = new System.Drawing.Size(65, 21);
            this.rdbtnLarge.TabIndex = 5;
            this.rdbtnLarge.TabStop = true;
            this.rdbtnLarge.Text = "Groot";
            this.rdbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rdbtnMedium
            // 
            this.rdbtnMedium.AutoSize = true;
            this.rdbtnMedium.Location = new System.Drawing.Point(8, 54);
            this.rdbtnMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnMedium.Name = "rdbtnMedium";
            this.rdbtnMedium.Size = new System.Drawing.Size(97, 21);
            this.rdbtnMedium.TabIndex = 4;
            this.rdbtnMedium.TabStop = true;
            this.rdbtnMedium.Text = "Gemiddeld";
            this.rdbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdbtnSmall
            // 
            this.rdbtnSmall.AutoSize = true;
            this.rdbtnSmall.Location = new System.Drawing.Point(8, 23);
            this.rdbtnSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnSmall.Name = "rdbtnSmall";
            this.rdbtnSmall.Size = new System.Drawing.Size(60, 21);
            this.rdbtnSmall.TabIndex = 3;
            this.rdbtnSmall.TabStop = true;
            this.rdbtnSmall.Text = "Klein";
            this.rdbtnSmall.UseVisualStyleBackColor = true;
            // 
            // lstvwAnimalPairs
            // 
            this.lstvwAnimalPairs.HideSelection = false;
            this.lstvwAnimalPairs.Location = new System.Drawing.Point(592, 16);
            this.lstvwAnimalPairs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstvwAnimalPairs.Name = "lstvwAnimalPairs";
            this.lstvwAnimalPairs.Size = new System.Drawing.Size(292, 507);
            this.lstvwAnimalPairs.TabIndex = 2;
            this.lstvwAnimalPairs.UseCompatibleStateImageBehavior = false;
            // 
            // CircustreinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 554);
            this.Controls.Add(this.lstvwAnimalPairs);
            this.Controls.Add(this.grpbxAddAnimal);
            this.Controls.Add(this.lstbxAnimals);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CircustreinForm";
            this.Text = "Circustrein";
            this.grpbxAddAnimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcTotal)).EndInit();
            this.grpbxEater.ResumeLayout(false);
            this.grpbxEater.PerformLayout();
            this.grpbxAnimalSize.ResumeLayout(false);
            this.grpbxAnimalSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxAnimals;
        private System.Windows.Forms.GroupBox grpbxAddAnimal;
        private System.Windows.Forms.GroupBox grpbxEater;
        private System.Windows.Forms.RadioButton rdbtnHerbivore;
        private System.Windows.Forms.RadioButton rdbtnMeatEater;
        private System.Windows.Forms.GroupBox grpbxAnimalSize;
        private System.Windows.Forms.RadioButton rdbtnLarge;
        private System.Windows.Forms.RadioButton rdbtnMedium;
        private System.Windows.Forms.RadioButton rdbtnSmall;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown nmrcTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListView lstvwAnimalPairs;
    }
}

