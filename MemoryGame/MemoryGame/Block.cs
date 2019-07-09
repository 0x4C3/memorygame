using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MemoryGame
{
    public class Block : Control
    {
        public Block(string value)
        {
            base.ForeColor = Color.Black;
            base.BackColor = Color.Black;
            base.Size = new Size(45, 45);
            base.Text = value;
        }
        public bool IsDisplayed { get; set; }
        public bool IsSolved { get; set; }

        private bool IsBmp = false;


        private Bitmap bmp;
        public Bitmap Bmp
        {
            get
            {
                return bmp;
            }
            set
            {
                if (value != null)
                    IsBmp = true;
                bmp = value;
            }
        }
        protected override void OnClick(EventArgs e)
        {
            if (!IsSolved && Game.Instance.TotalClickedBlockCount < 2)
            {
                if (IsDisplayed)
                    return;
                IsDisplayed = true;
                base.Refresh();
                Game.Instance.BlockClicked();
                Task.Factory.StartNew(async () =>
                {
                    await Task.Delay(1000);
                    Game.Instance.Check(base.Text);
                });
            }

        }

        public void RefreshWithInvoke()
        {
            this.Invoke((Action)(() => base.Refresh()));
        }
        protected override void OnPaint(PaintEventArgs e)
        { 
            Graphics gfx = e.Graphics;
            Rectangle rc = ClientRectangle;
            rc.Width -= 2;
            rc.Height -= 2;
            rc.Location = new Point(1, 1);
            if (!IsSolved)
            {
                gfx.FillRectangle(new SolidBrush(Color.Gray), rc);
            }
            else
            {
                base.BackColor = Color.DarkGray;
                gfx.FillRectangle(new SolidBrush(Color.DarkGreen), rc);
            }
            if (IsDisplayed)
            {
                if (IsBmp)
                {
                    Rectangle sourceRect = new Rectangle(6, 6, this.Bmp.Width, this.Bmp.Height);
                    gfx.DrawImage((Image)this.Bmp, sourceRect);
                }
                else
                {

                    var fnt = new Font("Tahoma", (float)rc.Height * 0.4f, FontStyle.Bold, GraphicsUnit.Pixel);
                    gfx.DrawString(Text, fnt, new SolidBrush(Color.White),
                        new RectangleF((float)rc.Left, (float)rc.Top, (float)rc.Width, (float)rc.Height),
                        new StringFormat()
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        });
                }
            }

        }
    }
}
