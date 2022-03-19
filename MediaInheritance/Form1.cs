using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaInheritance
{
    public partial class Form1 : Form
    {
        static List<Book> book_item = new List<Book>();
        static List<Film> film_item = new List<Film>();
        static List<Game> game_item = new List<Game>();

        public Form1()
        {
            InitializeComponent();
        }

        private void cb_type_submit_SelectedIndexChanged(object sender, EventArgs e)
        {
            submit_clicked.Text = "Submit " + cb_type_submit.Text;

            switch (cb_type_submit.SelectedIndex)
            {
                case 0:
                    label_length_or_multiplayer.Text = "No. of pages";
                    label_publisher.Text = "Studio";
                    label_genre.Enabled = false;
                    input_genre.Enabled = false;
                    break;
                case 1:
                    label_length_or_multiplayer.Text = "Length in minutes";
                    label_genre.Enabled = false;
                    input_genre.Enabled = false;
                    break;
                case 2:
                    label_length_or_multiplayer.Text = "Multiplayer";
                    label_genre.Enabled = true;
                    input_genre.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void submit_media_clicked(object sender, EventArgs e)
        {

        }
    }
}
