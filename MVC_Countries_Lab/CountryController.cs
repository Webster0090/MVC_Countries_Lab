using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }
        public static void CountryMenu()
        {
            bool runthis = true;
            while (runthis)
            {
                List<Country> countries;
                List<string> countryNames = new List<string>();
                string input = CountryMenuView.UserPick();
                if (input.ToLower() == "north america")
                {
                    NorthAmericaDB nadb = new NorthAmericaDB();
                    countries = nadb.Countries;
                    foreach (Country item in countries)
                    {
                        countryNames.Add(item.Name);
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine("what coutry would you like ot learn about?");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "usa")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "mexico")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Canada")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    break;
                }
                else if (input.ToLower() == "asia")
                {
                    AsiaDB adb = new AsiaDB();
                    countries = adb.Countries;
                    foreach (Country c in countries)
                    {
                        countryNames.Add(c.Name);
                        Console.WriteLine(c.Name);
                    }
                    Console.WriteLine("what coutry would you like ot learn about?");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "vietnam")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "japan")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "north korea")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "south korea")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
