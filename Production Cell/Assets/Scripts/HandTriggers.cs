using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class HandTriggers : MonoBehaviour
{
    private bool TableIsEmpty = true;
    public GameObject HandIngot;
    public GameObject MachineIngot;
    public GameObject HandTube;
    public GameObject MachineTube;
    public List<GameObject> TableIngots = new List<GameObject>();
    public List<GameObject> TrolleyIngots = new List<GameObject>();
    public List<GameObject> TableTubes = new List<GameObject>();
    public List<GameObject> TrolleyTubes = new List<GameObject>();

    void Start()
    {

    }


    private void OnTriggerEnter(Collider trigger)
    {

        if (trigger.gameObject.name == "TableTriggerPlace")
        {
            if (HandTube.activeSelf)
            {
                foreach (GameObject Tube in TableTubes)
                {
                    if (!Tube.activeSelf)
                    {
                        HandTube.SetActive(false);
                        Tube.SetActive(true);
                        break;
                    }
                }
            }
            else 
            {
                foreach (GameObject Tube in TableTubes)
                {
                    if (Tube.activeSelf)
                    {
                        Tube.SetActive(false);
                        HandTube.SetActive(true);
                        break;
                    }
                }
            }

        }

        if (trigger.gameObject.name == "MachineTrigger")
        {
            if (MachineTube.activeSelf)
            {
                MachineTube.SetActive(false);
                HandTube.SetActive(true);
            }
            else
            {
                var script = GameObject.Find("/Machine").GetComponent<Bake>();
                script.MakeTube = true;
                MachineIngot.SetActive(true);
                HandIngot.SetActive(false);
            }
        }

        if (trigger.gameObject.name == "TableTriggerGrab")
        {
            if (TableIsEmpty)
            {
                foreach (GameObject Ingot in TableIngots)
                {
                    if (!Ingot.activeSelf)
                    {
                        Ingot.SetActive(true);
                        HandIngot.SetActive(false);
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
                    if (Ingot.activeSelf)
                    {
                        Ingot.SetActive(false);
                        HandIngot.SetActive(true);
                        break;
                    }
                }
            }

        }

        if (trigger.gameObject.name == "TrolleyTriggerGrab")
        {
            if (!HandIngot.activeSelf)
            {
                if (!HandTube.activeSelf)
                {
                    foreach (GameObject Ingot in TrolleyIngots)
                    {
                        if (Ingot.activeSelf)
                        {
                            Ingot.SetActive(false);
                            HandIngot.SetActive(true);
                            break;
                        }
                    }
                }
                else 
                {
                    foreach (GameObject Tube in TrolleyTubes)
                    {
                        if (!Tube.activeSelf)
                        {
                            HandTube.SetActive(false);
                            Tube.SetActive(true);
                            if (TrolleyTubes[TrolleyTubes.Count - 1].activeSelf == true)
                            {
                                GameObject Trolley = GameObject.Find("Trolley");
                                var script = Trolley.GetComponent<StartAnimation>();
                                script.ReadyToGo = true;
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
