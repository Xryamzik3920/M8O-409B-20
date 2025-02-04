﻿namespace Numerics5
{
    internal class Issue
    {
        public BaseExpression BaseExpression { get; set; }
        public LeftBorderExpression LeftBorderExpression { get; set; }
        public RightBorderExpression RightBorderExpression { get; set; }
        public StartExpression StartExpression { get; set; }
        public IssueParameters Parameters { get; set; }
        public AnalyticalExpression AnalyticalExpression { get; set; }
    }
}
