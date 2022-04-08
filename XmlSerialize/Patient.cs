using System;
using System.Collections.Generic;
using System.Text;

namespace XmlSerialize
{
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int RoomNo { get; set; }
    }
}
