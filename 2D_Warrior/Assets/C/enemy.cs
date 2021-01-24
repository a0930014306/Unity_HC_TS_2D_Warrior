
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D),typeof(AudioSource),typeof(CapsuleCollider2D))]
public class enemy : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10;
    [Header("攻擊範圍"), Range(0, 100)]
    public float atkrange = 10;
    [Header("攻擊力"), Range(0, 1000)]
    public float power = 10;
    [Header("血量"), Range(0, 5000)]
    public float hp = 2500;
    [Header("血量文字")]
    public Text texthp;
    [Header("血量圖片")]
    public Image imghp;
    
   

    private Animator ani;
    private AudioSource aud;
    private Rigidbody2D rig;
    public float hpMax;
    private player player;

    private void Start()
    {
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody2D>();
        hpMax = hp;
        //透過類型尋找物件<物件>() - 不能有重複物件
        player = FindObjectOfType<player>();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收傷害值</param>
    public void Damage(float damage) 
    {
        hp -= damage;                    //遞減
        ani.SetTrigger("受傷觸發");      //受傷動畫
        texthp.text = hp.ToString();    //血量文字.文字內容 = 血量.轉字串()
        imghp.fillAmount = hp / hpMax;  //血量圖片.填滿長度 = 目前血量 / 最大血量;

        if (hp <= 0) Dead();
    }

    private void Dead()
    {
        hp = 0;
        texthp.text = 0.ToString(); 
        ani.SetBool("死亡開關",true);

        GetComponent<CapsuleCollider2D>().enabled = false;
    }

    private void Move()
    {
        /** 判斷式寫法
        if (transform.position.x > player.transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        */

        //三元運算子 - 布林值 ? 結果1 : 結果2

        //y = x是否大於玩家x ? 是 y = 180 : 否 y = 0
        float y = transform.position.x > player.transform.position.x ? 180 : 0;
        transform.eulerAngles = new Vector3(0, y, 0);

        //剛體.移動座標(座標 + 前方 * 一禎時間 *速度)
        rig.MovePosition(transform.position + transform.right * Time.deltaTime * speed);

        //動畫.設定布林值("走路開關" , 剛體.速度.值(vector轉為布林值) > 0)
        ani.SetBool("走路開關", rig.velocity.magnitude > 0);
    }
    

}
