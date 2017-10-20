using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketRogueItemEditor
{
    public partial class BonusesForm : Form
    {
        private ItemDefinition itemDefinition;

        public BonusesForm(ItemDefinition itemDefinition)
        {
            InitializeComponent();
            this.itemDefinition = itemDefinition;
            int[] bonuses = this.itemDefinition.bonuses;

            //Add rows
            bonusesGridView.Rows.Add(new object[] {"Melee Damage", bonuses[0] });
            bonusesGridView.Rows.Add(new object[] { "Magic Damage", bonuses[1] });
            bonusesGridView.Rows.Add(new object[] { "Range Damage", bonuses[2] });
            bonusesGridView.Rows.Add(new object[] { "Attack Speed", bonuses[3] });
            bonusesGridView.Rows.Add(new object[] { "Melee Defense", bonuses[4] });
            bonusesGridView.Rows.Add(new object[] { "Magic Defense", bonuses[5] });
            bonusesGridView.Rows.Add(new object[] { "Range Defense", bonuses[6] });
        }

        private void updateBonusesButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow bonusRow in this.bonusesGridView.Rows)
            {
                this.itemDefinition.bonuses[count] = Convert.ToInt32(bonusRow.Cells[1].Value);
                count++;
            }
            this.Close();
        }
    }
}
