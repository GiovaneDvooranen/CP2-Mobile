using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public EnemyFactory factory;

    public Transform[] spawnPoints;

    private int wave = 1;

    void Start()
    {
        InvokeRepeating(nameof(SpawnWave), 2f, 10f);
    }

    void SpawnWave()
    {
        Debug.Log("Wave " + wave);

        for (int i = 0; i < wave + 2; i++)
        {
            factory.CreateEnemy(EnemyType.Zombie, GetRandomSpawnPoint().position);
        }

        if (wave >= 2)
        {
            factory.CreateEnemy(EnemyType.Runner, GetRandomSpawnPoint().position);
        }

        if (wave % 5 == 0)
        {
            factory.CreateEnemy(EnemyType.Boss, GetRandomSpawnPoint().position);
        }

        wave++;
    }

    Transform GetRandomSpawnPoint()
    {
        int index = Random.Range(0, spawnPoints.Length);
        return spawnPoints[index];
    }
}