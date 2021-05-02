using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    //prefab do peixe
    public GameObject fishPrefab;
    //quantos peixes vão ser instanciados
    public int numFish= 20;
    //array para guardas os peixes que vão ser instanciados
    public GameObject[] allFish; 
   //min e max de onde eles vão ser instanciados
    public Vector3 swinLimits = new Vector3(5, 5, 5);

    //menu com sliders para setar a velocidade min e max que os peixes vão nadar
    [Header("Configurações do Cardume")] 
    [Range(0.0f, 5.0f)]
    public float minSpeed;
    [Range(0.0f, 5.0f)]
    public float maxSpeed;


    void Start()
    {
        //setando o array com os peixes instanciados
        allFish = new GameObject[numFish];

        //fazendo esses comandos para cara peixe instanciado
        for (int i = 0; i < numFish; i++)
        {
            //sorteando uma posição dentre o min e o max para instanciar o peixe
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-swinLimits.x, swinLimits.x), 
                Random.Range(-swinLimits.y, swinLimits.y), 
                Random.Range(-swinLimits.z, swinLimits.z));

            //instanceia os peixes
            allFish[i] = (GameObject) Instantiate(fishPrefab, pos, Quaternion.identity);

            //colocando o manager no script do flock
            allFish[i].GetComponent<Flock>().myManager = this;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
