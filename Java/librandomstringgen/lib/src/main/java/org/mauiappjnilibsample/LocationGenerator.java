/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.mauiappjnilibsample;

import io.reactivex.rxjava3.core.Observable;
import io.reactivex.rxjava3.disposables.Disposable;
import java.util.Random;
import java.util.concurrent.TimeUnit;

/**
 * This class is specifically for registering location listeners
 * and for generating random locations.
 */
public class LocationGenerator {
    private LocationListener listener;
    private final Observable generator;
    private Disposable disposable;
    private final RandomData rand;
    
    /**
     * Generate random locations with 1 second interval until stopped.
     */
    public LocationGenerator() {
        generator = 
                Observable
                .interval(new Random().nextInt(2), TimeUnit.SECONDS);
        
        rand = new RandomData();
    }
    
    public void setLocationListener(LocationListener listener) {
        this.listener = listener;                
    }
    
    /**
     * Start generating random locations
     */
    public void start() {
        disposable = generator.subscribe(x -> {
            Location loc = new Location(rand.getRandomFloat(), rand.getRandomFloat());
            listener.onLocation(loc);
        });
    }
    
    /**
     * Stop generating locations
     */
    public void stop() {
        disposable.dispose();
    }
}
