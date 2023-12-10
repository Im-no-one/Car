using System;

public class produkt{
    public string nazwa = "-";
    public double cena = 0;
}
public class koszyk{
    public produkt[] listaTowarow = {};
        
    public produkt[] AddToCart(produkt x){
        Console.WriteLine(x.nazwa);
        listaTowarow.Append(x);
        return koszyk;
    }
    
    public void podsumowanie(){
        
    }
}

