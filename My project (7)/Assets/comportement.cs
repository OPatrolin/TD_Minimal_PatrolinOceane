using System.Collections.Generic;
using UnityEngine;


public class herooo : MonoBehaviour
{
    public Transform posTarget_Right;
    public Transform posTarget_Left;

    // Quel sens va mon personnage
    public bool bDirection = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bDirection) transform.Translate(Vector3.right * Time.deltaTime);
        else transform.Translate(-Vector3.right * Time.deltaTime);

        if (bDirection && transform.position.x > posTarget_Right.position.x) bDirection = false;
        else if (!bDirection && transform.position.x < posTarget_Left.position.x) bDirection = true;
    }


  
}


