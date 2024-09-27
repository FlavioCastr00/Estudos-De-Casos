using System;

class HelloWorld
{
  static void Main()
  {
    //Random random = new Random();
    
    Console.WriteLine("Would you like to play? (Y/N)");
    if (ShouldPlay()) 
    {
        PlayGame();
    }
  }
  
    static bool ShouldPlay()
    {
        string readResult = Console.ReadLine().ToUpper();
        
        
        if (readResult == "Y")
            return true;
        
        else if (readResult == "N")
            return false;
        
        else
            do
            {
                readResult = "";
                Console.WriteLine("Invalid answer. Please, Try again.");
                readResult = Console.ReadLine().ToUpper();
            } while (readResult != "Y" && readResult != "N");
            
            if (readResult == "Y")
                return true;
            
            else
                return false;
    }
    
    static void PlayGame() 
    {
        Random rand = new Random();
        var play = true;
        
        while (play) 
        {
            int target = rand.Next(1, 6);
            int roll = rand.Next(1, 7);
            
            Console.WriteLine($"Roll a number greater than {target} to win!");
            Console.WriteLine($"You rolled a {roll}");
            Console.WriteLine(WinOrLose(roll, target));
            Console.WriteLine("\nPlay again? (Y/N)");
            
            play = ShouldPlay();
        }
    }
    
    static string WinOrLose(int roll, int target)
    {
        if (roll > target)
            return "Win!!";
        else
            return "You Lost D:";
    }
}