using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._3._2
{
    internal class ComparableListData : IComparable<ComparableListData>
    {
        public int IdNumber { get; set; }
        public string Name { get; set; }

        public ComparableListData(int idNumber, string name)
        {
            IdNumber = idNumber;
            Name = name;
        }

        public int CompareTo(ComparableListData other)
        {
            if (other == null) return 1;
            return IdNumber.CompareTo(other.IdNumber);
        }
    }

    public class SuperCollection<T> : List<T> where T : IComparable<T>
    {
        public new void Add (T item)
        {
            base.Add(item);
            Sort();
        }
    }
}