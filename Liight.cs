using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liight : MonoBehaviour
{
   public  GameObject light;
    public bool activate=false;
    private void Start()
    {
        light.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            light.SetActive(true);
        }
    }
}
