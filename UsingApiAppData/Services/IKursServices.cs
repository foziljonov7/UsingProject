using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingApiAppData.Models;

namespace UsingApiAppData.Services
{
    public interface IKursServices
    {
        List<Kurs> GetAll();
        Kurs GetById(int id);
    }
}
