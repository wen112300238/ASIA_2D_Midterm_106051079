using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public GameObject dead;
    public Text textCount;
    public int count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "星星")
        {
            dead.SetActive(true);
        }
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }
        if (collision.tag == "紅蘿蔔")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = " " + count;

        }
    }
}
