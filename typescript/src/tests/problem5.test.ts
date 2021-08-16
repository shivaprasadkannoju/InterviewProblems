import { describe, expect, test } from '@jest/globals';
import isDigitSumPalindrome from '../problem5';

/**
 * Problem 5 - Digit Sum Palindrome Tests
 *
 * @group palindrome
 */
describe('Problem 5 - Digit Sum Palindrome Tests', () => {
	test('56', () => {
		expect(isDigitSumPalindrome(56)).toBeTruthy();
	});

	test('958', () => {
		expect(isDigitSumPalindrome(92)).toBeTruthy();
	});

	test('296', () => {
		expect(isDigitSumPalindrome(296)).toBeFalsy();
	});
});
