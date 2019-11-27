import numpy as np
from typing import Iterable

class Conv2D:
    def __init__(self, filters: np.ndarray):
        """
        Construct a new conv2d layer
        :param filters: the filters to apply to each group of output channel
        """
        output_channels_size, y, x = filters.shape

        self.filters = filters
        self.stride = 1
        self.output_channels_size = output_channels_size

    def run(self, inputs: np.ndarray) -> np.ndarray:
        input_channels_size, y, x = inputs.shape
        assert y == x, "each input must have a squared shape"

        output = list()

        for filter_i, filter in enumerate(self.filters):
            pass