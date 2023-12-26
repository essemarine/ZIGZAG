using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ballinputcontroller : MonoBehaviour
{
    
    public ZeminSpawner zeminSpawner;
    
    public Vector3 ballDirection;




    void Start()
    {
        ballDirection = Vector3.left; 
    }


    void Update()
    {
        HandleBallInputs();


    }


    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ChangeBallDirection();
        }

    }


    private void ChangeBallDirection()
    {
        if(ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }


    private void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.tag == ("zemin"))
        {
            zeminSpawner.zemin_oluştur();
            StartCoroutine(GroundDelete(other.gameObject));
        }

    }

    IEnumerator GroundDelete(GameObject groundDestroy)
    {
        yield return new WaitForSeconds(2f);
        Destroy(groundDestroy);
    }


}
