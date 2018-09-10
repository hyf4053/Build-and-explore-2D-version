using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GenerateRandom  {

    public static bool floatRandom(float p,float q)
    {
        if (q<Random.Range(0f,p))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
	
}
