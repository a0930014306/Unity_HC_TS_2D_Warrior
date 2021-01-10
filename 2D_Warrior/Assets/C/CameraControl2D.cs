
using UnityEngine;

public class CameraControl2D : MonoBehaviour
{
    [Header("目標物件")]
    public Transform target;
    [Header("追蹤速度"),Range(0,100)]
    public float speed = 20;

    /// <summary>
    /// 追蹤目標物件
    /// </summary>
    public void Track()
    {
        //取得玩家座標
        Vector3 posA = target.position;
        //取得攝影機座標
        Vector3 posB = transform.position;
        //Z軸 = -10
        posA.z = -10;

        //差值
        posB = Vector3.Lerp(posB, posA ,speed * Time.deltaTime);
        //更新攝影機座標
        transform.position = posB;


    }

    //延遲更新 : 在Update執行之後才執行, 追蹤
    private void LateUpdate()
    {
        Track();
    }



}
