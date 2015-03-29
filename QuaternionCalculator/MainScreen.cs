using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuaternionCalculator
{
    public partial class MainScreen : Form
    {
        private readonly ViewModel _vm = new ViewModel();
        private HintForm _hintForm;
        
        public MainScreen()
        {
            InitializeComponent();

            InitializeGrid();

            InitializeTooltip();
        }

        private void InitializeGrid()
        {
            grid.Rows.Clear();

            grid.Rows.Add(Media3DModel.Actions.Pitch, "Pitch - rotate around X", null);
            grid.Rows.Add(Media3DModel.Actions.Yaw, "Yaw   - rotate around Y", null);
            grid.Rows.Add(Media3DModel.Actions.Roll, "Roll  - rotate around Z", null);

            grid.CellValueChanged += OnTextChanged;
        }

        private void InitializeTooltip()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(btnUp, "Move up");
            toolTip.SetToolTip(btnDown, "Move down");
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            TriggerCalculation();
        }

        private void TriggerCalculation()
        {
            GetOrderOfActions();
            ParseDegrees();

            _vm.Calculate();

            UpdateQuaternionText();
        }

        private void GetOrderOfActions()
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                var row = grid.Rows[i];
                var id = (Media3DModel.Actions) row.Cells["ActionId"].Value;
                _vm.Actions[i] = id;
            }
        }

        private void ParseDegrees()
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                var row = grid.Rows[i];
                var id = (Media3DModel.Actions)row.Cells["ActionId"].Value;
                var value = row.Cells["Degrees"].Value ?? string.Empty;
                switch (id)
                {
                    case Media3DModel.Actions.Pitch:
                        _vm.Pitch = TryParse(value.ToString());
                        continue;
                    case Media3DModel.Actions.Yaw:
                        _vm.Yaw = TryParse(value.ToString());
                        continue;
                    case Media3DModel.Actions.Roll:
                        _vm.Roll = TryParse(value.ToString());
                        continue;
                }
            }
        }

        private static int TryParse(string str)
        {
            int i;
            int.TryParse(str, out i);
            return i;
        }

        private void UpdateQuaternionText()
        {
            ColorizeAndSetTextBox(txtQX, _vm.X);
            ColorizeAndSetTextBox(txtQY, _vm.Y);
            ColorizeAndSetTextBox(txtQZ, _vm.Z);
            ColorizeAndSetTextBox(txtQW, _vm.W);
        }

        private static void ColorizeAndSetTextBox(TextBox tb, double value)
        {
            tb.Text = value.ToString();
            tb.ForeColor = value < 0 ? Color.Brown : Color.RoyalBlue;
        }

        private void OnCopyXmlClick(object sender, EventArgs e)
        {
            _vm.CopyXmlToClipboard();
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            _vm.CopyToClipboard();
        }

        private void OnButtonUpClick(object sender, EventArgs e)
        {
            if (grid.RowCount == 0 || grid.SelectedRows.Count != 1)
            {
                return;
            }
            var row = grid.SelectedRows[0];
            var index = grid.Rows.IndexOf(row);
            if (index == 0)
            {
                return;
            }
            var partnerRow = grid.Rows[index - 1];
            grid.Rows.Remove(partnerRow);
            grid.Rows.Insert(index, partnerRow);

            TriggerCalculation();
        }

        private void OnButtonDownClick(object sender, EventArgs e)
        {
            if (grid.RowCount == 0 || grid.SelectedRows.Count != 1)
            {
                return;
            }
            var row = grid.SelectedRows[0];
            var index = grid.Rows.IndexOf(row);
            if (index == grid.RowCount - 1)
            {
                return;
            }
            grid.Rows.Remove(row);
            grid.Rows.Insert(index + 1, row);
            grid.ClearSelection();
            row.Selected = true;

            TriggerCalculation();
        }

        private void OnHintClick(object sender, EventArgs e)
        {
            if (_hintForm == null)
            {
                _hintForm = new HintForm();
                _hintForm.Show();
                return;
            }
            _hintForm.Visible = !_hintForm.Visible;
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                var row = grid.Rows[i];
                row.Cells["Degrees"].Value = null;
            }
        }

        private void OnGitLinkClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Atropin/QuaternionCalculator");
        }

        private void OnGitLinkMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void OnGitLinkMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
