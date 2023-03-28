/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.mauiappjnilibsample;

/**
 * Latitude and Longitude
 */
public class Location {
    private float latitude;
    private float longitude;

    public Location(float lat, float lon) {
      latitude = lat;
      longitude = lon;
    }
    public float getLat() { return latitude; }
    public void setLat(float lat) { latitude = lat; }
    public float getLon() { return longitude; }
    public void setLon(float lon) { longitude = lon; }    
}
