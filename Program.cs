string EnterText(string MessageForUser)//метод для ввода текста и вывода сообщения с просьбой ввести текст
{
    Console.WriteLine(MessageForUser);
    string TempText = Console.ReadLine();
    return TempText;
}
string[] EnterTextArray(string MessageForUser)//меняю размер массива и записываю в него строки до тех пор, пока пользователь вводит строки с клавиатуры, таким образом программа не ограничена конкретными рамками в размерах массива из которого будут выбрираться короткие строки
{
    string[] array = Array.Empty<string>();
    int EnterStep = 0;
    for (string TempText = " "; TempText != "";)
    {
        TempText = EnterText(MessageForUser);
        if (TempText != "")
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = TempText;
            EnterStep++;
        }
    }
    return array;
}
string[] CreateArrayWithThreeSymbol(string[] FirstArray)//этот метод возвращает массив, в котором будут записаны только строки длиной равной или меньшей 3-м символам
{
    string[] array = Array.Empty<string>();
    for (int FindStep = 0; FindStep < FirstArray.Length; FindStep++)
    {
        string CurrentString = FirstArray[FindStep];
        if (CurrentString.Length <= 3)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = CurrentString; //учитывая, что строки всё время будут записываться в новую ячейку, которая была добавлена строчкой выше, тут можно и без дополнительных переменных обойтись, просто опираясь на длину массива
        }
    }
    return array;
}