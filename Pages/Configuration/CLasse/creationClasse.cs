﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formjdrppe
{
    public partial class creationClasse : Form
    {
        public creationClasse()
        {
            InitializeComponent();
        }

        private void creationClasse_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {



            string Name = textBoxNom.Text;

            int Life_point = Convert.ToInt32(textBoxPv.Text);

            int Strength = Convert.ToInt32(textBoxFo.Text);

            int Intelligence = Convert.ToInt32(textBoxInt.Text);

            int Agility = Convert.ToInt32(textBoxAgi.Text);

            int Initiative = Convert.ToInt32(textBoxIni.Text);

            int Social = Convert.ToInt32(textBoxSocial.Text);

            CreateClasse classe = new CreateClasse(Name, Life_point, Strength, Agility, Intelligence,  Initiative, Social);
               

             
            string response = await api.CreateAsync("classes", classe);

            MessageBox.Show(response);


            this.Close();
        }
    }
}
