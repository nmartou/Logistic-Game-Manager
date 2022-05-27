using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VehicleClass;

public class VehicleButton : MonoBehaviour
{
    public GameObject lockedVue;
    public GameObject unlockedVue;
    public GameObject specificVehicleVue;
    public bool isLocked = true;

    public Text wheelsText;
    public Text engineText;
    public Text gearboxText;
    public Text suspensionText;
    public Text controleText;
    public Text fuelText;

    public Text levelText;

    public GameObject car;
    Vehicle vehicle;

    public Text errorText;

    public GameObject errorObject;
    private Animator animator;

    private void Start()
    {
        car.gameObject.SetActive(false);
        animator = errorObject.gameObject.GetComponent<Animator>();

        if (isLocked)
        {
            lockedVue.SetActive(true);
            unlockedVue.SetActive(false);
        }
        else
        {
            lockedVue.SetActive(false);
            unlockedVue.SetActive(true);
        }
    }

    public void OnClickVehicleButton()
    {
        if (isLocked && GameManager.Instance.MyTotalMoney() >= 15000)
        {
            isLocked = false;
            lockedVue.SetActive(false);
            unlockedVue.SetActive(true);
            vehicle = new Vehicle();
            GameManager.Instance.WithdrawTotalMoney(15000);
        }
        else if (GameManager.Instance.MyTotalMoney() < 15000)
        {
            if(!animator.GetCurrentAnimatorStateInfo(0).IsName("Error"))
            {
                errorText.text = "You do not have enough money !";
                Debug.Log("Not enough money !");
                animator.SetTrigger("switch");
            }
        }
        else
        {
            wheelsText.text = "lvl " + vehicle.levelWheels.ToString() + " - $" + vehicle.part1LevelPrice[vehicle.levelWheels];
            engineText.text = "lvl " + vehicle.levelEngine.ToString() + " - $" + vehicle.part1LevelPrice[vehicle.levelEngine];
            gearboxText.text = "lvl " + vehicle.levelGearbox.ToString() + " - $" + vehicle.part2LevelPrice[vehicle.levelGearbox];
            suspensionText.text = "lvl " + vehicle.levelSuspension.ToString() + " - $" + vehicle.part2LevelPrice[vehicle.levelSuspension];
            controleText.text = "lvl " + vehicle.levelControle.ToString() + " - $" + vehicle.part3LevelPrice[vehicle.levelControle];
            fuelText.text = "lvl " + vehicle.levelFuel.ToString() + " - $" + vehicle.part3LevelPrice[vehicle.levelFuel];

            levelText.text = "lvl " + vehicle.levelVehicle.ToString();

            car.gameObject.SetActive(true);

            specificVehicleVue.SetActive(true);
        }
    }
}
