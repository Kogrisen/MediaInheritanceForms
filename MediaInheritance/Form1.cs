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
                    label_publisher.Text = "Publisher";
                    label_creator.Text = "Author";
                    input_genre.Clear();
                    label_genre.Enabled = false;
                    input_genre.Enabled = false;
                    break;
                case 1:
                    label_length_or_multiplayer.Text = "Runtime";
                    label_creator.Text = "Director";
                    label_publisher.Text = "Studio";
                    input_genre.Clear();
                    label_genre.Enabled = false;
                    input_genre.Enabled = false;
                    break;
                case 2:
                    label_length_or_multiplayer.Text = "Multiplayer";
                    label_creator.Text = "Studio";
                    label_publisher.Text = "Publisher";
                    label_genre.Enabled = true;
                    input_genre.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void submit_media_clicked(object sender, EventArgs e)
        {
            bool parse_success = false;
            string name = "";
            int length = 0;
            string creator = "";
            string publisher = "";
            string release_year = "";
            string genre = "";

            switch (cb_type_submit.SelectedIndex)
            {
                case 0:
                    while (!parse_success)
                    {

                        if (int.TryParse(input_length_or_multiplayer.Text, out length) && length > 0)
                        {
                            name = input_title.Text;
                            release_year = input_releaseyear.Text;
                            creator = input_creator.Text;
                            publisher = input_publisher.Text;
                            parse_success = true;

                            book_item.Add(new Book(name, release_year, creator, length, publisher));
                            ClearInputFields();
                        }
                        else
                        {
                            input_length_or_multiplayer.Clear();
                            input_length_or_multiplayer.Focus();
                            MessageBox.Show("\"No. of pages\" needs to be a numeric value larger then 0", "Warning");
                            break;
                        }
                    }
                    break;
                case 1:
                    parse_success = false;

                    while (!parse_success)
                    {

                        if (int.TryParse(input_length_or_multiplayer.Text, out length) && length > 0)
                        {
                            name = input_title.Text;
                            release_year = input_releaseyear.Text;
                            creator = input_creator.Text;
                            publisher = input_publisher.Text;
                            parse_success = true;

                            film_item.Add(new Film(name, release_year, creator, length, publisher));
                            ClearInputFields();
                        }
                        else
                        {
                            input_length_or_multiplayer.Clear();
                            input_length_or_multiplayer.Focus();
                            MessageBox.Show("\"Runtime\" needs to be a numeric value larger then 0 set to minutes", "Warning");
                            break;
                        }
                    }
                    break;
                case 2:
                    bool multiplayer = false;
                    name = input_title.Text;
                    release_year = input_releaseyear.Text;
                    creator = input_creator.Text;
                    publisher = input_publisher.Text;
                    genre = input_genre.Text;
                    parse_success = true;
                    if (input_length_or_multiplayer.Text == "y" || input_length_or_multiplayer.Text == "Y" || input_length_or_multiplayer.Text == "yes" || input_length_or_multiplayer.Text == "Yes")
                    {
                        multiplayer = true;
                    }
                    game_item.Add(new Game(name, genre, release_year, multiplayer, creator, publisher));
                    ClearInputFields();
                    break;
                default:
                    break;
            }
        }
        private void view_lists_clicked(object sender, EventArgs e)
        {
            box_view_selected_lists.Clear();
            switch (cb_list_view.SelectedIndex)
            {
                case 0:
                    ViewBooks();
                    break;
                case 1:
                    ViewFilms();
                    break;
                case 2:
                    ViewGames();
                    break;
                case 3:
                    ViewAllLists();
                    break;
                default:
                    break;
            }
        }

        private void ClearInputFields()
        {
            input_title.Clear();
            input_creator.Clear();
            input_length_or_multiplayer.Clear();
            input_releaseyear.Clear();
            input_publisher.Clear();
            input_genre.Clear();
        }

        private void ViewBooks()
        {
            for (int Current_item = 0; Current_item < book_item.Count; Current_item++)
            {
                box_view_selected_lists.Text += book_item[Current_item].ToString();
            }
        }

        private void ViewFilms()
        {
            for (int Current_item = 0; Current_item < film_item.Count; Current_item++)
            {
                box_view_selected_lists.Text += film_item[Current_item].ToString();
            }

        }

        private void ViewGames()
        {
            for (int Current_item = 0; Current_item < game_item.Count; Current_item++)
            {
                box_view_selected_lists.Text += game_item[Current_item].ToString();
            }

        }

        private void ViewAllLists()
        {
            ViewBooks();
            ViewFilms();
            ViewGames();
        }

    }
}
