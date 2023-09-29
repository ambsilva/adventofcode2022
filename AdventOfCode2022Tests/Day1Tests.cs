using AdventOfCode2022.Day1;

namespace AdventOfCode2022Tests.Day1
{

    public class Highest_calories_count
    {
        [Fact]
        public void Is_equal_to_total_calories_carried_by_the_only_existent_elf()
        {
            var caloriesCarriedByTheOnlyExistentElf = new int[] { 2300 };
            var calorieCounter = new CaloriesCounter();
            var expectedCalories = 2300;

            Assert.Equal(expectedCalories, calorieCounter.HighestCalorieCount(caloriesCarriedByTheOnlyExistentElf));
        }


        [Fact]
        public void Is_equal_to_total_calories_from_the_elf_carrying_the_highest_number_of_calories()
        {
            var caloriesCarriedBySeveralElfs = new int[] { 1200, 400, 5500, 67000, 12 };
            var calorieCounter = new CaloriesCounter();
            var expectedCalories = 67000;

            Assert.Equal(expectedCalories, calorieCounter.HighestCalorieCount(caloriesCarriedBySeveralElfs));
        }

        [Fact]
        public void Is_equal_to_zero_if_elfs_not_carrying_any_calories()
        {
            var caloriesCarriedBySeveralElfs = new int[] { };
            var calorieCounter = new CaloriesCounter();
            var expectedCalories = 0;

            Assert.Equal(expectedCalories, calorieCounter.HighestCalorieCount(caloriesCarriedBySeveralElfs));
        }
        
        [Fact]
        public void Is_zero_if_there_are_no_elfs()
        {
            var calorieCounter = new CaloriesCounter();
            var expectedCalories = 0;

            Assert.Equal(expectedCalories, calorieCounter.HighestCalorieCount(null));
        }
    }

    public class Total_of_top_3_Highest_calorie_count
    {
        [Fact]
        public void Is_equal_to_zero_if_there_are_no_calories_available()
        {
            var calorieCounter = new CaloriesCounter();
            var expectedCalories = 0;

            Assert.Equal(expectedCalories, calorieCounter.TotalTop3HighestCalorieCount(null));
        }

        [Theory]
        [InlineData(new int[] { 1200, 400 },1600)]
        [InlineData(new int[] { 1200, 400, 5500, 67000, 12, 100, 654, 90, 900, 100, 1, 3, 2, 9 }, 73700)]
        [InlineData(new int[] { 5500, 67000, 12, 100, 654 }, 73154)]
        [InlineData(new int[] { 1, 2,3,1,1,2},7)]
        [InlineData(new int[] { 10, 10,10},30)]
        [InlineData(new int[] { 10, 10, 10,10,10,10,1,2,3,3,10 }, 30)]
        [InlineData(new int[] { 1200},1200)]
        [InlineData(new int[] { }, 0)]
        public void Is_equal_to_the_sum_of_the_top_3_highest_calories_available(int[] caloriesCarriedByElfs, int expectedCalories)
        {
            var calorieCounter = new CaloriesCounter();
            Assert.Equal(expectedCalories, calorieCounter.TotalTop3HighestCalorieCount(caloriesCarriedByElfs));
        }


    }


    public class Calories_carried_by_elfs_are
    {
        [Fact]
        public void Available_if_source_data_has_one_single_numeric_value()
        {
            var expectedData = new int[] { 1200  };
            var sourceData = new string[] { "1200" };
            var foodCarriedByElfsDataReader = new FoodCarriedByElfsDataReader();

            Assert.Equal(expectedData, foodCarriedByElfsDataReader.Read(sourceData));
        }

        [Fact]
        public void Available_if_source_data_has_multiple_numeric_values_for_a_single_elf()
        {
            var expectedData = new int[] { 1700 };
            var sourceData = new string[] { "1200","200","300" };
            var foodCarriedByElfsDataReader = new FoodCarriedByElfsDataReader();

            Assert.Equal(expectedData, foodCarriedByElfsDataReader.Read(sourceData));
        }

        [Fact]
        public void Available_if_source_data_has_multiple_numeric_values_for_multiple_elfs()
        {
            var expectedData = new int[] { 1700, 1820 };
            var sourceData = new string[] { "1200", "200", "300","","100","1220","500" };
            var foodCarriedByElfsDataReader = new FoodCarriedByElfsDataReader();

            Assert.Equal(expectedData, foodCarriedByElfsDataReader.Read(sourceData));
        }

        [Fact]
        public void Not_available_if_there_is_no_source_data_available()
        {
            var expectedData = new int[] { };
            var foodCarriedByElfsDataReader = new FoodCarriedByElfsDataReader();

            Assert.Equal(expectedData, foodCarriedByElfsDataReader.Read(null));
        }

        [Fact]
        public void Not_available_if_the_only_available_source_data_is_not_numeric()
        {
            var expectedData = new int[] { };
            var sourceData = new string[] { "a" };
            var foodCarriedByElfsDataReader = new FoodCarriedByElfsDataReader();

            Assert.Equal(expectedData, foodCarriedByElfsDataReader.Read(sourceData));

        }
    }



}