// instead of writing the options here I created a new class named options with every option
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Options options = new Options();
        options.OptionsGenerator();
    }
}