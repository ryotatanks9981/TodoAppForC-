using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("todos.text", Encoding.GetEncoding(932)))
            {
                String file = reader.ReadToEnd();
                string[] todos = file.Split('\n');
                foreach (string todo in todos)
                {
                    todoList.Items.Add(todo);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (todoTextField.Text == "")
                {
                    MessageBox.Show("テキストフィールドが空です");
                    return;
                }
                todoList.Items.Add(getTodo());
                writeTodos();
                todoTextField.Text = "";
            }
        }


        private void writeTodos()
        {
            using (StreamWriter writer = new StreamWriter("todos.text", true, Encoding.GetEncoding(932)))
            {
                try
                {
                    writer.WriteLine(getTodo());
                } catch
                {
                    MessageBox.Show("保存できませんでした。");
                }
                
            }
        }

        private string getTodo()
        {
            if (todoTextField.Text == "")
            {
                throw new FormatException();
            }
            return todoTextField.Text;
        }
    }
}
