using System;
using System.Windows.Forms;
using Circustrein.Enums;

namespace Circustrein
{
    public partial class CircustreinForm : Form
    {
        public CircustreinForm()
        {
            InitializeComponent();
            lstbxAnimals.DisplayMember = "Name";
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            addNewAnimal();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //remove selected animal
        }

        private void addNewAnimal()
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

            if (rdbtnHerbivore.Checked) eater = AnimalEater.herbivore;
            else if (rdbtnMeatEater.Checked) eater = AnimalEater.meatEater;
            else
            {
                MessageBox.Show("Vink wat het dier eet aan.");
                return;
            }

            for (int i = 0; i < total; i++)
            {
                //add animal
            }

        }
    }
}
