using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterMovement characterMovement;
    
    public void Update()
    {
        characterMovement.MoveUpdate();
    }
}
