
namespace Lab_StructuresAndClasses
{
    public class City
    {
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public int? AmountResidents { get; set; }
        public int? TelephoneCode { get; set; }
        public string? DistrictName { get; set; }
        
        public City()
        {
            this.CityName = null;
            this.CountryName = null;
            this.AmountResidents = null;
            this.TelephoneCode = null;
            this.DistrictName = null;
        }

        public City(string? cityName, string? countryName, int? amountResidents, int? telephoneCode, string? districtName)
        {
            this.CityName = cityName;
            this.CountryName = countryName;
            this.AmountResidents = amountResidents;
            this.TelephoneCode = telephoneCode;
            this.DistrictName = districtName;
        }

        public void EnterInfo()
        {
            Console.WriteLine("Enter info: ");
            Console.WriteLine("City name -> "); CityName = Console.ReadLine();
            Console.WriteLine("Country name -> "); CountryName = Console.ReadLine();
            Console.WriteLine("Amount of residents -> "); AmountResidents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Telephone code -> "); TelephoneCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("District name -> "); DistrictName = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"City name -> {CityName}\n" +
                $"Country name -> {CountryName}\n" +
                $"Amount of residents -> {AmountResidents}\n" +
                $"Telephone code -> {TelephoneCode}\n" +
                $"Name of the district -> {DistrictName}";
        }
    }
}
