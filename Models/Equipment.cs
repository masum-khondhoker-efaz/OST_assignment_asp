using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OST_Assignment_02.Models
{
    public class Equipment
    {

        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Member Member { get; set; }

        public Equipment()
        {
            Member = new Member();
        }

        public static List<Equipment> ListEquipment()
        {
            var equipmentList = new List<Equipment>();

            for (int i = 1; i <= 6; i++)
            {
                var equipment = new Equipment
                {
                    EquipmentId = i,
                    Name = "P " + i,
                    Quantity = i,
                    Member = new Member
                    {
                        MemberId = i,
                        MemberName = "E " + i,
                        MemberPosition = "employee " + i,
                        MemberContact = "01800000000" + i
                    }
                };
                equipmentList.Add(equipment);
            }

            return equipmentList;
        }
    }
}