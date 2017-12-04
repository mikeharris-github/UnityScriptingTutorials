﻿using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;

    //switches are used in certain cases. If intelligence = 5, read case 5. intelligence = 4, case 4. break ends the case.

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 4:
                print("Hello and good day!");
                break;
            case 3:
                print("Whadya want?");
                break;
            case 2:
                print("Grog SMASH!");
                break;
            case 1:
                print("Ulg, glib, Pblblblblb");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
}