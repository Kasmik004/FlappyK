using UnityEngine;

public class piperefab : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2f;
    private float timer = 0f;
    public float heightOffset = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0f;
        }

    }

    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float randomY = Random.Range(lowestPoint, highestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, randomY, transform.position.z), transform.rotation);
    }
}
