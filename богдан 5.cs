﻿//С клавиатуры вводятся строки S, S1, S2. Заменить в строке S все вхождения строки S1 на строку S2.

Console.WriteLine("Введите строку S:");
string S = Console.ReadLine();
Console.WriteLine("Введите строку S1:");
string S1 = Console.ReadLine();
Console.WriteLine("Введите строку S2:");
string S2 = Console.ReadLine();

string result = S.Replace(S1, S2);
Console.WriteLine("Результат замены: " + result);
