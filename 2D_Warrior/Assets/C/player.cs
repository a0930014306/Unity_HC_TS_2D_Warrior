
using UnityEngine;

public class player : MonoBehaviour
{
    #region 角色欄位
    [Header("移動速度"), Range(0, 1000)]
    public float movespeed = 15;
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 750;
    [Header("是否在地板上")]
    public bool ground = true;
    [Header("子彈")]
    public Sprite bullet;
    [Header("子彈生成點")]
    public Transform bulletborn;
    [Header("子彈速度"), Range(0, 5000)]
    public int bulletspeed = 800;
    [Header("開槍音效")]
    public AudioClip shootaud;
    [Header("血量"), Range(0, 200)]
    public int hp = 100;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion

    public float h;

    private void Start()
    {
        //GetComponent<泛型>()
        //泛型:泛指所有類型
        //GetComponent<Animator>()
        //GetComponent<AudioSource>()

        //剛體欄位 = 取得原件<剛體>();
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();


    }
    public void Update()
    {
        GetHorizontal();
        Move();
        Jump();
    }
    /// <summary>
    /// 取得水平軸向
    /// </summary>
    public void GetHorizontal()
    {
        //浮點數 = 輸入.取得軸向("水平")
        h = Input.GetAxis("Horizontal");
    }

   
    private void Move()
    {

        //剛體.加速度 = 二維(水平 * 速度, 剛體原本的加速度 Y);
        rig.velocity = new Vector2(h * movespeed, rig.velocity.y);

        //如果 玩家 按下 D 或 右鍵 就執行(內容)
        if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            //transform 指的是與此腳本同一層的 元件
            //Rotation 角度在程式是 localEulerAngles
            transform.localEulerAngles = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            transform.localEulerAngles =new Vector3(0,180,0);

        }

        ani.SetBool("跑步開關", h != 0);
    }

    

    private void Jump()
    {
        //如果 在地板上 且 按下空白鍵 才可以跳躍
        if (ground && Input.GetKeyDown(KeyCode.Space))
        {
            //剛體.添加推力(二維向量);
            rig.AddForce(new Vector2(0 , jump));
            //不在地板上
            ground = false;
            
        }

        
    }

    private void Shoot()
    {

    }

    private void Hurt(float damage)
    {

    }

    private void Dead()
    {

    }
}
