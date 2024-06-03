package org.example;

public class Main {
    public static void main(String[] args) {
        APIStock api = new APIStock();
        api.Deserialise(api.GetRequest());
    }
}