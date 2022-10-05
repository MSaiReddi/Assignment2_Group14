using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_group14
{
    public static class Program
    {
        
        static void Main(string[] args)
        {
            int length = 1;
            int width = 1;

            do {
                Console.WriteLine("Please enter the length of the rectangle");
                int.TryParse(Console.ReadLine(), out length);
                if (LengthCheck(length) !=0)
                {
                    length = LengthCheck(length);
                }
            } while (LengthCheck(length) ==0);


            do
            {
                Console.WriteLine("Please enter the Width of the rectangle");
                int.TryParse(Console.ReadLine(), out width);
                if (WidthCheck(width) != 0)
                {
                    width = WidthCheck(width);
                }
            } while (WidthCheck(width) == 0);


            Rectangle rectangle = new Rectangle(length,width);

            
            bool inMenu = false;


            while (!inMenu)
            {
                Console.WriteLine("Please select from below menu");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("1.Get Rectangle Length\n2.Change Rectangle Length\n3.Get Rectangle Width\n4.Change Rectangle Width\n5.Get Rectangle Perimeter\n6.Get Rectangle Area\n7.Exit");
                int menu;
                int.TryParse(Console.ReadLine(), out menu);


                if (menu > 0 && menu < 8)
                {
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Current length is " + rectangle.GetCurrentLength()); 
                            break;
                        case 2:
                            Console.WriteLine("Please enter the new length of the rectangle");
                            int.TryParse(Console.ReadLine(), out length);

                            if(length==0)
                            {
                                break;
                            }
                            else
                            {
                                rectangle.SetNewLength(length);
                                break;
                            }
                        case 3:
                            Console.WriteLine("Current width is "+rectangle.GetCurrentWidth());
                            break;
                        case 4:
                            Console.WriteLine("Please enter the new Width of the rectangle");
                            int.TryParse(Console.ReadLine(), out width);

                            if (width == 0)
                            {
                                break;
                            }
                            else
                            {
                                rectangle.SetNewWidth(width);
                                break;
                            }
                        case 5:
                            Console.WriteLine("Perimeter of rectangle is " + rectangle.GetPerimeter());
                            break;
                        case 6:
                            Console.WriteLine("Area of Rectangle is "+rectangle.GetArea());
                            break;
                        case 7:
                            inMenu = true;
                            break;
                           
                    }

                }

            }


            Console.ReadKey();
        }

        public static int LengthCheck(int length)
        {
            int returnLength=0;
                if(length == 0)
                {
                    Console.WriteLine("Invalid Length please enter again");
                }
                else
                {
                
                returnLength= length;
                }
            
            return returnLength;
        }
        public static int WidthCheck(int width)
        {
            int returnWidth = 0;
           
            
            if (width == 0)
            {
                Console.WriteLine("Invalid width please enter again");
            }
            else
            {
                returnWidth = width;
            }

            return returnWidth;
        }

    }
}
