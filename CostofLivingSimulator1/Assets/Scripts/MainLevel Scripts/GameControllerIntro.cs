using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerIntro : MonoBehaviour
{
    public GameObject noDegreeButton;
    public GameObject hsDiplomaButton;
    public GameObject bachelorsDegreeButton;
    public GameObject fryCookButton;
    public GameObject waiterButton;
    public GameObject teacherButton;
    public GameObject callCenterAgentButton;
    public GameObject programmerButton;
    public GameObject crappyApartmentButton;
    public GameObject basicApartmentButton;
    public GameObject luxuryApartmentButton;
    public GameObject carButton;
    public GameObject motorcycleButton;
    public GameObject busButton;

    public GameObject welcomeScreen;
    public GameObject educationScreen1;
    public GameObject educationScreen2;
    public GameObject educationScreen3;
    public GameObject educationScreen4;
    public GameObject jobScreen1;
    public GameObject jobScreen2;
    public GameObject jobScreen3;
    public GameObject jobScreen4;
    public GameObject jobScreen5;
    public GameObject jobScreen6;
    public GameObject housingScreen1;
    public GameObject housingScreen2;
    public GameObject housingScreen3;
    public GameObject housingScreen4;
    public GameObject transportationScreen1;
    public GameObject transportationScreen2;
    public GameObject transportationScreen3;
    public GameObject transportationScreen4;
    public GameObject giftScreen1;
    public GameObject giftScreen2;
    public GameObject giftScreen3;
    public GameObject giftScreen4;
    public GameObject summaryScreen;


    private bool noDegree = false;
    private bool hsDiploma = false;
    private bool bachelorsDegree = false;
    private bool fryCook = false;
    private bool waiter = false;
    private bool teacher = false;
    private bool callCenterAgent = false;
    private bool programmer = false;
    private bool crappyApartment = false;
    private bool basicApartment = false;
    private bool luxuryApartment = false;
    private bool car = false;
    private bool motorcycle = false;
    private bool bus = false;
    private bool gift0 = false;
    private bool gift500 =  false;
    private bool gift1000 = false;

    public Text summaryInitialMoneyText;
    public Text summaryEducationText;
    public Text summaryJobText;
    public Text summaryJobPayText;
    public Text summaryHousingText;
    public Text summaryHousingRentText;
    public Text summaryTransportationText;
    public Text summaryTransportationCostText;
    public Text summaryGiftText;
    public Text summaryCurrentMoneyText;

    //private int actions = 3;
    //private double tips = random(0.00, 200.00);
    //private int education = 1;
    //private double gift;
    private double initialMoney = 0.00;
    private double currentMoney = 0.00;
    private double giftMoney = 0.00;
    private double monthlySalary;
    private double rent = 0.00;
    private double gas = 3.50;
    private double transportationCost = 0.00;
    //private double totalIncome = 0.00;
    //private double tax = 0.15;
    private string educationSelected;
    private string jobSelected;
    private string housingSelected;
    private string transportationSelected;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        currentMoney = initialMoney + giftMoney;

        summaryInitialMoneyText.text = "Initial Money: $" + initialMoney;
        summaryEducationText.text = "Education Status: " + educationSelected;
        summaryJobText.text = "Employment Status: " + jobSelected;
        summaryJobPayText.text = " - Monthly Salary: $" + monthlySalary;
        summaryHousingText.text = "Housing Status: " + housingSelected;
        summaryHousingRentText.text = " - Monthly Rent: $" + rent;
        summaryTransportationText.text = "Transportation Status: " + transportationSelected;
        summaryTransportationCostText.text = " - Monthly Travel Cost: $" + transportationCost;
        summaryGiftText.text = "Gift Received: $" + giftMoney;
        summaryCurrentMoneyText.text = "Current Money: $" + currentMoney;
    }

    // public void ChoosingEducation()
    // {
    //     if (education == 1)
    //     {
    //         ChooseEducationNoDegree();
    //     }
    //     else if (education == 2)
    //     {
    //         ChooseEducationHighSchoolDiploma();
    //     }
    //     else if (education == 3)
    //     {
    //         ChooseEducationBachelorsDegree();
    //     }
    // }
    
    public void ChooseEducation()
    {
        if (noDegree == true)
        {
            educationScreen1.SetActive(false);
            educationScreen2.SetActive(true);

            educationSelected = "No Degree";
            
            //Sets Available Jobs
            fryCookButton.SetActive(true);
            waiterButton.SetActive(true);
            callCenterAgentButton.SetActive(false);
            teacherButton.SetActive(false);
            programmerButton.SetActive(false);
        }
        else if (hsDiploma == true)
        {
            educationScreen1.SetActive(false);
            educationScreen3.SetActive(true);

            educationSelected = "High School Diploma";
            
            fryCookButton.SetActive(true);
            waiterButton.SetActive(true);
            callCenterAgentButton.SetActive(true);
            teacherButton.SetActive(false);
            programmerButton.SetActive(false);
        }
        else if (bachelorsDegree == true)
        {
            educationScreen1.SetActive(false);
            educationScreen4.SetActive(true);

            educationSelected = "Bachelor's Degree";
            
            fryCookButton.SetActive(true);
            waiterButton.SetActive(true);
            callCenterAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            programmerButton.SetActive(true);
        }
    }
    
    public void ChooseEducationNoDegree()
    {
        noDegree = true;
        ChooseEducation();
    }

    public void ChooseEducationHighSchoolDiploma()
    {
        hsDiploma = true;
        ChooseEducation();
    }

    public void ChooseEducationBachelorsDegree()
    {
        bachelorsDegree = true;
        ChooseEducation();
    }

    public void ChooseJob()
    {
        if (waiter == true)
        {
            jobScreen1.SetActive(false);
            jobScreen2.SetActive(true);
            
            jobSelected = "Waiter";
            monthlySalary = 1120.00;

            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(false);
            luxuryApartmentButton.SetActive(false);
        }
        else if (fryCook == true)
        {
            jobScreen1.SetActive(false);
            jobScreen3.SetActive(true);
            
            jobSelected = "Fry Cook";
            monthlySalary = 1600.00;

            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
        }
        else if (callCenterAgent == true)
        {
            jobScreen1.SetActive(false);
            jobScreen4.SetActive(true);
            
            jobSelected = "Call Center Agent";
            monthlySalary = 1920.00;

            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
        }
        else if (teacher == true)
        {
            jobScreen1.SetActive(false);
            jobScreen5.SetActive(true);
            
            jobSelected = "Teacher";
            monthlySalary = 2400.00;

            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);

        }
        else if (programmer == true)
        {
            jobScreen1.SetActive(false);
            jobScreen6.SetActive(true);
            
            jobSelected = "Programmer";
            monthlySalary = 3200.00;
            
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
        }
    }
    
    public void ChooseJobFryCook()
    {
        fryCook = true;
        ChooseJob();
    }

    public void ChooseJobWaiter()
    {
        waiter = true;
        ChooseJob();
    }

    public void ChooseJobTeacher()
    {
        teacher = true;
        ChooseJob();
    }

    public void ChooseJobCallCenterAgent()
    {
        callCenterAgent = true;
        ChooseJob();
    }

    public void ChooseJobProgrammer()
    {
        programmer = true;
        ChooseJob();
    }

    public void ChooseHousing()
    {
        if (crappyApartment == true)
        {
            housingScreen1.SetActive(false);
            housingScreen2.SetActive(true);
            
            housingSelected = "Crappy Apartment";
            rent = 700.00;
        }
        else if (basicApartment == true)
        {
            housingScreen1.SetActive(false);
            housingScreen3.SetActive(true);
            
            housingSelected = "Basic Apartment";
            rent = 1200.00;
        }
        else if (luxuryApartment == true)
        {
            housingScreen1.SetActive(false);
            housingScreen4.SetActive(true);
            
            housingSelected = "Luxury Apartment";
            rent = 1700.00;
        }
    }
    
    public void ChooseHousingCrappyApartment()
    {
        crappyApartment = true;
        ChooseHousing();
    }

    public void ChooseHousingBasicApartment()
    {
        basicApartment = true;
        ChooseHousing();
    }

    public void ChooseHousingLuxuryApartment()
    {
        luxuryApartment = true;
        ChooseHousing();
    }

    public void ChooseTransportation()
    {
        if (car == true)
        {
            transportationScreen1.SetActive(false);
            transportationScreen2.SetActive(true);
            
            transportationSelected = "Car";
            transportationCost = gas * 40;
        }
        else if (motorcycle == true)
        {
            transportationScreen1.SetActive(false);
            transportationScreen3.SetActive(true);
            
            transportationSelected = "Motorcycle";
            transportationCost = gas * 20;
        }
        else if (bus == true)
        {
            transportationScreen1.SetActive(false);
            transportationScreen4.SetActive(true);
            
            transportationSelected = "City Bus Transit";
            transportationCost = gas * (200 / 7);
        }
    }

    public void ChooseTransportationCar()
    {
        car = true;
        ChooseTransportation();
    }

    public void ChooseTransportationBus()
    {
        bus = true;
        ChooseTransportation();
    }

    public void ChooseTransportationMotorcycle()
    {
        motorcycle = true;
        ChooseTransportation();
    }

    public void ChooseGift()
    {
        if (gift0 == true)
        {
            giftScreen1.SetActive(false);
            giftScreen2.SetActive(true);

            giftMoney = 0.00;
            //currentMoney = currentMoney + giftMoney;
        }
        else if (gift500 == true)
        {
            giftScreen1.SetActive(false);
            giftScreen3.SetActive(true);

            giftMoney = 500.00;
            //currentMoney = currentMoney + giftMoney;
        }
        else if (gift1000 == true)
        {
            giftScreen1.SetActive(false);
            giftScreen4.SetActive(true);

            giftMoney = 1000.00;
            //currentMoney = currentMoney + giftMoney;
        }
    }

    public void ChooseGift0Dollars()
    {
        gift0 = true;
        ChooseGift();
    }

    public void ChooseGift500Dollars()
    {
        gift500 = true;
        ChooseGift();
    }

    public void ChooseGift1000Dollars()
    {
        gift1000 = true;
        ChooseGift();
    }

    public void ToEducationScreen()
    {
        welcomeScreen.SetActive(false);
        educationScreen1.SetActive(true);
    }
    
    public void ToJobScreen()
    {
        educationScreen2.SetActive(false);
        educationScreen3.SetActive(false);
        educationScreen4.SetActive(false);
        jobScreen1.SetActive(true);
    }

    public void ToHousingScreen()
    {
        jobScreen2.SetActive(false);
        jobScreen3.SetActive(false);
        jobScreen4.SetActive(false);
        jobScreen5.SetActive(false);
        jobScreen6.SetActive(false);
        housingScreen1.SetActive(true);
    }

    public void ToTransportationScreen()
    {
        housingScreen2.SetActive(false);
        housingScreen3.SetActive(false);
        housingScreen4.SetActive(false);
        transportationScreen1.SetActive(true);
    }
    
    public void ToGiftScreen()
    {
        transportationScreen2.SetActive(false);
        transportationScreen3.SetActive(false);
        transportationScreen4.SetActive(false);
        giftScreen1.SetActive(true);
    }

    public void ToSummaryScreen()
    {
        giftScreen2.SetActive(false);
        giftScreen3.SetActive(false);
        giftScreen4.SetActive(false);
        summaryScreen.SetActive(true);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Month1()
    {
        //SceneManager.LoadScene(2);
    }
}

