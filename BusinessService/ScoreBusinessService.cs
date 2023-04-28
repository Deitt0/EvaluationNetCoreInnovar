using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreTestInnovar.DataService;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.BusinessService
{
    public class ScoreBusinessService
    {
        private ScoreDataService _scoreDataService;
        public ScoreBusinessService(ScoreDataService scoreDataService){
            _scoreDataService = scoreDataService;
        }
        
        public List<Score> GetScores(){
            return _scoreDataService.GetScores();
        }

        public Score CreateScore(Score score){
            return _scoreDataService.CreateScore(score);
        }
    }
}