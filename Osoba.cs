using System;
class Osoba{
    public string imie;
    public string nazwisko;
    public int rokUrodzenia;
    public int waga;
    public int wzrost;
    public bool okulary = false;
    public enum plec{K, M};
    
    public int obliczWiek(int rokUrodzenia){
        int wiek;
        int now = DateTime.Now.Year;
        wiek = now - rokUrodzenia;
        return wiek;
    }
    
    public string BMI(){
        double BMI;
        double wz = Convert.ToDouble(wzrost)/100;
        BMI = Convert.ToDouble(waga)/(wz*wz);
        
        if (BMI>=18.5 && BMI<25) return "wartosc prawidlowa";
        else if (BMI<18.5 && BMI>0){
            if (BMI>=17) return "niedowaga";
            else if (BMI>=16) return "wychudzenie";
            else return "wyglodzenie";
        }
        else if (BMI>=25){
            if (BMI<30) return "nadwaga";
            else if (BMI<35) return "otylosc I stopnia";
            else if (BMI<40) return "otylosc II stopnia";
            else return "otylosc III stopnia";
        }
        else return "Error";
    }
}
