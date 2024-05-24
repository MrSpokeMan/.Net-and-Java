package org.example;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Knapsack problem = new Knapsack(10, 4923875, 1, 10);
        System.out.println(problem);
        System.out.println(problem.Solve(15));
    }
}