using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float inputX;
    private float inputZ;
    private float speed = 25.0f;

    //abilities
    public GameObject swordObject;
    private SwordScript swordScript;

    //ability tracking
    private bool hasSword = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        //move in relation to screen
        transform.Translate(Vector3.right * inputX * speed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.forward * inputZ * speed * Time.deltaTime, Space.World);

        //attack
        //space
        if(Input.GetKeyDown("space") && hasSword)
        {
            Debug.Log("stab");
            swordObject.SetActive(true);
            //swordScript.Stab();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")){
            Destroy(other.gameObject);

            swordScript = swordObject.GetComponent<SwordScript>();
            hasSword = true;
        }
    }
}
