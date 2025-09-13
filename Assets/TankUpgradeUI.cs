using UnityEngine;
using UnityEngine.UI;
using Tanks.Complete;

public class UpgradeManager : MonoBehaviour
{
    [Header("UI Buttons")]
    public Button speedButton;
    public Button armorButton;
    public Button damageButton;

    private TankMovement playerTank;

    private void Start()
    {
        if (speedButton != null) speedButton.onClick.AddListener(UpgradeSpeed);
        if (armorButton != null) armorButton.onClick.AddListener(UpgradeArmor);
        if (damageButton != null) damageButton.onClick.AddListener(UpgradeDamage);
    }

    public void SetPlayerTank(TankMovement tank)
    {
        playerTank = tank;
        Debug.Log($"Player tank set: {tank.name}, PlayerNumber = {tank.m_PlayerNumber}");
    }

    private void UpgradeSpeed()
    {
        if (playerTank != null)
        {
            playerTank.m_Speed += 10f;
            Debug.Log($"Speed for player {playerTank.m_PlayerNumber}, new speed: {playerTank.m_Speed}");
        }
    }

    private void UpgradeArmor()
    {
        if (playerTank != null)
        {
            Debug.Log($"Armor player {playerTank.m_PlayerNumber}");
        }
    }

    private void UpgradeDamage()
    {
        if (playerTank != null)
        {
            Debug.Log($"💥 Damage upgraded for Player {playerTank.m_PlayerNumber}");
        }
    }
}
