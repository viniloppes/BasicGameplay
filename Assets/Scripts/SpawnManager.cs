using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalsPrefab;
    [SerializeField] private float spawnPosZ = 20;
    [SerializeField] private float spawnRangeX = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {

            int animalIndex = Random.Range(0, animalsPrefab.Length);
            Vector3 spawnCoordinates = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalsPrefab[animalIndex], spawnCoordinates, animalsPrefab[animalIndex].transform.rotation);
        
        }
    }
}
