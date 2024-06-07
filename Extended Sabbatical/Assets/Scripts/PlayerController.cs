using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D Rigidbody_Player;
    [SerializeField] float F_MoveSpeed;
    [SerializeField] Animator Animator_Player;
    public bool buttonRightPressed;
    public bool buttonLeftPressed;

    void Update()
    {
        buttonRightPressed = FindObjectOfType<ButtonRight>().buttonRightPressed;
        buttonLeftPressed = FindObjectOfType<ButtonLeft>().buttonLeftPressed;

        if (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.LeftArrow) || buttonLeftPressed == false)
        {
            Animator_Player.SetBool("Walk_Left", false);
            Rigidbody_Player.velocity = Vector2.zero;
            Rigidbody_Player.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || buttonLeftPressed == true)
        {
            Vector2 v2_newSpeedLeft = new(-F_MoveSpeed, Rigidbody_Player.velocity.y);
            Rigidbody_Player.velocity = v2_newSpeedLeft;
            Animator_Player.SetBool("Walk_Left", true);
        }


        if (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.RightArrow) || buttonRightPressed == false)
        {
            Animator_Player.SetBool("Walk_Right", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || buttonRightPressed == true)
        {
            Vector2 v2_newSpeedRight = new(F_MoveSpeed, Rigidbody_Player.velocity.y);
            Rigidbody_Player.velocity = v2_newSpeedRight;
            Animator_Player.SetBool("Walk_Right", true);
        }

    }
}