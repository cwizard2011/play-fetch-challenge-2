using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float allowNextPress = 0.8f;
    private float timeSinceLastDog;

    void Start()
    {
        timeSinceLastDog = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.timeSinceLevelLoad - timeSinceLastDog >= allowNextPress)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastDog = Time.timeSinceLevelLoad;
        }
    }
}
