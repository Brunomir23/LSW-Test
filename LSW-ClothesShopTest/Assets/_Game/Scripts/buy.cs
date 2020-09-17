using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buy : MonoBehaviour
{
    public int price,itemID;
    public TMP_Text priceTxt;
    public Game gc;
    public bool isPurchased = false;
    public Button buyBtn;
    public GameObject unlockPanel,spawn,inventoryItems,characterItems;
    public GameObject moneyAnim;
    public AudioSource audioClip, audioClipDenied;
    // Start is called before the first frame update
    void Start()
    {
       
        
        priceTxt.text = price.ToString();
        moneyAnim.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buyItem()
    {
        if (gc.HasEnoughCoins(price))
        {
            gc.UseCoins(price);
            DisableBuyButton();
            isPurchased = true;
            var unlock = Instantiate(unlockPanel, new Vector3(spawn.transform.position.x, spawn.transform.position.y,
                spawn.transform.position.z), Quaternion.identity);
            unlock.transform.parent = spawn.transform;
            inventoryItems.GetComponent<Items>().AddToList(itemID);
            characterItems.GetComponent<Items>().AddToList(itemID);
            audioClip.Play();
        } else
        {
            //not enough money animation
            moneyAnim.SetActive(true);
            moneyAnim.GetComponent<Animator>().SetTrigger("playAnim");
            audioClipDenied.Play();
        }
    }

    void DisableBuyButton()
    {
        buyBtn.interactable = false;
        buyBtn.transform.GetChild(0).GetComponent<TMP_Text>().text = "PURCHASED";
    }
}
