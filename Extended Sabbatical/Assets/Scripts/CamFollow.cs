using UnityEngine;
public class CamFollow : MonoBehaviour
{
    public Transform Me;
    float f_posX;
    float f_posY;
    Vector3 v3_newPos;

    private void Update()
    {
        f_posX = Me.position.x;
        f_posY = Me.position.y;
        v3_newPos.x = f_posX;
        v3_newPos.y = f_posY;
        v3_newPos.z = transform.position.z;
        transform.position = v3_newPos;
    }
}