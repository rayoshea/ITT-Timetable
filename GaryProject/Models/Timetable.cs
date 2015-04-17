using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GaryProject.Models
{
    public class Timetable
    {
        public int ID { get; set; }

        public DateTime Time { get; set; }
        public string RoomNumber { get; set; }
        public string Subject { get; set; }
        public string Lecturer { get; set; }
        public string School { get; set; }
        public bool Availability { get; set; }
        public bool Holiday { get; set; }
    }
}
