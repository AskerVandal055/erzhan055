using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    internal class House
    {
            public List<Room> Rooms { get; set; }=  new List<Room>();
            public House()
            {
            Rooms.Add(new Room { Name = "Living Room" });
            Rooms.Add(new Room { Name = "Bedroom" });

            }

    }
}
