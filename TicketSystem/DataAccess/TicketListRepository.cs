using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.DataAccess
{
    public class TicketRepository : ITicketRepository
    {
        public void AddMessage(int ID, IMessage message)
        {
            throw new NotImplementedException();
        }

        public List<ITicket> GetAll()
        {
            var t = new List<ITicket>()
            {
                new Ticket(new List<IUser>(), new List<IMessage>(), 1)
                {
                    Title = "Test Ticket 1",
                    IssueDescription = "Here is a short description of issue one"
                }
                , new Ticket(new List<IUser>(), new List<IMessage>(), 2)
                {
                    Title = "Test Ticket 2",
                    IssueDescription = "Here is a short description of issue two"
                }
            };

            return t;
        }

        public ITicket GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void Save(ITicket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
