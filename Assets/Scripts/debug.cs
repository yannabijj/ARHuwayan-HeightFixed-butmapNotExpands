using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("log");
        Debug.LogWarning("Warning");
        Debug.LogError("Error");

    }
}
