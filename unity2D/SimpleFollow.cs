using UnityEngine;
//这个脚本是最基础的2D游戏相机跟随角色，逻辑简单，相机随着角色的移动而移动（可能会出现相机越界，看见虚空）
public class SimpleFollow: MonoBehaviour
{
    public Transform target;
    void LateUpdate()
    {
        Vector3 pos=target.position;

        pos.z = -10f;   //z越小 离相机越远 画在下面

        transform.position = pos;
    }
}
