using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogLimit = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogLimit <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogLimit = 1;
        }
        if (dogLimit >= 0) {
        dogLimit -= Time.deltaTime;
        }
    }
}
