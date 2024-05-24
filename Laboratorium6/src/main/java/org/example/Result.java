package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Result {
    ArrayList<Knapsack.Item> numbersOfItems;
    int summaryWeights, summaryValues;

    public Result(ArrayList<Knapsack.Item> list, int sumW, int sumV) {
        this.numbersOfItems = list;
        this.summaryWeights = sumW;
        this.summaryValues = sumV;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder("--------------------\n");

        for (Knapsack.Item item : numbersOfItems) {
            sb.append("Item number: ").append(item.number).append(" weight: ").append(item.weight).append(" value: ").append(item.value).append("\n");
        }
        sb.append("Summary weight: ").append(summaryWeights).append("\n");
        sb.append("Summary value: ").append(summaryValues).append("\n");
        return sb.toString();
    }
}
