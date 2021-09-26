using System;

namespace CodeLessons
{
    public class FrogJmp
    {
        public int Solution(int X, int Y, int D) {
                return (int)Math.Ceiling(((double)Y - X) / D);
	}
    }
}
