/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package org.mauiappjnilibsample;

import java.util.UUID;
import java.util.Random;

/**
 * Generates a random data (string or float) 
 */
public class RandomData {
    private final Random data;
    
    public RandomData() {
        data = new Random();
    }
    
    /**
     * Generate random string each time this function is called.
     * @return Random string
     */
    public String getRandomString() {
        return "FromJava: " + UUID.randomUUID().toString().substring(0, 10);
    }
    
    /**
     * Generate random float each time this function is called.
     * @return Random float
     */
    public float getRandomFloat() {
        return data.nextFloat() * 100;
    }
}
