namespace Assignment5
{
    public class NumericFunctions
    {
        public NumericFunctions()
        {
            Console.WriteLine("WELCOME");
        }
        public int Add(params int[] numbers)
        {
            int sum = 0;
            try
            {
                foreach (int i in numbers)
                {
                    sum += i;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return sum;
        }
        public int Sub(params int[] numbers)
        {
            int sub = 0;
            int result;
            try
            {
                foreach (int i in numbers)
                {
                    sub = i - sub;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return sub;
        }
        public int Mul(params int[] numbers)
        {
            int mul = 1;
            try
            {
                foreach (int i in numbers)
                {
                    mul *= i;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return mul;
        }

        public float Div(float n1, float n2)
        {
            float div = 10f;

            try
            {
                div = n1 / n2;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return div;
        }

        public double Max(params double[] numbers)
        {
            double max = 0;
            try
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    max = numbers[0];
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        
            return max;

        }

        public double Min(params double[]numbers )
        {
            double min = 0;
            try
            {
                min = numbers[0];
                for(int i=1;i<numbers.Length; i++)
                {
                    if(min > numbers[i])
                    {
                        min = numbers[i];
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return min;
        }

        public bool IsEven(int n)
        {
            bool isEven = false;
            try
            {
                if(n%2 == 0)
                {
                    isEven = true;
                    //return true;
                }
                else
                {
                    isEven = false;
                    //return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isEven;
        }

        public bool IsOdd(int n)
        {
            bool isOdd = false;
            try
            {
                if (n % 2 != 0)
                {
                    isOdd = true;
                    //return true;
                }
                else
                {
                    isOdd = false;
                    //return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isOdd;
        }
        public bool IsPrime(int number)
        { 
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }


}

