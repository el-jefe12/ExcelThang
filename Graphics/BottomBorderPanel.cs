using System.Drawing;
using System.Windows.Forms;

class BottomBorderPanel : Panel
{
    public BottomBorderPanel()
    {
        // Set the background color if needed
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.DrawLine(Pens.LightGray, 0, Height - 1, Width, Height - 1);
    }
}
