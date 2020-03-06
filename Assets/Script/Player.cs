using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text itemText;
    private int totalHeart = 0;
    private int totalKey = 0;
    private int totalStar = 0;
    private bool bawaBintang = false;

    void Start()
    {   
        UpdateItemText();
       

    }
    //melakukan pengecekan sesuai dengan tagnya 
    void OnTriggerEnter2D(Collider2D hit)
    {
    
        if (hit.CompareTag("Heart"))
        {
            bawaBintang = true;
            totalHeart++;
            UpdateItemText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Bintang"))
        {   
            bawaBintang = true;
            totalStar++;
            UpdateItemText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Key"))
        {
            bawaBintang = true;
            totalKey++;
            UpdateItemText();
            Destroy(hit.gameObject);
        }
    }
    //untuk update item 
    private void UpdateItemText()
    {
        string Pesan = "(Belum ada yang dikumpulkan)" + " : " + " [Star] " + totalStar + "[Heart] " + totalHeart + " [Key] " + totalKey;
        if (bawaBintang) Pesan= "(Item Terkumpul)" + " : " + " [Star] " + totalStar + "[Heart] " + totalHeart + " [Key] " + totalKey;
        itemText.text = Pesan;

    }


}