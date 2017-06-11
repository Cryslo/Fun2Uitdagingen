using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fun2Uitdagingen.Logic;

namespace Fun2Uitdagingen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crt_char_btn_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != null)
            {
                int classid;
                int raceid;
                string name;
                classid = combo_class.SelectedIndex;
                raceid = combo_race.SelectedIndex + 1;
                name = txt_name.Text;
                DBO.AddCharacter(classid,raceid,name);
                GetCharacters();
            }
            else
            {
                MessageBox.Show("Insert name");
            }
        }

        private void refresh_dg_Click(object sender, EventArgs e)
        {
            GetCharacters();
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            DBO.ExecuteRepairDurability(Convert.ToInt32(nud_repair.Value));
            GetItems();
        }

        private void btn_damage_Click(object sender, EventArgs e)
        {
            DBO.ExecuteDamageToItem(Convert.ToInt32(nud_damage.Value));
            GetItems();
        }

        private void btn_getitems_Click(object sender, EventArgs e)
        {
            GetItems();
        }

        private void dg_sql_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetItems()
        {
            string query = "Select itm.ItemID, itm.Name, itm.Durability from Item itm";
            dg_sql.DataSource = DBO.GetCharactersDataTable(query);
        }

        private void GetCharacters()
        {
            string query = "Select distinct ch.CharacterID, ch.Level, ch.Name, rc.Name, cl.Name, COALESCE(swpn.Name, 'Nog geen item.') As Weapon," +
                           "COALESCE(sarmor.Name, 'Nog geen item.') As Armor," +
                           "COALESCE(sshield.Name, 'Nog geen item.') As Shield " +
                           "from character ch " +
                           "join Race rc " +
                           "on rc.RaceID = ch.RaceID " +
                           "join Class cl " +
                           "on cl.ClassID = ch.ClassID " +
                           "left join Inventory inv " +
                           "on inv.CharacterID = ch.CharacterID " +
                           "left join Item swpn " +
                           "on swpn.ItemID = ch.WeaponID " +
                           "left join Item sarmor " +
                           "on sarmor.ItemID = ch.ArmorID " +
                           "left join Item sshield " +
                           "on sshield.ItemID = cl.StartShieldID";
            dg_sql.DataSource = DBO.GetCharactersDataTable(query);
            dg_sql.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_SetLevel_Click(object sender, EventArgs e)
        {
            DBO.SetLevelCharacter(Convert.ToInt32(nud_SetLevel.Value), Convert.ToInt32(nud_CharID.Value));
            GetCharacters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void getLoot_Click(object sender, EventArgs e)
        {
            int itemdropid = DBO.GetItemDrop(Convert.ToInt32(nud_CharID.Value));
            string query = "SELECT name FROM item where itemID = " + itemdropid;
            DataTable item = DBO.GetItemFromDB(query);
            dg_sql.DataSource = item;
            dg_sql.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
