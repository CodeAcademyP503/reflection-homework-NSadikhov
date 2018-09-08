using ServiceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceApp.Core;
using ServiceApp.Core.Generators;

namespace ServiceApp
{

    class Demo : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Card card = new Card()
            {
                Number = textBox1.Text
            };

            using (Database db = new InMemoryDatabase())
            {

                db.Cards.Add(new Card
                {
                    Id = 1,
                    Number = "12345",
                    IsUsed = false,
                    Balance = 45,
                    CurrencyType = CurrencyType.USD,
                    AddedDate = DateTime.Now
                });


                Card existsCard = db.Cards.Exists(card);
                if (existsCard != null)
                {
                    string n = new NameGenerator().Generate();
                    AppUser appUser = new AppUser()
                    {
                        Email = new EmailGenerator().Generate(),
                        MobileNumber = "",
                        Name = n,
                        Password = n,
                        Role = Role.User,
                        Balance = existsCard.Balance
                    };

                    AppUser addedUser = db.Users.Add(appUser);


                    if (addedUser != null)
                    {
                        existsCard.IsUsed = true;
                        existsCard.ActivatedDate = DateTime.Now;
                        db.Cards.Update(existsCard);

                        existsCard.ActivatedBy = addedUser;
                        existsCard.ActivatedById = addedUser.Id;
                        db.Cards.Update(existsCard);
                    }
                }

            }

        }
    }
}
