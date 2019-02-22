using System;

namespace Problems
{

    public class Program
    {
        public string Prefix (string input){
              //if iput is null return null
              if (input == null){  
                return null;
            }

            int length = input.Length;  //counts the string length

            //if input is an empty string, return zero words
                if (input ==""){
                int word = 0;
                return ($"{length},{word}:{input}"); //return output
            }

            string s = input;  //make copy of input

            string [] words = s.Split(" "); //split string on the space to get the number of words
            int wordcount = words.Length;   //word count of array
            foreach (string w in words){
                if (w == ""){             //if anything in array is an empty string, not a word
                   wordcount--;
                }
            }
            return ($"{length},{wordcount}:{input}"); //return output
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}