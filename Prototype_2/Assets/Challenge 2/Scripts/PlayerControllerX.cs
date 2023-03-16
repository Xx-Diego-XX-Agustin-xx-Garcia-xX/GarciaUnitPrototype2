using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown = 0f;
    private bool dogOn = true;

    // Update is called once per frame
    void Update()
    {
        coolDown += Time.deltaTime;
        if (coolDown > 1.5f)
        {
            dogOn = true;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogOn == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = 0;
            dogOn = false;
        }
    }
}