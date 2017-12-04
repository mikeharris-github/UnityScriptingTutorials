using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //access modifier = setting a the access of a variable, class, script, etc
    
    //public variables can be accessed by other scripts and the editor
    //public classes could also be accessed from other classes and scripts.
    //private is the default access modifier for any variable that isn't specified

    public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;

    //the other script can be declared as a variable since it's public.
    private AnotherClass myOtherClass;


    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }


    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }


    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}