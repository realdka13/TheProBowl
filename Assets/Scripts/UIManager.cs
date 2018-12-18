using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //Managers
    public GameObject bowlManager;

    //Panels
    public GameObject startPanel;
    public GameObject initialsPanel;
    public GameObject scorePanel;
    public GameObject debugPanel;

    //Text
    public Text playerCountText;
    public Text initialsPlayerText;
    public Text firstCharText;
    public Text secondCharText;
    public Text thirdCharText;
    public Text velocityCounter;

    //Bumper Toggle
    public Toggle bumpersToggle;

    //Other Variables
    public Button initialAcceptButton;
    public Button ballStuckButton;
    private int playerCount = 1;
    private int currentPlayer = 1;
    private float maxVel = 0;

    //Bumper Bools
    bool playerOneBumper;
    bool playerTwoBumper;
    bool playerThreeBumper;
    bool playerFourBumper;
    bool playerFiveBumper;
    bool playerSixBumper;

    //Characters
    private string playerOneInitials;
    private string playerTwoInitials;
    private string playerThreeInitials;
    private string playerFourInitials;
    private string playerFiveInitials;
    private string playerSixInitials;
    private string firstChar = "A";
    private string secondChar = "A";
    private string thirdChar = "A";
    private bool firstCharChosen = false;
    private bool secondCharChosen = false;
    private bool thirdCharChosen = false;

    // Start is called before the first frame update
    void Start()
    {
        //On game start, close all panels except the start panel
        startPanel.SetActive(true);
        initialsPanel.SetActive(false);
        scorePanel.SetActive(false);
        debugPanel.SetActive(false);

        //Initialize Text
        playerCountText.text = playerCount.ToString();
        initialsPlayerText.text = currentPlayer.ToString();
    }

    private void Update()
    {
        if (firstCharChosen == true && secondCharChosen == true && thirdCharChosen == true)
        {
            initialAcceptButton.enabled = true;
        }
        else
        {
            initialAcceptButton.enabled = false;
        }

        //Update Max Velocity
        float ballVel = bowlManager.GetComponent<BowlManager>().GetBallVelocity();
        if (ballVel > maxVel)
        {
            maxVel = ballVel;
            velocityCounter.text = maxVel.ToString("F2");
        }

    }

    public void ResetMaxVel()
    {
        maxVel = 0;
    }

    public void BallStuck()
    {
        bowlManager.GetComponent<BowlManager>().BallOutOfBounds();
    }

    public void DebugReset()
    {
        bowlManager.GetComponent<BowlManager>().ResetPins();
    }

    public void DebugTidy()
    {
        bowlManager.GetComponent<BowlManager>().TidyPins();
    }

    public void StartGame()
    {
        //Adjust Panels
        startPanel.SetActive(false);
        initialsPanel.SetActive(true);
        scorePanel.SetActive(false);
        debugPanel.SetActive(false);
    }

    public int GetPlayerCount()
    {
        return playerCount;
    }

    public void RightArrow()
    {
        if (playerCount < 6)
        {
            playerCount++;
        }
        playerCountText.text = playerCount.ToString();
    }

    public void LeftArrow()
    {
        if (playerCount > 1)
        {
            playerCount--;
        }
        playerCountText.text = playerCount.ToString();
    }

    public void InitialsBackButton()
    {
        //Reset Data
        firstCharText.text = "_";
        secondCharText.text = "_";
        thirdCharText.text = "_";
        firstChar = "A";
        secondChar = "B";
        thirdChar = "C";
        firstCharChosen = false;
        secondCharChosen = false;
        thirdCharChosen = false;

        startPanel.SetActive(true);
        initialsPanel.SetActive(false);
        scorePanel.SetActive(false);
        debugPanel.SetActive(false);
    }

    public void OpenDebug()
    {
        startPanel.SetActive(false);
        initialsPanel.SetActive(false);
        scorePanel.SetActive(false);
        debugPanel.SetActive(true);
    }

    public void InitialsAccept()
    {
        //Data Values
        if (currentPlayer == 1 && currentPlayer != playerCount)
        {
            playerOneInitials = firstChar + secondChar + thirdChar;
            playerOneBumper = bumpersToggle.isOn;
            currentPlayer++;
            firstCharText.text = "_";
            secondCharText.text = "_";
            thirdCharText.text = "_";
            firstChar = "A";
            secondChar = "B";
            thirdChar = "C";
            firstCharChosen = false;
            secondCharChosen = false;
            thirdCharChosen = false;
            bumpersToggle.isOn = false;
            initialsPlayerText.text = currentPlayer.ToString();
        }
        else if (currentPlayer == 2 && currentPlayer < playerCount)
        {
            playerTwoInitials = firstChar + secondChar + thirdChar;
            playerTwoBumper = bumpersToggle.isOn;
            currentPlayer++;
            firstCharText.text = "_";
            secondCharText.text = "_";
            thirdCharText.text = "_";
            firstChar = "A";
            secondChar = "B";
            thirdChar = "C";
            firstCharChosen = false;
            secondCharChosen = false;
            thirdCharChosen = false;
            bumpersToggle.isOn = false;
            initialsPlayerText.text = currentPlayer.ToString();
        }
        else if (currentPlayer == 3 && currentPlayer < playerCount)
        {
            playerThreeInitials = firstChar + secondChar + thirdChar;
            playerThreeBumper = bumpersToggle.isOn;
            currentPlayer++;
            firstCharText.text = "_";
            secondCharText.text = "_";
            thirdCharText.text = "_";
            firstChar = "A";
            secondChar = "B";
            thirdChar = "C";
            firstCharChosen = false;
            secondCharChosen = false;
            thirdCharChosen = false;
            bumpersToggle.isOn = false;
            initialsPlayerText.text = currentPlayer.ToString();
        }
        else if (currentPlayer == 4 && currentPlayer < playerCount)
        {
            playerFourInitials = firstChar + secondChar + thirdChar;
            playerFourBumper = bumpersToggle.isOn;
            currentPlayer++;
            firstCharText.text = "_";
            secondCharText.text = "_";
            thirdCharText.text = "_";
            firstChar = "A";
            secondChar = "B";
            thirdChar = "C";
            firstCharChosen = false;
            secondCharChosen = false;
            thirdCharChosen = false;
            bumpersToggle.isOn = false;
            initialsPlayerText.text = currentPlayer.ToString();
        }
        else if (currentPlayer == 5 && currentPlayer < playerCount)
        {
            playerFiveInitials = firstChar + secondChar + thirdChar;
            playerFiveBumper = bumpersToggle.isOn;
            currentPlayer++;
            firstCharText.text = "_";
            secondCharText.text = "_";
            thirdCharText.text = "_";
            firstChar = "A";
            secondChar = "B";
            thirdChar = "C";
            firstCharChosen = false;
            secondCharChosen = false;
            thirdCharChosen = false;
            bumpersToggle.isOn = false;
            initialsPlayerText.text = currentPlayer.ToString();
        }

        else if (currentPlayer >= playerCount)
        {
            playerSixInitials = firstChar + secondChar + thirdChar;
            playerSixBumper = bumpersToggle.isOn;
            firstCharText.text = "_";
            secondCharText.text = "_";
            thirdCharText.text = "_";
            firstChar = "A";
            secondChar = "B";
            thirdChar = "C";
            firstCharChosen = false;
            secondCharChosen = false;
            thirdCharChosen = false;
            bumpersToggle.isOn = false;
            //Set Panels
            startPanel.SetActive(false);
            initialsPanel.SetActive(false);
            scorePanel.SetActive(true);
            debugPanel.SetActive(false);

            //Spawn Ball
            bowlManager.GetComponent<BowlManager>().StartGame();
        }
    }

    public void AButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "A";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "A";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "A";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void BButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "B";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "B";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "B";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void CButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "C";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "C";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "C";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void DButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "D";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "D";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "D";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void EButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "E";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "E";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "E";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void FButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "F";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "F";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "F";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void GButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "G";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "G";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "G";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void HButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "H";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "H";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "H";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void IButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "I";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "I";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "I";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void JButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "J";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "J";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "J";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void KButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "K";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "K";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "K";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void LButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "L";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "L";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "L";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void MButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "M";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "M";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "M";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void NButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "N";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "N";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "N";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void OButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "O";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "O";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "O";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void PButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "P";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "P";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "P";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void QButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "Q";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "Q";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "Q";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void RButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "R";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "R";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "R";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void SButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "S";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "S";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "S";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void TButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "T";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "T";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "T";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void UButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "U";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "U";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "U";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void VButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "V";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "V";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "V";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void WButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "W";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "W";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "W";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void XButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "X";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "X";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "X";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void YButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "Y";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "Y";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "Y";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void ZButton()
    {
        if (firstCharChosen == false)
        {
            firstChar = "Z";
            firstCharText.text = firstChar;
            firstCharChosen = true;
        }
        else if (secondCharChosen == false)
        {
            secondChar = "Z";
            secondCharText.text = secondChar;
            secondCharChosen = true;
        }
        else if (thirdCharChosen == false)
        {
            thirdChar = "Z";
            thirdCharText.text = thirdChar;
            thirdCharChosen = true;
        }
    }

    public void BackspaceButton()
    {
        if (firstCharChosen == true && secondCharChosen == false)
        {
            firstCharText.text = "_";
            firstCharChosen = false;
        }
        if (secondCharChosen == true && thirdCharChosen == false)
        {
            secondCharText.text = "_";
            secondCharChosen = false;
        }
        if (thirdCharChosen == true)
        {
            thirdCharText.text = "_";
            thirdCharChosen = false;
        }
    }
}