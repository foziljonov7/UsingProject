using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingApiAppData.Models;

namespace UsingApiAppData.Services
{
    public interface ICreditServices
    {
        List<Credit> GetCreditAll();
        Credit GetCreditById(int Id);
        Credit GetCreditSearch(string FullName);
    }
}
