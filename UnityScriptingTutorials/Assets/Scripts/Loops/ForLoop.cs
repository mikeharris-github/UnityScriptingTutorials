using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;

    //3 steps: 1) declare a variable (optional 2) conditional (manditory), 3) allows to increasse/decrease (optional)
    //is is useful when counting is known while the number of iterations is known.
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}
