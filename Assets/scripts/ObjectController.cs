using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectController : MonoBehaviour
{
    public Transform objectToTrack;
    public string gameOverScene;
    public float margin = 0.1f;

    private void Update()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(objectToTrack.position);

        if (viewportPos.x < -margin || viewportPos.x > 1 + margin || viewportPos.y < -margin || viewportPos.y > 1 + margin)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
}
