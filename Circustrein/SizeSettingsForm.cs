using System;
using System.Windows.Forms;
using Circustrein.Enums;
using Circustrein.Models;

namespace Circustrein
{
    public partial class SizeSettingsForm : Form
    {
        public SizeSettingsForm()
        {
            InitializeComponent();
            nmrcWagonSize.Value = Wagon.GetMaxPoints();
            nmrcSmallAnimalSize.Value = (int)AnimalSize.Small;
            nmrcMediumAnimalSize.Value = (int)AnimalSize.Medium;
            nmrcLargeAnimalSize.Value = (int)AnimalSize.Large;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Wagon.SetMaxPoints(decimal.ToInt32(nmrcWagonSize.Value));
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
