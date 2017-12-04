using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour
{
    //type int, nameOfVariable = myInt, value = 5

    int myInt = 5;

    //type "void" is used for a function when nothing needs to be returned
    void Start()
    {
        myInt = MultiplyByTwo(myInt); //FunctionName(data to send to parameter)
        //myInt = the result of the MultiplyByTwo function
        Debug.Log(myInt);
        //This function myInt is triggering the MultiplyByTwo function, and feeding it a parameter of myInt which is 5

    }

    //type FunctionName(type parameterName);
    //type is int, since we're looking to return a number.
    //inside the function, int is the type given to the parameter
    //in this case, number = myInt, since it was passed by the Start function. 
    //Other functions could also feed a parameter into number if called

    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}