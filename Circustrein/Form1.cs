using System;
using System.Linq;
using System.Windows.Forms;
using Circustrein.Enums;
using Circustrein.Models;

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
    }
}