using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        List<Happiness> happiness;
        public DataModel()
        {
            con = new SqlConnection(@"Data Source=.; Initial Catalog=World; Integrated Security=True");
            cmd = con.CreateCommand();
        }

        public List<Happiness> GetHappiness()
        {
            happiness = new List<Happiness>();

            try
            {
                cmd.CommandText = "SELECT * FROM happiness";

                cmd.Parameters.Clear();
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Happiness h = new Happiness();
                    h.Alpha = reader.GetString(0);
                    h.CountryName = reader.GetString(1);
                    h.RegionalIndicator = reader.GetString(2);
                    h.LadderScore = reader.GetDouble(3);
                    h.StandartErrorOfLadderScore = reader.GetDouble(4);
                    h.UpperWhisker = reader.GetDouble(5);
                    h.LowerWhisker = reader.GetDouble(6);
                    h.LoggedGdpPerCapita = reader.GetDouble(7);
                    h.SocialSupport = reader.GetDouble(8);
                    h.HealthyLifeExpectancy = reader.GetDouble(9);
                    h.FreedomToMakeLifeChoices = reader.GetDouble(10);
                    h.Generocity = reader.GetDouble(11);
                    h.PerceptionsOfCorruption = reader.GetDouble(12);
                    h.LadderScoreInDystopia = reader.GetDouble(13);
                    h.ExplainedByLogGdpPerCapita = reader.GetDouble(14);
                    h.ExplainedBySocialSupport = reader.GetDouble(15);
                    h.ExplainedByHealthyLifeExpectancy = reader.GetDouble(16);
                    h.ExplainedByFreedomToMakeLifeChoices = reader.GetDouble(17);
                    h.ExplainedByGenerosity = reader.GetDouble(18);
                    h.ExplainedByPerceptionsOfCorruption = reader.GetDouble(19);
                    h.DystopiaResidual = reader.GetDouble(20);
                    happiness.Add(h);

                }
                return happiness;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
