# Header

```c
#include <semaphore.h>
```

# Create Semaphore

```c
int sem_init(sem_t *sem, int pshared, unsigned int value)
```

- `pshared` indicates whether the semaphore is shared between processes
  (non zero) or between threads of a process (zero)
- `value`

# Using Semaphore

```c
int sem_wait(sem_t *sem);
```

Decrease the value of the semaphore.

- Won't block if the value in the semaphore before decrease is bigger than 0
- Block if the value in the semaphore is already 0

```c
int sem_post(sem_t *sem);
```

Increase the value of the semaphore

- This function never blocks
