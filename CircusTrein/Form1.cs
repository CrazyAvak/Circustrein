using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        private List<Wagon> wagons = new List<Wagon>();
        private List<Animal> Animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //voegt de animal toe aan de animals list
            Animals.Add(createNewAnimal());
        }

        private Animal createNewAnimal()
        {
            //Creates a new animal 
            Animal animal = new Animal();
            animal.grootte = comboBoxSize.Text;
            animal.type = comboBoxEatType.Text;
            if (comboBoxSize.Text == "groot")
            {
                animal.punt = 5;
            }
            else if (comboBoxSize.Text == "middelmatig")
            {
                animal.punt = 3;
            }
            else
            {
                animal.punt = 1;
            }
            listBoxAnimals.Items.Add(animal.type + "| " + animal.grootte);
            return animal;
        }
        private Wagon createNewWagon()
        {
            //Creates a new Wagon
            Wagon wagon = new Wagon();
            wagon.punten = 0;
            return wagon;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            wagons.Clear();
            calcCarnivore();

        }

        private void calcCarnivore()
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].type == "vlees")
                {
                    Wagon wagon = createNewWagon();
                    wagon.animals.Add(Animals[i]);
                    wagon.punten = wagon.punten + Animals[i].punt;
                    wagons.Add(wagon);
                }
            }
            deleteCarnivores();
            calcHerbivore3();
        }        
      
        private bool wagonRules4(Wagon wagon, Animal CheckAnimal)
        {
            if (wagon.punten == 10 || wagon.punten + CheckAnimal.punt > 10)
            {
                return false;
            }

            foreach (var wagonAnimal in wagon.animals)
            {
                if (wagonAnimal.type == "vlees" && wagonAnimal.grootte == "groot")
                {
                    return false;
                }
                else if (wagonAnimal.type == "vlees" && CheckAnimal.grootte == "klein")
                {
                    return false;
                }
                else if (CheckAnimal.grootte == "groot" && wagonAnimal.type == "vlees" && wagonAnimal.grootte == "middelmatig")
                {
                    return true;
                }
                else if (CheckAnimal.grootte == "groot" && wagonAnimal.type == "vlees" && wagonAnimal.grootte == "klein")
                {
                    return true;
                }
                else if (CheckAnimal.grootte == "middelmatig" && wagonAnimal.type == "vlees" && wagonAnimal.grootte == "klein")
                {
                    return true;
                }
                if (CheckAnimal.type == wagonAnimal.type)
                {
                    return true;
                }
            }

            return false;
        }


     

     

        //verwijdert alle carnivoren uit de lijst
        private void deleteCarnivores()
        {
            Animals.RemoveAll(Animal => Animal.type == "vlees");
        }


        //geeft de resultaten aan het einde
        private void showResult()
        {
            foreach (var wagon in wagons)
            {
                listBoxResult.Items.Add(wagon.ToString());
            }
        }

        private void calcHerbivore3()
        {
            string[] sizes = new string[] { "groot", "middelmatig", "klein" };
            foreach (var size in sizes)
            {
                foreach (var animal in Animals)
                {
                    if (animal.grootte == size)
                    {
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (wagonRules4(wagons[i], animal) == true)
                            {
                                wagons[i].animals.Add(animal);
                                wagons[i].punten = wagons[i].punten + animal.punt;
                                break;
                            }
                            if (i == wagons.Count - 1)
                            {
                                Console.WriteLine("Nieuwe wagon");
                                Wagon wagon = createNewWagon();
                                wagon.punten = wagon.punten + animal.punt;
                                wagon.animals.Add(animal);
                                wagons.Add(wagon);
                                break;
                                //als we aan eht einde zitten van de wagons dan maak maar een nieuwe wagon aan
                                ;
                            }
                        }
                    }
                }
            }
            showResult();
        }
    }
}
