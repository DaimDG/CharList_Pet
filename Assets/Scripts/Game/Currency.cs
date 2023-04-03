using System;
using UnityEngine;

public class Currency
{
    private int _copper;
    private int _silver;
    private int _electrum;
    private int _gold;
    private int _platinum;
    public int CoinCopper { get => _copper; set => _copper = ClampCoinValue(value); }
    public int SilverCopper { get => _silver; set => _silver = ClampCoinValue(value); }
    public int ElectrumCopper { get => _electrum; set => _electrum = ClampCoinValue(value); }
    public int GoldCopper { get => _gold; set => _gold = ClampCoinValue(value); }
    public int PlatinumCopper { get => _platinum; set => _platinum = ClampCoinValue(value); }

    private int ClampCoinValue(int value)
    {
        return Mathf.Clamp(value, 0, 100000);
    }

    private int Conversion(CurrencyType fromCurrency, CurrencyType toCurrency, int value)
    {
        float currencyMultiplier = 1f;
        switch (fromCurrency)
        {
            case CurrencyType.Copper:
                switch (toCurrency)
                {
                    case CurrencyType.Copper: currencyMultiplier = 1f; break;
                    case CurrencyType.Silver: currencyMultiplier = 10f; break;
                    case CurrencyType.Electrum: currencyMultiplier = 50; break;
                    case CurrencyType.Gold: currencyMultiplier = 100f; break;
                    case CurrencyType.Platinum: currencyMultiplier = 1000f; break;
                    default: Debug.Log("ERROR: Converting to unknown Currency"); break; 
                }
                break;
            case CurrencyType.Silver:
                switch (toCurrency)
                {
                    case CurrencyType.Copper: currencyMultiplier = 0.1f; break;
                    case CurrencyType.Silver: currencyMultiplier = 1f; break;
                    case CurrencyType.Electrum: currencyMultiplier = 5f; break;
                    case CurrencyType.Gold: currencyMultiplier = 10f; break;
                    case CurrencyType.Platinum: currencyMultiplier = 100f; break;
                    default: Debug.Log("ERROR: Converting to unknown Currency"); break; 
                }
                break;
            case CurrencyType.Electrum:
                switch (toCurrency)
                {
                    case CurrencyType.Copper: currencyMultiplier = 0.02f; break;
                    case CurrencyType.Silver: currencyMultiplier = 0.2f; break;
                    case CurrencyType.Electrum: currencyMultiplier = 1f; break;
                    case CurrencyType.Gold: currencyMultiplier = 2f; break;
                    case CurrencyType.Platinum: currencyMultiplier = 50f; break;
                    default: Debug.Log("ERROR: Converting to unknown Currency"); break; 
                }
                break;
            case CurrencyType.Gold:
                switch (toCurrency)
                {
                    case CurrencyType.Copper: currencyMultiplier = 0.01f; break;
                    case CurrencyType.Silver: currencyMultiplier = 0.1f; break;
                    case CurrencyType.Electrum: currencyMultiplier = 0.5f; break;
                    case CurrencyType.Gold: currencyMultiplier = 1f; break;
                    case CurrencyType.Platinum: currencyMultiplier = 10f; break;
                    default: Debug.Log("ERROR: Converting to unknown Currency"); break; 
                }
                break;
            case CurrencyType.Platinum:
                switch (toCurrency)
                {
                    case CurrencyType.Copper: currencyMultiplier = 0.001f; break;
                    case CurrencyType.Silver: currencyMultiplier = 0.01f; break;
                    case CurrencyType.Electrum: currencyMultiplier = 0.05f; break;
                    case CurrencyType.Gold: currencyMultiplier = 0.1f; break;
                    case CurrencyType.Platinum: currencyMultiplier = 1f; break;
                    default: Debug.Log("ERROR: Converting to unknown Currency"); break; 
                }
                break;
            default: Debug.Log("ERROR: Converting from unknown Currency"); break; 
        }
        return Mathf.RoundToInt(value * currencyMultiplier);
    }
}
