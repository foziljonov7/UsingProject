using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingApiAppData.Models;

namespace UsingApiAppData.Services
{
    public class CreditServices : ICreditServices
    {
        List<Credit> _creditList;
     
        public CreditServices()
        {
            _creditList = new List<Credit>()
            {
                new Credit()
                {
                    Id = 1,
                    FullName = "Anvar",
                    MaxCredit = 10000,
                    CreditId = 1,
                    credit = 5000,
                    Location = "Fergana",
                    Lender = "Xumoyun",
                    Time = DateTime.Now,
                },
                new Credit()
                {
                    Id = 2,
                    FullName = "Avaz",
                    MaxCredit = 10000,
                    CreditId = 1,
                    credit = 8000,
                    Location = "Andijan",
                    Lender = "Zikirullo",
                    Time = DateTime.Now,
                },
                 new Credit()
                {
                    Id = 3,
                    FullName = "Avazbe",
                    MaxCredit = 5000,
                    CreditId = 3,
                    credit = 8000,
                    Location = "Andijan",
                    Lender = "Zikirullo",
                    Time = DateTime.Now,
                },
            };
        }
        public List<Credit> GetCreditAll() => _creditList;
        public Credit GetCreditById(int id)
        { 
            return _creditList.FirstOrDefault(x => x.Id == id);
        }

        public Credit GetCreditSearch(string FullName) => _creditList.FirstOrDefault(p=>p.FullName == FullName);
    }
}
