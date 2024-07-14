using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    private GameObject spawnedProjectile;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float xRange = 10f;
    float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        LaunchProjectile();
    }


    void PlayerMovement()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
    void LaunchProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnedProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
