using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private PlayerMover _player;

    private void Update()
    {
        _scoreText.text = _player.Score.ToString();
    }
}
