using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1) * Time.deltaTime * 4f);

        if (transform.position.y < -7f)
        {
            Destroy(this.gameObject);
        }
    }
}
