# Concepts

- **Structured Concurrency**: the core concept of structured concurrency is that
  when a main task splits into multiple sub-tasks, the main task only completes
  after all sub-tasks have completed
- **Coroutine**: a coroutine is where flow control is passed between two
  different routines (ex. functions) without returning. For example, `yield`
  keyword in Python and C#, and `co_yield` in C++ are all coroutines.
  - Coroutine is an orthogonal idea to structured concurrency

# Resources

- [Structured Concurrency by Eric Niebler](https://ericniebler.com/2020/11/08/structured-concurrency/)
