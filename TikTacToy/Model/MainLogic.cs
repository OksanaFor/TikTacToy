using System;
using System.Collections.Generic;
using System.Linq;
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
                    conditions[index] = CellCondition.Cross;

                    return index;
                }
            }
            return -1; 
       
        }
        public int BotHardStep()
        {
            // Check if the bot can win in the next move
            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i] == CellCondition.None)
                {
                    conditions[i] = CellCondition.Cross; 
                    if (IsWin(CellCondition.Cross))
                        return i; 
                    conditions[i] = CellCondition.None; 
                }
            }

            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i] == CellCondition.None)
                {
                    conditions[i] = CellCondition.Zero; 
                    if (IsWin(CellCondition.Zero))
                    {
                        conditions[i] = CellCondition.Cross; 
                        return i;
                    }
                    conditions[i] = CellCondition.None; 
                }
            }

            if (conditions[4] == CellCondition.None)
            {
                conditions[4] = CellCondition.Cross;
                return 4;
            }
                

            int[] moveOrder = { 0, 2, 6, 8, 1, 3, 5, 7 };
            foreach (var position in moveOrder)
            {
                if (conditions[position] == CellCondition.None)
                {
                    conditions[position] = CellCondition.Cross;
                    return position;
                }
            }
              
            Random random = new Random();
            int randomIndex = -1;
            if(conditions.Any(s => s == CellCondition.None))
            {
                do
                {
                    randomIndex = random.Next(0, conditions.Count);
                } while (conditions[randomIndex] != CellCondition.None);

               
            }
            return randomIndex;

        }

        public void PlayerStep(int index)
        {
            conditions[index] = CellCondition.Zero;
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
            else if (conditions[1] == conditions[4] && conditions[4] == conditions[7] && conditions[7] == target)
                return true;
            else if (conditions[2] == conditions[5] && conditions[5] == conditions[8] && conditions[8] == target)
                return true;
            else if ((conditions[0] == conditions[4] && conditions[4] == conditions[8] && conditions[8] == target) ||
                    (conditions[2] == conditions[4] && conditions[4] == conditions[6] && conditions[6] == target))
                 return true;
            return false;

        }
        
    }
    
}
