using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stp1_4sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string new_ID;
        string new_author;
        string new_title;
        string new_year_of_publication;
        string new_thematic;
        string new_status;
        string new_date_of_issue;
        string new_count;

        Library library = new Library();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string text = File.ReadAllText("Library.txt");
            var arr = text.Split('_');
            var arr_copy = arr;
            int k = 0;
            for (int i = 0; i < arr.Length; i += 8)
            {
                new_ID = arr[i];
                int new_ID_1 = Convert.ToInt32(arr[i]);
                new_author = arr[i + 1];
                new_title = arr[i + 2];
                new_year_of_publication = arr[i + 3];
                //new_thematic = arr[i + 4];
                new_status = arr[i + 5];
                new_date_of_issue = arr[i + 6];
                //new_count = arr[i + 7];
                ListViewItem item = new ListViewItem(new_ID);
                item.SubItems.Add(new_author);
                item.SubItems.Add(new_title);
                item.SubItems.Add(new_year_of_publication);
                //item.SubItems.Add(new_thematic);
                item.SubItems.Add(new_status);
                item.SubItems.Add(new_date_of_issue);
                //item.SubItems.Add(new_count);
                listView1.Items.Add(item);

                Book book = new Book(new_ID_1, new_author, new_title, new_year_of_publication, new_thematic, new_status, new_date_of_issue, new_count);
                library.add_book(book);
                k++;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 archive_Form = new Form2(this);
            archive_Form.Show();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            int get_id = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Книга ID: " + textBox1.Text + " " + library.search(get_id), "Состояние книги", MessageBoxButtons.OK);
            


        }

        
    }
}
