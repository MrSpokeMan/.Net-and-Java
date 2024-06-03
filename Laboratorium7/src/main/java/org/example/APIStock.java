package org.example;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class APIStock {
    private final String token = "3248e81f0c3648bab69d72bc63c25e0e";
    private final String url = "https://openexchangerates.org/api/latest.json?app_id=" + token;
    HttpURLConnection conn;

    public APIStock() {
        try {
        URL url = new URL(this.url);
        this.conn = (HttpURLConnection) url.openConnection();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public String GetRequest() {
        try {
            this.conn.setRequestMethod("GET");
            int req = conn.getResponseCode();
            BufferedReader in = new BufferedReader(new InputStreamReader(conn.getInputStream()));
            String inputLine;
            StringBuffer content = new StringBuffer();
            while ((inputLine = in.readLine()) != null) {
                content.append(inputLine);
            }
            in.close();
            return content.toString();
        } catch (IOException e) {
            e.printStackTrace();
            return null;
        }
    }

    public StockMarket Deserialise(String json) {
        // Deserialise JSON
        ObjectMapper mapper = new ObjectMapper();
        System.out.println(json);
        try {
            StockMarket stock = mapper.readValue(json, StockMarket.class);
            return stock;
        } catch (JsonProcessingException e) {
            e.printStackTrace();
            return null;
        }
    }
}
