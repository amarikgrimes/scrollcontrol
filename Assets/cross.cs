using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class cross : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float maxY;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minY;
    [SerializeField] GameObject fireballPrefab;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * Speed * y * Vector3.up);
        transform.Translate(Time.deltaTime * Speed * x * Vector3.right);
       
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0f);

        }
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0f);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0f);
        }
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, 0f);

        }

        if (Input.GetButtonDown("Fire1") == true)
            {
             Instantiate(fireballPrefab, transform.position, transform.rotation);
;            }
        }
}
