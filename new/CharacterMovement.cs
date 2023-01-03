using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Animator anim;
    public CharacterStatus characterStatus;
    public bool debugAiming;
    public bool isAiming;

    public void MoveUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Aiming", true);
        }
       
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Aiming", false);
        }

        if (!debugAiming)
            characterStatus.isAiming = Input.GetMouseButton(0);
        else
            characterStatus.isAiming = isAiming;
    }
}

