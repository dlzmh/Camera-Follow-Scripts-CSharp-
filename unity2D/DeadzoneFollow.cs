using UnityEngine;
//这个脚本是关于相机死区跟随，只有角色超出屏幕中的死区范围，相机才会跟随（可能会出现相机越界，看见虚空）
public class DeadzoneFollow : MonoBehaviour
{
    public float DeadzoneWide=2f;   //死区宽
    public float DeadzoneHigh=2f;   //死区高
    public Transform target;       
    void LateUpdate()
    {
        if (target == null) return;

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, target.position.x - DeadzoneWide, target.position.x + DeadzoneWide);
        pos.y = Mathf.Clamp(pos.y, target.position.y - DeadzoneHigh, target.position.y + DeadzoneHigh);
        pos.z = -10f;

        transform.position = pos;
    }
}
