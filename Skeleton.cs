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
        public IEnumerable<IFeature> Features{get;}
    }
    public interface IEntity : ILocatable
    {
        public IEnumerable<IFeature> Features{get;}
        public IEnumerable<IAction> Actions{get;}
    }
    public interface IFeature
    {
    }
    public interface IAction
    {
    }
    public interface IWorld
    {
        public int Width{get;}
        public int Height{get;}
        public int Depth{get;}
        public IEnumerable<ITile> Tiles{get;}
        public IEnumerable<IEntity> Entities{get;}
        public IEnumerable<ILocatable> Get<ILocatable>(Coordinates location);
    }
    public class Coordinates : IEquatable<Coordinates>
    {
        public int X;
        public int Y;
        public int Z;
        public bool Equals(Coordinates other) => other.X == X && other.Y == Y && other.Z == Z;
    }
}
