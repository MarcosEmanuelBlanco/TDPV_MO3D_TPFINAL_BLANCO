using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Failure : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelFailedText;
    [SerializeField] private Button backToMenuButton;
    [SerializeField] private Button restartButton;
    private void Awake()
    {
        levelFailedText.gameObject.SetActive(false);
        backToMenuButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }
    private void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) { return; }

        levelFailedText.gameObject.SetActive(true);
        backToMenuButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
