//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int NumberPrint(string msg){
    Console.Write($"Введите {msg} =");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int Degree(int num, int deg){
    int res = 1;
    for (int i=1; i<= deg; i++){
        res=res*num;
    }
    return res;
}


int a = NumberPrint("A");
int b = NumberPrint("B");
Console.WriteLine($"{a} в степени {b} = {Degree(a,b)}");

