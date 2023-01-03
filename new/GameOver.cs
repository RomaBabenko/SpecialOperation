using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] 
    public float health = 100f;
    public Slider healthBar;
    public GameObject deathScreen;
    public ParticleSystem Explosion;
    public ParticleSystem shotTank;
    public Animator animVsu;
    public Animator animTank;

    void Update()
    {
        healthBar.value = health;
    }

    public void Shovel(float amount)
    {
        health -= amount;
        if (health == 0f)
        {
                Invoke("Rot", 0.5f);
                Invoke("Boom", 2.05f);
                Invoke("End", 4f);
        }
    }

    void Rot()
    {
        animTank.SetBool("rot", true);
    }

    void Boom()
    {
        Explosion.Play();
        shotTank.Play();
        animVsu.SetBool("death2", true); 
    }

    void End()
    {
        deathScreen.SetActive(true);
    }
}
