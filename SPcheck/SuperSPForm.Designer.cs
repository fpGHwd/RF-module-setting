using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text;
using System.IO.Ports;

namespace SPcheck
{
    partial class SuperSPForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源,为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperSPForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.HandshakeCbb = new System.Windows.Forms.ComboBox();
            this.StopbitCbb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DatabitCbb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParityCbb = new System.Windows.Forms.ComboBox();
            this.openCloseSpbtn = new System.Windows.Forms.Button();
            this.BaudrateCbb = new System.Windows.Forms.ComboBox();
            this.ComportCbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabels = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabeltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RffrequencyCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RffactorCbb = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RfmodeCbb = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RfbwCbb = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NodeidCbb = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BreathCbb = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.PowerCbb = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NetidCbb = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ParitysetCbb = new System.Windows.Forms.ComboBox();
            this.BaudratesetCbb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WriteallBtn = new System.Windows.Forms.Button();
            this.ReadallBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.HandshakeCbb);
            this.groupBox1.Controls.Add(this.StopbitCbb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DatabitCbb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ParityCbb);
            this.groupBox1.Controls.Add(this.openCloseSpbtn);
            this.groupBox1.Controls.Add(this.BaudrateCbb);
            this.groupBox1.Controls.Add(this.ComportCbb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电脑串口设置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "握手";
            // 
            // HandshakeCbb
            // 
            this.HandshakeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HandshakeCbb.FormattingEnabled = true;
            this.HandshakeCbb.Location = new System.Drawing.Point(65, 149);
            this.HandshakeCbb.Name = "HandshakeCbb";
            this.HandshakeCbb.Size = new System.Drawing.Size(55, 20);
            this.HandshakeCbb.TabIndex = 19;
            // 
            // StopbitCbb
            // 
            this.StopbitCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopbitCbb.FormattingEnabled = true;
            this.StopbitCbb.Location = new System.Drawing.Point(65, 94);
            this.StopbitCbb.Name = "StopbitCbb";
            this.StopbitCbb.Size = new System.Drawing.Size(55, 20);
            this.StopbitCbb.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "停止位";
            // 
            // DatabitCbb
            // 
            this.DatabitCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabitCbb.FormattingEnabled = true;
            this.DatabitCbb.Location = new System.Drawing.Point(65, 68);
            this.DatabitCbb.Name = "DatabitCbb";
            this.DatabitCbb.Size = new System.Drawing.Size(55, 20);
            this.DatabitCbb.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验";
            // 
            // ParityCbb
            // 
            this.ParityCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityCbb.FormattingEnabled = true;
            this.ParityCbb.Location = new System.Drawing.Point(65, 122);
            this.ParityCbb.Name = "ParityCbb";
            this.ParityCbb.Size = new System.Drawing.Size(55, 20);
            this.ParityCbb.TabIndex = 9;
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.Location = new System.Drawing.Point(31, 175);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(65, 20);
            this.openCloseSpbtn.TabIndex = 13;
            this.openCloseSpbtn.Text = "打开";
            this.openCloseSpbtn.UseVisualStyleBackColor = true;
            // 
            // BaudrateCbb
            // 
            this.BaudrateCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudrateCbb.FormattingEnabled = true;
            this.BaudrateCbb.Location = new System.Drawing.Point(65, 41);
            this.BaudrateCbb.Name = "BaudrateCbb";
            this.BaudrateCbb.Size = new System.Drawing.Size(55, 20);
            this.BaudrateCbb.TabIndex = 7;
            // 
            // ComportCbb
            // 
            this.ComportCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComportCbb.FormattingEnabled = true;
            this.ComportCbb.Location = new System.Drawing.Point(65, 14);
            this.ComportCbb.Name = "ComportCbb";
            this.ComportCbb.Size = new System.Drawing.Size(55, 20);
            this.ComportCbb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabels,
            this.toolStripStatusLabeltime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabels
            // 
            this.toolStripStatusLabels.Name = "toolStripStatusLabels";
            this.toolStripStatusLabels.Size = new System.Drawing.Size(510, 17);
            this.toolStripStatusLabels.Spring = true;
            this.toolStripStatusLabels.Text = "就绪";
            this.toolStripStatusLabels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabeltime
            // 
            this.toolStripStatusLabeltime.Name = "toolStripStatusLabeltime";
            this.toolStripStatusLabeltime.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RffrequencyCbb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(161, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "频率";
            // 
            // RffrequencyCbb
            // 
            this.RffrequencyCbb.FormattingEnabled = true;
            this.RffrequencyCbb.Location = new System.Drawing.Point(30, 19);
            this.RffrequencyCbb.Name = "RffrequencyCbb";
            this.RffrequencyCbb.Size = new System.Drawing.Size(76, 20);
            this.RffrequencyCbb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "MHz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.RffactorCbb);
            this.groupBox3.Location = new System.Drawing.Point(316, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 49);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "扩频因子";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chips";
            // 
            // RffactorCbb
            // 
            this.RffactorCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RffactorCbb.FormattingEnabled = true;
            this.RffactorCbb.Location = new System.Drawing.Point(28, 21);
            this.RffactorCbb.Name = "RffactorCbb";
            this.RffactorCbb.Size = new System.Drawing.Size(76, 20);
            this.RffactorCbb.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.RfmodeCbb);
            this.groupBox4.Location = new System.Drawing.Point(161, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 58);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "模式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mode";
            // 
            // RfmodeCbb
            // 
            this.RfmodeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RfmodeCbb.FormattingEnabled = true;
            this.RfmodeCbb.Location = new System.Drawing.Point(30, 23);
            this.RfmodeCbb.Name = "RfmodeCbb";
            this.RfmodeCbb.Size = new System.Drawing.Size(76, 20);
            this.RfmodeCbb.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.RfbwCbb);
            this.groupBox5.Location = new System.Drawing.Point(323, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 58);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "扩频带宽";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kbs";
            // 
            // RfbwCbb
            // 
            this.RfbwCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RfbwCbb.FormattingEnabled = true;
            this.RfbwCbb.Location = new System.Drawing.Point(21, 23);
            this.RfbwCbb.Name = "RfbwCbb";
            this.RfbwCbb.Size = new System.Drawing.Size(76, 20);
            this.RfbwCbb.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.NodeidCbb);
            this.groupBox6.Location = new System.Drawing.Point(161, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 40);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "节点ID";
            // 
            // NodeidCbb
            // 
            this.NodeidCbb.FormattingEnabled = true;
            this.NodeidCbb.Location = new System.Drawing.Point(6, 13);
            this.NodeidCbb.MaxLength = 10;
            this.NodeidCbb.Name = "NodeidCbb";
            this.NodeidCbb.Size = new System.Drawing.Size(100, 20);
            this.NodeidCbb.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BreathCbb);
            this.groupBox7.Location = new System.Drawing.Point(279, 131);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(70, 40);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "呼吸时间";
            // 
            // BreathCbb
            // 
            this.BreathCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BreathCbb.FormattingEnabled = true;
            this.BreathCbb.Location = new System.Drawing.Point(6, 13);
            this.BreathCbb.Name = "BreathCbb";
            this.BreathCbb.Size = new System.Drawing.Size(59, 20);
            this.BreathCbb.TabIndex = 5;
            this.BreathCbb.SelectedIndexChanged += new System.EventHandler(this.breathCbbSelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PowerCbb);
            this.groupBox8.Location = new System.Drawing.Point(426, 131);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(65, 40);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "功率";
            // 
            // PowerCbb
            // 
            this.PowerCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PowerCbb.FormattingEnabled = true;
            this.PowerCbb.Location = new System.Drawing.Point(6, 14);
            this.PowerCbb.Name = "PowerCbb";
            this.PowerCbb.Size = new System.Drawing.Size(53, 20);
            this.PowerCbb.TabIndex = 5;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NetidCbb);
            this.groupBox9.Location = new System.Drawing.Point(355, 131);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(65, 40);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "网络ID";
            // 
            // NetidCbb
            // 
            this.NetidCbb.FormattingEnabled = true;
            this.NetidCbb.Location = new System.Drawing.Point(7, 14);
            this.NetidCbb.MaxLength = 5;
            this.NetidCbb.Name = "NetidCbb";
            this.NetidCbb.Size = new System.Drawing.Size(52, 20);
            this.NetidCbb.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ParitysetCbb);
            this.groupBox10.Controls.Add(this.BaudratesetCbb);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Location = new System.Drawing.Point(161, 177);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(330, 48);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "模块串口设置";
            // 
            // ParitysetCbb
            // 
            this.ParitysetCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParitysetCbb.FormattingEnabled = true;
            this.ParitysetCbb.Location = new System.Drawing.Point(235, 15);
            this.ParitysetCbb.Name = "ParitysetCbb";
            this.ParitysetCbb.Size = new System.Drawing.Size(55, 20);
            this.ParitysetCbb.TabIndex = 13;
            // 
            // BaudratesetCbb
            // 
            this.BaudratesetCbb.Cursor = System.Windows.Forms.Cursors.Default;
            this.BaudratesetCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudratesetCbb.FormattingEnabled = true;
            this.BaudratesetCbb.Location = new System.Drawing.Point(80, 15);
            this.BaudratesetCbb.Name = "BaudratesetCbb";
            this.BaudratesetCbb.Size = new System.Drawing.Size(55, 20);
            this.BaudratesetCbb.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "校验";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "波特率";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WriteallBtn
            // 
            this.WriteallBtn.Enabled = false;
            this.WriteallBtn.Location = new System.Drawing.Point(362, 235);
            this.WriteallBtn.Name = "WriteallBtn";
            this.WriteallBtn.Size = new System.Drawing.Size(72, 21);
            this.WriteallBtn.TabIndex = 15;
            this.WriteallBtn.Text = "写入设置";
            this.WriteallBtn.UseVisualStyleBackColor = true;
            // 
            // ReadallBtn
            // 
            this.ReadallBtn.AutoSize = true;
            this.ReadallBtn.Enabled = false;
            this.ReadallBtn.Location = new System.Drawing.Point(241, 234);
            this.ReadallBtn.Name = "ReadallBtn";
            this.ReadallBtn.Size = new System.Drawing.Size(69, 22);
            this.ReadallBtn.TabIndex = 17;
            this.ReadallBtn.Text = "读取设置";
            this.ReadallBtn.UseVisualStyleBackColor = true;
            // 
            // SuperSPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(525, 322);
            this.Controls.Add(this.ReadallBtn);
            this.Controls.Add(this.WriteallBtn);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperSPForm";
            this.Text = "RF模块参数设置";
            this.Load += new System.EventHandler(this.SuperSPForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCloseSpbtn;
        private System.Windows.Forms.ComboBox ParityCbb;
        private System.Windows.Forms.ComboBox BaudrateCbb;
        private System.Windows.Forms.ComboBox ComportCbb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RffactorCbb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RfmodeCbb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RfbwCbb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox BreathCbb;
        private System.Windows.Forms.ComboBox PowerCbb;
        private System.Windows.Forms.ComboBox ParitysetCbb;
        private System.Windows.Forms.ComboBox BaudratesetCbb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox StopbitCbb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DatabitCbb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox HandshakeCbb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox RffrequencyCbb;
        private System.Windows.Forms.ComboBox NodeidCbb;
        private System.Windows.Forms.ComboBox NetidCbb;
        private ToolStripStatusLabel toolStripStatusLabeltime;
        private Button WriteallBtn;
        private Button ReadallBtn;
        //private TextBox textBox1;
        //private EventHandler breathcbbSelectedIndexChanged;
    }
}

