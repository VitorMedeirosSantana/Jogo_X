using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 thirdPerson = new Vector3(0,7,-15);
    private Vector3 firstPerson = new Vector3(0, 2, 3.3f);
    public bool FirstPerson;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("c"))
            FirstPerson = !FirstPerson;
        if(FirstPerson)
            transform.position = player.transform.position  ;//firstPerson

        if (!FirstPerson)
            transform.position = player.transform.position + thirdPerson ;//
    }
}
