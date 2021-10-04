using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropApp
{
    class Kitchen : Form
    {
        Panel Header;
        Panel Main;
        Panel Aside;

        private int ctIng;

        public Kitchen()
        {
            Header = new Panel();
            Main = new Panel();
            Aside = new Panel();
            ctIng = 0;
            layout();
        }

        private void layout()
        {
            this.Size = new Size(705, 500);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            setHeader(Header);
            setAside(Aside);
            setMain(Main);
        }

        private void setHeader(Panel header)
        {
            header.Size = new Size(705, 100);
            header.Location = new Point(0, 0);
            header.BorderStyle = BorderStyle.FixedSingle;
            header.BackColor = Color.LightPink;

            setPozaHeader(header);
            setExit(header);

            Controls.Add(header);
        }

        private void setPozaHeader(Panel header)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(150, 100);
            pic.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\ChocolateChipCookies.bmp");
            pic.BackgroundImageLayout = ImageLayout.Stretch;

            header.Controls.Add(pic);
        }

        private void setExit(Panel header)
        {
            Button btnExit = new Button();
            btnExit.Size = new Size(25, 25);
            btnExit.Location = new Point(670, 5);
            btnExit.BackColor = Color.HotPink;
            btnExit.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\exit.png");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;

            btnExit.Click += BtnExit_Click;

            header.Controls.Add(btnExit);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setAside(Panel aside)
        {
            aside.Size = new Size(150, 400);
            aside.Location = new Point(0, 100);
            aside.BorderStyle = BorderStyle.FixedSingle;
            aside.BackColor = Color.LightPink;

            setLblIngrediente(aside);
            chkIngrediente(aside);
            picBucatar(aside);

            Controls.Add(aside);
        }

        private void setLblIngrediente(Panel aside)
        {
            Label label = new Label();
            label.Text = "Ingredients:";
            label.Location = new Point(5, 5);
            label.Size = new Size(100, 15);

            aside.Controls.Add(label);
        }

        private void chkIngrediente(Panel aside)
        {
            CheckBox chkIngredient = new CheckBox();
            chkIngredient.Name = "chkOua";
            chkIngredient.Text = "2 eggs";
            chkIngredient.Location = new Point(5, 20);
            chkIngredient.Enabled = false;

            aside.Controls.Add(chkIngredient);


            CheckBox chkIngredient2 = new CheckBox();

            chkIngredient2.Name = "chkLapte";
            chkIngredient2.Text = "2 cups milk";
            chkIngredient2.Location = new Point(5, 45);
            chkIngredient2.Enabled = false;

            aside.Controls.Add(chkIngredient2);


            CheckBox chkIngredient3 = new CheckBox();
            chkIngredient3.Name = "chkFaina";
            chkIngredient3.Text = "3 cups all-purpose flour";
            chkIngredient3.Size = new Size(150, 20);
            chkIngredient3.Location = new Point(5, 70);
            chkIngredient3.Enabled = false;
            aside.Controls.Add(chkIngredient3);


            CheckBox chkIngredient4 = new CheckBox();
            chkIngredient4.Name = "chkZahar";
            chkIngredient4.Text = "1 cup white sugar";
            chkIngredient4.Size = new Size(150, 20);
            chkIngredient4.Location = new Point(5, 95);
            chkIngredient4.Enabled = false;

            aside.Controls.Add(chkIngredient4);

            CheckBox chkIngredient5 = new CheckBox();
            chkIngredient5.Name = "chkPraf";
            chkIngredient5.Text = "1 teaspoon baking soda";
            chkIngredient5.Size = new Size(150, 20);
            chkIngredient5.Location = new Point(5, 120);
            chkIngredient5.Enabled = false;

            aside.Controls.Add(chkIngredient5);


            CheckBox chkIngredient6 = new CheckBox();
            chkIngredient6.Name = "chkChip";
            chkIngredient6.Text = "2 cups chocolate chips";
            chkIngredient6.Size = new Size(150, 20);
            chkIngredient6.Location = new Point(5, 145);
            chkIngredient6.Enabled = false;
            aside.Controls.Add(chkIngredient6);

            CheckBox chkIngredient7 = new CheckBox();
            chkIngredient7.Name = "chkSare";
            chkIngredient7.Text = "1/2 teaspoon salt";
            chkIngredient7.Size = new Size(150, 20);
            chkIngredient7.Location = new Point(5, 170);
            chkIngredient7.Enabled = false;
            aside.Controls.Add(chkIngredient7);

            CheckBox chkIngredient8 = new CheckBox();
            chkIngredient8.Name = "chkUnt";
            chkIngredient8.Text = "1 cup butter";
            chkIngredient8.Size = new Size(150, 20);
            chkIngredient8.Location = new Point(5, 195);
            chkIngredient8.Enabled = false;

            aside.Controls.Add(chkIngredient8);

        }

        private void picBucatar(Panel aside)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(100, 150);
            pic.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\chef.jpg");
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Location = new Point(25, 215);
            pic.BorderStyle = BorderStyle.Fixed3D;

            aside.Controls.Add(pic);
        }

        private void setMain(Panel main)
        {
            main.Size = new Size(555, 400);
            main.Location = new Point(150, 100);
            main.BorderStyle = BorderStyle.FixedSingle;

            picOua(main);
            picLapte(main);
            picFaina(main);
            picZahar(main);
            picPraf(main);
            picChip(main);
            picSare(main);
            picUnt(main);

            lblAdd(main);
            lblItemAdd(main);

            picItem(main);
            picTava(main);
            picCuptor(main);

            picBol(main);

            Controls.Add(main);
        }

        private void picBol(Panel main)
        {
            PictureBox picBol = new PictureBox();

            picBol.Size = new Size(120, 120);
            picBol.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\bowl1.bmp");
            picBol.BackgroundImageLayout = ImageLayout.Stretch;
            picBol.Location = new Point(215, 10);
            picBol.BorderStyle = BorderStyle.Fixed3D;
            picBol.AllowDrop = true;
            picBol.Name = "picBol";

            picBol.MouseDown += PicBol_MouseDown;
            picBol.DragEnter += PicBol_DragEnter;
            picBol.DragDrop += PicBol_DragDrop;

            main.Controls.Add(picBol);

        }

        private void PicBol_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picTava")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void PicBol_DragDrop(object sender, DragEventArgs e)
        {
            if (ctIng <= 9)
            { 
                PictureBox picDrop = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picBol")
                    {
                        picDrop = x as PictureBox;
                    }
                }

                String nume = e.Data.GetData(DataFormats.Text).ToString();

                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == nume)
                    {
                        picDrag = x as PictureBox;
                    }
                }

                String lista = nume.Replace("pic", "chk");

                CheckBox check = new CheckBox();
                foreach (Control x in Aside.Controls)
                {
                    if (x.Name == lista)
                    {
                        check = x as CheckBox;
                    }
                }

                check.Enabled = true;
                check.Checked = true;
                check.Enabled = false;

                Label lblAdd = new Label();
                Label lblItem = new Label();
                PictureBox picItem = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "lblAdd")
                    {
                        lblAdd = x as Label;
                    }
                    if (x.Name == "lblItem") 
                    {
                        lblItem = x as Label;
                    }
                    if (x.Name == "picItem")
                    {
                        picItem = x as PictureBox;
                    }
                }
                lblAdd.Visible = true;
                lblItem.Text = check.Text;
                lblItem.Visible = true;
                picItem.BackgroundImage = picDrag.BackgroundImage;
                picItem.Visible = true;

                ctIng++;

                Main.Controls.Remove(picDrag);

                if (ctIng == 8)
                {
                    lblAdd.Visible = false;
                    lblItem.Visible = false;
                    picItem.Visible = false;
                    PictureBox picTava = new PictureBox();
                    foreach (Control x in Main.Controls)
                    {
                        if (x.Name == "picTava")
                        {
                            picTava = x as PictureBox;
                        }
                    }
                    picTava.Visible = true;
                }

                if (ctIng == 3)
                {
                    picDrop.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\bowl2.bmp");
                }
                if (ctIng == 6)
                {
                    picDrop.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\bowl3.bmp");
                }
            }
        }

        private void PicBol_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void picOua(Panel main)
        {
            PictureBox picOua = new PictureBox();

            picOua.Size = new Size(120, 120);
            picOua.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\eggs.bmp");
            picOua.BackgroundImageLayout = ImageLayout.Stretch;
            picOua.Location = new Point(15, 135);
            picOua.BorderStyle = BorderStyle.Fixed3D;
            picOua.Name = "picOua";

            picOua.MouseDown += PicOua_MouseDown;

            main.Controls.Add(picOua);
        }

        private void PicOua_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picOua")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picLapte(Panel main)
        {
            PictureBox picLapte = new PictureBox();

            picLapte.Size = new Size(120, 120);
            picLapte.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\milk.bmp");
            picLapte.BackgroundImageLayout = ImageLayout.Stretch;
            picLapte.Location = new Point(150, 135);
            picLapte.BorderStyle = BorderStyle.Fixed3D;
            picLapte.Name = "picLapte";

            picLapte.MouseDown += PicLapte_MouseDown;

            main.Controls.Add(picLapte);
        }

        private void PicLapte_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picLapte")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picFaina(Panel main)
        {
            PictureBox picFaina = new PictureBox();

            picFaina.Size = new Size(120, 120);
            picFaina.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\flour.bmp");
            picFaina.BackgroundImageLayout = ImageLayout.Stretch;
            picFaina.Location = new Point(285, 135);
            picFaina.BorderStyle = BorderStyle.Fixed3D;
            picFaina.Name = "picFaina";

            picFaina.MouseDown += PicFaina_MouseDown;

            main.Controls.Add(picFaina);
        }

        private void PicFaina_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picFaina")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picZahar(Panel main)
        {
            PictureBox picZahar = new PictureBox();

            picZahar.Size = new Size(120, 120);
            picZahar.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\sugar.bmp");
            picZahar.BackgroundImageLayout = ImageLayout.Stretch;
            picZahar.Location = new Point(420, 135);
            picZahar.BorderStyle = BorderStyle.Fixed3D;
            picZahar.Name = "picZahar";

            picZahar.MouseDown += PicZahar_MouseDown;

            main.Controls.Add(picZahar);
        }

        private void PicZahar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picZahar")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picPraf(Panel main)
        {
            PictureBox picPraf = new PictureBox();

            picPraf.Size = new Size(120, 120);
            picPraf.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\bakingsoda.bmp");
            picPraf.BackgroundImageLayout = ImageLayout.Stretch;
            picPraf.Location = new Point(15, 260);
            picPraf.BorderStyle = BorderStyle.Fixed3D;
            picPraf.Name = "picPraf";

            picPraf.MouseDown += PicPraf_MouseDown;
            main.Controls.Add(picPraf);
        }

        private void PicPraf_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picPraf")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picChip(Panel main)
        {
            PictureBox picChip = new PictureBox();

            picChip.Size = new Size(120, 120);
            picChip.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\ChocolateChips.bmp");
            picChip.BackgroundImageLayout = ImageLayout.Stretch;
            picChip.Location = new Point(150, 260);
            picChip.BorderStyle = BorderStyle.Fixed3D;
            picChip.Name = "picChip";

            picChip.MouseDown += PicChip_MouseDown;

            main.Controls.Add(picChip);
        }

        private void PicChip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picChip")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picSare(Panel main)
        {
            PictureBox picSare = new PictureBox();

            picSare.Size = new Size(120, 120);
            picSare.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\salt.bmp");
            picSare.BackgroundImageLayout = ImageLayout.Stretch;
            picSare.Location = new Point(285, 260);
            picSare.BorderStyle = BorderStyle.Fixed3D;
            picSare.Name = "picSare";

            picSare.MouseDown += PicSare_MouseDown;

            main.Controls.Add(picSare);
        }

        private void PicSare_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picSare")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void picUnt(Panel main)
        {
            PictureBox picUnt = new PictureBox();

            picUnt.Size = new Size(120, 120);
            picUnt.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\butter.bmp");
            picUnt.BackgroundImageLayout = ImageLayout.Stretch;
            picUnt.Location = new Point(420, 260);
            picUnt.BorderStyle = BorderStyle.Fixed3D;
            picUnt.Name = "picUnt";

            picUnt.MouseDown += PicUnt_MouseDown;

            main.Controls.Add(picUnt);
        }

        private void PicUnt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picDrag = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picUnt")
                        picDrag = x as PictureBox;
                }
                picDrag.DoDragDrop(picDrag.Name, DragDropEffects.Move);
            }
        }

        private void lblAdd(Panel main)
        {
            Label lblAdd = new Label();
            lblAdd.Name = "lblAdd";
            lblAdd.Text = "You added:";
            lblAdd.Size = new Size(100, 20);
            lblAdd.Location = new Point(340, 10);
            lblAdd.Visible = false;

            main.Controls.Add(lblAdd);
        }

        private void lblItemAdd(Panel main)
        {
            Label lblItem = new Label();
            lblItem.Name = "lblItem";
            lblItem.Text = "You added:";
            lblItem.Size = new Size(300, 20);
            lblItem.Location = new Point(340, 30);
            lblItem.Visible = false;

            main.Controls.Add(lblItem);
        }

        private void picItem(Panel main)
        {
            PictureBox picItem = new PictureBox();

            picItem.Size = new Size(70, 70);
            picItem.BackgroundImageLayout = ImageLayout.Stretch;
            picItem.Location = new Point(380, 60);
            picItem.BorderStyle = BorderStyle.Fixed3D;
            picItem.Name = "picItem";
            picItem.Visible = false;

            main.Controls.Add(picItem);
        }

        private void picTava(Panel main)
        {
            PictureBox picTava = new PictureBox();

            picTava.Size = new Size(170, 120);
            picTava.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\emptytray.bmp");
            picTava.BackgroundImageLayout = ImageLayout.Stretch;
            picTava.Location = new Point(25, 10);
            picTava.BorderStyle = BorderStyle.Fixed3D;
            picTava.Name = "picTava";
            picTava.Visible = false;
            picTava.AllowDrop = true;

            picTava.DragEnter += PicTava_DragEnter;
            picTava.DragDrop += PicTava_DragDrop;

            main.Controls.Add(picTava);
        }

        private void PicTava_DragDrop(object sender, DragEventArgs e)
        {


            PictureBox picDrop = new PictureBox();
            PictureBox picTava = new PictureBox();
            PictureBox picCuptor = new PictureBox();
            foreach (Control x in Main.Controls)
            {
                if (x.Name == "picBol")
                {
                    picDrop = x as PictureBox;
                }
                if (x.Name == "picTava")
                {
                    picTava = x as PictureBox;
                }
                if (x.Name == "picCuptor")
                {
                    picCuptor = x as PictureBox;
                }
            }

            picDrop.Visible = false;
            picTava.Location = new Point(190, 10);
            picTava.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\tray.bmp");
            picTava.MouseDown += PicTava_MouseDown;
            picCuptor.Visible = true;
        }

        private void PicTava_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picTava = new PictureBox();
                foreach (Control x in Main.Controls)
                {
                    if (x.Name == "picTava")
                        picTava = x as PictureBox;
                }
                picTava.DoDragDrop(picTava.Name, DragDropEffects.Move);
            }
        }

        private void PicTava_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void picCuptor(Panel main)
        {
            PictureBox picCuptor = new PictureBox();

            picCuptor.Size = new Size(200, 200);
            picCuptor.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\oven.bmp");
            picCuptor.BackgroundImageLayout = ImageLayout.Stretch;
            picCuptor.Location = new Point(175, 150);
            picCuptor.BorderStyle = BorderStyle.Fixed3D;
            picCuptor.Name = "picCuptor";
            picCuptor.Visible = false;
            picCuptor.AllowDrop = true;

            picCuptor.DragEnter += PicCuptor_DragEnter;
            picCuptor.DragDrop += PicCuptor_DragDrop;

            main.Controls.Add(picCuptor);
        }

        private void PicCuptor_DragDrop(object sender, DragEventArgs e)
        {
            Main.Controls.Clear();
            Main.BackgroundImage = Image.FromFile(@"D:\C#\UIdesign\Dinamic\DragAndDropApp\DragAndDropApp\bin\Debug\resurse\cookies.bmp");
            Main.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void PicCuptor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
