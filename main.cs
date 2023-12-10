using System;
class Program{
    static void Main() {
        // 1. zadeklarowanie zmiennej carName
        string carName = "Moj samochod";
        
        // 2. Stworzenie klasy Car w pliku Car.cs
        // 3. Modyfikowanie klas na prywatne
        
        // 4. Tworzenie zmiennej car1 typu Car i poprawianie klas na publiczne
        Console.WriteLine("{0}", carName);
        Car car1 = new Car("Opel", 2001);
        Console.WriteLine("{0}, {1}", car1.marka, car1.rok);
        
        // 5. Tworzenie drugiej zmiennej car2 typu Car
        Car car2 = new Car("Honda", 2009);
        Console.WriteLine("{0}, {1}", car2.marka, car2.rok);
        
        // 6. Przypisanie car2 do car1
        car1 = car2;
        Console.WriteLine("{0}, {1}", car1.marka, car1.rok);
        Console.WriteLine("{0}, {1}", car2.marka, car2.rok);
        // 7. Komentowanie kodu do 5 i 6
        
        double o = car1.ObliczKosztPrzejazdu(50, 4);
        Console.WriteLine("{0}", o);

        
        
        
    }
}