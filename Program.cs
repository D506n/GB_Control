string EnterText(string MessageForUser)//метод для ввода текста и вывода сообщения с просьбой ввести текст
{
    Console.WriteLine(MessageForUser);
    string TempText = Console.ReadLine();
    return TempText;
}