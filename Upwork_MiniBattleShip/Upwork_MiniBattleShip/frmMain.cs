using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Upwork_MiniBattleShip
{
    public partial class frmMain : Form
    {
        enum ShipType
        {
            None = 0,
            Vertical = 1,
            Horizontal = 2
        }

        class FieldDiscriptions
        {
            public bool isCliced = false;
            public ShipType shipType = ShipType.None;
        }


        // game size
        const int SizeX = 4;
        const int SizeY = 4;

        // 
        const int dx = 4;
        const int dy = 4;


        //colors
        Color blank = SystemColors.ControlDark;
        Color see = Color.Blue;
        Color shipHorizontal = Color.Red;
        Color shipVertical = Color.Black;


        int clickCount = 0;


        Label[,] lblField = new Label[SizeX, SizeY];


        private void createField()
        {
            pnlShips.SuspendLayout();
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    lblField[i, j] = new Label();
                    lblField[i, j].BackColor = blank;
                    lblField[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lblField[i, j].Name = "lblField" + i.ToString() + "_" + j.ToString();
                    lblField[i, j].TabIndex = i + j * SizeX;
                    lblField[i, j].Click += new System.EventHandler(this.lblField_Click);
                    lblField[i, j].Tag = fd[i, j];

                }
            }
            setFielsSize();

            pnlShips.ResumeLayout(false);
            pnlShips.PerformLayout();
        }


        private void setFielsSize()
        {
            int sx = pnlShips.ClientSize.Width / SizeX - dx;
            int sy = pnlShips.ClientSize.Height / SizeY - dy;

            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    lblField[i, j].Location = new Point(sx * i + dx + dx * i, sy * j + dy + dy * j);
                    lblField[i, j].Size = new Size(sx, sy);
                }
            }
        }




        FieldDiscriptions[,] getMap()
        {
            FieldDiscriptions[,] fd = new FieldDiscriptions[SizeX, SizeY];

            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    fd[i, j] = new FieldDiscriptions();
                }
            }

            fd[1, 0].shipType = ShipType.Vertical;
            fd[1, 1].shipType = ShipType.Vertical;

            fd[2, 3].shipType = ShipType.Horizontal;
            fd[3, 3].shipType = ShipType.Horizontal;

            return fd;
        }

        private void startGame()
        {
            FieldDiscriptions[,] fd = getMap();

            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    lblField[i, j].Tag = fd[i, j];
                }
            }


            clickCount = 0;
        }


        private void chekField(Label lbl)
        {
            FieldDiscriptions fd = lbl.Tag as FieldDiscriptions;

            if (fd != null && !fd.isCliced)
            {
                fd.isCliced = true;
                clickCount++;

                if (fd.shipType == ShipType.Horizontal)
                    lbl.BackColor = shipHorizontal;
                else if (fd.shipType == ShipType.Vertical)
                    lbl.BackColor = shipVertical;
                else
                    lbl.BackColor = see;

            }
        }


        //---------------------------------------------------------------------



        public frmMain()
        {
            InitializeComponent();

            createField();

            startGame();
        }



        private void lblField_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl != null)
                chekField(lbl);
        }


        private void pnlShips_ClientSizeChanged(object sender, EventArgs e)
        {
            setFielsSize();
        }
    }
}
