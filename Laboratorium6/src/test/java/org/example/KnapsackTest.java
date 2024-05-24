package org.example;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;


class KnapsackTest {
    @Test
    void test1() {
        Knapsack problem = new Knapsack(10, 4923875, 1, 10);
        Result result = problem.Solve(15);
        assertFalse(result.numbersOfItems.isEmpty());
    }

    @Test
    void test2() {
        Knapsack problem = new Knapsack(10, 4923875, 1, 10);
        Result result = problem.Solve(0);
        assertTrue(result.numbersOfItems.isEmpty());
    }

    @Test
    void test3() {
        Knapsack problem = new Knapsack(10, 4923875, 1, 10);
        Result result = problem.Solve(15);
        for (Knapsack.Item item : result.numbersOfItems) {
            assertTrue(item.weight >= 1 && item.weight <= 10);
            assertTrue(item.value >= 1 && item.value <= 10);
        }
    }

    @Test
    void test4() {
        Knapsack problem = new Knapsack(10, 4923875, 1, 10);
        Result result = problem.Solve(15);
        int sumW = 0, sumV = 0;
        for (Knapsack.Item item : result.numbersOfItems) {
            sumW += item.weight;
            sumV += item.value;
        }
        assertEquals(sumW, result.summaryWeights);
        assertEquals(sumV, result.summaryValues);
    }
}