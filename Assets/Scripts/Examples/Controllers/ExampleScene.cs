using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleScene : MonoBehaviour
{
    [field: SerializeField] private SaveManager SaveManager { get; set; }
    [field: SerializeField] private PlayerController PlayerController { get; set; }

    public void SavePlayer()
    {
        SaveManager.SaveData<PlayerController, PlayerModel>(PlayerController);
    }

    public void LoadPlayer()
    {
        SaveManager.LoadData<PlayerController, PlayerModel>(PlayerController);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}