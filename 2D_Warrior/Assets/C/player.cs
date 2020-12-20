
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1000)]
    public float movespeed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;
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
    private Rigidbody2D rid;
    private Animator ani;
}
