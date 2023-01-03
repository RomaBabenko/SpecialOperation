using UnityEngine;

public class DamageForSpawn : MonoBehaviour
{
    public float damage = 10f;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Spawn")
        {
            other.GetComponent<GameOver>().Shovel(damage);
        }
    }
}
