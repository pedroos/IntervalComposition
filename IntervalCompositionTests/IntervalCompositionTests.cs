using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Pedroos.Algos
{
    [TestClass]
    public class IntervalCompositionTests
    {
        private static class IcSamples
        {
            public class Sample
            {
                public int Priorities { get; private set; }
                public IEnumerable<IntervalComposition.Point> Points { get; private set; }
                public IEnumerable<IntervalComposition.Point> Path { get; private set; }

                public Sample(int priorities, List<IntervalComposition.Point> points, List<IntervalComposition.Point> path)
                {
                    Priorities = priorities;
                    Points = points;
                    Path = path;
                }
            }

            private static readonly Dictionary<int, Sample> samples;

            public static Dictionary<int, Sample> Samples { get { return samples; } }

            private static void Scramble(List<IntervalComposition.Point> points)
            {

            }

            static IcSamples()
            {
                samples = new Dictionary<int, Sample>();
                samples.Add(
                    4, new Sample(5, new List<IntervalComposition.Point>()
                    {
                        new IntervalComposition.Point(21, true, 1),
                        new IntervalComposition.Point(21, true, 2),
                        new IntervalComposition.Point(20, true, 3),
                        new IntervalComposition.Point(19, true, 4),
                        new IntervalComposition.Point(18, false, 4),
                        new IntervalComposition.Point(18, true, 5),
                        new IntervalComposition.Point(17, false, 2),
                        new IntervalComposition.Point(16, false, 3),
                        new IntervalComposition.Point(15, false, 1),
                        new IntervalComposition.Point(14, true, 2),
                        new IntervalComposition.Point(14, false, 5),
                        new IntervalComposition.Point(13, true, 1),
                        new IntervalComposition.Point(13, true, 3),
                        new IntervalComposition.Point(13, true, 4),
                        new IntervalComposition.Point(12, false, 2),
                        new IntervalComposition.Point(11, false, 4),
                        new IntervalComposition.Point(9, false, 1),
                        new IntervalComposition.Point(7, true, 2),
                        new IntervalComposition.Point(6, false, 3),
                        new IntervalComposition.Point(5, true, 1),
                        new IntervalComposition.Point(3, false, 2),
                        new IntervalComposition.Point(1, false, 1)
                    }, new List<IntervalComposition.Point>
                    {
                        new IntervalComposition.Point(1, false, 0),
                        new IntervalComposition.Point(3, true, 0),
                        new IntervalComposition.Point(3, false, 0),
                        new IntervalComposition.Point(6, true, 0),
                        new IntervalComposition.Point(6, false, 0),
                        new IntervalComposition.Point(11, true, 0),
                        new IntervalComposition.Point(11, false, 0),
                        new IntervalComposition.Point(13, true, 0),
                        new IntervalComposition.Point(13, false, 0),
                        new IntervalComposition.Point(14, true, 0),
                        new IntervalComposition.Point(14, false, 0),
                        new IntervalComposition.Point(18, true, 0),
                        new IntervalComposition.Point(18, false, 0),
                        new IntervalComposition.Point(19, true, 0),
                        new IntervalComposition.Point(19, false, 0),
                        new IntervalComposition.Point(20, true, 0),
                        new IntervalComposition.Point(20, false, 0),
                        new IntervalComposition.Point(21, true, 0)
                    })
                );
                samples.Add(
                    3, new Sample(7, new List<IntervalComposition.Point>()
                    {
                        new IntervalComposition.Point(1, false, 1),
                        new IntervalComposition.Point(3, false, 3),
                        new IntervalComposition.Point(3, false, 2),
                        new IntervalComposition.Point(5, true, 1),
                        new IntervalComposition.Point(7, false, 4),
                        new IntervalComposition.Point(7, true, 2),
                        new IntervalComposition.Point(7, false, 1),
                        new IntervalComposition.Point(8, false, 5),
                        new IntervalComposition.Point(9, false, 7),
                        new IntervalComposition.Point(9, false, 6),
                        new IntervalComposition.Point(9, true, 4),
                        new IntervalComposition.Point(9, true, 3),
                        new IntervalComposition.Point(9, false, 2),
                        new IntervalComposition.Point(10, true, 7),
                        new IntervalComposition.Point(10, true, 5),
                        new IntervalComposition.Point(10, false, 4),
                        new IntervalComposition.Point(11, true, 1),
                        new IntervalComposition.Point(12, false, 7),
                        new IntervalComposition.Point(12, false, 5),
                        new IntervalComposition.Point(12, true, 4),
                        new IntervalComposition.Point(13, true, 7),
                        new IntervalComposition.Point(13, true, 6),
                        new IntervalComposition.Point(13, false, 4),
                        new IntervalComposition.Point(13, false, 3),
                        new IntervalComposition.Point(13, true, 2),
                        new IntervalComposition.Point(13, false, 1),
                        new IntervalComposition.Point(14, true, 5),
                        new IntervalComposition.Point(15, true, 4),
                        new IntervalComposition.Point(15, false, 2),
                        new IntervalComposition.Point(17, true, 3),
                        new IntervalComposition.Point(17, true, 1),
                        new IntervalComposition.Point(19, true, 2),
                        new IntervalComposition.Point(19, false, 1),
                        new IntervalComposition.Point(21, true, 1)
                    }, new List<IntervalComposition.Point>
                    {
                        new IntervalComposition.Point(1, false, 0),
                        new IntervalComposition.Point(3, true, 0),
                        new IntervalComposition.Point(3, false, 0),
                        new IntervalComposition.Point(7, true, 0),
                        new IntervalComposition.Point(7, false, 0),
                        new IntervalComposition.Point(8, true, 0),
                        new IntervalComposition.Point(8, false, 0),
                        new IntervalComposition.Point(9, true, 0),
                        new IntervalComposition.Point(9, false, 0),
                        new IntervalComposition.Point(10, true, 0),
                        new IntervalComposition.Point(10, false, 0),
                        new IntervalComposition.Point(12, true, 0),
                        new IntervalComposition.Point(12, false, 0),
                        new IntervalComposition.Point(13, true, 0),
                        new IntervalComposition.Point(13, false, 0),
                        new IntervalComposition.Point(14, true, 0),
                        new IntervalComposition.Point(14, false, 0),
                        new IntervalComposition.Point(15, true, 0),
                        new IntervalComposition.Point(15, false, 0),
                        new IntervalComposition.Point(17, true, 0),
                        new IntervalComposition.Point(17, false, 0),
                        new IntervalComposition.Point(19, true, 0),
                        new IntervalComposition.Point(19, false, 0),
                        new IntervalComposition.Point(21, true, 0)
                    })
                );
                samples.Add(
                    1, new Sample(6, new List<IntervalComposition.Point>()
                    {
                        new IntervalComposition.Point(1, false, 1),
                        new IntervalComposition.Point(3, false, 2),
                        new IntervalComposition.Point(5, false, 3),
                        new IntervalComposition.Point(7, false, 4),
                        new IntervalComposition.Point(9, false, 5),
                        new IntervalComposition.Point(10, false, 6),
                        new IntervalComposition.Point(12, true, 6),
                        new IntervalComposition.Point(13, true, 5),
                        new IntervalComposition.Point(15, true, 4),
                        new IntervalComposition.Point(17, true, 3),
                        new IntervalComposition.Point(19, true, 2),
                        new IntervalComposition.Point(21, true, 1)
                    }, new List<IntervalComposition.Point>
                    {
                        new IntervalComposition.Point(1, false, 0),
                        new IntervalComposition.Point(3, true, 0),
                        new IntervalComposition.Point(3, false, 0),
                        new IntervalComposition.Point(5, true, 0),
                        new IntervalComposition.Point(5, false, 0),
                        new IntervalComposition.Point(7, true, 0),
                        new IntervalComposition.Point(7, false, 0),
                        new IntervalComposition.Point(9, true, 0),
                        new IntervalComposition.Point(9, false, 0),
                        new IntervalComposition.Point(10, true, 0),
                        new IntervalComposition.Point(10, false, 0),
                        new IntervalComposition.Point(12, true, 0),
                        new IntervalComposition.Point(12, false, 0),
                        new IntervalComposition.Point(13, true, 0),
                        new IntervalComposition.Point(13, false, 0),
                        new IntervalComposition.Point(15, true, 0),
                        new IntervalComposition.Point(15, false, 0),
                        new IntervalComposition.Point(17, true, 0),
                        new IntervalComposition.Point(17, false, 0),
                        new IntervalComposition.Point(19, true, 0),
                        new IntervalComposition.Point(19, false, 0),
                        new IntervalComposition.Point(21, true, 0)
                    })
                );
                samples.Add(
                    5, new Sample(2, new List<IntervalComposition.Point>()
                    {
                        new IntervalComposition.Point(1, false, 1),
                        new IntervalComposition.Point(2, false, 2),
                        new IntervalComposition.Point(3, true, 2),
                        new IntervalComposition.Point(4, false, 2),
                        new IntervalComposition.Point(5, true, 2),
                        new IntervalComposition.Point(6, false, 2),
                        new IntervalComposition.Point(7, true, 2),
                        new IntervalComposition.Point(8, false, 2),
                        new IntervalComposition.Point(9, true, 2),
                        new IntervalComposition.Point(10, false, 2),
                        new IntervalComposition.Point(11, true, 2),
                        new IntervalComposition.Point(12, true, 1)
                    }, new List<IntervalComposition.Point>()
                    {
                        new IntervalComposition.Point(1, false, 0),
                        new IntervalComposition.Point(2, true, 0),
                        new IntervalComposition.Point(2, false, 0),
                        new IntervalComposition.Point(3, true, 0),
                        new IntervalComposition.Point(3, false, 0),
                        new IntervalComposition.Point(4, true, 0),
                        new IntervalComposition.Point(4, false, 0),
                        new IntervalComposition.Point(5, true, 0),
                        new IntervalComposition.Point(5, false, 0),
                        new IntervalComposition.Point(6, true, 0),
                        new IntervalComposition.Point(6, false, 0),
                        new IntervalComposition.Point(7, true, 0),
                        new IntervalComposition.Point(7, false, 0),
                        new IntervalComposition.Point(8, true, 0),
                        new IntervalComposition.Point(8, false, 0),
                        new IntervalComposition.Point(9, true, 0),
                        new IntervalComposition.Point(9, false, 0),
                        new IntervalComposition.Point(10, true, 0),
                        new IntervalComposition.Point(10, false, 0),
                        new IntervalComposition.Point(11, true, 0),
                        new IntervalComposition.Point(11, false, 0),
                        new IntervalComposition.Point(12, true, 0)
                    })
                );
                samples.Add(
                    6, new Sample(4, new List<IntervalComposition.Point>
                    {
                        new IntervalComposition.Point(1, false, 1),
                        new IntervalComposition.Point(5, true, 1),
                        new IntervalComposition.Point(4, false, 2),
                        new IntervalComposition.Point(6, true, 2),
                        new IntervalComposition.Point(1, false, 3),
                        new IntervalComposition.Point(5, true, 3),
                        new IntervalComposition.Point(3, false, 4),
                        new IntervalComposition.Point(5, true, 4)
                    }, new List<IntervalComposition.Point>
                    {
                        new IntervalComposition.Point(1, false, 0),
                        new IntervalComposition.Point(3, true, 0),
                        new IntervalComposition.Point(3, false, 0),
                        new IntervalComposition.Point(5, true, 0),
                        new IntervalComposition.Point(5, false, 0),
                        new IntervalComposition.Point(6, true, 0)
                    })
                );
            }
        }

        [TestMethod]
        [Ignore]
        public void Verify1()
        {
            var points = IcSamples.Samples[4].Points;
            Assert.IsTrue(IntervalComposition.VerifyPoints(points));
        }

        [TestMethod]
        [Ignore]
        public void Verify1Negative()
        {
            var points = IcSamples.Samples[4].Points;
            Assert.IsFalse(IntervalComposition.VerifyPoints(points));
        }

        [TestMethod]
        [Ignore]
        public void Verify2Negative()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(4, false, 2),
                new IntervalComposition.Point(6, true, 2),
                new IntervalComposition.Point(1, false, 3),
                new IntervalComposition.Point(5, false, 3), // <-- end should be true
                new IntervalComposition.Point(3, false, 4),
                new IntervalComposition.Point(5, true, 4)
            };
            Assert.IsFalse(IntervalComposition.VerifyPoints(points));
        }


        [TestMethod]
        [Ignore]
        public void Verify3Negative()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(2, false, 2),
                new IntervalComposition.Point(3, true, 2),
                new IntervalComposition.Point(4, false, 2),
                new IntervalComposition.Point(5, true, 2),
                new IntervalComposition.Point(6, false, 2),
                new IntervalComposition.Point(7, true, 2),
                new IntervalComposition.Point(8, false, 2),
                new IntervalComposition.Point(9, true, 2),
                new IntervalComposition.Point(10, false, 2),
                new IntervalComposition.Point(11, true, 2),
                new IntervalComposition.Point(12, true, 2) // <-- priority should be 1
            };
            Assert.IsFalse(IntervalComposition.VerifyPoints(points));
        }

        [TestMethod]
        [Ignore]
        public void VerifyEx3False()
        {
            var points = new List<IntervalComposition.Point>()
            {
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(5, false, 3),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(7, false, 4),
                new IntervalComposition.Point(7, true, 2),
                new IntervalComposition.Point(7, false, 1),
                new IntervalComposition.Point(8, false, 5),
                new IntervalComposition.Point(9, false, 7),
                new IntervalComposition.Point(9, false, 6),
                new IntervalComposition.Point(9, true, 4),
                new IntervalComposition.Point(9, true, 3),
                new IntervalComposition.Point(9, false, 2),
                new IntervalComposition.Point(10, true, 7), 
                // falta 10 true 5
                new IntervalComposition.Point(10, false, 4),
                new IntervalComposition.Point(11, true, 1),
                new IntervalComposition.Point(12, false, 7),
                new IntervalComposition.Point(12, false, 5),
                new IntervalComposition.Point(12, true, 4),
                new IntervalComposition.Point(13, true, 7),
                new IntervalComposition.Point(13, true, 6),
                new IntervalComposition.Point(13, false, 4),
                new IntervalComposition.Point(13, false, 3),
                new IntervalComposition.Point(13, true, 2),
                new IntervalComposition.Point(13, false, 1),
                new IntervalComposition.Point(14, true, 5),
                new IntervalComposition.Point(15, true, 4),
                new IntervalComposition.Point(15, false, 2),
                new IntervalComposition.Point(17, true, 3),
                new IntervalComposition.Point(17, true, 1),
                new IntervalComposition.Point(19, true, 2),
                new IntervalComposition.Point(19, false, 1),
                new IntervalComposition.Point(21, true, 1)
            };
            Assert.IsFalse(IntervalComposition.VerifyPoints(points));
        }

        private void OrderEx(int s)
        {
            var sample = IcSamples.Samples[s];
            var points = sample.Points;
            var pp = new IntervalComposition(sample.Priorities, points);
            var node = pp.getHead();
            while (true)
            {
                if (node.Next == null) break;
                Assert.IsTrue(node.Value < node.Next.Value);
                Assert.IsTrue((node.Point.Pos < node.Next.Point.Pos) ||
                    (node.Point.Pos == node.Next.Point.Pos && node.Point.Priority > node.Next.Point.Priority));
                node = node.Next;
            }
        }

        [TestMethod]
        public void OrderEx1()
        {
            OrderEx(1);
        }

        [TestMethod]
        public void OrderEx3()
        {
            OrderEx(3);
        }

        [TestMethod]
        public void OrderEx4()
        {
            OrderEx(4);
        }

        [TestMethod]
        public void OrderEx5()
        {
            OrderEx(5);
        }

        [TestMethod]
        public void OrderPath1()
        {
            var sample = IcSamples.Samples[4];
            var points = sample.Points;
            var pp = new IntervalComposition(sample.Priorities, points);
            pp.CalculateAll();
            var pathEn = pp.Path.GetEnumerator();
            Assert.IsTrue(pathEn.MoveNext());
            int count = 0;
            while (true)
            {
                count++;
                var prev = pathEn.Current;
                if (!pathEn.MoveNext()) break;
                Assert.IsTrue(pathEn.Current.Pos >= prev.Pos);
                Assert.IsTrue(pathEn.Current.Priority == prev.Priority);
                // If they are on the same spot, they have to be closing then opening
                Assert.IsTrue(pathEn.Current.Pos != prev.Pos || (pathEn.Current.Pos == prev.Pos && !pathEn.Current.End && prev.End));
            }
            Assert.AreEqual(pp.Path.Count(), count);
        }

        //[TestMethod]
        //public void NodeIndex1()
        //{
        //    var points = new List<LayeredIntervals.Point> {
        //        new LayeredIntervals.Point(9, false, 1),
        //        new LayeredIntervals.Point(7, true, 2),
        //        new LayeredIntervals.Point(6, false, 3),
        //        new LayeredIntervals.Point(5, true, 1),
        //        new LayeredIntervals.Point(3, false, 2),
        //        new LayeredIntervals.Point(1, false, 1)
        //    };
        //    var pp = new LayeredIntervals(5, points);
        //    foreach (var point in points)
        //    {
        //        int value = pp.getPointValue(point);
        //        Assert.AreEqual(value, pp.getIndexedNode(value).Value);
        //    }
        //    var node = pp.getHead();
        //    do
        //    {
        //        Assert.AreEqual(node, pp.getIndexedNode(node.Value));
        //        Assert.AreEqual(node.Value, pp.getIndexedNode(node.Value).Value);
        //        node = node.Next;
        //    }
        //    while (node.Next != null);
        //}

        [TestMethod]
        public void CalculateEx4()
        {
            CalculateEx(4);
        }

        [TestMethod]
        public void CalculateEx3()
        {
            CalculateEx(3);
        }

        [TestMethod]
        public void CalculateEx1()
        {
            CalculateEx(1);
        }

        [TestMethod]
        public void CalculateEx5()
        {
            CalculateEx(5);
        }

        [TestMethod]
        public void CalculateEx4A()
        {
            CalculateEx(6);
        }

        private void ComparePoints(IEnumerable<IntervalComposition.Point> pointsShould, IEnumerable<IntervalComposition.Point> pointsAre)
        {
            Assert.IsTrue(pointsAre.Count() > 0);
            Assert.AreEqual(pointsShould.Count(), pointsAre.Count());
            var pathShouldEn = pointsShould.GetEnumerator();
            var pathIsEn = pointsAre.GetEnumerator();
            while (pathIsEn.MoveNext())
            {
                Assert.IsTrue(pathShouldEn.MoveNext());
                Assert.AreEqual(pathShouldEn.Current.End, pathIsEn.Current.End);
                Assert.AreEqual(pathShouldEn.Current.Pos, pathIsEn.Current.Pos);
                Assert.AreEqual(pathShouldEn.Current.End, pathIsEn.Current.End);
            }
        }

        private void ComparePointsNodes(IEnumerable<IntervalComposition.Point> points, IntervalComposition.OrderedNode node, int countShould)
        {
            int count = 0;
            var pointsEn = points.GetEnumerator();
            while (pointsEn.MoveNext())
            {
                count++;
                Assert.AreEqual(pointsEn.Current.Pos, node.Point.Pos);
                Assert.AreEqual(pointsEn.Current.End, node.Point.End);
                Assert.AreEqual(pointsEn.Current.Priority, node.Point.Priority);
                if (node.Next == null) break;
                node = node.Next;
            }
            Assert.AreEqual(count, count);
        }

        private void ComparePaths(IEnumerable<IntervalComposition.Point> pathShould, IEnumerable<IntervalComposition.Point> pathIs)
        {
            Assert.IsTrue(pathIs.Count() > 0);
            Assert.AreEqual(pathShould.Count(), pathIs.Count());
            bool end = false;
            var pathShouldEn = pathShould.GetEnumerator();
            var pathIsEn = pathIs.GetEnumerator();
            while (pathIsEn.MoveNext())
            {
                Assert.IsTrue(pathShouldEn.MoveNext());
                Assert.AreEqual(end, pathIsEn.Current.End);
                Assert.AreEqual(pathShouldEn.Current.Pos, pathIsEn.Current.Pos);
                Assert.AreEqual(pathShouldEn.Current.End, pathIsEn.Current.End);
                end = !end;
            }
        }

        private void ComparePathsNegative(IEnumerable<IntervalComposition.Point> pathShould, IEnumerable<IntervalComposition.Point> pathIs)
        {
            Assert.IsTrue(pathIs.Count() > 0);
            Assert.AreEqual(pathShould.Count(), pathIs.Count());
            bool end = false;
            bool anyDiff = false;
            var pathShouldEn = pathShould.GetEnumerator();
            var pathIsEn = pathIs.GetEnumerator();
            while (pathIsEn.MoveNext())
            {
                if (!end != pathIsEn.Current.End || pathShouldEn.Current.Pos != pathIsEn.Current.Pos ||
                    pathShouldEn.Current.End != pathIsEn.Current.End)
                {
                    anyDiff = true;
                    break;
                }
                end = !end;
            }
            Assert.IsTrue(anyDiff);
        }

        private void CalculateEx(int s)
        {
            var sample = IcSamples.Samples[s];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();
            ComparePaths(sample.Path, pp.Path);
        }

        [TestMethod]
        public void PointValueExact1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 3),
                new IntervalComposition.Point(1, false, 2),
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(2, true, 3),
                new IntervalComposition.Point(2, true, 2),
                new IntervalComposition.Point(2, true, 1),
                new IntervalComposition.Point(2, false, 3),
                new IntervalComposition.Point(2, false, 2),
                new IntervalComposition.Point(2, false, 1),
                new IntervalComposition.Point(3, true, 3),
                new IntervalComposition.Point(3, true, 2),
                new IntervalComposition.Point(3, true, 1)
            };
            var pp = new IntervalComposition(3, points);

            var valuesCompare = new List<int> {
                1, 3, 5,
                6, 8, 10,
                7, 9, 11,
                12, 14, 16
            };

            var values = points.Select(p => pp.getPointValue(p)).ToList();

            for (int i = 0; i < points.Count; i++)
            {
                Assert.AreEqual(valuesCompare[i], values[i]);
            }
        }

        [TestMethod]
        public void PointValueByEyeProperties1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 3),
                new IntervalComposition.Point(1, false, 2),
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(2, true, 3),
                new IntervalComposition.Point(2, false, 3),
                new IntervalComposition.Point(2, true, 2),
                new IntervalComposition.Point(2, false, 2),
                new IntervalComposition.Point(2, true, 1),
                new IntervalComposition.Point(2, false, 1),
                new IntervalComposition.Point(3, true, 3),
                new IntervalComposition.Point(3, true, 2),
                new IntervalComposition.Point(3, true, 1)
            };
            var pp = new IntervalComposition(3, points);

            var values = points.Select(p => pp.getPointValue(p)).ToList();
            for (int i = 0; i < values.Count; i++)
            {
                bool notEnd = i < values.Count - 1;
                bool posLower = notEnd && points[i + 1].Pos > points[i].Pos;
                bool valueLower = notEnd && values[i + 1] > values[i];
                bool posPrioEqual = notEnd && points[i + 1].Pos == points[i].Pos && points[i + 1].Priority == points[i].Priority;
                bool valueOneLess = notEnd && values[i + 1] == values[i] + 1;
                // (Comparing to the next) Either position is lower and value too, lower, 
                // or position and priority are same and value is one less.
                Assert.IsTrue(!notEnd || valueLower);
                Assert.IsTrue(!notEnd || !posPrioEqual || posPrioEqual && valueOneLess);
            }
        }

        [TestMethod]
        public void PointValueBySortProperties1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 3),
                new IntervalComposition.Point(2, true, 2),
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(3, true, 1),
                new IntervalComposition.Point(2, true, 3),
                new IntervalComposition.Point(2, false, 3),
                new IntervalComposition.Point(1, false, 2),
                new IntervalComposition.Point(2, true, 1),
                new IntervalComposition.Point(3, true, 2),
                new IntervalComposition.Point(2, false, 1),
                new IntervalComposition.Point(2, false, 2),
                new IntervalComposition.Point(3, true, 3)
            };
            var pp = new IntervalComposition(3, points);
            var sortedPoints = pp.sortPoints(points);

            var sortedPointsEn = sortedPoints.GetEnumerator();
            Assert.IsTrue(sortedPointsEn.MoveNext());
            while (true)
            {
                var prev = sortedPointsEn.Current;
                int prevValue = pp.getPointValue(prev);
                if (!sortedPointsEn.MoveNext()) break;
                int currValue = pp.getPointValue(sortedPointsEn.Current);
                bool posLower = sortedPointsEn.Current.Pos > prev.Pos;
                bool valueLower = currValue > prevValue;
                bool posPrioEqual = sortedPointsEn.Current.Pos == prev.Pos && sortedPointsEn.Current.Priority == prev.Priority;
                bool valueOneLess = currValue == prevValue + 1;
                // (Comparing to the next) Either position is lower and value too, lower, 
                // or position and priority are same and value is one less.
                Assert.IsTrue(valueLower);
                Assert.IsTrue(!posPrioEqual || posPrioEqual && valueOneLess);
            }
        }

        [TestMethod]
        public void PointValuePathVisualProperties1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 0),
                new IntervalComposition.Point(2, true, 0),
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(3, false, 0),
                new IntervalComposition.Point(4, true, 0),
                new IntervalComposition.Point(4, false, 0),
                new IntervalComposition.Point(5, true, 0)
            };
            var pp = new IntervalComposition(3, points);

            var values = points.Select(p => pp.getPointValue(p)).ToList();
            for (int i = 0; i < values.Count; i++)
            {
                bool notEnd = i < values.Count - 1;
                bool posLower = notEnd && points[i + 1].Pos > points[i].Pos;
                bool valueLower = notEnd && values[i + 1] > values[i];
                bool posEqual = notEnd && points[i + 1].Pos == points[i].Pos;
                bool valueOneLess = notEnd && values[i + 1] == values[i] + 1;
                // (Comparing to the next) Either position is lower and value too, lower, 
                // or position is same and value is one less.
                Assert.IsTrue(!notEnd || valueLower);
                Assert.IsTrue(!notEnd || posLower || posEqual && valueOneLess);
            }
        }

        [TestMethod]
        public void PointValuePathBySortProperties1()
        {
            var points = new List<IntervalComposition.Point>
            {
                new IntervalComposition.Point(4, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(5, true, 0),
                new IntervalComposition.Point(3, false, 0),
                new IntervalComposition.Point(4, true, 0),
                new IntervalComposition.Point(1, false, 0),
                new IntervalComposition.Point(2, true, 0)
            };
            var pp = new IntervalComposition(3, points);
            var sortedPoints = pp.sortPoints(points);

            var sortedPointsEn = sortedPoints.GetEnumerator();
            Assert.IsTrue(sortedPointsEn.MoveNext());
            while (true)
            {
                var prev = sortedPointsEn.Current;
                int prevValue = pp.getPointValue(prev);
                if (!sortedPointsEn.MoveNext()) break;
                int currValue = pp.getPointValue(sortedPointsEn.Current);
                bool posLower = sortedPointsEn.Current.Pos > prev.Pos;
                bool valueLower = currValue > prevValue;
                bool posEqual = sortedPointsEn.Current.Pos == prev.Pos;
                bool valueOneLess = currValue == prevValue + 1;
                // (Comparing to the next) Either position is lower and value too, lower, 
                // or position is same and value is one less.
                Assert.IsTrue(valueLower);
                Assert.IsTrue(posLower || posEqual && valueOneLess);
            }
        }

        [TestMethod]
        public void PointValuePathExact1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 0),
                new IntervalComposition.Point(2, true, 0),
                new IntervalComposition.Point(3, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(5, false, 0),
                new IntervalComposition.Point(7, true, 0)
            };
            var pp = new IntervalComposition(1, points);
            var sortedPoints = pp.sortPoints(points);

            // TODO: these values (for a path) are a mystery. 
            // But not relevant right now as the order is ok.
            var valuesCompare = new List<int> {
                3, 4, 6, 7, 11, 14
            };

            var values = sortedPoints.Select(p =>
               pp.getPointValue(p)
            ).ToList();

            for (int i = 0; i < sortedPoints.Count; i++)
            {
                Assert.AreEqual(valuesCompare[i], values[i]);
            }
        }

        [TestMethod]
        public void SortPoints1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(9, false, 1),
                new IntervalComposition.Point(7, true, 2),
                new IntervalComposition.Point(3, false, 3),
                new IntervalComposition.Point(3, true, 3),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(1, false, 1)
            };
            var pp = new IntervalComposition(3, points);

            var sortedPoints = pp.sortPoints(points);

            var comparison = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(3, true, 3),
                new IntervalComposition.Point(3, false, 3),
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(7, true, 2),
                new IntervalComposition.Point(9, false, 1)
            };

            int i = 0;
            foreach (var sortedPoint in sortedPoints)
            {
                // TODO: implement point equality
                Assert.AreEqual(comparison[i].Pos, sortedPoint.Pos);
                Assert.AreEqual(comparison[i].End, sortedPoint.End);
                Assert.AreEqual(comparison[i].Priority, sortedPoint.Priority);
                i++;
            }
        }

        [TestMethod]
        public void SortPoints2()
        {
            var points = new List<IntervalComposition.Point>() {
                new IntervalComposition.Point(21, true, 1),
                new IntervalComposition.Point(21, true, 2),
                new IntervalComposition.Point(20, true, 3),
                new IntervalComposition.Point(19, true, 4),
                new IntervalComposition.Point(18, false, 4),
                new IntervalComposition.Point(18, true, 5),
                new IntervalComposition.Point(17, false, 2),
                new IntervalComposition.Point(16, false, 3),
                new IntervalComposition.Point(15, false, 1),
                new IntervalComposition.Point(14, true, 2),
                new IntervalComposition.Point(14, false, 5),
                new IntervalComposition.Point(13, true, 1),
                new IntervalComposition.Point(13, true, 3),
                new IntervalComposition.Point(13, true, 4),
                new IntervalComposition.Point(12, false, 2),
                new IntervalComposition.Point(11, false, 4),
                new IntervalComposition.Point(9, false, 1),
                new IntervalComposition.Point(7, true, 2),
                new IntervalComposition.Point(6, false, 3),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(1, false, 1)
            };
            var pp = new IntervalComposition(5, points);

            var sortedPoints = pp.sortPoints(points);

            var comparison = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 1),
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(6, false, 3),
                new IntervalComposition.Point(7, true, 2),
                new IntervalComposition.Point(9, false, 1),
                new IntervalComposition.Point(11, false, 4),
                new IntervalComposition.Point(12, false, 2),
                new IntervalComposition.Point(13, true, 4),
                new IntervalComposition.Point(13, true, 3),
                new IntervalComposition.Point(13, true, 1),
                new IntervalComposition.Point(14, false, 5),
                new IntervalComposition.Point(14, true, 2),
                new IntervalComposition.Point(15, false, 1),
                new IntervalComposition.Point(16, false, 3),
                new IntervalComposition.Point(17, false, 2),
                new IntervalComposition.Point(18, true, 5),
                new IntervalComposition.Point(18, false, 4),
                new IntervalComposition.Point(19, true, 4),
                new IntervalComposition.Point(20, true, 3),
                new IntervalComposition.Point(21, true, 2),
                new IntervalComposition.Point(21, true, 1)
            };

            int i = 0;
            foreach (var sortedPoint in sortedPoints)
            {
                Assert.AreEqual(comparison[i].Pos, sortedPoint.Pos);
                Assert.AreEqual(comparison[i].End, sortedPoint.End);
                Assert.AreEqual(comparison[i].Priority, sortedPoint.Priority);
                i++;
            }
        }

        [TestMethod]
        public void SortPointsPath()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(2, true, 0),
                new IntervalComposition.Point(4, false, 0),
                new IntervalComposition.Point(6, true, 0),
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(5, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(5, true, 0),
                new IntervalComposition.Point(1, false, 0)
            };
            var pp = new IntervalComposition(1, points);

            var sortedPoints = pp.sortPoints(points);

            var comparison = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(1, false, 0),
                new IntervalComposition.Point(2, true, 0),
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(4, false, 0),
                new IntervalComposition.Point(5, true, 0),
                new IntervalComposition.Point(5, false, 0),
                new IntervalComposition.Point(6, true, 0)
            };

            int i = 0;
            foreach (var sortedPoint in sortedPoints)
            {
                Assert.AreEqual(comparison[i].Pos, sortedPoint.Pos);
                Assert.AreEqual(comparison[i].End, sortedPoint.End);
                Assert.AreEqual(comparison[i].Priority, sortedPoint.Priority);
                i++;
            }
        }

        [TestMethod]
        public void ChangeNodePos1()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(9, false, 1),
                new IntervalComposition.Point(7, true, 2), // <-- pos to 4
                new IntervalComposition.Point(6, false, 3),
                new IntervalComposition.Point(5, true, 1),
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(1, false, 1)
            };
            var pp = new IntervalComposition(3, points);

            var changeNodePos = pp.getChangeNodePos(points[1], 4);
            Assert.AreEqual(true, changeNodePos.Inverted);
            Assert.AreEqual(4, changeNodePos.AffectedFrom);
            Assert.AreEqual(7, changeNodePos.AffectedTo);
            //Assert.AreEqual(4, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(true, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Priority);

            var newPoints = pp.sortPoints(points);
            Assert.AreEqual(1, newPoints.RemoveWhere(p => p.Pos == 7 && p.End && p.Priority == 2));
            newPoints.Add(new IntervalComposition.Point(4, true, 2));

            ComparePointsNodes(newPoints, pp.getHead(), 6);
        }

        [TestMethod]
        public void ChangeNodePos2()
        {
            var points = new List<IntervalComposition.Point> {
                new IntervalComposition.Point(9, false, 1), // <-- pos to 1
                new IntervalComposition.Point(7, true, 2), // <-- pos to 2
                new IntervalComposition.Point(6, false, 3),
                new IntervalComposition.Point(5, true, 1), // <-- pos to 6
                new IntervalComposition.Point(3, false, 2),
                new IntervalComposition.Point(1, false, 1) // <-- pos to 10
            };
            var pp = new IntervalComposition(3, points);

            var changeNodePos = pp.getChangeNodePos(points[0], 1);
            Assert.AreEqual(true, changeNodePos.Inverted);
            Assert.AreEqual(1, changeNodePos.AffectedFrom);
            Assert.AreEqual(9, changeNodePos.AffectedTo);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Priority);

            changeNodePos = pp.getChangeNodePos(points[1], 2);
            Assert.AreEqual(true, changeNodePos.Inverted);
            Assert.AreEqual(2, changeNodePos.AffectedFrom);
            Assert.AreEqual(7, changeNodePos.AffectedTo);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(true, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Priority);

            changeNodePos = pp.getChangeNodePos(points[3], 6);
            Assert.AreEqual(false, changeNodePos.Inverted);
            Assert.AreEqual(5, changeNodePos.AffectedFrom);
            Assert.AreEqual(6, changeNodePos.AffectedTo);
            //Assert.AreEqual(3, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Priority);

            changeNodePos = pp.getChangeNodePos(points[5], 10);
            Assert.AreEqual(false, changeNodePos.Inverted);
            Assert.AreEqual(1, changeNodePos.AffectedFrom);
            Assert.AreEqual(10, changeNodePos.AffectedTo);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Priority);

            var newPoints = pp.sortPoints(points);
            Assert.AreEqual(4, newPoints.RemoveWhere(p =>
                (p.Pos == 9 && !p.End && p.Priority == 1) ||
                (p.Pos == 7 && p.End && p.Priority == 2) ||
                (p.Pos == 5 && p.End && p.Priority == 1) ||
                (p.Pos == 1 && !p.End && p.Priority == 1)
            ));
            newPoints.Add(new IntervalComposition.Point(1, false, 1));
            newPoints.Add(new IntervalComposition.Point(2, true, 2));
            newPoints.Add(new IntervalComposition.Point(6, true, 1));
            newPoints.Add(new IntervalComposition.Point(10, false, 1));

            ComparePointsNodes(newPoints, pp.getHead(), 6);
        }

        [TestMethod]
        public void ChangeNodePos3()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);

            var point = sample.Points.Single(p => p.Pos == 11 && !p.End && p.Priority == 4);
            var changeNodePos = pp.getChangeNodePos(point, 8);
            Assert.AreEqual(true, changeNodePos.Inverted);
            Assert.AreEqual(8, changeNodePos.AffectedFrom);
            Assert.AreEqual(11, changeNodePos.AffectedTo);
            //Assert.AreEqual(8, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(4, changeNodePos.StopNode.Point.Priority);

            var newPoints = pp.sortPoints(sample.Points.ToList());
            newPoints.RemoveWhere(p => p.Pos == point.Pos && p.End == point.End && p.Priority == point.Priority);
            newPoints.Add(new IntervalComposition.Point(8, point.End, point.Priority));

            ComparePointsNodes(newPoints, pp.getHead(), newPoints.Count);
        }

        [TestMethod]
        public void ChangeNodePosEx4A1()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 3 && !p.End && p.Priority == 4);
            var result = pp.getChangeNodePos(point, 2);

            Assert.AreEqual(true, result.Inverted);
            Assert.AreEqual(2, result.AffectedFrom);
            Assert.AreEqual(3, result.AffectedTo);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(4, changeNodePos.StopNode.Point.Priority);

            var newPoints = pp.sortPoints(sample.Points.ToList());
            newPoints.RemoveWhere(p => p.Pos == point.Pos && p.End == point.End && p.Priority == point.Priority);
            newPoints.Add(new IntervalComposition.Point(2, point.End, point.Priority));

            ComparePointsNodes(newPoints, pp.getHead(), newPoints.Count);
        }

        [TestMethod]
        public void ChangeNodePosEx4A2Inverted()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 1 && !p.End && p.Priority == 3);
            var changeNodePos = pp.getChangeNodePos(point, 4);
            Assert.AreEqual(false, changeNodePos.Inverted);
            Assert.AreEqual(1, changeNodePos.AffectedFrom);
            Assert.AreEqual(4, changeNodePos.AffectedTo);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Priority);
        }

        [TestMethod]
        public void ChangeNodePosEx4A3Inverted()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 4 && !p.End && p.Priority == 2);
            var changeNodePos = pp.getChangeNodePos(point, 2);
            Assert.AreEqual(true, changeNodePos.Inverted);
            Assert.AreEqual(2, changeNodePos.AffectedFrom);
            Assert.AreEqual(4, changeNodePos.AffectedTo);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Priority);
        }

        [TestMethod]
        public void ChangeNodePosEx5()
        {
            var sample = IcSamples.Samples[5];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // first segment to 3
            var pointToChange = sample.Points.Single(p => p.Pos == 12 && p.End && p.Priority == 1);
            var changeNodePos = pp.getChangeNodePos(pointToChange, 3);
            Assert.AreEqual(true, changeNodePos.Inverted);
            Assert.AreEqual(3, changeNodePos.AffectedFrom);
            Assert.AreEqual(12, changeNodePos.AffectedTo);
            //Assert.AreEqual(3, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(true, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(1, changeNodePos.StopNode.Point.Priority);
        }

        [TestMethod]
        public void ChangeNodePosEx5Inverted()
        {
            var sample = IcSamples.Samples[5];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // first segment from 10
            var pointToChange = sample.Points.Single(p => p.Pos == 1 && !p.End && p.Priority == 1);
            var changeNodePos = pp.getChangeNodePos(pointToChange, 10);
            Assert.AreEqual(false, changeNodePos.Inverted);
            Assert.AreEqual(1, changeNodePos.AffectedFrom);
            Assert.AreEqual(10, changeNodePos.AffectedTo);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Pos);
            //Assert.AreEqual(false, changeNodePos.StopNode.Point.End);
            //Assert.AreEqual(2, changeNodePos.StopNode.Point.Priority);
        }

        [TestMethod]
        public void RecalculateAll1()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);

            // 3 to the left
            var pointToChange = sample.Points.Single(p => p.Pos == 11 && !p.End && p.Priority == 4);
            pp.getChangeNodePos(pointToChange, 8);

            // 2 to the right
            pointToChange = sample.Points.Single(p => p.Pos == 18 && p.End && p.Priority == 5);
            pp.getChangeNodePos(pointToChange, 20);

            pp.CalculateAll();

            Assert.IsTrue(pp.Path.GetEnumerator().MoveNext());
            var path = sample.Path.ToList();
            path[5] = new IntervalComposition.Point(8, path[5].End, path[5].Priority);
            path[6] = new IntervalComposition.Point(8, path[6].End, path[5].Priority);
            path.RemoveAll(p => p.Pos == 18 || p.Pos == 19);

            ComparePaths(path, pp.Path);
        }

        [TestMethod]
        public void RecalculateAll1Negative()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            IntervalComposition.Point pointToChange = sample.Points.Single(p => p.Pos == 11 && !p.End &&
                p.Priority == 4);
            pp.getChangeNodePos(pointToChange, 8);

            Assert.IsTrue(pp.Path.GetEnumerator().MoveNext());
            var path = sample.Path.ToList();
            path[5] = new IntervalComposition.Point(8, path[5].End, path[5].Priority);
            path[6] = new IntervalComposition.Point(8, path[6].End, path[5].Priority);

            ComparePathsNegative(path, pp.Path);
        }

        [TestMethod]
        public void CalculatePartialEx4A1()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 3 && !p.End && p.Priority == 4);
            int pathChanges;
            pp.getChangePos(point, 2, out pathChanges);
            Assert.AreEqual(4, pathChanges);
            var path = new List<IntervalComposition.Point>
            {
                new IntervalComposition.Point(1, false, 0),
                new IntervalComposition.Point(2, true, 0),
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(5, true, 0),
                new IntervalComposition.Point(5, false, 0),
                new IntervalComposition.Point(6, true, 0)
            };
            ComparePaths(path, pp.Path);
        }

        [TestMethod]
        public void CalculatePartialEx4A2()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 1 && !p.End && p.Priority == 3);
            int pathChanges;
            pp.getChangePos(point, 4, out pathChanges);
            ComparePaths(sample.Path, pp.Path);
        }

        [TestMethod]
        [Ignore]
        public void CalculatePartialOcclusionEx4A2()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 1 && !p.End && p.Priority == 3);
            int pathChanges;
            pp.getChangePos(point, 4, out pathChanges);
            Assert.AreEqual(0, pathChanges);
        }

        [TestMethod]
        [Ignore]
        public void CalculatePartialOcclusionEx4A2Negative()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 1 && !p.End && p.Priority == 3);
            int pathChanges;
            pp.getChangePos(point, 4, out pathChanges, false);
            Assert.AreEqual(6, pathChanges);
        }

        [TestMethod]
        public void CalculatePartialEx4A3()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 4 && !p.End && p.Priority == 2);
            int pathChanges;
            pp.getChangePos(point, 2, out pathChanges);
            ComparePaths(sample.Path, pp.Path);
        }

        [TestMethod]
        [Ignore]
        public void CalculatePartialOcclusionEx4A3()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 4 && !p.End && p.Priority == 2);
            int pathChanges;
            pp.getChangePos(point, 2, out pathChanges);
            Assert.AreEqual(0, pathChanges);
        }

        [TestMethod]
        [Ignore]
        public void CalculatePartialOcclusionEx4A3Negative()
        {
            var sample = IcSamples.Samples[6];
            var pp = new IntervalComposition(4, sample.Points);
            pp.CalculateAll();
            var point = sample.Points.Single(p => p.Pos == 4 && !p.End && p.Priority == 2);
            int pathChanges;
            pp.getChangePos(point, 2, out pathChanges, false);
            Assert.AreEqual(4, pathChanges);
        }

        [TestMethod]
        public void CalculatePartialEx4()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // 7 3 to the left
            var pointToChange = sample.Points.Single(p => p.Pos == 11 && !p.End && p.Priority == 4);
            int pathChanges;
            pp.getChangePos(pointToChange, 8, out pathChanges);
            Assert.AreEqual(4, pathChanges);

            var path = sample.Path.ToList();
            path[5] = new IntervalComposition.Point(8, path[5].End, path[5].Priority);
            path[6] = new IntervalComposition.Point(8, path[6].End, path[5].Priority);

            ComparePaths(path, pp.Path);
        }

        [TestMethod]
        public void CalculatePartialEx4_2()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // 8 6 to the left
            var pointToChange = sample.Points.Single(p => p.Pos == 12 && !p.End && p.Priority == 2);
            int pathChanges;
            pp.getChangePos(pointToChange, 6, out pathChanges);

            ComparePaths(sample.Path, pp.Path);
        }

        [TestMethod]
        [Ignore]
        public void CalculatePartialOcclusionEx4_2()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // 8 6 to the left
            var pointToChange = sample.Points.Single(p => p.Pos == 12 && !p.End && p.Priority == 2);
            int pathChanges;
            pp.getChangePos(pointToChange, 6, out pathChanges);
            Assert.AreEqual(0, pathChanges);
        }

        [TestMethod]
        [Ignore]
        public void CalculatePartialOcclusionEx4_2Negative()
        {
            var sample = IcSamples.Samples[4];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // 8 6 to the left
            var pointToChange = sample.Points.Single(p => p.Pos == 12 && !p.End && p.Priority == 2);
            int pathChanges;
            pp.getChangePos(pointToChange, 6, out pathChanges, false);
            Assert.AreEqual(8, pathChanges);
        }

        [TestMethod]
        public void CalculatePartialEx5()
        {
            var sample = IcSamples.Samples[5];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // first segment to 3
            var pointToChange = sample.Points.Single(p => p.Pos == 12 && p.End && p.Priority == 1);
            pp.ChangePos(pointToChange, 3);

            var path = new List<IntervalComposition.Point>()
            {
                new IntervalComposition.Point(1, false, 0),
                new IntervalComposition.Point(2, true, 0),
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(4, false, 0),
                new IntervalComposition.Point(5, true, 0),
                new IntervalComposition.Point(6, false, 0),
                new IntervalComposition.Point(7, true, 0),
                new IntervalComposition.Point(8, false, 0),
                new IntervalComposition.Point(9, true, 0),
                new IntervalComposition.Point(10, false, 0),
                new IntervalComposition.Point(11, true, 0)
            };

            ComparePaths(path, pp.Path);
        }

        [TestMethod]
        public void CalculatePartialEx5Inverted()
        {
            var sample = IcSamples.Samples[5];
            var pp = new IntervalComposition(sample.Priorities, sample.Points);
            pp.CalculateAll();

            // first segment from 10
            var pointToChange = sample.Points.Single(p => p.Pos == 1 && !p.End && p.Priority == 1);
            pp.ChangePos(pointToChange, 10);

            var path = new List<IntervalComposition.Point>()
            {
                new IntervalComposition.Point(2, false, 0),
                new IntervalComposition.Point(3, true, 0),
                new IntervalComposition.Point(4, false, 0),
                new IntervalComposition.Point(5, true, 0),
                new IntervalComposition.Point(6, false, 0),
                new IntervalComposition.Point(7, true, 0),
                new IntervalComposition.Point(8, false, 0),
                new IntervalComposition.Point(9, true, 0),
                new IntervalComposition.Point(10, false, 0),
                new IntervalComposition.Point(11, true, 0),
                new IntervalComposition.Point(11, false, 0),
                new IntervalComposition.Point(12, true, 0)
            };

            ComparePaths(path, pp.Path);
        }
    }
}
