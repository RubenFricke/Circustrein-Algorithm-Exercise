using System;
using System.Windows.Forms;
using Circustrein.Library.Enums;
using Circustrein.Library.Models;

namespace Circustrein
{
    public partial class SizeSettingsForm : Form
    {
        public SizeSettingsForm()
        {
            InitializeComponent();
            nmrcWagonSize.Value = Wagon.MaxPoints;
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
