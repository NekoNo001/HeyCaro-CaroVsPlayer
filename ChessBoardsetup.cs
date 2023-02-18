using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public class ChessBoardsetup
    {
        #region Properties
        private Panel banco;
        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }

        private int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private TextBox playername;
        public TextBox PlayerName { get => playername; set => playername = value; }

        private PictureBox playermark;
        public PictureBox playerMark { get => playermark; set => playermark = value; }

        private List<List<Button>> matrix;

        private TextBox playerscore1;

        public TextBox PlayerScore1 { get => playerscore1; set => playerscore1 = value; }

        private TextBox playerscore2;

        public TextBox PlayerScore2 { get => playerscore2; set => playerscore2 = value; }


        //tao mang ma tran 
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        #endregion

        #region Intitialize
        public ChessBoardsetup(Panel banco, TextBox playername, PictureBox mark, TextBox score1, TextBox score2)
        {
            this.banco = banco;
            this.PlayerName = playername;
            this.playerMark = mark ;
            this.PlayerScore1 = score1;
            this.PlayerScore2 = score2;
            //tao ra 2 nguoi choi
            this.Player = new List<Player>()
            {
                 new Player("Người Chơi 1",  Image.FromFile(Application.StartupPath+"\\Resources\\X.png"),0),
                 new Player("Người Chơi 2",  Image.FromFile(Application.StartupPath+"\\Resources\\O.png"),0)
            };

            PlayerScore1.Text = getscore1().ToString();
            PlayerScore2.Text = getscore2().ToString();
        }

        #endregion

        #region Methods

        public void resetscore()
        {
            banco.Controls.Clear();
            Player[0].Score = 0;
            Player[1].Score = 0;
            PlayerScore1.Text = getscore1().ToString();
            PlayerScore2.Text = getscore2().ToString();
        }
        public void vebanco()
        {
            
            banco.Controls.Clear();
            CurrentPlayer = 0;
            changeplayer();
            //tao ma tran
            Matrix = new List<List<Button>>();

            //tao ra button truoc do
            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i <= cons.board_height; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < cons.board_width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = cons.chess_width,
                        Height = cons.chess_heigh,
                        //lay vi tri cua oldbutton de xac dinh cho vi tri button lien ke
                        Location = new Point(oldbutton.Location.X + cons.chess_width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        //tag dung de xac dinh cot
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;

                    banco.Controls.Add(btn);

                    matrix[i].Add(btn);

                    oldbutton = btn;
                }
                //xuong hang, tao lai toa do moi cho oldbutton
                oldbutton.Location = new Point(0, oldbutton.Location.Y + cons.chess_heigh);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
        }
        
        //su ly su kien click va doi nguoi choi
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackgroundImage!= null)
                return;
            mark(btn);
            changeplayer();

            if (isEndgame(btn))
            {
                Endgame();
            }
        }

        private void Endgame()
        {
            if (currentPlayer == 1)
            {
                MessageBox.Show(Player[0].Name + " Chiến thắng");
                player[0].Score++;
                PlayerScore1.Text = getscore1().ToString();
            }
            else
            {
                MessageBox.Show(Player[1].Name + " Chiến thắng");
                player[1].Score++;
                PlayerScore2.Text = getscore2().ToString();
            }
            banco.Controls.Clear();
            vebanco();
        }

        private bool isEndgame(Button btn)
        {
            return hangngang(btn) || hangdoc(btn) || hangcheochinh(btn) || hangcheophu(btn);
        }

        private Point getchesspoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal,vertical);

            return point;
        }

        private bool hangngang(Button btn)
        {
            Point point = getchesspoint(btn);

            int countleft = 0;
            for(int i = point.X; i >= 0; i--)
            {
                if (matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countleft++;
                }
                else break;
            }

            int countright= 0;
            for (int i = point.X+1; i < cons.board_width; i++)
            {
                if (matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countright++;
                }
                else break;
            }
            return countleft + countright >= 5;
        }

        private bool hangdoc(Button btn)
        {
            Point point = getchesspoint(btn);

            int counttop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    counttop++;
                }
                else break;
            }

            int countbottom = 0;
            for (int i = point.Y + 1; i < cons.board_height; i++)
            {
                if (matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countbottom++;
                }
                else break;
            }
            return counttop + countbottom >= 5;
        }

        private bool hangcheochinh(Button btn)
        {
            Point point = getchesspoint(btn);

            int counttop = 0;
            for (int i =0; i <=point.X ; i++)
            {
                //kiem tra co ra khoi mang khong
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    counttop++;
                }
                else break;
            }

            int countbottom = 0;
            for (int i = 1; i <= cons.board_width - point.X; i++)
            {
                //kiem tra co ra khoi mang khong
                if (point.Y + i >= cons.board_height || point.X + i >= cons.board_width)
                    break;
                if (matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countbottom++;
                }
                else break;
            }
            return counttop + countbottom >= 5;
        }

        private bool hangcheophu(Button btn)
        {
            {
                Point point = getchesspoint(btn);

                int counttop = 0;
                for (int i = 0; i <= point.X; i++)
                {
                    //kiem tra co ra khoi mang khong
                    if (point.X + i > cons.board_width|| point.Y - i < 0)
                        break;
                    if (matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    {
                        counttop++;
                    }
                    else break;
                }

                int countbottom = 0;
                for (int i = 1; i <= cons.board_width - point.X; i++)
                {
                    //kiem tra co ra khoi mang khong
                    if (point.Y + i >= cons.board_height || point.X - i <0)
                        break;

                    if (matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    {
                        countbottom++;
                    }
                    else break;
                }
                return counttop + countbottom >= 5;
            }
        }

        private void mark(Button btn)
        {
            btn.BackgroundImage = Player [CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        private void changeplayer()
        {
            PlayerName.Text = Player[currentPlayer].Name;
            playerMark.Image = Player[currentPlayer].Mark;
        }

        private int getscore1()
        {
            return player[0].Score;
        }

        private int getscore2()
        {
            return player[1].Score;
        }
        #endregion
    }
}

