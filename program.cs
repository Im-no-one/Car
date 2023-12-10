using System;
class Program{
    static string opiszTyp(int x) { //?
        return "Int";
    }
    static string opiszTyp(double x){
        return "Double";
    }
    static string opiszTyp(string x){
        return "String";
    }
    static string opiszTyp(char x){
        return "Char";
    }
    
    static void Main() {
        Console.WriteLine("{0}", opiszTyp('1'));
        
        Osoba Dyrektor = new Osoba();
        Dyrektor.imie = "Alina";
        Dyrektor.nazwisko = "Kowalska";
        Dyrektor.rokUrodzenia = 2000;
        Dyrektor.waga = 60;
        Dyrektor.wzrost = 170;
        Osoba.plec plec = Osoba.plec.K;
        
        if(plec==0) Console.Write("Pani ");
        else Console.Write("Pan ");
        Console.WriteLine("{0} {1}, {2} lat",
        Dyrektor.imie, 
        Dyrektor.nazwisko, 
        Dyrektor.obliczWiek(Dyrektor.rokUrodzenia));
        
        // 17
        Osoba Pacjent = new Osoba();
        Pacjent.imie = "Jan";
        Pacjent.nazwisko = "Kowalski";
        Pacjent.wzrost = 180;
        Pacjent.waga = 90;
        
        Console.WriteLine("BMI pacjenta jest w kategorii: {0}", Pacjent.BMI());
        
        // 18
        produkt klej = new produkt();
        klej.nazwa = "klej";
        klej.cena = 2.99;
        koszyk koszyk = new koszyk();
        koszyk.AddToCart(klej);
    }
}