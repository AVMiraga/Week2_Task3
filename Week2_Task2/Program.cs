//Task 1
//Print numbers that have square root between 1 and 25.

using System;

for (int i = 1; i*i <= 25; i++)
{
    Console.Write(i*i + " ");
}

Console.WriteLine();

//Task 2
//Print the sum of odd numbers in array.

//Array Creation Block//
Console.WriteLine("Type Elements of Array[10]:");
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
if (numbers.Length == 0)
{
    Console.WriteLine("Array is empty");
    return;
}
//End Of Block//

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0)
    {
        sum += numbers[i];
    }
}

Console.WriteLine($"Sum of odd elements is: {sum}");

//Task 3
//Print the sum of elements of array that are placed on odd positions.

sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += numbers[i];
    }
}

Console.WriteLine($"Sum of elements on odd positions is: {sum}");

//Task 4
//Check if given string is palindrome.

Console.WriteLine("Type a word:");
string word = Console.ReadLine();

for (int i = 0; i < word.Length / 2; i++)
{
    if (char.ToLower(word[i]) != char.ToLower(word[word.Length - 1 - i])) //It's important to convert all letters to lower case, because otherwise it will not work with capital letters. Alternatively, you can use regular word[i] != word[word.Length - 1 - i] Which in this case Capital letters will be matter.
        if (word[i] != word[word.Length - 1 - i])
    {
        Console.WriteLine("Not palindrome");
        return;
    }
}
Console.WriteLine("Palindrome");
