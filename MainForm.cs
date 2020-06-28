using System;
using System.Windows.Forms;

namespace Laba4_ShellSort
{
    //Форма для отображения процесса сортировки Шелла для целых чисел
    public partial class MainForm : Form
    {
        int N = 20;
        int[] array = new int[20]; //массив для хранения сортируемых чисел
        ShellSorter sorter = new ShellSorter();//объект для управления сортировкой Шелла

        public MainForm()
        {
            InitializeComponent();
        }
        //Рандомное заполнение массива из N чисел
        private void buttonFillArrayWithRandomNumbers_Click(object sender, EventArgs e)
        {
            listBoxForNums.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < N; ++i)
            {
                array[i] = random.Next(1001);
                listBoxForNums.Items.Add(array[i]);
            }

            if (!buttonSortArray.Enabled)
            {
                buttonSortArray.Enabled = true;
            }
        }

        private void DemoModeForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < N; ++i)
            {
                listBoxForSelectedNums.Items.Add("");
                listBoxForSwapNums.Items.Add("");
            }
        }
        //Начать показ сортировки
        private void buttonSortArray_Click(object sender, EventArgs e)
        {
            sorter.SortForCartoon(array, listBoxForNums, listBoxForSelectedNums, listBoxForSwapNums);
            string text = "Сортировка окончена.\nЧисло перестановок: " + sorter.NumberOfSwaps + "\nЧисло сравнений: " + sorter.NumberOfCompares;
            MessageBox.Show(this, text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
