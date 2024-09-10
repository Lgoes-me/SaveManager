using UnityEngine;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global

public class PlayerModel: ISavable<PlayerController>, ILoadable<PlayerController>
{
    public string Id { get; set; }
    public float[] Position { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }

    public PlayerModel()
    {
        Id = "Player.json";
    }
    
    public PlayerController LoadData(PlayerController data)
    {
        data.transform.position = new Vector3(Position[0], Position[1], Position[2]);
        data.Name = Name;
        data.Score = Score;

        return data;
    }

    public void SaveData(PlayerController data)
    {
        var position = data.transform.position;
        Position = new[] {position.x,position.y, position.z};
        Name = data.Name;
        Score = data.Score;
    }
}