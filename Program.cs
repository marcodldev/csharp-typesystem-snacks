
// snack1();
// snack2();

snack3();

// CONDIZIONALI
void snack1()
{
    //Snack1.L’utenteinserisceduenumeriinsuccessione.
    //Ilsoftwarestampailmaggiore.

    Console.WriteLine("Scrivimi 2 numeri");

    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 == num2)
    {
        Console.WriteLine("I due numeri sono uguali");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"{num2} è il numero più grande");
    }
    else
    {
        Console.WriteLine($"{num1} è il numero più grande");
    }
    
}

void snack2()
{
   /* L’utenteinseriscedueparoleinsuccessione.
    Ilsoftwarestampaprimalaparolapiùcorta,poilaparolapiùlunga. */

    Console.WriteLine("Scrivi 2 parole");

    string parola1 = Console.ReadLine() ?? "";
    string parola2 = Console.ReadLine() ?? "";

    if (parola1.Length == parola2.Length)
    {
        Console.WriteLine("Le due parole hanno la stessa lunghezza");
    }
    else if (parola1.Length > parola2.Length)
    {
        Console.WriteLine($"la parola {parola1} è più lunga della parola {parola2}");
    }
    else
    {
        Console.WriteLine($"la parola {parola2} è più lunga della parola {parola1}");
    }

}


// CICLO FOR

void snack3()
{
    /* Il software deve chiedere per 10 volte all’utente di inserire un numero.
    Il programma stampa la somma di tutti i numeri inseriti. */

    int[] arraynumeri = new int[10];
    int somma = 0;

    for (int i = 0; i < arraynumeri.Length; i++) 
    {
        Console.WriteLine($"Inserisci il {i + 1}° numero: ");
        arraynumeri[i] = Convert.ToInt32(Console.ReadLine());
    }

    foreach (int numero in arraynumeri)
    {
        somma += numero;
    }

    Console.WriteLine($"La somma dei numeri è {somma}");
}