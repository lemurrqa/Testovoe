using Mirror;
using TMPro;
using UnityEngine;

public class PlayerInfoUI : NetworkBehaviour
{
    [SerializeField] private TMP_Text _playerNicknameText;
    [SerializeField] private TMP_Text _playerScoreText;

    public bool IsActive = false;

    [Command]
    public void Show()
    {
        IsActive = true;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        IsActive = false;
        gameObject.SetActive(false);
    }

    public void SetLocalPlayer()
    {
        _playerNicknameText.color = Color.green;
        _playerScoreText.color = Color.green;
    }

    public void OnPlayerNicknameChanged(string newPlayerNickname)
    {
        _playerNicknameText.text = newPlayerNickname;
    }

    public void OnPlayerScoreChanged(int score)
    {
        _playerScoreText.text = "Score: " + score;
    }
}
