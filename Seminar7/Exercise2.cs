using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar7
{
    internal class Exercise2
    {
        public Dictionary<int, string> dict = new Dictionary<int, string>();
        
        public void CreateDictionary(int phoneNumber, String fullname)
        {
            dict.Add(phoneNumber, fullname);
        }

        public String DictionaryFindById(int id)
        {
            String searchResult = "";
            if (dict.ContainsKey(id))
            {
                searchResult = dict[id];
            }
            else
            {
                searchResult = "Данного пользователя нет";
            }
            return searchResult;
        }

        public String DictionaryString()
        {
            String dictString = "";
            foreach (KeyValuePair<int, string> kvp in dict) { dictString =  dictString + kvp.Key + ": " + kvp.Value + ", "; }
            return dictString;
        }

    }
}
