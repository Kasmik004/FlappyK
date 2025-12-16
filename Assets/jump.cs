using UnityEngine;
using UnityEngine.InputSystem;


public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 5f;
    public logic logic;
    public bool isAlive = true;
    public AudioSource jumpSound;
    public AudioClip jumpClip;
    public AudioSource tryAgainSound;
    public AudioClip tryAgainClip;
    void Start()
    {
        gameObject.name = "Bird";
    }

    void Update()
    {
        float dir1 = 0.5f;
        float dir2 = 0.5f;
        if (Keyboard.current.wKey.wasPressedThisFrame && isAlive)
        {
            jumpSound.PlayOneShot(jumpClip);
            rb.linearVelocity = Vector2.up * jumpForce;
        }
        if (transform.position.y < -16f)
        {
            Destroy(gameObject);
            logic.GameOver();
            tryAgainSound.PlayOneShot(tryAgainClip);
            isAlive = false;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Game Over");
        logic.GameOver();
        isAlive = false;
        tryAgainSound.PlayOneShot(tryAgainClip);
    }
}
