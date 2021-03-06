﻿namespace ChessComposition.Rules
{
    public interface IRule
    {
        bool IsLegalMove(int x, int y, int dx, int dy);
        bool IsIllegalMove(int x, int y, int dx, int dy);
    }
}