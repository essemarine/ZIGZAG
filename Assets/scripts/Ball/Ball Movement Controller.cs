using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter ballDataTransmiter;

    [SerializeField] private float ballMoveSpeed;

    public float ballSpeed;


    private void Update()
    {
        setBallMovement();
    }


    private void setBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0)) 
        {
            ballMoveSpeed += ballSpeed* Time.deltaTime;
        }

    }
    




}
