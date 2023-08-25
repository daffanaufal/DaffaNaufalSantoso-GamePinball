using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
	// reference untuk button
	public Button mainMenuButton;
	public Button creditsButton;


	private void Start()
	{
		// setup event saat button di klik
		mainMenuButton.onClick.AddListener(MainMenu);
		creditsButton.onClick.AddListener(Credits);
	}

	public void MainMenu()
	{
		// kembali ke main menu
		SceneManager.LoadScene("MainMenu");
	}
	public void Credits()
	{
		SceneManager.LoadScene("Credits");
	}
}
