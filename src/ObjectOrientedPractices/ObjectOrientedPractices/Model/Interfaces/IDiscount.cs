using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ObjectOrientedPractices.Model.Classes;

namespace ObjectOrientedPractices.Model.Interfaces
{
    public interface IDiscount
    {
        string Info { get; }
        double Calculate(BindingList<Item> items);
        double Apply(BindingList<Item> items);
        void Update(BindingList<Item> items);
    }
}
