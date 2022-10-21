using System;

namespace Palindroms{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("Enter a word: ");
            string str = Console.ReadLine();

            string temp = "";

            for(int i = str.Length-1; i >= 0; i--){

                temp += str[i];
            }

            if(temp == str){

                Console.WriteLine(str+" is a palindrom.");
            } else{

                Console.WriteLine(str+" is not a palindrom.");
            }
        }
    }
}