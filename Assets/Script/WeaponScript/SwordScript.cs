using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    public float stabSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stab()
    {
        transform.Translate(Vector3.forward * stabSpeed * Time.deltaTime, Space.Self);
    }
}
