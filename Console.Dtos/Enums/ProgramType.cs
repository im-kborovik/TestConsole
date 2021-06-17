namespace Skynet.Dtos.Enums
{
    /// <summary>
    ///  Imported with small change. In Previous version type was integer and "All" was -1.
    /// </summary>
    public enum ProgramType : byte
    {
        All = 2,  //was -1
        None = 0,
        Fixed = 1,
        Arm = 3
    }
}
