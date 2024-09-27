using System;

class HelloWorld
{
  static void Main()
  {
    string[] pettingZoo = 
    {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
        "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
    };
    
    PlanSchoolVisit("School A", pettingZoo);
    PlanSchoolVisit("School B", pettingZoo, 3);
    PlanSchoolVisit("School C", pettingZoo, 2);
  }
  
  static void PlanSchoolVisit(string schoolName, string[] pettingZoo, int groups = 6)
  {
      RandomizeAnimals(pettingZoo);
      string[,] group = AssignGroup(pettingZoo, groups);
      Console.WriteLine(schoolName);
      PrintGroup(group);
  }
  
  //Method to randomize the order of the elements in the "pettingZoo" array
  static void RandomizeAnimals(string[] pettingZoo)
  {
      Random rand = new Random();
      
      for (int i = 0; i < pettingZoo.Length; i++)
      {
          int r = rand.Next(i, pettingZoo.Length);
          
          string temp = pettingZoo[i];
          pettingZoo[i] = pettingZoo[r];
          pettingZoo[r] = temp;
      }
  }
  
  //Method to assign animals to groups
  static string[,] AssignGroup(string[] pettingZoo, int groups = 6)
  {
      string[,] result = new string[groups, pettingZoo.Length/groups];
      int start = 0;
      
      for (int i = 0; i < groups; i++)
      {
          for (int j = 0; j < result.GetLength(1); j++)
          {
              result[i, j] = pettingZoo[start++];
          }
      }
      return result;
  }
  
  //Display Results
  static void PrintGroup(string[,] group)
  {
      for ( int i = 0; i < group.GetLength(0); i++)
      {
          Console.Write($"Group {i + 1}: ");
          for ( int j = 0; j < group.GetLength(1); j++)
          {
              Console.Write($"{group[i,j]} ");
          }
          Console.WriteLine();
      }
      Console.WriteLine();
  }
}