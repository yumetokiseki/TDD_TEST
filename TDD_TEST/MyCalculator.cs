using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_TEST
{
    public class MyCalculator
    {
        public List<int> add(string property,int num, List<Product> items)
        {
            List<int> output = new List<int> { };

            int sum = 0;
            int group = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (group == num - 1 || i == items.Count - 1)
                {
                    sum = sum + Convert.ToInt32(items[i].GetType().GetProperty(property).GetValue(items[i], null));
                    output.Add(sum);
                    group = 0;
                    sum = 0;
                }
                else
                {
                    sum = sum + Convert.ToInt32(items[i].GetType().GetProperty(property).GetValue(items[i], null));
                    group++;
                }
            }

            return output;
        }
    }


    public class Product
    {
        public int Id { get; set; }

        public int Cost { get; set; }

        public int Revenue { get; set; }

        public int SellPrice { get; set; }
    }
}
