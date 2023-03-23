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
 * This class is specifically for registering string sequence listeners
 * and for generating sequences.
 */
public class StringSequenceGenerator {
    private StringSequenceListener listener;
    private final Observable generator;
    private Disposable disposable;
    
    public StringSequenceGenerator() {
        generator = Observable.interval(new Random().nextInt(2), TimeUnit.SECONDS);
    }
    
    public void setStringSequenceListener(StringSequenceListener listener) {
        this.listener = listener;                
    }
    
    /**
     * Start generating string sequences
     */
    public void start() {
        disposable = generator.subscribe(x -> listener.onString("hello"));
    }
    
    /**
     * Stop generating string sequences
     */
    public void stop() {
        disposable.dispose();
    }
}
