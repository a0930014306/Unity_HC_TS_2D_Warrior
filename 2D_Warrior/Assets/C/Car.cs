using UnityEngine;

public class Car : MonoBehaviour
{
    //單行註解:不會被程式讀取
    //欄位語法;
    //修飾詞 類型 名稱 (指定 值);

    //四大種類
    //整數 int
    //浮點數 float
    //字串 string
    //布林值 bool

    //修飾詞
    //私人:不會顯示(預設) private
    //公開:會顯示 public    
    
    //指定符號: = 

    //欄位屬性
    //語法
    //[屬性名稱("字串或對應的值")]
    //標題
    //提示
    //範圍
    [Header("這是汽車的高度"),Range(1,10)]
    public int height = 5;
    [Tooltip("這是汽車的重量,單位是噸"),Range(2.5f,10.5f)]
    //Tooltip 游標放置在字上面才會顯示
    public float weight = 5.5F;
    [Header("這是汽車的品牌")]
    public string Brand = "BMW";
    [Header("這是汽車是否有天窗")]
    public bool hasWindow = true;
    //是 : true
    //否 : false

    //其他類型
    //顏色

    public Color mycolor;
    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color mycolor2 =new Color(0.5f, 0.3f, 0.1f);
    public Color mycolor3 = new Color(0, 0.5f, 0.3f, 0.5f);
    //紅 ,綠 ,藍, 透明度

    //座標
    //向量維度(2 - 4)

    public Vector2 V2Azero = Vector2.zero;
    public Vector2 V2Bone = Vector2.one;
    public Vector2 V2A = new Vector2(1.5f, 2.5f);
    public Vector3 V3A = new Vector3(1, 1, 1);
    public Vector4 V4A = new Vector4(1, 1, 1, 1);

    //圖片與音效

    public Sprite picture;
    public AudioClip sound;

    //遊戲物件與元件
    //遊戲物件:儲存階層面板內的物件與預製物

    public GameObject objA;
    public GameObject objB;

    //元件:儲存屬性面板裡可摺疊的元件

    public Transform tra;
    public Camera cam;
    



}
