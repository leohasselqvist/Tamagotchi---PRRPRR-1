using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Alla knappar kallar varsin funktion

namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        // Deklarera alla 3 stats
        int food = 100;
        int happiness = 100;
        int energy = 100;

        public Form1()
        {
            InitializeComponent();
            // Starta alla timers
            timer1.Start();
            timer2.Interval = 1000; // Gör så att timer2 kör varje sekund istället för varje tick.
            timer2.Start();
        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            // Funktion för att mata
            food += 10;
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            // Funktion för att sova
            food -= 10;
            energy += 10;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Funktion för att leka
            happiness += 10;
            energy -= 10;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (food > 0 && happiness > 0 && energy > 0)
            {
                // Funktion för att uppdatera variablerna
                HungerLabel.Text = "Food : " + food;
                HappyLabel.Text = "Happiness : " + happiness;
                EnergyLabel.Text = "Energy : " + energy;
            }
            else
            {
                // die
                die();
            }
        
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Långsamt döda tamagotchi:n, denna timer:n kör varenda 2 sekunder.
            food -= 2;
            happiness -= 1;
        }


        private void die()
        {
            // Ändra texten till YOU DIED
            HungerLabel.Text = "";
            HappyLabel.Text = "YOU DIED";
            EnergyLabel.Text = "";
            // Gör så att man inte kan trycka knapparna när man är död
            FeedButton.Enabled = false;
            PlayButton.Enabled = false;
            SleepButton.Enabled = false;
            // Stoppa timern som långsamt dödar tamagotchi:n
            timer2.Stop();
        }

        private void EnergyLabel_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            EnergyLabeI.Location = new Point(rand.Next(0, 600), 20);
            EnergyLabeI.ForeColor = Color.Black;
        }
    }
}