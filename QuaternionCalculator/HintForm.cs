using System.Windows.Forms;

namespace QuaternionCalculator
{
    public partial class HintForm : Form
    {
        private static readonly ToolTip ToolTip = new ToolTip();
        private const string ToolTipText = "Rotations are counter clockwise, when observed \r\nfrom the center along the positive axis.";

        public HintForm()
        {
            InitializeComponent();

            ToolTip.SetToolTip(pictureBox1, ToolTipText);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }
    }
}
