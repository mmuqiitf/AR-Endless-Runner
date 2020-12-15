using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    public float speed = 50f;
    public float respawnTime = 1.0f;
    public Transform ground;
    private Vector3 screenBounds;
    private Rigidbody rb;
    private bool _start;

    // Start is called before the first frame update
    void Start()
    {
        rb = obstaclePrefabs.GetComponent<Rigidbody>();
        StartCoroutine(obstacleWave());
       
    }

    private void Update()
    {
       
    }

    private void spawnEnemy()
    {
        if (PlayerManager.isGameStarted)
        {
            Debug.Log("Is Game Started : " + PlayerManager.isGameStarted);
            GameObject clone = Instantiate(obstaclePrefabs) as GameObject;
            clone.transform.position = new Vector3(Random.Range(-1.75f, 2.329f), 1.167f, 7.37f);
            rb.velocity = new Vector3(0, 0, -speed);
        }
        
    }
    
    private IEnumerator obstacleWave()
    {   
       
        while (true)
        {   
            _start = true;
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();

        }
        
    }

}
