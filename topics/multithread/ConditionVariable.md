# Workflows

```
lock mutex

while condition
  wait condition variable

unlock mutex
```

## Why Lock Before Wait?

Condition variables' wait implementation requires a mutex to be unlocked, if a
mutex is not locked before hand, this results in an undefined behavior, or
unlocking other thread's mutex.

## Why Use Condition Variable with Mutex

Condition variable by itself is just a low-level event mechanism. There are
better solutions to event dispatching than condition variables.

## Why Waiting Is Atomic

Otherwise, signal/broadcast can be missed. Consider the following example

- Thread A has unlocked the mutex, but has not blocked
- Thread B has locked the mutex, and issues a signal/broadcast before thread A
  blocked

Thread A would misss the signal/broadcast because it has not blocked

# Spurious Wakeups

Spurious wakeups refer to the situations where a thread wakes up from a
condition variable wait even though there has not been a signal or broadcast.

**This is the reason why condition variables are always kept inside loops**.
