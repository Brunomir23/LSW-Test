
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{

      
	public TMP_Text PlayerCoins;

	public int Coins;

	void Start ()
	{
        PlayerCoins.text = Coins.ToString();
	}

	public void UseCoins (int amount)
	{
		Coins -= amount;
        UpdateCoins();

    }

	public bool HasEnoughCoins (int amount)
	{
		return (Coins >= amount);
	}

	public void UpdateCoins ()
	{
        int playerCoinsValue = int.Parse(PlayerCoins.text);
		for (int i = 0; i < playerCoinsValue; i++) {
            PlayerCoins.text = Coins.ToString ();
		}
	}

}
