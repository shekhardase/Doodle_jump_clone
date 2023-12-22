using UnityEngine;
using UnityEngine.SceneManagement;

public class levelswitch : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        // Load the next scene
        SceneManager.LoadScene("LevelEnd");
    }
}