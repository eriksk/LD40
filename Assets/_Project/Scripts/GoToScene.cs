
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public string SceneName;

    public void ActivateScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}