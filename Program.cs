using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Vehicle
    {
        public string name;
        public string model;
        public int airbags;
        public int price;
        public Boolean power_steering;
        public Boolean kick_start;
        public int engine_diplacement;
        public static void insert_car(Vehicle cars)
        {
            Console.WriteLine("enter name: ");
            cars.name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            cars.model = Console.ReadLine();
            Console.WriteLine("\n enter no of airbags:");
            cars.airbags = int.Parse(Console.ReadLine());
            Console.WriteLine("\n enter price: ");
            cars.price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n power steering true or false: ");
            cars.power_steering = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            cars.engine_diplacement = int.Parse(Console.ReadLine());

        }
        public static void disp_car(Vehicle c)
        {
            Console.WriteLine("name:{0} \n", c.name);
            Console.WriteLine("model:{0} \n", c.model);
            Console.WriteLine("price:{0} \n", c.price);
            Console.WriteLine("airbags:{0} \n", c.airbags);
            Console.WriteLine("power_steering:{0} \n", c.power_steering);
            Console.WriteLine("engine_diplacement:{0} \n", c.engine_diplacement);
        }
        public static void insert_bike(Vehicle bikes)
        {
            Console.WriteLine("enter name: ");
            bikes.name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            bikes.model = Console.ReadLine();
            //Console.WriteLine("\n enter no of airbags:");
            //bikes.airbags = int.Parse(Console.ReadLine());
            Console.WriteLine("\n enter price: ");
            bikes.price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n kick start true or false: ");
            bikes.kick_start = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            bikes.engine_diplacement = int.Parse(Console.ReadLine());
        }
        public static void disp_bike(Vehicle b)
        {
            Console.WriteLine("name:{0} \n", b.name);
            Console.WriteLine("model:{0} \n", b.model);
            Console.WriteLine("price:{0} \n", b.price);
            // Console.WriteLine("airbags:{0} \n", b.airbags);
            Console.WriteLine("kick_start:{0} \n", b.kick_start);
            Console.WriteLine("engine_diplacement:{0} \n", b.engine_diplacement);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
                int option = 0;
                //bike bikes = new bike();
                List<Vehicle> carsl = new List<Vehicle>();
                List<Vehicle> bikesl = new List<Vehicle>();
                while (option != 5)
                {

                    Console.WriteLine("1.add new car \n2.add new bike \n3.view cars \n4.view bikes \n5.exit");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                        Vehicle cars = new Vehicle();
                        Vehicle.insert_car(cars);
                            carsl.Add(cars);
                            break;

                        case 2:
                        Vehicle bikes = new Vehicle();
                        Vehicle.insert_bike(bikes);
                            bikesl.Add(bikes);
                            break;

                        case 3:
                            foreach (Vehicle c in carsl)
                            {
                            Vehicle.disp_car(c);

                            }

                            break;

                        case 4:
                            foreach (Vehicle b in bikesl)
                            {
                            Vehicle.disp_bike(b);
                            }
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("invalid choice!");
                            break;
                    }
                }
            }
        }
    }

