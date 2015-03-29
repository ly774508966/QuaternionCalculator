using System.Globalization;
using System.Text;
using System.Windows;

namespace QuaternionCalculator
{
    class ViewModel
    {
        private readonly Media3DModel _model = new Media3DModel();
        private readonly Media3DModel.Actions[] _actions = new Media3DModel.Actions[3];
        private readonly StringBuilder _sb = new StringBuilder();

        private const string XmlTemplate = "<quaternion qx=\"{0}\" qy=\"{1}\" qz=\"{2}\" qw=\"{3}\"/><!-- rotation {4}-->";
        private const string TextTemplate = "qx={0}, qy={1}, qz={2}, qw={3} (rotation {4})";

        public Media3DModel.Actions[] Actions { get { return _actions; } } 
        public int Pitch { get; set; }
        public int Yaw { get; set; }
        public int Roll { get; set; }

        public double X { get { return _model.X; } }
        public double Y { get { return _model.Y; } }
        public double Z { get { return _model.Z; } }
        public double W { get { return _model.W; } }

        public void Calculate()
        {
            _model.Calculate(Actions, Pitch, Yaw, Roll);
        }

        public void CopyXmlToClipboard()
        {
            Clipboard.SetText(string.Format(
                XmlTemplate,
                X.ToString(CultureInfo.InvariantCulture),
                Y.ToString(CultureInfo.InvariantCulture),
                Z.ToString(CultureInfo.InvariantCulture),
                W.ToString(CultureInfo.InvariantCulture),
                GetCommentString()));
        }

        public void CopyToClipboard()
        {
            Clipboard.SetText(string.Format(
                TextTemplate,
                X.ToString(CultureInfo.InvariantCulture),
                Y.ToString(CultureInfo.InvariantCulture),
                Z.ToString(CultureInfo.InvariantCulture),
                W.ToString(CultureInfo.InvariantCulture),
                GetCommentString()));
        }

        private string GetCommentString()
        {
            _sb.Clear();
            foreach (Media3DModel.Actions action in _actions)
            {
                switch (action)
                {
                    case Media3DModel.Actions.Pitch:
                        _sb.Append(string.Format("-> x: {0} ", Pitch));
                        continue;
                    case Media3DModel.Actions.Yaw:
                        _sb.Append(string.Format("-> y: {0} ", Yaw));
                        continue;
                    case Media3DModel.Actions.Roll:
                        _sb.Append(string.Format("-> z: {0} ", Roll));
                        continue;
                }
            }
            return _sb.ToString();
        }
    }
}
