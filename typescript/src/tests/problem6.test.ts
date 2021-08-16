import { describe, expect, test } from '@jest/globals';
import createEquilibriumArrays from '../problem6';

/**
 * Problem 6 - Create Equilibrium Arrays Tests
 *
 * @group equilibrium
 */
describe('Problem 6 - Create Equilibrium Arrays', () => {
	test('[1, 2, 3]', () => {
		expect(createEquilibriumArrays([1, 2, 3])).toStrictEqual([[1, 2], [3]]);
	});

	test('[2, 3, 1, 5, 4, 7]', () => {
		expect(createEquilibriumArrays([2, 3, 1, 5, 4, 7])).toStrictEqual([
			[2, 3, 1, 5],
			[4, 7]
		]);
	});

	test('[1, 1, 1, 1, 1, 1]', () => {
		expect(createEquilibriumArrays([1, 1, 1, 1, 1, 1])).toStrictEqual([
			[1, 1, 1],
			[1, 1, 1]
		]);
	});
});
