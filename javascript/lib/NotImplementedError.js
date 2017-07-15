class NotImplementedError extends Error {
  constructor() {
    super();
    this.name = 'NotImplementedError';
    this.stack = (new Error()).stack;
  }
}

module.exports = NotImplementedError;
