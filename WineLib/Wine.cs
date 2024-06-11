namespace WineLib
{
    public class Wine
    {
        public int Id { get; set; }
        public string ? Manufacturer { get; set; }//min 2 chars
        public int Year { get; set; }
        public int Price { get; set; }// positive number
        public decimal Rating { get; set; } // min 2 max 5

        public override string ToString()
        {
            return $"Id: {Id}, Manufacturer: {Manufacturer}, Year: {Year}, Price: {Price}, Rating: {Rating}";
        }

        public void ValidateManufacturer()
        {
            if(string.IsNullOrEmpty(Manufacturer))
            { 
                throw new ArgumentException("Manufacturer is required"); 
            }
            if (Manufacturer.Length < 2)
            {
                throw new ArgumentException("Manufacturer must be at least 2 characters long");
            }
        }
        public void ValidateYear()
        {
            if (Year < 0)
            {
                throw new ArgumentException("Year must be a positive number");
            }
        }
        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new ArgumentException("Price must be a positive number");
            }
        }
        public void ValidateRating()
        {
            if (Rating < 2 || Rating > 5)
            {
                throw new ArgumentException("Rating must be between 2 and 5");
            }
        }
        public void validate()
        {
            ValidateManufacturer();
            ValidateYear();
            ValidatePrice();
            ValidateRating();
        }
    }
}
