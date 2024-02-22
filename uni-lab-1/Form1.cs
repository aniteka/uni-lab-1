using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsDataSave_Click(object sender, EventArgs e)
        {
            using (var fin = File.CreateText("FILE.txt"))
            {
                foreach (DataGridViewRow row in studentsGrid.Rows)
                {
                    foreach (DataGridViewCell rowCell in row.Cells)
                    {
                        if (rowCell.Value == null && rowCell.OwningColumn == studentDataGrid_Name)
                            break;

                        if (rowCell.Value != null)
                        {
                            fin.WriteLine(rowCell.Value.ToString());
                        }
                        else
                        {
                            fin.WriteLine("0\n");
                        }
                    }
                }
            }
        }

        private void studentsDataLoad_Click(object sender, EventArgs e)
        {
            studentsGrid.Rows.Clear();
            using (var fout = File.OpenText("FILE.txt"))
            {
                while (!fout.EndOfStream)
                {
                    var name = fout.ReadLine();
                    var markA = int.Parse(fout.ReadLine());
                    var markB = int.Parse(fout.ReadLine());
                    var markC = int.Parse(fout.ReadLine());
                    var markD = int.Parse(fout.ReadLine());
                    var markF = int.Parse(fout.ReadLine());
                    studentsGrid.Rows.Add(name, markA, markB, markC, markD, markF);
                }
            }
        }

        private void studentsGenerateLessMarkMenu_Click(object sender, EventArgs e)
        {
            var lessMark = new (string name, int mark)[5];
            for (var i = 0; i < lessMark.Length; i++)
            {
                lessMark[i].mark = int.MaxValue;
            }
            
            foreach (DataGridViewRow row in studentsGrid.Rows)
            {
                string name = "None";
                int i = 0;
                foreach (DataGridViewCell rowCell in row.Cells)
                {
                    if (rowCell.Value == null && rowCell.OwningColumn == studentDataGrid_Name)
                        break;
                    
                    if (rowCell.OwningColumn == studentDataGrid_Name)
                    {
                        name = rowCell.Value.ToString();
                        continue;
                    }

                    int mark;
                    if (rowCell.Value == null)
                    {
                        mark = 0;
                    }
                    else
                    {
                        if (!int.TryParse(rowCell.Value.ToString(), out mark))
                            mark = 0;
                    }

                    if (lessMark[i].mark > mark)
                    {
                        lessMark[i].name = name;
                        lessMark[i].mark = mark;
                    }

                    ++i;
                }
            }

            var resultStringBuilder = new StringBuilder();
            resultStringBuilder.AppendLine($"A: {lessMark[0].name}");
            resultStringBuilder.AppendLine($"B: {lessMark[1].name}");
            resultStringBuilder.AppendLine($"C: {lessMark[2].name}");
            resultStringBuilder.AppendLine($"D: {lessMark[3].name}");
            resultStringBuilder.AppendLine($"F: {lessMark[4].name}");
            lessMarkMenu.Text = resultStringBuilder.ToString();
        }
    }
}