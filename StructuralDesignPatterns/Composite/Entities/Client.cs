using CompositePattern.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Entities
{
    internal static class Client
    {
        public static void ClientCode(BaseItem item)
        {
            Console.WriteLine($"Price: {item.GetPrice()}");
        }

        public static void ClientCode2(BaseItem itemOne, BaseItem itemTwo)
        {
            if (itemOne.IsComposite())
            {
                itemOne.Add(itemTwo);
            }
        }
    }
}
