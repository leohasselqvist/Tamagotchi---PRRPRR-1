# Tamagotchi
Detta är koden för Tamagotchi projektet
Du kan ladda ner projektet genom den gröna "Clone" knappen där uppe sedan "Download as zip"

Om du vill bara ha koden för Form.CS finns den är

```csharp
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
        int food = 100;
        int happiness = 100;
        int energy = 100;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Interval = 1000;
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
            food -= 2;
            happiness -= 1;
        }


        private void die()
        {
            HungerLabel.Text = "";
            HappyLabel.Text = "YOU DIED GAME OVER";
            EnergyLabel.Text = "";
            FeedButton.Enabled = false;
            PlayButton.Enabled = false;
            SleepButton.Enabled = false;
            timer2.Stop();
        }
    }
}
```

Kör på!