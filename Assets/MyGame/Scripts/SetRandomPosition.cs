using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomPosition : MonoBehaviour
{
    public GameObject[] ballPositions;
    public GameObject ball;

    public void SetNewPosition()
    {
        int randomValue = Random.Range(0,4);
        Vector3 position = ballPositions[randomValue].transform.position;

        ball.transform.position = position;
    }
    
}
