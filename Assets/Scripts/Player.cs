using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //its access: public or private
    //its tyle: int (5,8,36,etc.), float (2.5f, 3.7f, etc)
    //its name: speed, playerSpeed --- Speed, PlayerSpeed
    //optional: give it an initial value
    private float speed;
    private int lives = 3;
    private int score = 0;
    private float verticalInput;
    private float horizontalInput;
  

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        //if (condition) { //do this }
        //else if (other condition {//do that }
        //else {//do this final }
        if (transform.position.x > 10f || transform.position.x <= -10f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
        // Restrict movement within y bounds
         if (transform.position.y > 0f) 
        { 
            transform.position = new Vector3(transform.position.x, 0f, 0); 
        } 
        else if (transform.position.y < -4.7f)
        { 
            transform.position = new Vector3(transform.position.x, -4.7f, 0); 
        }
    }
    void Shooting()
    {
        //if I press SPACE
        //create a bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
