using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using Valve.VR.InteractionSystem;


//������ �������� �� �������-����� ������������. � Item ��� ����������� ���� ��� �������. Grab_Zone - ����, � ������� ������� ��������� ������
public class ObjToHand : MonoBehaviour
{
    public GameObject Item, Grab_Zone;

    void Start()
    {

    }


    private void OnTriggerStay(Collider item)
    {
        if (item.gameObject == Item)
        {

            Item.transform.position = Grab_Zone.transform.position;
            Item.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            Item.GetComponent<Rigidbody>().freezeRotation = true;

        }

    }

    private void OnTriggerExit(Collider item)
    {
        if (item.gameObject == Item)
        {
            Item.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Item.GetComponent<Rigidbody>().freezeRotation = false;
        }

    }
}

