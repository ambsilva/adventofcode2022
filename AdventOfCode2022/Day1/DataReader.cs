using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1
{
    public class FoodCarriedByElfsDataReader
    {
        public FoodCarriedByElfsDataReader()
        {
        }

        public int[] Read(string[]? sourceData)
        {
            var returnValue = new int[] { };
            int calorie = 0;
            var entireCalorieList = new List<int>();
            int totalCaloriesByElf = 0;
            if (sourceData != null)
            {
                for (int i = 0; i < sourceData.Length; i++)
                {
                    if (int.TryParse(sourceData[i], out calorie))
                    {
                        totalCaloriesByElf += calorie;
                    }
                    else
                    {
                        if (totalCaloriesByElf > 0) entireCalorieList.Add(totalCaloriesByElf);
                        totalCaloriesByElf = 0;
                    }
                }
                if (totalCaloriesByElf > 0) entireCalorieList.Add(totalCaloriesByElf);
                returnValue = entireCalorieList.ToArray();
            }
            return returnValue;
        }
    }


}
