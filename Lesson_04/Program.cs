using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle(); // Task 1
            Console.WriteLine();

            Diamonds(); // Task 2
            Console.WriteLine();

            // Task 3
            // Initialization
            char[] normal = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] secret = { 'a', 'z', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'q', 's', 'd',
                'f', 'g', 'h', 'j', 'k', 'l', 'm', 'w', 'x', 'c', 'v', 'b', 'n' };
            // Execution
            Console.WriteLine("Please enter a message:");
            string message = Console.ReadLine();
            Console.WriteLine($"Encoded message:\n{Encode(normal, secret, message)}");
            Console.WriteLine($"Decoded message:\n{Decode(normal, secret, Encode(normal, secret, message))}");
            Console.WriteLine();

            Console.ReadKey();
        }

        static void Triangle() // Task 1
        {
            Console.Write("Please enter an integer n > ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static void Diamonds() // Task 2
        {
            Console.Write("Please enter an integer n > ");
            int n = int.Parse(Console.ReadLine()) - 1;

            // INCREASE
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i*2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            // DECREASE
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }


        static string Encode(char[] normal, char[] secret, string message) // Task 3 (1/3)
        {
            string encodedMessage = null;
            for (int i = 0; i<message.Length; i++)
            {
                if (message[i] == ' ')
                    encodedMessage += '$';
                else if (message[i] == '.')
                    encodedMessage += '&';
                else if (message[i] == ',')
                    encodedMessage += '€';
                else if (message[i] == '?')
                    encodedMessage += '%';
                else if (message[i] == '!')
                    encodedMessage += '=';
                else
                {
                    int index = Index(message[i], normal);
                    encodedMessage += secret[index];
                }
            }
            return encodedMessage;
        }

        static string Decode(char[] normal, char[] secret, string message) // Task 3 (2/3)
        {
            string decodedMessage = null;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == '$')
                    decodedMessage += ' ';
                else if (message[i] == '&')
                    decodedMessage += '.';
                else if (message[i] == '€')
                    decodedMessage += ',';
                else if (message[i] == '%')
                    decodedMessage += '?';
                else if (message[i] == '=')
                    decodedMessage += '!';
                else
                {
                    int index = Index(message[i], secret);
                    decodedMessage += normal[index];
                }
            }
            return decodedMessage;
        }

        static int Index(char letter, char[] array) // Task 3 (3/3)
        {
            int index = -1; // The program will never return -1
            for (int i = 0; i < array.Length; i++)
                if (letter == array[i])
                    index = i;
            return index;
        }
    }
}
