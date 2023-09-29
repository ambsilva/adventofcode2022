using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1
{
    public class CaloriesCounter
    {
        public int HighestCalorieCount(int[]? calories)
        {
            return calories != null && calories .Length > 0 ? calories.Max() : 0;
        }

        public int TotalTop3HighestCalorieCount(int[]? calories)
        {
            var sumTop3 = 0;
            if (calories != null)
            {
                var caloriesList = calories.ToList();
                var countOfAllCaloriesInTheList = calories.Length;
                for (int i = 0; (i < countOfAllCaloriesInTheList) && (i < 3); i++)
                {
                    var highest = HighestCalorieCount(caloriesList.ToArray());
                    sumTop3 += highest;
                    caloriesList.Remove(highest);
                }
            }
            return sumTop3;
        }

    }

}
