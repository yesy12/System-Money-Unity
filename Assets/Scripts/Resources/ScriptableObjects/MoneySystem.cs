using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Money", menuName = "Resources/Money Configuration", order = 1)]
public class MoneySystem : ScriptableObject {

    [SerializeField] private float _quantify;

    public float quantify {
        get { return _quantify;  } 
        set {
            if (value >= 0) {
                _quantify = value;
                OnMoneyChanged?.Invoke(value);
            }
        }
    }

    public event Action<float> OnMoneyChanged;

    public bool addMoney(float amount) {
        if (amount > 0) {
            quantify += amount;
            OnMoneyChanged?.Invoke(quantify);
            return true;
        }
        return false;
    }

    public bool removeMoney(float amount) {
        var removeValue = (quantify - amount);

        if (removeValue > 0) {
            quantify -= amount;
            OnMoneyChanged?.Invoke(quantify);
            return true;
        }

        return false;
    }
}