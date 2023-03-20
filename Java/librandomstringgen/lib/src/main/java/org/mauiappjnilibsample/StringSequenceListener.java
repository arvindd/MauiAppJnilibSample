/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.mauiappjnilibsample;

/**
 * Callback interface to be implemented by string sequence listeners.
 */
public interface StringSequenceListener {
    /**
     * Callback function called by the underlying library whenever a new string 
     * in the sequence is generated.
     * @param str 
     */
    void onString(String str);    
}
