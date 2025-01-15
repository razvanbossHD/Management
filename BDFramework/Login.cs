using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFramework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += MyForm_FormClosing;
        }
        private Form1 mainForm = null;
        public Login(Form callingForm)
        {
            mainForm = callingForm as Form1;
            this.FormClosing += MyForm_FormClosing;
            InitializeComponent();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                using (ConturiDbContext ctx = new ConturiDbContext())
                {

                    Conturi c = new Conturi();
                    bool exists = ctx.Conturis
                         .Any(f => f.Cont == txtUsername.Text);

                    if (exists)
                    {
                        lblAfisare.Text = "Username-ul exista deja";
                    }
                    else
                    {
                        c.Cont=txtUsername.Text;
                        SHA256 sha256 = SHA256.Create();

                        byte[] input = Encoding.UTF8.GetBytes(txtPassword.Text);
                        byte[] hash = sha256.ComputeHash(input);

                        StringBuilder output = new StringBuilder();

                        foreach (byte b in hash)
                        {
                            output = output.Append(b.ToString("x2"));
                        }

                        c.Parola = output.ToString();
                        c.Nivel = 1;
                        
                        ctx.Conturis.Add(c);
                        ctx.SaveChanges();
                        this.FormClosing -= MyForm_FormClosing;
                        this.Close();
                        this.FormClosing += MyForm_FormClosing;
                    }


                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                using (ConturiDbContext ctx = new ConturiDbContext())
                {
                    var cont = ctx.Conturis
                        .FirstOrDefault(f => f.Cont == txtUsername.Text);

                    if (cont != null)
                    {

                        Conturi c = new Conturi();

                        c.Cont = txtUsername.Text;
                        SHA256 sha256 = SHA256.Create();

                        byte[] input = Encoding.UTF8.GetBytes(txtPassword.Text);
                        byte[] hash = sha256.ComputeHash(input);

                        StringBuilder output = new StringBuilder();

                        foreach (byte b in hash)
                        {
                            output = output.Append(b.ToString("x2"));
                        }
                        c.Parola = output.ToString();
                        c.Nivel = 1;
                        if (cont.Parola==output.ToString())
                        {
                            this.FormClosing -= MyForm_FormClosing;
                            this.mainForm.Nivel=cont.Nivel;
                            this.Close();
                            this.FormClosing += MyForm_FormClosing;
                        }
                        else { Console.WriteLine(cont.Parola+"\n"+c.Parola); }
                        
                    }
                    else
                    {
                        Console.WriteLine("Person not found.");
                    }

                }
            }
        }
    }
}
