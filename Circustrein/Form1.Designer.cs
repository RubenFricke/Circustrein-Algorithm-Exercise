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
            this.lstbxAnimals.Location = new System.Drawing.Point(13, 13);
            this.lstbxAnimals.Name = "lstbxAnimals";
            this.lstbxAnimals.Size = new System.Drawing.Size(217, 420);
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
            this.grpbxAddAnimal.Location = new System.Drawing.Point(237, 13);
            this.grpbxAddAnimal.Name = "grpbxAddAnimal";
            this.grpbxAddAnimal.Size = new System.Drawing.Size(200, 420);
            this.grpbxAddAnimal.TabIndex = 1;
            this.grpbxAddAnimal.TabStop = false;
            this.grpbxAddAnimal.Text = "Nieuw Dier Toevoegen";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(7, 303);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(188, 23);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Beste wagon combinatie";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // nmrcTotal
            // 
            this.nmrcTotal.Location = new System.Drawing.Point(0, 230);
            this.nmrcTotal.Name = "nmrcTotal";
            this.nmrcTotal.Size = new System.Drawing.Size(194, 20);
            this.nmrcTotal.TabIndex = 8;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(6, 273);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(92, 23);
            this.btnAddAnimal.TabIndex = 7;
            this.btnAddAnimal.Text = "Voeg Toe";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(102, 273);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpbxEater
            // 
            this.grpbxEater.Controls.Add(this.rdbtnHerbivore);
            this.grpbxEater.Controls.Add(this.rdbtnMeatEater);
            this.grpbxEater.Location = new System.Drawing.Point(7, 123);
            this.grpbxEater.Name = "grpbxEater";
            this.grpbxEater.Size = new System.Drawing.Size(187, 100);
            this.grpbxEater.TabIndex = 4;
            this.grpbxEater.TabStop = false;
            this.grpbxEater.Text = "Eter";
            // 
            // rdbtnHerbivore
            // 
            this.rdbtnHerbivore.AutoSize = true;
            this.rdbtnHerbivore.Location = new System.Drawing.Point(5, 44);
            this.rdbtnHerbivore.Name = "rdbtnHerbivore";
            this.rdbtnHerbivore.Size = new System.Drawing.Size(91, 19);
            this.rdbtnHerbivore.TabIndex = 7;
            this.rdbtnHerbivore.TabStop = true;
            this.rdbtnHerbivore.Text = "Planteneter";
            this.rdbtnHerbivore.UseVisualStyleBackColor = true;
            // 
            // rdbtnMeatEater
            // 
            this.rdbtnMeatEater.AutoSize = true;
            this.rdbtnMeatEater.Location = new System.Drawing.Point(5, 19);
            this.rdbtnMeatEater.Name = "rdbtnMeatEater";
            this.rdbtnMeatEater.Size = new System.Drawing.Size(79, 19);
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
            this.grpbxAnimalSize.Location = new System.Drawing.Point(6, 19);
            this.grpbxAnimalSize.Name = "grpbxAnimalSize";
            this.grpbxAnimalSize.Size = new System.Drawing.Size(188, 97);
            this.grpbxAnimalSize.TabIndex = 3;
            this.grpbxAnimalSize.TabStop = false;
            this.grpbxAnimalSize.Text = "Diergrootte";
            // 
            // rdbtnLarge
            // 
            this.rdbtnLarge.AutoSize = true;
            this.rdbtnLarge.Location = new System.Drawing.Point(6, 69);
            this.rdbtnLarge.Name = "rdbtnLarge";
            this.rdbtnLarge.Size = new System.Drawing.Size(58, 19);
            this.rdbtnLarge.TabIndex = 5;
            this.rdbtnLarge.TabStop = true;
            this.rdbtnLarge.Text = "Groot";
            this.rdbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rdbtnMedium
            // 
            this.rdbtnMedium.AutoSize = true;
            this.rdbtnMedium.Location = new System.Drawing.Point(6, 44);
            this.rdbtnMedium.Name = "rdbtnMedium";
            this.rdbtnMedium.Size = new System.Drawing.Size(89, 19);
            this.rdbtnMedium.TabIndex = 4;
            this.rdbtnMedium.TabStop = true;
            this.rdbtnMedium.Text = "Gemiddeld";
            this.rdbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdbtnSmall
            // 
            this.rdbtnSmall.AutoSize = true;
            this.rdbtnSmall.Location = new System.Drawing.Point(6, 19);
            this.rdbtnSmall.Name = "rdbtnSmall";
            this.rdbtnSmall.Size = new System.Drawing.Size(56, 19);
            this.rdbtnSmall.TabIndex = 3;
            this.rdbtnSmall.TabStop = true;
            this.rdbtnSmall.Text = "Klein";
            this.rdbtnSmall.UseVisualStyleBackColor = true;
            // 
            // lstvwAnimalPairs
            // 
            this.lstvwAnimalPairs.HideSelection = false;
            this.lstvwAnimalPairs.Location = new System.Drawing.Point(444, 13);
            this.lstvwAnimalPairs.Name = "lstvwAnimalPairs";
            this.lstvwAnimalPairs.Size = new System.Drawing.Size(220, 413);
            this.lstvwAnimalPairs.TabIndex = 2;
            this.lstvwAnimalPairs.UseCompatibleStateImageBehavior = false;
            // 
            // CircustreinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.lstvwAnimalPairs);
            this.Controls.Add(this.grpbxAddAnimal);
            this.Controls.Add(this.lstbxAnimals);
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

