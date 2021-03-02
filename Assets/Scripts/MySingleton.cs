using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton : Singleton<MySingleton>
{
    public void PrintWarningLog(string log)
    {
        Debug.LogWarning(name + " " + log);
    }
}
