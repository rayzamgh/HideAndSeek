using System;
using System.Collections.Generic;
namespace Hide_and_Seek
{   
    /*
     *    
     */   
    public class Graph
    {
        //ATRIBUTES
        public List<int> weight = new List<int>();
        public List<int> vertices = new List<int>();
        public List<List<int>> edges = new List<List<int>>();
        public List<int> pathtopoint = new List<int>();
        public List<int> currentpathing = new List<int>();
        public int NVertex;


        //METHODS
        public Graph(int V, int[][] arrin)
        {
            AssignVertices(V);
            AssignEdges(arrin);
            AssignWeight();
        }

        public void AssignVertices(int V)
        { 
            for(int i = 0; i < V; i++)
            {
                vertices.Add(i + 1);
                weight.Add(0);
            }
            NVertex = V;
        }
        public void AssignEdges(int[][] arrin)
        {
           
            for(int i = 0; i<NVertex; i++)
            {
                List<int> Temp = new List<int>();
                Temp.Add(i + 1);
                for(int j = 0; j < arrin.Length; j++)
                {
                    if(arrin[j][0] == Temp[0])
                    {
                        if (!Temp.Contains(arrin[j][1]))
                        {
                            Temp.Add(arrin[j][1]);
                        }
                    }
                    if(arrin[j][1] == Temp[0])
                    {
                        if (!Temp.Contains(arrin[j][0]))
                        {
                            Temp.Add(arrin[j][0]);
                        }
                    }
                }
                //Temp.ForEach(El => Console.Write(El));
                //Console.WriteLine();
                edges.Add(Temp);
                //edges[i].ForEach(El => Console.Write(El));
                //Console.WriteLine();
            }
        }
        public void AssignWeight()
        {
            int King = 0;
            weight[0] = 1;
            foreach (int branch in edges[King]) {
                //List<int> been = new List<int>();
                if (branch != 1) {
                    AssignWeightUtil(2, branch);
                    }
            }
        }

        public void AssignWeightUtil(int lvl, int curhome)
        {
            //Console.WriteLine("LVEL"+lvl+" curhome " + curhome);
            weight[curhome - 1] = lvl;
            foreach (int branch in edges[curhome - 1])
            {
                if (branch != curhome && weight[branch - 1] == 0)
                { 
                    AssignWeightUtil(lvl + 1, branch);
                }
            }
        }

        public bool IsFerguso(int toraja, int dest, int src)
        {
            currentpathing.Add(src);
            //Console.WriteLine(dest + "== DEST , BRANCH ==" + src);
            bool temp = false;
            if (toraja == 1)
            {
                if (dest == src)
                {
                    return(true);
                }
                int curWeight = weight[src - 1];
                foreach (int branch in edges[src - 1])
                {
                    if (curWeight + 1 == weight[branch - 1])
                    {
                        temp = (IsFerguso(toraja, dest, branch));
                        if(temp == true)
                        {
                            return(temp);
                        }
                    }
                }
                currentpathing.Remove(src);
                return(temp);
            }
            else
            {
                if (dest == src)
                {
                    return(true);
                }
                int curWeight = weight[src - 1];
                foreach (int branch in edges[src - 1])
                {
                    if (curWeight - 1 == weight[branch - 1])
                    {
                        temp = (IsFerguso(toraja, dest, branch));
                        if (temp == true)
                        {
                            return (temp);
                        }
                    }
                }
                currentpathing.Remove(src);
                return (temp);
            }
        }
    }

    /*
    class Exec
    {
        static void Main(string[] args)
        {
            int[][] arin = new int[][]
            {
                new int[] {1, 2},
                new int[] {1, 7},
                new int[] {1, 3},
                new int[] {2, 9},
                new int[] {5, 4},
                new int[] {5, 6},
                new int[] {7, 8},
                new int[] {3, 5},
            };
            Console.WriteLine("arrinlenght :" + arin.Length);

            Graph pepe = new Graph(9, arin); 
            pepe.weight.ForEach(el => Console.WriteLine(el));

            if (pepe.IsFerguso(0, 9, 1))
            {
                Console.WriteLine("YA");
            }
            else
            {
                Console.WriteLine("TIDAK");
            }








            Console.WriteLine("SUPAPEGA");
            for (int p = 0; p < pepe.NVertex; p++)
            {
                pepe.edges[p].ForEach(El => Console.Write(El));
                Console.WriteLine();
            }
        }
    }*/
}
