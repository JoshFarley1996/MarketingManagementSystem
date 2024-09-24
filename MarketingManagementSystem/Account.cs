//Account based on the household
//Client: primary contact(will be declared by the HouseholdMemberRole: Primary
//Household members: anyone in the household including the client
//Assets: all insurable items owned by the client Type:auto/Home/landlord/rent/secondary

namespace MarketingManagementSystem
{
    public class Account
    {
        //accountOwner the sales agent that is the primary contact for the client and has access to the account info
        public string accountOwner;

        public string primaryAddress;

        public string mailAddress;

        public int accountID;
    }
}
