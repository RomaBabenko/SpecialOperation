using UnityEngine;

public class MovementHealthEnemy : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed;
    public Animator anim;
    public GameObject showel;
    public float health = 10f;
    private Score score;
    private MoneyGame moneyGame;

    private void Start()
    {
        score = FindObjectOfType<Score>();
        moneyGame = FindObjectOfType<MoneyGame>();
    }
    public void Update()
    {
        if (transform.position.z < 2f)
        {
            anim.SetBool("attack", true);
            fallSpeed = 0f;
        }

        transform.position -= new Vector3(0, 0, fallSpeed * Time.deltaTime);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health == 0f)
        {
            anim.SetBool("death", true);
            fallSpeed = 0f;
            score.Kill();
            moneyGame.Coin();
            Destroy(gameObject, 4);
            Destroy(showel);
        }    
    }
}
