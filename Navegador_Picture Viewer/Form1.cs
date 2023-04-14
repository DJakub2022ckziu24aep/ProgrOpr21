using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przegladarka_PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Jezeli uzytkownik zaznaczy pole wyboru Rozciągnij,
            // Zmień PictureBox'y
            // własciwosc SizeMode na „Rozciągnij”. Jezeli uzytkownik wyczysci
            // pole wyboru, zmien je na „Normal”.
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Pokaz okno dialogowe. Otworz plik. Jesli użytkownik kliknie OK, zaladuj plik
            // Wybor zdjecia przez uzytkownika.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // Wyczysc obraz.
            pictureBox1.Image = null;
        }


        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Pokaz okno dialogowe kolorow. Jeśli uzytkownik kliknie OK, zmień
            // Zmiana tla PictureBox na kolor wybrany przez użytkownika
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            // Zamknij formularz.
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
