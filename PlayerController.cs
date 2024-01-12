using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour;
private Rigidbody playerRb;
public float jumpForce;
public float gravityModifer;
public GameObject obstaclePrefab;
private Vector3 spawnPos = new Vector3(25, 0, 0);
private float startDelay = 2;
private float repeatRate = 2;

{
// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
