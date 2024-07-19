using _16_Repository_ManagerMantigi.Entities;
using _16_Repository_ManagerMantigi.MyTools;
using _16_Repository_ManagerMantigi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Repository_ManagerMantigi.Forms
{
    public partial class StudentOpt : Form
    {
        public StudentOpt()
        {
            InitializeComponent();
        }

        StudentRepository sRepo = new StudentRepository();
        StudentManager sManager;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sManager = new StudentManager(sRepo);

                if (Tools.BilgileriKontrolEt(grpOgrenciBilgileri))
                {
                    throw new Exception("Lütfen tüm alanları doldurunuz.");
                }

                Student s = new Student()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    TC = txtTC.Text,
                    BirthDate = DateOnly.Parse(txtDTarihi.Text),
                    IsActive = chkAktifPasif.Checked
                };

                sManager.Add(s);
                OgrencileriGetir();
                MessageBox.Show("İşlem Başarılı.");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void OgrencileriGetir()
        {
            lstListe.DataSource = null;
            lstListe.DisplayMember = "FullName";
            lstListe.ValueMember = "ID";
            lstListe.DataSource = sManager.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                //Seçilen öğrenci id bilgisini yakalayarak, silme işlemini yapıyoruz.
                if (lstListe.SelectedIndex != -1)
                {
                    sManager.Delete(lstListe.SelectedValue.ToString());
                }

                OgrencileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentOpt_Load(object sender, EventArgs e)
        {
            chkAktifPasif.Checked = true;
        }

        private void chkAktifPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAktifPasif.Checked)
            {
                chkAktifPasif.Text = "Aktif";
            }
            else
            {
                chkAktifPasif.Text = "Pasif";
            }
        }


        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
