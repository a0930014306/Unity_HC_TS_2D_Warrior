
using UnityEngine;

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

    private Animator ani;
    private AudioSource aud;
    private Rigidbody2D rig;

    private void Start()
    {
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收傷害值</param>
    public void Damage(float damage) 
    {
        hp -= damage;                //遞減
        ani.SetTrigger("受傷觸發");   //受傷動畫
    }

}
