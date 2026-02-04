namespace FirstApp_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("키를 입력하세요");
            int height_cm = int.Parse(Console.ReadLine());

            Console.WriteLine("몸무게를 입력하세요");
            int weight = int.Parse(Console.ReadLine());

            float height_m = height_cm / 100f;

            double bmi = weight / (height_m * height_m);
            string bmi_str = bmi.ToString("0.00");

            if (bmi < 18.5)
            {
                Console.WriteLine($"저체중입니다. BMI: {bmi_str}");
            }
            else if (bmi < 24.9)
            {
                Console.WriteLine($"정상체중입니다. BMI: {bmi_str}");
            }
            else
            {
                Console.WriteLine($"과체중입니다. BMI: {bmi_str}");
            }
        }
    }
}
