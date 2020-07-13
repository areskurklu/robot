using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coordinates c = new Coordinates();
                //setting the limits for 5x5
                c.SetLimits(4, 4);

                Robot r = new Robot(c);

                while (true)
                {
                    try
                    {
                        string com = Console.ReadLine();

                        if (com.Trim().ToUpper().StartsWith("PLACE"))
                        {
                            string[] parts = com.ToUpper().Replace("PLACE", "").Split(',');

                            int x = 0, y = 0;
                            string position = string.Empty;

                            x = int.Parse(parts[0].Trim());
                            y = int.Parse(parts[1].Trim());
                            position = parts[2].ToString();
                            r.Place(x, y);
                            r.SetPosition(position);
                        }

                        if (com.Trim().ToUpper() == "MOVE")
                        {
                            r.Move();
                        }
                        else if (com.Trim().ToUpper() == "RIGHT")
                        {
                            r.TurnRight();
                        }
                        else if (com.Trim().ToUpper() == "LEFT")
                        {
                            r.TurnLeft();
                        }
                        else if (com.Trim().ToUpper() == "REPORT")
                        {
                            Console.WriteLine(r.Report());
                        }
                        else if (com.Trim().ToUpper() == "EXIT")
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
           
            }

    
        }
    }
}
