using UnityEngine;
using TMPro;

public class HudController : MonoBehaviour{

    public TMP_Text MoneyTextValue;

    private void Awake() {
        
    }


    void FixedUpdate(){
        MoneyTextValue.text = SystemControllerValues.money.ToString();
    }
}