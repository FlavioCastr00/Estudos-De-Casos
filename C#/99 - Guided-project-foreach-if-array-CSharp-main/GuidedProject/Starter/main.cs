using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize variables - graded assignments 
        int currentAssignments = 5;
        
        //Nomes dos alunos:
        string[] studentNames = new string[]{"Sophia", "Andrew", "Emma", "Logan"};
        
        int[] sophiaScores = new int[]{90, 86, 87, 98, 100};
        int[] andrewScores = new int[]{92, 89, 81, 96, 90};
        int[] emmaScores = new int[]{90, 85, 87, 98, 68};
        int[] loganScores = new int[]{90, 95, 87, 88, 96};
        int[] studentScores = new int[5];
        
        string currentStudentLetterGrade = "";
        
        //Imprime o cabeçalho do relatório:
        Console.WriteLine("Student\t\tGrade\n");
        
        foreach (string name in studentNames)
        {
            if (name == "Sophia")
                studentScores = sophiaScores;
            
            else if(name == "Andre")
                studentScores = andrewScores;
            
            else if(name == "Emma")
                studentScores = emmaScores;
            
            else if(name == "Logan")
                studentScores = loganScores;
            
            //inicializa a variável destinada à soma das notas
            int sumAssigmentScores = 0;
            //inicializa a variável destinada à média do aluno atual
            decimal currentStudentGrade = 0;
            
            foreach (int score in studentScores)
            {
                //adciona a nota do exame para a soma
                sumAssigmentScores += score;
            }
            
            currentStudentGrade = (decimal)sumAssigmentScores / currentAssignments;
            
            if (currentStudentGrade >= 90)
            {
                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";
                
                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";
                
                else
                    currentStudentLetterGrade = "A-";
            }
            else if (currentStudentGrade >= 80)
            {
                if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";
                
                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";
                
                else
                    currentStudentLetterGrade = "B-";
            }
            else if (currentStudentGrade >= 70)
            {
                if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";
                
                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";
                
                else
                    currentStudentLetterGrade = "C-";
            }
            else if (currentStudentGrade >= 60)
            {
                if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";
                
                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";
                
                else
                    currentStudentLetterGrade = "D-";
            }
            else
                currentStudentLetterGrade = "F";
            
            Console.WriteLine($"{name}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }
        
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}