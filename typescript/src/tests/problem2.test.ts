import { describe, expect, test } from '@jest/globals';
import factorial from '../problem2';

/**
 * Problem 2 - Factorial Tests
 *
 * @group factorial
 */
describe('Problem 2 - Factorial', () => {
	test('1', () => {
		expect(factorial(1)).toBe(1);
	});

	test('5', () => {
		expect(factorial(5)).toBe(120);
	});

	test('8', () => {
		expect(factorial(8)).toBe(40320);
	});
});
