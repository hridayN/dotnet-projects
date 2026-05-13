using System;
namespace LeetCodes
{
	public class IntegerProblems
	{
		public IntegerProblems()
		{
		}

        public bool IsPalindrome(int x)
        {
			bool isPalindrome = true;

			if (x < 0)
                return false;

            Dictionary<int, int> digits = GetDigits(x);
			if (digits.Any())
			{
                int frontCounter = 0;
                int endCounter = digits.Count-1;
				while (frontCounter < endCounter)
				{
					if (digits.ElementAt(frontCounter).Value != digits.ElementAt(endCounter).Value)
					{
						isPalindrome = false;
						return isPalindrome;
                    }
					frontCounter++;
					endCounter--;
				}
            }

            return isPalindrome;
        }

		public Dictionary<int, int> GetDigits(int num)
		{
			Dictionary<int, int> values = new();
			int key = 1;
            while (num >= 1)
			{
				values.Add(key, num % 10);
                num /= 10;
				key++;
			}
			return values;
		}

        public int RomanToInt(string s)
        {
			Dictionary<string, int> romansToInt = new Dictionary<string, int>{
			{"I", 1}, 
            {"V", 5},
            {"X", 10},
			{"L", 50},
			{"C", 100}, 
            {"D", 500},
			{"M", 1000},
            {"CM", 900},
			{"IX", 9},
			{"IV", 4},
				{"XL", 40},
				{"XC",90},
				{"CD", 400}
			};

			int sum = 0;
			int charIndex = 0;
			while (charIndex < s.Length)
			{
                Console.WriteLine("charIndex: " + charIndex);

                switch (s[charIndex])
				{
					case 'I':
                        if (charIndex + 1 < s.Length)
                        {
                            if (s[charIndex + 1] == 'V')
                            {
                                sum += romansToInt["IV"];
                                charIndex++;
                            }
                            else if (s[charIndex + 1] == 'X')
                            {
                                sum += romansToInt["IX"];
                                charIndex++;
                            }
                            else
                            {
                                sum += romansToInt["I"];
                            }
                            charIndex++;
                            break;
                        }
						else
						{
                            sum += romansToInt["I"];
                            charIndex++;
                            break;
                        }

                    case 'X':
                        if (charIndex + 1 < s.Length)
                        {
                            if (s[charIndex + 1] == 'L')
                            {
                                sum += romansToInt["XL"];
                                charIndex++;
                            }
                            else if (s[charIndex + 1] == 'C')
                            {
                                sum += romansToInt["XC"];
                                charIndex++;
                            }
                            else
                            {
                                sum += romansToInt["X"];
                            }
                            charIndex++;
                            break;
                        }
                        else
                        {
                            sum += romansToInt["X"];
                            charIndex++;
                            break;
                        }

                    case 'C':
                        if (charIndex + 1 < s.Length)
                        {
                            if (s[charIndex + 1] == 'D')
                            {
                                sum += romansToInt["CD"];
                                charIndex++;
                            }
                            else if (s[charIndex + 1] == 'M')
                            {
                                sum += romansToInt["CM"];
                                charIndex++;
                            }
                            else
                            {
                                sum += romansToInt["C"];
                            }
                            charIndex++;
                            break;
                        }
                        else
                        {
                            sum += romansToInt["C"];
                            charIndex++;
                            break;
                        }

                    default:
                        sum += romansToInt[s[charIndex].ToString()];
                        charIndex++;
                        break;
                }
			}
			return sum;
        }

        
    }
}

