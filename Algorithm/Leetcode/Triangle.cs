using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            List<List<int>> triangle = new List<List<int>>();
            List<int> layer1 = new List<int>();
            layer1.Add(2);
            List<int> layer2 = new List<int>();
            layer2.Add(3);
            layer2.Add(4);
            List<int> layer3 = new List<int>();
            layer3.Add(6);
            layer3.Add(5);
            layer3.Add(7);
            List<int> layer4 = new List<int>();
            layer4.Add(4);
            layer4.Add(1);
            layer4.Add(8);
            layer4.Add(3);
            triangle.Add(layer1);
            triangle.Add(layer2); 
            triangle.Add(layer3); 
            triangle.Add(layer4);

            int len = new Leetcode.Triangle().minimumTotal(triangle);

            Console.WriteLine(len); 
 */
namespace Algorithm.Leetcode
{
    class Triangle
    {
        public int minimumTotal(List<List<int>> triangle)
        {
            List<int>[] temp = new List<int>[2];
            temp[0] = new List<int>();
            temp[1] = new List<int>();
            int ind = triangle.Count - 1;
            for (int i = 0; i < triangle[triangle.Count - 1].Count; i++)
            {
                temp[ind % 2].Add(triangle[triangle.Count - 1][i]);
            }
            --ind;
            for (; ind >= 0; ind--)
            {
                List<int> triangle_layer = triangle[ind];
                List<int> temp_up = temp[ind%2], temp_down = temp[(ind + 1) % 2];
                for (int row = 0; row < triangle_layer.Count; row++)
                {
                    temp_up.Add(triangle_layer[row] + Math.Min(temp_down[row], temp_down[row + 1]));
                }
                temp_down.Clear();
            }
            return temp[(ind + 1) % 2][0];
        }


    }
}
