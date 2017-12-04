using UnityEngine;
using System.Collections;

//these are useful when looping through arrays

public class ForeachLoop : MonoBehaviour
{
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        //looks through the collection in the item.
        //declare a variable (item), in collection (strings)

        foreach (string item in strings)
        {
            print(item);
        }
    }
}