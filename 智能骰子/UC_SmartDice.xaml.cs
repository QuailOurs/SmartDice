using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TRPGTools.Model;

namespace TRPGTools
{
    /// <summary>
    /// UC_SmartDice.xaml 的交互逻辑
    /// </summary>
    public partial class UC_SmartDice : UserControl
    {
        public UC_SmartDice()
        {
            InitializeComponent();
        }

        private String previousInfo = null;
        private String previousGroupResultString = null;

        /// <summary>
        /// 窗口初始化 预读已有信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 初始化骰子总数cb_countOfDice
            ComboBox countOfDice = this.cb_countOfDice;

            for ( int i = 1; i <= 30; i++ )
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                if (i == 1)
                    item.IsSelected = true;
                countOfDice.Items.Add(item);
            }

            // 初始化骰子类型cb_diceType
            ComboBox diceType = this.cb_diceType;

            for ( int i = 2; i <= 100; i += 2 )
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = "d" + i;
                if ((string)item.Content == "d2")
                    item.IsSelected = true;
                diceType.Items.Add(item);
            }

            // 初始化骰子类型cb_throwCounter
            ComboBox throwCounter = this.cb_throwCounter;

            for ( int i = 1; i <= 10; i ++ )
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                if (i == 1)
                    item.IsSelected = true;
                throwCounter.Items.Add(item);
            }
            
        }

        /// <summary>
        /// Roll按钮响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_roll_Click(object sender, RoutedEventArgs e)
        {
            // 将已选中的 # of Dice 与 Dice Type 拼接显示在 tb_diceExpression 上
            this.tb_diceExpression.Text = this.cb_countOfDice.Text + this.cb_diceType.Text;
            // 将Roll结果显示在界面DataGrid上
            dg_rollResult.ItemsSource = getRollResult().DefaultView;
            // 计算多次投掷总点数累加和
            this.tb_total.Text = getDataGridColumnSumByIndex(this.dg_rollResult, 1).ToString();
            // 显示上一次投掷信息
            this.tb_previous.Text = previousInfo;
            previousInfo = "总点数:" + this.tb_total.Text + ", 骰子公式:" + this.tb_diceExpression.Text + ", 各骰子点:" + previousGroupResultString;
        }

        #region 功能方法

        // 获取Roll点结果集
        private DataTable getRollResult()
        {
            int Counter = System.Int32.Parse(this.cb_throwCounter.Text); // 投掷次数
            int curCountOfDice = System.Int32.Parse(this.cb_countOfDice.Text); // 骰子数
            int curDiceFaceCount = System.Int32.Parse(this.cb_diceType.Text.Split('d')[1]) + 1; // 每个骰子面数
            String curDiceExpression = this.tb_diceExpression.Text; // 当前使用的公式

            // 生成结果集
            List<DiceGroupResult> diceGroupResultList = new List<DiceGroupResult>();

            Random randoms = new Random(unchecked((int)DateTime.Now.Ticks));
            Random random = new Random(randoms.Next());
            for (int i = 0; i < Counter; i++)
            {
                DiceGroupResult diceGroupResult = new DiceGroupResult(curCountOfDice);
                diceGroupResult.GroupIndex = i + 1;

                for ( int j = 0; j < curCountOfDice; j++ )
                {
                    for ( int k = 10; k > 0; k-- )
                        diceGroupResult.GroupDicePointArray[j] = random.Next(1, curDiceFaceCount);
                }
                                 
                diceGroupResult.generateGroupResultString();
                diceGroupResult.generatePointCount();
                diceGroupResult.DiceExpression = curDiceExpression;
                diceGroupResultList.Add(diceGroupResult);
            }

            // 将结果集封装为DataTable以备显示于页面上的DataGrid
            DataTable resultDataTable = new DataTable();
            DataColumn dataColumn = null;
            dataColumn = new DataColumn("CountNum", typeof(System.Int32));
            resultDataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("PointCount", typeof(System.Int32));
            resultDataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("PointString", typeof(System.String));
            resultDataTable.Columns.Add(dataColumn);
            dataColumn = new DataColumn("DiceString", typeof(System.String));
            resultDataTable.Columns.Add(dataColumn);

            for (int i = 0; i < diceGroupResultList.Count; i++)
            {
                if (i == 0)
                {
                    previousGroupResultString = diceGroupResultList[i].GroupResultString;
                }

                resultDataTable.Rows.Add(new object[] { diceGroupResultList[i].GroupIndex
                                                      , diceGroupResultList[i].PointCount
                                                      , diceGroupResultList[i].GroupResultString
                                                      , diceGroupResultList[i].DiceExpression });
            }

            return resultDataTable;
        }

        // 获得一个随机数
        private int getRandomNum(int minValue, int maxValue)
        {
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            return random.Next(minValue, maxValue);
        }

        // 将指定的列进行累加
        private static int getDataGridColumnSumByIndex(DataGrid dataGrid,int index) 
        { 
            int result = 0; 
            //返回的结果 
            int temp = 0; 
            //中间变量 
            for (int i = 0; i < dataGrid.Items.Count;i++ ) 
            {
                DataRowView mySelectedElement = dataGrid.Items[i] as DataRowView;
                if (mySelectedElement == null)
                    continue;
                int.TryParse(mySelectedElement.Row.ItemArray[index].ToString(), out temp);
                result += temp;
            } 
            return result; 
        }
        
        #endregion

    }
}
