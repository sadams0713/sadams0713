

var Continue_Running = false;

do
{
    Console.WriteLine($"How many people will be eating a PB & J sandwich?");
    string people = Console.ReadLine();


    int Total_Slices_Needed = int.Parse(people);
    int Peanut_Butter = int.Parse(people);
    int Jelly = int.Parse(people);
    var Total_Loaves = Math.Ceiling((Double)Total_Slices_Needed / 14);
    var Jars_PB = Math.Ceiling((Double)Peanut_Butter / 16);
    var Jars_Jelly = Math.Ceiling((Double)Jelly / 12);

    Console.WriteLine(" You will need "
        + Total_Slices_Needed * 2 + " slices of Bread, "
        + Peanut_Butter * 2 + " ounces of peanut butter, and "
        + Jelly * 4 + " ounces of jelly. ");


    Console.WriteLine(" That's roughly "
        + Total_Loaves + (" loaves of bread, ")
        + Jars_PB + (" jars of peanut butter, and ")
        + Jars_Jelly + (" jars of jelly, "));


    Console.Write("Did more people show up? Press Y to change the number of sandwiches needed. If everyone is full, N.");


    var input = (Console.ReadLine());

    if (input == "y") 
        { Continue_Running = true; }
         else if (input == "yes")
            { Continue_Running = true;}
         else if (input == "Y")
    { Continue_Running = true; }
         else if (input == "Yes")
    { Continue_Running = true; }
         else { Continue_Running = false; }
}
while (Continue_Running == true);


Console.Write(" Goodbye. Press any key to exit. ");