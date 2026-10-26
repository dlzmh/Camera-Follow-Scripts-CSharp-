using UnityEngine;

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
