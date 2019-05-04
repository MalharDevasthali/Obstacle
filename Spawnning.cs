using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject ObstaclePrefab;
  
    
    void Start()
    {
        StartCoroutine(spawning()); //Coroutines is like a function tht has ability to pause the execution
                                    // and return to the same state/frame where we have left it...
                                    //here we have started a coroutine with method spawning
    }
   

    IEnumerator spawning() //IEnumerator is an essential return type for coroutines along with yeild parameter
    {
        while (true)//to get infinite loop we used while(true)
        {
            Instantiate(ObstaclePrefab, new Vector3(Random.Range(-3.68f,3.68f), 7.54f, 0f), Quaternion.identity);
            //Instantiate used to spawn objects into the scene..it takes basically 3 parameters
                                                //1) prefab
                                                 //2)Position
                                                 //3)Rotation
            yield return new WaitForSeconds(1f); 
            
        }
    
    }
  

}
