using System.Text;

namespace CalorieCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                short age = ConsoleHelper.GetInput<short>("👉 Please enter your age: ");
                char gender = ConsoleHelper.GetInput<char>("👉 Please enter your gender (m/f): ");
                int height = ConsoleHelper.GetInput<int>("👉 Please enter your height in centimeters: ");
                int weight = ConsoleHelper.GetInput<int>("👉 Please enter your weight in kilograms: ");

                Console.Clear();

                Console.WriteLine("1. Sedentary\n" +
                                  "2. Lightly active (1–3 days of light exercise per week)\n" +
                                  "3. Moderately active (3–5 days of moderate exercise per week)\n" +
                                  "4. Very active (6–7 days of vigorous exercise per week)\n");

                byte act = ConsoleHelper.GetInput<byte>("👉 Please select your activity level: ");

                double bmr = BmrCalc(age, gender, height, weight);

                if (double.IsNaN(bmr))
                {
                    Console.WriteLine("\n⚠️ Invalid gender input. Program terminated.");
                    return;
                }

                double tdee = 0;

                switch (act)
                {
                    case 1: tdee = bmr * 1.2; break;
                    case 2: tdee = bmr * 1.375; break;
                    case 3: tdee = bmr * 1.55; break;
                    case 4: tdee = bmr * 1.725; break;
                    default:
                        Console.WriteLine("\n⚠️ Invalid Activity Level Selected.");
                        return;
                }

                Console.WriteLine($"\n✅ Your Basal Metabolic Rate (BMR): {Math.Round(bmr)} kcal");
                Console.WriteLine($"✅ Your Total Daily Energy Expenditure (TDEE): {Math.Round(tdee)} kcal");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error has occured: {ex.Message}");
            }
        }

        public static double BmrCalc(short age, char gender, int height, int weight)
        {
            double bmr;

            if (char.ToLower(gender) == 'm')
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            }
            else if (char.ToLower(gender) == 'f')
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            }
            else
                return double.NaN;

            return bmr;
        }
    }
}