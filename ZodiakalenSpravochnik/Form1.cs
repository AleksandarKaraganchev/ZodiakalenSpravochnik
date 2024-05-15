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
            stones[0] = "Агат";
            stones[1] = "Аметист";
            stones[2] = "Топаз";
            stones[3] = "Смарагд";
            stones[4] = "Сапфир";
            stones[5] = "Аквамарин";
            stones[6] = "Опал";
            stones[7] = "Турмалин";
            stones[8] = "Диамант";
            stones[9] = "Топаз";
            stones[10] = "Тюркоаз";
            stones[11] = "Аметист";
        }

        private void SetPeriods()
        {
            periods[0] = "21 Март - 19 Април";
            periods[1] = "20 Април - 20 Май";
            periods[2] = "21 Май - 20 Юни";
            periods[3] = "21 Юни - 22 Юли";
            periods[4] = "23 Юли - 22 Август";
            periods[5] = "23 Август - 22 Септември";
            periods[6] = "23 Септември - 22 Октомври";
            periods[7] = "23 Октомври - 21 Ноември";
            periods[8] = "22 Ноември - 21 Декември";
            periods[9] = "22 Декември - 19 Януари";
            periods[10] = "20 Януари - 18 Февруари";
            periods[11] = "19 Февруари - 20 Март";
        }

        private void SetPlanets()
        {
            planets[0] = "Марс";
            planets[1] = "Венера";
            planets[2] = "Меркурий";
            planets[3] = "Венера";
            planets[4] = "Меркурий";
            planets[5] = "Юпитер";
            planets[6] = "Луната";
            planets[7] = "Марс";
            planets[8] = "Венера";
            planets[9] = "Сатурн";
            planets[10] = "Слънцето";
            planets[11] = "Меркурий";
        }

        private void SetElements()
        {
            elements[0] = "Огън";
            elements[1] = "Огън";
            elements[2] = "Земя";
            elements[3] = "Земя";
            elements[4] = "Въздух";
            elements[5] = "Въздух";
            elements[6] = "Вода";
            elements[7] = "Вода";
            elements[8] = "Огън";
            elements[9] = "Огън";
            elements[10] = "Земя";
            elements[11] = "Въздух";
        }

        private void SetMottos()
        {
            mottos[0] = "Късметът помага на тези, които си помагат сами.";
            mottos[1] = "Никога не бива да се отказваш от мечтите си.";
            mottos[2] = "Животът е като книга - ако не пътуваш, четеш само една страница.";
            mottos[3] = "Вярвай в себе си и всичко е възможно.";
            mottos[4] = "Нека фантазията ти бъде безгранична.";
            mottos[5] = "Любовта и въображението са две от най-силните сили на света.";
            mottos[6] = "Вярвай във възможностите си и всичко е възможно.";
            mottos[7] = "Животът е къс, затова прекарвай го правилно.";
            mottos[8] = "Бъди добър със себе си и с другите.";
            mottos[9] = "Днешният момент е важен.";
            mottos[10] = "Има време за всичко.";
            mottos[11] = "Животът е пътешествие, не дестинация.";
        }

        private void SetColors()
        {
            colors[0] = "Червен";
            colors[1] = "Оранжев";
            colors[2] = "Жълт";
            colors[3] = "Зелен";
            colors[4] = "Син";
            colors[5] = "Индиго";
            colors[6] = "Виолетов";
            colors[7] = "Розов";
            colors[8] = "Бял";
            colors[9] = "Черен";
            colors[10] = "Кафяв";
            colors[11] = "Сив";
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