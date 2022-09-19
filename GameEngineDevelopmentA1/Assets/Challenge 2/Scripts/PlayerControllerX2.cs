using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float SpawnDelay = 1.0f;
    private float counter = 0;

    // Update is called once per frame
    void Update()
    {
        counter += 0.01f;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (counter > 0.5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                counter = 0;
            }
            else
                Debug.Log("too early!");
        }
    }
}
