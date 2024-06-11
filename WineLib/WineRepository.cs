using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineLib
{
    public class WineRepository
    {
        private int nextId = 6;
        private List<Wine> wines = new List<Wine>
        {
            new Wine { Id = 1, Manufacturer = "Brunello, Uggiano", Year = 2015, Price = 259, Rating = 4 },
            new Wine { Id = 2, Manufacturer = "Gigino 80", Year = 2016, Price = 199, Rating = 4 },
            new Wine { Id = 3, Manufacturer = "Chianti, Caffaggio", Year = 2019, Price = 200, Rating = 3 },
            new Wine { Id = 4, Manufacturer = "Crognolo", Year = 2014, Price = 249, Rating = 3 },
            new Wine { Id = 5, Manufacturer = "Mate, Mantus", Year = 2023, Price = 169, Rating = 0 },
        };
        public Wine GetById(int id)
        {
            Wine? wine = wines.FirstOrDefault(w => w.Id == id);
            if (wine == null)
            {
                throw new ArgumentException("Wine not found");
            }
            return wine;
        }
        public List<Wine> GetAll(string? manufacturer = null, int year = 0, int price = 0, decimal rating = 0)
        {
            IEnumerable<Wine> result = wines;

            if (manufacturer != null)
            {
                result = result.Where(w => w.Manufacturer == manufacturer);
            }
            if (year > 0)
            {
                result = result.Where(w => w.Year == year);
            }
            if (price > 0)
            {
                result = result.Where(w => w.Price == price);
            }
            if (rating >= 2 && rating <= 5)
            {
                result = result.Where(w => w.Rating >= 2 && w.Rating <= 5);
            }

            return result.ToList();
        }
        public Wine Add(Wine wine)
        {
            wine.validate();
            wine.Id = nextId++;
            wines.Add(wine);
            return wine;
        }
        public Wine Delete(int id)
        {
            Wine wine = GetById(id);
            wines.Remove(wine);
            return wine;
        }
        public Wine Update(int id, Wine updateWine)
        {
            Wine wine = GetById(id);
            wine.Manufacturer = updateWine.Manufacturer;
            wine.Year = updateWine.Year;
            wine.Price = updateWine.Price;
            wine.Rating = updateWine.Rating;
            return wine;
        }
    }
}
