
namespace WindowsFormsApp1
{
    partial class Deuceng_Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_select_dataset = new System.Windows.Forms.Button();
            this.comboBox_datasets = new System.Windows.Forms.ComboBox();
            this.pnl_intro = new System.Windows.Forms.Panel();
            this.pnl_dataset_info = new System.Windows.Forms.Panel();
            this.lbl_dataset_name = new System.Windows.Forms.Label();
            this.btn_cont_with_dataset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataset_info_textbox = new System.Windows.Forms.TextBox();
            this.pnl_result_and_prediction = new System.Windows.Forms.Panel();
            this.lbl_result_for_dataset = new System.Windows.Forms.Label();
            this.btn_predict = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back_info_page = new System.Windows.Forms.Button();
            this.prediction_panel = new System.Windows.Forms.Panel();
            this.lbl_prediction = new System.Windows.Forms.Label();
            this.pnl_intro.SuspendLayout();
            this.pnl_dataset_info.SuspendLayout();
            this.pnl_result_and_prediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_welcome.Location = new System.Drawing.Point(18, 13);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(465, 26);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome DEUCENG Classification Tool, Please select Dataset that you want to run M" +
    "L algorithm\r\n\r\n";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // btn_select_dataset
            // 
            this.btn_select_dataset.Location = new System.Drawing.Point(342, 71);
            this.btn_select_dataset.Name = "btn_select_dataset";
            this.btn_select_dataset.Size = new System.Drawing.Size(75, 23);
            this.btn_select_dataset.TabIndex = 1;
            this.btn_select_dataset.Text = "Select";
            this.btn_select_dataset.UseVisualStyleBackColor = true;
            this.btn_select_dataset.Click += new System.EventHandler(this.btn_select_dataset_Click);
            // 
            // comboBox_datasets
            // 
            this.comboBox_datasets.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox_datasets.FormattingEnabled = true;
            this.comboBox_datasets.Items.AddRange(new object[] {
            "airline",
            "breast-cancer",
            "contact-lenses",
            "cpu",
            "cpu.with.vendor",
            "diabetes",
            "glass",
            "hypothyroid",
            "ionosphere",
            "iris",
            "labor",
            "iris.2D",
            "soybean",
            "unbalanced",
            "vote",
            "weather.nominal",
            "weather.numeric"});
            this.comboBox_datasets.Location = new System.Drawing.Point(62, 71);
            this.comboBox_datasets.Name = "comboBox_datasets";
            this.comboBox_datasets.Size = new System.Drawing.Size(174, 21);
            this.comboBox_datasets.TabIndex = 2;
            this.comboBox_datasets.Text = "Please Select Dataset";
            this.comboBox_datasets.SelectedIndexChanged += new System.EventHandler(this.comboBox_datasets_SelectedIndexChanged);
            // 
            // pnl_intro
            // 
            this.pnl_intro.Controls.Add(this.comboBox_datasets);
            this.pnl_intro.Controls.Add(this.btn_select_dataset);
            this.pnl_intro.Controls.Add(this.lbl_welcome);
            this.pnl_intro.Location = new System.Drawing.Point(12, 13);
            this.pnl_intro.Name = "pnl_intro";
            this.pnl_intro.Size = new System.Drawing.Size(655, 421);
            this.pnl_intro.TabIndex = 3;
            this.pnl_intro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_intro_Paint);
            // 
            // pnl_dataset_info
            // 
            this.pnl_dataset_info.Controls.Add(this.dataset_info_textbox);
            this.pnl_dataset_info.Controls.Add(this.lbl_dataset_name);
            this.pnl_dataset_info.Controls.Add(this.btn_cont_with_dataset);
            this.pnl_dataset_info.Controls.Add(this.btn_back);
            this.pnl_dataset_info.Location = new System.Drawing.Point(12, 12);
            this.pnl_dataset_info.Name = "pnl_dataset_info";
            this.pnl_dataset_info.Size = new System.Drawing.Size(655, 422);
            this.pnl_dataset_info.TabIndex = 4;
            this.pnl_dataset_info.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_dataset_info_Paint);
            // 
            // lbl_dataset_name
            // 
            this.lbl_dataset_name.AutoSize = true;
            this.lbl_dataset_name.Location = new System.Drawing.Point(21, 72);
            this.lbl_dataset_name.Name = "lbl_dataset_name";
            this.lbl_dataset_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_dataset_name.TabIndex = 2;
            this.lbl_dataset_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cont_with_dataset
            // 
            this.btn_cont_with_dataset.Location = new System.Drawing.Point(455, 270);
            this.btn_cont_with_dataset.Name = "btn_cont_with_dataset";
            this.btn_cont_with_dataset.Size = new System.Drawing.Size(92, 27);
            this.btn_cont_with_dataset.TabIndex = 1;
            this.btn_cont_with_dataset.Text = "Continue";
            this.btn_cont_with_dataset.UseVisualStyleBackColor = true;
            this.btn_cont_with_dataset.Click += new System.EventHandler(this.btn_cont_with_dataset_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 27);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_welcome_page_Click);
            // 
            // dataset_info_textbox
            // 
            this.dataset_info_textbox.Location = new System.Drawing.Point(22, 93);
            this.dataset_info_textbox.Multiline = true;
            this.dataset_info_textbox.Name = "dataset_info_textbox";
            this.dataset_info_textbox.Size = new System.Drawing.Size(413, 159);
            this.dataset_info_textbox.TabIndex = 3;
            this.dataset_info_textbox.TextChanged += new System.EventHandler(this.dataset_info_textbox_TextChanged);
            // 
            // pnl_result_and_prediction
            // 
            this.pnl_result_and_prediction.Controls.Add(this.lbl_prediction);
            this.pnl_result_and_prediction.Controls.Add(this.prediction_panel);
            this.pnl_result_and_prediction.Controls.Add(this.btn_back_info_page);
            this.pnl_result_and_prediction.Controls.Add(this.btn_exit);
            this.pnl_result_and_prediction.Controls.Add(this.btn_predict);
            this.pnl_result_and_prediction.Controls.Add(this.lbl_result_for_dataset);
            this.pnl_result_and_prediction.Location = new System.Drawing.Point(9, 12);
            this.pnl_result_and_prediction.Name = "pnl_result_and_prediction";
            this.pnl_result_and_prediction.Size = new System.Drawing.Size(655, 422);
            this.pnl_result_and_prediction.TabIndex = 5;
            // 
            // lbl_result_for_dataset
            // 
            this.lbl_result_for_dataset.AutoSize = true;
            this.lbl_result_for_dataset.Location = new System.Drawing.Point(28, 21);
            this.lbl_result_for_dataset.Name = "lbl_result_for_dataset";
            this.lbl_result_for_dataset.Size = new System.Drawing.Size(35, 13);
            this.lbl_result_for_dataset.TabIndex = 0;
            this.lbl_result_for_dataset.Text = "label1";
            // 
            // btn_predict
            // 
            this.btn_predict.Location = new System.Drawing.Point(282, 343);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(116, 31);
            this.btn_predict.TabIndex = 1;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = true;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(524, 346);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 25);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back_info_page
            // 
            this.btn_back_info_page.Location = new System.Drawing.Point(62, 349);
            this.btn_back_info_page.Name = "btn_back_info_page";
            this.btn_back_info_page.Size = new System.Drawing.Size(95, 25);
            this.btn_back_info_page.TabIndex = 3;
            this.btn_back_info_page.Text = "Back";
            this.btn_back_info_page.UseVisualStyleBackColor = true;
            this.btn_back_info_page.Click += new System.EventHandler(this.btn_back_info_page_Click);
            // 
            // prediction_panel
            // 
            this.prediction_panel.Location = new System.Drawing.Point(32, 88);
            this.prediction_panel.Name = "prediction_panel";
            this.prediction_panel.Size = new System.Drawing.Size(480, 224);
            this.prediction_panel.TabIndex = 4;
            // 
            // lbl_prediction
            // 
            this.lbl_prediction.AutoSize = true;
            this.lbl_prediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_prediction.Location = new System.Drawing.Point(547, 105);
            this.lbl_prediction.Name = "lbl_prediction";
            this.lbl_prediction.Size = new System.Drawing.Size(0, 20);
            this.lbl_prediction.TabIndex = 5;
            // 
            // Deuceng_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(772, 489);
            this.Controls.Add(this.pnl_result_and_prediction);
            this.Controls.Add(this.pnl_dataset_info);
            this.Controls.Add(this.pnl_intro);
            this.Name = "Deuceng_Form";
            this.Text = "DEUCENG - DSS Classification Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_intro.ResumeLayout(false);
            this.pnl_intro.PerformLayout();
            this.pnl_dataset_info.ResumeLayout(false);
            this.pnl_dataset_info.PerformLayout();
            this.pnl_result_and_prediction.ResumeLayout(false);
            this.pnl_result_and_prediction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_select_dataset;
        private System.Windows.Forms.ComboBox comboBox_datasets;
        private System.Windows.Forms.Panel pnl_intro;
        private System.Windows.Forms.Panel pnl_dataset_info;
        private System.Windows.Forms.Button btn_cont_with_dataset;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_dataset_name;
        private System.Windows.Forms.TextBox dataset_info_textbox;
        private System.Windows.Forms.Panel pnl_result_and_prediction;
        private System.Windows.Forms.Button btn_back_info_page;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label lbl_result_for_dataset;
        private System.Windows.Forms.Panel prediction_panel;
        private System.Windows.Forms.Label lbl_prediction;
    }
}

