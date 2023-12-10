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
    }
}