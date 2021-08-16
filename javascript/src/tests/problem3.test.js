import { describe, expect, test } from '@jest/globals';
import passengerLoad from '../problem3';

/**
 * Problem 3 - Passenger Load Tests
 *
 * @group passengerLoad
 */
describe('Problem 3 - Passenger Load', () => {
	test('[[10, 0], [3, 5], [5, 8]]', () => {
		expect(
			passengerLoad([
				[10, 0],
				[3, 5],
				[5, 8]
			])
		).toBe(5);
	});

	test('[[5, 3]]', () => {
		expect(passengerLoad([[5, 3]])).toBe(2);
	});

	test('[[8, 4], [19, 4], [6, 3], [0, 12], [7, 8], [4, 4]]', () => {
		expect(
			passengerLoad([
				[8, 4],
				[19, 4],
				[6, 3],
				[0, 12],
				[7, 8],
				[4, 4]
			])
		).toBe(9);
	});
});
