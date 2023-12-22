using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
	public float timel;
	public float time2;
    private bool moveLeft;
    private bool moveRight;
    private bool isJumping; // new flag to indicate whether the object is in mid-air
    public float jumpForce = 10f;
    private float horizontalMove;
    public float speed = 5;
    public AudioClip jumpSound;
	public ParticleSystem KillEffect;
    // Start is called before the first frame update
   public float force = 10f;

    // private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        rb.AddForce(Vector2.left * force);
    }

    public void MoveRight()
    {
        rb.AddForce(Vector2.right * force);
    }


	void OnCollisionEnter2D(Collision2D collision)
	{

        AudioSource.PlayClipAtPoint(jumpSound, transform.position);
		if (collision.gameObject.tag == "Finish")
		{
			Destroy(gameObject , time2);
			KillEffect.Play();
			// SceneManager.LoadScene("GameOver");
			Invoke("LoadScene", timel);
			
		
			
		}
	}

	void LoadScene()
	{
		SceneManager.LoadScene("GameOver");
	}
}
