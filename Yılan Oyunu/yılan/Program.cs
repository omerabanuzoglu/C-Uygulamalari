using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace yılan
{
    class Program
    {
        static void Main(string[] args)
        {
                char[,] space = new char[15, 40];

                ConsoleKey key;
                int yemX = 0, yemY = 0;
                bool yendiMi = true;
                string yon = "sag";
                int yilanX = 7, yilanY = 20, yilanBoyut = 1;

                Console.WriteLine("Çıkmak için herhangi bir tuşa basmanız yeterlidir. \n\nBaşlamak için 'ENTER'");
                Console.ReadKey();
                while (true)
                { 
                    
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey().Key;
                        if (key == ConsoleKey.UpArrow)
                        {
                            yon = "yukari";
                        }
                        else if (key == ConsoleKey.DownArrow)
                        {
                            yon = "asagi";
                        }
                        else if (key == ConsoleKey.LeftArrow)
                        {
                            yon = "sol";
                        }
                        else if (key == ConsoleKey.RightArrow)
                        {
                            yon = "sag";
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (yendiMi)
                    {
                        Random rnd = new Random();
                        yemX = rnd.Next(0, 15);
                        yemY = rnd.Next(0, 40);
                        yendiMi = false;
                    }

                    if (yilanX < 0 || yilanX > 15 || yilanY < 0 || yilanY > 40)
                    {
                        Console.WriteLine("Çarptınız...\n");
                        break;
                    }

                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 40; j++)
                        {
                            if (i == yemX && j == yemY)
                            {
                                space[i, j] = 'X';
                            }
                            else if (!(i == yilanX && j == yilanY))
                            {
                                if (space[i, j] == '1')
                                {
                                    space[i, j] = ' ';
                                }
                            }
                            else
                            {
                                if (yon == "sag")
                                {
                                    for (int k = 0; k < yilanBoyut; k++)
                                    {
                                        space[i, j - k] = '*';
                                    }
                                }
                                else if (yon == "sol")
                                {
                                    for (int k = 0; k < yilanBoyut; k++)
                                    {
                                        space[i, j + k] = '*';
                                    }
                                }
                                else if (yon == "yukari")
                                {
                                    for (int k = 0; k < yilanBoyut; k++)
                                    {
                                        space[i - k, j] = '*';
                                    }
                                }
                                else
                                {
                                    for (int k = 0; k < yilanBoyut; k++)
                                    {
                                        space[i + k, j] = '*';
                                    }
                                }
                            }
                        }
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 40; j++)
                        {
                            Console.Write(space[i, j]);
                            space[i, j] = '1';
                        }
                        Console.WriteLine();
                    }
                    if (yemX == yilanX && yemY == yilanY)
                    {
                        yendiMi = true;
                        yilanBoyut++;
                    }
                    if (yon == "sag")
                    {
                        yilanY++;
                    }
                    else if (yon == "sol")
                    {
                        yilanY--;
                    }
                    else if (yon == "yukari")
                    {
                        yilanX--;
                    }
                    else
                    {
                        yilanX++;
                    }
                    
                    Thread.Sleep(250);
                    Console.Clear();
                }
                Console.WriteLine("\n///////////////////////////////\n\n{0} kere yemi yediniz...\n\n///////////////////////////////", yilanBoyut - 1);
                Console.ReadLine();
            }
        }
    }
