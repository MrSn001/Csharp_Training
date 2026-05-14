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

            bool flag = false;
            int clinicManagementSystem;


            // Region 1:
            //Starting Do While Loop - Clinic Mnagement System 
            do
            {
                flag = false;
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
                        break;

                    // Doctor Management
                    case 2:
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
                        break;

                    // Appointment Management 
                    case 3:
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
                        break;

                    //Stoping the system
                    case 0:
                        Console.WriteLine("Thank you for using our system.");
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (flag != true);// END do while loop - Clinic Mnagement System 








        }
    }
}
