Random rng = new Random();
while (true)
{
    Console.WriteLine("1 kő, 2 papír, 3 olló");
    int valasz = Convert.ToInt32(Console.ReadLine());
    int gep = rng.Next(1,4);

    switch (valasz)
    {
        case 1:
            if (gep == 1)
            {
                Console.WriteLine("Döntetlen");

            }
            else if (gep == 2)
            {
                Console.WriteLine("Vesztettél!");
            }
            else { Console.WriteLine("Nyert!"); }
        break;
        case 2:
            if (gep == 2)
            {
                Console.WriteLine("Döntetlen");

            }
            else if (gep == 1)
            {
                Console.WriteLine("Nyert!");
            }
            else { Console.WriteLine("Vesztett!"); }
            break;
        case 3:
            if (gep == 3)
            {
                Console.WriteLine("Döntetlen");

            }
            else if (gep == 1)
            {
                Console.WriteLine("Vesztettél!");
            }
            else { Console.WriteLine("Nyert!"); }
            break;
        
    }
    Console.WriteLine("Szeretne még játszani? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }
}