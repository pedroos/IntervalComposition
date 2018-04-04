using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pedroos.Algos
{
    public class IntervalComposition
    {
        public struct Point : ICloneable
        {
            public int Pos { get; private set; }
            public bool End { get; private set; }
            public int Priority { get; private set; }

            public Point(int pos, bool end, int priority)
            {
                Pos = pos;
                End = end;
                Priority = priority;
            }

            public object Clone()
            {
                return new Point(Pos, End, Priority);
            }
        }

        public class OrderedNode : IDisposable
        {
            public Point Point { get; private set; }
            public int Value { get; private set; }
            public OrderedNode Next { get; private set; }

            public OrderedNode(Point point, int value)
            {
                Point = point;
                Value = value;
            }

            public OrderedNode InsertBefore(Point point, int value)
            {
                OrderedNode node = new OrderedNode(point, value);
                node.Next = this;
                return node;
            }

            public OrderedNode InsertAfter(Point point, int value)
            {
                OrderedNode node = new OrderedNode(point, value);
                node.Next = Next;
                Next = node;
                return node;
            }

            public void RemoveNext()
            {
                if (Next == null) return;
                OrderedNode newNext = Next.Next;
                Next.Next = null;
                Next.Dispose();
                Next = newNext;
            }

            public void RemoveThisHead() // Assumes no previous node (head)
            {
                Next = null;
                Dispose();
            }

            #region IDisposable Support
            private bool disposedValue = false; // Redundant calls detection

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        Next = null;
                    }

                    disposedValue = true;
                }
            }
            
            public void Dispose()
            {
                Dispose(true);
            }
            #endregion
        }

        private int priorities;
        private PointComparer pointComparer; // Tied to priorities
        private OrderedNode head;
        //private Dictionary<int, OrderedNode> nodeIndex; // Indexed by point value
        private SortedSet<Point> path;

        public IEnumerable<Point> Path
        {
            get
            {
                return path.AsEnumerable();
            }
        }

        public IntervalComposition(int priorities)
        {
            this.priorities = priorities;
            pointComparer = new PointComparer(priorities);
            //nodeIndex = new Dictionary<int, OrderedNode>();
            path = new SortedSet<Point>(pointComparer);
        }

        /// <summary>
        /// Create an interval composition with the specified points.
        /// </summary>
        /// <param name="priorities">The number of priorities.</param>
        /// <param name="points">The points to be loaded.</param>
        /// <remarks>To load a new set of points, create a new instance of IntervalComposition.</remarks>
        public IntervalComposition(int priorities, IEnumerable<Point> points) : this(priorities)
        {
            if (!(priorities > 0))
            {
                throw new ArgumentException("Priorities should be positive");
            }
            foreach (Point point in points)
            {
                AddPoint(point);
            }
        }

        internal class ChangeNodePosResult
        {
            public OrderedNode StopNode { get; private set; }
            public bool Inverted { get; private set; }
            public int AffectedFrom { get; private set; }
            public int AffectedTo { get; private set; }

            public ChangeNodePosResult(OrderedNode stopNode, bool inverted, int affectedFrom, int affectedTo)
            {
                StopNode = stopNode;
                Inverted = inverted;
                AffectedFrom = affectedFrom;
                AffectedTo = affectedTo;
            }
        }

        // Remove one point and insert the substituting point.
        // Calculate the affected range in the path.
        // (Old) Return the last point to be used in the calculation for the path.
        // TODO: Linked list thread safety
        private ChangeNodePosResult ChangeNodePos(Point point, int newPos)
        {
            int value = pointComparer.PointValue(point.Pos, point.Priority, point.End);
            int newValue = pointComparer.PointValue(newPos, point.Priority, point.End);

            bool inverted = newPos < point.Pos;
            int affectedFrom = !inverted ? point.Pos : newPos;
            int affectedTo = !inverted ? newPos : point.Pos;

            // Remove
            if (head.Value == value)
            {
                OrderedNode newHead = head.Next;
                head.RemoveThisHead();
                head = newHead;
            }
            else
            {
                OrderedNode node = head;
                while (true)
                {
                    if (node.Next != null && node.Next.Value == value)
                    {
                        break;
                    }
                    if (node.Next == null)
                    {
                        throw new ArgumentException("Point not found.");
                    }
                    node = node.Next;
                }
                if (node.Next.Point.Pos != point.Pos)
                {
                    throw new ApplicationException("Changed point position doesn't match.");
                }
                node.RemoveNext();
            }

            // Insert
            Point newPoint = new Point(newPos, point.End, point.Priority);
            OrderedNode newNode;
            if (head.Value > newValue)
            {
                newNode = head.InsertBefore(newPoint, newValue);
            }
            else
            {
                OrderedNode node = head;
                while (true)
                {
                    if (node.Next == null || node.Next.Value > newValue)
                    {
                        break;
                    }
                    node = node.Next;
                }
                newNode = node.InsertAfter(newPoint, newValue);
            }

            // If the direction is to the right, we should calculate up to the new point. 
            // If not, we should stop right after the point preceding the changed point.
            //OrderedNode stopNode = !inverted ? (oldNodePrevious ?? head) : newNode;

            return new ChangeNodePosResult(null/*stopNode*/, inverted, affectedFrom, affectedTo);
        }

        // TODO: Nodes index could be binary searched.
        // TODO: Linked list thread safety
        private OrderedNode AddPoint(Point point)
        {
            int pointValue = pointComparer.PointValue(point.Pos, point.Priority, point.End);
            // Each time, search from beginning
            if (head == null)
            {
                head = new OrderedNode(point, pointValue);
                //nodeIndex.Add(pointValue, head);
                return head;
            }
            if (head.Value > pointValue)
            {
                head = head.InsertBefore(point, pointValue);
                //nodeIndex.Add(pointValue, head);
                return head;
            }
            OrderedNode newNode;
            if (head.Next == null)
            {
                newNode = head.InsertAfter(point, pointValue);
                //nodeIndex.Add(pointValue, newNode);
                return newNode;
            }
            OrderedNode node = head;
            // Find where to insert
            while (true)
            {
                if (node.Next == null || node.Next.Value > pointValue)
                {
                    newNode = node.InsertAfter(point, pointValue);
                    //nodeIndex.Add(pointValue, newNode);
                    return newNode;
                }
                node = node.Next;
            }
        }

        public void CalculateAll()
        {
            int pathChanges;
            CalculateFromTo(head, false, null, null, out pathChanges);
        }

        #region Box API

        //public void AddSegment(int pos, int endPos, int priority)
        //{
        //    if (priority > priorities)
        //    {
        //        throw new ArgumentOutOfRangeException("priority");
        //    }
        //    Point point = new Point(pos, false, priority);
        //    OrderedNode from = AddPoint(point);
        //    point = new Point(endPos, true, priority);
        //    AddPoint(point);
        //    CalculateFromTo(from, endPos);
        //}

        public void ChangePos(Point point, int newPos)
        {
            //OrderedNode node = nodeIndex[nodePointValue];
            ChangeNodePosResult result = ChangeNodePos(point, newPos);

            // Recalculate.
            int pathChanges;
            CalculateFromTo(result.StopNode, result.Inverted, result.AffectedFrom, result.AffectedTo, out pathChanges);
        }

        #endregion

        private void CalculateFromTo(OrderedNode stopNode, bool inverted, int? affectedFrom, int? affectedTo,
            out int pathChanges, bool occlusionCheck = true)
        {
            pathChanges = 0;

            // Clear the path partial area
            if (affectedFrom.HasValue && affectedTo.HasValue)
            {
                pathChanges += path.RemoveWhere(p => p.Pos >= affectedFrom.Value && p.Pos <= affectedTo.Value);
            }
            else
            {
                path.Clear();
            }

            // Walk from the beginning. Begin from scratch for statuses but only consider the 
            // final path in the affected range. Stop right after it.
            OrderedNode node = head;

            bool[] priorityOpened = new bool[priorities];
            bool finalOpened = false;

            lock (path)
            {
                while (true)
                {
                    bool inAffected = !affectedFrom.HasValue || (node.Point.Pos >= affectedFrom.Value &&
                        node.Point.Pos <= affectedTo.Value);
                    if (!node.Point.End)
                    {
                        // Any higher priority opened or still in same position? Keep it open.
                        int higherOpened = AnyHigherPriorityOpened(node.Point.Priority, ref priorityOpened);
                        if (higherOpened == 0)
                        {
                            // Final opened? Close it.
                            if (finalOpened)
                            {
                                if (inAffected)
                                {
                                    path.Add(new Point(node.Point.Pos, true, 0));
                                    pathChanges++;
                                }
                                finalOpened = false;
                            }
                            // Open.
                            if (inAffected)
                            {
                                path.Add(new Point(node.Point.Pos, false, 0));
                                pathChanges++;
                            }
                            finalOpened = true;
                        }

                        priorityOpened[node.Point.Priority - 1] = true;
                    }
                    else
                    {
                        priorityOpened[node.Point.Priority - 1] = false;

                        // Final opened?
                        if (finalOpened)
                        {
                            // Any higher opened? Don't close final.
                            int higherOpened = AnyHigherPriorityOpened(node.Point.Priority, ref priorityOpened);
                            if (higherOpened == 0)
                            {
                                // Close final
                                if (inAffected)
                                {
                                    path.Add(new Point(node.Point.Pos, true, 0));
                                    pathChanges++;
                                }
                                finalOpened = false;
                            }
                        }
                    }

                    // Final closed. At last priority of position, and any (other) priority 
                    // open? Reopen final. (Except at last node.)
                    if (!finalOpened)
                    {
                        if (node.Next != null && node.Next.Point.Pos != node.Point.Pos)
                        {
                            bool otherOpened = AnyOtherPriorityOpened(node.Point.Priority, ref priorityOpened);
                            if (otherOpened)
                            {
                                if (inAffected)
                                {
                                    path.Add(new Point(node.Point.Pos, false, 0));
                                    pathChanges++;
                                }
                                finalOpened = true;
                            }
                        }
                    }

                    if (node.Next == null || (affectedTo.HasValue && node.Next.Point.Pos > affectedTo.Value))
                    {
                        break;
                    }
                    node = node.Next;
                }
            }
        }

        private int AnyHigherPriorityOpened(int priority, ref bool[] priorityOpened)
        {
            if (!(priority > 0))
            {
                return 0;
            }
            for (int p = priority + 1; p <= priorities; p++)
            {
                if (priorityOpened[p - 1])
                {
                    return p;
                }
            }
            return 0;
        }

        private bool AnyOtherPriorityOpened(int priority, ref bool[] priorityOpened)
        {
            for (int p = 1; p < priorities; p++)
            {
                if (p == priority)
                {
                    continue;
                }
                if (priorityOpened[p - 1])
                {
                    return true;
                }
            }
            return false;
        }

        // TODO: Integrity verification
        public static bool VerifyPoints(IEnumerable<Point> points)
        {
            // RULES:
            // Two points in the same position can't have the same priority.
            // Each priority should have an even number of points.
            // Points in a priority should toggle between opening and closing.
            // No two segments in a priority should overlap.

            return true;
        }

        #region For tests

        private class PointComparer : IComparer<Point>
        {
            private int priorities;

            public PointComparer(int priorities)
            {
                this.priorities = priorities;
            }

            public int Compare(Point x, Point y)
            {
                return PointValue(x.Pos, x.Priority, x.End) - PointValue(y.Pos, y.Priority, y.End);
            }

            // Values are 0-based, with lower positions, higher priorities, and opening points 
            // come first.
            internal int PointValue(int pos, int priority, bool end)
            {
                return (((priorities * (pos - 1)) + priorities - priority) * 2) + (end ? 0 : 1);
            }
        }

        internal OrderedNode getHead()
        {
            return head;
        }

        // We're disabling indexing for now.
        //internal OrderedNode getIndexedNode(int value)
        //{
        //    return nodeIndex[value];
        //}

        internal int getPointValue(Point point)
        {
            return pointComparer.PointValue(point.Pos, point.Priority, point.End);
        }

        internal SortedSet<Point> sortPoints(List<Point> points)
        {
            SortedSet<Point> sortedPoints = new SortedSet<Point>(pointComparer);
            foreach (Point point in points)
            {
                sortedPoints.Add((Point)point.Clone());
            }
            return sortedPoints;
        }

        internal ChangeNodePosResult getChangeNodePos(Point point, int newPos)
        {
            return ChangeNodePos(point, newPos);
        }

        internal void getChangePos(Point point, int newPos, out int pathChanges, bool occlusionCheck = true)
        {
            //OrderedNode node = nodeIndex[nodePointValue];
            ChangeNodePosResult result = ChangeNodePos(point, newPos);

            // Recalculate.
            CalculateFromTo(result.StopNode, result.Inverted, result.AffectedFrom, result.AffectedTo, out pathChanges,
                occlusionCheck);
        }

        #endregion

    }
}
