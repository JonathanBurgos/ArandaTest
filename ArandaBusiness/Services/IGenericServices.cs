using ArandaData.Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaBusiness.Services
{
    public interface IGenericServices
    {
        Task<PropertiesMachine> GetById(int id);
        Task<PropertiesMachine> Insert(PropertiesMachine entity);

        void CreateFile(PropertiesMachine propertiesMachine);
        string GetLocalIPAddress();
        string GetLocalNameHost();
        string GetLocalHardDisk();
        string GetVersonSystem();
        string GetLocalMemoryRAM();
        string GetProcessorName();
    }
}
