
// snack1();
// snack2();
// snack3();
// snack4();
// snack5();
// snack6();
// snack7();
// snack8();
// snack9();
 snack10(); 
// snack11();
// snack12();

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

void snack7()
{
    /* Crea un array vuoto.
    Chiedi per 6 volte all’utente di inserire un numero, se è dispari
    inseriscilo nell’array. */

    Console.WriteLine("Voglio 6 numeri dispari");

    int[] arrayVuoto = new int[6];

    //bool dispari = (numero % 2 == 1);

    for (int i = 0; i < arrayVuoto.Length;i++)
    {
        Console.WriteLine($"Inserisci il {i + 1}° numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 1)
        {
            arrayVuoto[i] = numero;
        }
        else
        {
            Console.WriteLine("Attenzione hai inserito un numero pari");
        }
            
    }

    if(arrayVuoto != null)
    {
        Console.WriteLine($"I numeri che hai scelto sono:");
        foreach (int numero in arrayVuoto)
        {
            Console.WriteLine(numero + " ");
        }
    }
}

void snack8()
{
    /* 
     Crea un array di numeri interi e fai la somma di tutti gli elementi che
     sono in posizione dispari.
     */

    int[] arrayNumeri = { 1, 2, 3, 4, 5, 6 };

    int somma = 0;

    for (int i = 0; i < arrayNumeri.Length; i += 2)
    {
        somma += arrayNumeri[i];
    }

    Console.WriteLine($"La somma degli elementi in posizione dispari dell'array è: {somma}");
}


// Ciclo while


void snack9()
{
    /* Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
     Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a
     quando la somma degli elementi è minore di 50. */

    int[] arrayNumeri = new int[50];

    int somma = 0;
    int i = 0;

    while (somma < 50)
    {
        Console.WriteLine("Inserisci un numero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        arrayNumeri[i] = numero;
        i++;
        somma += numero;
    }

    Console.WriteLine("I numeri che hai scelto sono:");
    for (int j = 0; j < i; j++)
    {
        Console.WriteLine(arrayNumeri[j]);
    }

}



// Random


void snack10()
{
    /* 
        Fai inserire un numero, che chiameremo N, all’utente.
        Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
        Ogni volta che ne crei uno, stampalo a schermo.*/
     

    Console.Write("Quanti array vuoi generare?");

    int N = Convert.ToInt32(Console.ReadLine());

    Random numeriRandom = new Random();

    for (int i = 0;i < N; i++)
    {
        int[] array = new int[10];

        for (int j = 0; j < array.Length; j++)
        {
            array[j] = numeriRandom.Next(0, 100); 
        }

        Console.Write("Array " + (i + 1) + ": ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }


}

// FUNZIONI

void snack11()
{
    /* 
        Dare la possibilità di inserire due parole.
        Verificare tramite una funzione che le due parole abbiano la stessa
        lunghezza. Se hanno la stessa lunghezza, stamparle entrambe,
        altrimenti stampare la più lunga delle due.
     */

    Console.WriteLine("Scrivi 2 parole");

    string parolaScelta1 = Console.ReadLine() ?? "";
    string parolaScelta2 = Console.ReadLine() ?? "";

    bool checkLunghezza(string parola1,string parola2)
    {
        if (parola1.Length == parola2.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool parolaLunga(string parola1, string parola2)
    {
        if (parola1.Length > parola2.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    if (checkLunghezza(parolaScelta1,parolaScelta2)) {
        Console.WriteLine("le due parole hanno la stessa lunghezza");
    }
    else
    {
        Console.WriteLine("le due parole NON hanno la stessa lunghezza, ti stampo la più lunga:");
        if(parolaLunga(parolaScelta1, parolaScelta2) ){
            Console.WriteLine(parolaScelta1);
        }
        else
        {
            Console.WriteLine(parolaScelta2);
        }
    }
}

void snack12()
{
    /* 
     Scrivere una funzione per verificare se un numero è pari o dispari.
       Quindi chiedere un numero all'utente e comunicargli se è pari o dispari
     */

    bool pariOdispari(int numero)
    {
        if(numero % 2 == 0)
        {
            return true;
        }
        else
        {
           return false;
        }
    }

    Console.WriteLine("dammi un numero,ti dirò se è pari o dispari");

    int numeroUtente = Convert.ToInt32(Console.ReadLine());

    if (pariOdispari(numeroUtente))
    {
        Console.WriteLine("Pari");
    }
    else
    {
        Console.WriteLine("Dispari");
    }
}