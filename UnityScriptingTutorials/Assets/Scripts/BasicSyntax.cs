using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.position.x);
        /*
        For the dot operator
        debug = country
        log = the city

        transform = country
        log = city
        x = street

        transform is a class (included in the UnityEngine namespace) that contains position, rotation, and scale.
        position also contains x, y, and z
        */
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}