using UnityEngine;
using UnityEngine.UI;

public class MoneyGame : MonoBehaviour
{
    public int money;
    public Text moneyDisplay;

    public void Start()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetInt("money");
        }
    }

    public void Update()
    {
        moneyDisplay.text = money.ToString();
        PlayerPrefs.SetInt("money", money);
    }

    public void Coin()
    {
        money += Random.Range(1, 5);
        PlayerPrefs.SetInt("money", money);
    }
}

