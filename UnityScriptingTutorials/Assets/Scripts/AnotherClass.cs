using UnityEngine;
using System.Collections;

//This script can't be accessed because the class doesn't derive from MonoBehavior

public class AnotherClass
{
    public int apples;
    public int bananas;


    private int stapler;
    private int sellotape;


    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }


    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}