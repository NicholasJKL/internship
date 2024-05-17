using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTriggers : MonoBehaviour
{
    private bool TableIsEmpty = true;
    public List<GameObject> TableIngots = new List<GameObject>();
    public List<GameObject> TrolleyIngots = new List<GameObject>();

    void Start()
    {

    }

    


    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.name == "TableTriggerGrab")
        {
            if (TableIsEmpty)
            {
                foreach (GameObject Ingot in TableIngots)
                {
                    if (Ingot.activeSelf == false)
                    {
                        Ingot.SetActive(true);
                        if (TableIngots[TableIngots.Count - 1].activeSelf == true)
                        {
                            TableIsEmpty = false;
                        }
                        break;
                    }
                }
            }
            else
            {
                foreach (GameObject Ingot in TableIngots)
                {
                    if (Ingot.activeSelf == true)
                    {
                        Ingot.SetActive(false);
                        break;
                    }
                }
            }

        }

        if (trigger.gameObject.name == "TrolleyTriggerGrab")
        {
            foreach (GameObject Ingot in TrolleyIngots)
            {
                if (Ingot.activeSelf == true)
                {
                    Ingot.SetActive(false);
                    break;
                }
            }
        }
    }
}
