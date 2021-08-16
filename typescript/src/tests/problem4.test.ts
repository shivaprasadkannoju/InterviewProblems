import { describe, expect, test } from '@jest/globals';
import consecutiveDistance from '../problem4';

/**
 * Problem 4 - Consecutive Distance Tests
 *
 * @group consecutiveDistance
 */
describe('Problem 4 - Consecutive Distance', () => {
	test('[4, 3, 6, 8, 2]', () => {
		expect(consecutiveDistance([4, 3, 6, 8, 2])).toStrictEqual([1, -3, -2, 6]);
	});

	test('[0, 0, 1, 1, 5, 10, 100, 1000, 100, 999]', () => {
		expect(consecutiveDistance([0, 0, 1, 1, 5, 10, 100, 1000, 100, 999])).toStrictEqual([0, -1, 0, -4, -5, -90, -900, 900, -899]);
	});
});
