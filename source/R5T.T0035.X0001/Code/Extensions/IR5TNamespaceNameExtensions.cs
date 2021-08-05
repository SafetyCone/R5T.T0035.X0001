using System;

using R5T.T0035.X0001;


namespace System
{
    public static class IR5TNamespaceNameExtensions
    {
        public static string Value(this IR5TNamespaceName _)
        {
            return R5TNamespaceNames.R5T;
        }


        public static IR5TDaciaNamespaceName Dacia(this IR5TNamespaceName _)
        {
            return R5TDaciaNamespaceName.Instance;
        }
    }
}