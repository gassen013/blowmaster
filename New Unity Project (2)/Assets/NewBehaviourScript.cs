using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    

    // Use this for initialization
    void Start ()
    {
        int c = 0;
        Debug.Log("hi");
        int[] how = new int[11];
        foreach (int i  in how)
        {
           
            how[c] = 10;
            c++;
        }
        foreach (int k in how)
        {
            Debug.Log(k);
            Debug.Log("how[k]" + how[k]);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
