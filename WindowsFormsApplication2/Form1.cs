using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=Evgenii\SQLEXPRESS;Initial Catalog=Techins;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            VisFalse();
           

           /* // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            Console.Read();*/
            

        }
  
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void VisTrue()
        {
            textAdres.Visible = true;
            textNomerPrav.Visible = true;
            textMark.Visible = true;
            textNomerP.Visible = true;
            textGodV.Visible = true;
            textFIO.Visible = true;
            textDateR.Visible = true;
            textIsgotov.Visible = true;
            textVIN.Visible = true;
            textTelefon.Visible = true;
            labelAdres.Visible = true;
            labelDataR.Visible = true;
            labelGodV.Visible = true;
            labelIsgotov.Visible = true;
            labelMark.Visible = true;
            labelNomerP.Visible = true;
            labelNomerPrav.Visible = true;
            labelTelefon.Visible = true;
            labelVIN.Visible = true;
            labelFIO.Visible = true;
            buttonNew.Visible = true;
            buttonSave.Visible = true;
            //dataGridView1.Visible = true;
        }
        private void Start()
        {
            textAdres.Text = "";
            textNomerPrav.Text = "";
            textMark.Text = "";
            textNomerP.Text = "";
            textGodV.Text = "";
            textFIO.Text = "";
            textDateR.Text = "";
            textIsgotov.Text = "";
            textVIN.Text = "";
            textTelefon.Text = "";
            textBD.Text = "";
            textZapr.Text = "";
        }
        private void VisFalse()
        {
            textAdres.Visible = false;
            textNomerPrav.Visible = false;
            textMark.Visible = false;
            textNomerP.Visible = false;
            textGodV.Visible = false;
            textFIO.Visible = false;
            textDateR.Visible = false;
            textIsgotov.Visible = false;
            textVIN.Visible = false;
            textTelefon.Visible = false;
            labelAdres.Visible = false;
            labelDataR.Visible = false;
            labelGodV.Visible = false;
            labelIsgotov.Visible = false;
            labelMark.Visible = false;
            labelNomerP.Visible = false;
            labelNomerPrav.Visible = false;
            labelTelefon.Visible = false;
            labelVIN.Visible = false;
            labelFIO.Visible = false;
            buttonSave.Visible = false;
            dataGridView1.Visible = false;
            textZapr.Visible = false;
            labelZapr.Visible = false;
            buttonOtpr.Visible = false;
            buttonSaveBD.Visible = false;
            textBD.Visible = false;
            labelFail.Visible = false;
            lableKodRab.Visible = false;
            lableOpis.Visible = false;
            labelNeisp.Visible = false;
            labelMoney.Visible = false;
            labelTime.Visible = false;
            buttonSaveD.Visible = false;
            buttonSaveNeis.Visible = false;
            button1.Visible = false;
            buttonSend.Visible = false;
        
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            VisFalse();
            VisTrue();   
        }

        private void labelFIO_Click(object sender, EventArgs e)
        {

        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Adres, NomerPrav, Mark, NomerP, GodV, FIO, DateR, Isgotov, VIN, Telefon;

            Adres = textAdres.Text;
            NomerP = textNomerP.Text;
            Mark = textMark.Text;
            NomerPrav = textNomerPrav.Text;
            GodV = textGodV.Text;
            FIO = textFIO.Text;
            DateR = textDateR.Text;
            Isgotov = textIsgotov.Text;
            VIN = textVIN.Text;
            Telefon = textTelefon.Text;


            string InsVlad = "INSERT INTO Владелец (Код_владельца,ФИО,Адрес,Номер_паспорта,Телефон,Дата_рождения,Права) VALUES ((SELECT Value FROM Value)+1,'" + FIO + "','" + Adres + "'," + NomerP + "," + Telefon + ",'" + DateR + "','" + NomerPrav + "')";
            string InsAuto = "INSERT INTO Автомобиль (Код_владельца,VIN_номер,Марка,Год_выпуска,Изготовитель) VALUES ((SELECT Value FROM Value)+1,'" + VIN + "','" + Mark + "','" + GodV + "','" + Isgotov + "')";
            string Update = "UPDATE Value SET Value=(SELECT Value FROM Value)+1";
            //string sqlExpression = "INSERT INTO Владелец (Код_владельца,ФИО,Адрес,Номер_паспорта,Телефон,Дата_рождения,Права) VALUES (1,'" + FIO + "','" + Adres + "'," + NomerP + "," + Telefon + ",'" + DateR + "','" + NomerPrav + "')";
            string Sel = "SELECT * FROM Владелец,Автомобиль";
            string Seq = "SELECT * FROM Работник";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(InsVlad, connection);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand(InsAuto, connection);
                    command2.ExecuteNonQuery();
                    SqlCommand command3 = new SqlCommand(Update, connection);
                    command3.ExecuteNonQuery();
                    VisFalse();
                    Start();
                }
                catch (SqlException es)
                {
                    string message = "Ошибка ввода данных, повторите ввод.";
                    string caption = "Error!";
                    MessageBoxButtons mesbutt = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, mesbutt);
                    SqlCommand command5 = new SqlCommand("DELETE FROM Автомобиль WHERE Код_владельца = ((SELECT Value FROM Value )+1)", connection);
                    command5.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand("DELETE FROM Владелец WHERE Код_владельца = ((SELECT Value FROM Value )+1)", connection);
                    command4.ExecuteNonQuery();
                   
                }
                connection.Close();
               
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "techinsDataSet.Владелец". При необходимости она может быть перемещена или удалена.
            this.владелецTableAdapter.Fill(this.techinsDataSet.Владелец);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisFalse();
            textZapr.Visible = true;
            labelZapr.Visible = true;
            buttonOtpr.Visible = true;
        }

        private void buttonOtpr_Click(object sender, EventArgs e)
        {
            labelFail.Visible = false;
            try
            {
                dataGridView1.Visible = true;
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(textZapr.Text, connection1);
                    if ((textZapr.Text).Contains("SELECT") && (textZapr.Text).Substring(0, 1)=="S")
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                    }
                    Start();
                    connection1.Close();
                }
            }
            catch (SqlException eq)
            {
                labelFail.Visible = true;
                dataGridView1.Visible = false;
            }
        }

        private void buttonBD_Click(object sender, EventArgs e)
        {
            buttonChange.Visible = false;
            buttonSaveBD.Visible = true;
            textBD.Visible = true;
        }

        private void buttonSaveBD_Click(object sender, EventArgs e)
        {
            if (textBD.Text != "")
            {
                connectionString = textBD.Text;
                buttonSaveBD.Visible = false;
                textBD.Visible = false;
                buttonChange.Visible = true;
            }
            else
            {
                buttonSaveBD.Visible = false;
                textBD.Visible = false;
                buttonChange.Visible = true;
            }
        }

        private void buttonNeisp_Click(object sender, EventArgs e)
        {
            VisFalse();
            textVIN.Visible = true;
            textMark.Visible = true;
            textGodV.Visible = true;
            textIsgotov.Visible = true;
            labelVIN.Visible = true;
            lableKodRab.Visible = true;
            lableOpis.Visible = true;
            labelTime.Visible = true;
            buttonSaveNeis.Visible = true;
        }

        private void buttonDet_Click(object sender, EventArgs e)
        {
            VisFalse();
            textVIN.Visible = true;
            textMark.Visible = true;
            textGodV.Visible = true;
            textIsgotov.Visible = true;
            button1.Visible = true;
            textFIO.Visible = true;
            labelVIN.Visible = true;
            labelNeisp.Visible = true;
            lableOpis.Visible = true;
            labelMoney.Visible = true;
            buttonSaveD.Visible = true;
            dataGridView1.Visible = true;
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection2.Open();
                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT Неисправность.Код_неисправности,Неисправность.описание,Автомобиль.VIN_номер FROM Неисправность inner join Автомобиль on Неисправность.Код_владельца=Автомобиль.Код_Владельца", connection2);
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
                connection2.Close();
            }

            Start();
        }

        private void buttonTekZak_Click(object sender, EventArgs e)
        {
            VisFalse();
            string zakaz = "select Код_заказа,od.Код_владельца,Автомобиль.Изготовитель+Автомобиль.Марка as 'Автомобиль', tr.Описание, od.Дата, od.Сумма from Заказ od left join Автомобиль on od.VIN_номер=Автомобиль.VIN_номер left join Владелец cl on cl.Код_владельца=Автомобиль.Код_владельца left join Неисправность tr on tr.Код_неисправности=od.Код_неисправности left join Детали dt on tr.Код_неисправности=dt.Код_неисправности group by od.Код_заказа, cl.ФИО,Автомобиль.Изготовитель,Автомобиль.Марка, Автомобиль.Год_выпуска, tr.Описание, od.Дата, od.Сумма ,od.Код_владельца order by od.Код_заказа";
            dataGridView1.Visible = true;
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection2.Open();
                SqlDataAdapter adapter2 = new SqlDataAdapter(zakaz, connection2);
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
                connection2.Close();
            }
            
        }

        private void buttonRab_Click(object sender, EventArgs e)
        {
            VisFalse();
            string rab = "select c.Изготовитель+c.Марка+c.VIN_номер as 'Автомобиль', emp.Код_работника, tr.Время_устранения from Автомобиль c inner join Неисправность tr on c.VIN_номер=tr.VIN_номер inner join Работник emp on emp.Код_работника=tr.Код_работника union all select 'Итого автомобилей:', '', count(*) from Автомобиль inner join Неисправность on Неисправность.VIN_номер=Автомобиль.VIN_номер";
            dataGridView1.Visible = true;
            using (SqlConnection connection3 = new SqlConnection(connectionString))
            {
                connection3.Open();
                SqlDataAdapter adapter3 = new SqlDataAdapter(rab , connection3);
                DataSet ds3 = new DataSet();
                adapter3.Fill(ds3);
                dataGridView1.DataSource = ds3.Tables[0];
                connection3.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Update = "UPDATE Value SET Value=(SELECT Value FROM Value)+1";
            string neisp = "INSERT INTO Неисправность (Код_неисправности,Код_работника,Описание,Время_устранения,VIN_номер,Код_владельца) VALUES ((SELECT Value FROM Value)+1,'" + textMark.Text + "','" + textGodV.Text + "','" + textIsgotov.Text + "','" + textVIN.Text + "',(SELECT Код_владельца FROM Автомобиль WHERE VIN_номер='" + textVIN.Text + "'))";
            string zakaz = "INSERT INTO Заказ (Код_неисправности,Код_заказа,Сумма,Дата,VIN_номер,Код_владельца,Статус) VALUES ((SELECT Value FROM Value)+1,(SELECT Value FROM Value)+1,0,GETDATE(),'" + textVIN.Text + "',(SELECT Код_владельца FROM Автомобиль WHERE VIN_номер='" + textVIN.Text + "'),0)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(neisp, connection);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand(zakaz, connection);
                    command2.ExecuteNonQuery();
                    SqlCommand command3 = new SqlCommand(Update, connection);
                    command3.ExecuteNonQuery();
                    VisFalse();
                    Start();
                }
                catch (SqlException es)
                {
                    string message = "Ошибка ввода данных, повторите ввод.";
                    string caption = "Error!";
                    MessageBoxButtons mesbutt = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, mesbutt);
                    SqlCommand command5 = new SqlCommand("DELETE FROM Заказ WHERE Код_владельца = ((SELECT Value FROM Value )+1)", connection);
                    command5.ExecuteNonQuery();
                    SqlCommand command1 = new SqlCommand("DELETE FROM Неисправность WHERE Код_владельца = ((SELECT Value FROM Value )+1)", connection);
                    command1.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        private void buttonSaveD_Click(object sender, EventArgs e)
        {
            string Update = "UPDATE Value SET Value=(SELECT Value FROM Value)+1";
            string det = "INSERT INTO Детали (Код_неисправности,Код_детали,Описание,Стоимость,VIN_номер,Код_владельца) VALUES (" + textMark.Text + ",(SELECT Value FROM Value)+1,'" + textGodV.Text + "'," + textIsgotov.Text + ",'" + textVIN.Text + "',(SELECT Код_владельца FROM Автомобиль WHERE VIN_номер='" + textVIN.Text + "'))";
            string zakaz = "UPDATE Заказ SET Сумма=Сумма+'" + textIsgotov.Text + "' WHERE VIN_номер='" + textVIN.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(det, connection);
                    command.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand(zakaz, connection);
                    command4.ExecuteNonQuery();
                    SqlCommand command3 = new SqlCommand(Update, connection);
                    command3.ExecuteNonQuery();
                    
                    VisFalse();
                    Start();
               }
               catch (SqlException es)
               {
                   string message = "Ошибка ввода данных, повторите ввод.";
                   string caption = "Error!";
                   MessageBoxButtons mesbutt = MessageBoxButtons.OK;
                   MessageBox.Show(message, caption, mesbutt);
               }
                
                connection.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           using (SqlConnection connection3 = new SqlConnection(connectionString))
            {
                connection3.Open();
                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT Неисправность.Код_неисправности,Неисправность.описание,Автомобиль.VIN_номер FROM Неисправность inner join Автомобиль on Неисправность.Код_владельца=Автомобиль.Код_Владельца WHERE Автомобиль.VIN_номер='" + textFIO.Text + "'", connection3);
                DataSet ds3 = new DataSet();
                adapter3.Fill(ds3);
                dataGridView1.DataSource = ds3.Tables[0];
                connection3.Close();
            } 
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            using (SqlConnection connection3 = new SqlConnection(connectionString))
            {
                connection3.Open();
                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT Неисправность.описание as 'Неисправность',Детали.Описание as 'Деталь',Детали.Стоимость as 'Стоимость' FROM Неисправность inner join Детали on Неисправность.код_неисправности=Детали.Код_неисправности WHERE Неисправность.VIN_номер='" + textVIN.Text + "'", connection3);
                DataSet ds3 = new DataSet();
                adapter3.Fill(ds3);
                dataGridView1.DataSource = ds3.Tables[0];
                connection3.Close();
            } 
            
            Start();
        }

        private void buttonDannie_Click(object sender, EventArgs e)
        {
            VisFalse();
            buttonSend.Visible = true;
            textVIN.Visible = true;
            labelVIN.Visible = true;
        }
    }
}
