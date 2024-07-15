using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField] float topBound = 30f;
    [SerializeField] float lowerBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if game object goes out of bound / past the player view, destroy that object
        if(transform.position.z > topBound  )
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);

        }
    }
}
