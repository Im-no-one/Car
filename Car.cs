using System;
public class Car{
    public string marka;
    public int rok = 0;
    
    private string model;
    private int iloscDrzwi = 4;
    private double pojemnoscSilnika = 20;
    public double srednieSpalanie = 5;
    
    public Car(string x, int y){
        marka = x;
        
        if(y<1769) Console.WriteLine("W sredniowieczu nie bylo samochodow");
        else if(y>2017) Console.WriteLine("Ograniczenie do 2017");
        else rok = y;
    }
    
    private double ObliczSpalanie(double dlugoscTrasy){
        double spalanie;
        spalanie = srednieSpalanie * dlugoscTrasy;
        return spalanie;
    }
    
    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa){
        double kosztPrzejazdu;
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        kosztPrzejazdu = spalanie * cenaPaliwa;
        Console.WriteLine("{0}", kosztPrzejazdu);
        return kosztPrzejazdu;
    }
}