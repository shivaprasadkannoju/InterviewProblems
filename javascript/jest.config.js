module.exports = {
	testEnvironment: 'node',
	runner: 'groups',
	transform: {
		'^.+\\.[t|j]sx?$': 'babel-jest'
	}
};
