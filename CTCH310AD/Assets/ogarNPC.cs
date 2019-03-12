using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogarNPC : MonoBehaviour
{
    public int intel = 5;
    public bool hitOnHead = true;
    public bool readBook = true;
    float test()
    {
        return 5.0f;
    }

    void Greet()
    {
        switch (intel)
        {
            case 5:
                print("Hello, Good Sir! Do you like physics");


                break;

            case 4:
                print("Ello, guv!");
                break;
            case 3:
                print("What you want");
                break;
            case 2:
                print("Ug, ug... me hunge!");
                break;
            case 1:
                print("Grrrrrrrrr. *farts*");
                break;
            default:
                print("Drools");
                break;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Greet();
        float testnum = test();
        print(testnum);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hitOnHead = true;
            print("Head Shot");
            intel = intel--;
            Greet();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            readBook = true;
            print("Read a book");
            if (intel < 5)
            {
                intel = intel++;
            }
            else
            {
                print("Your are already intelligent");
            }

            Greet();
        }
    }
}
