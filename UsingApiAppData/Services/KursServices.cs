    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingApiAppData.Models;

namespace UsingApiAppData.Services
{
    public class KursServices : IKursServices
    {
        List<Kurs> kurslar;
        public KursServices()
        {
            kurslar = new List<Kurs>()
            {
                new Kurs()
                {
                    Id = 1,
                    Name = "USD",
                    Rate = 11350
                },
                new Kurs()
                {
                    Id = 2,
                    Name = "EUR",
                    Rate = 13100
                },
                new Kurs()
                {
                    Id = 3,
                    Name = "RUB",
                    Rate = 180
                }
            };
        }
        public List<Kurs> GetAll() => kurslar;
        public Kurs GetById(int id) => kurslar.FirstOrDefault(x => x.Id == id);
    }
}
