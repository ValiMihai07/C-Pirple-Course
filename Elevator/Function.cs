using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Function
    {
        int elevatorA = 0;
        int elevatorB = 0;
        bool busyA = false;
        bool busyB = false;
        int floor;
        int people;
        

        public void WhatElevator()
        {
        
                Console.WriteLine("Which floor you want to go?");
                floor = (int)Console.Read();
                seeWhoGo();
        
        }
        bool isBusy()
        {
            return true;
        }

       
        void seeWhoGo()
        {
            if (floor == 10)
            {
                elevatorA = floor;
                Console.WriteLine("Elevator A is going to you and after to the floor you want");
                busyA = isBusy();
            }
            else if (floor == -1)
            {
                elevatorB = floor;
                Console.WriteLine("Elevator B is going to you and after to the floor you want");
                busyB = isBusy();
            }
            else
            {
                if (busyA)
                {
                    if (busyB)
                    {
                        if (floor - elevatorA < floor - elevatorB)
                        {
                            elevatorA = floor;
                            Console.WriteLine("Elevator A is going to you and after to the floor you want");
                            busyA = isBusy();
                        }
                        else
                        {
                            elevatorB = floor;
                            Console.WriteLine("Elevator B is going to you and after to the floor you want");
                            busyB = isBusy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Elevator B is going to you and after to the floor you want");
                        busyB = isBusy();
                    }
                }

                else if (busyB)
                {
                    if (busyA)
                    {
                        if (floor - elevatorA < floor - elevatorB)
                        {
                            elevatorA = floor;
                            Console.WriteLine("Elevator A is going to you and after to the floor you want");
                            busyA = isBusy();
                        }
                        else
                        {
                            elevatorB = floor;
                            Console.WriteLine("Elevator B is going to you and after to the floor you want");
                            busyB = isBusy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Elevator A is going to you and after to the floor you want");
                        busyA = isBusy();
                    }
                }
                else
                {
                    elevatorA = floor;
                    Console.WriteLine("Elevator A is going to you and after to the floor you want");
                    busyA = isBusy();
                }
            }
        }

    }




}
