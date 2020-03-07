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
            this.btnWagonCombination = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbxAddAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcTotal)).BeginInit();
            this.grpbxEater.SuspendLayout();
            this.grpbxAnimalSize.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxAnimals
            // 
            this.lstbxAnimals.FormattingEnabled = true;
            this.lstbxAnimals.ItemHeight = 16;
            this.lstbxAnimals.Location = new System.Drawing.Point(13, 32);
            this.lstbxAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxAnimals.Name = "lstbxAnimals";
            this.lstbxAnimals.Size = new System.Drawing.Size(288, 516);
            this.lstbxAnimals.TabIndex = 0;
            // 
            // grpbxAddAnimal
            // 
            this.grpbxAddAnimal.Controls.Add(this.btnWagonCombination);
            this.grpbxAddAnimal.Controls.Add(this.nmrcTotal);
            this.grpbxAddAnimal.Controls.Add(this.btnAddAnimal);
            this.grpbxAddAnimal.Controls.Add(this.btnRemove);
            this.grpbxAddAnimal.Controls.Add(this.grpbxEater);
            this.grpbxAddAnimal.Controls.Add(this.grpbxAnimalSize);
            this.grpbxAddAnimal.Location = new System.Drawing.Point(316, 32);
            this.grpbxAddAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxAddAnimal.Name = "grpbxAddAnimal";
            this.grpbxAddAnimal.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxAddAnimal.Size = new System.Drawing.Size(267, 517);
            this.grpbxAddAnimal.TabIndex = 1;
            this.grpbxAddAnimal.TabStop = false;
            this.grpbxAddAnimal.Text = "Nieuw Dier Toevoegen";
            // 
            // btnWagonCombination
            // 
            this.btnWagonCombination.Location = new System.Drawing.Point(9, 373);
            this.btnWagonCombination.Margin = new System.Windows.Forms.Padding(4);
            this.btnWagonCombination.Name = "btnWagonCombination";
            this.btnWagonCombination.Size = new System.Drawing.Size(251, 28);
            this.btnWagonCombination.TabIndex = 9;
            this.btnWagonCombination.Text = "Beste wagon combinatie";
            this.btnWagonCombination.UseVisualStyleBackColor = true;
            this.btnWagonCombination.Click += new System.EventHandler(this.btnWagonCombination_Click);
            // 
            // nmrcTotal
            // 
            this.nmrcTotal.Location = new System.Drawing.Point(0, 283);
            this.nmrcTotal.Margin = new System.Windows.Forms.Padding(4);
            this.nmrcTotal.Name = "nmrcTotal";
            this.nmrcTotal.Size = new System.Drawing.Size(259, 22);
            this.nmrcTotal.TabIndex = 8;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(8, 336);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
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
            this.grpbxEater.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxEater.Name = "grpbxEater";
            this.grpbxEater.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxEater.Size = new System.Drawing.Size(249, 123);
            this.grpbxEater.TabIndex = 4;
            this.grpbxEater.TabStop = false;
            this.grpbxEater.Text = "Eter";
            // 
            // rdbtnHerbivore
            // 
            this.rdbtnHerbivore.AutoSize = true;
            this.rdbtnHerbivore.Location = new System.Drawing.Point(7, 54);
            this.rdbtnHerbivore.Margin = new System.Windows.Forms.Padding(4);
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
            this.rdbtnMeatEater.Margin = new System.Windows.Forms.Padding(4);
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
            this.grpbxAnimalSize.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxAnimalSize.Name = "grpbxAnimalSize";
            this.grpbxAnimalSize.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxAnimalSize.Size = new System.Drawing.Size(251, 119);
            this.grpbxAnimalSize.TabIndex = 3;
            this.grpbxAnimalSize.TabStop = false;
            this.grpbxAnimalSize.Text = "Diergrootte";
            // 
            // rdbtnLarge
            // 
            this.rdbtnLarge.AutoSize = true;
            this.rdbtnLarge.Location = new System.Drawing.Point(8, 85);
            this.rdbtnLarge.Margin = new System.Windows.Forms.Padding(4);
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
            this.rdbtnMedium.Margin = new System.Windows.Forms.Padding(4);
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
            this.rdbtnSmall.Margin = new System.Windows.Forms.Padding(4);
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
            this.lstvwAnimalPairs.Location = new System.Drawing.Point(591, 32);
            this.lstvwAnimalPairs.Margin = new System.Windows.Forms.Padding(4);
            this.lstvwAnimalPairs.Name = "lstvwAnimalPairs";
            this.lstvwAnimalPairs.Size = new System.Drawing.Size(292, 516);
            this.lstvwAnimalPairs.TabIndex = 2;
            this.lstvwAnimalPairs.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAnimalsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearAnimalsToolStripMenuItem
            // 
            this.clearAnimalsToolStripMenuItem.Name = "clearAnimalsToolStripMenuItem";
            this.clearAnimalsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.clearAnimalsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.clearAnimalsToolStripMenuItem.Text = "Clear animals";
            this.clearAnimalsToolStripMenuItem.Click += new System.EventHandler(this.clearAnimalsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeSizeToolStripMenuItem
            // 
            this.changeSizeToolStripMenuItem.Name = "changeSizeToolStripMenuItem";
            this.changeSizeToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.changeSizeToolStripMenuItem.Text = "Change settings";
            this.changeSizeToolStripMenuItem.Click += new System.EventHandler(this.changeWagonSizeToolStripMenuItem_Click);
            // 
            // CircustreinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 562);
            this.Controls.Add(this.lstvwAnimalPairs);
            this.Controls.Add(this.grpbxAddAnimal);
            this.Controls.Add(this.lstbxAnimals);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CircustreinForm";
            this.Text = "Circustrein";
            this.grpbxAddAnimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcTotal)).EndInit();
            this.grpbxEater.ResumeLayout(false);
            this.grpbxEater.PerformLayout();
            this.grpbxAnimalSize.ResumeLayout(false);
            this.grpbxAnimalSize.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnWagonCombination;
        private System.Windows.Forms.ListView lstvwAnimalPairs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

