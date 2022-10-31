using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;
using System;
//using Class;

public class BrowserScript : MonoBehaviour
{
    private Browser browser;
    // Start is called before the first frame update

    //TRY4
    private GameObject colorchangescript;
    CCFT ccft;
    MeshRenderer mesh;

    /*public static BrowserScript instance;
    public int number;*/


    /*void Awake()
    {
      if(instance == null)
      {
        instance =this;
      }
    }*/

    void Start()
    {

      Debug.Log("Test");

      browser = GetComponent<Browser>();//assuming we are a MonoBehaviour attached to the same GameObject as the Browser
      mesh = GetComponent<MeshRenderer>();
      // browser.RegisterFunction("mouseOver", args => {
      //     Debug.Log("[mouseOver] No.:" + (int)args[0]);
      //     //受け取った時に実行する関数(args);
      // }
      // );

      //ページ遷移時にコールバック関数を毎回登録するように指定
      Action<JSONNode> act = delegate { RegisterCallbakFunctions(); };
      browser.onLoad += act;

      //TRY2
      //ColorChangeFT ccft = refObj.GetComponent< ColorChangeFT >();

    }

    /// <summary>
    /// コールバック関数の登録
    /// </summary>
    void RegisterCallbakFunctions()
    {
      browser.RegisterFunction("horrorMouseOver", args => {

        Debug.Log("recieve done. form BrowserScript.cs");
        colorchange();
          //Debug.Log("[mouseOver] No.:" + (int)args[0]);
          //number=args[0];
          //Debug.Log("number is [" + number +"]");
          //colorchange();

          //TRY1
          //Class instance = new Class();
          //instance.ColorChangeFT.Transparent();

          //TRY2
          //ColorChangeFT CCFT= new ColorChangeFT();
          //ccft = GameObject.Find("obj").GetComponent<ColorChangeFT>();
          //ccft.Transparent();

          //TRY3
          //ColorChangeFT.instance.Transparent();

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
    void colorchange(){
      colorchangescript = GameObject.Find("Cube");
      ccft = colorchangescript.GetComponent<CCFT>();
    }

}
