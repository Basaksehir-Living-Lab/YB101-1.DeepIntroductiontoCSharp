using _16_Repository_ManagerMantigi.Entities;
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
    public partial class CourseOpt : Form
    {
        private readonly CourseManager _courseManager;
        public CourseOpt()
        {
            InitializeComponent();
            CourseRepository cRep = new CourseRepository();
            _courseManager = new CourseManager(cRep);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CourseOpt_Load(object sender, EventArgs e)
        {
            //CourseRepository tamamlanacak
            //CourseManager sınıfı eklenecek
            //CourseOpt formu kodlanacak. (Kaydet ve listele işlemleri yeterli)
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtBaslangic.Value.Date >= dtBitis.Value.Date)
                {
                    throw new Exception("Başlangıç Tarihi Bitiş Tarihine eşit veya büyük olamaz.");
                }

                Course c = new Course()
                {
                    CourseName = txtKursAdi.Text,
                    StartDate = dtBaslangic.Value.Date,
                    EndDate = dtBitis.Value.Date,
                    IsActive = chkAktifPasif.Checked
                };

                _courseManager.Add(c);
                GetAllCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllCourses()
        {
            lstListe.Items.Clear();
            var liste = _courseManager.GetAll();

            if (liste != null)
            {
                liste.ForEach(c => lstListe.Items.Add(c));
            }
        }
    }
}
