using System;
using System.IO;
using System.Collections.Generic;

public class FileReader
{
    public int[][] inputArray;
    public int nVertex;

    /*
    static void Main()
    {
        // base stack level
        int x = 0;  
        int[][] trial = new int[1][];
        ParseNumberFile("../../somefile.txt", trial,x);
        
        

        for(int i = 0; i<x; i++){
                foreach(var j in trial[i]){
                        Console.WriteLine(trial[i][j]);
                        Console.WriteLine(",");
                }
                Console.WriteLine("\n");
        }
    }*/
    

    public void ParseNumberFile(string filename)
    {
        string pathing = filename;
        StreamReader sr = File.OpenText("../../" + pathing);
        string fileContent = sr.ReadLine();
        string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
       
        nVertex = int.Parse(integerStrings[0]);
        
        int[][] _inputArray = new int[nVertex-1][];

        int count = 0;
        while((fileContent = sr.ReadLine()) != null)
        {
             integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            _inputArray[count] = new int[2] { int.Parse(integerStrings[0]), int.Parse(integerStrings[1]) };
            count++;
        }
        Console.Out.WriteLine(nVertex);
        for (int n = 0; n < nVertex-1; n++){
            Console.Out.Write(_inputArray[n][0]);
            Console.Out.WriteLine(_inputArray[n][1]);
        }

        inputArray = _inputArray; //gapapa bitwise karena sama
    }
}