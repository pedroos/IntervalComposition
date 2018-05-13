# Interval Composition
Calculate a final set of intervals based on a composition of intervals with priorities.

Maintain and change intervals and recalculate.

Here are some examples of interval compositions:

Example 1:

![Example 1](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_1.svg "Example 1")

Example 2:

![Example 2](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_2.svg "Example 2")

Example 3:

![Example 3](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_4.svg "Example 3")

Path of points considered:

![Example 3B](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_4b.svg "Example 3B")

### Execution time

The calculation of the final line is based on using a toggle state for each layer.

The time taken to calculate is fixed (O(n)) relative to the number of points.

The space taken for state during calculation is one true/false value per layer.

### Change processing

The intervals are stored in a forward-only linked list.

When an interval is modified, a traversal of all the points up to the change occurs; but points outside of the changed range are not recalculated.

### Requirements

Target is the .NET Framework 4 Client Profile.
