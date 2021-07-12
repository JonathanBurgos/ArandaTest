using ArandaBusiness.Repositories;
using ArandaData.Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaBusiness.Services.Implementations
{
    public class GenericServices : IGenericServices 
    {
        private readonly IGenericRepository _genericRepository;

        public GenericServices(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<PropertiesMachine> GetById(int id)
        {
            return await _genericRepository.GetById(id);
        }

        public async Task<PropertiesMachine> Insert(PropertiesMachine entity)
        {
            return await _genericRepository.Insert(entity);
        }

        public string GetLocalHardDisk()
        {
            return _genericRepository.GetLocalHardDisk();
        }

        public string GetLocalIPAddress()
        {
            return _genericRepository.GetLocalIPAddress();
        }

        public string GetLocalMemoryRAM()
        {
            return _genericRepository.GetLocalMemoryRAM();
        }

        public string GetLocalNameHost()
        {
            return _genericRepository.GetLocalNameHost();
        }

        public string GetProcessorName()
        {
            return _genericRepository.GetProcessorName();
        }

        public string GetVersonSystem()
        {
            return _genericRepository.GetVersonSystem();
        }

        public void CreateFile(PropertiesMachine propertiesMachine)
        {
            _genericRepository.CreateFile(propertiesMachine);
        }
    }
}
