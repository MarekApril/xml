﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp4.Models
{
    [Serializable]
    [XmlType(TypeName = "Document-Order")]
    public class Document_Order
    {
        [XmlElement("Order-Header")]
        public Order_Header OrderHeader { get; set; }
    }
}
