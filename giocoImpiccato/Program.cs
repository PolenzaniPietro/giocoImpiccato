﻿Console.WriteLine("benvenuto giocatore!! stai per giocare al gioco dell'impiccato,\n" +
    " spero tu già conosca le regole, in caso contrario... IMPARA LE REGOLE");
int tentativi = 0, indizi = 0;
string FilePath = " ";
string trattino;
Random rdn = new Random();
int casuale;
string parolaCasuale = " ";
string lingua = " ";
string categoria= " ";
//selezione difficolta
Console.WriteLine("seleziona la difficoltà");
Console.WriteLine("facile: 10 tentativi, 3 indizi");
Console.WriteLine("medio: 5 tentativi, 2 indizi");
Console.WriteLine("difficile: 3 tentativi, 1 indizio");
Console.WriteLine("impossibile: 1 tentativo, 0 indizi");
string difficolta = Console.ReadLine();
if (difficolta == "facile")
{
    tentativi = 10;
    indizi = 3;
}
else if (difficolta == "medio")
{
    tentativi = 5;
    indizi = 2;
}
else if (difficolta == "difficile")
{
    tentativi = 3;
    indizi = 1;
}
else if (difficolta == "impossibile")
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
        string[] lines = File.ReadAllLines(FilePath); 
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
    else if (categoria == "a")
    {
        FilePath = "animali_italiano.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
    else if (categoria == "p")
    {
        FilePath = "parti_del_corpo_italiano.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
    else if (categoria == "n")
    {
        FilePath = "natura_italiano.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
}
else if (lingua == "ing") //gioco in inglese
{
    Console.WriteLine("select the category: (v) videogames, (a) animals, (p) body parts, (n) nature");
    categoria = Console.ReadLine();
    if (categoria == "v")
    {
        FilePath = "videogiochi.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
    else if (categoria == "a")
    {
        FilePath = "animali_inglese.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
    else if (categoria == "p")
    {
        FilePath = "parti_del_corpo_inglese.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
    else if (categoria == "n")
    {
        FilePath = "natura_inglese.txt";
        string[] lines = File.ReadAllLines(FilePath);
        StreamReader reader = new StreamReader(FilePath);
        lines = File.ReadAllLines(FilePath);
        casuale = rdn.Next(lines.Length);
        parolaCasuale = lines[casuale];
    }
}
trattino = new string('_', parolaCasuale.Length );
Console.WriteLine(trattino + "(" + parolaCasuale.Length + ")");
while (tentativi > 0)
{
    Console.WriteLine("tentativi rimanenti: " + tentativi);
    Console.WriteLine();
    Console.WriteLine("inserisci lettera(l), suggerimento(s), inserisci parola(p)");
    string scelta=Console.ReadLine();
    if (scelta == "l")
    {
        Console.WriteLine("inserisci la lettera");
        char inserimento = char.ToLower(Console.ReadKey().KeyChar);
        for (int i = 0; i<parolaCasuale.Length; i++)
        {
            if(inserimento == parolaCasuale[i])
            {
                trattino += inserimento;
            }
            else
            {
                Console.WriteLine("inserimento non corretto");
                tentativi--;
            }
        }
    }
    else if( scelta == "p") 
    {
        Console.WriteLine("prova ad indovinare");
        string parola=Console.ReadLine();
        if (parola== parolaCasuale)
        {
            Console.WriteLine("HAI VINTO!!!");
        }
        else
        {
            Console.WriteLine("inserimento sbagliato");
            tentativi--;
        }
    }
    else if( scelta == "s")
    { 
        
    }

}