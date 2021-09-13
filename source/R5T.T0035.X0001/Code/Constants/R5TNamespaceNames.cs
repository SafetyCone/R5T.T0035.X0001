using System;


namespace R5T.T0035.X0001
{
    public static class R5TNamespaceNames
    {
        public static string R5T => "R5T";
        public static string R5T_Dacia => Instances.NamespaceName.AppendToken(R5T, "Dacia");
        public static string R5T_Plymouth => Instances.NamespaceName.AppendToken(R5T, "Plymouth");
        public static string R5T_Plymouth_ProgramAsAService => Instances.NamespaceName.AppendToken(R5T_Plymouth, "ProgramAsAService");
        public static string R5T_T0027 => Instances.NamespaceName.AppendToken(R5T, "T0027");
        public static string R5T_T0027_T008 => Instances.NamespaceName.AppendToken(R5T_T0027, "T008");
        public static string R5T_T0027_T009 => Instances.NamespaceName.AppendToken(R5T_T0027, "T009");
        public static string R5T_T0039 => Instances.NamespaceName.AppendToken(R5T, "T0039");
        public static string R5T_T0039_T002 => Instances.NamespaceName.AppendToken(R5T_T0039, "T002");
    }
}
