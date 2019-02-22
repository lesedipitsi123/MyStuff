using System;
using System.Text;

namespace Problems
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }

        // Prefixes string
       public string Prefix(string  input)
        {
            if(input == null) return null;
            StringBuilder sb= new StringBuilder();
            int len = input.Length;
            if(len < 1)
            {
                return "0,0:";
            }
            sb.Append(len).Append(',');
            // Append number of words in string
            int words=1; // len >= 1 so at least 1 words
            for(int i=0; i < len; i++)
            {
                
                    if(String.IsNullOrWhiteSpace(input[i].ToString()))
                    {
                    words+=1;  
                    }
            }

            sb.Append(words).Append(':').Append(input);

            return sb.ToString();
        }
    }
}
