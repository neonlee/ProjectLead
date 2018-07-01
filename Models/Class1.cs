using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConnectLead.Models
{
    public class ConnectLead
    {
    }

    public class ConnectLeadDBContext : DbContext
    {
        public DbSet<ConnectLead> connectlead { get; set; }
    }


}