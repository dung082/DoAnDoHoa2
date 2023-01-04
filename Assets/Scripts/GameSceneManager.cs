using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void LoadSence(string sceneManager)
    {
        SceneManager.LoadScene(sceneManager);
    }
}
