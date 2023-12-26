using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFall : MonoBehaviour
{
    private Rigidbody rb;


    private void Start() 
    {
       rb = GetComponent<Rigidbody>(); 
    }

    private void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.tag == "Ball")
        {
            StartCoroutine(values());

        }
        
    }

    public IEnumerator values()
    {
        yield return new WaitForSeconds(0.5f);
        rb.useGravity = true;
        rb.isKinematic = false;

    } 




}   
