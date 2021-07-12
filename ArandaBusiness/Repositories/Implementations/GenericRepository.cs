using ArandaData.Connection;
using ArandaData.Connection.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ArandaBusiness.Repositories.Implementations
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ArandaDbContext _db;

        public GenericRepository(ArandaDbContext db)
        {
            db.Database.EnsureCreatedAsync();
            _db = db;
        }
        public async Task<PropertiesMachine> GetById(int id)
        {
            return await _db.propertiesMachines.FindAsync(id);
        }

        public async Task<PropertiesMachine> Insert(PropertiesMachine entity)
        {
            _db.propertiesMachines.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No hay adaptadores de red en el sistema");
        }

        public string GetLocalNameHost()
        {
            var name = Environment.MachineName;
            if (string.IsNullOrEmpty(name))
                throw new Exception("Error al obtener el nombre de la Maquina.");

            return name;
        }

        public string GetLocalHardDisk()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    var totalSize = FormatBytes(drive.TotalSize);
                    return totalSize;
                }
            }

            throw new Exception("Error al obtener la propiedades del disco duro");
        }


        public string GetVersonSystem()
        {
            OperatingSystem os_info = Environment.OSVersion;
            if (string.IsNullOrEmpty(os_info.VersionString))
                throw new Exception("Error al Obtener el sistema operativo");

            return os_info.VersionString;
        }

        public string GetLocalMemoryRAM()
        {
            var query = "SELECT Capacity FROM Win32_PhysicalMemory";
            var searcher = new ManagementObjectSearcher(query);
            foreach (var WniPART in searcher.Get())
            {
                var capacity = Convert.ToInt64(WniPART.Properties["Capacity"].Value);
                var capacityGB = FormatBytes(capacity);
                return capacityGB;
            }

            throw new Exception("");
        }

        public string GetProcessorName()
        {
            var query = "SELECT * FROM Win32_Processor";
            var searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject mo in searcher.Get())
            {
                return mo["Name"].ToString();
            }
            throw new NotImplementedException();
        }

        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }
            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public void CreateFile(PropertiesMachine propertiesMachine)
        {
            string fileName = $"aplicativo_aranda_{DateTime.Now.ToString("yy-MM-dd_HH-mm-ss")}.txt";
            string fullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName;
            if (!File.Exists(fullName))
            {
                using (StreamWriter writer = File.CreateText(fullName))
                {
                    writer.WriteLine(propertiesMachine.VersonSystem);
                    writer.WriteLine(propertiesMachine.NameHost);
                    writer.WriteLine(propertiesMachine.IPAddress);
                    writer.WriteLine(propertiesMachine.HardDisk);
                    writer.WriteLine(propertiesMachine.MemoryRAM);
                    writer.WriteLine(propertiesMachine.ProcessorName);
                    writer.WriteLine(propertiesMachine.DateTimeNow);
                }
            }
        }
    }
}
