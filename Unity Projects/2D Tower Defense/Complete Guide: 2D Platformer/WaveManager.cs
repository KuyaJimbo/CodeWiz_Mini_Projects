using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    [System.Serializable]
    public class Wave
    {
        public GameObject enemyPrefab;
        public int enemyCount;
        public float spawnRate;
    }
    
    [SerializeField] private Wave[] waves;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float timeBetweenWaves = 5f;
    
    private int currentWaveIndex = 0;
    private bool isSpawning = false;
    
    void Start()
    {
        StartCoroutine(StartNextWave());
    }
    
    IEnumerator StartNextWave()
    {
        if (currentWaveIndex < waves.Length)
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            StartCoroutine(SpawnWave(waves[currentWaveIndex]));
            currentWaveIndex++;
        }
    }
    
    IEnumerator SpawnWave(Wave wave)
    {
        isSpawning = true;
        
        for (int i = 0; i < wave.enemyCount; i++)
        {
            SpawnEnemy(wave.enemyPrefab);
            yield return new WaitForSeconds(1f / wave.spawnRate);
        }
        
        isSpawning = false;
        
        // Wait for all enemies to be defeated
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        // Start next wave
        StartCoroutine(StartNextWave());
    }
    
    void SpawnEnemy(GameObject enemyPrefab)
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}