using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

//browser.RegisterFunction("mouseOver", args => Debug.Log("Mouse Over: " + args[0] + " val: " + (int)args[1]));

public class ColorChangeFT : MonoBehaviour
{
  MeshRenderer mesh;

void Start ()
{
  mesh = GetComponent<MeshRenderer>();
  mesh.material.color = mesh.material.color - new Color32(0,0,0,0);
  StartCoroutine("Transparent");
}

  IEnumerator Transparent()
  {
      for ( int i = 255 ; i > 0 ; i-- ){
          mesh.material.color = mesh.material.color + new Color32(0,0,0,1);
          yield return new WaitForSeconds(0.05f);
      }
  }
}
