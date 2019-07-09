using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class FormInput : Form
    {
        public Difficulty Dif { get; set; }
        public FormInput()
        { 
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            switch (CmbDifficulty.SelectedItem)
            {
                case Difficulty.Beginner:
                    Dif = Difficulty.Beginner;
                    break;
                case Difficulty.Easy:
                    Dif = Difficulty.Easy;
                    break;
                case Difficulty.Normal:
                    Dif = Difficulty.Normal;
                    break;
                case Difficulty.Hard:
                    Dif = Difficulty.Hard;
                    break;
                case Difficulty.VeryHard:
                    Dif = Difficulty.VeryHard;
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
            
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            foreach (var dif in ((Difficulty[])Enum.GetValues(typeof(Difficulty))))
            {
                CmbDifficulty.Items.Add(dif);
            }
            CmbDifficulty.SelectedIndex = 0;
        }
    }
}
