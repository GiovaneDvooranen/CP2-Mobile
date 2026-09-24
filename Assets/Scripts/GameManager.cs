using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float survivalTime;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        survivalTime += Time.deltaTime;
    }

    public float GetSurvivalTime()
    {
        return survivalTime;
    }
}
