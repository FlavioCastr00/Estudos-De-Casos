using System;
using Microsoft.VisualBasic;

// initialize variables - graded assignments 
int examAssignments = 5;
        
//Nomes dos alunos:
string[] studentNames = new string[]{"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

int[] sophiaScores = new int[]{90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[]{92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[]{90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[]{90, 95, 87, 88, 96, 96};
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    
int[] studentScores = new int[10];
        
string currentStudentLetterGrade = "";
        
//Imprime o cabeçalho do relatório:
Console.WriteLine("Student\t\tGrade\n");
        
foreach (string name in studentNames)
{
    if (name == "Sophia")
        studentScores = sophiaScores;
            
    else if(name == "Andrew")
        studentScores = andrewScores;
            
    else if(name == "Emma")
        studentScores = emmaScores;
            
    else if(name == "Logan")
        studentScores = loganScores;
    
    else if(name == "Becky")
        studentScores = beckyScores;

    else if(name == "Chris")
        studentScores = chrisScores;

    else if(name == "Eric")
        studentScores = ericScores;

    else if(name == "Gregor")
        studentScores = gregorScores;
     
    //inicializa a variável destinada à soma das notas
    int sumAssigmentScores = 0;
    //inicializa a variável destinada à média do aluno atual
    decimal currentStudentGrade = 0;
    //inicializa a variável que acompanhara quantas notas já foram somadas
    int gradedAssignments = 0;
            
    foreach (int score in studentScores)
    {
        //incrementa a variável de notas somadas
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            //adciona a nota do exame para a soma
            sumAssigmentScores += score;
        else
            //adiciona a nota de pontos extras
            sumAssigmentScores += score / 10;
    }
            
    currentStudentGrade = (decimal)sumAssigmentScores / examAssignments;

    //Para atribuir as notas em letras:        
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