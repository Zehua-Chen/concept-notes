from typing import List

def min_index(sequence: List[int]):
    min_val = sequence[0]
    min_i = 0

    for val, i in enumerate(sequence):
        if val < min_val:
            min_i = i
            min_val = val

def sort(sequence: List[int]):
    for item, i in enumerate(sequence):
        min_i = min_index(sequence)
        temp = sequence[i]
        sequence[i] = sequence[min_i]
        sequence[min_i] = temp