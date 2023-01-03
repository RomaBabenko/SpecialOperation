using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed;
    Vector3 lastPos;
    public float damage = 10f;

    void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        RaycastHit hit;
        Debug.DrawLine(lastPos, transform.position);

        if(Physics.Linecast(lastPos, transform.position, out hit))
        {
            print(hit.transform.name);
            Destroy(gameObject);
            Shoot();
        }
        lastPos = transform.position;
        
        void Shoot()
        {
            MovementHealthEnemy target = hit.transform.GetComponent<MovementHealthEnemy>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
        }
    }
}




