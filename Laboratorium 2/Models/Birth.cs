namespace Laboratorium_2.Models

{
    public class Birth
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && BirthDate.HasValue && BirthDate < DateTime.Now;
        }

        public int CalculateAge()
        {
            if (BirthDate.HasValue)
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - BirthDate.Value.Year;

                if (currentDate.Month < BirthDate.Value.Month || (currentDate.Month == BirthDate.Value.Month && currentDate.Day < BirthDate.Value.Day))
                {
                    age--;
                }

                return age;
            }

            return 0;
        }
    }
}
