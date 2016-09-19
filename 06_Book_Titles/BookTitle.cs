using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Book_Titles
{
    class Book
    {
        private String   title;
        private String[] capitalizeExceptions = { "the", "a", "an", "and", "or", "in", "of" };

        public String Title {
            get{ 
                return title;
            }
            set{
                title = UpperFirst(value.Split(' '));
            }
        }

        private String UpperFirst(String value){
            return value.Substring(0,1).ToUpper() + value.Substring(1);
        }

        private String UpperFirst(String[] values){
            List<String> valueList = new List<String>();

            foreach(String value in values){
                if(capitalizeExceptions.Contains(value))
                    valueList.Add(value);
                else
                    valueList.Add(UpperFirst(value));
            }

            return UpperFirst(String.Join(" ", valueList.ToArray()));
        }


    }
}
