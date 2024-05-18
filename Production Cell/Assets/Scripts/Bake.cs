using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bake : MonoBehaviour
{
    public bool MakeTube = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (MakeTube) 
        {
            
            StartCoroutine(Wait());
            
            MakeTube = false;
        }
    }
    IEnumerator Wait() 
    {
        yield return new WaitForSecondsRealtime(4);
        GameObject Ingot = gameObject.transform.GetChild(1).gameObject;
        GameObject Tube = gameObject.transform.GetChild(0).gameObject;
        Ingot.SetActive(false);
        Tube.SetActive(true);
    }
}
