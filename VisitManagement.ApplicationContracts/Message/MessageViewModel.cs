﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.ApplicationContracts.Message
{
    public class MessageViewModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public string VisitID { get; set; }
        public string FamilyOS { get; set; }
        public string FamilyDevice { get; set; }
    }
}
