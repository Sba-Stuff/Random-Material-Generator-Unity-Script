using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommaterial : MonoBehaviour {
    public Material[] totalmaterial;
    int materialcount;
     
 // Use this for initialization
 void Start () {
        materialcount = totalmaterial.Length;
        Renderer rend = GetComponent<Renderer>();
        rend.material = totalmaterial[Random.Range(0,materialcount)];
    }
 
 // Update is called once per frame
 //void Update () {
  
 //}
}