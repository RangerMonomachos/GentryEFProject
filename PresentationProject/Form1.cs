using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataProject;

//Continue with the IT410 from 2/24/2021
//We still need a deleat and to format the output so as to not have the ID shown.
//also... make sure to recheck microsoft and the government
namespace PresentationProject
{
    public partial class Form1 : Form
    {
        SalesContext ctx = new SalesContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //do the start full load into the feild
            FullListReturn();
        }

        // this is the create method of the CRUD this will also prevent a user from trying to make a new line without the nesesary information.
        private void AddNew_Click(object sender, EventArgs e)
        {
            if(FirstNameAnswer.Text != "" && LastNameAnswer.Text != "")
            {
                Customer NewCustomer = new Customer();
                NewCustomer.Id = ctx.Customers.Count() + 1;
                NewCustomer.FirstName = FirstNameAnswer.Text;
                NewCustomer.LastName = LastNameAnswer.Text;
                NewCustomer.City = CityAnswer.Text;
                NewCustomer.Country = CountryAnswer.Text;
                NewCustomer.Phone = PhoneNumberAnswer.Text;
                ctx.Customers.Add(NewCustomer);
                ctx.SaveChanges();

                FirstNameAnswer.Text = "";
                LastNameAnswer.Text = "";
                CityAnswer.Text = "";
                CountryAnswer.Text = "";
                PhoneNumberAnswer.Text = "";
                FullListReturn();
            }
        }

        //This is the find method and filter method with the added benifet of if the box is empty it returns us to the origenal form
        private void FindLastName_Click(object sender, EventArgs e)
        {
            if (LastNameToBeFound.Text != "")
            {
                string ToFind = LastNameToBeFound.Text;
                switch(SearchType.Text)
                {
                    case "Last Name":
                        var FoundCustomer = ctx.Customers.Where(F => F.LastName == ToFind).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                        DataVeiwOutput.DataSource = FoundCustomer;
                        break;
                    case "City":
                        var FoundCustomerCity = ctx.Customers.Where(c => c.City == ToFind).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                        DataVeiwOutput.DataSource = FoundCustomerCity;
                        break;
                    case "Last Name (char)":
                        var CharSearch = ctx.Customers.Where(c => c.LastName.StartsWith(ToFind)).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                        DataVeiwOutput.DataSource = CharSearch;
                        break;
                    case "All":
                        LastNameToBeFound.Text = "";
                        FullListReturn();
                        break;
                    default:
                        var FindDefault = ctx.Customers.Where(d => d.LastName == ToFind).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                        DataVeiwOutput.DataSource = FindDefault;
                        break;
                }              
            }
            else
            {
                FullListReturn();
            }
        }

        //Returns an list to the view set to the Lastname this is also the Read on the CRUD
        private void FullListReturn()
        {
            var allRows = ctx.Customers.OrderBy(a => a.LastName).Select(s => new{ s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
            DataVeiwOutput.DataSource = allRows;
        }

        //this is the update part of the CRUD
        private void DataVeiwOutput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ctx.SaveChanges();
        }

        private void RemoveFromList_Click(object sender, EventArgs e)
        {
            if (DataVeiwOutput.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
            {
                //int RowIDToRemove = DataVeiwOutput.
                string userFirst = (string)DataVeiwOutput.SelectedRows[0].Cells[0].Value;
                string userCity = (string)DataVeiwOutput.SelectedRows[0].Cells[2].Value;
                string userCountry = (string)DataVeiwOutput.SelectedRows[0].Cells[3].Value;
                string userPhone = (string)DataVeiwOutput.SelectedRows[0].Cells[4].Value;

                int FindRows = ctx.Customers.Where(f => f.LastName == LastNameToBeRemoved.Text && f.FirstName == userFirst && f.City == userCity && f.Country == userCountry && f.Phone == userPhone).Select(i => i.Id).FirstOrDefault();

                //int RemovedId = ctx.Customers.Where(a => a.LastName)
                ctx.Remove(ctx.Customers.Find(FindRows));
                ctx.SaveChanges();
                RemoveFromList.Enabled = false;
                LastNameToBeRemoved.Text = "";
                FullListReturn();
            }
        }

        private void FindLastNameToBeRemoved_Click(object sender, EventArgs e)
        {
            if(LastNameToBeRemoved.Text != "")
            {
                var FindRows = ctx.Customers.Where(f => f.LastName == LastNameToBeRemoved.Text).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                DataVeiwOutput.DataSource = FindRows;
                RemoveFromList.Enabled = true;
            }
        }
    }
}
