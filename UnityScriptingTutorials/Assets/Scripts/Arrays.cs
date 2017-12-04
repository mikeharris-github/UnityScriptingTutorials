using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;

    int[] myIntArray = new int[3];
    int[] myOtherIntArray = { 12, 76, 8, 937, 903 };


    void Start()
    {
        //find all game objects in scene with tag "Player" and add to array
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + players[i].name);
        }
    }

    void ExampleArray()
    {
        myIntArray[0] = 12;
        myIntArray[1] = 23;
        myIntArray[2] = 99;
    }
}