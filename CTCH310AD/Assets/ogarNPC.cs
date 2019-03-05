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
                if (hitOnHead)
                {
                    print("Head Shot");
                    intel = intel--;
                    Greet();
                }else if(readBook && intel != 5){
                    print("Hurray!! Your IQ went up");
                    intel = intel++;
                    Greet();
                }

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
        
    }
}
