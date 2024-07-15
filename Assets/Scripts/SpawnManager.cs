using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalsPrefab;
    [SerializeField] private float spawnPosZ = 20;
    [SerializeField] private float spawnRangeX = 20;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefab.Length);
        Vector3 spawnCoordinates = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalsPrefab[animalIndex], spawnCoordinates, animalsPrefab[animalIndex].transform.rotation);

    }
}
