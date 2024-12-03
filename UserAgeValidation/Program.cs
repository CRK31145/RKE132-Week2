// See https://aka.ms/new-console-template for more information

//rakendus küsib sugu (m/f)
//rakendus küsib perekonna nime
//lähtudeskasutaja kasutaja valikust, rakendus tervitab kasutajat järgmiselt
// welcome (MR. keegi keegi)

Console.WriteLine("Please, select your gender (M/F):");

char userGender = Char.Parse(Console.ReadLine());

if (userGender == 'M')
{
    Console.WriteLine("Welcome, Mr.!");
}
else if (userGender == 'F')
{
    Console.WriteLine("Welcome, Ms.!");
}
else
{
    Console.WriteLine("Welcome!");
}