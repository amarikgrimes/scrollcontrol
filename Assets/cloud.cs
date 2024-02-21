using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cloud : MonoBehaviour
{
    [SerializeField] float Speed = 4f;
    [SerializeField] float maxX;
    [SerializeField] float minX;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.left);
        if (transform.position.x<maxX)
        {
            transform.position = new Vector3(minX, 0f, 0f);
        }
      
    }
}

