using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    class Vertex
    {
        public int x = 0, y = 0;
        public int key;
        public Vertex parent = null;
        public Vertex left = null, right = null;
        public int Offset;

        public Vertex(int value)
        {
            this.key = value;
        }
    }

    class BinaryTree
    {
        public Vertex root = null;
        public int Offset = 500;

        public void Insert(Vertex z) // 1
        {
            Vertex y = null;
            Vertex x = root;
            while (x != null)
            {
                y = x;
                if (z.key < y.key)
                {
                    x = x.left;
                }
                else
                {
                    x = x.right;
                }
            }
            z.parent = y;
            if (y == null)
            {
                root = z;
                z.x = 550;
                z.y = 23;
                z.Offset = Offset;
            }
            else if (z.key < y.key)
            {
                y.left = z;
                z.y = y.y + 40;
                z.Offset = y.Offset / 2;
                z.x = y.x - z.Offset;
            }
            else
            {
                y.right = z;
                z.y = y.y + 40;
                z.Offset = y.Offset / 2;
                z.x = y.x + z.Offset;
            }
            return;
        }

        //public void Insert(Vertex vertex) 
        //{
        //    if (this.root == null)
        //    {
        //        vertex.x = 550;
        //        vertex.y = 23;      //plan b - insert
        //        this.root = vertex;
        //        return;
        //    }
        //    insertItem(this.root, vertex);
        //}
        //private void insertItem(Vertex root, Vertex vertex)
        //{
        //    if (vertex.key < root.key)
        //    {
        //        if (root.left == null)
        //        {
        //            root.left = vertex;
        //            vertex.parent = root;
        //            vertex.y = root.y + 40;
        //            if (root == this.root) vertex.Offset = (int)(Offset / 2);
        //            else vertex.Offset = (int)(vertex.parent.Offset / 2);
        //            vertex.x = root.x - vertex.Offset;
        //        }
        //        else
        //        {
        //            insertItem(root.left, vertex);
        //        }
        //    }
        //    else if (vertex.key >= root.key)
        //    {
        //        if (root.right == null)
        //        {
        //            root.right = vertex;
        //            vertex.parent = root;
        //            vertex.y = root.y + 40;
        //            if (root == this.root) vertex.Offset = (int)(Offset / 2);
        //            else vertex.Offset = (int)(vertex.parent.Offset / 2);
        //            vertex.x = root.x + vertex.Offset;
        //        }
        //        else
        //        {
        //            insertItem(root.right, vertex);
        //        }
        //    }
        //}

        public Vertex Search(Vertex vertex, int number) // 2
        {
            if (vertex == null) return null;
            else if (vertex.key == number) return vertex;
            else if (number < vertex.key) return Search(vertex.left, number);
            else return Search(vertex.right, number);
        }

        public Vertex Min(Vertex vertex) // 3
        {
            while (vertex.left != null)
            {
                return Min(vertex.left);
            }
            return vertex;
        }

        public Vertex Max(Vertex vertex) // 4
        {
            while (vertex.right != null)
            {
                return Max(vertex.right);
            }
            return vertex;
        }

        public Vertex Successor(Vertex vertex) // 5
        {
            if (vertex.right != null)
            {
                return Min(vertex.right);
            }
            Vertex y = vertex.parent;
            while (y != null && vertex == y.right)
            {
                vertex = y;
                y = y.parent;
            }
            return y;
        }

        public Vertex Predecessor(Vertex vertex) // 6
        {
            if (vertex.left != null)
            {
                return Max(vertex.left);
            }
            Vertex y = vertex.parent;
            while (y != null && vertex == y.left)
            {
                vertex = y;
                y = y.parent;
            }
            return y;
        }

        public Vertex Delete(Vertex vertex) // 7
        {
            Vertex x;
            Vertex y;
            if (vertex.left == null || vertex.right == null)
            {
                y = vertex;
            }
            else y = Successor(vertex);
            if (y.left != null)
            {
                x = y.left;
            }
            else x = y.right;
            if (x != null) x.parent = y.parent;
            if (y.parent == null) this.root = x;
            else if (y == y.parent.left) y.parent.left = x;
            else y.parent.right = x;
            if (y != vertex)
            {
                vertex.key = y.key;
            }
            return y;
        }

        public void InorderTree(Vertex vertex, StringBuilder binTree) // 8
        {
            if (vertex != null)
            {
                InorderTree(vertex.left, binTree);
                binTree.Append(vertex.key.ToString() + "; ");
                InorderTree(vertex.right, binTree);
            }
            return;
        }
    }

    //рисовалка
    class DrawGraph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen greenYellowPen;
        Pen green;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 15; //радиус окружности вершины

        //параметры фигур
        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 1;
            greenYellowPen = new Pen(Color.GreenYellow);
            greenYellowPen.Width = 2;
            green = new Pen(Color.Green);
            green.Width = 5;
            fo = new Font("Arial", 13);
            br = Brushes.Black;
        }

        //полотно
        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        //очистка полотна
        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

        //рисуем вершину
        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 12, y - 10);
            gr.DrawString(number, fo, br, point);
        }

        //Закрашиваем верщину
        public void drawDFSVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.Red, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 12, y - 10);
            gr.DrawString(number, fo, br, point);
        }

        //рисуем ребро
        public void drawEdge(Vertex V1, Vertex V2)
        {
            gr.DrawLine(green, V1.x, V1.y, V2.x, V2.y);
            drawVertex(V1.x, V1.y, (V1.key).ToString());
            drawVertex(V2.x, V2.y, (V2.key).ToString());
        }

        //рисуем дерево
        public void PrintTree(Vertex vertex)
        {

            if (vertex != null)
            {
                PrintTree(vertex.left);

                drawVertex(vertex.x, vertex.y, vertex.key.ToString());
                if (vertex.parent != null) drawEdge(vertex, vertex.parent);

                PrintTree(vertex.right);

                drawVertex(vertex.x, vertex.y, vertex.key.ToString());
                if (vertex.parent != null) drawEdge(vertex, vertex.parent);
            }
        }
    }
}