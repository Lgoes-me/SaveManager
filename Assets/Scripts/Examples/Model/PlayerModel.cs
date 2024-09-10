using UnityEngine;

public class PlayerModel
{
    public Vector3Model Position { get; private set; }
    public string Name { get; private set; }
    public int Score { get; private set; }

    public PlayerModel(Vector3 position, string name, int score)
    {
        Position = new Vector3Model(position);
        Name = name;
        Score = score;
    }
}

public class Vector3Model
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Vector3Model(Vector3 vector3)
    {
        X = vector3.x;
        Y = vector3.y;
        Z = vector3.z;
    }

    public Vector3 ToVector3()
    {
        return new Vector3(X, Y, Z);
    }
}