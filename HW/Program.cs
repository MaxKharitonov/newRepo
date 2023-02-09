// Написать программу, которая из имеющегося массива строк, сформирует
// массив строк, длина которых, меньше либо равна 3 символам.

Console.WriteLine("Введите длину массива: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[arrLen];
string inputString = " ";
string[] resArray = new string[stringArray.GetLength(0)];

for (int i = 0; i < stringArray.GetLength(0); i++) {
    Console.WriteLine("Введите строку: ");
    inputString = Console.ReadLine();
    stringArray[i] = inputString;
    if (stringArray[i].Length <= 3 && stringArray[i].Length > 0) {
        resArray[i] = stringArray[i];
    }
}
Console.WriteLine($"Изначальный массив: {string.Join(" ", stringArray)}");
Console.WriteLine($"Конечный массив: {string.Join(" ", resArray)}");