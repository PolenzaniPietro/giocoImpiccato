Console.WriteLine("benvenuto giocatore!! stai per giocare al gioco dell'impiccato,\n" +
    " spero tu già conosca le regole, in caso contrario... IMPARA LE REGOLE");
int tentativi = 0, indizi = 0;
string FilePath = " ";
Random rdn = new Random();
int casuale;
string parolaCasuale = "";
string lingua = " ";
string categoria = " ";
bool vittoria = false;
string lettere_inserite = "";

//selezione difficolta
Console.WriteLine("seleziona la difficoltà");
Console.WriteLine("facile: 10 tentativi, 3 indizi");
Console.WriteLine("medio: 5 tentativi, 2 indizi");
Console.WriteLine("difficile: 3 tentativi, 1 indizio");
Console.WriteLine("impossibile: 1 tentativo, 0 indizi");
string difficolta = Console.ReadLine();

if (difficolta == "facile" || difficolta == "f")
{
    tentativi = 10;
    indizi = 3;
}
else if (difficolta == "medio" || difficolta == "m")
{
    tentativi = 5;
    indizi = 2;
}
else if (difficolta == "difficile" || difficolta == "d")
{
    tentativi = 3;
    indizi = 1;
}
else if (difficolta == "impossibile" || difficolta == "i")
{
    tentativi = 1;
    indizi = 0;
}

//selezione lingua e tipologia partita
Console.WriteLine("seleziona la lingua della tua partita, italiano(ita) o inglese(ing)");
lingua = Console.ReadLine();

if (lingua == "ita") //gioco in italiano
{
    Console.WriteLine("scegli la categoria della tua partita: (v) videogiochi, (a) animali, (p) parti del corpo, (n) natura");
    categoria = Console.ReadLine();
    if (categoria == "v")
    {
        FilePath = "videogiochi.txt";
    }
    else if (categoria == "a")
    {
        FilePath = "animali_italiano.txt";
    }
    else if (categoria == "p")
    {
        FilePath = "parti_del_corpo_italiano.txt";
    }
    else if (categoria == "n")
    {
        FilePath = "natura_italiano.txt";
    }
}
else if (lingua == "ing") //gioco in inglese
{
    Console.WriteLine("select the category: (v) videogames, (a) animals, (p) body parts, (n) nature");
    categoria = Console.ReadLine();
    if (categoria == "v")
    {
        FilePath = "videogiochi.txt";
    }
    else if (categoria == "a")
    {
        FilePath = "animali_inglese.txt";
    }
    else if (categoria == "p")
    {
        FilePath = "parti_del_corpo_inglese.txt";
    }
    else if (categoria == "n")
    {
        FilePath = "natura_inglese.txt";
    }
}



 string[] lines = File.ReadAllLines(FilePath);
 casuale = rdn.Next(lines.Length);
 parolaCasuale = lines[casuale].ToLower();


char[] trattino = new char[parolaCasuale.Length];
for (int i = 0; i < trattino.Length; i++)
{
    trattino[i] = '_';
}
Console.WriteLine("( " + parolaCasuale.Length + " )");
trattino[0] = parolaCasuale[0];
trattino[trattino.Length - 1] = parolaCasuale[parolaCasuale.Length - 1];

while (tentativi > 0 && !vittoria)
{
    Console.WriteLine();
    for (int i = 0; i < trattino.Length; i++)
    {
        Console.Write(trattino[i]);
    }
    Console.WriteLine();
    Console.WriteLine("tentativi rimanenti: " + tentativi);
    Console.WriteLine("lettere inserite: " + lettere_inserite);
    Console.WriteLine();
    Console.WriteLine("inserisci lettera(l), suggerimento(s), inserisci parola(p)");

    string scelta = Console.ReadLine();
    if (scelta == "l")
    {
        Console.WriteLine("inserisci la lettera");
        char inserimento = Console.ReadKey().KeyChar;
        Console.WriteLine();  


        bool letteraTrovata = false;
        for (int j = 0; j < parolaCasuale.Length; j++)
        {
            if (inserimento == parolaCasuale[j])
            {
                trattino[j] = inserimento;
                letteraTrovata = true;
            }
        }

        if (!letteraTrovata)
        {
            Console.WriteLine("inserimento non corretto");
            tentativi--;
        }
        lettere_inserite += inserimento;

        vittoria = true;
        for (int i = 0; i < trattino.Length; i++)
        {
            if (trattino[i] == '_')
            {
                vittoria = false;
                break;
            }
        }
    }
    else if (scelta == "p")
    {
        Console.WriteLine("prova ad indovinare la parola:");
        string parola = Console.ReadLine();
        if (parola == parolaCasuale)
        {
            vittoria = true;
            Console.WriteLine("CONGRATULAZIONI HAI VINTO!!!!!!");
            break;
        }
        else
        {
            Console.WriteLine("inserimento sbagliato");
            tentativi--;
        }
    }
    else if (scelta == "s")
    {
        if (indizi > 0)
        {
            int indice = rdn.Next(1, parolaCasuale.Length - 1);
            trattino[indice] = parolaCasuale[indice];
            indizi--;
        }
        else
        {
            Console.WriteLine("indizi esauriti");
        }
    }
}

if (!vittoria)
{
    Console.WriteLine("non sei riuscito ad indovinare la parola, SCARSO");
}
