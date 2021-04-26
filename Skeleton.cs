using System;

namespace ProtoFramework
{
    public interface ITile
    {
        public Coordinates Location{get;}
    }
    public class Coordinates : IEquatable<Coordinates>
    {
        public int X{ get; protected set;}
        public int Y{ get;  protected set;}
        public bool Equals(Coordinates other) => other.X == X && other.Y == Y;
    }
}
