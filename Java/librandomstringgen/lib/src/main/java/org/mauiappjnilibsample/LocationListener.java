/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.mauiappjnilibsample;

/**
 * Callback interface to be implemented by string sequence listeners.
 */
public interface LocationListener {
    /**
     * Callback function called by the underlying library whenever a new location 
     * is generated.
     * 
     * @param loc Generated location 
     */
    void onLocation(Location loc);    
}
