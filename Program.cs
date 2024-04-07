// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] CreateNewMas(int num1, int[] mas) {
    if(num1 == -1) {return mas;}
    mas[num1] = new Random().Next(1,10);
    Console.Write($"{mas[num1]} ");
    int[] res = CreateNewMas((num1 - 1), mas);
    return res;
}

int[] RotateMas(int num1, int length, int[] mas) {
    if(num1 == length) {return mas;}
    Console.Write($"{mas[num1]} ");
    int[] res = RotateMas((num1 + 1), length, mas);
    return res;
}

int[] chisla = new int [10];
Console.WriteLine(chisla.Length);
int[] new_mas = CreateNewMas((chisla.Length-1), chisla);
Console.WriteLine();
RotateMas(0, (new_mas.Length), new_mas);
