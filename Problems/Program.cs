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
        static string Prefix(string  input)
        {
            if(input == null) return null;
            StringBuilder sb= new StringBuilder();
            int len = input.Length;
        
            sb.Append(len).Append(',');
            // Append number of words in string
            int words=0;
            for(int i=0; i< len; i++)
            {
                
                    if(String.IsNullOrWhiteSpace(input[i].ToString())){
                    words+=1;  
                    }
            }

            sb.Append(words).Append(':').Append(input);

            return sb.ToString();
        }
    }
}
