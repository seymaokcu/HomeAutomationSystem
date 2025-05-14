using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAutomationSystem
{
    public partial class Form1 : Form
    {
        List<Room> rooms = new List<Room>();
        public Form1()
        {
            LoadRooms();
            InitializeComponent();
        }
        Random rnd = new Random();
        private void SimulateTemperatureChange()
        {
            foreach(var room in rooms)
            {
                int change = rnd.Next(-1, 2);
                room.Temperature += change;

            }
        }
        private void LoadRooms()
        {
            rooms.Add(new Room("Living Room"));
            rooms.Add(new Room("Bedroom"));
            rooms.Add(new Room("Kitchen"));

            cmbRooms.Items.AddRange(rooms.Select(r => r.RoomName).ToArray());
            cmbRooms.SelectedIndex = 0;
            UpdateRoomUI();
        }
        private void UpdateRoomUI()
        {
            Room selectedRoom = rooms[cmbRooms.SelectedIndex];

            chkLight.Checked = selectedRoom.Light.IsOn;
            chkLight.Checked = selectedRoom.Heater.IsOn;
            lblTemp.Text = selectedRoom.Temperature.ToString() + " C";

        }

        private void btnIncTemp_Click(object sender, EventArgs e)
        {
            rooms[cmbRooms.SelectedIndex].IncreaseTemperature();
            UpdateRoomUI();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Room selectedRoom = rooms[cmbRooms.SelectedIndex];

            selectedRoom.Light.IsOn = chkLight.Checked;
            selectedRoom.Heater.IsOn = chkHeater.Checked;

            MessageBox.Show("Changes applied to " + selectedRoom.RoomName);
        }

        private void btnDecTemp_Click(object sender, EventArgs e)
        {
            rooms[cmbRooms.SelectedIndex].DecreaseTepmerature();
            UpdateRoomUI();
        }

        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRoomUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SimulateTemperatureChange();
            foreach(var room in rooms)
            {
                bool isNight = DateTime.Now.Hour >= 19 || DateTime.Now.Hour < 6;
                room.AutoControl(isNight);
            }
            UpdateRoomUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
