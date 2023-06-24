using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{


        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            string ChosenWord = AnimalWords();
            Form2 Wordle = new Form2();
            Wordle.Text = "Wordle Game";
            Wordle.word = ChosenWord.ToUpper();
            Wordle.guesses = 6;
            this.Hide();
            Wordle.Closed += (s, args) => this.Close();
            Wordle.Show();

        }


        private void btnFood_Click(object sender, EventArgs e)
        {
            string ChosenWord = FoodWords();
            Form2 Wordle = new Form2();
            Wordle.Text = "Wordle Game";
            Wordle.word = ChosenWord.ToUpper();
            Wordle.guesses = 6;
            this.Hide();
            Wordle.Closed += (s, args) => this.Close();
            Wordle.Show();

        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            string ChosenWord = PlaceWords();
            Form2 Wordle = new Form2();
            Wordle.Text = "Wordle Game";
            Wordle.word = ChosenWord.ToUpper();
            Wordle.guesses = 6;
            this.Hide();
            Wordle.Closed += (s, args) => this.Close();
            Wordle.Show();


        }

        private void btnVerbs_Click(object sender, EventArgs e)
        {
            string ChosenWord = VerbWords();
            Form2 Wordle = new Form2();
            Wordle.Text = "Wordle Game";
            Wordle.word = ChosenWord.ToUpper();
            Wordle.guesses = 6;
            this.Hide();
            Wordle.Closed += (s, args) => this.Close();
            Wordle.Show();



        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            string ChosenWord = AllWords();
            Form2 Wordle = new Form2();
            Wordle.Text = "Wordle Game";
            Wordle.word = ChosenWord.ToUpper();
            Wordle.guesses = 6;
            this.Hide();
            Wordle.Closed += (s, args) => this.Close();
            Wordle.Show();

        }

        public string AnimalWords()
        {

            string[] words = { "tiger", "horse", "whale", "zebra", "mouse", "moose", "camel", "koala", "sheep", "hyena", "rhino", "otter", "bison", "panda", "llama", "lemur", "skunk", "sloth", "shrew", "stoat" };

            Random random = new Random();
            string word = words[random.Next(words.Length)];
            return word;
        }

        public string FoodWords()
        {

            string[] words = { "apple", "bacon", "honey", "kebab", "pizza", "sushi", "pasta", "bagel", "salsa", "gravy" };

            Random random = new Random();
            string word = words[random.Next(words.Length)];
            return word;
        }

        public string PlaceWords()
        {

            string[] words = { "chile", "china", "egypt", "haiti", "india", "italy", "japan", "kenya", "libya", "malta", "nepal", "sudan", "samoa", "spain", "syria", "yemen" };
            Random random = new Random();
            string word = words[random.Next(words.Length)];
            return word;
        }

        public string VerbWords()
        {

            string[] words = { "admit", "adopt", "agree", "allow", "alter", "apply", "argue", "arise", "avoid", "begin", "blame", "break", "bring", "build", "burst", "carry", "catch", "cause", "check", "claim", "clean", "clear", "climb", "close", "count", "cover", "cross", "dance", "doubt", "drink", "drive", "enjoy", "enter", "exist", "fight", "focus", "force", "guess", "imply", "issue", "judge", "laugh", "learn", "leave", "limit", "marry", "match", "occur", "offer", "order", "phone", "place", "point", "press", "prove", "paise", "reach", "refer", "relax", "serve", "shall", "throw", "visit", "watch" };

            Random random = new Random();
            string word = words[random.Next(words.Length)];
            return word;

        }

        public string AllWords()
        {

            string[] words = { "tiger", "horse", "whale", "zebra", "mouse", "moose", "camel", "koala", "sheep", "hyena", "rhino", "otter", "bison", "panda", "llama", "lemur", "skunk", "sloth", "shrew", "stoat", "apple", "bacon", "honey", "kebab", "pizza", "sushi", "pasta", "bagel", "salsa", "gravy", "chile", "china", "egypt", "haiti", "india", "italy", "japan", "kenya", "libya", "malta", "nepal", "sudan", "samoa", "spain", "syria", "yemen", "admit", "adopt", "agree", "allow", "alter", "apply", "argue", "arise", "avoid", "begin", "blame", "break", "bring", "build", "burst", "carry", "catch", "cause", "check", "claim", "clean", "clear", "climb", "close", "count", "cover", "cross", "dance", "doubt", "drink", "drive", "enjoy", "enter", "exist", "fight", "focus", "force", "guess", "imply", "issue", "judge", "laugh", "learn", "leave", "limit", "marry", "match", "occur", "offer", "order", "phone", "place", "point", "press", "prove", "paise", "reach", "refer", "relax", "serve", "shall", "throw", "visit", "watch" };

            Random random = new Random();
            string word = words[random.Next(words.Length)];
            return word;
        }
    }
}
