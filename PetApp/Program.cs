using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PetApp.Program.Pet;

namespace PetApp
{
    internal class Program
    {
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }

        public abstract class Pet
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
            }

            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();

            public Pet()
            {

            }

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public class Cat :Pet, ICat
            {
                public Cat(string name, int age) : base(name, age)
                {

                }

                public override void Eat()
                {
                    Console.WriteLine(name + " has decided to get takeout");
                }

                public override void Play()
                {
                    Console.WriteLine(name + " is playing a game of Solitaire");
                }

                public void Purr()
                {
                    Console.WriteLine(name + " purred");
                }

                public void Scratch()
                {
                    Console.WriteLine(name + " found a backscratcher");
                }

                public override void GotoVet()
                {
                    Console.WriteLine(name + " has a terrible case of sleepybones");
                }
            }

            public class Dog : Pet, IDog
            {
                public string license;

                public Dog(string license, string name, int age) : base(name, age)
                {
                    this.license = license;
                }
                public override void Eat()
                {
                    Console.WriteLine(name + " did a trick and demands compensation");
                }

                public override void Play()
                {
                    Console.WriteLine(name + " is going fetch");
                }

                public void Bark()
                {
                    Console.WriteLine(name + " barks");
                }

                public void NeedWalk()
                {
                    Console.WriteLine(name + " heard someone say w a l k");
                }

                public override void GotoVet()
                {
                    Console.WriteLine(name + " is being taken on a trip"); ;
                }
            }

            public class Pets
            {
                List<Pet> petList = new List<Pet>();
                private int count;

                public Pet this[int nPetEl]
                {
                    get
                    {
                        Pet returnVal;
                        try
                        {
                            returnVal = (Pet)petList[nPetEl];
                        }
                        catch
                        {
                            returnVal = null;
                        }

                        return (returnVal);
                    }

                    set
                    {
                        // if the index is less than the number of list elements
                        if (nPetEl < petList.Count)
                        {
                            // update the existing value at that index
                            petList[nPetEl] = value;
                        }
                        else
                        {
                            // add the value to the list
                            petList.Add(value);
                        }
                    }
                }

                public int Count
                {
                    get { return count; }
                }

                public void Add(Pet pet)
                {
                    petList.Add(pet);
                    count++;
                }

                public void Remove(Pet pet)
                {
                    if (petList.Remove(pet))
                    {
                        count--;
                    }
                    
                    
                }

                public void RemoveAt(int petEI)
                {
                    try
                    {
                        petList.RemoveAt(petEI);
                        count--;
                    }
                    catch { }
                }
            }
        }


        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random random = new Random();
            
                if (random.Next(0, 2) == 0)
                {
                    // add a dog
                    int age;
                    Console.WriteLine("You bought a dog!");
                    Console.Write("Dog's Name => ");
                    string name = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("Age => ");
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Please enter an int");
                        }
                    }
                    Console.Write("License => ");
                    string license = Console.ReadLine();
                    pets.Add(new Dog(license, name, age));
                }
                else
                {
                    // else add a cat
                    int age;
                    Console.WriteLine("You bought a cat!");
                    Console.Write("Cat's Name => ");
                    string name = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("Age => ");
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Please enter an int");
                        }
                    }

                    pets.Add(new Cat(name, age));
                }
            
            for (int i = 0; i < 50; i++)
            {
                if (random.Next(1, 11) == 1)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        // add a dog
                        int age;
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's Name => ");
                        string name = Console.ReadLine();
                        while(true)
                        {
                            Console.Write("Age => ");
                            try
                            {
                                age = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Please enter an int");
                            }
                        }
                        Console.Write("License => ");
                        string license = Console.ReadLine();
                        pets.Add(new Dog(license, name, age));
                    }
                    else
                    {
                        // else add a cat
                        int age;
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's Name => ");
                        string name = Console.ReadLine();
                        while (true)
                        {
                            Console.Write("Age => ");
                            try
                            {
                                age = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Please enter an int");
                            }
                        }
                        
                        pets.Add(new Cat(name, age));
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    int count = pets.Count;
                    int rand = random.Next(0, (count - 1));
                    int rand2 = random.Next(1, 5);


                    switch (rand2) {
                        case 1:
                            pets[rand].Eat();
                            break;
                        case 2:
                            pets[rand].Play();
                            break;
                        case 3:
                            if (pets[rand] is Dog)
                            {
                                Dog dogPet = (Dog)pets[rand];
                                dogPet.Bark();
                            }              
                            else if (pets[rand] is Cat)
                            {
                                Cat catPet = (Cat)pets[rand];
                                catPet.Purr();
                            }
                            break;
                        case 4:
                            if (pets[rand] is Dog)
                            {
                                Dog pet = (Dog)pets[rand];
                                pet.NeedWalk();
                            }
                            else if (pets[rand] is Cat)
                            {
                                Cat pet = (Cat)pets[rand];
                                pet.Scratch();
                            }
                            break;
                        case 5:
                            pets[rand].GotoVet();
                            break;
                    }
                }
            }
        }
    }
}
