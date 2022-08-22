// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
/*  _____________ Возвращаемая функция___________________________________

int CutNumber(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Number is: " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    return result;
}

int number = CutNumber();
Console.WriteLine("CutNumber number is: " + number); */
//_____________________________не возвращаемая функция...______________________________________
/* 
void CutNumber(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Number is: " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    Console.WriteLine("CutNumber number is: " + result);
}
CutNumber(); */

//__________________________умножение 2х факториалов на примере возвращаемой функции  (НЕ VOID)_________________________________________________
/* int Factorial(int num){
    int current = 1;
    int fact = 1;
    if (num >0){
        while(current<num){
            fact = fact * current;
            current++;
        }
        return fact;
    }
    else if (num == 0){
        return fact;
    }
    else {
        Console.WriteLine ("фАКТОРИАЛ ОТРИЦАТЕЛЬНОГО ЧИСЛА НЕ ВОЗМОЖЕН!");
        return 0;
    }
}
int result = Factorial(0) * Factorial(-10);
Console.WriteLine("Your result is: " + result); */




//______________________________________________________________________________________________
// Напишите программу, которая выводит число  изотрезка [10,99] и показывает наибольшую цифру числа.

/* int Line(){
    int num = new Random().Next(10, 100);
    Console.WriteLine("Your number is: " + num);
    int dec = num /100;
    int ed = num % 10;
    if (dec>ed){
        return dec;
    }
    else{
        return ed;
    }
} 

Console.WriteLine("Максимальная цифра: "+ Line());    // А не работает написанный код..  он показывает только вторую цифру числа */



//_______________________________________________________________________________________
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

/* void func(int num){
    if (num % 7 == 0 && num % 23 == 0){
        Console.WriteLine("Введёное число кратно 7 и 23!");
    }
    else{
        Console.WriteLine("Введёное число НЕ кратно 7 и 23!");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
func(number);
 */




//____________________________________________________________________________________________________
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*  void Square(int a, int b){
     if(a == b*b || b == a*a){
         Console.WriteLine("Условие выполняется");
     }
     else{
         Console.WriteLine("Условие не выполняется");
     }
 }

 Console.WriteLine("Enter the number 1: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter the number 2: ");
 int b = Convert.ToInt32(Console.ReadLine());
 Square(a,b);
 */



//___________________________________________________________________________________________________________
// 3 Задача - Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деление.

/* int Square(int a, int b){
    
    if(b % a != 0){
        int result = b % a;
        return result;
    }
    else{
        return 0;
    }
}

Console.Write("Enter the number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==0 || b==0){
    Console.WriteLine("На ноль делить нельзя!");
}
else{
    int result = Square(a,b);
    if(result == 0){
        Console.WriteLine("Второе число кратно первому");
    }
    else{
        Console.WriteLine("Второе число не кратно первому.Остаток от деления: " + result);
    }
}
 */
//___________________________________________________________________________________________





