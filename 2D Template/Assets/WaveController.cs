using UnityEngine;

public class WaveController : MonoBehaviour
{
    public WaveData waveData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(waveData.enemyCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
