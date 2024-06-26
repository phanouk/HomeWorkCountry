using HomeWorkCountry.Models;

namespace HomeWorkCountry.Data
{
    public class MemberSeed
    {
        public List<TeamMembers> member => teamMembers;
        List<TeamMembers> teamMembers = new List<TeamMembers>
        {
            new TeamMembers
            {
                Name = "John Doe",
                Gender = "Male",
                Address = "123 Main St, Anytown, USA",
                Age = 28,
                Email = "john.doe@example.com"
            },
            new TeamMembers
            {
                Name = "Jane Smith",
                Gender = "Female",
                Address = "456 Oak Ave, Sometown, USA",
                Age = 32,
                Email = "jane.smith@example.com"
            },
            new TeamMembers
            {
                Name = "Alice Johnson",
                Gender = "Female",
                Address = "789 Pine Rd, Anycity, USA",
                Age = 25,
                Email = "alice.johnson@example.com"
            },
            new TeamMembers
            {
                Name = "Bob Brown",
                Gender = "Male",
                Address = "101 Maple St, Somecity, USA",
                Age = 45,
                Email = "bob.brown@example.com"
            },
            new TeamMembers
            {
                Name = "Charlie Davis",
                Gender = "Male",
                Address = "202 Birch Blvd, Thistown, USA",
                Age = 37,
                Email = "charlie.davis@example.com"
            }
        };
    }
}
