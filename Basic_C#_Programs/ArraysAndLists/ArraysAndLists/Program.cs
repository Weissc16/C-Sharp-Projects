﻿using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        /////Lists//////
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Cody");
        stringList.Remove("Cody");


        Console.WriteLine(intList[1]);

        //for images//
        byte[] byteArray = new byte[5000];


        /////Ways to make an Arrays/////
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;


        Console.ReadLine();
    }
}

