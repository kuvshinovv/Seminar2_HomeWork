//________________________________________________________________________________________________________
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


/* void func(){
    int number = new Random().Next(99, 1000);
    Console.WriteLine("Рандомно программа выбрала трехзначное число: " + number);

    int dvachisla = number / 10;
    int second = dvachisla % 10;
    Console.WriteLine("Вторая цифра этого трехзначного числа: " + second);
}


func(); */










//_______________________________________________________________________________________________________
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* void func(int num){
    
    if (num > 99 && num <= 1000){
        int number3 = num % 10;
        Console.WriteLine("Третья цифра этого трехзначного числа: " + number3);
    }
    else if(num > 1000 && num <= 10000){
        int tmp = num % 100;
        int number3 = tmp / 10;

        Console.WriteLine("Третья цифра введённого числа: " + number3 );
    }
    else if(num > 10000 && num <= 100000){
        int tmp = num % 1000;
        int number3 = tmp / 100;

        Console.WriteLine("Третья цифра введённого числа: " + number3 );
    }
    else if(num > 100000 && num <= 1000000){
        int tmp = num % 10000;
        int number3 = tmp / 1000;

        Console.WriteLine("Третья цифра введённого числа: " + number3 );
    }
    else if(num > 1000000 && num <= 10000000){
        int tmp = num % 100000;
        int number3 = tmp / 10000;

        Console.WriteLine("Третья цифра введённого числа: " + number3 );
    }
    else if(num > 10000000 && num <= 100000000){
        int tmp = num % 1000000;
        int number3 = tmp / 100000;

        Console.WriteLine("Третья цифра введённого числа: " + number3 );
    }
   else if(num > 100000000 && num <= 1000000000){   
        int tmp = num % 10000000;
        int number3 = tmp / 1000000;
        Console.WriteLine("Третья цифра введённого числа: " + number3 );
        
    }
    else if(num > 1000000000 && num <= 1999999999){   
        int tmp = num % 100000000;
        int number3 = tmp / 10000000;
        Console.WriteLine("Третья цифра введённого числа: " + number3 );
        Console.WriteLine("Значение числа >= 1000000000, выходят за рамки значений 32bit: " );
    }
    else{
        Console.WriteLine("Третьей цифры в ведённом числе НЕТ!");
    }
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());  // Для чисел более 10 знаков не хватает значений 32бит, 
                                                   // попроболвал поставить 64 битную конвертацию, но выдало ошибку почему то :)  

func(number);
 */











//____________________________________________________________________________________________________
/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


/* void GetDay(int num){
    if (num <= 7){
        if(num == 1){
            Console.WriteLine("Понедельник - рабочий день, НЕ является выходным!!!");
        }
        else if (num == 2){
            Console.WriteLine("Вторник - рабочий день, НЕ является выходным!!!");
        }
        else if (num == 3){
            Console.WriteLine("Среда - рабочий день, НЕ является выходным!!!");
        }
        else if (num == 4){
            Console.WriteLine("Четверг - рабочий день, НЕ является выходным!!!");
        }
        else if (num == 5){
            Console.WriteLine("Пятница - рабочий день, НЕ является выходным!!!");
        }
        else if (num == 6){
            Console.WriteLine("УРА!!! Суббота - выходной!!!");
        }
        else if (num == 7){
            Console.WriteLine("УРА!!! Воскресение - выходной!!!");
        }
    }
    else {
        Console.WriteLine("Такого дня недели не существует!!!");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetDay(number); */