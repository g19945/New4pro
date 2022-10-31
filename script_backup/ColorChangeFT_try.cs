using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class ColorChangeFT_try : MonoBehaviour
{

    MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
      mesh = GetComponent<MeshRenderer>();
      mesh.material.color = mesh.material.color - new Color32(0,0,0,0);
      //StartCoroutine("Transparent");
    }

    /*void OnMouseEnter(){
      for ( int i = 255 ; i > 0 ; i-- ){
          mesh.material.color = mesh.material.color + new Color32(0,0,0,1);
          yield return new WaitForSeconds(0.005f);
        }
    }*/

    /*void OnMouseEnter()
    {
      this.GetComponent<MeshRenderer>().color += new Color(0,0,0, -0.1f);
    }*/

    public IEnumerator Transparent(){
    //public void Transparent(){
      for ( int i = 0 ; i < 255 ; i++ ){
          mesh.material.color = mesh.material.color + new Color32(0,0,0,1);
          //this.GetComponent<SpriteRenderer>().color += new Color(0,0,0,120);
          yield return new WaitForSeconds(0.005f);
          //0.09f遅い　0.01f普通　0.005f早い
          //透過速度=数字が小さいほど早く透過する
      }
    }
}
