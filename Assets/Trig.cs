using UnityEngine;

public class Trig : MonoBehaviour
{
    public logic logicScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicScript.IncrementScore(1);
        }
    }
}
