using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerMonth01 : MonoBehaviour
{
    public GameObject month01Screen;
    public GameObject educationScreen1;
    public GameObject educationScreen2;
    public GameObject educationScreen3;
    public GameObject jobScreen1;
    public GameObject jobScreen2;
    public GameObject jobScreen3;
    public GameObject jobScreen4;
    public GameObject jobScreen5;
    public GameObject housingScreen1;
    public GameObject housingScreen2;
    public GameObject housingScreen3;
    public GameObject transportationScreen1;
    public GameObject transportationScreen2;
    public GameObject transportationScreen3;
    public GameObject summaryScreen;
    public GameObject activity1RentScreen;
    public GameObject activity2TravelScreen;
    public GameObject activity3GroceryScreen;
    public GameObject event1Screen;
    public GameObject event2Screen;
    public GameObject gameCompleteScreen;
    public GameObject paydayScreen;

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
    public GameObject summaryButton;
    public GameObject activity1RentButton;
    public GameObject activity2TravelButton;
    public GameObject activity3GroceryButton;
    public GameObject activity1PayRentButton;
    public GameObject activity1PayTravelButton;
    public GameObject activity3PayGrocery1Button;
    public GameObject activity3PayGrocery2Button;
    public GameObject activity3PayGrocery3Button;
    public GameObject event2Button1;
    public GameObject event2Button2;
    public GameObject event2Button3;
    public GameObject paydayButton;
    public GameObject startMonthButton;

    public bool noDegree;
    public bool hsDiploma;
    public bool bachelorsDegree;
    public bool fryCook;
    public bool waiter;
    public bool teacher;
    public bool callCenterAgent;
    public bool programmer;
    public bool crappyApartment;
    public bool basicApartment;
    public bool luxuryApartment;
    public bool car;
    public bool motorcycle;
    public bool bus;
    
    public bool noDegree1;
    public bool hsDiploma1;
    public bool bachelorsDegree1;
    public bool fryCook1;
    public bool waiter1;
    public bool teacher1;
    public bool callCenterAgent1;
    public bool programmer1;
    public bool crappyApartment1;
    public bool basicApartment1;
    public bool luxuryApartment1;
    public bool car1;
    public bool motorcycle1;
    public bool bus1;
    public bool gameOver;
    
    //public string educationSelected;
    public string jobSelected;
    public string housingSelected;
    public string transportationSelected;

    //public string educationSelected1;
    public string jobSelected1;
    public string housingSelected1;
    public string transportationSelected1;

    public Text updatingMoneyText;
    public Text rentPaidText;
    public Text travelPaidText;
    public Text foodPaidText;
    public Text eventPaidText;

    public Text summaryInitialMoneyText;
    public Text summaryJobText;
    public Text summaryJobPayText;
    public Text summaryJobTaxPaidText;
    public Text summaryJobPayReceivedText;
    public Text summaryHousingText;
    public Text summaryHousingRentPaidText;
    public Text summaryTransportationText;
    public Text summaryTransportationCostPaidText;
    public Text summaryGroceryCostPaidText;
    public Text summaryEvent2PaidText;
    public Text summaryCurrentMoneyText;
    public Text gameCompleteText;

    public double currentMoney;
    public double monthlySalary;
    public double rent;
    public double gas;
    public double transportationCost;
    
    public double startingMonthMoney1;
    public double currentMoney1;
    public double monthlySalary1;
    private double payReceived1;
    public double rent1;
    public double gas1;
    public double transportationCost1;
    private double event2Cost = 0.00;
    private double groceryCost1 = 0.00;

    private double tax1 = 0.15;
    private double taxPaid1 = 0.00;
    private int activity1 = 3;

    public GameObject month01Controller;

    public int educationNow;
    public int jobNow;
    public int houseNow;
    public int travelNow;

    public int educationNow1;
    public int jobNow1;
    public int houseNow1;
    public int travelNow1;

    // Start is called before the first frame update
    void Start()
    {
        
        // VariableConversion();

        // DisplayEducation();
        // DisplayJob();
        // DisplayHousing();
        // DisplayTransportation();

        currentMoney1 = startingMonthMoney1;
    }

    // Update is called once per frame
    void Update()
    {
        VariableConversion();

        DisplayEducation();
        DisplayJob();
        DisplayHousing();
        DisplayTransportation();
        
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (activity1 == 0)
        {
            summaryButton.SetActive(true);
        }
        else if (activity1 == 1)
        {
            Event2a();
        }
        else if (activity1 == 2)
        {
            Event1a();
        }

        updatingMoneyText.text = "Current Money: $" + currentMoney1;
        rentPaidText.text = "Rent Paid: $" + rent1;
        travelPaidText.text = "Travel Paid: $" + transportationCost1;
        foodPaidText.text = "Food Paid: $" + groceryCost1;
        eventPaidText.text = "Unexpected Paid: $" + event2Cost;


        summaryInitialMoneyText.text = "Starting Money: $" + startingMonthMoney1;
        //summaryEducationText.text = "Education Status: " + educationSelected;
        summaryJobText.text = "Employment Status: " + jobSelected1;
        summaryJobPayText.text = " - Gross Salary Earned: $" + monthlySalary1;
        summaryJobTaxPaidText.text = " - Tax Paid: $" + taxPaid1;
        summaryJobPayReceivedText.text = " - Net Salary Received: $" + payReceived1;
        summaryHousingText.text = "Housing Status: " + housingSelected1;
        summaryHousingRentPaidText.text = " - Rent Paid: $" + rent1;
        summaryTransportationText.text = "Transportation Status: " + transportationSelected1;
        summaryTransportationCostPaidText.text = " - Travel Cost Paid: $" + transportationCost1;
        summaryGroceryCostPaidText.text = "Grocery/Food Paid: $" + groceryCost1;
        summaryEvent2PaidText.text = "Unexpected Expense Paid: $" + event2Cost;
        summaryCurrentMoneyText.text = "Current Money: $" + currentMoney1;
    }

    public void VariableConversion()
    {
        // GameObject introController = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro = introController.GetComponent<GameControllerIntro>();
        // noDegree = gameControllerIntro.noDegree;

        // noDegree1 = noDegree;

        // GameObject introController01 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro01 = introController01.GetComponent<GameControllerIntro>();
        // hsDiploma = gameControllerIntro01.hsDiploma;

        // hsDiploma1 = hsDiploma;

        // GameObject introController02 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro02 = introController02.GetComponent<GameControllerIntro>();
        // bachelorsDegree1 = gameControllerIntro02.bachelorsDegree;

        // bachelorsDegree1 = bachelorsDegree;

        // GameObject introController03 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro03 = introController03.GetComponent<GameControllerIntro>();
        // waiter = gameControllerIntro03.waiter;

        // waiter1 = waiter;

        // GameObject introController04 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro04 = introController04.GetComponent<GameControllerIntro>();
        // fryCook = gameControllerIntro04.fryCook;

        // fryCook1 = fryCook;

        // GameObject introController05 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro05 = introController05.GetComponent<GameControllerIntro>();
        // callCenterAgent = gameControllerIntro05.callCenterAgent;

        // callCenterAgent1 = callCenterAgent;

        // GameObject introController06 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro06 = introController06.GetComponent<GameControllerIntro>();
        // teacher = gameControllerIntro06.teacher;

        // teacher1 = teacher;

        // GameObject introController07 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro07 = introController07.GetComponent<GameControllerIntro>();
        // programmer = gameControllerIntro07.programmer;

        // programmer1 = programmer;

        // GameObject introController08 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro08 = introController08.GetComponent<GameControllerIntro>();
        // crappyApartment = gameControllerIntro08.crappyApartment;

        // crappyApartment1 = crappyApartment;

        // GameObject introController09 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro09 = introController09.GetComponent<GameControllerIntro>();
        // basicApartment = gameControllerIntro09.basicApartment;

        // basicApartment1 = basicApartment;

        // GameObject introController10 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro10 = introController10.GetComponent<GameControllerIntro>();
        // luxuryApartment = gameControllerIntro10.luxuryApartment;

        // luxuryApartment1 = luxuryApartment;

        // GameObject introController11 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro11 = introController11.GetComponent<GameControllerIntro>();
        // car = gameControllerIntro11.car;

        // car1 = car;

        // GameObject introController12 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro12 = introController12.GetComponent<GameControllerIntro>();
        // motorcycle = gameControllerIntro12.motorcycle;

        // motorcycle1 = motorcycle;

        // GameObject introController13 = GameObject.Find("IntroController");
        // GameControllerIntro gameControllerIntro13 = introController13.GetComponent<GameControllerIntro>();
        // bus = gameControllerIntro13.bus;

        // bus1 = bus;


        GameObject introController14 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro14 = introController14.GetComponent<GameControllerIntro>();
        currentMoney = gameControllerIntro14.currentMoney;

        startingMonthMoney1 = currentMoney;

        GameObject introController15 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro15 = introController15.GetComponent<GameControllerIntro>();
        monthlySalary = gameControllerIntro15.monthlySalary;

        monthlySalary1 = monthlySalary;

        GameObject introController16 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro16 = introController16.GetComponent<GameControllerIntro>();
        rent = gameControllerIntro16.rent;

        rent1 = rent;

        GameObject introController17 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro17 = introController17.GetComponent<GameControllerIntro>();
        gas = gameControllerIntro17.gas;

        gas1 = gas;

        GameObject introController18 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro18 = introController18.GetComponent<GameControllerIntro>();
        transportationCost = gameControllerIntro18.transportationCost;

        transportationCost1 = transportationCost;

        GameObject introController19 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro19 = introController19.GetComponent<GameControllerIntro>();
        jobSelected = gameControllerIntro19.jobSelected;

        jobSelected1 = jobSelected;

        GameObject introController20 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro20 = introController20.GetComponent<GameControllerIntro>();
        housingSelected = gameControllerIntro20.housingSelected;

        housingSelected1 = housingSelected;

        GameObject introController21 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro21 = introController21.GetComponent<GameControllerIntro>();
        transportationSelected = gameControllerIntro21.transportationSelected;

        transportationSelected1 = transportationSelected;

        GameObject introController22 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro22 = introController22.GetComponent<GameControllerIntro>();
        educationNow = gameControllerIntro22.educationNow;

        educationNow1 = educationNow;

        GameObject introController23 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro23 = introController23.GetComponent<GameControllerIntro>();
        jobNow = gameControllerIntro23.jobNow;

        jobNow1 = jobNow;

        GameObject introController24 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro24 = introController24.GetComponent<GameControllerIntro>();
        houseNow = gameControllerIntro24.houseNow;

        houseNow1 = houseNow;

        GameObject introController25 = GameObject.Find("IntroController");
        GameControllerIntro gameControllerIntro25 = introController25.GetComponent<GameControllerIntro>();
        travelNow = gameControllerIntro25.travelNow;

        travelNow1 = travelNow;
    }

    public void DisplayEducation()
    {
        // if (noDegree1 == true)
        // {
        //     noDegreeButton.SetActive(true);
        //     hsDiplomaButton.SetActive(false);
        //     bachelorsDegreeButton.SetActive(false);
        // }
        // else if (hsDiploma1 == true)
        // {
        //     noDegreeButton.SetActive(false);
        //     hsDiplomaButton.SetActive(true);
        //     bachelorsDegreeButton.SetActive(false);
        // }
        // else if (bachelorsDegree1 == true)
        // {
        //     noDegreeButton.SetActive(false);
        //     hsDiplomaButton.SetActive(false);
        //     bachelorsDegreeButton.SetActive(true);
        // }

        if (educationNow1 == 1)
        {
            noDegreeButton.SetActive(true);
            hsDiplomaButton.SetActive(false);
            bachelorsDegreeButton.SetActive(false);
        }
        else if (educationNow1 == 2)
        {
            noDegreeButton.SetActive(false);
            hsDiplomaButton.SetActive(true);
            bachelorsDegreeButton.SetActive(false);
        }
        else if (educationNow1 == 3)
        {
            noDegreeButton.SetActive(false);
            hsDiplomaButton.SetActive(false);
            bachelorsDegreeButton.SetActive(true);
        }
    }

    public void NoDegreeInfo()
    {
        
        educationScreen1.SetActive(true);
    }

    public void HSDiplomaInfo()
    {

        educationScreen2.SetActive(true);
    }

    public void BachelorsDegreeInfo()
    {
        
        educationScreen3.SetActive(true);
    }

    public void DisplayJob()
    {
        // if (waiter1 == true)
        // {
        //     waiterButton.SetActive(true);
        //     fryCookButton.SetActive(false);
        //     callCenterAgentButton.SetActive(false);
        //     teacherButton.SetActive(false);
        //     programmerButton.SetActive(false);
        // }
        // else if (fryCook1 == true)
        // {
        //     waiterButton.SetActive(false);
        //     fryCookButton.SetActive(true);
        //     callCenterAgentButton.SetActive(false);
        //     teacherButton.SetActive(false);
        //     programmerButton.SetActive(false);
        // }
        // else if (callCenterAgent1 == true)
        // {
        //     waiterButton.SetActive(false);
        //     fryCookButton.SetActive(false);
        //     callCenterAgentButton.SetActive(true);
        //     teacherButton.SetActive(false);
        //     programmerButton.SetActive(false);
        // }
        // else if (teacher1 == true)
        // {
        //     waiterButton.SetActive(false);
        //     fryCookButton.SetActive(false);
        //     callCenterAgentButton.SetActive(false);
        //     teacherButton.SetActive(true);
        //     programmerButton.SetActive(false);
        // }
        // else if (programmer1 == true)
        // {
        //     waiterButton.SetActive(false);
        //     fryCookButton.SetActive(false);
        //     callCenterAgentButton.SetActive(false);
        //     teacherButton.SetActive(false);
        //     programmerButton.SetActive(true);
        // }

        if (jobNow1 == 1)
        {
            waiterButton.SetActive(true);
            fryCookButton.SetActive(false);
            callCenterAgentButton.SetActive(false);
            teacherButton.SetActive(false);
            programmerButton.SetActive(false);
        }
        else if (jobNow1 == 2)
        {
            waiterButton.SetActive(false);
            fryCookButton.SetActive(true);
            callCenterAgentButton.SetActive(false);
            teacherButton.SetActive(false);
            programmerButton.SetActive(false);
        }
        else if (jobNow1 == 3)
        {
            waiterButton.SetActive(false);
            fryCookButton.SetActive(false);
            callCenterAgentButton.SetActive(true);
            teacherButton.SetActive(false);
            programmerButton.SetActive(false);
        }
        else if (jobNow1 == 4)
        {
            waiterButton.SetActive(false);
            fryCookButton.SetActive(false);
            callCenterAgentButton.SetActive(false);
            teacherButton.SetActive(true);
            programmerButton.SetActive(false);
        }
        else if (jobNow1 == 5)
        {
            waiterButton.SetActive(false);
            fryCookButton.SetActive(false);
            callCenterAgentButton.SetActive(false);
            teacherButton.SetActive(false);
            programmerButton.SetActive(true);
        }
    }

    public void WaiterInfo()
    {

        jobScreen1.SetActive(true);
    }

    public void FryCookInfo()
    {

        jobScreen2.SetActive(true);
    }

    public void CallCenterAgentInfo()
    {

        jobScreen3.SetActive(true);
    }

    public void TeacherInfo()
    {

        jobScreen4.SetActive(true);
    }

    public void ProgrammerInfo()
    {
        
        jobScreen5.SetActive(true);
    }

    public void DisplayHousing()
    {
        // if (crappyApartment1 == true)
        // {
        //     crappyApartmentButton.SetActive(true);
        //     basicApartmentButton.SetActive(false);
        //     luxuryApartmentButton.SetActive(false);
        // }
        // else if (basicApartment1 == true)
        // {
        //     crappyApartmentButton.SetActive(false);
        //     basicApartmentButton.SetActive(true);
        //     luxuryApartmentButton.SetActive(false);
        // }
        // else if (luxuryApartment1 == true)
        // {
        //     crappyApartmentButton.SetActive(false);
        //     basicApartmentButton.SetActive(false);
        //     luxuryApartmentButton.SetActive(true);
        // }

        if (houseNow1 == 1)
        {
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(false);
            luxuryApartmentButton.SetActive(false);
        }
        else if (houseNow1 == 2)
        {
            crappyApartmentButton.SetActive(false);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
        }
        else if (houseNow1 == 3)
        {
            crappyApartmentButton.SetActive(false);
            basicApartmentButton.SetActive(false);
            luxuryApartmentButton.SetActive(true);
        }
    }

    public void CrappyApartmentInfo()
    {

        housingScreen1.SetActive(true);
    }

    public void BasicApartmentInfo()
    {

        housingScreen2.SetActive(true);
    }

    public void LuxuryApartmentInfo()
    {

        housingScreen3.SetActive(true);
    }

    public void DisplayTransportation()
    {
        // if (car1 == true)
        // {
        //     carButton.SetActive(true);
        //     motorcycleButton.SetActive(false);
        //     busButton.SetActive(false);
        // }
        // else if (motorcycle1 == true)
        // {
        //     carButton.SetActive(false);
        //     motorcycleButton.SetActive(true);
        //     busButton.SetActive(false);
        // }
        // else if (bus1 == true)
        // {
        //     carButton.SetActive(false);
        //     motorcycleButton.SetActive(false);
        //     busButton.SetActive(true);
        // }

        if (travelNow1 == 1)
        {
            carButton.SetActive(true);
            motorcycleButton.SetActive(false);
            busButton.SetActive(false);
        }
        else if (travelNow1 == 2)
        {
            carButton.SetActive(false);
            motorcycleButton.SetActive(true);
            busButton.SetActive(false);
        }
        else if (travelNow1 == 3)
        {
            carButton.SetActive(false);
            motorcycleButton.SetActive(false);
            busButton.SetActive(true);
        }
    }

    public void CarInfo()
    {

        transportationScreen1.SetActive(true);
    }

    public void MotorcycleInfo()
    {

        transportationScreen2.SetActive(true);
    }

    public void BusInfo()
    {

        transportationScreen3.SetActive(true);
    }

    public void ReturnToMonth01()
    {
    //month01Screen;
    educationScreen1.SetActive(false);
    educationScreen2.SetActive(false);
    educationScreen3.SetActive(false);
    jobScreen1.SetActive(false);
    jobScreen2.SetActive(false);
    jobScreen3.SetActive(false);
    jobScreen4.SetActive(false);
    jobScreen5.SetActive(false);
    housingScreen1.SetActive(false);
    housingScreen2.SetActive(false);
    housingScreen3.SetActive(false);
    transportationScreen1.SetActive(false);
    transportationScreen2.SetActive(false);
    transportationScreen3.SetActive(false);
    summaryScreen.SetActive(false);
    activity1RentScreen.SetActive(false);
    activity2TravelScreen.SetActive(false);
    activity3GroceryScreen.SetActive(false);
    event1Screen.SetActive(false);
    event2Screen.SetActive(false);
    gameCompleteScreen.SetActive(false);
    paydayScreen.SetActive(false);
    }

    public void ActivityRent()
    {

        activity1RentScreen.SetActive(true);
    }

    public void ActivityPayRent()
    {
        currentMoney1 = currentMoney1 - rent1;
        activity1PayRentButton.SetActive(false);
        activity1RentButton.SetActive(false);
        activity1 = activity1 - 1;
    }

    public void ActivityTravel()
    {
        activity2TravelScreen.SetActive(true);
    }

    public void ActivityPayTravel()
    {
        currentMoney1 = currentMoney1 - transportationCost1;
        activity1PayTravelButton.SetActive(false);
        activity2TravelButton.SetActive(false);
        activity1 = activity1 - 1;
    }

    public void ActivityGrocery()
    {
        activity3GroceryScreen.SetActive(true);
    }

    public void ActivityPayGrocery1()
    {
        groceryCost1 = 100.00;
        currentMoney1 = currentMoney1 - groceryCost1;
        activity3PayGrocery1Button.SetActive(false);
        activity3GroceryButton.SetActive(false);
        activity1 = activity1 - 1;
    }

    public void ActivityPayGrocery2()
    {
        groceryCost1 = 200.00;
        currentMoney1 = currentMoney1 - groceryCost1;
        activity3PayGrocery2Button.SetActive(false);
        activity3GroceryButton.SetActive(false);
        activity1 = activity1 - 1;
    }

    public void ActivityPayGrocery3()
    {
        groceryCost1 = 300.00;
        currentMoney1 = currentMoney1 - groceryCost1;
        activity3PayGrocery3Button.SetActive(false);
        activity3GroceryButton.SetActive(false);
        activity1 = activity1 - 1;
    }

    public void StartMonth()
    {
        
        paydayScreen.SetActive(true);

        activity1RentButton.SetActive(true);
        activity2TravelButton.SetActive(true);
        activity3GroceryButton.SetActive(true);
    }

    public void PayDay()
    {
        taxPaid1 = monthlySalary1 * tax1;
        payReceived1 = monthlySalary1 - taxPaid1;
        currentMoney1 = currentMoney1 + payReceived1;
        paydayButton.SetActive(false);
        startMonthButton.SetActive(false);
    }
    
    public void Event1a()
    {
        //yield return new WaitForSeconds(5);
        event1Screen.SetActive(true);
    }
    
    public void Event1b()
    {
        if (car1 == true)
        {
            gas1 = 5.00;
            transportationCost1 = transportationCost1 * (10 / 7);
        }
        else if (motorcycle1 == true)
        {
            gas1 = 5.00;
            transportationCost1 = transportationCost * (10 / 7);
        }
        else if (bus1 == true)
        {
            gas1 = 5.00;
            transportationCost1 = transportationCost1 * (10 / 7);
        }
    }

    public void Event2a()
    {
        //yield return new WaitForSeconds(5);
        event2Screen.SetActive(true);
    }

    public void Event2b()
    {
        event2Cost = 50.00;
        currentMoney1 = currentMoney1 - event2Cost;
        event2Button1.SetActive(false);
        event2Button2.SetActive(false);
        event2Button3.SetActive(false);
    }

    public void Event2c()
    {
        event2Cost = 100.00;
        currentMoney1 = currentMoney1 - event2Cost;
        event2Button1.SetActive(false);
        event2Button2.SetActive(false);
        event2Button3.SetActive(false);
    }

    public void Event2d()
    {
        event2Cost = 150.00;
        currentMoney1 = currentMoney1 - event2Cost;
        event2Button1.SetActive(false);
        event2Button2.SetActive(false);
        event2Button3.SetActive(false);
    }

    public void Month01Summary()
    {
        summaryScreen.SetActive(true);
    }

    public void GameComplete()
    {
        gameOver = true;
        gameCompleteScreen.SetActive(true);
        summaryScreen.SetActive(false);
        summaryButton.SetActive(false);

        if (currentMoney1 >= 100.00)
        {
            gameCompleteText.text = "It looks like you managed to survive this last month. You currently have a balance of $" + currentMoney1 + "! Will you be able to keep up the lifestyle in the future?";
        }
        else if (currentMoney1 >= 0.00 && currentMoney1 < 100.00)
        {
            gameCompleteText.text = "It looks like you struggled a bit this last month, but managed to stay afloat. You currently have a balance of $" + currentMoney1 + "! Do you think you'll be able to keep breaking even if things don't change?";
        }
        else if (currentMoney1 < 0.00)
        {
            gameCompleteText.text = "It looks like you struggled a lot this last month. You currently have a balance of $" + currentMoney1 + "! If things don't change, how will you be able to keep on living?";
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
            Application.Quit();
    }
}
