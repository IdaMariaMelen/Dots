using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizar, yo"); //print(); er like bra
        Debug.Log("Hughest Number you can pick is 100");
        Debug.Log("Lowest Number is 1");
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Update Arrow key was pressed.");
        }   
    }
}
