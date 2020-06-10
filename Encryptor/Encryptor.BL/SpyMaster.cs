using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encryptor.BL
{
    public static class SpyMaster
    {
        const int MIN_VALUE = 'A';
        const int MAX_VALUE = 'z';

        public static string Encrypt(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var @char in input)
            {
                if (@char >= MIN_VALUE && @char <= MAX_VALUE)
                {
                    int data = @char - MIN_VALUE;
                    sb.Append(data.ToString("00"));
                }
                else sb.Append(@char);
            }

            return sb.ToString();
        }

        public static string Decrypt(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            List<char> chars = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9' &&
                    i < input.Length - 1 &&
                    input[i + 1] >= '0' && input[i + 1] <= '9' &&
                    int.TryParse(input.Substring(i, 2), out var data))
                {
                    chars.Add((char)(MIN_VALUE + data));
                    i++;
                }
                else chars.Add(input[i]);
            }

            return new string(chars.ToArray());
        }
    }
}
