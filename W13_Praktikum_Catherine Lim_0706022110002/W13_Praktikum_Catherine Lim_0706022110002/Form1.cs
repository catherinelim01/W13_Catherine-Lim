using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W13_Praktikum_Catherine_Lim_0706022110002
{
    public partial class FormPemain : Form
    {
        public FormPemain()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dataPlayer = new DataTable();
        DataTable dataNationality = new DataTable();
        DataTable dataTeamName = new DataTable();
        int PosisiSekarang = 0;

        private void FormPemain_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id, p.player_name, p.birthdate, n.nation, t.team_name , p.team_number from player p, nationality n, team t where p.nationality_id = n.nationality_id and p.team_id = t.team_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataPlayer);

            sqlQuery = "select nationality_id, nation from nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataNationality);

            comboBox_Nationality.DataSource = dataNationality;
            comboBox_Team.DisplayMember = "nation";
            comboBox_Nationality.ValueMember = "nationality_id";

            sqlQuery = "select team_id, team_name from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTeamName);

            comboBox_Team.DataSource = dataTeamName;
            comboBox_Team.DisplayMember = "team_name";
            comboBox_Team.ValueMember = "team_id";

            //textBox_PlayerID.Text = PlayerIDSebelumnya;
            //textBox_PlayerName.Text = PlayerNameSebelumnya;
            //dateTimePicker_BirthDate.Text = BirthDateSebelumnya;
            //comboBox_Nationality.ValueMember = NationalitySebelumnya;
            //comboBox_Team.ValueMember = TeamSebelumnya;
            //numericUpDown_TeamNumber.Text = TeamNumberSebelumnya;

            IsiDataPemain(0);

        }
        string PlayerIDSebelumnya, PlayerNameSebelumnya, BirthDateSebelumnya, NationalitySebelumnya, TeamSebelumnya, TeamNumberSebelumnya;

        public void IsiDataPemain(int Posisi)
        {
            textBox_PlayerID.Text = dataPlayer.Rows[Posisi][0].ToString();
            textBox_PlayerName.Text = dataPlayer.Rows[Posisi][1].ToString();
            dateTimePicker_BirthDate.Text = dataPlayer.Rows[Posisi][2].ToString();
            comboBox_Nationality.Text = dataPlayer.Rows[Posisi][3].ToString();
            comboBox_Team.Text = dataPlayer.Rows[Posisi][4].ToString();
            numericUpDown_TeamNumber.Text = dataPlayer.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }

        public void SimpanDataSebelumnya()
        {
            textBox_PlayerID.Text = PlayerIDSebelumnya;
            textBox_PlayerName.Text = PlayerNameSebelumnya;
            dateTimePicker_BirthDate.Text = BirthDateSebelumnya;
            comboBox_Nationality.ValueMember = NationalitySebelumnya;
            comboBox_Team.ValueMember = TeamSebelumnya;
            numericUpDown_TeamNumber.Text = TeamNumberSebelumnya;
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            SimpanDataSebelumnya();
            IsiDataPemain(0);
            
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            SimpanDataSebelumnya();
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
            
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            SimpanDataSebelumnya();
            if (PosisiSekarang < dataPlayer.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
            
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            SimpanDataSebelumnya();
            IsiDataPemain(dataPlayer.Rows.Count - 1);
           
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            //sqlQuery = $"UPDATE player SET player_name = '" + textBox_PlayerName.Text + "', team_number = '" + numericUpDown_TeamNumber.Value.ToString() + "', nationality_id = '" + comboBox_Nationality.SelectedValue.ToString() + "', team_id = '" + comboBox_Team.SelectedValue.ToString() + "' where player_id = '" + textBox_PlayerID.Text + "' ";
            //sqlConnect.Open();
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnect.Close();
            sqlQuery = "UPDATE player SET player_id ='"+ textBox_PlayerID.Text +"', player_name ='" + textBox_PlayerName.Text +"', birthdate = '"+ dateTimePicker_BirthDate.Text +"', nationality_id = '" + comboBox_Nationality.ValueMember +"', team_id ='" + comboBox_Team.ValueMember +"', team_number ='"+ numericUpDown_TeamNumber.Value.ToString() +"' where player_id = '"+ PlayerIDSebelumnya +"' and player_name = '"+ PlayerNameSebelumnya +"' and birthdate ='"+ BirthDateSebelumnya+"' and nationality_id ='"+ NationalitySebelumnya +"' and team_id ='"+ TeamSebelumnya+"'and team_number = '"+ TeamNumberSebelumnya +"';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            //try
            //{
            //    sqlConnect.Open();

            //    sqlConnect.Close();
            //}
            //catch
            //{

            //}

            MessageBox.Show("Data pelajar baru bernama " + textBox_PlayerName.Text + " berhasil diinput.");

            MessageBox.Show("Data Berhasil Disimpan");

        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_Nationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_TeamNumber_ValueChanged(object sender, EventArgs e)
        {
            DataTable dtTeamNumber = new DataTable();
            sqlQuery = "SELECT * FROM player WHERE team_id='"+ (comboBox_Team.SelectedValue) +"' and team_number="+ (numericUpDown_TeamNumber.Value) +";";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamNumber);

            if (dtTeamNumber.Rows.Count > 0)
            {
                label_NotAvailable.Text = "Not Available";
            }
            else
            {
                label_NotAvailable.Text = "Available";
            }
        }

        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }
}
