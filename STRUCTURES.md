# STRUCTURES

---
switch (a) 
{ 
    case 1: { } break; 
    case 2: { } break; 
}

---

for(int i = 0; i < 10; i++)
{
    continue;
    break;
}

---

if (a = b) 
{

}

---
int a = 1;
int b = 2;
int result = 0;
Plus(a, b, ref result);

Plus(int a, int b, ref int result)
{
    result = a+b; // result in main method = result in "Plus" method
{

---
public override string ToString()
{
    return $"Имя: {name}, Возраст: {age}, Email: {email}";
}

---
___НОД___
 while (b != 0)
{
    long temp = b;
    b = a % b;
    a = temp;
}

Console.WriteLine(a)
