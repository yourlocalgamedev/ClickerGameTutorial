using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public int cash;
    public int cashPerClick;
    public int level;
    public int price;
    public Text cashText;
    public Text priceText;
    public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("CashPref"))
        {
            cash = PlayerPrefs.GetInt("CashPref");
        }
        else
        {
            PlayerPrefs.SetInt("CashPref", 0);
            cash = 0;
        }

        if (PlayerPrefs.HasKey("LevelPref"))
        {
            level = PlayerPrefs.GetInt("LevelPref");
        }
        else
        {
            PlayerPrefs.SetInt("LevelPref", 1);
            level = 1;
        }
    }

    public void UpdateText()
    {
        cashText.text = "$" + cash.ToString();
        priceText.text = "Level Up: " + price.ToString();
        levelText.text = "lvl " + level.ToString();
    }

    public void AddCash()
    {
        cash += cashPerClick;
    }

    public void LevelUp()
    {
        if(cash >= price)
        {
            cash -= price;
            level += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        cashPerClick = level;
        price = level * 100;
        PlayerPrefs.SetInt("CashPref", cash);
        PlayerPrefs.SetInt("LevelPref", level);
        UpdateText();
    }
}
