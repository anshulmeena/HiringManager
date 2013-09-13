﻿using System.Collections.Generic;

namespace HiringManager.Domain
{
    public class Manager
    {
        public int? ManagerId { get; set; }

        public IList<Position> Positions { get; set; }
 
        public IList<ContactInfo> ContactInfo { get; set; } 

        public IList<Message> Messages { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }

    }
}