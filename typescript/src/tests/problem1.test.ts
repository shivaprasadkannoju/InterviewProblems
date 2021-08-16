import { describe, expect, test } from '@jest/globals';
import longestStr from '../problem1';

/**
 * Problem 1 - Max Length String Tests
 *
 * @group maxLenStr
 */
describe('Problem 1 - Max Length String', () => {
	test('quick brown fox', () => {
		const longest = longestStr(['the', 'quick', 'brown', 'fox', 'jumped', 'over', 'the', 'lazy', 'dog']);
		expect(longest).toBe(6);
	});

	test('long', () => {
		const longest = longestStr(['long string 123', 'short str', 'tiny']);
		expect(longest).toBe(15);
	});

	test('duplicates', () => {
		const longest = longestStr(['test', 'test', 'hi']);
		expect(longest).toBe(4);
	});
});
