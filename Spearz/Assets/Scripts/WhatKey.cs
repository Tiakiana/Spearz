using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class WhatKey : MonoBehaviour
{
    void Start()
    {

    }
    string GoLow(KeyCode kc)
    {
        return kc.ToString().ToLower();

    }
    public void detectPressedKeyOrButton()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                Debug.Log("KeyCode down: " + kcode);
                Debug.Log("Which would be " + GoLow(kcode));
            

                Debug.Log(""+ (int) kcode);
            }
        }
    }    
    void Update()
    {
        detectPressedKeyOrButton();
    }
}

/*
// Nedenstående bruges til Input.GetKey("qqch");

Normal keys: “a”, “b”, “c” …
Number keys: “1”, “2”, “3”, …
Arrow keys: “up”, “down”, “left”, “right”
Keypad keys: “[1]”, “[2]”, “[3]”, “[+]”, “[equals]”
Modifier keys: “right shift”, “left shift”, “right ctrl”, “left ctrl”, “right alt”, “left alt”, “right cmd”, “left cmd”
Mouse Buttons: “mouse 0”, “mouse 1”, “mouse 2”, …
Joystick Buttons (from any joystick): “joystick button 0”, “joystick button 1”, “joystick button 2”, …
Joystick Buttons (from a specific joystick): “joystick 1 button 0”, “joystick 1 button 1”, “joystick 2 button 0”, …
Special keys: “backspace”, “tab”, “return”, “escape”, “space”, “delete”, “enter”, “insert”, “home”, “end”, “page up”, “page down”
Function keys: “f1”, “f2”, “f3”, …
    */
