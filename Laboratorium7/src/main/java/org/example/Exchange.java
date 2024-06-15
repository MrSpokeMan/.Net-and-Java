package org.example;

import javax.swing.*;
import java.awt.*;

public class Exchange {
    private JButton calculate;
    private JTextField input;
    private JTextField output;
    private JComboBox comboBox1;
    private JComboBox comboBox2;
    private  JPanel panel;
    private JButton download;
    private StockMarket stock;

    public Exchange() {
        download.addActionListener(e -> {
            APIStock api = new APIStock();
            stock = api.Deserialise(api.GetRequest());
            for (String key : stock.getRates().keySet()) {
                comboBox1.addItem(key);
                comboBox2.addItem(key);
            }
        });

        calculate.addActionListener(e -> {
            String from = (String) comboBox1.getSelectedItem();
            String to = (String) comboBox2.getSelectedItem();
            double amount = Double.parseDouble(input.getText());
            double result = Math.round(amount * getRate(from, to) * 100.0) / 100.0;
            output.setText(String.valueOf(result));
        });
    }

    private double getRate(String from, String to) {
        return stock.getRates().get(to) / stock.getRates().get(from);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Exchange");
        frame.setContentPane(new Exchange().panel);
        frame.setPreferredSize(new Dimension(800, 600));
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setVisible(true);
    }
}

