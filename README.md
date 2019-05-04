# Interval Composition
Calculate a final set of intervals based on a composition of intervals with priorities.

Maintain and change intervals and recalculate.

Example of path of points considered:

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
