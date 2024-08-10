namespace GymApp
{
    partial class EditSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSubForm));
            TableLayouContainer = new System.Windows.Forms.TableLayoutPanel();
            TableLayoutForm = new System.Windows.Forms.TableLayoutPanel();
            SessionCountLabel = new System.Windows.Forms.Label();
            ExpiredDateLabel = new System.Windows.Forms.Label();
            SessionCountNumeric = new System.Windows.Forms.NumericUpDown();
            DateTimePickerExpiredTime = new Telerik.WinControls.UI.RadDateTimePicker();
            TableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            SubmitButton = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            TableLayouContainer.SuspendLayout();
            TableLayoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SessionCountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateTimePickerExpiredTime).BeginInit();
            TableLayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // TableLayouContainer
            // 
            TableLayouContainer.BackColor = System.Drawing.Color.LightGray;
            TableLayouContainer.ColumnCount = 3;
            TableLayouContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            TableLayouContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TableLayouContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            TableLayouContainer.Controls.Add(TableLayoutForm, 1, 1);
            TableLayouContainer.Controls.Add(TableLayoutButtons, 1, 2);
            TableLayouContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayouContainer.Location = new System.Drawing.Point(0, 0);
            TableLayouContainer.Name = "TableLayouContainer";
            TableLayouContainer.RowCount = 4;
            TableLayouContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            TableLayouContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TableLayouContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            TableLayouContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            TableLayouContainer.Size = new System.Drawing.Size(329, 245);
            TableLayouContainer.TabIndex = 0;
            // 
            // TableLayoutForm
            // 
            TableLayoutForm.ColumnCount = 2;
            TableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            TableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TableLayoutForm.Controls.Add(SessionCountLabel, 0, 0);
            TableLayoutForm.Controls.Add(ExpiredDateLabel, 0, 2);
            TableLayoutForm.Controls.Add(SessionCountNumeric, 1, 0);
            TableLayoutForm.Controls.Add(DateTimePickerExpiredTime, 1, 2);
            TableLayoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutForm.Location = new System.Drawing.Point(23, 23);
            TableLayoutForm.Name = "TableLayoutForm";
            TableLayoutForm.RowCount = 4;
            TableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            TableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            TableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            TableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            TableLayoutForm.Size = new System.Drawing.Size(283, 161);
            TableLayoutForm.TabIndex = 0;
            // 
            // SessionCountLabel
            // 
            SessionCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SessionCountLabel.AutoSize = true;
            SessionCountLabel.Location = new System.Drawing.Point(201, 6);
            SessionCountLabel.Name = "SessionCountLabel";
            SessionCountLabel.Size = new System.Drawing.Size(79, 17);
            SessionCountLabel.TabIndex = 0;
            SessionCountLabel.Text = "تعداد جلسات";
            // 
            // ExpiredDateLabel
            // 
            ExpiredDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ExpiredDateLabel.AutoSize = true;
            ExpiredDateLabel.Location = new System.Drawing.Point(217, 61);
            ExpiredDateLabel.Name = "ExpiredDateLabel";
            ExpiredDateLabel.Size = new System.Drawing.Size(63, 17);
            ExpiredDateLabel.TabIndex = 1;
            ExpiredDateLabel.Text = "تاریخ اتمام";
            // 
            // SessionCountNumeric
            // 
            SessionCountNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            SessionCountNumeric.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SessionCountNumeric.Location = new System.Drawing.Point(3, 3);
            SessionCountNumeric.Name = "SessionCountNumeric";
            SessionCountNumeric.Size = new System.Drawing.Size(187, 24);
            SessionCountNumeric.TabIndex = 2;
            // 
            // DateTimePickerExpiredTime
            // 
            DateTimePickerExpiredTime.CalendarSize = new System.Drawing.Size(290, 320);
            DateTimePickerExpiredTime.Dock = System.Windows.Forms.DockStyle.Fill;
            DateTimePickerExpiredTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DateTimePickerExpiredTime.Location = new System.Drawing.Point(3, 58);
            DateTimePickerExpiredTime.Name = "DateTimePickerExpiredTime";
            DateTimePickerExpiredTime.Size = new System.Drawing.Size(187, 26);
            DateTimePickerExpiredTime.TabIndex = 3;
            DateTimePickerExpiredTime.TabStop = false;
            DateTimePickerExpiredTime.Text = "Thursday, August 8, 2024";
            DateTimePickerExpiredTime.Value = new System.DateTime(2024, 8, 8, 10, 54, 44, 632);
            // 
            // TableLayoutButtons
            // 
            TableLayoutButtons.ColumnCount = 3;
            TableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            TableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            TableLayoutButtons.Controls.Add(SubmitButton, 0, 0);
            TableLayoutButtons.Controls.Add(CancelButton, 2, 0);
            TableLayoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutButtons.Location = new System.Drawing.Point(23, 190);
            TableLayoutButtons.Name = "TableLayoutButtons";
            TableLayoutButtons.RowCount = 1;
            TableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TableLayoutButtons.Size = new System.Drawing.Size(283, 32);
            TableLayoutButtons.TabIndex = 1;
            // 
            // SubmitButton
            // 
            SubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SubmitButton.Location = new System.Drawing.Point(186, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new System.Drawing.Size(94, 26);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "ثبت";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            CancelButton.Location = new System.Drawing.Point(3, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(94, 26);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "بازگشت";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditSubForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(329, 245);
            Controls.Add(TableLayouContainer);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditSubForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "ویرایش اشتراک";
            TableLayouContainer.ResumeLayout(false);
            TableLayoutForm.ResumeLayout(false);
            TableLayoutForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SessionCountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateTimePickerExpiredTime).EndInit();
            TableLayoutButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayouContainer;
        private System.Windows.Forms.TableLayoutPanel TableLayoutForm;
        private System.Windows.Forms.Label SessionCountLabel;
        private System.Windows.Forms.Label ExpiredDateLabel;
        private System.Windows.Forms.NumericUpDown SessionCountNumeric;
        private System.Windows.Forms.TableLayoutPanel TableLayoutButtons;
        private Telerik.WinControls.UI.RadDateTimePicker DateTimePickerExpiredTime;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
