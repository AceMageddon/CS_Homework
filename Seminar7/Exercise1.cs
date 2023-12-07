using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar7
{
    internal class Exercise1
    {
        public List<int> list = new List<int>();
        public void CreateList()
        {
            Random random = new Random();
            for (int i = 0; i <= 100;i++)
            {
                list.Add(random.Next(0,101));
            }
        }

        public void RemoveItems()
        {
            List<int> new_list = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    new_list.Add(list[i]);
                }
            }
            list = new_list;
        }

        public String CollectionString()
        {
            String listString = "Коллекция чисел: ";
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    listString += list[i].ToString();
                }
                else
                {
                    listString = listString + ", " + list[i].ToString();
                }
            }
            return listString;
        }
    }
}
