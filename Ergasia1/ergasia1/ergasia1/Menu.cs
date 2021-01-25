﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public partial class Menu : Form
    {
        private List<string> images;
        List<string> playersName = new List<string>();
        private String connectionString = "Data Source=c:DB1.db;Version=3;";

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timerWelcome.Start();
            buttonBack.Hide();

            panelSettings.Hide();

            // Get images from a folder
            images = Directory.GetFiles(@"Cards\Default", "*jpg").ToList(); 
            images.AddRange(Directory.GetFiles(@"Cards\Default", "*png").ToList()); 
            images.AddRange(Directory.GetFiles(@"Cards\Default", "*bmp").ToList());

            // Otan ksekinaei to programma o xrhsths mporei na dei to leaderboard me tous prohgoumenous paiktes
            using (SQLiteConnection conn = new SQLiteConnection(connectionString)) //(automatically closes the connection)
            {
                conn.Open();
                string selectQuery = "Select Name FROM Users";
                SQLiteCommand cmd1 = new SQLiteCommand(selectQuery, conn);
                SQLiteDataReader reader = cmd1.ExecuteReader();

                // Vazei tou paiktes pou einai sthn DM sth lista player h opoia meta fortwnetai kai emfanizetai sto listbox1 (=Leaderboard)
                if (reader.Read())
                {
                    Players player = new Players(reader.GetValue(0).ToString());
                    playersName.Add(player.name);
                }
            }
        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        {
            if (labelWelcome.BackColor == Color.DodgerBlue)
            {
                labelWelcome.BackColor = Color.Black;
                labelWelcome.ForeColor = Color.DodgerBlue;
            }
            else
            {
                labelWelcome.ForeColor = Color.Black;
                labelWelcome.BackColor = Color.DodgerBlue;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            panelWelcome.Hide();
            buttonExit.Hide();
            
            buttonBack.Show();

            panelSettings.Show();
            panelSettings.Location = new Point(330, panelSettings.Location.Y);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelWelcome.Show();
            buttonExit.Show();

            buttonBack.Hide();
            
            panelSettings.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                buttonPlay.Enabled = false;
            }
            else
            {
                buttonPlay.Enabled = true;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            string name2 = textBoxName.Text;
            Players player = new Players(name2);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString)) //(automatically closes the connection)
            {
                conn.Open();
                // elegxei mesa sthn DB an to onoma pou ebale o xrhsths sto textbox uparxei hdh
                /* to ekana etsi giati ta onomata sthn database den einai tikarismena ws monadika dioti o kathe paikths exei polles
                   prospatheies, dld to idio name exei polla times kai attemps. Kai auto sumbainei dioti sto telos ths askhshs leei
                   na deixnoume tis 10 kaluteres prospatheies twn paiktwn, ara oi prospatheies sto idio name einai parapanw apo 1. */
                string selectQuery = "Select Name FROM Users WHERE Name = @name;";
                SQLiteCommand cmd1 = new SQLiteCommand(selectQuery, conn);
                cmd1.Parameters.AddWithValue("@name", name2); // safe way

                SQLiteDataReader reader = cmd1.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("This username already exists!");
                    return;
                }
                else
                {
                    playersName.Add(player.name); // kanei add to name sth lista pou xrhsimopoieitai gia to leaderboard
                }

                Game game = new Game(new List<string>(images), textBoxName.Text);

                this.Hide();
                game.ShowDialog();
                this.Show();

            }

        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get images from a folder
                var tempImages = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*jpg").ToList();
                tempImages.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*png").ToList());
                tempImages.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*bmp").ToList());

                if (tempImages.Count >= 12)
                {
                    tempImages.RemoveRange(11, tempImages.Count - 12);
                    images = tempImages;
                    Console.WriteLine(tempImages.Count);
                    MessageBox.Show("Images selected succsessfully!");
                }
                else
                {
                    MessageBox.Show("Error! The images in your folder must be 12 or above.");
                }
            }

        }

        // Show Attemps
        private void buttonShowLeaderboard_Click(object sender, EventArgs e)
        {
            TopPlayers topPlayers = new TopPlayers(playersName); // stelnoume th lista me ta onomata meso constractora

            this.Hide();
            topPlayers.ShowDialog();
            this.Show();
        }
    }
}
