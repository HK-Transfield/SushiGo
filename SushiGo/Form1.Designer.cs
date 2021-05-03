namespace SushiGo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPlayerTwoHand = new System.Windows.Forms.ListBox();
            this.buttonPlayCardPlayerOne = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFeedback = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRoundNumber = new System.Windows.Forms.Label();
            this.labelNumCards = new System.Windows.Forms.Label();
            this.listBoxPlayerTwoBoard = new System.Windows.Forms.ListBox();
            this.listBoxPlayerOneBoard = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDealCards = new System.Windows.Forms.Button();
            this.listBoxPlayerOneHand = new System.Windows.Forms.ListBox();
            this.buttonPlayCardPlayerTwo = new System.Windows.Forms.Button();
            this.buttonEndRound = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPlayerOneScore = new System.Windows.Forms.Label();
            this.labelPlayerTwoScore = new System.Windows.Forms.Label();
            this.labelPlayerOnePudding = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPlayerTwoPudding = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonRevealCards = new System.Windows.Forms.Button();
            this.radioButtonSinglePlayer = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiPlayer = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonBeginGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlayerTwoHand
            // 
            this.listBoxPlayerTwoHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(4)))));
            this.listBoxPlayerTwoHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlayerTwoHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerTwoHand.ForeColor = System.Drawing.Color.White;
            this.listBoxPlayerTwoHand.FormattingEnabled = true;
            this.listBoxPlayerTwoHand.ItemHeight = 16;
            this.listBoxPlayerTwoHand.Location = new System.Drawing.Point(860, 237);
            this.listBoxPlayerTwoHand.Name = "listBoxPlayerTwoHand";
            this.listBoxPlayerTwoHand.Size = new System.Drawing.Size(162, 176);
            this.listBoxPlayerTwoHand.TabIndex = 1;
            this.listBoxPlayerTwoHand.SelectedIndexChanged += new System.EventHandler(this.listBoxComputerHand_SelectedIndexChanged);
            // 
            // buttonPlayCardPlayerOne
            // 
            this.buttonPlayCardPlayerOne.Enabled = false;
            this.buttonPlayCardPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayCardPlayerOne.Location = new System.Drawing.Point(21, 423);
            this.buttonPlayCardPlayerOne.Name = "buttonPlayCardPlayerOne";
            this.buttonPlayCardPlayerOne.Size = new System.Drawing.Size(161, 55);
            this.buttonPlayCardPlayerOne.TabIndex = 2;
            this.buttonPlayCardPlayerOne.Text = "Play Card";
            this.buttonPlayCardPlayerOne.UseVisualStyleBackColor = true;
            this.buttonPlayCardPlayerOne.Click += new System.EventHandler(this.buttonPlayCard_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(359, 474);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(330, 35);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(359, 433);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(330, 35);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "&New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player 1\'s Hand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(904, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player 2\'s Hand:";
            // 
            // listBoxFeedback
            // 
            this.listBoxFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(4)))));
            this.listBoxFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFeedback.Enabled = false;
            this.listBoxFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFeedback.ForeColor = System.Drawing.Color.White;
            this.listBoxFeedback.FormattingEnabled = true;
            this.listBoxFeedback.ItemHeight = 16;
            this.listBoxFeedback.Location = new System.Drawing.Point(356, 237);
            this.listBoxFeedback.Name = "listBoxFeedback";
            this.listBoxFeedback.Size = new System.Drawing.Size(330, 48);
            this.listBoxFeedback.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(334, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 79);
            this.label5.TabIndex = 12;
            this.label5.Text = "SUSHI GO!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Round:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(431, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cards in Deck:";
            // 
            // labelRoundNumber
            // 
            this.labelRoundNumber.AutoSize = true;
            this.labelRoundNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoundNumber.ForeColor = System.Drawing.Color.White;
            this.labelRoundNumber.Location = new System.Drawing.Point(524, 133);
            this.labelRoundNumber.Name = "labelRoundNumber";
            this.labelRoundNumber.Size = new System.Drawing.Size(25, 25);
            this.labelRoundNumber.TabIndex = 19;
            this.labelRoundNumber.Text = "1";
            // 
            // labelNumCards
            // 
            this.labelNumCards.AutoSize = true;
            this.labelNumCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelNumCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCards.ForeColor = System.Drawing.Color.White;
            this.labelNumCards.Location = new System.Drawing.Point(604, 176);
            this.labelNumCards.Name = "labelNumCards";
            this.labelNumCards.Size = new System.Drawing.Size(25, 25);
            this.labelNumCards.TabIndex = 20;
            this.labelNumCards.Text = "0";
            // 
            // listBoxPlayerTwoBoard
            // 
            this.listBoxPlayerTwoBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(4)))));
            this.listBoxPlayerTwoBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlayerTwoBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerTwoBoard.ForeColor = System.Drawing.Color.White;
            this.listBoxPlayerTwoBoard.FormattingEnabled = true;
            this.listBoxPlayerTwoBoard.ItemHeight = 16;
            this.listBoxPlayerTwoBoard.Location = new System.Drawing.Point(692, 237);
            this.listBoxPlayerTwoBoard.Name = "listBoxPlayerTwoBoard";
            this.listBoxPlayerTwoBoard.Size = new System.Drawing.Size(162, 176);
            this.listBoxPlayerTwoBoard.TabIndex = 21;
            // 
            // listBoxPlayerOneBoard
            // 
            this.listBoxPlayerOneBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(4)))));
            this.listBoxPlayerOneBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlayerOneBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerOneBoard.ForeColor = System.Drawing.Color.White;
            this.listBoxPlayerOneBoard.FormattingEnabled = true;
            this.listBoxPlayerOneBoard.ItemHeight = 16;
            this.listBoxPlayerOneBoard.Location = new System.Drawing.Point(188, 237);
            this.listBoxPlayerOneBoard.Name = "listBoxPlayerOneBoard";
            this.listBoxPlayerOneBoard.Size = new System.Drawing.Size(162, 176);
            this.listBoxPlayerOneBoard.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(185, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Player 1\'s Board:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(729, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Player 2\'s Board:";
            // 
            // buttonDealCards
            // 
            this.buttonDealCards.AutoSize = true;
            this.buttonDealCards.Enabled = false;
            this.buttonDealCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDealCards.Location = new System.Drawing.Point(524, 300);
            this.buttonDealCards.Name = "buttonDealCards";
            this.buttonDealCards.Size = new System.Drawing.Size(162, 55);
            this.buttonDealCards.TabIndex = 25;
            this.buttonDealCards.Text = "Deal Cards";
            this.buttonDealCards.UseVisualStyleBackColor = true;
            this.buttonDealCards.Click += new System.EventHandler(this.buttonDealCards_Click);
            // 
            // listBoxPlayerOneHand
            // 
            this.listBoxPlayerOneHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(4)))));
            this.listBoxPlayerOneHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlayerOneHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerOneHand.ForeColor = System.Drawing.Color.White;
            this.listBoxPlayerOneHand.FormattingEnabled = true;
            this.listBoxPlayerOneHand.ItemHeight = 16;
            this.listBoxPlayerOneHand.Location = new System.Drawing.Point(20, 237);
            this.listBoxPlayerOneHand.Name = "listBoxPlayerOneHand";
            this.listBoxPlayerOneHand.Size = new System.Drawing.Size(162, 176);
            this.listBoxPlayerOneHand.TabIndex = 26;
            this.listBoxPlayerOneHand.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayerHand_SelectedIndexChanged);
            // 
            // buttonPlayCardPlayerTwo
            // 
            this.buttonPlayCardPlayerTwo.Enabled = false;
            this.buttonPlayCardPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayCardPlayerTwo.Location = new System.Drawing.Point(860, 423);
            this.buttonPlayCardPlayerTwo.Name = "buttonPlayCardPlayerTwo";
            this.buttonPlayCardPlayerTwo.Size = new System.Drawing.Size(162, 55);
            this.buttonPlayCardPlayerTwo.TabIndex = 27;
            this.buttonPlayCardPlayerTwo.Text = "Play Card";
            this.buttonPlayCardPlayerTwo.UseVisualStyleBackColor = true;
            this.buttonPlayCardPlayerTwo.Click += new System.EventHandler(this.buttonPlayCardPlayerTwo_Click);
            // 
            // buttonEndRound
            // 
            this.buttonEndRound.Enabled = false;
            this.buttonEndRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndRound.Location = new System.Drawing.Point(524, 361);
            this.buttonEndRound.Name = "buttonEndRound";
            this.buttonEndRound.Size = new System.Drawing.Size(162, 55);
            this.buttonEndRound.TabIndex = 28;
            this.buttonEndRound.Text = "End Round";
            this.buttonEndRound.UseVisualStyleBackColor = true;
            this.buttonEndRound.Click += new System.EventHandler(this.buttonEndRound_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Score:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(856, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Score:";
            // 
            // labelPlayerOneScore
            // 
            this.labelPlayerOneScore.AutoSize = true;
            this.labelPlayerOneScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPlayerOneScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerOneScore.ForeColor = System.Drawing.Color.White;
            this.labelPlayerOneScore.Location = new System.Drawing.Point(122, 176);
            this.labelPlayerOneScore.Name = "labelPlayerOneScore";
            this.labelPlayerOneScore.Size = new System.Drawing.Size(25, 25);
            this.labelPlayerOneScore.TabIndex = 34;
            this.labelPlayerOneScore.Text = "0";
            // 
            // labelPlayerTwoScore
            // 
            this.labelPlayerTwoScore.AutoSize = true;
            this.labelPlayerTwoScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPlayerTwoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerTwoScore.ForeColor = System.Drawing.Color.White;
            this.labelPlayerTwoScore.Location = new System.Drawing.Point(962, 176);
            this.labelPlayerTwoScore.Name = "labelPlayerTwoScore";
            this.labelPlayerTwoScore.Size = new System.Drawing.Size(25, 25);
            this.labelPlayerTwoScore.TabIndex = 35;
            this.labelPlayerTwoScore.Text = "0";
            // 
            // labelPlayerOnePudding
            // 
            this.labelPlayerOnePudding.AutoSize = true;
            this.labelPlayerOnePudding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPlayerOnePudding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerOnePudding.ForeColor = System.Drawing.Color.White;
            this.labelPlayerOnePudding.Location = new System.Drawing.Point(122, 133);
            this.labelPlayerOnePudding.Name = "labelPlayerOnePudding";
            this.labelPlayerOnePudding.Size = new System.Drawing.Size(25, 25);
            this.labelPlayerOnePudding.TabIndex = 37;
            this.labelPlayerOnePudding.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Pudding:";
            // 
            // labelPlayerTwoPudding
            // 
            this.labelPlayerTwoPudding.AutoSize = true;
            this.labelPlayerTwoPudding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPlayerTwoPudding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerTwoPudding.ForeColor = System.Drawing.Color.White;
            this.labelPlayerTwoPudding.Location = new System.Drawing.Point(962, 133);
            this.labelPlayerTwoPudding.Name = "labelPlayerTwoPudding";
            this.labelPlayerTwoPudding.Size = new System.Drawing.Size(25, 25);
            this.labelPlayerTwoPudding.TabIndex = 39;
            this.labelPlayerTwoPudding.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(856, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "Pudding:";
            // 
            // buttonRevealCards
            // 
            this.buttonRevealCards.AutoSize = true;
            this.buttonRevealCards.Enabled = false;
            this.buttonRevealCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevealCards.Location = new System.Drawing.Point(356, 361);
            this.buttonRevealCards.Name = "buttonRevealCards";
            this.buttonRevealCards.Size = new System.Drawing.Size(162, 55);
            this.buttonRevealCards.TabIndex = 40;
            this.buttonRevealCards.Text = "Reveal Cards";
            this.buttonRevealCards.UseVisualStyleBackColor = true;
            this.buttonRevealCards.Click += new System.EventHandler(this.buttonRevealCards_Click);
            // 
            // radioButtonSinglePlayer
            // 
            this.radioButtonSinglePlayer.AutoSize = true;
            this.radioButtonSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSinglePlayer.ForeColor = System.Drawing.Color.White;
            this.radioButtonSinglePlayer.Location = new System.Drawing.Point(356, 211);
            this.radioButtonSinglePlayer.Name = "radioButtonSinglePlayer";
            this.radioButtonSinglePlayer.Size = new System.Drawing.Size(119, 20);
            this.radioButtonSinglePlayer.TabIndex = 42;
            this.radioButtonSinglePlayer.TabStop = true;
            this.radioButtonSinglePlayer.Text = "Single Player";
            this.radioButtonSinglePlayer.UseVisualStyleBackColor = true;
            this.radioButtonSinglePlayer.CheckedChanged += new System.EventHandler(this.radioButtonSinglePlayer_CheckedChanged);
            // 
            // radioButtonMultiPlayer
            // 
            this.radioButtonMultiPlayer.AutoSize = true;
            this.radioButtonMultiPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMultiPlayer.ForeColor = System.Drawing.Color.White;
            this.radioButtonMultiPlayer.Location = new System.Drawing.Point(584, 211);
            this.radioButtonMultiPlayer.Name = "radioButtonMultiPlayer";
            this.radioButtonMultiPlayer.Size = new System.Drawing.Size(102, 20);
            this.radioButtonMultiPlayer.TabIndex = 43;
            this.radioButtonMultiPlayer.TabStop = true;
            this.radioButtonMultiPlayer.Text = "Multiplayer";
            this.radioButtonMultiPlayer.UseVisualStyleBackColor = true;
            this.radioButtonMultiPlayer.CheckedChanged += new System.EventHandler(this.radioButtonMultiPlayer_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 40);
            this.label8.TabIndex = 44;
            this.label8.Text = "Player 1";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(853, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 40);
            this.label9.TabIndex = 45;
            this.label9.Text = "Player 2";
            // 
            // buttonBeginGame
            // 
            this.buttonBeginGame.Enabled = false;
            this.buttonBeginGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeginGame.Location = new System.Drawing.Point(356, 300);
            this.buttonBeginGame.Name = "buttonBeginGame";
            this.buttonBeginGame.Size = new System.Drawing.Size(162, 55);
            this.buttonBeginGame.TabIndex = 47;
            this.buttonBeginGame.Text = "Begin Game";
            this.buttonBeginGame.UseVisualStyleBackColor = true;
            this.buttonBeginGame.Click += new System.EventHandler(this.buttonBeginGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1035, 639);
            this.Controls.Add(this.buttonBeginGame);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonMultiPlayer);
            this.Controls.Add(this.radioButtonSinglePlayer);
            this.Controls.Add(this.buttonRevealCards);
            this.Controls.Add(this.labelPlayerTwoPudding);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelPlayerOnePudding);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelPlayerTwoScore);
            this.Controls.Add(this.labelPlayerOneScore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonEndRound);
            this.Controls.Add(this.buttonPlayCardPlayerTwo);
            this.Controls.Add(this.listBoxPlayerOneHand);
            this.Controls.Add(this.buttonDealCards);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxPlayerOneBoard);
            this.Controls.Add(this.listBoxPlayerTwoBoard);
            this.Controls.Add(this.labelNumCards);
            this.Controls.Add(this.labelRoundNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayCardPlayerOne);
            this.Controls.Add(this.listBoxPlayerTwoHand);
            this.Name = "Form1";
            this.Text = "Sushi Go!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPlayerTwoHand;
        private System.Windows.Forms.Button buttonPlayCardPlayerOne;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFeedback;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRoundNumber;
        private System.Windows.Forms.Label labelNumCards;
        private System.Windows.Forms.ListBox listBoxPlayerTwoBoard;
        private System.Windows.Forms.ListBox listBoxPlayerOneBoard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDealCards;
        private System.Windows.Forms.ListBox listBoxPlayerOneHand;
        private System.Windows.Forms.Button buttonPlayCardPlayerTwo;
        private System.Windows.Forms.Button buttonEndRound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPlayerOneScore;
        private System.Windows.Forms.Label labelPlayerTwoScore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPlayerTwoPudding;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelPlayerOnePudding;
        private System.Windows.Forms.Button buttonRevealCards;
        private System.Windows.Forms.RadioButton radioButtonSinglePlayer;
        private System.Windows.Forms.RadioButton radioButtonMultiPlayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBeginGame;
    }
}

