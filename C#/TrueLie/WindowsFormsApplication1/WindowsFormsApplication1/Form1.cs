using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static int GeneralDelay = 100;  //Задержка потоков сервера и клиента в милисекундах
        static String ProgrammName = "Верю не верю";  //Титул формы
        static int PortServer = 777;  //Порт сервера
        static String IPServer = "127.0.0.1",IPClient;  
        const int MyTopPos = 284,ChangePos = MyTopPos-20,ClientTopPos = 12;  //Позиции карт

        const int Cards = 36;
        static int inMyHands = (Cards / 2), inClientHands = (Cards / 2), hangUp = 0;
        static int[] CardDeck = new int[Cards];// = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35};
        static int[] MyCards = new int[Cards];//,ClientCards = new int[Cards];

        static Boolean MyMove = false;
        static int Upped = 0; const int maxUpped = 4;

        //Функция срабатывает при запуске
        public Form1()
        {
            //Меняем титул программы
            this.Text = ProgrammName;
            InitializeComponent();
            //Инициализируем карты
            InitializeArrOfCards();
            UpdatePosition();
            //Запускаем сервер
            Server(true);
        }

        public void InitializeArrOfCards()
        {
            //Заносим в массив информацию о том, что карты перевёрнуты
            int i; for (i = 0; i < Cards; i++) { MyCards[i] = 36; }
            //Говорим, что у каждого на руках по 18 карт
            inMyHands = 18; inClientHands = 18; Hided = 0;
            //Если карты уходили в отбой, то работала команда Visible = false;
            //Следующий длинный блок, позволяет снова всё отобразить
            if (this.LocalCard1.InvokeRequired)
            { this.LocalCard1.BeginInvoke((MethodInvoker)delegate() { LocalCard1.Visible = true; }); }
            else { LocalCard1.Visible = true; }
            if (this.LocalCard2.InvokeRequired)
            { this.LocalCard2.BeginInvoke((MethodInvoker)delegate() { LocalCard2.Visible = true; }); }
            else { LocalCard2.Visible = true; }
            if (this.LocalCard3.InvokeRequired)
            { this.LocalCard3.BeginInvoke((MethodInvoker)delegate() { LocalCard3.Visible = true; }); }
            else { LocalCard3.Visible = true; }
            if (this.LocalCard4.InvokeRequired)
            { this.LocalCard4.BeginInvoke((MethodInvoker)delegate() { LocalCard4.Visible = true; }); }
            else { LocalCard4.Visible = true; }
            if (this.LocalCard5.InvokeRequired)
            { this.LocalCard5.BeginInvoke((MethodInvoker)delegate() { LocalCard5.Visible = true; }); }
            else { LocalCard5.Visible = true; }
            if (this.LocalCard6.InvokeRequired)
            { this.LocalCard6.BeginInvoke((MethodInvoker)delegate() { LocalCard6.Visible = true; }); }
            else { LocalCard6.Visible = true; }
            if (this.LocalCard7.InvokeRequired)
            { this.LocalCard7.BeginInvoke((MethodInvoker)delegate() { LocalCard7.Visible = true; }); }
            else { LocalCard7.Visible = true; }
            if (this.LocalCard8.InvokeRequired)
            { this.LocalCard8.BeginInvoke((MethodInvoker)delegate() { LocalCard8.Visible = true; }); }
            else { LocalCard8.Visible = true; }
            if (this.LocalCard9.InvokeRequired)
            { this.LocalCard9.BeginInvoke((MethodInvoker)delegate() { LocalCard9.Visible = true; }); }
            else { LocalCard9.Visible = true; }
            if (this.LocalCard10.InvokeRequired)
            { this.LocalCard10.BeginInvoke((MethodInvoker)delegate() { LocalCard10.Visible = true; }); }
            else { LocalCard10.Visible = true; }
            if (this.LocalCard11.InvokeRequired)
            { this.LocalCard11.BeginInvoke((MethodInvoker)delegate() { LocalCard11.Visible = true; }); }
            else { LocalCard11.Visible = true; }
            if (this.LocalCard12.InvokeRequired)
            { this.LocalCard12.BeginInvoke((MethodInvoker)delegate() { LocalCard12.Visible = true; }); }
            else { LocalCard12.Visible = true; }
            if (this.LocalCard13.InvokeRequired)
            { this.LocalCard13.BeginInvoke((MethodInvoker)delegate() { LocalCard13.Visible = true; }); }
            else { LocalCard13.Visible = true; }
            if (this.LocalCard14.InvokeRequired)
            { this.LocalCard14.BeginInvoke((MethodInvoker)delegate() { LocalCard14.Visible = true; }); }
            else { LocalCard14.Visible = true; }
            if (this.LocalCard15.InvokeRequired)
            { this.LocalCard15.BeginInvoke((MethodInvoker)delegate() { LocalCard15.Visible = true; }); }
            else { LocalCard15.Visible = true; }
            if (this.LocalCard16.InvokeRequired)
            { this.LocalCard16.BeginInvoke((MethodInvoker)delegate() { LocalCard16.Visible = true; }); }
            else { LocalCard16.Visible = true; }
            if (this.LocalCard17.InvokeRequired)
            { this.LocalCard17.BeginInvoke((MethodInvoker)delegate() { LocalCard17.Visible = true; }); }
            else { LocalCard17.Visible = true; }
            if (this.LocalCard18.InvokeRequired)
            { this.LocalCard18.BeginInvoke((MethodInvoker)delegate() { LocalCard18.Visible = true; }); }
            else { LocalCard18.Visible = true; }
            if (this.LocalCard19.InvokeRequired)
            { this.LocalCard19.BeginInvoke((MethodInvoker)delegate() { LocalCard19.Visible = true; }); }
            else { LocalCard19.Visible = true; }
            if (this.LocalCard20.InvokeRequired)
            { this.LocalCard20.BeginInvoke((MethodInvoker)delegate() { LocalCard20.Visible = true; }); }
            else { LocalCard20.Visible = true; }
            if (this.LocalCard21.InvokeRequired)
            { this.LocalCard21.BeginInvoke((MethodInvoker)delegate() { LocalCard21.Visible = true; }); }
            else { LocalCard21.Visible = true; }
            if (this.LocalCard22.InvokeRequired)
            { this.LocalCard22.BeginInvoke((MethodInvoker)delegate() { LocalCard22.Visible = true; }); }
            else { LocalCard22.Visible = true; }
            if (this.LocalCard23.InvokeRequired)
            { this.LocalCard23.BeginInvoke((MethodInvoker)delegate() { LocalCard23.Visible = true; }); }
            else { LocalCard23.Visible = true; }
            if (this.LocalCard24.InvokeRequired)
            { this.LocalCard24.BeginInvoke((MethodInvoker)delegate() { LocalCard24.Visible = true; }); }
            else { LocalCard24.Visible = true; }
            if (this.LocalCard25.InvokeRequired)
            { this.LocalCard25.BeginInvoke((MethodInvoker)delegate() { LocalCard25.Visible = true; }); }
            else { LocalCard25.Visible = true; }
            if (this.LocalCard26.InvokeRequired)
            { this.LocalCard26.BeginInvoke((MethodInvoker)delegate() { LocalCard26.Visible = true; }); }
            else { LocalCard26.Visible = true; }
            if (this.LocalCard27.InvokeRequired)
            { this.LocalCard27.BeginInvoke((MethodInvoker)delegate() { LocalCard27.Visible = true; }); }
            else { LocalCard27.Visible = true; }
            if (this.LocalCard28.InvokeRequired)
            { this.LocalCard28.BeginInvoke((MethodInvoker)delegate() { LocalCard28.Visible = true; }); }
            else { LocalCard28.Visible = true; }
            if (this.LocalCard29.InvokeRequired)
            { this.LocalCard29.BeginInvoke((MethodInvoker)delegate() { LocalCard29.Visible = true; }); }
            else { LocalCard29.Visible = true; }
            if (this.LocalCard30.InvokeRequired)
            { this.LocalCard30.BeginInvoke((MethodInvoker)delegate() { LocalCard30.Visible = true; }); }
            else { LocalCard30.Visible = true; }
            if (this.LocalCard31.InvokeRequired)
            { this.LocalCard31.BeginInvoke((MethodInvoker)delegate() { LocalCard31.Visible = true; }); }
            else { LocalCard31.Visible = true; }
            if (this.LocalCard32.InvokeRequired)
            { this.LocalCard32.BeginInvoke((MethodInvoker)delegate() { LocalCard32.Visible = true; }); }
            else { LocalCard32.Visible = true; }
            if (this.LocalCard33.InvokeRequired)
            { this.LocalCard33.BeginInvoke((MethodInvoker)delegate() { LocalCard33.Visible = true; }); }
            else { LocalCard33.Visible = true; }
            if (this.LocalCard34.InvokeRequired)
            { this.LocalCard34.BeginInvoke((MethodInvoker)delegate() { LocalCard34.Visible = true; }); }
            else { LocalCard34.Visible = true; }
            if (this.LocalCard35.InvokeRequired)
            { this.LocalCard35.BeginInvoke((MethodInvoker)delegate() { LocalCard35.Visible = true; }); }
            else { LocalCard35.Visible = true; }
            if (this.LocalCard36.InvokeRequired)
            { this.LocalCard36.BeginInvoke((MethodInvoker)delegate() { LocalCard36.Visible = true; }); }
            else { LocalCard36.Visible = true; }
            //Поставить карты на свои места
            UpdatePosition();
            //MessageBox.Show("I am worked Now");
        }

        //Активировать кнопки для следующего хода: 6,7,8,9,10,J,Q,K,A, Кнопка ходить
        public void ChangeMyMove(Boolean isMy)
        {
            if (this.RadioButton6.InvokeRequired)
            { this.RadioButton6.BeginInvoke((MethodInvoker)delegate() { this.RadioButton6.Enabled = isMy; }); }
            else { this.RadioButton6.Enabled = isMy; }
                //RadioButton6.Enabled = isMy;
            if (this.RadioButton7.InvokeRequired)
            { this.RadioButton7.BeginInvoke((MethodInvoker)delegate() { this.RadioButton7.Enabled = isMy; }); }
            else { this.RadioButton7.Enabled = isMy; }
                //RadioButton7.Enabled = isMy;
            if (this.RadioButton8.InvokeRequired)
            { this.RadioButton8.BeginInvoke((MethodInvoker)delegate() { this.RadioButton8.Enabled = isMy; }); }
            else { this.RadioButton8.Enabled = isMy; }
                //RadioButton8.Enabled = isMy;
            if (this.RadioButton9.InvokeRequired)
            { this.RadioButton9.BeginInvoke((MethodInvoker)delegate() { this.RadioButton9.Enabled = isMy; }); }
            else { this.RadioButton9.Enabled = isMy; }
                //RadioButton9.Enabled = isMy;
            if (this.RadioButton10.InvokeRequired)
            { this.RadioButton10.BeginInvoke((MethodInvoker)delegate() { this.RadioButton10.Enabled = isMy; }); }
            else { this.RadioButton10.Enabled = isMy; }
                //RadioButton10.Enabled = isMy;
            if (this.RadioButtonJ.InvokeRequired)
            { this.RadioButtonJ.BeginInvoke((MethodInvoker)delegate() { this.RadioButtonJ.Enabled = isMy; }); }
            else { this.RadioButtonJ.Enabled = isMy; }
                //RadioButtonJ.Enabled = isMy;
            if (this.RadioButtonQ.InvokeRequired)
            { this.RadioButtonQ.BeginInvoke((MethodInvoker)delegate() { this.RadioButtonQ.Enabled = isMy; }); }
            else { this.RadioButtonQ.Enabled = isMy; }
                //RadioButtonQ.Enabled = isMy;
            if (this.RadioButtonK.InvokeRequired)
            { this.RadioButtonK.BeginInvoke((MethodInvoker)delegate() { this.RadioButtonK.Enabled = isMy; }); }
            else { this.RadioButtonK.Enabled = isMy; }
                //RadioButtonK.Enabled = isMy;
            if (this.RadioButtonA.InvokeRequired)
            { this.RadioButtonA.BeginInvoke((MethodInvoker)delegate() { this.RadioButtonA.Enabled = isMy; }); }
            else { this.RadioButtonA.Enabled = isMy; }
                //RadioButtonA.Enabled = isMy;
                MyMove = isMy;
                if (this.ButtonGo.InvokeRequired)
                { this.ButtonGo.BeginInvoke((MethodInvoker)delegate() { this.ButtonGo.Enabled = isMy; }); }
                else { this.ButtonGo.Enabled = isMy; }
                //ButtonGo.Enabled = isMy;
                //buttonLie.Enabled = !isMy;
                //buttonTruth.Enabled = !isMy;
        }

        //Функция кнопки(Включить сервер). Кнопку скрыл, так как включение сервера сделал по запуску программы
        private void button1_Click(object sender, EventArgs e)
        {
            const string ServerOn = "Включить сервер";
            const string ServerOff = "Выключить сервер";
            //Включаем|Выключаем сервер
            if(ButtonServer.Text == ServerOn)
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        IPServer = ip.ToString();
                    }
                }
                labelMyIP.Text = "Мой IP: " + IPServer;
                labelMyIP.Visible = true;
                textBoxIP.Visible = false;
                ButtonConnect.Visible = false;
                Server(true);
                RandomShuffle();
                RandomShuffle();
                ChangeMyMove(true);
                ButtonServer.Text = ServerOff;
                
            }
            else
            {
                Server(false);
                hideCards();
                ButtonServer.Text = ServerOn;
                labelMyIP.Visible = false;
                textBoxIP.Visible = true;
                ButtonConnect.Visible = true;
                ChangeMyMove(false);
            }
        }

        //Включение/выключение сервера
        public void Server(Boolean Start)
        {
            try{
                if (Start)
                {
                    //Получаем IP локального компьютера 192.168.0.---;
                    var host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (var ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            IPServer = ip.ToString();
                        }
                    }
                    labelMyIP.Text = "Мой IP: " + IPServer;
                    labelMyIP.Visible = true;

                    //Добавляем новый поток, для работы с объектами формы после получения сообщений от клиента
                    if (!BackgroundServerWorking) { backgroundServer.RunWorkerAsync(); }

                    //Запускаем сервер
                    ServerWorked = true;
                    ServerThread = new Thread(ServerRun);
                    ServerThread.Start();
                } else {
                        //Останавливаем сервер
                        ServerWorked = false;
                        ServerThread.Interrupt();
                        ServerListener.Stop();
                }
            } catch(Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }
        }

        static Boolean ServerWorked = false;

        static Boolean ClientThreadWorked = false;

        Thread ServerThread = new Thread(ServerRun);
        static TcpListener ServerListener = new TcpListener(IPAddress.Any, PortServer);
        static string receive = "",send_to_server = "";
        

        public void Client(Boolean start)
        {
            if (start)
            {
                //Подключаемся к серверу включая клиента
                ClientThreadWorked = true;
                IPClient = textBoxIP.Text;
                ClientThread = new Thread(ClientRun);
                ClientThread.Start();
            }
            else
            {
                //Останавливаем работу клиента
                ClientThreadWorked = false;
            }
        }

        static Thread ClientThread = new Thread(ClientRun);

        static Boolean IamClient = false;
        static String FirstMessage = "Hello World!";
        static Boolean SendStroke = false;

        //Спрятать центральные объекты для входа и показать серверу кнопку - новая игра
        public void HideConnect(Boolean Hide)
        {
            if (this.ButtonConnect.InvokeRequired)
            { this.ButtonConnect.BeginInvoke((MethodInvoker)delegate() { this.ButtonConnect.Visible = !Hide; }); }
            else { this.ButtonConnect.Visible = !Hide; }

            if (this.textBoxIP.InvokeRequired)
            { this.textBoxIP.BeginInvoke((MethodInvoker)delegate() { this.textBoxIP.Visible = !Hide; }); }
            else { this.textBoxIP.Visible = !Hide; }
            if (this.labelMyIP.InvokeRequired)
            { this.labelMyIP.BeginInvoke((MethodInvoker)delegate() { this.labelMyIP.Visible = !Hide; }); }
            else { this.labelMyIP.Visible = !Hide; }
            //this.textBoxIP.Visible = !Hide;
            //this.labelMyIP.Visible = !Hide;
            if (this.ButtonDisconnect.InvokeRequired)
            { this.ButtonDisconnect.BeginInvoke((MethodInvoker)delegate() { this.ButtonDisconnect.Visible = Hide; }); }
            else { this.ButtonDisconnect.Visible = Hide; }
            //this.ButtonDisconnect.Visible = Hide;
            if (!IamClient) {
                if (this.ButtonNewGame.InvokeRequired)
                { this.ButtonNewGame.BeginInvoke((MethodInvoker)delegate() { this.ButtonNewGame.Visible = Hide; }); }
                else { this.ButtonNewGame.Visible = Hide; }
                //this.ButtonNewGame.Visible = Hide; 
            }
        }

        //Визуально перевернуть все карты
        public void hideCards()
        {
            if (this.LocalCard1.InvokeRequired)
            { this.LocalCard1.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard1, 36); }); }
            else { ChangeCard(LocalCard1, 36); }
            if (this.LocalCard2.InvokeRequired)
            { this.LocalCard2.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard2, 36); }); }
            else { ChangeCard(LocalCard2, 36); }
            if (this.LocalCard3.InvokeRequired)
            { this.LocalCard3.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard3, 36); }); }
            else { ChangeCard(LocalCard3, 36); }
            if (this.LocalCard4.InvokeRequired)
            { this.LocalCard4.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard4, 36); }); }
            else { ChangeCard(LocalCard4, 36); }
            if (this.LocalCard5.InvokeRequired)
            { this.LocalCard5.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard5, 36); }); }
            else { ChangeCard(LocalCard5, 36); }
            if (this.LocalCard6.InvokeRequired)
            { this.LocalCard6.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard6, 36); }); }
            else { ChangeCard(LocalCard6, 36); }
            if (this.LocalCard7.InvokeRequired)
            { this.LocalCard7.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard7, 36); }); }
            else { ChangeCard(LocalCard7, 36); }
            if (this.LocalCard8.InvokeRequired)
            { this.LocalCard8.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard8, 36); }); }
            else { ChangeCard(LocalCard8, 36); }
            if (this.LocalCard9.InvokeRequired)
            { this.LocalCard9.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard9, 36); }); }
            else { ChangeCard(LocalCard9, 36); }
            if (this.LocalCard10.InvokeRequired)
            { this.LocalCard10.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard10, 36); }); }
            else { ChangeCard(LocalCard10, 36); }
            if (this.LocalCard11.InvokeRequired)
            { this.LocalCard11.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard11, 36); }); }
            else { ChangeCard(LocalCard11, 36); }
            if (this.LocalCard12.InvokeRequired)
            { this.LocalCard12.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard12, 36); }); }
            else { ChangeCard(LocalCard12, 36); }
            if (this.LocalCard13.InvokeRequired)
            { this.LocalCard13.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard13, 36); }); }
            else { ChangeCard(LocalCard13, 36); }
            if (this.LocalCard14.InvokeRequired)
            { this.LocalCard14.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard14, 36); }); }
            else { ChangeCard(LocalCard14, 36); }
            if (this.LocalCard15.InvokeRequired)
            { this.LocalCard15.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard15, 36); }); }
            else { ChangeCard(LocalCard15, 36); }
            if (this.LocalCard16.InvokeRequired)
            { this.LocalCard16.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard16, 36); }); }
            else { ChangeCard(LocalCard16, 36); }
            if (this.LocalCard17.InvokeRequired)
            { this.LocalCard17.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard17, 36); }); }
            else { ChangeCard(LocalCard17, 36); }
            if (this.LocalCard18.InvokeRequired)
            { this.LocalCard18.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard18, 36); }); }
            else { ChangeCard(LocalCard18, 36); }
            if (this.LocalCard19.InvokeRequired)
            { this.LocalCard19.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard19, 36); }); }
            else { ChangeCard(LocalCard19, 36); }
            if (this.LocalCard20.InvokeRequired)
            { this.LocalCard20.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard20, 36); }); }
            else { ChangeCard(LocalCard20, 36); }
            if (this.LocalCard21.InvokeRequired)
            { this.LocalCard21.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard21, 36); }); }
            else { ChangeCard(LocalCard21, 36); }
            if (this.LocalCard22.InvokeRequired)
            { this.LocalCard22.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard22, 36); }); }
            else { ChangeCard(LocalCard22, 36); }
            if (this.LocalCard23.InvokeRequired)
            { this.LocalCard23.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard23, 36); }); }
            else { ChangeCard(LocalCard23, 36); }
            if (this.LocalCard24.InvokeRequired)
            { this.LocalCard24.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard24, 36); }); }
            else { ChangeCard(LocalCard24, 36); }
            if (this.LocalCard25.InvokeRequired)
            { this.LocalCard25.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard25, 36); }); }
            else { ChangeCard(LocalCard25, 36); }
            if (this.LocalCard26.InvokeRequired)
            { this.LocalCard26.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard26, 36); }); }
            else { ChangeCard(LocalCard26, 36); }
            if (this.LocalCard27.InvokeRequired)
            { this.LocalCard27.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard27, 36); }); }
            else { ChangeCard(LocalCard27, 36); }
            if (this.LocalCard28.InvokeRequired)
            { this.LocalCard28.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard28, 36); }); }
            else { ChangeCard(LocalCard28, 36); }
            if (this.LocalCard29.InvokeRequired)
            { this.LocalCard29.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard29, 36); }); }
            else { ChangeCard(LocalCard29, 36); }
            if (this.LocalCard30.InvokeRequired)
            { this.LocalCard30.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard30, 36); }); }
            else { ChangeCard(LocalCard30, 36); }
            if (this.LocalCard31.InvokeRequired)
            { this.LocalCard31.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard31, 36); }); }
            else { ChangeCard(LocalCard31, 36); }
            if (this.LocalCard32.InvokeRequired)
            { this.LocalCard32.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard32, 36); }); }
            else { ChangeCard(LocalCard32, 36); }
            if (this.LocalCard33.InvokeRequired)
            { this.LocalCard33.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard33, 36); }); }
            else { ChangeCard(LocalCard33, 36); }
            if (this.LocalCard34.InvokeRequired)
            { this.LocalCard34.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard34, 36); }); }
            else { ChangeCard(LocalCard34, 36); }
            if (this.LocalCard35.InvokeRequired)
            { this.LocalCard35.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard35, 36); }); }
            else { ChangeCard(LocalCard35, 36); }
            if (this.LocalCard36.InvokeRequired)
            { this.LocalCard36.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard36, 36); }); }
            else { ChangeCard(LocalCard36, 36); }
            /*ChangeCard(LocalCard1, 36);
            ChangeCard(LocalCard2, 36);
            ChangeCard(LocalCard3, 36);
            ChangeCard(LocalCard4, 36);
            ChangeCard(LocalCard5, 36);
            ChangeCard(LocalCard6, 36);
            ChangeCard(LocalCard7, 36);
            ChangeCard(LocalCard8, 36);
            ChangeCard(LocalCard9, 36);
            ChangeCard(LocalCard10, 36);
            ChangeCard(LocalCard11, 36);
            ChangeCard(LocalCard12, 36);
            ChangeCard(LocalCard13, 36);
            ChangeCard(LocalCard14, 36);
            ChangeCard(LocalCard15, 36);
            ChangeCard(LocalCard16, 36);
            ChangeCard(LocalCard17, 36);
            ChangeCard(LocalCard18, 36);
            ChangeCard(LocalCard19, 36);
            ChangeCard(LocalCard20, 36);
            ChangeCard(LocalCard21, 36);
            ChangeCard(LocalCard22, 36);
            ChangeCard(LocalCard23, 36);
            ChangeCard(LocalCard24, 36);
            ChangeCard(LocalCard25, 36);
            ChangeCard(LocalCard26, 36);
            ChangeCard(LocalCard27, 36);
            ChangeCard(LocalCard28, 36);
            ChangeCard(LocalCard29, 36);
            ChangeCard(LocalCard30, 36);
            ChangeCard(LocalCard31, 36);
            ChangeCard(LocalCard32, 36);
            ChangeCard(LocalCard33, 36);
            ChangeCard(LocalCard34, 36);
            ChangeCard(LocalCard35, 36);
            ChangeCard(LocalCard36, 36);*/
        }

        //Тасовка карт
        public void RandomShuffle()
        {
            int i;
            //Создаём упорядоченную колоду
            for (i = 0; i < Cards; i++)
            {
                CardDeck[i] = i;
                //MessageBox.Show(CardDeck[i].ToString());
            }
            var random = new Random();
            const int Changes = 200;
            int tmp, pos, pos2;
            //Меняем карты местами
            for (i = 0; i < Changes; i++)
            {
                pos = random.Next(0, Cards);
                pos2 = random.Next(0, Cards);
                tmp = CardDeck[pos];
                CardDeck[pos] = CardDeck[pos2];
                CardDeck[pos2] = tmp;
            }
                //Отображаем изображения
                ChangeCard(LocalCard1, CardDeck[0]);
                ChangeCard(LocalCard2, CardDeck[1]);
                ChangeCard(LocalCard3, CardDeck[2]);
                ChangeCard(LocalCard4, CardDeck[3]);
                ChangeCard(LocalCard5, CardDeck[4]);
                ChangeCard(LocalCard6, CardDeck[5]);
                ChangeCard(LocalCard7, CardDeck[6]);
                ChangeCard(LocalCard8, CardDeck[7]);
                ChangeCard(LocalCard9, CardDeck[8]);
                ChangeCard(LocalCard10, CardDeck[9]);
                ChangeCard(LocalCard11, CardDeck[10]);
                ChangeCard(LocalCard12, CardDeck[11]);
                ChangeCard(LocalCard13, CardDeck[12]);
                ChangeCard(LocalCard14, CardDeck[13]);
                ChangeCard(LocalCard15, CardDeck[14]);
                ChangeCard(LocalCard16, CardDeck[15]);
                ChangeCard(LocalCard17, CardDeck[16]);
                ChangeCard(LocalCard18, CardDeck[17]);
            //Выдаём карты на руки
                for (i = 0; i < Cards; i++)
                {
                    if (i < (Cards / 2)) { MyCards[i] = CardDeck[i]; }
                }
                inMyHands = Cards / 2;
                inClientHands = inMyHands;
        }



        //Функция для изменения картинки карты
        static public void ChangeCard(object img, int CardID)
        {
            switch (CardID){
                case 0: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._6C; break;
                case 1: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._6D; break;
                case 2: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._6H; break;
                case 3: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._6S; break;
                case 4: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._7C; break;
                case 5: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._7D; break;
                case 6: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._7H; break;
                case 7: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._7S; break;
                case 8: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._8C; break;
                case 9: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._8D; break;
                case 10: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._8H; break;
                case 11: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._8S; break;
                case 12: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._9C; break;
                case 13: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._9D; break;
                case 14: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._9H; break;
                case 15: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._9S; break;
                case 16: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._10C; break;
                case 17: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._10D; break;
                case 18: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._10H; break;
                case 19: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources._10S; break;
                case 20: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.JC; break;
                case 21: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.JD; break;
                case 22: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.JH; break;
                case 23: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.JS; break;
                case 24: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.QC; break;
                case 25: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.QD; break;
                case 26: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.QH; break;
                case 27: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.QS; break;
                case 28: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.KC; break;
                case 29: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.KD; break;
                case 30: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.KH; break;
                case 31: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.KS; break;
                case 32: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.AC; break;
                case 33: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.AD; break;
                case 34: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.AH; break;
                case 35: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.AS; break;
                case 36: (img as PictureBox).Image = WindowsFormsApplication1.Properties.Resources.green_back; break;
            }
        }

        //Boolean[] ActivatedCards = new Boolean[Cards];

        static int[] CardsToTable = new int[maxUpped];
        //Функция выбора карт для следующего хода
        private void LocalCard1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as PictureBox).Top.ToString());

            //Получаем номер объекта
            int LenName = (sender as PictureBox).Name.Length;
            String Name = (sender as PictureBox).Name;
            int Num = (int)Char.GetNumericValue(Name[LenName - 1]) - 1;
            if (Char.IsDigit(Name[LenName - 2]))
            {
                Num = Num + (10 * (int)Char.GetNumericValue(Name[LenName - 2]));
            }
            //MessageBox.Show(Num.ToString());
            //Выбираем карту
            if (MyMove)
            {
                //Поднимаем карту и активируем её
                if((sender as PictureBox).Top==MyTopPos)
                {
                    if (Upped < maxUpped) {
                        CardsToTable[Upped] = Num;
                        //ActivatedCards[Num] = true;
                        (sender as PictureBox).Top = ChangePos;
                        Upped++;
                    }
                }
                //Опускаем карту
                else if ((sender as PictureBox).Top == ChangePos)
                {
                    //ActivatedCards[Num] = false;
                    (sender as PictureBox).Top = MyTopPos;
                    Upped--;
                }
            }
        }

        private void textBoxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            //if (c == 0x13) { ButtonConnect_Click(null,EventArgs.Empty); }
            //Разрешить вводить в поле только цифры, BackSpace и точку
            if (!Char.IsDigit(c) && !(c==0x8) && !(c=='.'))
            {
                e.KeyChar = '\0';
            }
        }

        static Boolean ServerRestarted = false;
        //Поток сервера
        static void ServerRun()
        {
            Console.WriteLine("Server started");
            TcpClient client;
            StreamReader STR;
            StreamWriter STW;
            string ConnectedIP;
            //Включаем прослушку TCP по всем сетям к которым подключенно устройство
            ServerListener = new TcpListener(IPAddress.Any, PortServer);
            ServerListener.Start();
            while (ServerWorked)
            {
                try
                {
                    //Ожидаем клиента
                    client = ServerListener.AcceptTcpClient();
                    //Подключаемся к клиенту
                    ConnectedIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                    if (!ClientThreadWorked)
                    {
                        ClientThreadWorked = true;
                        IPClient = ConnectedIP;
                        ClientThread = new Thread(ClientRun);
                        ClientThread.Start();
                    }
                    //Меняем титул программы. Добавляем в титул IP адрес.
                    if (Form1.ActiveForm.InvokeRequired)
                    { Form1.ActiveForm.BeginInvoke((MethodInvoker)delegate() { Form1.ActiveForm.Text = ProgrammName + " - " + ConnectedIP; }); }
                    else { Form1.ActiveForm.Text = ProgrammName + " - " + ConnectedIP; }

                    //Воспроизводим звуковой сигнал после подключения
                    Console.Beep();
                    //System.Media.SystemSounds.Beep;
                    //MessageBox.Show("Подключение к IP: "+IPClient+"\nЧтобы начать игру, нажмите на сервере кнопку - 'Новая игра'");
                    //Берём стримы для взятия новых сообщений от клиента
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    //Пока клиент подключён, принимаем его сообщения
                    while (client.Connected)
                    {
                        receive = STR.ReadLine();
                        Console.WriteLine(receive);
                        //MessageBox.Show("Received " + receive);
                        Thread.Sleep(GeneralDelay);
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (Form1.ActiveForm.InvokeRequired)
                        { Form1.ActiveForm.BeginInvoke((MethodInvoker)delegate() { Form1.ActiveForm.Text = ProgrammName; }); }
                        else { Form1.ActiveForm.Text = ProgrammName; }/*MessageBox.Show(ex.Message.ToString());*/
                    }
                    catch (Exception exInner) { }
                }
                //Говорим что сервер начал ожидать нового клиента
                ServerRestarted = true;
            }
            Console.WriteLine("Server stoped");
        }

        static int tmpUpped = 0;
        //Делаем ход
        private void ButtonGo_Click(object sender, EventArgs e)
        {
            if (Upped == 0) { MessageBox.Show("Выберите карты!"); }
            else
            {
                int tmp = CardsToTable[0], tmp2 = CardsToTable[0];
                //Сортируем выбранные карты
                for (int i = 0; i < Upped; i++)
                    for (int j = i; j < Upped; j++)
                    {
                        tmp = CardsToTable[i];
                        tmp2 = CardsToTable[j];
                        if (tmp2 > CardsToTable[i])
                        {
                            CardsToTable[i] = tmp2;
                            CardsToTable[j] = tmp;
                        }
                    }
                //Проверяем выбранный RadioButton
                if (RadioButton6.Checked) { CheckedRadioButton = "6"; }
                else if (RadioButton7.Checked) { CheckedRadioButton = "7";}
                else if (RadioButton8.Checked) { CheckedRadioButton = "8";}
                else if (RadioButton9.Checked) { CheckedRadioButton = "9";}
                else if (RadioButton10.Checked) { CheckedRadioButton = "10";}
                else if (RadioButtonJ.Checked) { CheckedRadioButton = "J";}
                else if (RadioButtonQ.Checked) { CheckedRadioButton = "Q";}
                else if (RadioButtonK.Checked) { CheckedRadioButton = "K";}
                else if (RadioButtonA.Checked) { CheckedRadioButton = "A";}
                
                Truth = false;
                string card = "6";
                send_to_server = Upped.ToString();
                //Проверяем, игрок сказал правду или неправду и формируем сообщение
                for (int i = 0; i < Upped; i++)
                {
                    send_to_server = send_to_server+" "+MyCards[CardsToTable[i]].ToString();
                    if (MyCards[CardsToTable[i]] < 4) { card = "6"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 2)) { card = "7"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 3)) { card = "8"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 4)) { card = "9"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 5)) { card = "10"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 6)) { card = "J"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 7)) { card = "Q"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 8)) { card = "K"; }
                    else if (MyCards[CardsToTable[i]] < (4 * 9)) { card = "A"; }
                    if (card == CheckedRadioButton) { Truth = true; }
                }
                send_to_server = send_to_server +" "+ CheckedRadioButton + " " + "Stroke";
                if (Truth) { send_to_server = send_to_server + " " + "Truth"; }
                else { send_to_server = send_to_server + " " + "Lie"; }
                //MessageBox.Show(send_to_server);
                ChangeMyMove(false);
                tmpUpped = Upped;
                Upped = 0;
                //MessageBox.Show(send_to_server);
                //Отправляем потоку сигнал, чтобы он послал сообщение
                SendStroke = true;
                /*if (Truth) { MessageBox.Show("Правда"); }
                else { MessageBox.Show("Не правда"); }*/
            }
        }

        //Поток клиента
        static void ClientRun()
        {
            Console.WriteLine("Client Thread started");
            TcpClient client = new TcpClient();
            StreamReader STR;
            StreamWriter STW;
            try
            {
                //Пытаемся подключиться к клиенту
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(IPClient), PortServer);
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    //Берём стримы, чтобы отправить серверу первое сообщение
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    if (IamClient) { STW.WriteLine(FirstMessage); }
                    //MessageBox.Show("Вы успешно подключились по IP: "+IPClient);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                ClientThreadWorked = false;
            }
            try
            {
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                //Отправить сообщение серверу по сигналу
                while (ClientThreadWorked)
                {
                    if (SendStroke)
                    {
                        STW.WriteLine(send_to_server);
                        send_to_server = "";
                        SendStroke = false;
                    }
                    else if (NewGame)
                    {
                        STW.WriteLine(send_to_server);
                        send_to_server = "";
                        NewGame = false;
                    }
                    else if (WhoseCards)
                    {
                        STW.WriteLine(send_to_server);
                        send_to_server = "";
                        WhoseCards = false;
                    }
                    Thread.Sleep(GeneralDelay);
                }
            }
            catch (Exception ex) { }
            ClientThreadWorked = false;
            IamClient = false;
            Console.WriteLine("Client Thread stoped");
        }

        Boolean Truth = false;

        //Кнопка подключения
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            IamClient = true;
            Client(true);
            HideConnect(true);
        }

        //Событие (Закрытие формы)
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Остановить все потоки
            try
            {
                Server(false);
                Client(false);
                Works = false;
                Application.Exit();
                //Environment.Exit(1);
            }
            catch (Exception ex)
            {
            }
        }

        //Обновление позиций карт
        public void UpdatePosition()
        {
            int i, k = 0;
                if (inClientHands < 19) { k = 38; }
                else 
                {
                    switch (inClientHands)
                    {
                        case 19: k = 36; break;
                        case 20: k = 34; break;
                        case 21: k = 32; break;
                        case 22: k = 30; break;
                        case 23: k = 29; break;
                        case 24: k = 27; break;
                        case 25: k = 26; break; //7

                        case 26: k = 25; break;
                        case 27: k = 24; break;
                        case 28: k = 23; break;
                        case 29: k = 22; break;
                        case 30: k = 21; break; //12

                        case 31: k = 20; break;
                        case 32: k = 20; break;
                        case 33: k = 19; break;
                        case 34: k = 19; break;
                        case 35: k = 18; break;
                        case 36: k = 18; break;
                    }
                }
                for(i=0;i< inClientHands;i++)
                {
                    ChangeCardPosition(i+inMyHands+1, 50 + (k * (i - 1)), ClientTopPos);
                }
                if (inMyHands < 19) { k = 38; }
                else
                {
                    switch (inMyHands)
                    {
                        case 19: k = 36; break;
                        case 20: k = 34; break;
                        case 21: k = 32; break;
                        case 22: k = 30; break;
                        case 23: k = 29; break;
                        case 24: k = 27; break;
                        case 25: k = 26; break; //7

                        case 26: k = 25; break;
                        case 27: k = 24; break;
                        case 28: k = 23; break;
                        case 29: k = 22; break;
                        case 30: k = 21; break; //12

                        case 31: k = 20; break;
                        case 32: k = 20; break;
                        case 33: k = 19; break;
                        case 34: k = 19; break;
                        case 35: k = 18; break;
                        case 36: k = 18; break;
                    }
                }
                for (i = 0; i < inMyHands; i++)
                {
                    ChangeCardPosition(i + 1, 50 + (k * (i - 1)), MyTopPos);
                }
        }

        //Поменять позицию Left(X) и Top(y) карты
        public void ChangeCardPosition(int NumOfCard, int LeftCard, int TopCard)
        {
            switch (NumOfCard)
            {
                case 1: if (this.LocalCard1.InvokeRequired)
                    { this.LocalCard1.BeginInvoke((MethodInvoker)delegate() { this.LocalCard1.Left = LeftCard; this.LocalCard1.Top = TopCard; }); }
                    else { this.LocalCard1.Left = LeftCard; this.LocalCard1.Top = TopCard; } break;
                case 2: if (this.LocalCard2.InvokeRequired)
                    { this.LocalCard2.BeginInvoke((MethodInvoker)delegate() { this.LocalCard2.Left = LeftCard; this.LocalCard2.Top = TopCard; }); }
                    else { this.LocalCard2.Left = LeftCard; this.LocalCard2.Top = TopCard; } break;
                case 3: if (this.LocalCard3.InvokeRequired)
                    { this.LocalCard3.BeginInvoke((MethodInvoker)delegate() { this.LocalCard3.Left = LeftCard; this.LocalCard3.Top = TopCard; }); }
                    else { this.LocalCard3.Left = LeftCard; this.LocalCard3.Top = TopCard; } break;
                case 4: if (this.LocalCard4.InvokeRequired)
                    { this.LocalCard4.BeginInvoke((MethodInvoker)delegate() { this.LocalCard4.Left = LeftCard; this.LocalCard4.Top = TopCard; }); }
                    else { this.LocalCard4.Left = LeftCard; this.LocalCard4.Top = TopCard; } break;
                case 5: if (this.LocalCard5.InvokeRequired)
                    { this.LocalCard5.BeginInvoke((MethodInvoker)delegate() { this.LocalCard5.Left = LeftCard; this.LocalCard5.Top = TopCard; }); }
                    else { this.LocalCard5.Left = LeftCard; this.LocalCard5.Top = TopCard; } break;
                case 6: if (this.LocalCard6.InvokeRequired)
                    { this.LocalCard6.BeginInvoke((MethodInvoker)delegate() { this.LocalCard6.Left = LeftCard; this.LocalCard6.Top = TopCard; }); }
                    else { this.LocalCard6.Left = LeftCard; this.LocalCard6.Top = TopCard; } break;
                case 7: if (this.LocalCard7.InvokeRequired)
                    { this.LocalCard7.BeginInvoke((MethodInvoker)delegate() { this.LocalCard7.Left = LeftCard; this.LocalCard7.Top = TopCard; }); }
                    else { this.LocalCard7.Left = LeftCard; this.LocalCard7.Top = TopCard; } break;
                case 8: if (this.LocalCard8.InvokeRequired)
                    { this.LocalCard8.BeginInvoke((MethodInvoker)delegate() { this.LocalCard8.Left = LeftCard; this.LocalCard8.Top = TopCard; }); }
                    else { this.LocalCard8.Left = LeftCard; this.LocalCard8.Top = TopCard; } break;
                case 9: if (this.LocalCard9.InvokeRequired)
                    { this.LocalCard9.BeginInvoke((MethodInvoker)delegate() { this.LocalCard9.Left = LeftCard; this.LocalCard9.Top = TopCard; }); }
                    else { this.LocalCard9.Left = LeftCard; this.LocalCard9.Top = TopCard; } break;
                case 10: if (this.LocalCard10.InvokeRequired)
                           { this.LocalCard10.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard10.Left = LeftCard; this.LocalCard10.Top = TopCard; }); }
                      else { this.LocalCard10.Left = LeftCard; this.LocalCard10.Top = TopCard; } break;
                case 11: if (this.LocalCard11.InvokeRequired)
                           { this.LocalCard11.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard11.Left = LeftCard; this.LocalCard11.Top = TopCard; }); }
                      else { this.LocalCard11.Left = LeftCard; this.LocalCard11.Top = TopCard; } break;
                case 12: if (this.LocalCard12.InvokeRequired)
                           { this.LocalCard12.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard12.Left = LeftCard; this.LocalCard12.Top = TopCard; }); }
                      else { this.LocalCard12.Left = LeftCard; this.LocalCard12.Top = TopCard; } break;
                case 13: if (this.LocalCard13.InvokeRequired)
                           { this.LocalCard13.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard13.Left = LeftCard; this.LocalCard13.Top = TopCard; }); }
                      else { this.LocalCard13.Left = LeftCard; this.LocalCard13.Top = TopCard; } break;
                case 14: if (this.LocalCard14.InvokeRequired)
                           { this.LocalCard14.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard14.Left = LeftCard; this.LocalCard14.Top = TopCard; }); }
                      else { this.LocalCard14.Left = LeftCard; this.LocalCard14.Top = TopCard; } break;
                case 15: if (this.LocalCard15.InvokeRequired)
                           { this.LocalCard15.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard15.Left = LeftCard; this.LocalCard15.Top = TopCard; }); }
                      else { this.LocalCard15.Left = LeftCard; this.LocalCard15.Top = TopCard; } break;
                case 16: if (this.LocalCard16.InvokeRequired)
                           { this.LocalCard16.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard16.Left = LeftCard; this.LocalCard16.Top = TopCard; }); }
                      else { this.LocalCard16.Left = LeftCard; this.LocalCard16.Top = TopCard; } break;
                case 17: if (this.LocalCard17.InvokeRequired)
                           { this.LocalCard17.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard17.Left = LeftCard; this.LocalCard17.Top = TopCard; }); }
                      else { this.LocalCard17.Left = LeftCard; this.LocalCard17.Top = TopCard; } break;
                case 18: if (this.LocalCard18.InvokeRequired)
                           { this.LocalCard18.BeginInvoke((MethodInvoker)delegate() 
                           { this.LocalCard18.Left = LeftCard; this.LocalCard18.Top = TopCard; }); }
                      else { this.LocalCard18.Left = LeftCard; this.LocalCard18.Top = TopCard; } break;
                case 19: if (this.LocalCard19.InvokeRequired)
                    {
                        this.LocalCard19.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard19.Left = LeftCard; this.LocalCard19.Top = TopCard; });
                    }
                    else { this.LocalCard19.Left = LeftCard; this.LocalCard19.Top = TopCard; } break;
                case 20: if (this.LocalCard20.InvokeRequired)
                    {
                        this.LocalCard20.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard20.Left = LeftCard; this.LocalCard20.Top = TopCard; });
                    }
                    else { this.LocalCard20.Left = LeftCard; this.LocalCard20.Top = TopCard; } break;
                case 21: if (this.LocalCard21.InvokeRequired)
                    {
                        this.LocalCard21.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard21.Left = LeftCard; this.LocalCard21.Top = TopCard; });
                    }
                    else { this.LocalCard21.Left = LeftCard; this.LocalCard21.Top = TopCard; } break;
                case 22: if (this.LocalCard22.InvokeRequired)
                    {
                        this.LocalCard22.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard22.Left = LeftCard; this.LocalCard22.Top = TopCard; });
                    }
                    else { this.LocalCard22.Left = LeftCard; this.LocalCard22.Top = TopCard; } break;
                case 23: if (this.LocalCard23.InvokeRequired)
                    {
                        this.LocalCard23.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard23.Left = LeftCard; this.LocalCard23.Top = TopCard; });
                    }
                    else { this.LocalCard23.Left = LeftCard; this.LocalCard23.Top = TopCard; } break;
                case 24: if (this.LocalCard24.InvokeRequired)
                    {
                        this.LocalCard24.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard24.Left = LeftCard; this.LocalCard24.Top = TopCard; });
                    }
                    else { this.LocalCard24.Left = LeftCard; this.LocalCard24.Top = TopCard; } break;
                case 25: if (this.LocalCard25.InvokeRequired)
                    {
                        this.LocalCard25.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard25.Left = LeftCard; this.LocalCard25.Top = TopCard; });
                    }
                    else { this.LocalCard25.Left = LeftCard; this.LocalCard25.Top = TopCard; } break;
                case 26: if (this.LocalCard26.InvokeRequired)
                    {
                        this.LocalCard26.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard26.Left = LeftCard; this.LocalCard26.Top = TopCard; });
                    }
                    else { this.LocalCard26.Left = LeftCard; this.LocalCard26.Top = TopCard; } break;
                case 27: if (this.LocalCard27.InvokeRequired)
                    {
                        this.LocalCard27.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard27.Left = LeftCard; this.LocalCard27.Top = TopCard; });
                    }
                    else { this.LocalCard27.Left = LeftCard; this.LocalCard27.Top = TopCard; } break;
                case 28: if (this.LocalCard28.InvokeRequired)
                    {
                        this.LocalCard28.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard28.Left = LeftCard; this.LocalCard28.Top = TopCard; });
                    }
                    else { this.LocalCard28.Left = LeftCard; this.LocalCard28.Top = TopCard; } break;
                case 29: if (this.LocalCard29.InvokeRequired)
                    {
                        this.LocalCard29.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard29.Left = LeftCard; this.LocalCard29.Top = TopCard; });
                    }
                    else { this.LocalCard29.Left = LeftCard; this.LocalCard29.Top = TopCard; } break;
                case 30: if (this.LocalCard30.InvokeRequired)
                    {
                        this.LocalCard30.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard30.Left = LeftCard; this.LocalCard30.Top = TopCard; });
                    }
                    else { this.LocalCard30.Left = LeftCard; this.LocalCard30.Top = TopCard; } break;
                case 31: if (this.LocalCard31.InvokeRequired)
                    {
                        this.LocalCard31.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard31.Left = LeftCard; this.LocalCard31.Top = TopCard; });
                    }
                    else { this.LocalCard31.Left = LeftCard; this.LocalCard31.Top = TopCard; } break;
                case 32: if (this.LocalCard32.InvokeRequired)
                    {
                        this.LocalCard32.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard32.Left = LeftCard; this.LocalCard32.Top = TopCard; });
                    }
                    else { this.LocalCard32.Left = LeftCard; this.LocalCard32.Top = TopCard; } break;
                case 33: if (this.LocalCard33.InvokeRequired)
                    {
                        this.LocalCard33.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard33.Left = LeftCard; this.LocalCard33.Top = TopCard; });
                    }
                    else { this.LocalCard33.Left = LeftCard; this.LocalCard33.Top = TopCard; } break;
                case 34: if (this.LocalCard34.InvokeRequired)
                    {
                        this.LocalCard34.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard34.Left = LeftCard; this.LocalCard34.Top = TopCard; });
                    }
                    else { this.LocalCard34.Left = LeftCard; this.LocalCard34.Top = TopCard; } break;
                case 35: if (this.LocalCard35.InvokeRequired)
                    {
                        this.LocalCard35.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard35.Left = LeftCard; this.LocalCard35.Top = TopCard; });
                    }
                    else { this.LocalCard35.Left = LeftCard; this.LocalCard35.Top = TopCard; } break;
                case 36: if (this.LocalCard36.InvokeRequired)
                    {
                        this.LocalCard36.BeginInvoke((MethodInvoker)delegate()
                        { this.LocalCard36.Left = LeftCard; this.LocalCard36.Top = TopCard; });
                    }
                    else { this.LocalCard36.Left = LeftCard; this.LocalCard36.Top = TopCard; } break;
            }
        }

        //Активировать кнопки Верю Не верю и показать надпись
        public void TruthButtons(Boolean Enabled)
        {
            if (this.buttonTruth.InvokeRequired)
            { this.buttonTruth.BeginInvoke((MethodInvoker)delegate() { this.buttonTruth.Enabled = Enabled; }); }
            else { this.buttonTruth.Enabled = Enabled; }
            if (this.buttonLie.InvokeRequired)
            { this.buttonLie.BeginInvoke((MethodInvoker)delegate() { this.buttonLie.Enabled = Enabled; }); }
            else { this.buttonLie.Enabled = Enabled; }
            if (this.labelOnTable.InvokeRequired)
            { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Visible = true; }); }
            else { this.labelOnTable.Visible = true; }
            //ChangeMyMove(!Enabled);
            //buttonTruth.Visible = Visible;
            //buttonLie.Visible = Visible;
        }

        static int[] tmpCards = new int[maxUpped+1];
        public Boolean Works = true;

        static String ClientCheckedRadioButton = "6";
        static Boolean BackgroundServerWorking = false;
        //----------------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------//MAIN THREAD//--------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------------------//
        //Отображаем игровые изменения, в зависимости от полученного сообщения с сервера
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundServerWorking = true;
            Console.WriteLine("BackgroundServer Start works");
            while (Works)
            {
                Thread.Sleep(GeneralDelay);
                //Если подключился клиент, то прячем кнопку connect на сервере
                if (receive == FirstMessage)
                {
                    HideConnect(true);
                    receive = "";
                }
                    //Если полученно сообщение New_game, то заносим новые карты которые прислал сервер
                else if (receive.Contains("New_game")){
                    Boolean First = true;
                    int i = 0;
                    InitializeArrOfCards();
                    inMyHands = 18; inClientHands = 18;
                    //MessageBox.Show("Getted:" + receive);
                    //Заносим ID карт в массив и отображаем их
                    foreach (string CardID in receive.Split(' '))
                    {
                        if (First) { i = 0; First = false; }
                        else { CardDeck[i] = int.Parse(CardID); ChangeCardByNum(i + 1, int.Parse(CardID)); i++; MyCards[i - 1] = int.Parse(CardID); }
                    }
                    UpdatePosition();
                    //Если рандом выдал нам первый ход, то активируем кнопки для хода
                    if (receive.Contains("Your")) { MyMove = true; ChangeMyMove(MyMove); }
                    else { MyMove = false; ChangeMyMove(MyMove); }
                    //Обнуляем текст сообщения
                    receive = "";
                }
                    //Сообщение  после нажатия кнопки ходить
                else if (receive.Contains("Stroke"))
                {
                    //То переносим всю информацию из строки сообщения, в переменные данных на локальном комьпютере
                    if (receive.Contains("Truth")) { Truth = true; } else { Truth = false; }
                    tmpCards[0] = int.Parse(receive.Split(' ')[0]);
                    //MessageBox.Show(receive);
                    int i = 0;
                    for (i = 1; i <= tmpCards[0];i++)
                    {
                        //MessageBox.Show(receive.Split(' ')[i]);
                        tmpCards[i] = int.Parse(receive.Split(' ')[i]);
                    }
                        ClientCheckedRadioButton = receive.Split(' ')[tmpCards[0]+1];
                        //MessageBox.Show(CheckedRadioButton);
                        ChangeTruthLabel();
                        //Обнуляем текст сообщения
                        receive = "";
                        //После хода игрока, активируем кнопки Верю, Не верю
                        TruthButtons(true);
                }
                else if (ServerRestarted) { /*AllDisable();*/ ServerRestarted = false; }
                    //Сообщение после нажатия Верю или Не верю
                else if (receive.Contains("After"))
                {
                    //MessageBox.Show(receive);
                    //Если игрок сказал правду и другой поверил
                    if (receive.Contains("-cards"))
                    {
                        if (this.labelOnTable.InvokeRequired)
                        { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Text = " Карты ушли в\nотбой"; }); }
                        else { this.labelOnTable.Text = " Карты ушли в\nотбой"; }
                        //labelOnTable.Text = " Карты ушли в\nотбой";
                        for(int i = 0; i<tmpUpped;i++)
                        {
                            //MessageBox.Show((CardsToTable[i] + 1).ToString());
                            //Удаляем карту из своей колоды и прячем её визуально
                            RemoveCard(CardsToTable[i]+1);
                            HideCard();
                        }
                        //Проверяем, есть ли на руках карты у клиента или сервера
                        CheckFinish();
                    }
                        //Если другой игрок не поверил в правду, или поверил в ложь
                    else if (receive.Contains("I get cards"))
                    {
                        if (this.labelOnTable.InvokeRequired)
                        { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Text = " Другой игрок \n забрал карты"; }); }
                        else { this.labelOnTable.Text = " Другой игрок \n забрал карты"; }
                        //labelOnTable.Text = " Другой игрок \n забрал карты";
                        for (int i = 0; i < tmpUpped; i++)
                        {
                            //Убираем карту из нашей колоды
                            RemoveCard(CardsToTable[i] + 1);
                        }
                        //Проверяем, есть ли на руках карты у клиента или сервера
                        CheckFinish();
                    }
                        //Если игрок солгал и ложь распознали
                    else if (receive.Contains("get back your cards"))
                    {
                        if (this.labelOnTable.InvokeRequired)
                        { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Text = "Ложь распознали" + '\n' + "Карты вернулись"; }); }
                        else { this.labelOnTable.Text = "Ложь распознали" + '\n' + "Карты вернулись"; }
                        //labelOnTable.Text = "Ложь распознали" + '\n' + "Карты вернулись";
                           //Обновляем позиции карт, чтобы поднятые карты стали на свои места                 
                        UpdatePosition();
                    }
                    receive = "";
                }
                /*for (int i = 0; i < 10000; i++)
                { this.Text = "Test "+i.ToString(); }*/
            }
            Console.WriteLine("BackgroundServer Ends works");
            BackgroundServerWorking = false;
        }

        //Функция для изменения центральной надписи "В картах есть (название карты)"
        public void ChangeTruthLabel()
        {
            if (this.labelOnTable.InvokeRequired)
            { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Text = "В картах есть " + ClientCheckedRadioButton; }); }
            else { this.labelOnTable.Text = "В картах есть " + ClientCheckedRadioButton; }
        }

        static Boolean NewGame = false;
        //Начать новую игру
        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            //AllCardsOnSelfPlace();
            InitializeArrOfCards();
            UpdatePosition();
            //Делаем тасовку карт
            RandomShuffle();
            //Говорим кто первый ходит
            Random rnd = new Random();
            if(rnd.Next(1,101)<=50)
            { MyMove = true; ChangeMyMove(MyMove); }
            else { MyMove = false; ChangeMyMove(MyMove); }
            //Формируем сообщение из карт игрока
            send_to_server = "New_game";
            if (MyMove) { send_to_server=send_to_server+"_My";}
            else { send_to_server = send_to_server + "_Your"; }
            for (int i = inMyHands; i < Cards; i++)
            {
                send_to_server = send_to_server + " " + CardDeck[i];
            }
            //Отправляем сигнал потоку, чтобы отправить сообщение с картами противоположного игрока
            NewGame = true;
            //MessageBox.Show("Sended:" + send_to_server);
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            //Отключаем сервер и клиент
            Client(false);
            Server(false);
            //Снова включаем сервер, чтобы можно было подключиться к нам
            Server(true);
            IamClient = false;
            labelOnTable.Visible = false;
            AllDisable();
            if (this.labelOnTable.InvokeRequired)
            { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Visible = false; }); }
            else { this.labelOnTable.Visible = false; }
            if (Form1.ActiveForm.InvokeRequired)
            { Form1.ActiveForm.BeginInvoke((MethodInvoker)delegate() { Form1.ActiveForm.Text = ProgrammName; }); }
            else { Form1.ActiveForm.Text = ProgrammName; }

        }

        //Отключаем игровые кнопки и делаем состояние объектов как при первом запуске
        public void AllDisable()
        {
            if (this.labelOnTable.InvokeRequired)
            { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Visible = false; }); }
            else { this.labelOnTable.Visible = false; }
            HideConnect(false);
            ChangeMyMove(false);
            TruthButtons(false);
            hideCards();
            InitializeArrOfCards();
        }

        string CheckedRadioButton = "6";
        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            CheckedRadioButton = (sender as RadioButton).Text;
        }
        
        //Кнопка для тестирования
        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBoxTest.Text); i++)
                RemoveCard(1);
            //ChangeMyMove(true);
            //UpdatePosition();
            //HideCard();
            //LocalCard1.Dispose();
            //AddCard(1);
            //AddCard(1);
            //AddCard(1);
            //RemoveCard(1);

            
            //UpdatePosition(true);
            //UpdatePosition(false);
            /*for (int i = 1; i <= Cards;i++ )
                ChangeCardPosition(i, 12, 150);*/
            //ReplaceCards(0, 1);
            //AllCardsOnSelfPlace();
            //for (int i = 0; i <= Cards; i++) { ChangeCardPosition(i, 200, 200); }
            //ChangeCardPosition(1, 300, 300);
            //TruthButtons(true);
            //Thread.Sleep(2000);
            //TruthButtons(false);
            /*foreach(int i in CardDeck){
                MessageBox.Show(i.ToString());
            }
            if("012345".Contains("123")){MessageBox.Show("Contains");}
            else {MessageBox.Show("No contains");}*/
        }

        static Boolean WhoseCards = false;
        static int NewInClientHands = inClientHands,NewInMyHands = inMyHands;
        //Функция формирования сообщения, после нажатия Верю или Не верю
        public void Guessed(Boolean YourAnswer)
        {
            send_to_server = "After "+tmpCards[0].ToString()+" ";
            //Если человек сказал правду, а другой поверил, то карты идут в отбой
            if ((YourAnswer) && (Truth)) { send_to_server = send_to_server + "-cards"; NewInClientHands = inClientHands - tmpCards[0]; NewInMyHands = inMyHands; }
            //Если человек сказал правду, а другой не поверил, то карты переходят в другие руки
            else if ((!YourAnswer) && (Truth)) { send_to_server = send_to_server + "I get cards"; NewInClientHands = inClientHands - tmpCards[0]; NewInMyHands = inMyHands + tmpCards[0]; }
            //Если человек сказал неправду, а другой не поверил и оказался прав, то карты возвращаются
            else if ((!YourAnswer) && (!Truth)) { send_to_server = send_to_server + "get back your cards"; NewInClientHands = inClientHands; NewInMyHands = inMyHands; }
            //Если человек сказал неправду, а другой поверил, то карты переходят в другие руки
            else if ((YourAnswer) && (!Truth)) { send_to_server = send_to_server + "I get cards"; NewInClientHands = inClientHands - tmpCards[0]; NewInMyHands = inMyHands+tmpCards[0];}

            if (send_to_server.Contains("I get cards"))
            {
                labelOnTable.Text = "Вы забрали карты";
                for(int i=1;i<=tmpCards[0];i++)
                {
                    AddCard(tmpCards[i]);
                }
            }
            else if (send_to_server.Contains("-cards"))
            {
                for (int i = 0; i < tmpCards[0]; i++)
                {
                    labelOnTable.Text = " Карты ушли в\nотбой";
                    //MessageBox.Show("-cards and I'm Hide");
                    HideCard();
                }
            }
            else if (send_to_server.Contains("get back your cards"))
            {
                labelOnTable.Text = "Игрок солгал и\nостался с картами";
            }
            inClientHands = NewInClientHands;
            inMyHands = NewInMyHands;
            CheckFinish();
            //MessageBox.Show(send_to_server);
            WhoseCards = true;
            ChangeMyMove(true);
            TruthButtons(false);
        }

        //Функция проверки карт у игроков, если их 0 то игра окончена
        public void CheckFinish()
        {
            if (inClientHands == 0)
            {
                FinishGame(false);
            }
            else if (inMyHands == 0)
            {
                FinishGame(true);
            }
        }

        //Функция окончания игры
        public void FinishGame(Boolean Win)
        {
            string WinMsg = "";
            if (Win) { WinMsg = "Вы выиграли!"; }
            else { WinMsg = "Вы проиграли!"; }
            if (this.labelOnTable.InvokeRequired)
            { this.labelOnTable.BeginInvoke((MethodInvoker)delegate() { this.labelOnTable.Text = WinMsg; }); }
            else { this.labelOnTable.Text = WinMsg; }

            ChangeMyMove(false);
            TruthButtons(false);
            hideCards();
            InitializeArrOfCards();
            //AllDisable();
        }

        static int Hided = 0;

        //Спрятать визуально карту, функция нужна для отбоя
        public void HideCard()
        {
            int CardNum = Cards - Hided;
            Hided++;
            switch (CardNum)
            {
                case 1: if (this.LocalCard1.InvokeRequired)
                    { this.LocalCard1.BeginInvoke((MethodInvoker)delegate() { LocalCard1.Visible = false; }); }
                    else { LocalCard1.Visible = false; } break;
                case 2: if (this.LocalCard2.InvokeRequired)
                    { this.LocalCard2.BeginInvoke((MethodInvoker)delegate() { LocalCard2.Visible = false; }); }
                    else { LocalCard2.Visible = false; } break;
                case 3: if (this.LocalCard3.InvokeRequired)
                    { this.LocalCard3.BeginInvoke((MethodInvoker)delegate() { LocalCard3.Visible = false; }); }
                    else { LocalCard3.Visible = false; } break;
                case 4: if (this.LocalCard4.InvokeRequired)
                    { this.LocalCard4.BeginInvoke((MethodInvoker)delegate() { LocalCard4.Visible = false; }); }
                    else { LocalCard4.Visible = false; } break;
                case 5: if (this.LocalCard5.InvokeRequired)
                    { this.LocalCard5.BeginInvoke((MethodInvoker)delegate() { LocalCard5.Visible = false; }); }
                    else { LocalCard5.Visible = false; } break;
                case 6: if (this.LocalCard6.InvokeRequired)
                    { this.LocalCard6.BeginInvoke((MethodInvoker)delegate() { LocalCard6.Visible = false; }); }
                    else { LocalCard6.Visible = false; } break;
                case 7: if (this.LocalCard7.InvokeRequired)
                    { this.LocalCard7.BeginInvoke((MethodInvoker)delegate() { LocalCard7.Visible = false; }); }
                    else { LocalCard7.Visible = false; } break;
                case 8: if (this.LocalCard8.InvokeRequired)
                    { this.LocalCard8.BeginInvoke((MethodInvoker)delegate() { LocalCard8.Visible = false; }); }
                    else { LocalCard8.Visible = false; } break;
                case 9: if (this.LocalCard9.InvokeRequired)
                    { this.LocalCard9.BeginInvoke((MethodInvoker)delegate() { LocalCard9.Visible = false; }); }
                    else { LocalCard9.Visible = false; } break;
                case 10: if (this.LocalCard10.InvokeRequired)
                    { this.LocalCard10.BeginInvoke((MethodInvoker)delegate() { LocalCard10.Visible = false; }); }
                    else { LocalCard10.Visible = false; } break;
                case 11: if (this.LocalCard11.InvokeRequired)
                    { this.LocalCard11.BeginInvoke((MethodInvoker)delegate() { LocalCard11.Visible = false; }); }
                    else { LocalCard11.Visible = false; } break;
                case 12: if (this.LocalCard12.InvokeRequired)
                    { this.LocalCard12.BeginInvoke((MethodInvoker)delegate() { LocalCard12.Visible = false; }); }
                    else { LocalCard12.Visible = false; } break;
                case 13: if (this.LocalCard13.InvokeRequired)
                    { this.LocalCard13.BeginInvoke((MethodInvoker)delegate() { LocalCard13.Visible = false; }); }
                    else { LocalCard13.Visible = false; } break;
                case 14: if (this.LocalCard14.InvokeRequired)
                    { this.LocalCard14.BeginInvoke((MethodInvoker)delegate() { LocalCard14.Visible = false; }); }
                    else { LocalCard14.Visible = false; } break;
                case 15: if (this.LocalCard15.InvokeRequired)
                    { this.LocalCard15.BeginInvoke((MethodInvoker)delegate() { LocalCard15.Visible = false; }); }
                    else { LocalCard15.Visible = false; } break;
                case 16: if (this.LocalCard16.InvokeRequired)
                    { this.LocalCard16.BeginInvoke((MethodInvoker)delegate() { LocalCard16.Visible = false; }); }
                    else { LocalCard16.Visible = false; } break;
                case 17: if (this.LocalCard17.InvokeRequired)
                    { this.LocalCard17.BeginInvoke((MethodInvoker)delegate() { LocalCard17.Visible = false; }); }
                    else { LocalCard17.Visible = false; } break;
                case 18: if (this.LocalCard18.InvokeRequired)
                    { this.LocalCard18.BeginInvoke((MethodInvoker)delegate() { LocalCard18.Visible = false; }); }
                    else { LocalCard18.Visible = false; } break;
                case 19: if (this.LocalCard19.InvokeRequired)
                    { this.LocalCard19.BeginInvoke((MethodInvoker)delegate() { LocalCard19.Visible = false; }); }
                    else { LocalCard19.Visible = false; } break;
                case 20: if (this.LocalCard20.InvokeRequired)
                    { this.LocalCard20.BeginInvoke((MethodInvoker)delegate() { LocalCard20.Visible = false; }); }
                    else { LocalCard20.Visible = false; } break;
                case 21: if (this.LocalCard21.InvokeRequired)
                    { this.LocalCard21.BeginInvoke((MethodInvoker)delegate() { LocalCard21.Visible = false; }); }
                    else { LocalCard21.Visible = false; } break;
                case 22: if (this.LocalCard22.InvokeRequired)
                    { this.LocalCard22.BeginInvoke((MethodInvoker)delegate() { LocalCard22.Visible = false; }); }
                    else { LocalCard22.Visible = false; } break;
                case 23: if (this.LocalCard23.InvokeRequired)
                    { this.LocalCard23.BeginInvoke((MethodInvoker)delegate() { LocalCard23.Visible = false; }); }
                    else { LocalCard23.Visible = false; } break;
                case 24: if (this.LocalCard24.InvokeRequired)
                    { this.LocalCard24.BeginInvoke((MethodInvoker)delegate() { LocalCard24.Visible = false; }); }
                    else { LocalCard24.Visible = false; } break;
                case 25: if (this.LocalCard25.InvokeRequired)
                    { this.LocalCard25.BeginInvoke((MethodInvoker)delegate() { LocalCard25.Visible = false; }); }
                    else { LocalCard25.Visible = false; } break;
                case 26: if (this.LocalCard26.InvokeRequired)
                    { this.LocalCard26.BeginInvoke((MethodInvoker)delegate() { LocalCard26.Visible = false; }); }
                    else { LocalCard26.Visible = false; } break;
                case 27: if (this.LocalCard27.InvokeRequired)
                    { this.LocalCard27.BeginInvoke((MethodInvoker)delegate() { LocalCard27.Visible = false; }); }
                    else { LocalCard27.Visible = false; } break;
                case 28: if (this.LocalCard28.InvokeRequired)
                    { this.LocalCard28.BeginInvoke((MethodInvoker)delegate() { LocalCard28.Visible = false; }); }
                    else { LocalCard28.Visible = false; } break;
                case 29: if (this.LocalCard29.InvokeRequired)
                    { this.LocalCard29.BeginInvoke((MethodInvoker)delegate() { LocalCard29.Visible = false; }); }
                    else { LocalCard29.Visible = false; } break;
                case 30: if (this.LocalCard30.InvokeRequired)
                    { this.LocalCard30.BeginInvoke((MethodInvoker)delegate() { LocalCard30.Visible = false; }); }
                    else { LocalCard30.Visible = false; } break;
                case 31: if (this.LocalCard31.InvokeRequired)
                    { this.LocalCard31.BeginInvoke((MethodInvoker)delegate() { LocalCard31.Visible = false; }); }
                    else { LocalCard31.Visible = false; } break;
                case 32: if (this.LocalCard32.InvokeRequired)
                    { this.LocalCard32.BeginInvoke((MethodInvoker)delegate() { LocalCard32.Visible = false; }); }
                    else { LocalCard32.Visible = false; } break;
                case 33: if (this.LocalCard33.InvokeRequired)
                    { this.LocalCard33.BeginInvoke((MethodInvoker)delegate() { LocalCard33.Visible = false; }); }
                    else { LocalCard33.Visible = false; } break;
                case 34: if (this.LocalCard34.InvokeRequired)
                    { this.LocalCard34.BeginInvoke((MethodInvoker)delegate() { LocalCard34.Visible = false; }); }
                    else { LocalCard34.Visible = false; } break;
                case 35: if (this.LocalCard35.InvokeRequired)
                    { this.LocalCard35.BeginInvoke((MethodInvoker)delegate() { LocalCard35.Visible = false; }); }
                    else { LocalCard35.Visible = false; } break;
                case 36: if (this.LocalCard36.InvokeRequired)
                    { this.LocalCard36.BeginInvoke((MethodInvoker)delegate() { LocalCard36.Visible = false; }); }
                    else { LocalCard36.Visible = false; } break;
            }
        }

        //Изменить картинку карты, по номеру объекта
        public void ChangeCardByNum(int CardNum,int CardID)
        {
            switch (CardNum)
            {
                case 1: if (this.LocalCard1.InvokeRequired)
                    { this.LocalCard1.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard1, CardID); }); }
                    else { ChangeCard(LocalCard1, CardID); } break;
                case 2: if (this.LocalCard2.InvokeRequired)
                    { this.LocalCard2.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard2, CardID); }); }
                    else { ChangeCard(LocalCard2, CardID); } break;
                case 3: if (this.LocalCard3.InvokeRequired)
                    { this.LocalCard3.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard3, CardID); }); }
                    else { ChangeCard(LocalCard3, CardID); } break;
                case 4: if (this.LocalCard4.InvokeRequired)
                    { this.LocalCard4.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard4, CardID); }); }
                    else { ChangeCard(LocalCard4, CardID); } break;
                case 5: if (this.LocalCard5.InvokeRequired)
                    { this.LocalCard5.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard5, CardID); }); }
                    else { ChangeCard(LocalCard5, CardID); } break;
                case 6: if (this.LocalCard6.InvokeRequired)
                    { this.LocalCard6.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard6, CardID); }); }
                    else { ChangeCard(LocalCard6, CardID); } break;
                case 7: if (this.LocalCard7.InvokeRequired)
                    { this.LocalCard7.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard7, CardID); }); }
                    else { ChangeCard(LocalCard7, CardID); } break;
                case 8: if (this.LocalCard8.InvokeRequired)
                    { this.LocalCard8.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard8, CardID); }); }
                    else { ChangeCard(LocalCard8, CardID); } break;
                case 9: if (this.LocalCard9.InvokeRequired)
                    { this.LocalCard9.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard9, CardID); }); }
                    else { ChangeCard(LocalCard9, CardID); } break;
                case 10: if (this.LocalCard10.InvokeRequired)
                    { this.LocalCard10.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard10, CardID); }); }
                    else { ChangeCard(LocalCard10, CardID); } break;
                case 11: if (this.LocalCard11.InvokeRequired)
                    { this.LocalCard11.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard11, CardID); }); }
                    else { ChangeCard(LocalCard11, CardID); } break;
                case 12: if (this.LocalCard12.InvokeRequired)
                    { this.LocalCard12.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard12, CardID); }); }
                    else { ChangeCard(LocalCard12, CardID); } break;
                case 13: if (this.LocalCard13.InvokeRequired)
                    { this.LocalCard13.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard13, CardID); }); }
                    else { ChangeCard(LocalCard13, CardID); } break;
                case 14: if (this.LocalCard14.InvokeRequired)
                    { this.LocalCard14.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard14, CardID); }); }
                    else { ChangeCard(LocalCard14, CardID); } break;
                case 15: if (this.LocalCard15.InvokeRequired)
                    { this.LocalCard15.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard15, CardID); }); }
                    else { ChangeCard(LocalCard15, CardID); } break;
                case 16: if (this.LocalCard16.InvokeRequired)
                    { this.LocalCard16.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard16, CardID); }); }
                    else { ChangeCard(LocalCard16, CardID); } break;
                case 17: if (this.LocalCard17.InvokeRequired)
                    { this.LocalCard17.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard17, CardID); }); }
                    else { ChangeCard(LocalCard17, CardID); } break;
                case 18: if (this.LocalCard18.InvokeRequired)
                    { this.LocalCard18.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard18, CardID); }); }
                    else { ChangeCard(LocalCard18, CardID); } break;
                case 19: if (this.LocalCard19.InvokeRequired)
                    { this.LocalCard19.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard19, CardID); }); }
                    else { ChangeCard(LocalCard19, CardID); } break;
                case 20: if (this.LocalCard20.InvokeRequired)
                    { this.LocalCard20.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard20, CardID); }); }
                    else { ChangeCard(LocalCard20, CardID); } break;
                case 21: if (this.LocalCard21.InvokeRequired)
                    { this.LocalCard21.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard21, CardID); }); }
                    else { ChangeCard(LocalCard21, CardID); } break;
                case 22: if (this.LocalCard22.InvokeRequired)
                    { this.LocalCard22.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard22, CardID); }); }
                    else { ChangeCard(LocalCard22, CardID); } break;
                case 23: if (this.LocalCard23.InvokeRequired)
                    { this.LocalCard23.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard23, CardID); }); }
                    else { ChangeCard(LocalCard23, CardID); } break;
                case 24: if (this.LocalCard24.InvokeRequired)
                    { this.LocalCard24.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard24, CardID); }); }
                    else { ChangeCard(LocalCard24, CardID); } break;
                case 25: if (this.LocalCard25.InvokeRequired)
                    { this.LocalCard25.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard25, CardID); }); }
                    else { ChangeCard(LocalCard25, CardID); } break;
                case 26: if (this.LocalCard26.InvokeRequired)
                    { this.LocalCard26.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard26, CardID); }); }
                    else { ChangeCard(LocalCard26, CardID); } break;
                case 27: if (this.LocalCard27.InvokeRequired)
                    { this.LocalCard27.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard27, CardID); }); }
                    else { ChangeCard(LocalCard27, CardID); } break;
                case 28: if (this.LocalCard28.InvokeRequired)
                    { this.LocalCard28.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard28, CardID); }); }
                    else { ChangeCard(LocalCard28, CardID); } break;
                case 29: if (this.LocalCard29.InvokeRequired)
                    { this.LocalCard29.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard29, CardID); }); }
                    else { ChangeCard(LocalCard29, CardID); } break;
                case 30: if (this.LocalCard30.InvokeRequired)
                    { this.LocalCard30.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard30, CardID); }); }
                    else { ChangeCard(LocalCard30, CardID); } break;
                case 31: if (this.LocalCard31.InvokeRequired)
                    { this.LocalCard31.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard31, CardID); }); }
                    else { ChangeCard(LocalCard31, CardID); } break;
                case 32: if (this.LocalCard32.InvokeRequired)
                    { this.LocalCard32.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard32, CardID); }); }
                    else { ChangeCard(LocalCard32, CardID); } break;
                case 33: if (this.LocalCard33.InvokeRequired)
                    { this.LocalCard33.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard33, CardID); }); }
                    else { ChangeCard(LocalCard33, CardID); } break;
                case 34: if (this.LocalCard34.InvokeRequired)
                    { this.LocalCard34.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard34, CardID); }); }
                    else { ChangeCard(LocalCard34, CardID); } break;
                case 35: if (this.LocalCard35.InvokeRequired)
                    { this.LocalCard35.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard35, CardID); }); }
                    else { ChangeCard(LocalCard35, CardID); } break;
                case 36: if (this.LocalCard36.InvokeRequired)
                    { this.LocalCard36.BeginInvoke((MethodInvoker)delegate() { ChangeCard(LocalCard36, CardID); }); }
                    else { ChangeCard(LocalCard36, CardID); } break;
            }
        }

        //Перенести карту из нижней колоды, в верхнюю
        public void RemoveCard(int CardNum)
        {
            inClientHands++;
            for (int i = CardNum-1; i <inMyHands-1; i++)
            {
                MyCards[i] = MyCards[i+1];
                ChangeCardByNum(i+1, MyCards[i]);
            }
                //MyCards[CardNum - 1] = MyCards[inMyHands - 1];
            MyCards[inMyHands - 1] = 36;
            ChangeCardByNum(inMyHands, 36);
            inMyHands--;
            UpdatePosition();
        }

        //Функция переноса карты из верхней колоды, в нижнюю
        public void AddCard(int CardID)
        {
                MyCards[inMyHands] = CardID;
                inMyHands++;
                ChangeCardByNum(inMyHands, CardID);
                inClientHands--;
                UpdatePosition();
        }

        //Кнопка Не верю
        private void buttonLie_Click(object sender, EventArgs e)
        {
            Guessed(false);
        }

        //Кнопка Верю
        private void buttonTruth_Click(object sender, EventArgs e)
        {
            Guessed(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
