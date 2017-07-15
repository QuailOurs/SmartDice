using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPGTools.Model
{
    class DiceGroupResult
    {
        #region ***** 私有变量 *****

        /// <summary>
        /// 组索引
        /// </summary>
        private int groupIndex;

        /// <summary>
        /// 每个骰子的面数
        /// </summary>
        private int diceFaceCount;

        /// <summary>
        /// 本组骰子个数
        /// </summary>
        private int diceCount;

        /// <summary>
        /// 本组各骰子Roll点结果的数组
        /// </summary>
        private int[] groupDicePointArray;

        /// <summary>
        /// 本组骰子Roll后总点数
        /// </summary>
        private int pointCount;

        /// <summary>
        /// 本组各个骰子结果字符串
        /// </summary>
        private String groupResultString;

        /// <summary>
        /// 本组执行骰子表达式
        /// </summary>
        private String diceExpression;

        #endregion

        #region ***** 构造方法 *****
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public DiceGroupResult() { }

        /// <summary>
        /// 重构构造方法
        /// </summary>
        public DiceGroupResult(int length)
        {
            this.groupDicePointArray = new int[length];
        }

        #endregion

        #region ***** 公有属性 *****

        public int GroupIndex
        {
            get { return groupIndex; }
            set { groupIndex = value; }
        }

        public int DiceFaceCount
        {
            get { return diceFaceCount; }
            set { diceFaceCount = value; }
        }

        public int DiceCount
        {
            get { return diceCount; }
            set { diceCount = value; }
        }

        public int[] GroupDicePointArray
        {
            get { return groupDicePointArray; }
            set { groupDicePointArray = value; }
        }

        public int PointCount
        {
            get { return pointCount; }
            set { pointCount = value; }
        }

        public String GroupResultString
        {
            get { return groupResultString; }
            set { groupResultString = value; }
        }

        public String DiceExpression
        {
            get { return diceExpression; }
            set { diceExpression = value; }
        }

        #endregion

        #region ***** 私有方法 *****

        // 根据
        public void generateGroupResultString()
        {
            if (GroupDicePointArray.Length == 0)
            {
                return;
            }

            this.GroupResultString = null;

            foreach(int dicePoint in GroupDicePointArray)
            {
                this.GroupResultString += dicePoint + ", ";
            }
        }

        public void generatePointCount()
        {
            if (GroupDicePointArray.Length == 0)
            {
                return;
            }

            this.PointCount = 0;

            for (int i = 0; i < GroupDicePointArray.Length; i++ )
            {
                this.PointCount += groupDicePointArray[i];
            }
        }
        
        #endregion
    }
}
