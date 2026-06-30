




int i;
float[] th= new float[5];
float[] pr= new float[5];


float total_theory = 0;
float total_practical = 0;

for (i = 1; i <= 5; i++)
{
    Console.WriteLine("subject", i);

    Console.WriteLine("enter the theory marks ");
    th[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter the practical marks ");
    pr[i] = Convert.ToInt32(Console.ReadLine());






    total_theory += th[i];
    total_practical += pr[i];
}

    float average_theory = total_theory / 5;
    float average_practical = total_theory / 5;


    float totalmarks = total_theory + total_practical;
    float totalaverage = totalmarks / 10;


    float gpa;


    if (totalaverage >= 90) gpa = 4.0f;
    else if (totalaverage >= 80) gpa = 3.6f;
    else if (totalaverage >= 70) gpa = 3.2f;
    else if (totalaverage >= 60) gpa = 2.8f;
    else if (totalaverage >= 50) gpa = 2.4f;
    else if (totalaverage >= 40) gpa = 2.0f;
    else gpa = 0.0f;




    Console.WriteLine("theory average " + average_theory);
    Console.WriteLine("pratical average" + average_practical);

    Console.WriteLine("GPA " + gpa);


























