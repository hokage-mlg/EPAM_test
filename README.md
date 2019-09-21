## Description
This repository contains the tasks that I did for the EPAM test. Programming language is C#.
## Tasks
### Задание 1. Сортировка
Дан массив целых чисел. Напишите функцию, которая получает данный массив в
качестве аргумента и сортирует его по возрастанию, а также программу для
демонстрации работы этой функции.
How to use System Collections:

Sort(Array, Int32, Int32, IComparer)
Sorts the elements in a range of elements in a one-dimensional Array using the specified IComparer.

public static void Sort<T> (T[] array, int index, int length, System.Collections.Generic.IComparer<T> comparer);
Sorts the elements in a range of elements in an Array using the specified IComparer<T> generic interface.
### Задание 2. Поиск
Напишите функцию, которая для отсортированного маcсива целых чисел
определяет, содержится ли в нем заданное значение.
How to use System Collections:

Enumerable.Any Method
public static bool Any<TSource> (this System.Collections.Generic.IEnumerable<TSource> source);
Determines whether a sequence contains any elements.

String.Contains Method
public bool Contains (string value);
Returns a value indicating whether a specified substring occurs within this string.

Enumerable.Intersect Method
Intersect<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)
public static System.Collections.Generic.IEnumerable<TSource> Intersect<TSource> (this
System.Collections.Generic.IEnumerable<TSource> first,
System.Collections.Generic.IEnumerable<TSource> second);
Produces the set intersection of two sequences by using the default equality comparer to compare values.
### Задание 3. Строки
Дана строка, вывести только те слова, которые встречаются в ней только один
раз.
How to use System Collections:
Distinct<TSource>(IEnumerable<TSource>)
public static System.Collections.Generic.IEnumerable<TSource> Distinct<TSource> (this System.Collections.Generic.IEnumerable<TSource> source);
Returns distinct elements from a sequence by using the default equality comparer to compare values.

Split(Char[], Int32, StringSplitOptions)
[System.Runtime.InteropServices.ComVisible(false)]
public string[] Split (char[] separator, int count, StringSplitOptions options);

And one more example in my program(second button)
### Задание 4 Факториал
Написать функцию нахождения факториала числа n.
How to use System Collections:

Example:
int n = 3;
Console.WriteLine(Enumerable.Range(1, n).Aggregate((y, x) => y * x));
### Задание 5. Правильная скобочная последовательность*
Дана строка состоящая из скобок “{},(),[]”, определить является ли данная строка
правильно скобочной последовательность. Например (()) – псп, а ((() нет.