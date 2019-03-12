using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletSpwan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }




    }

    void Fire()
    {
        // Create the bullet from prefab
        var newBullet = (GameObject)Instantiate(
            bullet,
            bulletSpwan.position,
            bulletSpwan.rotation);

        // add velocity to the bullet
        newBullet.GetComponent<Rigidbody>().velocity = newBullet.transform.forward * 10;
        Destroy(newBullet, 2.0f);
    
    }

}
