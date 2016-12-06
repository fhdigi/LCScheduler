using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using LCScheduler.Data;
using SQLite;

namespace LCScheduler.Model
{
    public class AgencyResource : DatabaseService<AgencyResource>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [Ignore]
        public Color ResColor { get; set; }

        public static BindingList<AgencyResource> GetAgencyResources()
        {
            return new BindingList<AgencyResource>(GetItems().ToList());
        }
    }
}
