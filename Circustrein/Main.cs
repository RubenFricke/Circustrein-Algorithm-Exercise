using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Circustrein.Enums;
using Circustrein.Models;
using Newtonsoft.Json;
namespace Circustrein
{
    public partial class CircustreinForm : Form
    {
        private CircusTrain circusTrein;
        public CircustreinForm()
        {
            circusTrein = new CircusTrain();
            InitializeComponent();
            lstbxAnimals.DisplayMember = "Name";
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddNewAnimal();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            circusTrein.RemoveAnimal((Animal)lstbxAnimals.SelectedItem);
            UpdateAnimalList();
        }

        private void UpdateAnimalList()
        {
            lstbxAnimals.Items.Clear();
            circusTrein.GetAllAnimals()
                .ToList()
                .ForEach(x => lstbxAnimals.Items.Add(x));
        }

        private void AddNewAnimal()
        {
            AnimalSize size;
            AnimalEater eater;
            decimal total = nmrcTotal.Value;
            if (rdbtnSmall.Checked) size = AnimalSize.Small;
            else if (rdbtnMedium.Checked) size = AnimalSize.Medium;
            else if (rdbtnLarge.Checked) size = AnimalSize.Large;
            else
            {
                MessageBox.Show("Vink een diergrootte aan!");
                return;
            }

            if (rdbtnHerbivore.Checked) eater = AnimalEater.Herbivore;
            else if (rdbtnMeatEater.Checked) eater = AnimalEater.MeatEater;
            else
            {
                MessageBox.Show("Vink wat het dier eet aan.");
                return;
            }

            for (int i = 0; i < total; i++)
            {
                //gegevens van het dier nog meegeven voor het object
                circusTrein.AddAnimal(new Animal(size, eater));
            }
            UpdateAnimalList();
        }

        private void btnWagonCombination_Click(object sender, EventArgs e)
        {
            lstvwAnimalPairs.Clear();
            if (circusTrein.GetWagons().Count > 0)
            {
                int total = 0;
                foreach (var wagon in circusTrein.GetWagons())
                {
                    total++;
                    ListViewGroup lstvwgrp = new ListViewGroup("Wagon " + total, HorizontalAlignment.Left);
                    wagon.GetAnimals().ToList().ForEach(animal =>
                        lstvwAnimalPairs.Items.Add(new ListViewItem(animal.Name, lstvwgrp)));

                    lstvwAnimalPairs.Groups.Add(lstvwgrp);
                }
            }
            else MessageBox.Show("Voeg eerst dieren toe voordat de optimale combinatie berekend kan worden.");
        }

        private void clearAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (circusTrein.GetAllAnimals().Count > 0)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Weet je het zeker dat je alle ingevoerde dieren wilt verwijderen?", "Some",
                        MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    circusTrein.ClearAllAnimals();
                    UpdateAnimalList();
                }
            }
        }

        private void changeWagonSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeSettingsForm window = new SizeSettingsForm();
            window.ShowDialog();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var output = JsonConvert.SerializeObject(circusTrein.GetAllAnimals());
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Json files | .txt", DefaultExt = "json", AddExtension = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(output);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string json = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                json = File.ReadAllText(openFileDialog.FileName);
            }

            circusTrein.AddAnimal(JsonConvert.DeserializeObject<List<Animal>>(json));
            UpdateAnimalList();
        }
    }
}