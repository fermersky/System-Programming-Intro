using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sysprog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (var Process in Process.GetProcessesByName("atom"))
            //{
            //    //Console.WriteLine($"{Process.Id} {Process.ProcessName}");
            //    Process.CloseMainWindow();
            //    Process.Close();
            //}
            //Console.WriteLine();

            Process proc = Process.GetProcessesByName("devenv")[0];

            // var procThread = proc.Threads;
            //foreach (ProcessThread thread in proc.Threads)
            //{
            //    Console.WriteLine($"id: {thread.Id}, time: {thread.StartTime}}");
            //}

           // Process proc2 = Process.Start("notepad++.exe", @"C:\Users\PKO\Desktop\index.txt");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.Columns.Add("id");
            listView1.Columns.Add("name");
            listView1.View = View.Details;

            foreach (Process proc in Process.GetProcesses())
            {
                ListViewItem item = new ListViewItem();
                
                item.Text = proc.Id.ToString();
                item.SubItems.Add(proc.ProcessName);

                listView1.Items.Add(item);
            }
        }
    }
}
