using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Circustrein.Library;
using Circustrein.Library.Enums;
using Circustrein.Library.Models;

namespace Circustrein
{
    public partial class CircustreinForm : Form
    {
        private CircusTrainFiller filler;
        private List<Animal> animals;

        public CircustreinForm()
        {
            animals = new List<Animal>();
            filler = new CircusTrainFiller();
            InitializeComponent();
            lstbxAnimals.DisplayMember = "Name";
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddNewAnimal();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            animals.Remove((Animal)lstbxAnimals.SelectedItem);
            UpdateAnimalList();
        }

        private void UpdateAnimalList()
        {
            lstbxAnimals.Items.Clear();
            animals
                .ToList()
                .ForEach(x => lstbxAnimals.Items.Add(x));
        }

        private void AddNewAnimal()
        {
            AnimalSize size;
            AnimalEater eater;
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

            for (int i = 0; i < nmrcTotal.Value; i++)
            {
                animals.Add(new Animal(size, eater));
            }
            UpdateAnimalList();
        }

        private void btnWagonCombination_Click(object sender, EventArgs e)
        {
            lstvwAnimalPairs.Clear();
            var wagons = filler.SortAnimalsInWagons(animals);
            if (wagons.Count > 0)
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    ListViewGroup lstvwgrp = new ListViewGroup($"Wagon {i}", HorizontalAlignment.Left);
                    wagons[i].GetAnimals().ToList().ForEach(animal =>
                        lstvwAnimalPairs.Items.Add(new ListViewItem(animal.Name, lstvwgrp)));

                    lstvwAnimalPairs.Groups.Add(lstvwgrp);
                }
            }
            else MessageBox.Show("Voeg eerst dieren toe voordat de optimale combinatie berekend kan worden.");
        }

        private void clearAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animals.Count > 0)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Weet je het zeker dat je alle ingevoerde dieren wilt verwijderen?", "Alle dieren verwijderen",
                        MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    animals.Clear();
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
            var output = JsonConvert.SerializeObject(animals);
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Json files | .json", DefaultExt = "json", AddExtension = true
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                animals.AddRange((JsonConvert.DeserializeObject<List<Animal>>(json)));
                UpdateAnimalList();
            }
        }
    }
}