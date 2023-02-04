using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript2 : MonoBehaviour
{

// number it starts with
    float[] rotations = {0,90,180,270};
    
    private void Start(){
        int rand = Random.Range(0,rotations.Length);
        transform.eulerAngles = new Vector3(0,0,rotations[rand]);
    }



    private void OnMouseDown(){
        transform.Rotate(new Vector3(0,0,90));
    }

}
