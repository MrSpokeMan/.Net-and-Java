package org.example;

import javax.swing.*;
import java.awt.*;

public class KnapsackUI {
    private JTextField textField1;
    private JTextField textField2;
    private JTextField capacityText;
    private JTextArea textGenerated;
    private JButton solveButton;
    private JTextArea textSolution;
    private JPanel panel1;

    public KnapsackUI() {
        solveButton.addActionListener(e -> {
            int n = Integer.parseInt(textField2.getText());
            int seed = Integer.parseInt(textField1.getText());
            int capacity = Integer.parseInt(capacityText.getText());
            Knapsack problem = new Knapsack(n, seed, 1, 10);
            textGenerated.setText(problem.toString());
            textSolution.setText(problem.Solve(capacity).toString());
        });
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("KnapsackUI");
        frame.setContentPane(new KnapsackUI().panel1);
        frame.setPreferredSize(new Dimension(800, 600));
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setVisible(true);
    }
}
