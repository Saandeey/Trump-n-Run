using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tacoeinsammeln : MonoBehaviour {

    public int tacoCounter; 


    // Use this for initialization
    void Start() {
        tacoCounter = 0;
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            tacoCounter++;
            if (other.tag == "Taco")
            {
                Destroy(other.gameObject);
                Debug.Log("Score: " +tacoCounter);
            }


        }
    }
}