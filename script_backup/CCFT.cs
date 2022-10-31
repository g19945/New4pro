using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCFT : MonoBehaviour
{
  MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
      mesh = GetComponent<MeshRenderer>();
      mesh.material.color = mesh.material.color - new Color32(0,0,0,0);
      StartCoroutine("Transparent");
    }

    IEnumerator Transparent(){
      for ( int i = 255 ; i > 0 ; i-- ){
          mesh.material.color = mesh.material.color + new Color32(0,0,0,1);
          yield return new WaitForSeconds(0.05f);
      }
    }
}
