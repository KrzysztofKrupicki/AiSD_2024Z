namespace program
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
            label1 = new Label();
            inputTextToConvert = new TextBox();
            buttonConvertToArray = new Button();
            buttonGenerateRandomArray = new Button();
            numericUpDownSize = new NumericUpDown();
            numericUpDownMinValue = new NumericUpDown();
            numericUpDownMaxValue = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonShowArray = new Button();
            label5 = new Label();
            buttonBubbleSort = new Button();
            buttonInsertionSort = new Button();
            buttonMergeSort = new Button();
            buttonQuickSort = new Button();
            label6 = new Label();
            inputResultOfSorting = new TextBox();
            labelSortingTime = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Wprowadź dane w postaci \"5,4,7...\"";
            // 
            // inputTextToConvert
            // 
            inputTextToConvert.Location = new Point(12, 27);
            inputTextToConvert.Name = "inputTextToConvert";
            inputTextToConvert.Size = new Size(191, 23);
            inputTextToConvert.TabIndex = 1;
            // 
            // buttonConvertToArray
            // 
            buttonConvertToArray.Location = new Point(12, 56);
            buttonConvertToArray.Name = "buttonConvertToArray";
            buttonConvertToArray.Size = new Size(191, 23);
            buttonConvertToArray.TabIndex = 2;
            buttonConvertToArray.Text = "Konwertuj na tablicę";
            buttonConvertToArray.UseVisualStyleBackColor = true;
            buttonConvertToArray.Click += ButtonConvertToArray_Click;
            // 
            // buttonGenerateRandomArray
            // 
            buttonGenerateRandomArray.Location = new Point(219, 94);
            buttonGenerateRandomArray.Name = "buttonGenerateRandomArray";
            buttonGenerateRandomArray.Size = new Size(244, 23);
            buttonGenerateRandomArray.TabIndex = 3;
            buttonGenerateRandomArray.Text = "Generuj tablicę";
            buttonGenerateRandomArray.UseVisualStyleBackColor = true;
            buttonGenerateRandomArray.Click += ButtonGenerateRandomArray_Click;
            // 
            // numericUpDownSize
            // 
            numericUpDownSize.Location = new Point(343, 7);
            numericUpDownSize.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSize.Name = "numericUpDownSize";
            numericUpDownSize.Size = new Size(120, 23);
            numericUpDownSize.TabIndex = 4;
            numericUpDownSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownMinValue
            // 
            numericUpDownMinValue.Location = new Point(343, 36);
            numericUpDownMinValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownMinValue.Name = "numericUpDownMinValue";
            numericUpDownMinValue.Size = new Size(120, 23);
            numericUpDownMinValue.TabIndex = 5;
            // 
            // numericUpDownMaxValue
            // 
            numericUpDownMaxValue.Location = new Point(343, 65);
            numericUpDownMaxValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            numericUpDownMaxValue.Size = new Size(120, 23);
            numericUpDownMaxValue.TabIndex = 6;
            numericUpDownMaxValue.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 9);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 7;
            label2.Text = "Ilość elementów";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 38);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 8;
            label3.Text = "Minimalna wartość";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 67);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 9;
            label4.Text = "Maksymalna wartość";
            // 
            // buttonShowArray
            // 
            buttonShowArray.Location = new Point(12, 94);
            buttonShowArray.Name = "buttonShowArray";
            buttonShowArray.Size = new Size(191, 23);
            buttonShowArray.TabIndex = 10;
            buttonShowArray.Text = "Pokaż tablicę";
            buttonShowArray.UseVisualStyleBackColor = true;
            buttonShowArray.Click += ButtonShowArray_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 11;
            label5.Text = "Wybierz algorytm sortujący";
            // 
            // buttonBubbleSort
            // 
            buttonBubbleSort.Location = new Point(12, 158);
            buttonBubbleSort.Name = "buttonBubbleSort";
            buttonBubbleSort.Size = new Size(100, 23);
            buttonBubbleSort.TabIndex = 12;
            buttonBubbleSort.Text = "bubbleSort";
            buttonBubbleSort.UseVisualStyleBackColor = true;
            buttonBubbleSort.Click += ButtonBubbleSort_Click;
            // 
            // buttonInsertionSort
            // 
            buttonInsertionSort.Location = new Point(118, 158);
            buttonInsertionSort.Name = "buttonInsertionSort";
            buttonInsertionSort.Size = new Size(100, 23);
            buttonInsertionSort.TabIndex = 13;
            buttonInsertionSort.Text = "insertionSort";
            buttonInsertionSort.UseVisualStyleBackColor = true;
            buttonInsertionSort.Click += ButtonInsertionSort_Click;
            // 
            // buttonMergeSort
            // 
            buttonMergeSort.Location = new Point(224, 158);
            buttonMergeSort.Name = "buttonMergeSort";
            buttonMergeSort.Size = new Size(100, 23);
            buttonMergeSort.TabIndex = 14;
            buttonMergeSort.Text = "mergeSort";
            buttonMergeSort.UseVisualStyleBackColor = true;
            buttonMergeSort.Click += ButtonMergeSort_Click;
            // 
            // buttonQuickSort
            // 
            buttonQuickSort.Location = new Point(330, 158);
            buttonQuickSort.Name = "buttonQuickSort";
            buttonQuickSort.Size = new Size(100, 23);
            buttonQuickSort.TabIndex = 15;
            buttonQuickSort.Text = "quickSort";
            buttonQuickSort.UseVisualStyleBackColor = true;
            buttonQuickSort.Click += ButtonQuickSort_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 16;
            label6.Text = "Wynik sortowania:";
            // 
            // inputResultOfSorting
            // 
            inputResultOfSorting.Location = new Point(12, 226);
            inputResultOfSorting.Name = "inputResultOfSorting";
            inputResultOfSorting.Size = new Size(312, 23);
            inputResultOfSorting.TabIndex = 17;
            // 
            // labelSortingTime
            // 
            labelSortingTime.AutoSize = true;
            labelSortingTime.Location = new Point(12, 252);
            labelSortingTime.Name = "labelSortingTime";
            labelSortingTime.Size = new Size(98, 15);
            labelSortingTime.TabIndex = 18;
            labelSortingTime.Text = "Czas sortowania: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 285);
            Controls.Add(labelSortingTime);
            Controls.Add(inputResultOfSorting);
            Controls.Add(label6);
            Controls.Add(buttonQuickSort);
            Controls.Add(buttonMergeSort);
            Controls.Add(buttonInsertionSort);
            Controls.Add(buttonBubbleSort);
            Controls.Add(label5);
            Controls.Add(buttonShowArray);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownMaxValue);
            Controls.Add(numericUpDownMinValue);
            Controls.Add(numericUpDownSize);
            Controls.Add(buttonGenerateRandomArray);
            Controls.Add(buttonConvertToArray);
            Controls.Add(inputTextToConvert);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextToConvert;
        private Button buttonConvertToArray;
        private Button buttonGenerateRandomArray;
        private NumericUpDown numericUpDownSize;
        private NumericUpDown numericUpDownMinValue;
        private NumericUpDown numericUpDownMaxValue;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonShowArray;
        private Label label5;
        private Button buttonBubbleSort;
        private Button buttonInsertionSort;
        private Button buttonMergeSort;
        private Button buttonQuickSort;
        private Label label6;
        private TextBox inputResultOfSorting;
        private Label labelSortingTime;
    }
}
