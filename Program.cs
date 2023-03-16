
// snack1();
// snack2();
// snack3();
// snack4();
// snack5();
snack6();

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

void snack4()
{
    //Calcola la somma e la media dei numeri da 2 a 10.

    int[] numeri = new int[9]; 
    for (int i = 2; i <= 10; i++)
    {
        numeri[i - 2] = i;
    }

    int somma = 0;

    for (int i = 0; i < numeri.Length; i++)
    {
        somma += numeri[i];
    }

    double media = (double)somma / numeri.Length;

    for (int i = 0; i < numeri.Length; i++)
    {
        Console.WriteLine(numeri[i]);
    }

    Console.WriteLine($"La somma dei numeri è {somma}");

    Console.WriteLine($"La media dei numeri è {media}");
}

// Operatore modulo

void snack5()
{
    /* Il software chiede all’utente di inserire un numero. Se il numero inserito
    è pari, stampa il numero, se è dispari, stampa il numero successivo. */

    Console.WriteLine("Dammi un numero pari, se mi darai un numero dispari lo aumenterò di 1");

    int numero = Convert.ToInt32(Console.ReadLine());

    bool pari = (numero % 2 == 0);

    if ( pari )
    {
        Console.WriteLine($"il numero scelto ({numero}) è pari");
    }
    else
    {
        Console.WriteLine($"il numero scelto NON è pari, dunque ne ho aggiunto uno, il risultato è : {numero+1}");
    }
}

// Array

void snack6()
{
    /* 
    In un array sono contenuti i nomi degli invitati alla festa del grande
    Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare
    o meno alla festa
     */

    Console.WriteLine("Devo controllare se sei presente nella lista, mi serve il tuo nome");

    string nomeDaControllare = Console.ReadLine() ?? "";

    string[] invitati = { "luca", "marco", "giovanni"};

    for (int i = 0;i < invitati.Length;i++)
    {

        if (nomeDaControllare == invitati[i])
        {
            Console.WriteLine("divertiti");
            break;
        }
        else
        {
            if (i == invitati.Length - 1)
            {
                Console.WriteLine("non sei sulla lista");
            }
            
        }

    }
}