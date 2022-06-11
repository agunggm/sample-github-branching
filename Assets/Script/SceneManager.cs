using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public int a;
    public int b;
    // Start is called before the first frame update
    void Start()
    {
        a = 1;
        b = 3;
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
