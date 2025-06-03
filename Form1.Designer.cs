namespace PS5_NOR_Modifier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label5 = new Label();
            fileLocationBox = new TextBox();
            browseFileButton = new Button();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            serialNumber = new Label();
            modelInfo = new Label();
            fileSizeInfo = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label8 = new Label();
            boardVariant = new Label();
            label11 = new Label();
            convertToDigitalEditionButton = new Button();
            boardVariantSelectionBox = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            serialNumberTextbox = new TextBox();
            label14 = new Label();
            boardModelSelectionBox = new ComboBox();
            label16 = new Label();
            macAddressInfo = new Label();
            LANMacAddressInfo = new Label();
            label18 = new Label();
            moboSerialInfo = new Label();
            label19 = new Label();
            label17 = new Label();
            wifiMacAddressTextbox = new TextBox();
            lanMacAddressTextbox = new TextBox();
            label20 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label25 = new Label();
            btnSendCommand = new Button();
            txtCustomCommand = new TextBox();
            label24 = new Label();
            btnRefreshPorts = new Button();
            button3 = new Button();
            txtUARTOutput = new TextBox();
            label22 = new Label();
            btnClearErrorCodes = new Button();
            label21 = new Label();
            codepuller = new Button();
            comboComPorts = new ComboBox();
            btnDisconnectCom = new Button();
            btnConnectCom = new Button();
            label3 = new Label();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(573, 33);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(530, 67);
            label2.TabIndex = 2;
            label2.Text = "PS5 NOR Modifier";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 6);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(291, 33);
            label5.TabIndex = 6;
            label5.Text = "Please Select NOR Dump";
            // 
            // fileLocationBox
            // 
            fileLocationBox.Location = new Point(10, 44);
            fileLocationBox.Margin = new Padding(5, 4, 5, 4);
            fileLocationBox.Name = "fileLocationBox";
            fileLocationBox.Size = new Size(1532, 41);
            fileLocationBox.TabIndex = 7;
            // 
            // browseFileButton
            // 
            browseFileButton.Location = new Point(1558, 42);
            browseFileButton.Margin = new Padding(5, 4, 5, 4);
            browseFileButton.Name = "browseFileButton";
            browseFileButton.Size = new Size(167, 44);
            browseFileButton.TabIndex = 8;
            browseFileButton.Text = "Browse";
            browseFileButton.UseVisualStyleBackColor = true;
            browseFileButton.Click += browseFileButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 108);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 29);
            label6.TabIndex = 9;
            label6.Text = "Dump Results:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 159);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 33);
            label7.TabIndex = 10;
            label7.Text = "Serial Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 350);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(142, 33);
            label9.TabIndex = 12;
            label9.Text = "PS5 Model:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 416);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(121, 33);
            label10.TabIndex = 13;
            label10.Text = "File Size:";
            // 
            // serialNumber
            // 
            serialNumber.AutoSize = true;
            serialNumber.Location = new Point(265, 159);
            serialNumber.Margin = new Padding(5, 0, 5, 0);
            serialNumber.Name = "serialNumber";
            serialNumber.Size = new Size(33, 33);
            serialNumber.TabIndex = 14;
            serialNumber.Text = "...";
            // 
            // modelInfo
            // 
            modelInfo.AutoSize = true;
            modelInfo.Location = new Point(265, 350);
            modelInfo.Margin = new Padding(5, 0, 5, 0);
            modelInfo.Name = "modelInfo";
            modelInfo.Size = new Size(33, 33);
            modelInfo.TabIndex = 16;
            modelInfo.Text = "...";
            // 
            // fileSizeInfo
            // 
            fileSizeInfo.AutoSize = true;
            fileSizeInfo.Location = new Point(265, 416);
            fileSizeInfo.Margin = new Padding(5, 0, 5, 0);
            fileSizeInfo.Name = "fileSizeInfo";
            fileSizeInfo.Size = new Size(33, 33);
            fileSizeInfo.TabIndex = 17;
            fileSizeInfo.Text = "...";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 1183);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 22, 0);
            statusStrip1.Size = new Size(1815, 42);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(271, 32);
            toolStripStatusLabel1.Text = "Status: Waiting for input";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 286);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 33);
            label8.TabIndex = 20;
            label8.Text = "Board Variant:";
            // 
            // boardVariant
            // 
            boardVariant.AutoSize = true;
            boardVariant.Location = new Point(265, 286);
            boardVariant.Margin = new Padding(5, 0, 5, 0);
            boardVariant.Name = "boardVariant";
            boardVariant.Size = new Size(33, 33);
            boardVariant.TabIndex = 21;
            boardVariant.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(842, 108);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(176, 29);
            label11.TabIndex = 22;
            label11.Text = "Modify Values";
            // 
            // convertToDigitalEditionButton
            // 
            convertToDigitalEditionButton.Location = new Point(1403, 486);
            convertToDigitalEditionButton.Margin = new Padding(5, 4, 5, 4);
            convertToDigitalEditionButton.Name = "convertToDigitalEditionButton";
            convertToDigitalEditionButton.Size = new Size(322, 101);
            convertToDigitalEditionButton.TabIndex = 23;
            convertToDigitalEditionButton.Text = "Save New\r\nBIOS Information";
            convertToDigitalEditionButton.UseVisualStyleBackColor = true;
            convertToDigitalEditionButton.Click += convertToDigitalEditionButton_Click;
            // 
            // boardVariantSelectionBox
            // 
            boardVariantSelectionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            boardVariantSelectionBox.FormattingEnabled = true;
            boardVariantSelectionBox.Items.AddRange(new object[] { "CFI-1000A", "CFI-1000A01", "CFI-1000B", "CFI-1002A", "CFI-1008A", "CFI-1014A", "CFI-1015A", "CFI-1015B", "CFI-1016A", "CFI-1018A", "CFI-1100A01", "CFI-1102A", "CFI-1108A", "CFI-1109A", "CFI-1114A", "CFI-1115A", "CFI-1116A", "CFI-1118A", "CFI-1208A", "CFI-1215A", "CFI-1216A", "DFI-T1000AA", "DFI-D1000AA" });
            boardVariantSelectionBox.Location = new Point(1087, 216);
            boardVariantSelectionBox.Margin = new Padding(5, 4, 5, 4);
            boardVariantSelectionBox.Name = "boardVariantSelectionBox";
            boardVariantSelectionBox.Size = new Size(634, 41);
            boardVariantSelectionBox.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(842, 159);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(183, 33);
            label12.TabIndex = 30;
            label12.Text = "Serial Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(842, 220);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(175, 33);
            label13.TabIndex = 31;
            label13.Text = "Board Variant:";
            // 
            // serialNumberTextbox
            // 
            serialNumberTextbox.Location = new Point(1087, 154);
            serialNumberTextbox.Margin = new Padding(5, 4, 5, 4);
            serialNumberTextbox.Name = "serialNumberTextbox";
            serialNumberTextbox.Size = new Size(634, 41);
            serialNumberTextbox.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(842, 284);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(142, 33);
            label14.TabIndex = 33;
            label14.Text = "PS5 Model:";
            // 
            // boardModelSelectionBox
            // 
            boardModelSelectionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            boardModelSelectionBox.FormattingEnabled = true;
            boardModelSelectionBox.Items.AddRange(new object[] { "Digital Edition", "Disc Edition" });
            boardModelSelectionBox.Location = new Point(1087, 279);
            boardModelSelectionBox.Margin = new Padding(5, 4, 5, 4);
            boardModelSelectionBox.Name = "boardModelSelectionBox";
            boardModelSelectionBox.Size = new Size(634, 41);
            boardModelSelectionBox.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 486);
            label16.Margin = new Padding(7, 0, 7, 0);
            label16.Name = "label16";
            label16.Size = new Size(228, 33);
            label16.TabIndex = 36;
            label16.Text = "WiFi Mac Address:";
            // 
            // macAddressInfo
            // 
            macAddressInfo.AutoSize = true;
            macAddressInfo.Location = new Point(265, 486);
            macAddressInfo.Margin = new Padding(7, 0, 7, 0);
            macAddressInfo.Name = "macAddressInfo";
            macAddressInfo.Size = new Size(33, 33);
            macAddressInfo.TabIndex = 37;
            macAddressInfo.Text = "...";
            // 
            // LANMacAddressInfo
            // 
            LANMacAddressInfo.AutoSize = true;
            LANMacAddressInfo.Location = new Point(265, 555);
            LANMacAddressInfo.Margin = new Padding(7, 0, 7, 0);
            LANMacAddressInfo.Name = "LANMacAddressInfo";
            LANMacAddressInfo.Size = new Size(33, 33);
            LANMacAddressInfo.TabIndex = 39;
            LANMacAddressInfo.Text = "...";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 555);
            label18.Margin = new Padding(7, 0, 7, 0);
            label18.Name = "label18";
            label18.Size = new Size(223, 33);
            label18.TabIndex = 38;
            label18.Text = "LAN Mac Address:";
            // 
            // moboSerialInfo
            // 
            moboSerialInfo.AutoSize = true;
            moboSerialInfo.Location = new Point(265, 222);
            moboSerialInfo.Margin = new Padding(7, 0, 7, 0);
            moboSerialInfo.Name = "moboSerialInfo";
            moboSerialInfo.Size = new Size(33, 33);
            moboSerialInfo.TabIndex = 41;
            moboSerialInfo.Text = "...";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(10, 222);
            label19.Margin = new Padding(7, 0, 7, 0);
            label19.Name = "label19";
            label19.Size = new Size(242, 33);
            label19.TabIndex = 40;
            label19.Text = "Motherboard Serial:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(842, 350);
            label17.Margin = new Padding(7, 0, 7, 0);
            label17.Name = "label17";
            label17.Size = new Size(235, 33);
            label17.TabIndex = 42;
            label17.Text = "WiFi MAC Address:";
            // 
            // wifiMacAddressTextbox
            // 
            wifiMacAddressTextbox.Enabled = false;
            wifiMacAddressTextbox.Location = new Point(1087, 343);
            wifiMacAddressTextbox.Margin = new Padding(7, 6, 7, 6);
            wifiMacAddressTextbox.Name = "wifiMacAddressTextbox";
            wifiMacAddressTextbox.Size = new Size(634, 41);
            wifiMacAddressTextbox.TabIndex = 43;
            // 
            // lanMacAddressTextbox
            // 
            lanMacAddressTextbox.Enabled = false;
            lanMacAddressTextbox.Location = new Point(1087, 407);
            lanMacAddressTextbox.Margin = new Padding(7, 6, 7, 6);
            lanMacAddressTextbox.Name = "lanMacAddressTextbox";
            lanMacAddressTextbox.Size = new Size(634, 41);
            lanMacAddressTextbox.TabIndex = 44;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(842, 414);
            label20.Margin = new Padding(7, 0, 7, 0);
            label20.Name = "label20";
            label20.Size = new Size(223, 33);
            label20.TabIndex = 45;
            label20.Text = "LAN Mac Address:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(17, 162);
            tabControl1.Margin = new Padding(7, 6, 7, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1768, 878);
            tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(fileLocationBox);
            tabPage1.Controls.Add(lanMacAddressTextbox);
            tabPage1.Controls.Add(browseFileButton);
            tabPage1.Controls.Add(wifiMacAddressTextbox);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(moboSerialInfo);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(LANMacAddressInfo);
            tabPage1.Controls.Add(serialNumber);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(modelInfo);
            tabPage1.Controls.Add(macAddressInfo);
            tabPage1.Controls.Add(fileSizeInfo);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(boardVariant);
            tabPage1.Controls.Add(boardModelSelectionBox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(convertToDigitalEditionButton);
            tabPage1.Controls.Add(serialNumberTextbox);
            tabPage1.Controls.Add(boardVariantSelectionBox);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Location = new Point(8, 47);
            tabPage1.Margin = new Padding(7, 6, 7, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(7, 6, 7, 6);
            tabPage1.Size = new Size(1752, 823);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "NOR Modifier";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(btnSendCommand);
            tabPage2.Controls.Add(txtCustomCommand);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(btnRefreshPorts);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(txtUARTOutput);
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(btnClearErrorCodes);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(codepuller);
            tabPage2.Controls.Add(comboComPorts);
            tabPage2.Controls.Add(btnDisconnectCom);
            tabPage2.Controls.Add(btnConnectCom);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(8, 47);
            tabPage2.Margin = new Padding(7, 6, 7, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(7, 6, 7, 6);
            tabPage2.Size = new Size(1752, 823);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "UART Communication";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(70, 631);
            label25.Margin = new Padding(7, 0, 7, 0);
            label25.Name = "label25";
            label25.Size = new Size(640, 132);
            label25.TabIndex = 17;
            label25.Text = resources.GetString("label25.Text");
            // 
            // btnSendCommand
            // 
            btnSendCommand.Location = new Point(1440, 285);
            btnSendCommand.Margin = new Padding(7, 6, 7, 6);
            btnSendCommand.Name = "btnSendCommand";
            btnSendCommand.Size = new Size(160, 51);
            btnSendCommand.TabIndex = 16;
            btnSendCommand.Text = "Send";
            btnSendCommand.UseVisualStyleBackColor = true;
            btnSendCommand.Click += btnSendCommand_Click;
            // 
            // txtCustomCommand
            // 
            txtCustomCommand.Location = new Point(1311, 223);
            txtCustomCommand.Margin = new Padding(7, 6, 7, 6);
            txtCustomCommand.Name = "txtCustomCommand";
            txtCustomCommand.Size = new Size(417, 41);
            txtCustomCommand.TabIndex = 15;
            txtCustomCommand.KeyPress += txtCustomCommand_KeyPress;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1307, 171);
            label24.Margin = new Padding(7, 0, 7, 0);
            label24.Name = "label24";
            label24.Size = new Size(381, 33);
            label24.TabIndex = 14;
            label24.Text = "Send custom command via UART:";
            // 
            // btnRefreshPorts
            // 
            btnRefreshPorts.Location = new Point(1199, 29);
            btnRefreshPorts.Margin = new Padding(7, 6, 7, 6);
            btnRefreshPorts.Name = "btnRefreshPorts";
            btnRefreshPorts.Size = new Size(190, 51);
            btnRefreshPorts.TabIndex = 11;
            btnRefreshPorts.Text = "Refresh Ports";
            btnRefreshPorts.UseVisualStyleBackColor = true;
            btnRefreshPorts.Click += btnRefreshPorts_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1378, 490);
            button3.Margin = new Padding(7, 6, 7, 6);
            button3.Name = "button3";
            button3.Size = new Size(335, 51);
            button3.TabIndex = 10;
            button3.Text = "Clear Output Window";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtUARTOutput
            // 
            txtUARTOutput.Location = new Point(157, 171);
            txtUARTOutput.Margin = new Padding(7, 6, 7, 6);
            txtUARTOutput.Multiline = true;
            txtUARTOutput.Name = "txtUARTOutput";
            txtUARTOutput.ScrollBars = ScrollBars.Vertical;
            txtUARTOutput.Size = new Size(1134, 369);
            txtUARTOutput.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(13, 171);
            label22.Margin = new Padding(7, 0, 7, 0);
            label22.Name = "label22";
            label22.Size = new Size(98, 33);
            label22.TabIndex = 8;
            label22.Text = "Output:";
            // 
            // btnClearErrorCodes
            // 
            btnClearErrorCodes.Location = new Point(398, 97);
            btnClearErrorCodes.Margin = new Padding(7, 6, 7, 6);
            btnClearErrorCodes.Name = "btnClearErrorCodes";
            btnClearErrorCodes.Size = new Size(253, 51);
            btnClearErrorCodes.TabIndex = 7;
            btnClearErrorCodes.Text = "Clear Error Codes";
            btnClearErrorCodes.UseVisualStyleBackColor = true;
            btnClearErrorCodes.Click += btnClearErrorCodes_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(13, 105);
            label21.Margin = new Padding(7, 0, 7, 0);
            label21.Name = "label21";
            label21.Size = new Size(109, 33);
            label21.TabIndex = 6;
            label21.Text = "Options:";
            // 
            // codepuller
            // 
            codepuller.Location = new Point(157, 97);
            codepuller.Margin = new Padding(7, 6, 7, 6);
            codepuller.Name = "codepuller";
            codepuller.Size = new Size(230, 51);
            codepuller.TabIndex = 5;
            codepuller.Text = "Get Error Codes";
            codepuller.UseVisualStyleBackColor = true;
            // Update the event handler assignment to match the correct return type
            codepuller.Click += Pullcodes_Click;
            // 
            // comboComPorts
            // 
            comboComPorts.FormattingEnabled = true;
            comboComPorts.Location = new Point(157, 29);
            comboComPorts.Margin = new Padding(7, 6, 7, 6);
            comboComPorts.Name = "comboComPorts";
            comboComPorts.Size = new Size(582, 41);
            comboComPorts.TabIndex = 4;
            // 
            // btnDisconnectCom
            // 
            btnDisconnectCom.Location = new Point(960, 24);
            btnDisconnectCom.Margin = new Padding(7, 6, 7, 6);
            btnDisconnectCom.Name = "btnDisconnectCom";
            btnDisconnectCom.Size = new Size(210, 51);
            btnDisconnectCom.TabIndex = 3;
            btnDisconnectCom.Text = "Disconnect";
            btnDisconnectCom.UseVisualStyleBackColor = true;
            btnDisconnectCom.Click += btnDisconnectCom_Click;
            // 
            // btnConnectCom
            // 
            btnConnectCom.Location = new Point(757, 27);
            btnConnectCom.Margin = new Padding(7, 6, 7, 6);
            btnConnectCom.Name = "btnConnectCom";
            btnConnectCom.Size = new Size(160, 51);
            btnConnectCom.TabIndex = 2;
            btnConnectCom.Text = "Connect";
            btnConnectCom.UseVisualStyleBackColor = true;
            btnConnectCom.Click += btnConnectCom_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 35);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 0;
            label3.Text = "Com Port:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1815, 1225);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "PS5 NOR Modifier";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        // Ensure the method signature matches the expected return type for the event handler
        private void Pullcodes_Click(object sender, EventArgs e)
        {
            _ = Pullerrorsasync(null, EventArgs.Empty); // Fire and forget
             //the other methods are commented out to avoid them running before they exist 
             //   _ = Pullsystemtemps(null, EventArgs.Empty); // Fire and forget
            //   _ = Pullsystemstate(null, EventArgs.Empty); // Fire and forget
        }
        #endregion
        private Label label2;
        private Label label5;
        private TextBox fileLocationBox;
        private Button browseFileButton;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label serialNumber;
        private Label modelInfo;
        private Label fileSizeInfo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label8;
        private Label boardVariant;
        private Label label11;
        private Button convertToDigitalEditionButton;
        private ComboBox boardVariantSelectionBox;
        private Label label12;
        private Label label13;
        private TextBox serialNumberTextbox;
        private Label label14;
        private ComboBox boardModelSelectionBox;
        private Label label16;
        private Label macAddressInfo;
        private Label LANMacAddressInfo;
        private Label label18;
        private Label moboSerialInfo;
        private Label label19;
        private Label label17;
        private TextBox wifiMacAddressTextbox;
        private TextBox lanMacAddressTextbox;
        private Label label20;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private TextBox txtUARTOutput;
        private Label label22;
        private Button btnClearErrorCodes;
        private Label label21;
        private Button codepuller;
        private ComboBox comboComPorts;
        private Button btnDisconnectCom;
        private Button btnConnectCom;
        private Label label3;
        private Button btnRefreshPorts;
        private Button btnSendCommand;
        private TextBox txtCustomCommand;
        private Label label24;
        private Label label25;
    }
}