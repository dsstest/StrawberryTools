using System.Runtime.InteropServices;

namespace SilinoronParser.Util
{
    public struct Vector3
    {
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X;

        public float Y;

        public float Z;

        public static bool operator ==(Vector3 first, Vector3 other)
        {
            return first.Equals(other);
        }

        public static bool operator !=(Vector3 first, Vector3 other)
        {
            return !(first == other);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector3)
                return Equals((Vector3)obj);

            return false;
        }

        public override string ToString()
        {
            return "X: " + X + " Y: " + Y + " Z: " + Z;
        }

        public bool Equals(Vector3 other)
        {
            return other.X == X && other.Y == Y && other.Z == Z;
        }

        public override int GetHashCode()
        {
            var result = X.GetHashCode();
            result = (result * 397) ^ Y.GetHashCode();
            result = (result * 397) ^ Z.GetHashCode();
            return result;
        }
    }
}
