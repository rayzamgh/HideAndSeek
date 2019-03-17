using System;
using System.IO;
using System.Collections.Generic;

public class FileReader
{
    public int[][] inputArray;
    public int nVertex;

    static void Main()
    {
        // base stack level
        int x = 0;  
        int[][] trial = new int[1][];
        ParseNumberFile("somefile.txt",trial,x);
        
        

        for(int i = 0; i<x; i++){
                foreach(var j in trial[i]){
                        Console.WriteLine(trial[i][j]);
                        Console.WriteLine(",");
                }
                Console.WriteLine("\n");
        }
    }

    public static void ParseNumberFile(string filename, int[][] inputArray, int nVertex)
    {
        string fileContent = File.ReadAllText(filename);
        string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
       
        nVertex = int.Parse(integerStrings[0]);
        
        int[][] _inputArray = new int[integerStrings.Length-1][];

        for (int n = 1; n < integerStrings.Length-1; n++){
            _inputArray[n] = new int[2]{int.Parse(integerStrings[n]), int.Parse(integerStrings[n])};
            Console.Out.WriteLine(_inputArray[n][0].ToString() + _inputArray[n][1].ToString());
        }  

        inputArray = _inputArray; //gapapa bitwise karena sama
    }
}