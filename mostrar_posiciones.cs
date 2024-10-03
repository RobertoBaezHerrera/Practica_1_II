using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrar_posiciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.tag + " Position: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
