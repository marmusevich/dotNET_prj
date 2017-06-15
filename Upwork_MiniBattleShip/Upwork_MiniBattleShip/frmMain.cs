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
        //ship type
        enum ShipType
        {
            None = 0,
            Vertical = 1,
            Horizontal = 2
        }

        //fielf state
        class FieldDiscriptions
        {
            public bool isCliced = false;
            public ShipType shipType = ShipType.None;
        }


        // game size
        const int fieldSizeX = 4;
        const int fieldSizeY = 4;

        // Distance between fields
        const int dbfx = 4;
        const int dbfy = 4;


        //colors
        Color blank = SystemColors.ControlDark;
        Color see = Color.Blue;
        Color shipHorizontal = Color.Red;
        Color shipVertical = Color.Black;

        //inner counters
        int clickCount = 0;
        int shipsCount = 0;

        // array of fields
        Label[,] lblField = new Label[fieldSizeX, fieldSizeY];

        //create all fields
        private void createField()
        {
            pnlShips.SuspendLayout();
            for (int i = 0; i < fieldSizeX; i++)
            {
                for (int j = 0; j < fieldSizeY; j++)
                {
                    lblField[i, j] = new Label();
                    lblField[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lblField[i, j].Name = "lblField" + i.ToString() + "_" + j.ToString();
                    lblField[i, j].TabIndex = i + j * fieldSizeX;
                    lblField[i, j].Click += new System.EventHandler(this.lblField_Click);

                    pnlShips.Controls.Add(lblField[i, j]);
                }
            }
            setFieldsSize();

            pnlShips.ResumeLayout(false);
            pnlShips.PerformLayout();
        }

        // set size of fields or resize
        private void setFieldsSize()
        {
            int sx = pnlShips.ClientSize.Width / fieldSizeX - dbfx;
            int sy = pnlShips.ClientSize.Height / fieldSizeY - dbfy;

            for (int i = 0; i < fieldSizeX; i++)
            {
                for (int j = 0; j < fieldSizeY; j++)
                {
                    lblField[i, j].Location = new Point(sx * i + dbfx + dbfx * i, sy * j + dbfy + dbfy * j);
                    lblField[i, j].Size = new Size(sx, sy);
                }
            }
        }

        // get map, sips position
        FieldDiscriptions[,] getMap()
        {
            FieldDiscriptions[,] fd = new FieldDiscriptions[fieldSizeX, fieldSizeY];

            for (int i = 0; i < fieldSizeX; i++)
            {
                for (int j = 0; j < fieldSizeY; j++)
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

        //start / restart geme
        private void startGame()
        {
            FieldDiscriptions[,] fd = getMap();

            for (int i = 0; i < fieldSizeX; i++)
            {
                for (int j = 0; j < fieldSizeY; j++)
                {
                    lblField[i, j].Tag = fd[i, j];
                    lblField[i, j].BackColor = blank;

                    if (fd[i, j].shipType == ShipType.Vertical || fd[i, j].shipType == ShipType.Horizontal)
                        shipsCount++;
                }
            }

            btnStart.Text = "Re start";
            lblGamaResult.Text = "";
            clickCount = 0;
        }

        // chek click on field
        private void chekField(Label lbl)
        {
            FieldDiscriptions fd = lbl.Tag as FieldDiscriptions;

            if (fd != null && !fd.isCliced)
            {
                fd.isCliced = true;
                clickCount++;

                if (fd.shipType == ShipType.Horizontal)
                {
                    lbl.BackColor = shipHorizontal;
                    chekWin();
                }
                else if (fd.shipType == ShipType.Vertical)
                {
                    lbl.BackColor = shipVertical;
                    chekWin();
                }
                else
                    lbl.BackColor = see;

            }
        }

        // check game win
        private void chekWin()
        {
            shipsCount--;
            if (shipsCount <= 0) //geme win
            {
                btnStart.Text = "Start";
                lblGamaResult.Text = "You Win! Your clicked = " + clickCount.ToString();
            }
        }

        //---------------------------------------------------------------------

        // event handlers


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
            setFieldsSize();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
