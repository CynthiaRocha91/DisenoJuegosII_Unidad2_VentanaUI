using UnityEngine;

public class PageNavigator : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

   public void NextPage()
{
    Debug.Log("NEXT PRESIONADO");

    page1.SetActive(false);
    page2.SetActive(true);
}

    public void BackPage()
    {
        page1.SetActive(true);
        page2.SetActive(false);
    }
}
