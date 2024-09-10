using UnityEngine;

public class PlayerController : MonoBehaviour, ISavable<PlayerModel>, ILoadable<PlayerModel>
{
    public string Id { get; set; }
    
    [field: SerializeField] private string Name { get; set; }
    [field: SerializeField] private int Score { get; set; }
    
    private void Awake()
    {
        Id = "Player.json";
    }

    public void LoadData(PlayerModel player)
    {
        transform.position = player.Position.ToVector3();
        Name = player.Name;
        Score = player.Score;
        
    }

    public PlayerModel SaveData()
    {
        return new PlayerModel(transform.position, Name, Score);
    }
}