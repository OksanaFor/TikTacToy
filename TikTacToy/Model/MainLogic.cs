using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TikTacToy.Common.Enums;

namespace TikTacToy.Model
{

    public class MainLogic
    {
        private List<CellCondition> conditions = new List<CellCondition>()
        { CellCondition.None, CellCondition.None, CellCondition.None,
        CellCondition.None, CellCondition.None, CellCondition.None,
        CellCondition.None, CellCondition.None, CellCondition.None,};

        public void ClearField()
        {
            for (int i = 0; i < conditions.Count; i++)
                conditions[i] = CellCondition.None;
        }

        public int BotStep()
        {
            Random random = new Random();
            while(conditions.Any(s => s == CellCondition.None))
            {
                var index = random.Next(0, conditions.Count);
                if (conditions[index] == CellCondition.None)
                {
                    conditions[index] = CellCondition.Zero;

                    return index;
                }
            }
            return -1; 
       
        }
        public int BotHardStep()
        {
            var index = 0;
                if()
        }
        public void PlayerStep(int index)
        {
            conditions[index] = CellCondition.Cross;
        }
        public bool IsWin(CellCondition target)
        {
            if (conditions[0] == conditions[1] && conditions[1] == conditions[2] && conditions[0] == target)
                return true;
            else if (conditions[3] == conditions[4] && conditions[4] == conditions[5] && conditions[5] == target)
                return true;
            else if (conditions[6] == conditions[7] && conditions[7] == conditions[8] && conditions[8] == target)
                return true;

            else if (conditions[0] == conditions[3] && conditions[3] == conditions[6] && conditions[6] == target)
                return true;
            else if (conditions[1] == conditions[5] && conditions[5] == conditions[8] && conditions[8] == target)
                return true;

            return false;
        }
    }
    
}
