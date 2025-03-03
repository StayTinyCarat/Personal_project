using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "Scriptable Objects/WaveData")]
public class WaveData : ScriptableObject
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public float enemySpacing;
    public float enemyRespawnTime;
    public float enemyHealth;
    public int currencySpeed;
    public float enemySpeed;
}
