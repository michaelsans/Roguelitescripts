using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casas : MonoBehaviour
{

    public Transform[] positions;
    public GameObject[] rooms;
    public GameObject target;
    private float timeBtwRoom;
    public float startTimeBtwRoom = .10f;
    public LayerMask whatIsRoom;


    void Update()
    {
        if (timeBtwRoom <= 0)
        {
            transform.position = target.transform.position;
            Casa();
            timeBtwRoom = startTimeBtwRoom;
        }
        else
        {

            timeBtwRoom -= Time.deltaTime;
        }

    }


    private void Casa()
    {
        Collider2D roomDetection = Physics2D.OverlapCircle(transform.position, 1, whatIsRoom);
        if (roomDetection == null)
            {
            if (transform.position == positions[0].transform.position)
            {
                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[1].transform.position)
            {
                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
               
            }
            else if (transform.position == positions[2].transform.position)
            {
                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[3].transform.position)
            {
                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
               
            }
            else if (transform.position == positions[4].transform.position )
            {
                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[8].transform.position)
            {
                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[5].transform.position)
            {
                Instantiate(rooms[3], transform.position, Quaternion.identity);
              
            }
            else if (transform.position == positions[6].transform.position)
            {
                Instantiate(rooms[3], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[9].transform.position)
            {
                Instantiate(rooms[3], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[10].transform.position)
            {
                Instantiate(rooms[3], transform.position, Quaternion.identity);
                
            }

            else if (transform.position == positions[7].transform.position)
            {
                int rand = Random.Range(1, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[11].transform.position)
            {
                int rand = Random.Range(1, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[13].transform.position)
            {
                int rand = Random.Range(0, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
               
            }
            else if (transform.position == positions[14].transform.position)
            {
                int rand = Random.Range(0, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
                
            }
            else if (transform.position == positions[12].transform.position)
            {
                int rand = Random.Range(0, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
               
            }
            else if (transform.position == positions[15].transform.position)
            {
                int rand = Random.Range(0, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);
               ;
            }

        }
    }
}

    

