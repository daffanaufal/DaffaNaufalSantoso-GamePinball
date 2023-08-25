using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
	public TMP_Text scoreText;

	// reference ke score manager
	public ScoreManager scoreManager;

	private void Update()
	{
		// agar lebih mudah, tiap update kita set aja angak score text nya menjadi angka score
		scoreText.text = scoreManager.score.ToString();
	}
}
