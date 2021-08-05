using System;

using R5T.T0035;
using R5T.T0035.X0001;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static IR5TNamespaceName R5T(this INamespaceName _)
        {
            return R5TNamespaceName.Instance;
        }
    }
}