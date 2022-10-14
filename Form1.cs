namespace Activity8App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateFatButton1_Click(object sender, EventArgs e)
        {
            //calls fatCalories method, converts fatInGramsInputTextBox1 to integer, and assigns the result to caloriesFromFatLabel3.Text
            caloriesFromFatLabel3.Text = "Calories from Fat : " + fatCalories(int.Parse(fatInGramsInputTextBox1.Text));


        }

        private void calculateCarbsButton2_Click(object sender, EventArgs e)
        {
            //calls carbCalories method, converts carbohydratesInGramsInputTextBox2 to integer, and assigns the result to caloriesFromCarbsLabel4.Text
            caloriesFromCarbsLabel4.Text = "Calories from Carbs : " + carbCalories(int.Parse(carbohydratesInGramsInputTextBox2.Text));


        }
        //method to calculate calories from fat
        public static int fatCalories(int fatOfMembers)
        {
            return fatOfMembers * 9;//return calories from fat
        }
        //method to calculate calories from carbs
        public static int carbCalories(int carbsOfMembers)
        {
            return carbsOfMembers * 4;//return calories from carbs
        }
    }
}