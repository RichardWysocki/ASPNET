using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ClassLibrary
{
    class ClientDataAccess : IDataAccess
    {
        public IList<T> ReadData<T>(string StoredProcedure)
        {
            IList<T> members = new List<T>();
            string constr = "Data Source=DESKTOP-726BCQD;Initial Catalog=RichExample;Integrated Security=True;MultipleActiveResultSets=True";
            using (var connection = new SqlConnection(constr))
            using (var command = new SqlCommand("Client_List", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            members.Add(Mapper.Map<IDataReader, T>(reader));
                        }
                    }
            }
            return members;
        }
    }
}
