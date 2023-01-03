using UnityEngine;

public class IK : MonoBehaviour
{
    public Animator anim;
    //public CharacterMovement characterMovement;
    //public CharacterInventory characterInventory;
    public CharacterStatus characterStatus;
    public Transform targetLook;
    public Transform leftHand;
    public Transform leftHandTarget;
    public Transform rightHand;
    public Quaternion leftHandRot;
    public float rightHandWeight;
    public Transform shoulder;
    public Transform aimPivot;

    void Start()
    {
        shoulder = anim.GetBoneTransform(HumanBodyBones.RightShoulder).transform;
        aimPivot = new GameObject().transform;
        aimPivot.name = "aim pivot";
        aimPivot.transform.parent = transform;
        rightHand = new GameObject().transform;
        rightHand.name = "right hand";
        rightHand.transform.parent = aimPivot;
        leftHand = new GameObject().transform;
        leftHand.name = "left hand";
        leftHand.transform.parent = aimPivot;
        Vector3 temp = new Vector3(0.134f, -0.013f, 0.213f);
        rightHand.transform.position += temp;
        Quaternion rotRight = Quaternion.Euler(-10, -17, -90);
        rightHand.localRotation = rotRight;
    }
    
    void Update()
    {
        leftHandRot = leftHandTarget.rotation;
        leftHand.position = leftHandTarget.position;
        
        if (characterStatus.isAiming)
        {
            rightHandWeight += Time.deltaTime * 4;
        }
        else rightHandWeight -= Time.deltaTime* 4;

        rightHandWeight = Mathf.Clamp(rightHandWeight, 0, 1);
    }

    void OnAnimatorIK()
    {
        aimPivot.position = shoulder.position;

        if(characterStatus.isAiming)
        {
            aimPivot.LookAt(targetLook);
            anim.SetLookAtWeight(1f, .4f, 1f);
            anim.SetLookAtPosition(targetLook.position);
            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKPosition(AvatarIKGoal.LeftHand, leftHand.position);
            anim.SetIKRotation(AvatarIKGoal.LeftHand, leftHandRot);
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);
            anim.SetIKPosition(AvatarIKGoal.RightHand, rightHand.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, rightHand.rotation);
        }
        else
        {
            anim.SetLookAtWeight(.3f, .3f, .3f);
            anim.SetLookAtPosition(targetLook.position);
            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKPosition(AvatarIKGoal.LeftHand, leftHand.position);
            anim.SetIKRotation(AvatarIKGoal.LeftHand, leftHandRot);
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);
            anim.SetIKPosition(AvatarIKGoal.RightHand, rightHand.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, rightHand.rotation);
        }
    }
}
