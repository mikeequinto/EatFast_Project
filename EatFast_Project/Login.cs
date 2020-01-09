using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EatFast_Project
{
    public partial class Login : Form
    {
        private static Login instance;

        private Login()
        {
            InitializeComponent();
        }

        public static Login getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new Login();
            }
            return instance;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string HashCode(string str)
        {
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(str);
            SHA1CryptoServiceProvider cryptoTransformSHA1 =
            new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(
                cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

            return hash;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxLoginEmail.Text == "" || textBoxLoginPassword.Text == "")
            {
                MessageBox.Show("The username or password is incorrect", "Information");
            }
            else
            {

                //Accès à la table eatfast_person dans la bdd
                DataSetEatFast personDataSet = new DataSetEatFast();
                DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter listePerson = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();
                listePerson.Fill(personDataSet.EATFAST_PERSON);

                try
                {
                    //Récupération de l'utilisateur
                    int id = (int)listePerson.FillByEmail(textBoxLoginEmail.Text);
                    DataSetEatFast.EATFAST_PERSONRow personRow = personDataSet.EATFAST_PERSON.FindByPER_ID(id);

                    if (personRow.PER_PASSWORD.Equals(HashCode(textBoxLoginPassword.Text))){
                        if (personRow.PER_ACCOUNTTYPE == "Client")
                        { //Si compte client
                            this.Hide();
                            Homepage homePage = Homepage.getInstance();
                            homePage.Show();
                            homePage.initializeUser(personRow);
                            
                        }
                        else
                        { //Si compte administrateur
                            this.Hide();
                            AdminHomepage adminHomepage = AdminHomepage.getInstance();
                            adminHomepage.Show();
                            adminHomepage.initializeUser(personRow);
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect", "Information");
                    }
                    
                }
                catch(Exception o)
                {
                    MessageBox.Show("The username or password is incorrect", "Information");
                    Console.Write(o);
                }
           
            }

        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            if (!textBoxSignupPassword.Text.Equals(textBoxSignupConfirm.Text))
            {
                MessageBox.Show("The passwords do not match", "Information");
            }
            else
            {
                if (textBoxSignupPassword.Text.Length < 8)
                {
                    MessageBox.Show("Your password needs to be at least 8 characters long", "Information");
                }
                else
                { //Enregistrer le nouvel utilisateur
                    RegisterUser();
                }
            
            }
            //this.Close();
        }

        private void RegisterUser()
        {
            //Accès à la table eatfast_person dans la bdd
            DataSetEatFast personDataSet = new DataSetEatFast();
            DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter listePerson = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();
            String name = textBoxSignupName.Text;
            String email = textBoxSignupEmail.Text;
            String password = HashCode(textBoxSignupPassword.Text);

            if(listePerson.FillByEmail(email) == null)
            { //Si le compte n'existe pas encore
                listePerson.AddAccount(name,email,password,"","Client");
                this.Hide();
                Homepage homepage = Homepage.getInstance();
                homepage.Show();
                //Pour que le nouvel utilisateur indique son adresse de livraison
                homepage.InitializeNewUser(email);
            }
            else
            { //Sinon informer que l'utilisateur existe déjà
                MessageBox.Show("A user with this email already exists");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CheckNewUserInfo(object sender, EventArgs e)
        {
            if(textBoxSignupName.Text != "" && textBoxSignupEmail.Text != "" 
                && textBoxSignupPassword.Text != "" && textBoxSignupConfirm.Text != "")
            {
                btnSignup.Enabled = true;
            }
        }
    }
}
