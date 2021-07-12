using ArandaBusiness.Services;
using ArandaBusiness.Services.Implementations;
using ArandaData.Connection;
using ArandaData.Connection.Models;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArandaTest
{
    public partial class Form1 : Form
    {
        private readonly IGenericServices _propertiesMachine;
        private readonly ArandaDbContext _db;
        PropertiesMachine propertiesMachine = new PropertiesMachine();

        public Form1(IGenericServices propertiesMachine, ArandaDbContext db)
        {
            InitializeComponent();
            _propertiesMachine = propertiesMachine;
            _db = db;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            LblVersionSystem.Text = $"Sistema Operativo: {_propertiesMachine.GetVersonSystem()}";
            LblLocalName.Text = $"Nombre de la Maquina: {_propertiesMachine.GetLocalNameHost()}";
            LblLocalIP.Text = $"Dirección IP: {_propertiesMachine.GetLocalIPAddress()}";
            LblHardDisk.Text = $"Disco Duro: {_propertiesMachine.GetLocalHardDisk()}";
            LblLocalRAM.Text = $"RAM : {_propertiesMachine.GetLocalMemoryRAM()}";
            LblProcessorName.Text = $"Procesador: {_propertiesMachine.GetProcessorName()}";
            LblDateTimeNow.Text = $"Fecha Reporte: {DateTime.Now.ToString()}";

            propertiesMachine = new PropertiesMachine
            {
                VersonSystem = LblVersionSystem.Text,
                NameHost = LblLocalName.Text,
                IPAddress = LblLocalIP.Text,
                HardDisk = LblHardDisk.Text,
                MemoryRAM = LblLocalRAM.Text,
                ProcessorName = LblProcessorName.Text,
                DateTimeNow = LblDateTimeNow.Text
            };

            var id = _propertiesMachine.Insert(propertiesMachine).Id;

            LblId.Text = id.ToString();

            var pm = _propertiesMachine.GetById(id);
            BtnExportar.Visible = true;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            _propertiesMachine.CreateFile(propertiesMachine);           
        }
    }
}
