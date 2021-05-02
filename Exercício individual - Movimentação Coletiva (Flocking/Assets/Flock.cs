using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    //criando a var para colocar o manager
    public FlockManager myManager;
    //setando speed
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        //setando a speed random com os valores no script mymanager
        speed = Random.Range(myManager.minSpeed, myManager.maxSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        //movimenta os peixes
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
