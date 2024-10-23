namespace C_Intro_Reference_Value_Types;
class Program
{
    static void Main(string[] args)
    {
        //string phrase = "He l  l o";
        //string editedPhrase = "";
        //foreach (char letter in phrase)
        //{
        //    if (letter != ' ')
        //        editedPhrase += letter;
        //}
        //Console.WriteLine(editedPhrase);


        //string words = "Good Morning";
        //int count = 0;
        //for (int i = 0; i < words.Length; i++)
        //{
        //    if (words[i] == 'o')
        //    {
        //        count++;
        //    }

        //}
        //Console.WriteLine(count);


        //string phrase = "   How are you? ";
        //string editedPhrase = "";
        //for (int i = 0; i < phrase[i] != " "; i++)
        //{
        //    if (phrase[i] != " ")
        //    {
        //        editedPhrase[0] == phrase[i];

        //        Console.WriteLine(editedPhrase);

        //    }
        //}




        //int num1 = 22;
        //int num2 = 11;
        //string[] actions = { "+", "-", "*", "/" };
        //string chosenaction = "+";

        //switch (chosenaction)
        //{
        //    case "+":
        //        Console.WriteLine(num1 + num2);
        //        break;
        //    case "-":
        //        Console.WriteLine(num1 - num2);
        //        break;
        //    case "*":
        //        Console.WriteLine(num1 * num2);
        //        break;
        //    case "/":
        //        Console.WriteLine(num1 / num2);
        //        break;
        //    default:
        //        Console.WriteLine("Enter another symbol");
        //        break;
        //}


        //string name = "Pineapple";
        //char letter = 'a';
        //int count = 0;
        //for (int i = 0; i < name.Length; i++)
        //{
        //    if (name[i] == letter)
        //        count++;

        //}
        //if (count > 0)
        //{
        //    Console.WriteLine("yes");
        //}

        //else
        //{
        //    Console.WriteLine("No");
        //}




        //string words = "Academy";
        //char letter1 = 'a';
        //char letter2 = 'A';
        //int count = 0;
        //for (int i = 0; i < words.Length; i++)
        //{
        //    if (words[i] == letter1 || words[i] == letter2)
        //    {
        //        count++;
        //    }

        //}
        //Console.WriteLine(count);



        //int num = 9;
        //int num2 = num;
        //int power = 1;
        //if (num > 0 && num % 2 == 0)
        //{
        //    power = num2 * num;

        //    Console.WriteLine(power);
        //}

        //else if (num <= 0 || num % 2 != 0)
        //{
        //    Console.WriteLine("Enter another value");
        //}


        string[] programs = { "Pogramming", "Design", "System" };
        string chosenprogram = "Design";
        switch (chosenprogram)
        {
            case "Pogramming":
                Console.WriteLine("400 hours");
                break;
            case "Design":
                Console.WriteLine("250 hours");
                break;
            case "System":
                Console.WriteLine("200 hours");
                break;
            default:
                Console.WriteLine("Wrong chosenprogram");
                break;
        }

















    }

}







    


