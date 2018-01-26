namespace CS_Force_Exit
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProcessGridView = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessGridView
            // 
            this.ProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessId});
            this.ProcessGridView.Location = new System.Drawing.Point(12, 21);
            this.ProcessGridView.Name = "ProcessGridView";
            this.ProcessGridView.RowTemplate.Height = 23;
            this.ProcessGridView.Size = new System.Drawing.Size(501, 421);
            this.ProcessGridView.TabIndex = 0;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "ProcessName";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Width = 245;
            // 
            // ProcessId
            // 
            this.ProcessId.HeaderText = "ProcessId";
            this.ProcessId.Name = "ProcessId";
            this.ProcessId.Width = 210;
            // 
            // ProcessRefresh
            // 
            this.ProcessRefresh.Enabled = true;
            this.ProcessRefresh.Interval = 5000;
            this.ProcessRefresh.Tick += new System.EventHandler(this.ProcessRefresh_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(525, 445);
            this.Controls.Add(this.ProcessGridView);
            this.Name = "Form1";
            this.Text = "강제종료 프로그램 - LittleDev0617";
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProcessGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessId;
        private System.Windows.Forms.Timer ProcessRefresh;
    }
}

