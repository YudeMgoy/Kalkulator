using System;
using System.IO;
using System.Globalization;

class Kalkulator{
    public static void Main(){
        Console.WriteLine("Enter 1 for Addition");
        Console.WriteLine("Enter 2 for Substraction");
        Console.WriteLine("Enter 3 for Multiplication");
        Console.WriteLine("Enter 4 for Division");

        var menuInput = Console.ReadLine();

        Console.WriteLine("Enter 1st Input");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter 2nd Input");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Kalkulator kalkulator =  new Kalkulator();
        
        switch(menuInput){
            case "1":
                kalkulator.Penambahan(num1, num2);
                break;
            case "2": 
                kalkulator.Pengurangan(num1, num2);
                break;
            case "3": 
                kalkulator.Perkalian(num1, num2);
                break;
            case "4": 
                kalkulator.Pembagian(num1, num2);
                break;
        }
    }

    public void Penambahan(double num1, double num2){
        Console.WriteLine(num1+"+"+num2+"="+(num1+num2));
    }

    public void Pengurangan(double num1, double num2){
        Console.WriteLine(num1+"-"+num2+"="+(num1-num2));
    }

    public void Perkalian(double num1, double num2){
        Console.WriteLine(num1+"x"+num2+"="+(num1*num2));
    }

    public void Pembagian(double num1, double num2){
        Console.WriteLine(num1+"/"+num2+"="+(num1/num2));
    }
}
