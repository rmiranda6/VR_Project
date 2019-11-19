using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impossibleSpaceController : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject anteroom;
    public GameObject room0, room1, room2;


    // Start is called before the first frame update
    void Start()
    {
        //anteroom.SetActive(true);
        room0.SetActive(false);
        room1.SetActive(false);
        room2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "trigger")
        {

            if (anteroom.activeInHierarchy) {

                room0.SetActive(true);
                anteroom.SetActive(false);
                room1.SetActive(false);
                room2.SetActive(false);

            } else if (room0.activeInHierarchy) {


                room1.SetActive(true);
                anteroom.SetActive(false);
                room0.SetActive(false);
                room2.SetActive(false);

            }
            else if (room1.activeInHierarchy)
            {
                room2.SetActive(true);
                room1.SetActive(false);
                anteroom.SetActive(false);
                room0.SetActive(false);

            }
            else if (room2.activeInHierarchy)
            {
                room1.SetActive(true);
                room2.SetActive(false);


            }



            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }

}
