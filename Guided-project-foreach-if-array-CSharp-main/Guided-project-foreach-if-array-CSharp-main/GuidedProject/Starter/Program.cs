using System;
Console.Clear();

// initialize variables - graded assignments 
int currentAssignments = 5;

string[] studentNames = {"Sophia", "Andrew", "Emma  ", "Logan ", "Becky ", "Chris ", "Eric  ", "Gregor"};

int[][] studentGrades = {
    new int[] {90, 86, 87, 98, 100, 94, 90}, 
    new int[] {92, 89, 81, 96, 90, 89}, 
    new int[] {90, 85, 87, 98, 68, 89, 89, 89}, 
    new int[] {90, 95, 87, 88, 96, 96},
    new int[] {92, 91, 90, 91, 92, 92, 92},
    new int[] {84, 86, 88, 90, 92, 94, 96, 98},
    new int[] {80, 90, 100, 80, 90, 100, 80, 90},
    new int[] {91, 91, 91, 91, 91, 91, 91}
};

float[] studentFinalGrades = {0, 0, 0, 0, 0, 0, 0, 0};

// for (int name = 0; name < studentGrades.GetLength(0); name++)
// {
//     for (int grade = 0; grade < studentGrades.GetLength(1); grade++)
//     {
//         studentFinalGrades[name] += studentGrades[name, grade];
//     }
//     studentFinalGrades[name] /= (float)currentAssignments;
// }

int currentStudent = 0;
foreach (var studentGrade in studentGrades)
{
    int currentGrade = 0;
    foreach (int grade in studentGrade)
    {
        if (currentGrade < currentAssignments)
        {
            studentFinalGrades[currentStudent] += grade;
        }
        else
        {
            studentFinalGrades[currentStudent] += grade / 10;
        }
        currentGrade++;
    }
    studentFinalGrades[currentStudent] /= (float)currentAssignments;
    currentStudent++;
}

string[] studentFinalLetterGrades = {"", "", "", "", "", "", "", ""};

currentStudent = 0;
foreach (int grade in studentFinalGrades)
{
    if (grade > 96 && grade < 101)
    {
        studentFinalLetterGrades[currentStudent] = "A+";
        currentStudent++;
    }
    else if (grade > 92 && grade < 97)
    {
        studentFinalLetterGrades[currentStudent] = "A";
        currentStudent++;
    }
    else if (grade > 89 && grade < 93)
    {
        studentFinalLetterGrades[currentStudent] = "A-";
        currentStudent++;
    }
    else if (grade > 86 && grade < 90)
    {
        studentFinalLetterGrades[currentStudent] = "B+";
        currentStudent++;
    }
    else if (grade > 82 && grade < 87)
    {
        studentFinalLetterGrades[currentStudent] = "B";
        currentStudent++;
    }
    else if (grade > 79 && grade < 83)
    {
        studentFinalLetterGrades[currentStudent] = "B-";
        currentStudent++;
    }
    else if (grade > 76 && grade < 78)
    {
        studentFinalLetterGrades[currentStudent] = "C+";
        currentStudent++;
    }
    else if (grade > 72 && grade < 77)
    {
        studentFinalLetterGrades[currentStudent] = "C";
        currentStudent++;
    }
    else if (grade > 69 && grade < 73)
    {
        studentFinalLetterGrades[currentStudent] = "C-";
        currentStudent++;
    }
    else if (grade > 66 && grade < 70)
    {
        studentFinalLetterGrades[currentStudent] = "D+";
        currentStudent++;
    }
    else if (grade > 62 && grade < 67)
    {
        studentFinalLetterGrades[currentStudent] = "D";
        currentStudent++;
    }
    else if (grade > 59 && grade < 63)
    {
        studentFinalLetterGrades[currentStudent] = "D-";
        currentStudent++;
    }
    else if (grade < 60)
    {
        studentFinalLetterGrades[currentStudent] = "F";
        currentStudent++;
    }
}

Console.WriteLine("Student \tGrade\n");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine($"{studentNames[i]}: \t{studentFinalGrades[i]} \t{studentFinalLetterGrades[i]}");
}

Console.Write("\n\rPress the Enter key to continue...");
Console.ReadLine();
// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
