namespace ClinicManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── REGION 1: System Storage ─────────────────────────────────────
            // Capacity constants
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;
            // Patient slots
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
            int patientCount = 0;
            // Doctor slots
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
            int doctorCount = 0;
            // Appointment slots
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status =
            ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status =
            ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status =
            ""; bool a3Active = false;
            int appointmentCount = 0;

            //Adding Patient Variables
            string name;
            int age;
            string phone;

            // Adding Doctor Variables
            string spec;
            double fee;
            string doctorName;

            bool clinicFlag;
            bool patientFlag;
            bool doctorFlag;
            bool appointmentFlag;
            //////////////////////////////////////
            int clinicManagementSystem;
            int patientManagementSystem;
            int doctroManagementSystem;
            int appointmentManagementSystem;
            int displayNum = 0;
            string newPhone;
            double newFee;

            //Appointment variable
            int patientChoice;
            int doctorChoice;
            string chosenPatient = "";
            string chosenDoctor = "";
            string date;
            

            // Region 2 — Main Menu: the outer while loop + switch-case
            //Starting Do While Loop - Clinic Mnagement System 
           
            do
            {
                clinicFlag = false;
                Console.WriteLine("""

                    ╔══════════════════════════════════════╗
                    ║ CLINIC MANAGEMENT SYSTEM             ║
                    ╠══════════════════════════════════════╣
                    ║ 1. Patient Management                ║
                    ║ 2. Doctor Management                 ║
                    ║ 3. Appointment Management            ║
                    ║ 0. Exit                              ║
                    ╚══════════════════════════════════════╝

                    Enter your choice: 
                    """);
                clinicManagementSystem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (clinicManagementSystem)
                {
                    // Patient Management
                    case 1:
                        Console.Clear();
                        patientFlag = false;
                        //While do loop Patient Management System
                        do
                        {
                           
                            Console.WriteLine("""
                            ╔══════════════════════════════════════╗
                            ║ PATIENT MANAGEMENT                   ║
                            ╠══════════════════════════════════════╣
                            ║ 1. Add New Patient                   ║
                            ║ 2. Display All Patients              ║
                            ║ 3. Update Patient Phone              ║
                            ║ 4. Delete Patient                    ║
                            ║ 0. Back to Main Menu                 ║
                            ╚══════════════════════════════════════╝

                            """);
                            Console.WriteLine("Enter your choice: ");
                            patientManagementSystem = Convert.ToInt32(Console.ReadLine());
                            //Switch Patient Management System
                            switch (patientManagementSystem)
                            {
                                //Add New Patient
                                case 1:
                                    //Check if there is available slots to add new patient
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Clinic is full. Cannot add more patients.");
                                        Console.WriteLine("");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter your Name: ");
                                        name = Console.ReadLine();
                                        if (name == "")
                                        { 
                                            Console.WriteLine("Error, Name can't be empty!!");
                                            break; 
                                        }
                                        Console.WriteLine("Enter your Age: ");
                                        age = Convert.ToInt32(Console.ReadLine());
                                        if (age < 1 || age > 120)
                                        {
                                            Console.WriteLine("Error, Age should be greater than 1 and less than 120!!");
                                            break;
                                        }
                                        Console.WriteLine("Enter your Phone: ");
                                        phone = Console.ReadLine();

                                        if (!p1Active)
                                        {
                                            p1Name = name; p1Age = age; p1Phone = phone; p1Active = true;
                                        }
                                        else if (!p2Active)
                                        {
                                            p2Name = name; p2Age = age; p2Phone = phone; p2Active = true;
                                        }
                                        else if (!p3Active)
                                        {
                                            p3Name = name; p3Age = age; p3Phone = phone; p3Active = true;
                                        }

                                        patientCount++;
                                        Console.WriteLine("");
                                        Console.WriteLine("Patient added successfully.");
                                       

                                    }
                                    break;
                                //Display All Patients
                                case 2:
                                    if (patientCount == 0)
                                    {
                                        Console.WriteLine("No patients registered.");
                                        break;
                                    }
                                    else
                                    {
                                        if (p1Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine("Patient#" + displayNum + " || Patient Name: " 
                                                + p1Name + " || Patient Age: " + p1Age + " || Patient Phone Number: " + p1Phone);
                                        }
                                        if (p2Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine("Patient#" + displayNum + " || Patient Name: "
                                                + p2Name + " || Patient Age: " + p2Age + " || Patient Phone Number: " + p2Phone);
                                        }
                                        if (p3Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine("Patient#" + displayNum + " || Patient Name: "
                                                + p3Name + " || Patient Age: " + p3Age + " || Patient Phone Number: " + p3Phone);
                                        }
                                    }
                                    displayNum = 0;
                                    break;
                                //Update Patient Phone
                                case 3:
                                    Console.WriteLine("Enter the patient name to update: ");
                                    name = Console.ReadLine();
                                    if(p1Active && p1Name == name)
                                    {
                                        Console.WriteLine("Enter your new phone number");
                                        newPhone = Console.ReadLine();
                                        p1Phone = newPhone;
                                        Console.WriteLine("Updated!!");
                                    }
                                    else if (p2Active && p2Name == name)
                                    {
                                        Console.WriteLine("Enter your new phone number");
                                        newPhone = Console.ReadLine();
                                        p2Phone = newPhone;
                                        Console.WriteLine("Updated!!");
                                    }
                                    else if (p3Active && p3Name == name)
                                    {
                                        Console.WriteLine("Enter your new phone number");
                                        newPhone = Console.ReadLine();
                                        p3Phone = newPhone;
                                        Console.WriteLine("Updated!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }
                                    break;
                                //Delete Patient
                                case 4:
                                    Console.WriteLine("Enter the patient name to delete: ");
                                    name = Console.ReadLine();
                                    if (p1Active && p1Name == name)
                                    {
                                        p1Name = ""; p1Age = 0; p1Phone = "";
                                        patientCount--;
                                        p1Active = false;
                                        Console.WriteLine("Patient Deleted!!");
                                    }
                                    else if(p2Active && p2Name == name)
                                    {
                                        p2Name = ""; p2Age = 0; p2Phone = "";
                                        patientCount--;
                                        p2Active = false;
                                        Console.WriteLine("Patient Deleted!!");
                                    }
                                    else if( p3Active && p3Name == name)
                                    {
                                        p3Name = ""; p3Age = 0; p3Phone = "";
                                        patientCount--;
                                        p2Active = false;
                                        Console.WriteLine("Patient Deleted!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found");
                                    }
                                    break;
                                //Back to Main Menu
                                case 0:
                                    Console.WriteLine("Back to Main Menu");
                                    patientFlag = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }//END Patient Management System
 

                        } while (patientFlag != true); // END Patient Management System
                        break;

                    // Doctor Management
                    case 2:
                        Console.Clear();
                        doctorFlag = false;
                        do
                        {

                            Console.WriteLine("""
                            ╔══════════════════════════════════════╗
                            ║ DOCTOR MANAGEMENT                    ║
                            ╠══════════════════════════════════════╣
                            ║ 1. Add New Doctor                    ║
                            ║ 2. Display All Doctors               ║
                            ║ 3. Update Consultation Fee           ║
                            ║ 4. Delete Doctor                     ║
                            ║ 0. Back to Main Menu                 ║
                            ╚══════════════════════════════════════╝

                            """);
                            Console.WriteLine("Enter your choice: ");
                            doctroManagementSystem = Convert.ToInt32(Console.ReadLine());

                            switch (doctroManagementSystem)
                            {
                                //Add New Doctor
                                case 1:
                                    //Check if there is available slots to add new patient
                                    if (doctorCount == MAX_DOCTORS)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("No available doctor slots");
                                        Console.WriteLine("");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter the doctor name: ");
                                        doctorName = Console.ReadLine();
                                        if (doctorName == "")
                                        {
                                            Console.WriteLine("Error, Name can't be empty!!");
                                            break;
                                        }

                                        Console.WriteLine("Enter the doctor specialization: ");
                                        spec =Console.ReadLine();
                                        if (spec == "")
                                        {
                                            Console.WriteLine("Error, Specialization can't be empty!!");
                                            break;
                                        }

                                        Console.WriteLine("Enter the doctor fee: ");
                                        fee = Convert.ToDouble(Console.ReadLine());
                                        if (fee < 0)
                                        {
                                            Console.WriteLine("Error, Fee Can't be negative!!");
                                            break;
                                        }


                                        if (!d1Active)
                                        {
                                           d1Name = doctorName; d1Spec = spec; d1Fee = fee; d1Active = true;
                                        }
                                        else if (!d2Active)
                                        {
                                           d2Name = doctorName; d2Spec = spec; d2Fee = fee; d2Active = true;
                                        }
       
                                        doctorCount++;
                                        Console.WriteLine("");
                                        Console.WriteLine("Doctor added successfully.");
                                        Console.Clear();

                                    }
                                    break;
                                //Display All Doctors  
                                case 2:
                                    if (doctorCount == 0)
                                    {
                                        Console.WriteLine("No doctors registered.");
                                        break;
                                    }
                                    else
                                    {
                                        if (d1Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine("Doctor#" + displayNum + " || Doctor Name: "
                                                + d1Name + " || Doctor Specilization: " + d1Spec + " || Doctor Fee: " + d1Fee);
                                        }
                                        if (d2Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine("Doctor#" + displayNum + " || Doctor Name: "
                                                   + d2Name + " || Doctor Specilization: " + d2Spec + " || Doctor Fee: " + d2Fee);
                                        }
                                    }
                                    displayNum = 0;
                                    break;
                                //Update Consultation Fee
                                case 3:
                                    Console.WriteLine("Enter the doctor name to update: ");
                                    doctorName = Console.ReadLine();
                                    if (d1Active && d1Name == doctorName)
                                    {
                                        Console.WriteLine("Enter the new consultation fee: ");
                                        newFee = Convert.ToDouble(Console.ReadLine());
                                        d1Fee = newFee;
                                        Console.WriteLine("Updated!!");
                                    }
                                    else if (d2Active && d2Name == doctorName)
                                    {
                                        Console.WriteLine("Enter the new consultation fee: ");
                                        newFee = Convert.ToDouble(Console.ReadLine());
                                        d2Fee = newFee;
                                        Console.WriteLine("Updated!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }
                                    break;

                                //Delete Doctor
                                case 4:
                                    Console.WriteLine("Enter the doctor name to delete: ");
                                    doctorName = Console.ReadLine();
                                    if (d1Active && d1Name == doctorName)
                                    {
                                        d1Name = ""; d1Spec = ""; d1Fee = 0;
                                        doctorCount--;
                                        d1Active = false;
                                        Console.WriteLine("Doctor Deleted!!");
                                    }
                                    else if (d2Active && d2Name == doctorName)
                                    {
                                        d2Name = ""; d2Spec = ""; d2Fee = 0;
                                        doctorCount--;
                                        d2Active = false;
                                        Console.WriteLine("Doctor Deleted!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found");
                                    }
                                    break;
                                //Back to Main Menu
                                case 0:
                                    Console.WriteLine("Back to Main Menu");
                                    doctorFlag = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }


                        } while (doctorFlag != true);
                        break;

                    // Appointment Management 
                    case 3:
                        //Appointment Do while loop
                        Console.Clear();
                        appointmentFlag = false;
                        do
                        {

                            Console.WriteLine("""
                            ╔══════════════════════════════════════╗
                            ║ APPOINTMENT MANAGEMENT               ║
                            ╠══════════════════════════════════════╣
                            ║ 1. Book New Appointment              ║
                            ║ 2. Display All Appointments          ║
                            ║ 3. Update Appointment Status         ║
                            ║ 4. Cancel Appointment                ║
                            ║ 0. Back to Main Menu                 ║
                            ╚══════════════════════════════════════╝

                            """);
                            Console.WriteLine("Enter your choice: ");
                            appointmentManagementSystem = Convert.ToInt32(Console.ReadLine());
                             
                            // Switch Appointment Management System
                            switch (appointmentManagementSystem)
                            {
                                //Book New Appointment 
                                case 1:
                                    if (appointmentCount == MAX_APPOINTMENTS)
                                    {
                                        Console.WriteLine("No available appointment slots.");
                                        break;
                                    }
                                    else if (patientCount == 0 || doctorCount == 0)
                                    {
                                        Console.WriteLine("Please add patients and doctors first"); 
                                        break;
                                    }
                                    else
                                    {
                                        

                                        if (p1Active)
                                        {
                                            
                                            Console.WriteLine(" 1. Patient Name: "
                                                + p1Name + " || Patient Age: " + p1Age + " || Patient Phone Number: " + p1Phone);
                                        }
                                        if (p2Active)
                                        {
                                            
                                            Console.WriteLine("2. Patient Name: "
                                                + p2Name + " || Patient Age: " + p2Age + " || Patient Phone Number: " + p2Phone);
                                        }
                                        if (p3Active)
                                        {
                                            
                                            Console.WriteLine("3. Patient Name: "
                                                + p3Name + " || Patient Age: " + p3Age + " || Patient Phone Number: " + p3Phone);
                                        }

                                       
                                        Console.WriteLine("");
                                        Console.WriteLine("Enter the patient number: ");
                                        patientChoice = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("");

                                        switch (patientChoice)
                                        {
                                            //Patient 1 Choice: 
                                            case 1:
                                                if (p1Active)
                                                {
                                                    chosenPatient = p1Name;
                                                    
                                                }
                                                else
                                                {
                                                    Console.WriteLine("This patient is not Active!!");
                                                    
                                                }
                                                break;
                                            //Patient 2 Choice: 
                                            case 2:
                                                if (p2Active)
                                                {
                                                    chosenPatient = p2Name;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("This patient is not Active!!");

                                                }
                                                break;
                                            //Patient 3 Choice: 
                                            case 3:
                                                if (p3Active)
                                                {
                                                    chosenPatient = p3Name;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("This patient is not Active!!");

                                                }
                                                break;

                                            default:
                                                Console.WriteLine("Invalid Choice!!");
                                                break;
                                        }

                                        

                                        if (d1Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine( "1. Doctor Name: "
                                                + d1Name + " || Doctor Specilization: " + d1Spec + " || Doctor Fee: " + d1Fee);
                                        }
                                        if (d2Active)
                                        {
                                            displayNum++;
                                            Console.WriteLine("2. Doctor Name: "
                                                   + d2Name + " || Doctor Specilization: " + d2Spec + " || Doctor Fee: " + d2Fee);
                                        }


                                        Console.WriteLine("");
                                        Console.WriteLine("Enter the doctor number: ");
                                        patientChoice = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("");

                                        switch (patientChoice)
                                        {
                                            //Doctor 1 Choice: 
                                            case 1:
                                                if (d1Active)
                                                {
                                                    chosenDoctor = d1Name;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("This Doctor is not Active!!");

                                                }
                                                break;
                                            //Doctor 2 Choice: 
                                            case 2:
                                                if (d2Active)
                                                {
                                                    chosenDoctor = d2Name;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("This Doctor is not Active!!");

                                                }
                                                break;

                                            default:
                                                Console.WriteLine("Invalid Choice!!");
                                                break;
                                        }


                                        Console.WriteLine("Enter the apointment date DD/MM/YYYY: ");
                                        date = Console.ReadLine();

                                        if (a1Active && a1Patient == chosenPatient && a1Doctor == chosenDoctor && a1Date == date)
                                        {
                                            Console.WriteLine("Duplicate appointment.");
                                        }
                                        else if (a2Active && a2Patient == chosenPatient && a2Doctor == chosenDoctor && a2Date == date)
                                        {
                                            Console.WriteLine("Duplicate appointment.");
                                        }
                                        else if (a3Active && a3Patient == chosenPatient && a3Doctor == chosenDoctor && a3Date == date)
                                        {
                                            Console.WriteLine("Duplicate appointment.");
                                        }
                                        else
                                        {
                                            if (!a1Active)
                                            {
                                                a1Patient = chosenPatient; a1Doctor = chosenDoctor; 
                                                a1Date = date; a1Status = "Scheduled"; a1Active = true;
                                            }
                                            else if (!a2Active)
                                            {
                                                a2Patient = chosenPatient; a2Doctor = chosenDoctor;
                                                a2Date = date; a2Status = "Scheduled"; a2Active = true;
                                            }
                                            else if (!a3Active)
                                            {
                                                a3Patient = chosenPatient; a3Doctor = chosenDoctor;
                                                a3Date = date; a3Status = "Scheduled"; a3Active = true;
                                            }
                                            appointmentCount ++;
                                            Console.WriteLine("Appointment booked.");
                                        }

                                    }
                                    break;
                                //Display All Appointments
                                case 2:
                                    Console.WriteLine("2. Display All Appointments ");
                                    break;
                                //Update Appointment Status
                                case 3:
                                    Console.WriteLine("3. Update Appointment Status");
                                    break;
                                //Cancel Appointment
                                case 4:
                                    Console.WriteLine("4. Cancel Appointment");
                                    break;
                                //Back to Main Menu
                                case 0:
                                    Console.WriteLine("Back to Main Menu");
                                    appointmentFlag = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }// END Appointment Management System

                            

                        } while (appointmentFlag != true); // END Do while loop 
                        break;

                    //Stoping the system
                    case 0:
                        Console.WriteLine("Thank you for using our system.");
                        clinicFlag = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
            } while (clinicFlag != true);// END do while loop - Clinic Mnagement System 








        }
    }
}
