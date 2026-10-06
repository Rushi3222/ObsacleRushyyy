using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]float moveSpeed = 5f;
    [SerializeField] float sprintspeed = 70f;
    [SerializeField] float currentspeed;
    [SerializeField] float speedkmh;


    private Vector3 lastPosition;

    void Start()
    {

    }

    void Update()
    {

        PrintLogMsj();
    }

    void PrintLogMsj()
    {
        currentspeed = moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentspeed = sprintspeed;
        }





        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yvalue = 0.0f;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(xvalue, yvalue, zvalue);


        currentspeed = Vector3.Distance(transform.position, lastPosition)
                       / Time.deltaTime;

        speedkmh = currentspeed * 3.6f;

        lastPosition = transform.position;

 

        /* if (Input.GetKey(KeyCode.W))
         {
             transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.S))
         {
             transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
         }*/
    }
}