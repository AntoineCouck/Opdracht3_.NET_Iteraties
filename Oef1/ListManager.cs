using System;
using System.Windows.Forms;

namespace Oef1
{
    public partial class ListsManager : Form
    {
        public ListsManager()
        {
            InitializeComponent();
        }

        private bool IsEveritingDigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }


        // de 3 stapels 

        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();
        Stapel<Persoon>personen = new Stapel<Persoon>();



        private void integersToevoegen_Click(object sender, EventArgs e)
        {
            if (IsEveritingDigit(integersInput.Text))
            {
                integers.OpDeStapel(int.Parse(integersInput.Text));

            } else
            {
                MessageBox.Show("enkel integers toegelaten ! ");
                integersInput.Text = null;
            }

            integersInput.Text = null;
        }

        private void verwijderenIntegers_Click(object sender, EventArgs e)
        {
            if(integers.ToString() != string.Empty)
            {
                integers.vanDeStapel();
            } else
            {
                MessageBox.Show(" de stapel is al leeg ! ");
            }
            
        }

        private void LeegmakenIntegers_Click(object sender, EventArgs e)
        {
           
            integers.StapelLeegMaken();
        }

        private void showListIntegers_Click(object sender, EventArgs e)
        {
            label6.Text =  "integers: " +  integers.ToString();
        }

      

        private void CopyListInteger_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + integers.ToString() + "\n new list  de nieuwe lijst is : " + " " +
               String.Join(",", integers.lijstCopy()));

        }

        private void toevoegenStrings_Click(object sender, EventArgs e)
        {
            strings.OpDeStapel(stringsInput.Text);

            stringsInput.Text = null;
        }

        private void SearchInteger_Click(object sender, EventArgs e)
        {
            if (integers.IsAanwezigOpStapel(int.Parse(integersInput.Text)))
            {

                MessageBox.Show(integersInput.Text + " " + "is aanwezig op de stapel van integers");
            }
            else
            {
                MessageBox.Show("sorry maar " + integersInput.Text + " bestaat niet op de stapel");
            }

            integersInput.Text = null;


        }

        private void verwijderenStrings_Click(object sender, EventArgs e)
        {
            if(strings.ToString() != string.Empty)
            {
                strings.vanDeStapel();
            } else
            {
                MessageBox.Show("de stapel is al leeg !");
            }
           
        }

        private void leegmakenStrings_Click(object sender, EventArgs e)
        {
            strings.StapelLeegMaken();
        }

        private void showListStrings_Click(object sender, EventArgs e)
        {
            label8.Text =  "strings : " +  strings.ToString();

        }

        private void SearchStrings_Click(object sender, EventArgs e)
        {
            if (strings.IsAanwezigOpStapel(stringsInput.Text))
            {
                MessageBox.Show(stringsInput.Text + " " + "is aanwezig op de stapel van strings");
            } else
            {
                MessageBox.Show("sorry maar " + stringsInput.Text + " bestaat niet op de stapel");
            }
           
            stringsInput.Text = null;
        }

        private void copyStrings_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strings.ToString() + "\n de nieuwe lijst is : " + " " + 
                String.Join(",", strings.lijstCopy()));
        }

        private void toevoegenPersoon_Click(object sender, EventArgs e)
        {

            if(persoonInput.Text == string.Empty || inputleeftijd.Text == string.Empty)
            {

                MessageBox.Show("beide velden moeten ingevuld worden ! ");

            } else if(IsEveritingDigit(inputleeftijd.Text) == false)
            {
                MessageBox.Show(" leeftijd moet enkel getallen bevatten");
            }
            
            else
            {
                personen.OpDeStapel(new Persoon(persoonInput.Text, int.Parse(inputleeftijd.Text)));
            }

            persoonInput.Text = null;
            inputleeftijd.Text = null;
        }

        private void verwijderenPersoon_Click(object sender, EventArgs e)
        {
            if(personen.ToString() != string.Empty)
            {
                personen.vanDeStapel();
            } else
            {
                MessageBox.Show("sorry maar de stapel is al leeg !");
            }
            
        }

        private void LeegmakenPersoon_Click(object sender, EventArgs e)
        {
            personen.StapelLeegMaken();
        }

        private void showPersonen_Click(object sender, EventArgs e)
        { 
            label7.Text = "personen : " +  personen.ToString();
        }

        private void searchPersoon_Click(object sender, EventArgs e)
        {
            if (personen.IsAanwezigOpStapel(new Persoon(persoonInput.Text , int.Parse(inputleeftijd.Text))))
            {
                MessageBox.Show(" de persoon met naam : " + " " + persoonInput.Text + " en met leeftijd : " + " " + inputleeftijd.Text + " " + "is aanwezig in de lijst van personen");
            }
            else
            {
                MessageBox.Show("de persoon met naam : " + " "+ persoonInput.Text + " " + "bestaat niet in de lijst");
            }
        }

        private void copyPersoon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + personen.ToString() + "\n new list  de nieuwe lijst is : " + " " +
                String.Join(":", personen.lijstCopy()));
        }
    }
}
