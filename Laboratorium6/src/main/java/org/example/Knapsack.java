package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;

// Class for solving unlimited KnapSack problem
public class Knapsack {
    int n; // Number of kinds of items
    int seed; // Seed for random number generator
    int lowerBound, upperBound; // Maximum and minimum weight of items
    public class Item {
        int number, weight, value;
        Item(int num, int weight, int value) {
            this.number = num;
            this.weight = weight;
            this.value = value;
        }
    }
    Item[] items; // Array of items

    // Constructor
    public Knapsack(int n, int seed, int lowerBound, int upperBound) {
        this.n = n;
        this.seed = seed;
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;

        // Generate random items
        Random random = new Random(seed);
        this.items = new Item[n];
        for (int i = 0; i < n; i++) {
            this.items[i] = new Item((i + 1), random.nextInt(upperBound - lowerBound) + lowerBound,
                    random.nextInt(upperBound - lowerBound) + lowerBound);
        }
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        for (Item item : items) {
            sb.append("Item number: ").append(item.number).append(" weight: ").append(item.weight).append(" value: ").append(item.value).append("\n");
        }
        return sb.toString();
    }

    public Result Solve(int capacity) {
        ArrayList<Item> resultList = new ArrayList<>();
        int summaryW = 0, summaryV = 0;

        Arrays.sort(items, (a, b) -> {
            double r1 = (double) a.value / a.weight;
            double r2 = (double) b.value / b.weight;
            return Double.compare(r2, r1);
        });

        for (int i = 0; i < n; i++) {
            if (capacity == 0) {
                break;
            }
            if (items[i].weight <= capacity) {
                while(items[i].weight <= capacity) {
                    resultList.add(items[i]);
                    summaryW += items[i].weight;
                    summaryV += items[i].value;
                    capacity -= items[i].weight;
                }
            }
        }

        Result result = new Result(resultList, summaryW, summaryV);
        return result;
    }
}
