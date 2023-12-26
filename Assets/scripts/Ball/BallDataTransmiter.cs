using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private Ballinputcontroller ballinputcontroller;

    public Vector3 GetBallDirection()
    {
        return ballinputcontroller.ballDirection;
    }
}
