using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public GameObject mobPrefab;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;
    public int numberOfMobs = 10;
    public float spawnInterval = 5f;
    private float timer;
    public Transform player; // Referencia al jugador

    void Start()
    {
        for (int i = 0; i < numberOfMobs; i++)
        {
            SpawnMob();
        }

        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnMob();
            timer = spawnInterval;
        }
    }

    void SpawnMob()
    {
        float spawnX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float spawnY = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        Vector2 spawnPosition = new Vector2(spawnX, spawnY);

        GameObject mob = Instantiate(mobPrefab, spawnPosition, Quaternion.identity);
        mob.GetComponent<MobBehavior>().SetPlayer(player);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector2(spawnAreaMin.x, spawnAreaMin.y), new Vector2(spawnAreaMax.x, spawnAreaMin.y));
        Gizmos.DrawLine(new Vector2(spawnAreaMin.x, spawnAreaMin.y), new Vector2(spawnAreaMin.x, spawnAreaMax.y));
        Gizmos.DrawLine(new Vector2(spawnAreaMax.x, spawnAreaMax.y), new Vector2(spawnAreaMax.x, spawnAreaMin.y));
        Gizmos.DrawLine(new Vector2(spawnAreaMax.x, spawnAreaMax.y), new Vector2(spawnAreaMin.x, spawnAreaMax.y));
    }
}
