// Нахождение максимума из 9 чисел(решение в лоб без использования функций).

int a1 = 12;
int b1 = 16;
int c1 = 11;
int a2 = 19;
int b2 = 19;
int c2 = 18;
int a3 = 19;
int b3 = 12;
int c3 = 14;

int max = a1;
if(b1 > max) max =b1;
if(c1 > max) max =c1;

if(a2 > max) max =a2;
if(b2 > max) max =b2;
if(c2 > max) max =c2;

if(a3 > max) max =a3;
if(b3 > max) max =b3;
if(c3 > max) max =c3;

Console.WriteLine(max);