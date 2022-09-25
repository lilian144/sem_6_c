// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа. При помощи ввода стоп-слова stop остановите ввод чисел");
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int count = 0;

while(true)
{
    string answer = Console.ReadLine();
    if(answer == "stop")
    {
        break;
    }
    else{
        int answerNumber = Convert.ToInt32(answer);
        if(answerNumber > 0)
        {
            count++;
        }
    }
}

Console.WriteLine(count);