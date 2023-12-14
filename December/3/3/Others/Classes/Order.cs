using _3.Others.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Others.Classes;

class Order : IOrder
{
    public int ID { get; }
    public Status Status { get; set; }
    public string OrderedItems { get; set; }
}