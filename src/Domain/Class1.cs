namespace Domain;
public class Bicycle // Public is mandatory, (see later)
{ 
  private int gear = 5; // Field
  public void Brake() // Function
  { 
      System.Console.WriteLine("I'm braking in gear:" + gear);
  }
}
