using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_Left_Right : MonoBehaviour
{

    public float speed = 40.0f;
    public bool TurnAroundFlag = false;
    public int TurnAroundCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TurnAroundFlag == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            TurnAroundCounter++;
        }
        else if (TurnAroundFlag == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            TurnAroundCounter--;
        }

        if (TurnAroundCounter == 40)
        {
            TurnAroundFlag = true;
        }
        else if (TurnAroundCounter == 0)
        {
            TurnAroundFlag = false;
        }

    }
}
