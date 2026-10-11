using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    private void Start()
    {
        // Step 6: Set the 1st screen to true
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    // Step 7a: Public void function to turn on screen 1
    public void OpenScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    // Step 7a: Public void function to turn on screen 2
    public void OpenScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}
