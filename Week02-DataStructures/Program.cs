using System;


//  DICTIONARY

Dictionary<string, District> regions = new Dictionary<string, District>();
regions.Add("Lagos", new District { Capital = "Ikeja",
                                    LGA = "

keyValuePairs.Add(1, "One");
keyValuePairs.Add(2, "Two");
keyValuePairs.Add(3, "Three");

foreach(var  region in regionss)
{
    Console.WriteLine(regions[region]);
}



class District
{
    public string Capital;
    public List<string> LGA;
}