using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 1, 0) * velocidad * Time.deltaTime);

        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1, 0) * velocidad * Time.deltaTime);
        }
    }
}
