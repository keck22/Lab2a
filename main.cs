using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Provide a tempurature in celsius");
    string celsius = Console.ReadLine();
    int celsiusTemp = Convert.ToInt32(celsius);
    int fahrenheitTemp = celsiusTemp*9/5+32;
    Console.WriteLine ("The tempurature given in celsius is equivalent to: " + fahrenheitTemp);
    
    if (fahrenheitTemp <32) {
      Console.WriteLine ("This tempurature is below the freezing tempurature of 32 degrees Fahrenheit ");
    }
      else if (fahrenheitTemp > 212) {
      Console.WriteLine ("This tempurature is above the boiling tempurature of 212 degrees Fahrenheit ");
      
    }

    


    
  }
}