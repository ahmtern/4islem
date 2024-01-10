using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class Kodlama : MonoBehaviour
{
    
    public UnityEngine.UI.Text ilkSayi, ikinciSayi, islem, cevap, sonuc;
    public UnityEngine.UI.InputField cevapInput;
    int sayi1, sayi2, islemIsareti;
    int islemSonuc;
    
    // Start is called before the first frame update
    void Start()
    {
        YeniSoru();  
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void Kontrol() 
    {
        if (int.Parse(cevap.text)==islemSonuc)
        {
            sonuc.text = "Doðru";
        }
        else 
        {
            sonuc.text = "Yanlýþ";
        }
    }
    public void YeniSoru() 
    {
        sonuc.text = "";
        cevapInput.text = "?";
        sayi1 = Random.Range(1, 50);
        sayi2 = Random.Range(1, 50);
        islemIsareti = Random.Range(1, 5);
        switch (islemIsareti)
        {
            case 1:
                islem.text = "+"; islemSonuc = sayi1 + sayi2; break;
            case 2:
                islem.text = "-"; islemSonuc = sayi1 - sayi2; break;
            case 3:
                islem.text = "*"; islemSonuc = sayi1 * sayi2; break;
            case 4:
                islem.text = "/"; islemSonuc = sayi1 / sayi2; break;

        }
        ilkSayi.text = sayi1 + "";
        ikinciSayi.text = sayi2 + "";
    }
}
