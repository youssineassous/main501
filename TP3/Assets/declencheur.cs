using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declencheur : MonoBehaviour
{
    private int nbCube=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            nbCube++;
            Debug.Log("Cube entré. Nombre de cubes: " + nbCube);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            nbCube--;
            Debug.Log("Cube sorti. Nombre de cubes: " + nbCube);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
