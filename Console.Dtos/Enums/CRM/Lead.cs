namespace Skynet.Dtos.Enums.CRM
{
    
    public enum LoanType
    {
        Conventional=1,
        FHA=2,
        VA=3
    }
    public enum PropertyType
    {
        SingleFamily=1,
        MultiFamily=2,
        Condo=3,
        TownHouse=4,
        Coop=5
    }
    public enum OccupancyType
    {
        OwnerOccupied=1,
        NonOwnerOccupied=2,
        SecondHome=3
    }
    public enum RateType
    {
        YearFixed30 = 1,
        YearFixed15 = 2,
        ARM = 3,
        Unsure = 4,
        YearFixed20 = 5,
        YearFixed25 = 6,
        YearFixed10 = 7,
    }

    public enum LoanPurpose
    {
        Purchase = 1,
        Refinance = 2,
        Cashout=3,
        Construction = 4,
        ConstructionPermanent = 5,
        Other = 6
    }

    public enum CreditRating
    {
        Excellent = 1,
        Good = 2,
        Fair = 3,
        Poor = 4
    }

}