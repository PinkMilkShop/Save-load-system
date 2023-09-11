using System;

namespace CodeBase.Data
{
  [Serializable]
  public class PositionOnLevel
  {
    public string Level;
    public Vector3Data Vector3Data;

    public PositionOnLevel(string initialLevel)
    {
      Level = initialLevel;
    }

    public PositionOnLevel(string level, Vector3Data position)
    {
      Level = level;
      Vector3Data = position;
    }
  }
}