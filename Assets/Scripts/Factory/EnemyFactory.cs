using UnityEngine;

public enum EnemyType
{
    Zombie,
    Runner,
    Boss
}

public class EnemyFactory : MonoBehaviour
{
    public GameObject zombiePrefab;
    public GameObject runnerPrefab;
    public GameObject bossPrefab;

    public GameObject CreateEnemy(
    EnemyType type,
    Vector3 position)
    {
        switch (type)
        {
            case EnemyType.Zombie:
                return Instantiate(
                zombiePrefab,
                position,
                Quaternion.identity);

            case EnemyType.Runner:
                return Instantiate(
                runnerPrefab,
                position,
                Quaternion.identity);

            case EnemyType.Boss:
                return Instantiate(
                bossPrefab,
                position,
                Quaternion.identity);
        }

        return null;
    }
}