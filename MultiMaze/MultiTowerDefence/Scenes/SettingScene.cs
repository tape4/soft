﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeClient
{
    public partial class SettingScene : Form
    {
        GameManager Manager;
        public SettingScene()
        {
            InitializeComponent();

            //매니저 할당
            Manager = GameManager.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.scene.ChangeGameState(this, Define.GameState.WaitScene);
        }
    }
}