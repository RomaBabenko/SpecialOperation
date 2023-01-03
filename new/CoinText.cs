using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    Text coinText;
    public static int coin;

    void Start()
    {
        coinText = GetComponent<Text>();
        coin = PlayerPrefs.GetInt("money", coin);
    }

    void Update()
    {
        coinText.text = coin.ToString();
        PlayerPrefs.SetInt("money", coin);
    }
}
