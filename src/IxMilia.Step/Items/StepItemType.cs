﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace IxMilia.Step.Items
{
    public enum StepItemType
    {
        AxisPlacement2D,
        AxisPlacement3D,
        CartesianPoint,
        Circle,
        Direction,
        EdgeCurve,
        Ellipse,
        Line,
        Vector,
        Vertex
    }

    internal static class StepItemTypeExtensions
    {
        public const string Axis2Placement2DText = "AXIS2_PLACEMENT_2D";
        public const string Axis2Placement3DText = "AXIS2_PLACEMENT_3D";
        public const string CartesianPointText = "CARTESIAN_POINT";
        public const string CircleText = "CIRCLE";
        public const string DirectionText = "DIRECTION";
        public const string EdgeCurveText = "EDGE_CURVE";
        public const string EllipseText = "ELLIPSE";
        public const string LineText = "LINE";
        public const string VectorText = "VECTOR";
        public const string VertexText = "VERTEX_POINT";

        public static string GetItemTypeString(this StepItemType type)
        {
            switch (type)
            {
                case StepItemType.AxisPlacement2D:
                    return Axis2Placement2DText;
                case StepItemType.AxisPlacement3D:
                    return Axis2Placement2DText;
                case StepItemType.CartesianPoint:
                    return CartesianPointText;
                case StepItemType.Circle:
                    return CircleText;
                case StepItemType.Direction:
                    return DirectionText;
                case StepItemType.EdgeCurve:
                    return EdgeCurveText;
                case StepItemType.Ellipse:
                    return EllipseText;
                case StepItemType.Line:
                    return LineText;
                case StepItemType.Vector:
                    return VectorText;
                case StepItemType.Vertex:
                    return VertexText;
                default:
                    throw new InvalidOperationException("Unexpected item type " + type);
            }
        }
    }
}