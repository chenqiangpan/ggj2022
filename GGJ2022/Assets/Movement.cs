using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    Rect allowedArea = new Rect(-5, -5, 10, 10);

    [SerializeField]
    private bool isReverse = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isReverse)
        {
            NormalControl();
        }
        else
        {
            ReverseControl();
        }

    }

    void NormalControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

    }

    void ReverseControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    // when collide with boundary, die

    // when die, respawn

    // when go into the oppsite color zone, reverse the direction

    // when collide with the other player, win 

    // win event : UI update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.name == "Player")
        {
            Win();
        }
        if (other.gameObject.tag == gameObject.tag)
        {
            Debug.Log("into the same color zone");
           isReverse = true;
        }

    }



    void Win()
    {
        Debug.Log("You Win!");
    }


}
