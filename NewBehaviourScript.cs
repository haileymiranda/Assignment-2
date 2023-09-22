using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    string myBody;
    string myIntroduction;
    [SerializeField] float moveX;






    // Start is called before the first frame update
    void Start()
    {

        myIntroduction = "My name is Hailey";
        Debug.Log(myIntroduction);
        myBody = "Here we go into the air. The air is thick and foggy like we are in a different world. As I float into the sun I get hotter and hotter. Man, this doesn't feel like a game anymore";
        Debug.Log(myBody);

        moveX = 0.005f;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveX * Time.deltaTime, 0.003F, -0.003F);
        transform.Rotate(moveX, 0.03F, -0.02F);


    }
}
