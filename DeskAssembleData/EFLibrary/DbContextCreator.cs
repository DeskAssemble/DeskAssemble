using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/DeskAssemble.csdl|res://*/DeskAssemble.ssdl|res://*/DeskAssemble.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=DeskAssembly;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";
        public static DeskAssemblyEntities Create()
        {
            DeskAssemblyEntities context = new DeskAssemblyEntities(ConnectionString);

            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
    }
}
namespace DeskAssembleData
{
    public partial class DeskAssemblyEntities
    {
        public DeskAssemblyEntities(string connectionString) : base(connectionString)
        {

        }
    }
}