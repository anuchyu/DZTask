﻿using DZTask;

var duplexList = new DuplexLinkedList<int>();
duplexList.Add(1);
duplexList.Add(2);
duplexList.Add(3);
duplexList.Add(4);
duplexList.Add(5);
duplexList.Add(6);
duplexList.Add(7);

foreach (var item in duplexList)
{
    Console.WriteLine(item);
}

Console.WriteLine();

duplexList.Delete(3);

foreach (var item in duplexList)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var reverse = duplexList.Reverse();
foreach (var item in reverse)
{
    Console.WriteLine(item);
}

