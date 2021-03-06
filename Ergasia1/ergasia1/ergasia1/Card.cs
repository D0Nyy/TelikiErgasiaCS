﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public class Card : PictureBox // klironomei apo to PictureBox
    {
        private Image Img { set; get;}  // Edo tha apothikevoume thn eikona tou meso tou constractora.

        public string ImagePathLocation { get; set; }

        private bool Hidden { get; set; } // Flag gia na kseroume an einai flipped h oxi

        public Card(string imagePath)
        {
            // Kalo thn sinartisi pou allazei thn eikona ths kartas
            this.ChangeImage(imagePath);

            // flip it
            this.Hidden = true;
            this.Image = Properties.Resources.back;
        }

        /// <summary>
        /// Flips the card.
        /// </summary>
        public void Flip()
        {
            if (Hidden) // an h karta dixnei thn krimenh plevra
            {
                this.Image = Img; // Show image
                this.Hidden = false;
            }
            else
            {
                this.Image = Properties.Resources.back; // Hide image
                this.Hidden = true;
            }
        }

        // Allazei thn eikona ths kartas
        public void ChangeImage(string imagePath)
        {
            Img = Image.FromFile(imagePath);
            ImagePathLocation = imagePath;
        }
    }
}
