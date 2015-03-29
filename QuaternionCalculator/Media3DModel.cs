using System.Windows.Media.Media3D;

namespace QuaternionCalculator
{
    class Media3DModel
    {
        public enum Actions
        {
            Pitch = 1,
            Yaw = 2,
            Roll = 3,
        }

        private static Quaternion _quaternion;

        private static readonly Vector3D PitchVector = new Vector3D(1, 0, 0);
        private static readonly Vector3D YawVector = new Vector3D(0, 1, 0);
        private static readonly Vector3D RollVector = new Vector3D(0, 0, 1);

        public double X { get { return _quaternion.X; } }
        public double Y { get { return _quaternion.Y; } }
        public double Z { get { return _quaternion.Z; } }
        public double W { get { return _quaternion.W; } }

        public void Calculate(Actions[] actions, int x = 0, int y = 0, int z = 0)
        {
            ResetQuaternion();

            for (int i = 0; i < 3; i++)
            {
                switch (actions[i])
                {
                    case Actions.Pitch:
                        Pitch(x);
                        continue;
                    case Actions.Yaw:
                        Yaw(y);
                        continue;
                    case Actions.Roll:
                        Roll(z);
                        continue;
                }
            }
        }

        /// <summary>
        /// Rotate around given axes by given degrees
        /// </summary>
        private static void TransformQuaternion(Vector3D vector, double degrees)
        {
            var q = new Quaternion(vector, degrees);
            _quaternion = _quaternion * q;
        }

        /// <summary>
        /// Rotate around X axis
        /// </summary>
        private static void Pitch(double degrees)
        {
            if (degrees == 0) return;
            TransformQuaternion(PitchVector, degrees);
            Normalize();
        }

        /// <summary>
        /// Rotate around Y axis
        /// </summary>
        private static void Yaw(double degrees)
        {
            if (degrees == 0) return;
            TransformQuaternion(YawVector, degrees);
            Normalize();
        }

        /// <summary>
        /// Rotate around Z axis
        /// </summary>
        private static void Roll(double degrees)
        {
            if (degrees == 0) return;
            TransformQuaternion(RollVector, degrees);
            Normalize();
        }
        
        /// <summary>
        /// Reset to empty quaternion
        /// </summary>
        private static void ResetQuaternion()
        {
            _quaternion = new Quaternion();
        }

        /// <summary>
        /// Normalize
        /// </summary>
        private static void Normalize()
        {
            if (_quaternion.IsNormalized) return;
            _quaternion.Normalize();
        }
    }
}
