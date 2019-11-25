using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impossibleSpaceController : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject anteroom;
    public GameObject room0, room1, room2, room3, room4, room5, end;


    // Start is called before the first frame update
    void Start()
    {
        anteroom.SetActive(true);
        room0.SetActive(false);
        room1.SetActive(false);
        room2.SetActive(false);
        room3.SetActive(false);
        room4.SetActive(false);
        room5.SetActive(false);
        end.SetActive(false);
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

                anteroom.SetActive(false);
                room0.SetActive(true);                
                room1.SetActive(false);
                room2.SetActive(false);
                room3.SetActive(false);
                room4.SetActive(false);
                room5.SetActive(false);
                end.SetActive(false);

            } else if (room0.activeInHierarchy) {

                anteroom.SetActive(false);
                room0.SetActive(false);
                room1.SetActive(true);
                room2.SetActive(false);
                room3.SetActive(false);
                room4.SetActive(false);
                room5.SetActive(false);
                end.SetActive(false);
            }
            else if (room1.activeInHierarchy)
            {
                anteroom.SetActive(false);
                room0.SetActive(false);
                room2.SetActive(true);
                room1.SetActive(false);
                room3.SetActive(false);
                room4.SetActive(false);
                room5.SetActive(false);
                end.SetActive(false);
            }
            else if (room2.activeInHierarchy)
            {
                anteroom.SetActive(false);
                room0.SetActive(false);
                room2.SetActive(false);
                room1.SetActive(false);
                room3.SetActive(true);
                room4.SetActive(false);
                room5.SetActive(false);
                end.SetActive(false);
            }
            else if (room3.activeInHierarchy)
            {
                anteroom.SetActive(false);
                room0.SetActive(false);
                room2.SetActive(false);
                room1.SetActive(false);
                room3.SetActive(false);
                room4.SetActive(true);
                room5.SetActive(false);
                end.SetActive(false);
            }
            else if (room4.activeInHierarchy)
            {
                anteroom.SetActive(false);
                room0.SetActive(false);
                room2.SetActive(false);
                room1.SetActive(false);
                room3.SetActive(false);
                room4.SetActive(false);
                room5.SetActive(true);
                end.SetActive(false);
            }
            else if (room5.activeInHierarchy)
            {
                anteroom.SetActive(false);
                room0.SetActive(false);
                room2.SetActive(false);
                room1.SetActive(false);
                room3.SetActive(false);
                room4.SetActive(false);
                room5.SetActive(false);
                end.SetActive(true);
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
