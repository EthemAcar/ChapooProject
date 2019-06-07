﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel.Models
{
    public class OrderItem
    {
        public List<MenuItem> MenuItem { get; set; }
        public int Aantal { get; set; }
        public int Menu_ID { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        
    }
}
