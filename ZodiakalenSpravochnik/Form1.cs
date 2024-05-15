namespace ZodiakalenSpravochnik
{
    public partial class Form1 : Form
    {
        string[] colors = new string[12];
        string[] mottos = new string[12];
        string[] elements = new string[12];
        string[] planets = new string[12];
        string[] periods = new string[12];
        string[] stones = new string[12];

        int selectedZodiacIndex = -1;
        public Form1()
        {  
                InitializeComponent();
                InitializeArrays();
        }
        private void InitializeArrays()
        {

            SetColors();
            SetMottos();
            SetElements();
            SetPlanets();
            SetPeriods();
            SetStones();
        }

        private void SetStones()
        {
            stones[0] = "����";
            stones[1] = "�������";
            stones[2] = "�����";
            stones[3] = "�������";
            stones[4] = "������";
            stones[5] = "���������";
            stones[6] = "����";
            stones[7] = "��������";
            stones[8] = "�������";
            stones[9] = "�����";
            stones[10] = "�������";
            stones[11] = "�������";
        }

        private void SetPeriods()
        {
            periods[0] = "21 ���� - 19 �����";
            periods[1] = "20 ����� - 20 ���";
            periods[2] = "21 ��� - 20 ���";
            periods[3] = "21 ��� - 22 ���";
            periods[4] = "23 ��� - 22 ������";
            periods[5] = "23 ������ - 22 ���������";
            periods[6] = "23 ��������� - 22 ��������";
            periods[7] = "23 �������� - 21 �������";
            periods[8] = "22 ������� - 21 ��������";
            periods[9] = "22 �������� - 19 ������";
            periods[10] = "20 ������ - 18 ��������";
            periods[11] = "19 �������� - 20 ����";
        }

        private void SetPlanets()
        {
            planets[0] = "����";
            planets[1] = "������";
            planets[2] = "��������";
            planets[3] = "������";
            planets[4] = "��������";
            planets[5] = "������";
            planets[6] = "������";
            planets[7] = "����";
            planets[8] = "������";
            planets[9] = "������";
            planets[10] = "��������";
            planets[11] = "��������";
        }

        private void SetElements()
        {
            elements[0] = "����";
            elements[1] = "����";
            elements[2] = "����";
            elements[3] = "����";
            elements[4] = "������";
            elements[5] = "������";
            elements[6] = "����";
            elements[7] = "����";
            elements[8] = "����";
            elements[9] = "����";
            elements[10] = "����";
            elements[11] = "������";
        }

        private void SetMottos()
        {
            mottos[0] = "�������� ������ �� ����, ����� �� ������� ����.";
            mottos[1] = "������ �� ���� �� �� �������� �� ������� ��.";
            mottos[2] = "������� � ���� ����� - ��� �� �������, ����� ���� ���� ��������.";
            mottos[3] = "������ � ���� �� � ������ � ��������.";
            mottos[4] = "���� ���������� �� ���� �����������.";
            mottos[5] = "������� � ������������� �� ��� �� ���-������� ���� �� �����.";
            mottos[6] = "������ ��� ������������� �� � ������ � ��������.";
            mottos[7] = "������� � ���, ������ ��������� �� ��������.";
            mottos[8] = "���� ����� ��� ���� �� � � �������.";
            mottos[9] = "�������� ������ � �����.";
            mottos[10] = "��� ����� �� ������.";
            mottos[11] = "������� � �����������, �� ����������.";
        }

        private void SetColors()
        {
            colors[0] = "������";
            colors[1] = "�������";
            colors[2] = "����";
            colors[3] = "�����";
            colors[4] = "���";
            colors[5] = "������";
            colors[6] = "��������";
            colors[7] = "�����";
            colors[8] = "���";
            colors[9] = "�����";
            colors[10] = "�����";
            colors[11] = "���";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbZodia.SelectedIndex = -1;
            selectedZodiacIndex = -1;
            lblTime.Text = "";
            lblDeviz.Text = "";
            lblColor.Text = "";
            lblPlanet.Text = "";
            lblElement.Text = "";
            lblStone.Text = "";
        }

        private void cbZodia_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedZodiacIndex = cbZodia.SelectedIndex;
            ShowZodiacInfo();
        }
        private void ShowZodiacInfo()
        {
            if (selectedZodiacIndex >= 0 && selectedZodiacIndex < 12)
            {
                lblTime.Text = periods[selectedZodiacIndex];
                lblDeviz.Text = mottos[selectedZodiacIndex];
                lblColor.Text = colors[selectedZodiacIndex];
                lblPlanet.Text = planets[selectedZodiacIndex];
                lblElement.Text = elements[selectedZodiacIndex];
                lblStone.Text = stones[selectedZodiacIndex];
            }
        }
    }
}