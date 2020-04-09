using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circles : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float screenHightInUnits = 12f;

    [SerializeField] float minX = 0.35f;
    [SerializeField] float maxX = 2.65f;

    [SerializeField] float minY = 1.35f;
    [SerializeField] float maxY = 7.65f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnits);


        float mouseXPosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        float mouseYPosInUnits = Input.mousePosition.y / Screen.height * screenHightInUnits;

  
        Vector2 circlesPos = new Vector2(mouseXPosInUnits, mouseYPosInUnits);
        //(transform.position.x, transform.position.y) //keep still
        circlesPos.x = Mathf.Clamp(mouseXPosInUnits, minX, maxX);
        circlesPos.y = Mathf.Clamp(mouseYPosInUnits, minY, maxY);
        transform.position = circlesPos;
    }
}
