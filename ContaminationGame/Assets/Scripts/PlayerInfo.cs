using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public int nucleotides;
    [SerializeField] public int grossFee;
    [SerializeField] public int netFee;
    [SerializeField] public int cure;
    [SerializeField] private GameObject _playerNucleotides;
    [SerializeField] private GameObject _playerGrossFee;
    [SerializeField] private GameObject _playerNetFee;
    [SerializeField] private GameObject _playerCureFee;
    
    void ShowPlayerInfo()
    {
        
    }
}
