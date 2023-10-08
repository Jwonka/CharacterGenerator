//Author: Josh Werlein
//Purpose: Create a character generator application
//Date: 09/12/2023

using System.Runtime.Intrinsics.X86;

namespace CharacterGenerator
{
    public partial class CharacterGeneratorForm : Form
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }

        private List<int> statsList = new List<int>();
        private Random numberGenRandom = new Random();
        private void generateButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string name;
            string race;
            int age;
            decimal height;
            decimal weight;
            bool isAge;
            bool isHeight;
            bool isWeight;
            string output;

            //Validate Inputs and Assign Variables
            name = this.nameTextBox.Text;
            race = this.raceComboBox.Text;
            isAge = int.TryParse(this.ageTextBox.Text, out age);
            isHeight = decimal.TryParse(this.heightTextBox.Text, out height);
            isWeight = decimal.TryParse(this.weightTextBox.Text, out weight);

            if ((name ?? "") == (string.Empty ?? ""))
            {
                MessageBox.Show("Name must be filled in.");
                this.nameTextBox.Focus();
                return;
            }
            else if ((race ?? "") == (string.Empty ?? ""))
            {
                MessageBox.Show("Race must be filled in.");
                this.raceComboBox.Focus();
                return;
            }
            else if (isAge == false)
            {
                MessageBox.Show("Age must be numeric.");
                this.ageTextBox.Focus();
                return;
            }
            else if (isHeight == false)
            {
                MessageBox.Show("Height must be numeric.");
                this.heightTextBox.Focus();
                return;
            }
            else if (isWeight == false)
            {
                MessageBox.Show("Weight must be numeric.");
                this.weightTextBox.Focus();
                return;
            }
            else if (statsList.Count == 0)
            {
                MessageBox.Show("Stats must be generated.");
                this.rollButton.Focus();
                return;
            }
            else
            {
                output = "Congratulation, " + name + " the " + race + " has appeared into the world. This individual is " +
                    age.ToString() + " years old, weighing " + weight.ToString() + "lbs, with a height of " + height.ToString() +
                    " inches and stats of: " + Environment.NewLine + "STR=" + statsList[0].ToString() + ",INT=" + statsList[1].ToString() +
                    ",WIS=" + statsList[2].ToString() + ",DEX=" + statsList[3].ToString() + ",CON=" + statsList[4].ToString() + ",CHA=" +
                    statsList[5].ToString();

                this.outputLabel.Text = output;
            }
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            // Create two List of prefix and suffix parts of name
            var namePrefixList = new List<string>();
            var nameSuffixList = new List<string>();

            //Create Variables
            string name;

            //Create Random Numbers
            var numberPrefixRandom = new Random();
            var numberSuffixRandom = new Random();

            //Populate Name Prefix List.
            namePrefixList.Add("Ru");
            namePrefixList.Add("Al");
            namePrefixList.Add("Cu");
            namePrefixList.Add("Gar");
            namePrefixList.Add("Arun");
            namePrefixList.Add("Mal");
            namePrefixList.Add("Val");
            namePrefixList.Add("Yir");
            namePrefixList.Add("Dru");
            namePrefixList.Add("Bar");
            namePrefixList.Add("Rin");
            namePrefixList.Add("Mir");
            namePrefixList.Add("Rel");
            namePrefixList.Add("Rul");
            namePrefixList.Add("Ril");
            namePrefixList.Add("Nir");
            namePrefixList.Add("Grel");
            namePrefixList.Add("Ind");

            // Populate Name Suffix List.
            nameSuffixList.Add("del");
            nameSuffixList.Add("dor");
            nameSuffixList.Add("din");
            nameSuffixList.Add("arn");
            nameSuffixList.Add("fir");
            nameSuffixList.Add("vir");
            nameSuffixList.Add("mir");
            nameSuffixList.Add("el");
            nameSuffixList.Add("tir");
            nameSuffixList.Add("los");
            nameSuffixList.Add("os");
            nameSuffixList.Add("on");
            nameSuffixList.Add("lon");
            nameSuffixList.Add("den");
            nameSuffixList.Add("ven");
            nameSuffixList.Add("vol");
            nameSuffixList.Add("or");
            nameSuffixList.Add("grim");
            nameSuffixList.Add("ul");
            nameSuffixList.Add("uz");

            //Generate Name
            name = namePrefixList[numberPrefixRandom.Next(namePrefixList.Count - 1)].ToString() + nameSuffixList[numberSuffixRandom.Next(nameSuffixList.Count)].ToString();

            //Output Name
            this.nameTextBox.Text = name;
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //Select Race
            string race = this.raceComboBox.SelectedItem.ToString();

            // Clear statsList
            statsList.Clear();
            for (int count = 1; count <= 6; count++)
            {
                statsList.Add(rollDice(6, 4, true));
            }
            if (race == "Elf")
            {
                //Elves get bonus INT and DEX
                statsList[1] = statsList[1] + 2;
                statsList[3] = statsList[3] + 2;
            }
            else if (race == "Dwarf")
            {
                //Drawfs get bonus STR, CON, CHA -1
                statsList[0] = statsList[0] + 1;
                statsList[4] = statsList[4] + 1;
                statsList[5] = statsList[5] - 2;
            }
            else if (race == "Gnome")
            {
                // Gnomes get bonus INT, WIS, STR -2
                statsList[1] = statsList[1] + 1;
                statsList[2] = statsList[2] + 2;
                statsList[0] = statsList[0] - 2;
            }
            displayStats();
        }


        private int rollDice(int sides, int number, bool dropLow)
        {
            var dieRollsList = new List<int>();

            for (int counter = 1, loopTo = number; counter <= loopTo; counter++)
            {
                dieRollsList.Add(numberGenRandom.Next(1, sides + 1));
            }
            if (dropLow)
            {
                //Add up all die rolls except the lowest
                int minValue = dieRollsList.Min();
                dieRollsList.Remove(minValue);
                return dieRollsList.Sum();
            }
            else
            {
                return dieRollsList.Sum();
            }
        }

        private void CharacterGeneratorform_Load(object sender, EventArgs e)
        {
            //Add Races to the comboBox on Load
            this.raceComboBox.Items.Add("Human");
            this.raceComboBox.Items.Add("Elf");
            this.raceComboBox.Items.Add("Dwarf");
            this.raceComboBox.Items.Add("Gnome");

            //Select the first Race to show in the comboBox
            this.raceComboBox.SelectedIndex = 0;
        }

        private void displayStats()
        {
            strLabel.Text = statsList[0].ToString();
            intLabel.Text = statsList[1].ToString();
            wisLabel.Text = statsList[2].ToString();
            dexLabel.Text = statsList[3].ToString();
            conLabel.Text = statsList[4].ToString();
            chaLabel.Text = statsList[5].ToString();
        }
    }
}