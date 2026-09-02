using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_HasRectIntersection(SDL_Rect* A, SDL_Rect* B)
        {
            return iSDL_HasRectIntersection(A, B);
        }

        internal static SDL_Bool SDL_GetRectIntersection(SDL_Rect* A, SDL_Rect* B, SDL_Rect* result)
        {
            return iSDL_GetRectIntersection(A, B, result);
        }

        internal static SDL_Bool SDL_GetRectUnion(SDL_Rect* A, SDL_Rect* B, SDL_Rect* result)
        {
            return iSDL_GetRectUnion(A, B, result);
        }

        internal static SDL_Bool SDL_GetRectEnclosingPoints(SDL_Point* points, int count, SDL_Rect* clip, SDL_Rect* result)
        {
            return iSDL_GetRectEnclosingPoints(points, count, clip, result);
        }

        internal static SDL_Bool SDL_GetRectAndLineIntersection(SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2)
        {
            return iSDL_GetRectAndLineIntersection(rect, X1, Y1, X2, Y2);
        }

        internal static SDL_Bool SDL_HasRectIntersectionFloat(SDL_FRect* A, SDL_FRect* B)
        {
            return iSDL_HasRectIntersectionFloat(A, B);
        }

        internal static SDL_Bool SDL_GetRectIntersectionFloat(SDL_FRect* A, SDL_FRect* B, SDL_FRect* result)
        {
            return iSDL_GetRectIntersectionFloat(A, B, result);
        }

        internal static SDL_Bool SDL_GetRectUnionFloat(SDL_FRect* A, SDL_FRect* B, SDL_FRect* result)
        {
            return iSDL_GetRectUnionFloat(A, B, result);
        }

        internal static SDL_Bool SDL_GetRectEnclosingPointsFloat(SDL_FPoint* points, int count, SDL_FRect* clip, SDL_FRect* result)
        {
            return iSDL_GetRectEnclosingPointsFloat(points, count, clip, result);
        }

        internal static SDL_Bool SDL_GetRectAndLineIntersectionFloat(SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2)
        {
            return iSDL_GetRectAndLineIntersectionFloat(rect, X1, Y1, X2, Y2);
        }
    }
}