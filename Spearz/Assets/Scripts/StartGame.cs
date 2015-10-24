using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Text;

public class StartGame : MonoBehaviour
{
    int[] problematics = new int[] {
        //F Taster
         282,
         283,
         284,
         285,
         286,
         287,
        288,
        289,
        290,
        291,
        292,
        293,
       // NumPAd
        256,
        278,
        273,
        280,
        300,
        267,
        268,
        269,
        263,
        264,
        265,
        260,
        261,
        262,
        270,
        257,
        258,
        259,
        271,
        266,
        127,
        323,
        324,
        325,
        301,
        304,
        306,
        308,
        313,
        305,
        303,
        276,
        273,
        275,
        274,
        48,
        49,
        51,
        52,
        53,
        54,
        55,
        56,
        57,
        50



     };
  
    public string[] keys = new string[4];
    public int num = 0;
    public Text[] txt = new Text[4];



    void Awake()
    {
        DontDestroyOnLoad(this);

    }

    string GoLow(KeyCode kc)
    {

        foreach (int i in problematics)
        {
            if ((int)kc == i)
            {
                string s = null;
                switch (kc)
                {
                    case KeyCode.Keypad0:
                        s =  "[0]";
                     break;
                    case KeyCode.Keypad1:
                        s ="[1]";
                        break;
                    case KeyCode.Keypad2:
                        s ="[2]";
                        break;
                    case KeyCode.Keypad3:
                        s = "[3]";
                        break;
                    case KeyCode.Keypad4:
                        s = "[4]";
                        break;
                    case KeyCode.Keypad5:
                        s = "[5]";
                        break;
                    case KeyCode.Keypad6:
                        s = "[6]";
                        break;
                    case KeyCode.Keypad7:
                        s = "[7]";
                        break;
                    case KeyCode.Keypad8:
                        s = "[8]";
                        break;
                    case KeyCode.Keypad9:
                        s = "[9]";
                        break;
                    case KeyCode.KeypadPeriod:
                        s = "[.]";
                        break;
                    case KeyCode.KeypadDivide:
                        s = "[/]";
                        break;
                    case KeyCode.KeypadMultiply:
                        s = "[*]";
                        break;
                    case KeyCode.KeypadMinus:
                        s = "[-]";
                        break;
                    case KeyCode.KeypadPlus:
                        s = "[+]";
                        break;
                    case KeyCode.KeypadEnter:
                        s = "[enter]";
                        break;
                    case KeyCode.KeypadEquals:
                        s = "[equals]";
                        break;
                    case KeyCode.Alpha0:
                        s = "0";
                        break;
                    case KeyCode.Alpha1:
                        s = "1";
                        break;
                    case KeyCode.Alpha2:
                        s = "2";
                        break;
                    case KeyCode.Alpha3:
                        s = "3";
                        break;
                    case KeyCode.Alpha4:
                        s = "4";
                        break;
                    case KeyCode.Alpha5:
                        s = "5";
                        break;
                    case KeyCode.Alpha6:
                        s = "6";
                        break;
                    case KeyCode.Alpha7:
                        s = "7";
                        break;
                    case KeyCode.Alpha8:
                        s = "8";
                        break;
                    case KeyCode.Alpha9:
                        s = "9";
                        break;
                    case KeyCode.UpArrow:
                        s = "up";
                        break;
                    case KeyCode.DownArrow:
                        s = "down";
                        break;
                    case KeyCode.RightArrow:
                        s = "right";
                        break;
                    case KeyCode.LeftArrow:
                        s = "left";
                        break;
                    case KeyCode.Insert:
                        break;
                    case KeyCode.Home:
                        break;
                    case KeyCode.End:
                        break;
                    case KeyCode.PageUp:
                        break;
                    case KeyCode.PageDown:
                        break;
                    case KeyCode.F1:
                        s = "f1";
                        break;
                    case KeyCode.F2:
                        s = "f2";
                        break;
                    case KeyCode.F3:
                        s = "f3";
                        break;
                    case KeyCode.F4:
                        s = "f4";
                        break;
                    case KeyCode.F5:
                        s = "f5";
                        break;
                    case KeyCode.F6:
                        s = "f6";
                        break;
                    case KeyCode.F7:
                        s = "f7";
                        break;
                    case KeyCode.F8:
                        s = "f8";
                        break;
                    case KeyCode.F9:
                        s = "f9";
                        break;
                    case KeyCode.F10:
                        s = "f10";
                        break;
                    case KeyCode.F11:
                        s = "f11";
                        break;
                    case KeyCode.F12:
                        s = "f12";
                        break;
                    case KeyCode.Numlock:
                        break;
                    case KeyCode.CapsLock:
                        break;
                    case KeyCode.ScrollLock:
                        break;
                    case KeyCode.RightShift:
                        s = "right shift";
                        break;
                    case KeyCode.LeftShift:
                        s = "left shift";
                        break;
                    case KeyCode.RightControl:
                        s = "right ctrl";
                        break;
                    case KeyCode.LeftControl:
                        s = "left ctrl";
                        break;
                    case KeyCode.RightAlt:
                        s = "right alt";
                        break;
                    case KeyCode.LeftAlt:
                        s = "left alt";
                        break;
                    case KeyCode.AltGr:
                        s = "alt gr";
                        break;
                    case KeyCode.Mouse0:
                        s = "mouse 0";
                        break;
                    case KeyCode.Mouse1:
                        s = "mouse 1";
                        break;
                    case KeyCode.Mouse2:
                        s = "mouse 2";
                        break;
                    case KeyCode.Mouse3:
                        s = "mouse 3";
                        break;
                    case KeyCode.Mouse4:
                        s = "mouse 4";
                        break;
                    case KeyCode.Mouse5:
                        s = "mouse 5";
                        break;
                    case KeyCode.Mouse6:
                        s = "mouse 6";
                        break;
                    
                    default:
                        break;
                }



                return s;
            }
        }

        return kc.ToString().ToLower();

    }

    public void NumOfPlayers(int i)
    {
        switch (i)
        {
            case 2:
                num = 2;
                break;

            case 3:
                num = 3;
                break;

            case 4:
                num = 4;
                break;

            default:

                break;
        }
        StartCoroutine("AssignKeys");
    }

    private void setkey(int i, string s) {
        keys[i] = s;
        
    }

    public IEnumerator AssignKeys()
    {
     
        int i = 0;
        int x = 1;
        while (i < num)
        {

            txt[i].gameObject.SetActive(true);
            if (Input.anyKeyDown)
            {
                    foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
                    {
                        if (Input.GetKeyDown(kcode)) {
                            keys[i] = GoLow(kcode);
                            txt[i].text = "Player " + x + ": " + keys[i];
                            i++;
                            x++;
                           
                            yield return null;
                        }


                    }
             

                }
                yield return null;

            }
        
        

        Application.LoadLevel(1);
    }


}
