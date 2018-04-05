# Interval Composition
Calculate a final set of intervals based on a composition of intervals with priorities.

Here are some examples of interval compositions with the visible end segments:

Example 1:

![Example 1](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_1.svg "Example 1")

Example 2:

![Example 2](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_2.svg "Example 2")

Example 3:

![Example 3](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_4.svg "Example 3")

Here is a demonstration of the path of point visitation taken by the procedure:

![Example 3B](https://github.com/pedroos/pedroos.github.io/blob/master/layered_intervals_svg_4b.svg "Example 3B")

### Execution time

The calculation procedure of the final line is based on using a toggle state for each layer.

The time taken to calculate is at maximum linear (O(n)) to the total number of points, as in examples 1) and 2). But normally, as in example 3) when there is a minimal path, the procedure will take a shortcut and less points will be considered. In this case, the time taken is logarithmic (O log n).

In the example 3), there are 18 segments or 36 points. The minimal path consists of 12 points, or 33%.

The space taken for state during calculation is one true/false value per priority.

### Change processing

The points are stored internally in a forward-only linked list.

When an interval is modified, a traversal of all the points up to the change occurs; but only the range in the final line affected by the modification is recalculated.

### Requirements

The code is compiled for the .NET Framework 4 Client Profile.