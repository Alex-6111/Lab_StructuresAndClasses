
namespace Lab_StructuresAndClasses
{
    public class Airplane
    {
        public string? AircraftName { get; set; }
        public string? ManufacturersName { get; set; }
        public int? YearIssue { get; set; }
        public string? AircraftType { get; set; }

        public Airplane()
        {
            this.AircraftName = null;
            this.ManufacturersName = null;
            this.YearIssue = null;
            this.AircraftType = null;
        }
        public Airplane(string? aircraftName, string? manufacturersName, int? yearIssue, string? aircraftType)
        {
            AircraftName = aircraftName;
            ManufacturersName = manufacturersName;
            YearIssue = yearIssue;
            AircraftType = aircraftType;
        }

        public void EnterInfo()
        {
            Console.WriteLine("Enter info: ");
            Console.WriteLine("Aircraft name -> "); AircraftName = Console.ReadLine();
            Console.WriteLine("Manufacturers name -> "); ManufacturersName = Console.ReadLine();
            Console.WriteLine("Year issue -> "); YearIssue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aircraft type -> "); AircraftType = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Aircraft name -> {AircraftName}\n" +
                $"Manufacturer's name -> {ManufacturersName}\n" +
                $"Year of issue -> {YearIssue}\n" +
                $"Aircraft type -> {AircraftName}";
        }
    }
}
