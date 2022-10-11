using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class BrowserScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

      var browser = GetComponent<Browser>();//assuming we are a MonoBehaviour attached to the same GameObject as the Browser
      browser.RegisterFunction("mouseOver(1)", args => {
          Debug.Log("[mouseOver] No.:" + args[0]);
          //受け取った時に実行する関数(args);
      }
      );
    }
    // void 受け取った時に実行する関数(var args){
    //   if (args[0] == 1){
    //     //normal to horror
    //     setHorror();
    //   }else{
    //     // horror to normal
    //     setNormal();
    //   }
    // }
    // // ホラーやノーマルのオブジェクトにアタッチされたスクリプトにはsetVisble()関数とsetInvisible()関数があり、それを実行すると透明度が変化する
    // void setHorror(){
    //   //さくせん１
    //   list hl = この世界の全てのホラーオブジェクト; // 「特定のtagのついたオブジェクトを全て取得する」みたいな手法で出来そう。妹尾さんに聞けばわかる
    //   hl.setVisible();
    //   list nl = この世界の全てのノーマルオブジェクト;
    //   nl.setInvisible();
    //
    //   //作戦２
    //   sendmessage("horror");みたいなやつ
    // }
    // void setInvisible(){
    //
    // }

    // Update is called once per frame
    void Update()
    {

    }
}
