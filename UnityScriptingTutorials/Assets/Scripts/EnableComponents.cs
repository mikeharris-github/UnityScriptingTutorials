using UnityEngine;
using System.Collections;

public class EnableComponents : MonoBehaviour
{
    private Light myLight;


    void Start()
    {
        myLight = GetComponent<Light>(); //references the light component in game object
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
            //this is done when you're looking to turn it into a toggle. otherwise, it can be 
            //myLight.enabled = false;
        }
    }
}