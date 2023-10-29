using System;

// initialize variables - graded assignments 
int examAssignments = 5;

// Student grades
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
  string currentStudent = name;

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;
  else if (currentStudent == "Andrew")
    studentScores = andrewScores;
  else if (currentStudent == "Emma")
    studentScores = emmaScores;
  else if (currentStudent == "Logan")
    studentScores = loganScores;
  else if (currentStudent == "Becky")
    studentScores = beckyScores;
  else if (currentStudent == "Chris")
    studentScores = chrisScores;
  else if (currentStudent == "Eric")
    studentScores = ericScores;
  else if (currentStudent == "Gregor")
    studentScores = gregorScores;
  else
    continue;

  // Calculate Exam Grade
  int sumExamScores = 0;
  int gradedExamAssignments = 0;
  decimal examGrade;

  for (int i = 0; i < examAssignments; i++)
  {
    gradedExamAssignments++;
    sumExamScores += studentScores[i];
  }

  examGrade = (decimal)sumExamScores / gradedExamAssignments;

  // Calculate Extra Credit
  int sumExtraCreditScores = 0;
  int gradedExtraCreditAssignments = 0;
  decimal extraCreditGrade;
  decimal extraCreditPoints = 0;

  for (int i = examAssignments; i < studentScores.Length; i++)
  {
    gradedExtraCreditAssignments++;
    sumExtraCreditScores += studentScores[i];
  }

  extraCreditGrade = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;
  extraCreditPoints = (decimal)(sumExtraCreditScores / 10) / examAssignments;

  decimal totalGrade = examGrade + extraCreditPoints;
  string letterGrade = "";

  if (totalGrade >= 97)
    letterGrade = "A+";

  else if (totalGrade >= 93)
    letterGrade = "A";

  else if (totalGrade >= 90)
    letterGrade = "A-";

  else if (totalGrade >= 87)
    letterGrade = "B+";

  else if (totalGrade >= 83)
    letterGrade = "B";

  else if (totalGrade >= 80)
    letterGrade = "B-";

  else if (totalGrade >= 77)
    letterGrade = "C+";

  else if (totalGrade >= 73)
    letterGrade = "C";

  else if (totalGrade >= 70)
    letterGrade = "C-";

  else if (totalGrade >= 67)
    letterGrade = "D+";

  else if (totalGrade >= 63)
    letterGrade = "D";

  else if (totalGrade >= 60)
    letterGrade = "D-";

  else letterGrade = "F";

  Console.WriteLine($"{currentStudent}\t\t{examGrade}\t\t{totalGrade}\t{letterGrade}\t{extraCreditGrade} ({extraCreditPoints}pts)");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
