using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PESEL { get; set; }
        public string NFZNumber { get; set; }
        public string MedicineName {get; set; }
        public string ClinicInfo { get; set; }
        public string DoctorsName { get; set; }
        public string DateOfCreating { get; set; }
    }
}
