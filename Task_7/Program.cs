﻿class Test
{
    int test1;
    string test2;

    public Test()
    {
        test1 = 0;
        test2 = "Undefined";
    }

    public Test(int test1, string test2)
    {
        this.test1 = test1;
        this.test2 = test2;
    }

    public void Print()
    {
        Console.WriteLine($"параметр 1 = {this.test1}, параметр 2 = {this.test2}");
    }
}