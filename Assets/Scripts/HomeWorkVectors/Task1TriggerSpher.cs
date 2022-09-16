using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class Task1TriggerSpher : MonoBehaviour
{
    [SerializeField] private GameObject sphere2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, sphere2.transform.position);
        var sphereRenderer = sphere2.GetComponent<Renderer>();
        if (distance <= 1)                  
            sphereRenderer.material.SetColor("_Color", Color.red);
        else
            sphereRenderer.material.SetColor("_Color", Color.white);

    }

    

}
