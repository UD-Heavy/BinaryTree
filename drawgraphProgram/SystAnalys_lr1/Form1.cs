using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace SystAnalys_lr1
{
    public partial class Form1 : Form
    {
        DrawGraph G;
        List<Vertex> V;
        BinaryTree B;

        //форма - инициализация
        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            B = new BinaryTree();
            sheet.Image = G.GetBitmap();

        }

        //кнопка - вставка
        private void InsertButton_Click(object sender, EventArgs e)
        {

            int value = Convert.ToInt32(tbValue.Text);
            Vertex vertex = new Vertex(value);
            B.Insert(vertex);// 1 вставка
            V.Add(vertex);
            G.drawVertex(vertex.x, vertex.y, vertex.key.ToString());
            sheet.Image = G.GetBitmap();
            tbValue.Text = "";
            G.PrintTree(vertex);
            sheet.Image = G.GetBitmap();
        }

        //кнопка вызова опреаций дерева
        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            Lres.Visible = false;
            G.clearSheet();
            G.PrintTree(B.root);
            if (CBchoice.SelectedIndex == 0) // 2 поиск
            {
                int number = Convert.ToInt32(TBresult.Text);
                Vertex vertex = B.Search(B.root, number);
                if (vertex == null) MessageBox.Show("вершины с таким значением нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    G.drawDFSVertex(vertex.x, vertex.y, vertex.key.ToString());
                }
                sheet.Image = G.GetBitmap();
                TBresult.Text = "";
            }
            else if (CBchoice.SelectedIndex == 1) // 3 минимум
            {
                Vertex vertex = B.Min(B.root);
                G.drawDFSVertex(vertex.x, vertex.y, vertex.key.ToString());
                sheet.Image = G.GetBitmap();
            }
            else if (CBchoice.SelectedIndex == 2) // 4 максимум
            {
                Vertex vertex = B.Max(B.root);
                G.drawDFSVertex(vertex.x, vertex.y, vertex.key.ToString());
                sheet.Image = G.GetBitmap();
            }
            else if (CBchoice.SelectedIndex == 3) // 5 следующий
            {
                int number = Convert.ToInt32(TBresult.Text);
                Vertex vertex1;
                foreach (Vertex vertex in V)
                {
                    if (vertex.key == number)
                    {
                        vertex1 = B.Successor(vertex);
                        if (vertex1 == null) MessageBox.Show("Для данного элемента нет следующей вершины!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            G.drawDFSVertex(vertex1.x, vertex1.y, vertex1.key.ToString());
                            sheet.Image = G.GetBitmap();
                        }
                        break;
                    }
                }
            }
            else if (CBchoice.SelectedIndex == 4) // 6 предыдущий
            {
                int number = Convert.ToInt32(TBresult.Text);
                Vertex vertex1;
                foreach (Vertex vertex in V)
                {
                    if (vertex.key == number)
                    {
                        vertex1 = B.Predecessor(vertex);
                        if (vertex1 == null) MessageBox.Show("Для данного элемента нет предыдущей вершины!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            G.drawDFSVertex(vertex1.x, vertex1.y, vertex1.key.ToString());
                            sheet.Image = G.GetBitmap();
                        }
                        break;
                    }
                }
            }
            else if (CBchoice.SelectedIndex == 5) // 7 удаление
            {
                bool exist = false;
                int number = Convert.ToInt32(TBresult.Text);
                Vertex vertex1;
                foreach (Vertex vertex in V)
                {
                    if (vertex.key == number)
                    {
                        exist = true;
                        vertex1 = B.Delete(vertex);
                        if (vertex == vertex1) V.Remove(vertex);
                        else V.Remove(vertex1);
                        break;
                    }
                }
                G.clearSheet();
                G.PrintTree(B.root);
                sheet.Image = G.GetBitmap();
                if (exist == false) MessageBox.Show("Данного элемента нет в дереве!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CBchoice.SelectedIndex == 6) // 8 Печать
            {
                StringBuilder res = new StringBuilder();
                B.InorderTree(B.root, res);
                Lres.Visible = true;
                Lres.Text = "Дерево: " + res.ToString();
            }
            TBresult.Text = "";
            Lhelp.Text = "";
            Lhelp.Visible = false;
        }

        //вспомогательные элементы
        private void enterNumbLabel_Click(object sender, EventArgs e)
        {

        }
        private void tbValue_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBchoice.SelectedIndex == 0)
            {
                Lhelp.Text = "Введите значение для поиска";
                Lhelp.Visible = true;
            }
            else if (CBchoice.SelectedIndex == 1)
            {
                Lhelp.Text = "Нажмите \"ОК\", чтобы найти наименьший элемент";
                Lhelp.Visible = true;
            }
            else if (CBchoice.SelectedIndex == 2)
            {
                Lhelp.Text = "Нажмите \"ОК\", чтобы найти наибольший элемент";
                Lhelp.Visible = true;
            }
            else if (CBchoice.SelectedIndex == 3)
            {
                Lhelp.Text = "Введите значение, чтобы найти следующий от него элемент";
                Lhelp.Visible = true;
            }
            else if (CBchoice.SelectedIndex == 4)
            {
                Lhelp.Text = "Введите значение, чтобы найти предыдущий от него элемент";
                Lhelp.Visible = true;
            }
            else if (CBchoice.SelectedIndex == 5)
            {
                Lhelp.Text = "Введите значение, которое необходимо удалить";
                Lhelp.Visible = true;
            }
            else if (CBchoice.SelectedIndex == 6)
            {
                Lhelp.Text = "Нажмите \"ОК\", чтобы напечатать дерево";
                Lhelp.Visible = true;
            }
        }
        private void TBresult_TextChanged(object sender, EventArgs e)
        {

        }
        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            G.clearSheet();
            sheet.Image = G.GetBitmap();
        }
        private void InorderTreeButton_Click(object sender, EventArgs e)
        {
            G.clearSheet();
            G.PrintTree(B.root);
            sheet.Image = G.GetBitmap();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Lhelp_Click(object sender, EventArgs e)
        {

        }
        private void Lres_Click(object sender, EventArgs e)
        {

        }
    }
}
