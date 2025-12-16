using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);
    }

    void SpawnPipe()
    {
        float y = Random.Range(-heightOffset, heightOffset);
        Instantiate(pipePrefab, new Vector3(transform.position.x, y, 0), Quaternion.identity);
    }
}
