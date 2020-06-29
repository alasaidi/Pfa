﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool interactable = false;

    public Material[] material;
    Renderer rend;

	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}

    public virtual void Interact()
    {
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(interactable && Input.GetKeyDown(KeyCode.P))
        {
            Interact();
        }
        if(interactable)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactable = false;
        }
    }
}
