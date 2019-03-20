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
        public List<List<int>> pathtoone = new List<List<int>>();
        public List<int> pathtopoint = new List<int>();
        public List<int> currentpathing = new List<int>();
        public List<int> aidilPath = new List<int>();
        public int NVertex;


        //METHODS
        public Graph(int V, int[][] arrin)
        {
            List<int> emptypath = new List<int>();
            AssignVertices(V);
            AssignEdges(arrin);
            AssignWeight(emptypath);
        }

        public void AssignVertices(int V)
        {
            
            for (int i = 0; i < V; i++)
            {
                List<int> temp = new List<int>();
                temp.Add(1);
                vertices.Add(i + 1);
                weight.Add(0);
                //add path to one (1)
                pathtoone.Add(temp);
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
        public void AssignWeight(List<int> emptypath)
        {
            int King = 0;
            weight[0] = 1;
            foreach (int branch in edges[King]) {
                //List<int> been = new List<int>();
                if (branch != 1) {
                    //emptypath.Add(branch);
                    AssignWeightUtil(2, branch, emptypath);
                    emptypath.Clear();
                    }
            }
        }

        public void AssignWeightUtil(int lvl, int curhome, List<int> curpath)
        {
            //Console.WriteLine("LVEL"+lvl+" curhome " + curhome);
            curpath.Add(curhome);
            curpath.ForEach(el => pathtoone[curhome - 1].Add(el));            
            weight[curhome - 1] = lvl;
            foreach (int branch in edges[curhome - 1])
            {
                if (branch != curhome && weight[branch - 1] == 0)
                { 
                    AssignWeightUtil(lvl + 1, branch, curpath);
                }
            }
        }

        public bool PathExists(int _to_Raja, int _dest, int _src)
        {
            currentpathing.Clear();
            return FindPathRecursion(_to_Raja, _dest, _src);
        }

        //Asumsi pasti ada jalan.
        public void FindPathToOne(int _node)
        {
            aidilPath.Add(_node);
            while (_node != 1)
            {
                int id = 0;
                for (int i = 0; i < edges[_node - 1].Count; i++)
                {
                    if (weight[edges[_node - 1][i] - 1] < weight[_node - 1])
                    {
                        id = i;
                        break;
                    }
                }

                aidilPath.Add(edges[_node - 1][id]);
                _node = edges[_node - 1][id];
            }

            for (int i = 0; i < aidilPath.Count; i++)
            {
                Console.WriteLine(aidilPath[i]);
            }
        }

        public bool FindPathRecursion(int toraja, int dest, int src)
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
                        temp = (FindPathRecursion(toraja, dest, branch));
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
                        temp = (FindPathRecursion(toraja, dest, branch));
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

            if (pepe.FindPathRecursion(0, 9, 1))
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
