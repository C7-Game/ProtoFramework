using System;
using System.Collections.Generic;

namespace ProtoFramework
{
    public interface ILocatable
    {
        public Coordinates Location{get;}
    }
    public interface ITile : ILocatable
    {
    }
    public interface IEntity : ILocatable
    {
    }
    public interface IMap
    {
        public int Width{get;}
        public int Height{get;}
        public int Depth{get;}
        public IEnumerable<ITile> Tiles{get;}
        public ITile Tile(ILocatable location);
    }
    public interface IWorld
    {
        public IMap Map{get;}
    }
    public class Coordinates : IEquatable<Coordinates>
    {
        public int X;
        public int Y;
        public int Z;
        public bool Equals(Coordinates other) => other.X == X && other.Y == Y && other.Z == Z;
    }
}
