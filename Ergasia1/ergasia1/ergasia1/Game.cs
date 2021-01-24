﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public partial class Game : Form
    {
        private Random random;

        private Card first;
        private Card second;

        private List<string> images;

        string username;
        int time = 0;

        // na tou valoume na dexete:
        // 1. Onoma pexth
        public Game(List<string> imageList, string user)
        {
            InitializeComponent();
            images = imageList;
            username = user;
        }

        // kanei th images random
        // afto einai poli paromio me kati pou vrika sto google elpizo min theorithei antigrafh :(((((
        private List<string> Randomize(List<string> images)
        {
            var randomizedImages = new List<string>();
            while (images.Count > 0)
            {
                int index = random.Next(0, images.Count);
                randomizedImages.Add(images[index]);
                images.RemoveAt(index);
            }
            return randomizedImages;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            labelUsername.Text = username;
            labelTime.Text = time.ToString();

            // Initialize Random
            random = new Random((int)DateTime.Now.Ticks);

            images.AddRange(images); // add the same images. so 12 + 12
            images = Randomize(images); // randomize it

            // Create 24 cards | 6 X 4 
            // to aplopiisa poli
            // to int name einai axristo min sas niazei to aferoume an einai
            int name = 0;
            for (int i = 0; i < 24; i++)
            {
                var card = new Card(images[i])
                {
                    Size = new Size(100, 100),
                    Margin = new Padding(4), // To keno metaksi kathe eikonas einai 4 pixels
                    BorderStyle = BorderStyle.FixedSingle, // na exoun border oi kartes
                    Cursor = Cursors.Hand, // Add hand cursor when hovering over it
                    Name = name++.ToString(), // give it a name
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // tou dinoume ena event handel gia otan pataei o xrhsths click pano tou
                card.MouseClick += Card_Click;
                 
                // Prosthetoume thn karta sto panel
                flowLayoutPanelCards.Controls.Add(card);
            }
        }

        // Trexei kathe fora pou o xrisths pataei mia apo tis kartes
        // Tsekarei an oi 2 eikones pou patise einai idies( vash to path )
        // prepei na valoume ena timer sto deftero click giati: otan patame to deftero an einai lathos o sindiasmos den tha to diksei kan giati to 
        // girnaei kai to ksanagirnaei poli grigora. ara prepei na valoume ena timer otan to girnaei na perimenei 500ms kai meta na to ksanagirnaei
        // gia na dei o xrhshts ti ekane lathos
        private void Card_Click(object sender, EventArgs e)
        {
            if (time == 0)
            {
                timerGameDuration.Start();
            }

            // Etsi prosdiourizoume pia karta patithike
            Card clicked = (Card)sender;

            // Emfanizoume to onoma ths kartas pou patithike
            Console.WriteLine($"Clicked card '{clicked.Name}'");
            clicked.Flip();

            if (first == null)
            {
                first = clicked;
            }
            else
            {
                if (clicked != first) // an ksanapatisei to idio kse-epilekse to
                {
                    second = clicked;
                    if (first.ImagePathLocation == second.ImagePathLocation) 
                    {
                        // an einai sosta ta kanoume disable oste na min mporei na ta patisei pali
                        Console.WriteLine($"CORRECT {first.Name} the same as {second.Name}");
                        first.Enabled = false;
                        second.Enabled = false;

                        // reset clicked
                        first = null;
                        second = null;
                    }
                    else
                    {
                        // hide them again if wrong
                        Task.Run(() =>
                        {
                            Invoke(new Action(() => { flowLayoutPanelCards.Enabled = false; }));

                            Thread.Sleep(500); // 750ms pause

                            Invoke(new Action(() =>
                            {
                                first.Flip();
                                second.Flip();
                                first = null;
                                second = null;
                                flowLayoutPanelCards.Enabled = true;
                            }));
                        });
                        Console.WriteLine($"WRONG {first.Name} not the same as {second.Name}");
                    }
                }
                else
                {
                    first = null;
                }
            }
        }

        private void timerGameDuration_Tick(object sender, EventArgs e)
        {
            time++;
            labelTime.Text = time.ToString();
        }
    }
}
