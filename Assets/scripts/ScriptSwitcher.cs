using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptSwitcher : MonoBehaviour
{
    public string sceneName;
    public MonoBehaviour scriptToDisable;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == sceneName)
        {
            scriptToDisable.enabled = false;
        }
        else
        {
            scriptToDisable.enabled = true;
        }
    }
}