using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luckyNumber
{
    public partial class Form1 : Form
    {
        public  static int luckyNumberText;
        public  static string title;
        public  static string favoriteColor;

        public Form1()
        {
            InitializeComponent();
            title = "Your  Result!";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool updateColor(string  color)
        {
            string[] colors = {"RED", "BLUE", "BLACK","YELLOW","GREEN","WHITE"};

            for (int temp = 0; temp < colors.Length; temp++)
            {
                if(colors[temp] == color)
                {
                    return true;
                }
              
            }
            return false;
        }

        public  void run(string color,Form form)
        {
            if (updateColor(color.ToUpper()) !=  true)
            {

                MessageBox.Show("I can't determined  your color. Please select from  the list of colors");
            }

            if (updateColor(color.ToUpper()) == true && color == "red".ToUpper())
            {
              
                form.BackColor = System.Drawing.Color.Red;
            }

            if (updateColor(color.ToUpper()) == true && color == "white".ToUpper())
            {
                MessageBox.Show("White is not allowed");

            }
            if (updateColor(color.ToUpper()) == true && color == "blue".ToUpper())
            {
                form.BackColor = System.Drawing.Color.Blue;
            }

            if (updateColor(color.ToUpper()) == true && color == "green".ToUpper())
            {
                form.BackColor = System.Drawing.Color.Green;
            }

            if (updateColor(color.ToUpper()) == true && color == "yellow".ToUpper())
            {
                form.BackColor = System.Drawing.Color.Yellow;
            }

            if (updateColor(color.ToUpper()) == true && color == "black".ToUpper())
            {
                form.BackColor = System.Drawing.Color.Black;
            }
        }
        // calculate  color.
        public  void  calculate(int birthYear,  int   birthMonth, string  color){

            try
            {
                Console.WriteLine("Birth month " + birthMonth);

                Form3 form = new Form3();

                if (birthMonth > 0 && birthYear > 0 && birthYear < 1960)
                {

                    Random random = new Random();

                    int luckyNumber = birthMonth * random.Next(16);

                    form.Show();

                    luckyNumberText = luckyNumber;
                    favoriteColor = color;

                    form.active();

                    run(color, form);
                    //MessageBox.Show("You  lucky  number is an  " + luckyNumber + "and fovorite color is " + color);

                }

                if (birthMonth > 0 && birthYear > 0 && birthYear >= 1960 && birthYear < 1970)
                {

                    Random random = new Random();
                    int luckyNumber = birthMonth * random.Next(16);

                    form.Show();

                    luckyNumberText = luckyNumber;

                    favoriteColor = color;
                    form.active();

                    run(color, form);

                    //MessageBox.Show("You  lucky  number is  " + luckyNumber + " and favorite color is " + color);
                }

                if (birthMonth > 0 && birthYear > 0 && birthYear >= 1970 && birthYear < 1980)
                {

                    Random random = new Random();
                    int luckyNumber = birthMonth * random.Next(16);

                    luckyNumberText = luckyNumber;


                    form.Show();

                    favoriteColor = color;
                    form.active();
                    run(color, form);

                    //MessageBox.Show("You  lucky  number is  " + luckyNumber + " and favorite color is " + color);
                }

                if (birthMonth > 0 && birthYear > 0 && birthYear >= 1980 && birthYear < 2000)
                {

                    Random random = new Random();
                    int luckyNumber = birthMonth * random.Next(16);

                    luckyNumberText = luckyNumber;

                    form.Show();

                    favoriteColor = color;
                    form.active();
                    run(color, form);

                    //MessageBox.Show("You  lucky  number is  " + luckyNumber + " and favorite color is " + color);
                }

                if (birthMonth > 0 && birthYear > 0 && birthYear >= 2000 && birthYear < 2010)
                {
                    Random random = new Random();
                    int luckyNumber = birthMonth * random.Next(16);

                    form.BackColor = System.Drawing.Color.Black;


                    favoriteColor = "";

                    luckyNumberText = luckyNumber;


                    form.Show();

                    favoriteColor = color;

                    form.active();

                    run(color, form);

                    //MessageBox.Show("You  lucky  number is  " + luckyNumber + " and favorite color is " + color);
                }

                if (birthMonth > 0 && birthYear > 0 && birthYear >= 2010 && birthYear < 2010)
                {
                    Random random = new Random();
                    int luckyNumber = birthMonth * random.Next(16);

                    form.BackColor = System.Drawing.Color.Black;

                    form.Show();

                    luckyNumberText = luckyNumber;

                    favoriteColor = color;

                    form.active();

                    run(color, form);

                    //MessageBox.Show("You  lucky  number is  " + luckyNumber + " and favorite color is " + color);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("There is a  problem  please call for help");
            }
        }
        private  bool UserPassword(string  name, string Password)
        {
            string username = "pass";
            string password = "pass";

            bool istrue = false; 

            if (name ==  username &&  Password ==  password)
            {
                istrue = true;
            }
            return istrue; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int temp = 0;

            string name = textBox1.Text;
            string password = textBox2.Text;

            bool isNumericBirthYear = int.TryParse(comboBox1.Text, out temp);
            string birthYear = comboBox1.Text;

            bool isNumericBirthMonth = int.TryParse(comboBox2.Text, out temp);
            string birthMonth = comboBox2.Text;

            bool isNumericBirthDay = int.TryParse(comboBox3.Text, out temp);
            string birthDay =  comboBox3.Text;

            string favoriteColor = comboBox4.Text;

            if (!String.IsNullOrEmpty(birthYear) && !String.IsNullOrEmpty(birthMonth) && !String.IsNullOrEmpty(birthDay) && !String.IsNullOrEmpty(favoriteColor) && !String.IsNullOrEmpty(favoriteColor))
            {

                if (name != "" && password != ""  && UserPassword(name, password) == true) {

                    if (isNumericBirthYear && isNumericBirthMonth && isNumericBirthMonth && Int32.Parse(birthMonth) > 0 && Int32.Parse(birthMonth) < 13 && Int32.Parse(birthDay) < 32)
                    {
                        calculate(Int32.Parse(birthYear), Int32.Parse(birthMonth), favoriteColor.ToUpper());
                    }
                    else
                    {
                        MessageBox.Show("Check your inputs for miss  match or month and  day  are  out of  range ");
                    }
                }
                else
                {
                      MessageBox.Show("please enter  a   user  name and  password to continue ");
                }
            }
            else
            {
                MessageBox.Show("Please make sure  all  field  have inputs");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
