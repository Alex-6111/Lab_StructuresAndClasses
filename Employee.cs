
namespace Lab_StructuresAndClasses
{
    public class Employee
    {
        public string? FullName { get; set; }
        public string? DateBirth { get; set; }
        public string? ContactNumber { get; set; }
        public string? WorkEmail { get; set; }
        public string? Position { get; set; }
        public string? JobDescription { get; set; }

        public Employee()
        {
            this.FullName = null;
            this.DateBirth = null;
            this.ContactNumber = null;
            this.WorkEmail = null;
            this.Position = null;
            this.JobDescription = null;
        }

        public Employee(string? fullName, string? dateBirth, string? contactNumber, string? workEmail, string? position, string? jobDescription)
        {
            FullName = fullName;
            DateBirth = dateBirth;
            ContactNumber = contactNumber;
            WorkEmail = workEmail;
            Position = position;
            JobDescription = jobDescription;
        }

        public void EnterInfo()
        {
            Console.WriteLine("Enter info: ");
            Console.WriteLine("Full name -> "); FullName = Console.ReadLine();
            Console.WriteLine("Date of birth -> ");  DateBirth = Console.ReadLine();
            Console.WriteLine("Contact number -> "); ContactNumber = Console.ReadLine();
            Console.WriteLine("Work email -> "); WorkEmail = Console.ReadLine();
            Console.WriteLine("Position -> "); Position = Console.ReadLine();
            Console.WriteLine("Job description -> "); JobDescription = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Full name -> {FullName}\n" +
                $"Date of birth -> {DateBirth}\n" +
                $"Contact number -> {ContactNumber}\n" +
                $"Work email -> {WorkEmail}\n" +
                $"Job title -> {Position}\n" +
                $"Job description -> {JobDescription}";
        }
    }
}
