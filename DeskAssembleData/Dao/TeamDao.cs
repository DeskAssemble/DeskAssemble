using DeskAssembleData.EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData
{
    public class TeamDao : SingleKeyDao<Team, int>
    {
        protected override Expression<Func<Team, int>> KeySelector => throw new NotImplementedException();

        public List<SalesPerformanceModel> GetModel()
        {
            using (var context = DbContextCreator.Create())
            {
                List<Team> teams = context.Teams.ToList();

                var query = from x in context.Orders
                            where x.IsSale == true
                            group x by x.TeamId into g
                            select g;

                // 달성건수 추가
                List<SalesPerformanceModel> saleModels = new List<SalesPerformanceModel>();
                foreach (var g in query)
                {
                    SalesPerformanceModel model = new SalesPerformanceModel();
                    model.Type = "달성건수";
                    model.Count = g.Count();
                    model.Team = teams.Find(t => t.TeamId == g.Key).Name;

                    saleModels.Add(model);
                }


                // 목표건수 추가
                List<SalesPerformanceModel> targetModels = new List<SalesPerformanceModel>();
                foreach (var saleModel in saleModels)
                {
                    Team team = teams.Find(t => t.Name == saleModel.Team);

                    if (team == null)
                        continue;

                    SalesPerformanceModel targetModel = new SalesPerformanceModel();
                    targetModel.Type = "목표건수";
                    targetModel.Team = team.Name;
                    targetModel.Count = team.Target;

                    targetModels.Add(targetModel);
                }

                saleModels.AddRange(targetModels);

                return saleModels;
            }
        }
    }
}
