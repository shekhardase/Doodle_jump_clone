using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] public AudioClip sound;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

   public void soound()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
