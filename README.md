Cwiczenie bazujące na MsLearn:
(https://learn.microsoft.com/en-us/training/modules/challenge-project-arrays-iteration-selection/2-prepare)

Project specification
The Starter code project for this module is a C# console application that implements the following code features:

• Uses arrays to store student names and assignment scores.
• Uses a foreach statement to iterate through the student names as an outer program loop.
• Uses an if statement within the outer loop to identify the current student's name and access that student's assignment scores.
• Uses a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
• Uses an algorithm within the outer loop to calculate the average exam score for each student.
• Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

Integrates extra credit scores when calculating the student's final score and letter grade as follows:

• Detects extra credit assignments based on the number of elements in the student's scores array.
• Applies a 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

Your goal in this challenge is to implement the coding updates required to produce the teacher's requested score report.
The current score report lists the student's name followed by the calculated overall grade and letter grade. Here is the existing report format:

Output
Student         Grade   Letter Grade

Sophia          95.6    A
Andrew          91.6    A-
Emma            89.2    B+
Logan           93      A

In addition to the student's final numeric score and letter grade, the teacher wants the updated report to include the exam score and the impact that extra credit work has on the student's final grade. The format of the updated score report should appear as follows:

Output
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
