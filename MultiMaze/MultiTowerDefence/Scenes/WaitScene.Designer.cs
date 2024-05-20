namespace MazeClient
{
    partial class WaitScene
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            roundLabel = new Label();
            BtnStart = new Button();
            BtnReady = new Button();
            BtnLeave = new Button();
            PicPlayer2 = new PictureBox();
            Player1 = new Label();
            Player2 = new Label();
            Player4 = new Label();
            PicPlayer1 = new PictureBox();
            Player3 = new Label();
            PicPlayer4 = new PictureBox();
            PicPlayer3 = new PictureBox();
            RtbChat = new RichTextBox();
            BtnSend = new Button();
            BtnColor = new Button();
            cld = new ColorDialog();
            inputTb = new TextBox();
            hostLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PicPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayer4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayer3).BeginInit();
            SuspendLayout();
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(422, 12);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(89, 20);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "라운드 대기";
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(0, 456);
            BtnStart.Margin = new Padding(4);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(462, 169);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnReady
            // 
            BtnReady.Location = new Point(458, 456);
            BtnReady.Margin = new Padding(4);
            BtnReady.Name = "BtnReady";
            BtnReady.Size = new Size(462, 92);
            BtnReady.TabIndex = 3;
            BtnReady.Text = "준비";
            BtnReady.UseVisualStyleBackColor = true;
            BtnReady.Click += BtnReady_Click;
            // 
            // BtnLeave
            // 
            BtnLeave.Location = new Point(458, 540);
            BtnLeave.Margin = new Padding(4);
            BtnLeave.Name = "BtnLeave";
            BtnLeave.Size = new Size(462, 85);
            BtnLeave.TabIndex = 3;
            BtnLeave.Text = "나가기";
            BtnLeave.UseVisualStyleBackColor = true;
            BtnLeave.Click += BtnLeave_Click;
            // 
            // PicPlayer2
            // 
            PicPlayer2.Location = new Point(380, 80);
            PicPlayer2.Margin = new Padding(4);
            PicPlayer2.Name = "PicPlayer2";
            PicPlayer2.Size = new Size(110, 110);
            PicPlayer2.TabIndex = 4;
            PicPlayer2.TabStop = false;
            PicPlayer2.Paint += PicPlayer_Paint;
            // 
            // Player1
            // 
            Player1.AutoSize = true;
            Player1.Location = new Point(180, 200);
            Player1.Margin = new Padding(4, 0, 4, 0);
            Player1.Name = "Player1";
            Player1.Size = new Size(58, 20);
            Player1.TabIndex = 6;
            Player1.Text = "Player1";
            Player1.Paint += Player_Paint;
            // 
            // Player2
            // 
            Player2.AutoSize = true;
            Player2.Location = new Point(380, 200);
            Player2.Margin = new Padding(4, 0, 4, 0);
            Player2.Name = "Player2";
            Player2.Size = new Size(58, 20);
            Player2.TabIndex = 6;
            Player2.Text = "Player2";
            Player2.Paint += Player_Paint;
            // 
            // Player4
            // 
            Player4.AutoSize = true;
            Player4.Location = new Point(380, 360);
            Player4.Margin = new Padding(4, 0, 4, 0);
            Player4.Name = "Player4";
            Player4.Size = new Size(58, 20);
            Player4.TabIndex = 6;
            Player4.Text = "Player4";
            Player4.Paint += Player_Paint;
            // 
            // PicPlayer1
            // 
            PicPlayer1.BackColor = SystemColors.Control;
            PicPlayer1.Location = new Point(180, 80);
            PicPlayer1.Margin = new Padding(4);
            PicPlayer1.Name = "PicPlayer1";
            PicPlayer1.Size = new Size(110, 110);
            PicPlayer1.TabIndex = 4;
            PicPlayer1.TabStop = false;
            PicPlayer1.Paint += PicPlayer_Paint;
            // 
            // Player3
            // 
            Player3.AutoSize = true;
            Player3.Location = new Point(180, 360);
            Player3.Margin = new Padding(4, 0, 4, 0);
            Player3.Name = "Player3";
            Player3.Size = new Size(58, 20);
            Player3.TabIndex = 6;
            Player3.Text = "Player3";
            Player3.Paint += Player_Paint;
            // 
            // PicPlayer4
            // 
            PicPlayer4.Location = new Point(380, 240);
            PicPlayer4.Margin = new Padding(4);
            PicPlayer4.Name = "PicPlayer4";
            PicPlayer4.Size = new Size(110, 110);
            PicPlayer4.TabIndex = 4;
            PicPlayer4.TabStop = false;
            PicPlayer4.Paint += PicPlayer_Paint;
            // 
            // PicPlayer3
            // 
            PicPlayer3.Location = new Point(180, 240);
            PicPlayer3.Margin = new Padding(4);
            PicPlayer3.Name = "PicPlayer3";
            PicPlayer3.Size = new Size(110, 110);
            PicPlayer3.TabIndex = 4;
            PicPlayer3.TabStop = false;
            PicPlayer3.Paint += PicPlayer_Paint;
            // 
            // RtbChat
            // 
            RtbChat.Location = new Point(543, 79);
            RtbChat.Margin = new Padding(4);
            RtbChat.Name = "RtbChat";
            RtbChat.Size = new Size(292, 325);
            RtbChat.TabIndex = 7;
            RtbChat.Text = "";
            // 
            // BtnSend
            // 
            BtnSend.Location = new Point(838, 418);
            BtnSend.Margin = new Padding(4);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(84, 30);
            BtnSend.TabIndex = 8;
            BtnSend.Text = "전송";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // BtnColor
            // 
            BtnColor.Location = new Point(12, 417);
            BtnColor.Name = "BtnColor";
            BtnColor.Size = new Size(94, 29);
            BtnColor.TabIndex = 9;
            BtnColor.Text = "색 변경";
            BtnColor.UseVisualStyleBackColor = true;
            BtnColor.Click += BtnColor_Click;
            // 
            // inputTb
            // 
            inputTb.Location = new Point(543, 421);
            inputTb.Name = "inputTb";
            inputTb.Size = new Size(288, 27);
            inputTb.TabIndex = 9;
            inputTb.KeyDown += inputTb_KeyDown;
            // 
            // hostLabel
            // 
            hostLabel.AutoSize = true;
            hostLabel.Location = new Point(21, 23);
            hostLabel.Name = "hostLabel";
            hostLabel.Size = new Size(86, 20);
            hostLabel.TabIndex = 10;
            hostLabel.Text = "Host의 IP : ";
            // 
            // WaitScene
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 627);
            Controls.Add(hostLabel);
            Controls.Add(BtnColor);
            Controls.Add(inputTb);
            Controls.Add(BtnSend);
            Controls.Add(RtbChat);
            Controls.Add(Player3);
            Controls.Add(Player4);
            Controls.Add(Player2);
            Controls.Add(Player1);
            Controls.Add(PicPlayer1);
            Controls.Add(PicPlayer3);
            Controls.Add(PicPlayer4);
            Controls.Add(PicPlayer2);
            Controls.Add(BtnLeave);
            Controls.Add(BtnReady);
            Controls.Add(BtnStart);
            Controls.Add(roundLabel);
            Name = "WaitScene";
            Text = "WaitScene";
            Load += WaitScene_Load;
            ((System.ComponentModel.ISupportInitialize)PicPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayer4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayer3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label roundLabel;
        private Button BtnStart;
        private Button BtnReady;
        private Button BtnLeave;
        private PictureBox PicPlayer2;
        private Label Player1;
        private Label Player2;
        private Label Player4;
        private PictureBox PicPlayer1;
        private Label Player3;
        private PictureBox PicPlayer4;
        private PictureBox PicPlayer3;
        private RichTextBox RtbChat;
        private Button BtnSend;
        private Button BtnColor;
        private ColorDialog cld;
        private TextBox inputTb;
        private Label hostLabel;
    }
}
