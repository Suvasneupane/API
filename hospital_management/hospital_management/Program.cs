using hospital_management.Hospital;

Console.WriteLine("Welcome to ABC Hospital");

string type;

do
{
    Console.WriteLine();
    Console.Write("Who are you? Doctor or Patient: ");
    type = Console.ReadLine().ToLower();

    if (type == "doctor")
    {
        int choice;
        Doctor dr = new Doctor();

        do
        {
            Console.WriteLine();
            Console.WriteLine("Doctor Menu");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. View Details");
            Console.WriteLine("5. Back");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: dr.add(); break;
                case 2: dr.edit(); break;
                case 3: dr.delete(); break;
                case 4: dr.details(); break;
                case 5: break;
                default: Console.WriteLine("Invalid Choice"); break;
            }

        } while (choice != 5);
    }

    else if (type == "patient")
    {
        int choice;
        Patient pi = new Patient();
        Appoinment a = new Appoinment();

        do
        {
            Console.WriteLine();
            Console.WriteLine("Patient Menu");
            Console.WriteLine("0. Registration");
            Console.WriteLine("1. Patient Details");
            Console.WriteLine("2. Edit Patient");
            Console.WriteLine("3. Delete Patient");
            Console.WriteLine("4. Back");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    a.appoinment_date();
                    pi.patient_details();
                    break;

                case 1:
                    pi.patient_display();
                    break;

                case 2:
                    pi.patient_edit();
                    break;

                case 3:
                    pi.patient_delete();
                    break;
            }

        } while (choice != 4);
    }

} while (type == "doctor" || type == "patient");