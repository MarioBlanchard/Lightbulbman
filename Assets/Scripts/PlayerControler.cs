using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public float charge = 0;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (charge == 0)
            {

            }

            else
            {
                //Throw Food
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                charge -= 1;
            }
           
        }
    }

    //up charge when collecting batteries
    // how would door check charge?
    //remove charge when using attack

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "attack")
        {

        }
        else if (other.tag == "wall")
        {

        }


        else if (other.tag == "text")
        {

        }
        else if (other.tag == "Door")
        {

        }

        else
        {
            Destroy(other.gameObject);
            charge += 1;
        }
        

    }


}
