/**
 * Passenger Load
 * @typedef {[number, number]} PassengerLoad
 */
type PassengerLoad = [number, number];

/**
 * A bus is moving through Champaign-Urbana.
 * At each stop, passengers get on and off.
 * Create a function that takes a collection of arrays representing stops.
 * Each array will contain two integer values – the first representing passengers boarding at the stop
 * and the second representing passengers alighting at the stop.
 * This function should calculate the total passenger load at the bus’s last stop.
 *
 * To test your solution, run `yarn test3` in the console.
 *
 * @param {PassengerLoad[]} busStops A collection of arrays representing bus stops. Each Array contains two integer values.
 * The first representing the total number of passengers boarding at that stop
 * and the second representing the total number of passengers alighting at that stop.
 * You may assume that this array will not be empty.
 * @returns {number} The total number of passengers at the bus’s last stop.
 * @example passengerLoad([[10, 0], [3, 5], [5, 8]]); // 5
 */
export default function passengerLoad(busStops: PassengerLoad[]): number {
	// Your code goes below
	throw new Error('not implemented');
}
