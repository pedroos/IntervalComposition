# Interval Composition
Calculate a final set of intervals based on a composition of intervals with priorities. [More details](http://psobo.com/blog/an_algorithm_for_layered_interval_computation.html).

Maintain and change intervals and recalculate.

Example of path of points considered:

![Example 3B](https://psobo.com/blog/layered_intervals_svg_4b.svg "Example 3B")

### Execution time

The calculation of the final line is based on using a toggle state for each layer.

The time taken to calculate is fixed (O(n)) relative to the number of points.

The space taken for state during calculation is one true/false value per layer.

### Change processing

The intervals are stored in a forward-only linked list.

When an interval is modified, a traversal of all the points up to the change occurs; but points outside of the changed range are not recalculated.
