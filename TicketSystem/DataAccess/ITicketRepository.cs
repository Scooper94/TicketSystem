using System.Collections;
using System.Windows.Documents;
using TicketSystem.Models;
using System;
using System.Collections.Generic;

namespace TicketSystem.DataAccess
{
    public interface ITicketRepository
    {
        ITicket GetByID(int ID);
        List<ITicket> GetAll();
        void Save(ITicket ticket);
        void AddMessage(int ID, IMessage message);
    }
}