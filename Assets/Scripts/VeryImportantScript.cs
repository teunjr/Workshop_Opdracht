using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeryImportantScript : MonoBehaviour
{

    int carsThatNeedToCrash = 10;

    void Start()
    {
        TeslaNavigationSystem();
    }

    private void TeslaNavigationSystem()
    {
        for (int i = 0; i < carsThatNeedToCrash; i++)
        {
            Debug.Log("Very Important stuff happening");
            i++;
        }
        Debug.Log("Boom boom");
    }
}
