﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MazeClient.Share;

namespace MazeClient.Scenes
{
    public partial class GetRoomInfoScene : Form
    {
        GameManager Manager;
        public GetRoomInfoScene()
        {
            InitializeComponent();
            Manager = GameManager.Instance;
            this.ControlBox = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void enterRoomBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hostTxtbox.Text) || string.IsNullOrEmpty(portTxtbox.Text) )
            {
                //입력 제한
                if(Convert.ToInt32(portTxtbox.Text) != -1)
                {
                    MessageBox.Show("입력 정보를 확인해주세요.");
                    return;
                }
            }

            string messageString = string.Format("IP : {0}\nPORT: {1}", hostTxtbox.Text, portTxtbox.Text);
            //다른 아이피 사용
            bool serverResult = await Manager.server.ConnectServer(hostTxtbox.Text, int.Parse(portTxtbox.Text));
            if (serverResult)
            {
                MessageBox.Show(messageString + "접속 완료!");
                this.DialogResult = DialogResult.OK;
                Manager.server.ServerIP = hostTxtbox.Text;
                Manager.server.ServerPort = Convert.ToInt32(portTxtbox.Text);
            }
            else
            {
                MessageBox.Show(messageString + "접속 실패!");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
