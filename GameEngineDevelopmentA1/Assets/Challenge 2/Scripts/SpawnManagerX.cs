using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -30;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3, 6);
        StartCoroutine(SpawnRandomBall());
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall()
    {

        while (true)
        {         // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            spawnInterval = Random.Range(3, 6);
            yield return new WaitForSeconds(spawnInterval);


            int Rand = Random.Range(0, 3);
            Debug.Log(spawnInterval);
            // instantiate ball at random spawn location

            switch (Rand) // the only reason this is in a switch statement is because setting the array element never worked out for me
            {
                case 0:
                    Debug.Log("Blue");
                    Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
                    break;
                case 1:
                    Debug.Log("Green");
                    Instantiate(ballPrefabs[1], spawnPos, ballPrefabs[1].transform.rotation);
                    break;
                case 2:
                    Debug.Log("Red");
                    Instantiate(ballPrefabs[2], spawnPos, ballPrefabs[2].transform.rotation);
                    break;



            }
        }
    }


    private void FixedUpdate()
    {
        spawnInterval = Random.Range(3, 6);
       
    }
}
