using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UltimateGameController : MonoBehaviour
{
    // Intro Variables

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
    public GameObject introSummaryScreen;

    public bool noDegree = false;
    public bool hsDiploma = false;
    public bool bachelorsDegree = false;
    public bool fryCook = false;
    public bool waiter = false;
    public bool teacher = false;
    public bool callCenterAgent = false;
    public bool programmer = false;
    public bool crappyApartment = false;
    public bool basicApartment = false;
    public bool luxuryApartment = false;
    public bool car = false;
    public bool motorcycle = false;
    public bool bus = false;
    private bool gift0 = false;
    private bool gift500 =  false;
    private bool gift1000 = false;
    //private bool gameOver = false;

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

    public double initialMoney = 0.00;
    public double currentIntroMoney = 0.00;
    public double giftMoney = 0.00;
    public double monthlySalary;
    public double rent = 0.00;
    public double gas = 3.50;
    public double transportationCost = 0.00;

    public string educationSelected;
    public string jobSelected;
    public string housingSelected;
    public string transportationSelected;


    // Month01 Variables
    public GameObject month01Screen;
    public GameObject m1educationScreen1;
    public GameObject m1educationScreen2;
    public GameObject m1educationScreen3;
    public GameObject m1jobScreen1;
    public GameObject m1jobScreen2;
    public GameObject m1jobScreen3;
    public GameObject m1jobScreen4;
    public GameObject m1jobScreen5;
    public GameObject m1housingScreen1;
    public GameObject m1housingScreen2;
    public GameObject m1housingScreen3;
    public GameObject m1transportationScreen1;
    public GameObject m1transportationScreen2;
    public GameObject m1transportationScreen3;
    public GameObject m1summaryScreen;
    public GameObject m1activity1RentScreen;
    public GameObject m1activity2TravelScreen;
    public GameObject m1activity3GroceryScreen;
    public GameObject m1event1Screen;
    public GameObject m1event2Screen;
    public GameObject m1gameCompleteScreen;
    public GameObject m1paydayScreen;

    public GameObject m1noDegreeButton;
    public GameObject m1hsDiplomaButton;
    public GameObject m1bachelorsDegreeButton;
    public GameObject m1fryCookButton;
    public GameObject m1waiterButton;
    public GameObject m1teacherButton;
    public GameObject m1callCenterAgentButton;
    public GameObject m1programmerButton;
    public GameObject m1crappyApartmentButton;
    public GameObject m1basicApartmentButton;
    public GameObject m1luxuryApartmentButton;
    public GameObject m1carButton;
    public GameObject m1motorcycleButton;
    public GameObject m1busButton;
    public GameObject m1summaryButton;
    public GameObject m1activity1RentButton;
    public GameObject m1activity2TravelButton;
    public GameObject m1activity3GroceryButton;
    public GameObject m1activity1PayRentButton;
    public GameObject m1activity1PayTravelButton;
    public GameObject m1activity3PayGrocery1Button;
    public GameObject m1activity3PayGrocery2Button;
    public GameObject m1activity3PayGrocery3Button;
    public GameObject m1event2Button1;
    public GameObject m1event2Button2;
    public GameObject m1event2Button3;
    public GameObject m1paydayButton;
    public GameObject m1startMonthButton;

    public Text m1updatingMoneyText;
    public Text m1rentPaidText;
    public Text m1travelPaidText;
    public Text m1foodPaidText;
    public Text m1eventPaidText;

    public Text m1summaryInitialMoneyText;
    public Text m1summaryJobText;
    public Text m1summaryJobPayText;
    public Text m1summaryJobTaxPaidText;
    public Text m1summaryJobPayReceivedText;
    public Text m1summaryHousingText;
    public Text m1summaryHousingRentPaidText;
    public Text m1summaryTransportationText;
    public Text m1summaryTransportationCostPaidText;
    public Text m1summaryGroceryCostPaidText;
    public Text m1summaryEvent2PaidText;
    public Text m1summaryCurrentMoneyText;
    public Text m1gameCompleteText;
    
    public double m1startingMonthMoney1;
    public double m1currentMoney1;
    private double m1payReceived1;
    public double m1transportationCost1;
    private double m1event2Cost = 0.00;
    private double m1groceryCost1 = 0.00;

    private double m1tax1 = 0.15;
    private double m1taxPaid1 = 0.00;
    private int m1activity1 = 3;


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

        // Intro
        currentIntroMoney = initialMoney + giftMoney;

        summaryInitialMoneyText.text = "Initial Money: $" + initialMoney;
        summaryEducationText.text = "Education Status: " + educationSelected;
        summaryJobText.text = "Employment Status: " + jobSelected;
        summaryJobPayText.text = " - Monthly Salary: $" + monthlySalary;
        summaryHousingText.text = "Housing Status: " + housingSelected;
        summaryHousingRentText.text = " - Monthly Rent: $" + rent;
        summaryTransportationText.text = "Transportation Status: " + transportationSelected;
        summaryTransportationCostText.text = " - Monthly Travel Cost: $" + transportationCost;
        summaryGiftText.text = "Gift Received: $" + giftMoney;
        summaryCurrentMoneyText.text = "Current Money: $" + currentIntroMoney;

        // Month 01

        m1startingMonthMoney1 = currentIntroMoney;

        if (m1activity1 == 0)
        {
            m1summaryButton.SetActive(true);
        }
        

        m1updatingMoneyText.text = "Current Money: $" + m1currentMoney1;
        m1rentPaidText.text = "Rent Paid: $" + rent;
        m1travelPaidText.text = "Travel Paid: $" + m1transportationCost1;
        m1foodPaidText.text = "Food Paid: $" + m1groceryCost1;
        m1eventPaidText.text = "Unexpected Paid: $" + m1event2Cost;


        m1summaryInitialMoneyText.text = "Starting Money: $" + m1startingMonthMoney1;
        //summaryEducationText.text = "Education Status: " + educationSelected;
        m1summaryJobText.text = "Employment Status: " + jobSelected;
        m1summaryJobPayText.text = " - Gross Salary Earned: $" + monthlySalary;
        m1summaryJobTaxPaidText.text = " - Tax Paid: $" + m1taxPaid1;
        m1summaryJobPayReceivedText.text = " - Net Salary Received: $" + m1payReceived1;
        m1summaryHousingText.text = "Housing Status: " + housingSelected;
        m1summaryHousingRentPaidText.text = " - Rent Paid: $" + rent;
        m1summaryTransportationText.text = "Transportation Status: " + transportationSelected;
        m1summaryTransportationCostPaidText.text = " - Travel Cost Paid: $" + m1transportationCost1;
        m1summaryGroceryCostPaidText.text = "Grocery/Food Paid: $" + m1groceryCost1;
        m1summaryEvent2PaidText.text = "Unexpected Expense Paid: $" + m1event2Cost;
        m1summaryCurrentMoneyText.text = "Current Money: $" + m1currentMoney1;
    }
    
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
        introSummaryScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToMonth01()
    {
        month01Screen.SetActive(true);
        introSummaryScreen.SetActive(false);

        DisplayEducation();
        DisplayJob();
        DisplayHousing();
        DisplayTransportation();

        m1currentMoney1 = m1startingMonthMoney1;
    }

    public void DisplayEducation()
    {
        if (noDegree == true)
        {
            m1noDegreeButton.SetActive(true);
            m1hsDiplomaButton.SetActive(false);
            m1bachelorsDegreeButton.SetActive(false);
        }
        else if (hsDiploma == true)
        {
            m1noDegreeButton.SetActive(false);
            m1hsDiplomaButton.SetActive(true);
            m1bachelorsDegreeButton.SetActive(false);
        }
        else if (bachelorsDegree == true)
        {
            m1noDegreeButton.SetActive(false);
            m1hsDiplomaButton.SetActive(false);
            m1bachelorsDegreeButton.SetActive(true);
        }
    }

    public void NoDegreeInfo()
    {
        
        m1educationScreen1.SetActive(true);
    }

    public void HSDiplomaInfo()
    {

        m1educationScreen2.SetActive(true);
    }

    public void BachelorsDegreeInfo()
    {
        
        m1educationScreen3.SetActive(true);
    }

    public void DisplayJob()
    {
        if (waiter == true)
        {
            m1waiterButton.SetActive(true);
            m1fryCookButton.SetActive(false);
            m1callCenterAgentButton.SetActive(false);
            m1teacherButton.SetActive(false);
            m1programmerButton.SetActive(false);
        }
        else if (fryCook == true)
        {
            m1waiterButton.SetActive(false);
            m1fryCookButton.SetActive(true);
            m1callCenterAgentButton.SetActive(false);
            m1teacherButton.SetActive(false);
            m1programmerButton.SetActive(false);
        }
        else if (callCenterAgent == true)
        {
            m1waiterButton.SetActive(false);
            m1fryCookButton.SetActive(false);
            m1callCenterAgentButton.SetActive(true);
            m1teacherButton.SetActive(false);
            m1programmerButton.SetActive(false);
        }
        else if (teacher == true)
        {
            m1waiterButton.SetActive(false);
            m1fryCookButton.SetActive(false);
            m1callCenterAgentButton.SetActive(false);
            m1teacherButton.SetActive(true);
            m1programmerButton.SetActive(false);
        }
        else if (programmer == true)
        {
            m1waiterButton.SetActive(false);
            m1fryCookButton.SetActive(false);
            m1callCenterAgentButton.SetActive(false);
            m1teacherButton.SetActive(false);
            m1programmerButton.SetActive(true);
        }
    }

    public void WaiterInfo()
    {

        m1jobScreen1.SetActive(true);
    }

    public void FryCookInfo()
    {

        m1jobScreen2.SetActive(true);
    }

    public void CallCenterAgentInfo()
    {

        m1jobScreen3.SetActive(true);
    }

    public void TeacherInfo()
    {

        m1jobScreen4.SetActive(true);
    }

    public void ProgrammerInfo()
    {
        
        m1jobScreen5.SetActive(true);
    }

    public void DisplayHousing()
    {
        if (crappyApartment == true)
        {
            m1crappyApartmentButton.SetActive(true);
            m1basicApartmentButton.SetActive(false);
            m1luxuryApartmentButton.SetActive(false);
        }
        else if (basicApartment == true)
        {
            m1crappyApartmentButton.SetActive(false);
            m1basicApartmentButton.SetActive(true);
            m1luxuryApartmentButton.SetActive(false);
        }
        else if (luxuryApartment == true)
        {
            m1crappyApartmentButton.SetActive(false);
            m1basicApartmentButton.SetActive(false);
            m1luxuryApartmentButton.SetActive(true);
        }
    }

    public void CrappyApartmentInfo()
    {

        m1housingScreen1.SetActive(true);
    }

    public void BasicApartmentInfo()
    {

        m1housingScreen2.SetActive(true);
    }

    public void LuxuryApartmentInfo()
    {

        m1housingScreen3.SetActive(true);
    }

    public void DisplayTransportation()
    {
        if (car == true)
        {
            m1carButton.SetActive(true);
            m1motorcycleButton.SetActive(false);
            m1busButton.SetActive(false);
        }
        else if (motorcycle == true)
        {
            m1carButton.SetActive(false);
            m1motorcycleButton.SetActive(true);
            m1busButton.SetActive(false);
        }
        else if (bus == true)
        {
            m1carButton.SetActive(false);
            m1motorcycleButton.SetActive(false);
            m1busButton.SetActive(true);
        }
    }

    public void CarInfo()
    {

        m1transportationScreen1.SetActive(true);
    }

    public void MotorcycleInfo()
    {

        m1transportationScreen2.SetActive(true);
    }

    public void BusInfo()
    {

        m1transportationScreen3.SetActive(true);
    }

    public void ReturnToMonth01()
    {
        m1educationScreen1.SetActive(false);
        m1educationScreen2.SetActive(false);
        m1educationScreen3.SetActive(false);
        m1jobScreen1.SetActive(false);
        m1jobScreen2.SetActive(false);
        m1jobScreen3.SetActive(false);
        m1jobScreen4.SetActive(false);
        m1jobScreen5.SetActive(false);
        m1housingScreen1.SetActive(false);
        m1housingScreen2.SetActive(false);
        m1housingScreen3.SetActive(false);
        m1transportationScreen1.SetActive(false);
        m1transportationScreen2.SetActive(false);
        m1transportationScreen3.SetActive(false);
        m1summaryScreen.SetActive(false);
        m1activity1RentScreen.SetActive(false);
        m1activity2TravelScreen.SetActive(false);
        m1activity3GroceryScreen.SetActive(false);
        m1event1Screen.SetActive(false);
        m1event2Screen.SetActive(false);
        m1gameCompleteScreen.SetActive(false);
        m1paydayScreen.SetActive(false);
    }

    public void ActivityRent()
    {

        m1activity1RentScreen.SetActive(true);
    }

    public void ActivityPayRent()
    {
        m1currentMoney1 = m1currentMoney1 - rent;
        m1activity1PayRentButton.SetActive(false);
        m1activity1RentButton.SetActive(false);
        m1activity1 = m1activity1 - 1;
    }

    public void ActivityTravel()
    {
        m1activity2TravelScreen.SetActive(true);
    }

    public void ActivityPayTravel()
    {
        m1currentMoney1 = m1currentMoney1 - m1transportationCost1;
        m1activity1PayTravelButton.SetActive(false);
        m1activity2TravelButton.SetActive(false);
        m1activity1 = m1activity1 - 1;
    }

    public void ActivityGrocery()
    {
        m1activity3GroceryScreen.SetActive(true);
    }

    public void ActivityPayGrocery1()
    {
        m1groceryCost1 = 100.00;
        m1currentMoney1 = m1currentMoney1 - m1groceryCost1;
        m1activity3PayGrocery1Button.SetActive(false);
        m1activity3GroceryButton.SetActive(false);
        m1activity1 = m1activity1 - 1;
    }

    public void ActivityPayGrocery2()
    {
        m1groceryCost1 = 200.00;
        m1currentMoney1 = m1currentMoney1 - m1groceryCost1;
        m1activity3PayGrocery2Button.SetActive(false);
        m1activity3GroceryButton.SetActive(false);
        m1activity1 = m1activity1 - 1;
    }

    public void ActivityPayGrocery3()
    {
        m1groceryCost1 = 300.00;
        m1currentMoney1 = m1currentMoney1 - m1groceryCost1;
        m1activity3PayGrocery3Button.SetActive(false);
        m1activity3GroceryButton.SetActive(false);
        m1activity1 = m1activity1 - 1;
    }

    public void StartMonth()
    {
        
        m1paydayScreen.SetActive(true);
        m1activity1RentButton.SetActive(true);
        m1activity2TravelButton.SetActive(true);
        m1activity3GroceryButton.SetActive(true);
    }

    public void PayDay()
    {
        m1taxPaid1 = monthlySalary * m1tax1;
        m1payReceived1 = monthlySalary - m1taxPaid1;
        m1currentMoney1 = m1currentMoney1 + m1payReceived1;
        m1paydayButton.SetActive(false);
        m1startMonthButton.SetActive(false);
    }
    
    public void Event1a()
    {
        m1event1Screen.SetActive(true);
    }
    
    public void Event1b()
    {
        if (car == true)
        {
            gas = 5.00;
            m1transportationCost1 = transportationCost * (10 / 7);
            
        }
        else if (motorcycle == true)
        {
            gas = 5.00;
            m1transportationCost1 = transportationCost * (10 / 7);
        }
        else if (bus == true)
        {
            gas = 5.00;
            m1transportationCost1 = transportationCost * (10 / 7);
        }
    }

    public void Event2a()
    {
        m1event2Screen.SetActive(true);
    }

    public void Event2b()
    {
        m1event2Cost = 50.00;
        m1currentMoney1 = m1currentMoney1 - m1event2Cost;
        m1event2Button1.SetActive(false);
        m1event2Button2.SetActive(false);
        m1event2Button3.SetActive(false);
    }

    public void Event2c()
    {
        m1event2Cost = 100.00;
        m1currentMoney1 = m1currentMoney1 - m1event2Cost;
        m1event2Button1.SetActive(false);
        m1event2Button2.SetActive(false);
        m1event2Button3.SetActive(false);
    }

    public void Event2d()
    {
        m1event2Cost = 150.00;
        m1currentMoney1 = m1currentMoney1 - m1event2Cost;
        m1event2Button1.SetActive(false);
        m1event2Button2.SetActive(false);
        m1event2Button3.SetActive(false);
    }

    public void Month01Summary()
    {
        m1summaryScreen.SetActive(true);
    }

    public void GameComplete()
    {
        //gameOver = true;
        m1gameCompleteScreen.SetActive(true);
        m1summaryScreen.SetActive(false);
        m1summaryButton.SetActive(false);

        if (m1currentMoney1 >= 100.00)
        {
            m1gameCompleteText.text = "It looks like you managed to survive this last month. You currently have a balance of $" + m1currentMoney1 + "! Will you be able to keep up the lifestyle in the future?";
        }
        else if (m1currentMoney1 >= 0.00 && m1currentMoney1 < 100.00)
        {
            m1gameCompleteText.text = "It looks like you struggled a bit this last month, but managed to stay afloat. You currently have a balance of $" + m1currentMoney1 + "! Do you think you'll be able to keep breaking even if things don't change?";
        }
        else if (m1currentMoney1 < 0.00)
        {
            m1gameCompleteText.text = "It looks like you struggled a lot this last month. You currently have a balance of $" + m1currentMoney1 + "! If things don't change, how will you be able to keep on living?";
        }
    }
}
