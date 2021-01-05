using proj2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tjänst
{
    public partial class Stugtjänster : Form
    {
        int reservationID = 0;
        public Stugtjänster()
        {
            InitializeComponent();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void updateCabinListBox(List<Cabin> cabins)
        {

            stugorList.Items.Clear();
            foreach (Cabin cabin in cabins)
            {
                stugorList.Items.Add(cabin.name);

            }
        }
        public void updateServiceListBox(List<Service> services)
        {

                 serviceList.Items.Clear();
            foreach (Service service in services)
            {
                serviceList.Items.Add(service.serviceType);

            }
        }
        public void updateReservationListBox(List<Reservation> reservations)
        {
            reservationList.Items.Clear();

            foreach (Reservation reservation in reservations)
            {
                reservationList.Items.Add("ID: "+reservation.ID+" Stuga: "+reservation.cabin+" Tjänst: "+reservation.serviceType+" Datum: "+reservation.datum);

            }
        }
        private async void sendEmail_ClickAsync(object sender, EventArgs e)
        {
            string email = emailText.Text;
        
            RestApi api = new RestApi();
            List<Cabin> cabins = await api.getCabins(email);
            List<Service> services = await api.getServices();
            List<Reservation> reservations = await api.getReservations(email);
            updateCabinListBox(cabins);
            updateServiceListBox(services);
            updateReservationListBox(reservations);
            
        }


        private async void bookButton_Click(object sender, EventArgs e)
        {

            string email = emailText.Text;
            Reservation reservation = new Reservation();
            reservation.ID = 23;
            reservation.serviceType = (string)serviceList.SelectedItem;
            reservation.cabin = (string)stugorList.SelectedItem;
            reservation.datum = datum.Text;
            reservation.booker = email;
            RestApi api = new RestApi();
            await api.saveReservation(reservation);
            List<Reservation> reservations = await api.getReservations(email);
            updateReservationListBox(reservations);


        }

        
        private void stugorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void deleteButton_ClickAsync(object sender, EventArgs e)
        {
            //splitta med mellanrum
          
            string email = emailText.Text;
            string reserv = reservationList.SelectedItem.ToString();
            string[] ssize = reserv.Split(null);
            long id = Int64.Parse(ssize[1]);
            RestApi api = new RestApi();
            await api.deleteReservation(id);
            List<Reservation> reservations = await api.getReservations(email);
            updateReservationListBox(reservations);
            
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datum_TextChanged(object sender, EventArgs e)
        {

        }

        private async void modifyButton_ClickAsync(object sender, EventArgs e)
        {
          
                string email = emailText.Text;


                string reserv = reservationList.SelectedItem.ToString();
                string[] ssize = reserv.Split(null);

                long id = Int64.Parse(ssize[1]);
                Debug.WriteLine(id);
                Reservation reservation = new Reservation();
                reservation.serviceType = (string)serviceList.SelectedItem;
                reservation.cabin = (string)stugorList.SelectedItem;
                reservation.datum = datum.Text;
                reservation.booker = emailText.Text;


                RestApi api = new RestApi();
                await api.modifyReservation(reservation, id);
                List<Reservation> reservations = await api.getReservations(email);
                updateReservationListBox(reservations);
            }
          

        }

     
    }

