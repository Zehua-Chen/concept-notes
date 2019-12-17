# Spurious Wakeups

Spurious wakeups refer to the situations where a thread wakes up from a
condition variable wait even though there has not been a signal or broadcast.

**This is the reason why condition variables are always kept inside loops**.
