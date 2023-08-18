using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_1_BaiThiCuoiKy
{
    public partial class FormMenu : Form
    {
        class Speciality
        {
            public string foodandrink { get; set; }
            public string PicName { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }

        }
        const string food = "Đồ ăn", Drink = "Đồ uống", All = "Tất cả";
        SortedList<String, Speciality> Specialities;

        private void FormMenu_Load(object sender, EventArgs e)
        {
            cbofoodanddrink.Items.Add(food);
            cbofoodanddrink.Items.Add(Drink);
            cbofoodanddrinkFilter.Items.Add(All);
            cbofoodanddrinkFilter.Items.Add(food);
            cbofoodanddrinkFilter.Items.Add(Drink);
            cbofoodanddrinkFilter.SelectedIndex = cbofoodanddrinkFilter.SelectedIndex = 0;

            OutputList();
            lstSpecialities.SelectedIndex = 0;
        }
        private void OutputList()
        {
            lstSpecialities.Items.Clear();
            foreach (KeyValuePair<string, Speciality> pair in Specialities)
            {
                if (cbofoodanddrinkFilter.Text == All || pair.Value.foodandrink == cbofoodanddrinkFilter.Text)
                    lstSpecialities.Items.Add(pair.Key + " - " + pair.Value.Name);
            }
        }
        public FormMenu()
        {
            InitializeComponent();
            Initializelist();
        }

        private void lstSpecialities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpecialities.SelectedIndex < 0) return;
            int index = lstSpecialities.Text.IndexOf('-');
            string key = lstSpecialities.Text.Substring(0, index).Trim();
            Speciality spec;
            bool result = Specialities.TryGetValue(key, out spec);
            if (!result)
            {
                MessageBox.Show("Không tìm thấy món đã chọn", "Lỗi");
                return;
            }
            txtKey.Text = key;
            txtName.Text = spec.Name;
            txtGiaTien.Text = spec.Price;
            picFood.ImageLocation = @"hinh anh\" + spec.PicName;
            cbofoodanddrink.SelectedIndex = cbofoodanddrink.Items.IndexOf(spec.foodandrink);
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            Speciality spec = new Speciality { Name = txtName.Text, foodandrink = cbofoodanddrink.Text };
            Specialities[txtKey.Text] = spec;
            OutputList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSpecialities.SelectedIndex < 0) return;
            int index = lstSpecialities.Text.IndexOf('-');
            string key = lstSpecialities.Text.Substring(0, index).Trim();
            Specialities.Remove(key);
            OutputList();
        }

        private void cbofoodanddrinkFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputList();
        }
        private void Initializelist()
        {
            Specialities = new SortedList<String, Speciality>()
            {
                {"B01", new Speciality{Name = "Bánh gạo", PicName = "Banhgao.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 24000) }   },
                {"B02", new Speciality{Name = "Bánh bông lan", PicName = "Banhbonglan.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 64000)}  },
                {"B03", new Speciality{Name = "Bánh Choco-Pie", PicName = "Banhchoco-Pie.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 24000)}  },
                {"B04", new Speciality{Name = "Bánh Pía", PicName = "BanhPia.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 15000)}  },
                {"B05", new Speciality{Name = "Bánh Bao", PicName = "Banhbao.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 15000)}  },
                {"B06", new Speciality{Name = "Bánh Crepe", PicName = "Banhcrepe.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 20000)}  },
                {"B07", new Speciality{Name = "Sandwich", PicName = "Sandwich.png", foodandrink = food, Price = String.Format("{0:N} VNĐ", 15000)}  },
                {"B08", new Speciality{Name = "Bánh Oreo", PicName = "Banhoreo.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 15000)}  },
                {"B09", new Speciality{Name = "Bánh Quy bơ", PicName = "Banhquybo.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 64000)}  },
                {"B10", new Speciality{Name = "Bánh Kem", PicName = "Banhkem.PNG", foodandrink = food, Price = String.Format("{0:N} VNĐ", 100000)}  },

                {"K01", new Speciality{Name = "Kem Phô Mai", PicName = "KemPhoMai.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 24000)}  },
                {"K02", new Speciality{Name = "Kem Sầu Riêng", PicName = "KemSaurieng.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 24000)}  },
                {"K03", new Speciality{Name = "Kem Chuối", PicName = "KemChuoi.JPEG", foodandrink = food, Price = String.Format("{0:N} VNĐ", 10000)}  },
                {"K04", new Speciality{Name = "Kem Socola", PicName = "KemSocola.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 10000)}  },


                {"M01", new Speciality{Name = "Mì hảo hảo", PicName = "Mihaohao.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 3000)}  },
                {"M02", new Speciality{Name = "Mì Ba Miền", PicName = "MiBamien.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 6000)}  },
                {"M03", new Speciality{Name = "Mì Gấu Đỏ", PicName = "MiGaudo.jpg", foodandrink = food, Price = String.Format("{0:N} VNĐ", 3000)}  },
                {"M04", new Speciality{Name = "Mì Omachi", PicName = "MiOmachi.JFIF", foodandrink = food, Price = String.Format("{0:N} VNĐ", 6000)}  },

                {"N01", new Speciality{Name = "Sting", PicName = "Sting.jpg", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 10000)}  },
                {"N02", new Speciality{Name = "Coca-cola", PicName = "Coca-cola.PNG", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 10000)}  },
                {"N03", new Speciality{Name = "Red Bull", PicName = "RedBull.JFIF", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 10000)}  },
                {"N04", new Speciality{Name = "Pepsi", PicName = "Pepsi.JPEG", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 10000)}  },
                {"N05", new Speciality{Name = "Nước Suối", PicName = "Nuocsuoi.JFIF", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 5000)}  },
                {"N06", new Speciality{Name = "Bia Tiger", PicName = "Biatiger.jpg", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 12000)}  },
                {"N07", new Speciality{Name = "Bia Heineken", PicName = "BiaHeineken.jpg", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 12000)}  },
                {"N08", new Speciality{Name = "Bia Sài Gòn", PicName = "Biasaigon.PNG", foodandrink = Drink, Price = String.Format("{0:N} VNĐ", 12000)}  },
            };
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            FormAdmin formadmin = new FormAdmin();
            formadmin.ShowDialog();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            FormGiohang btnDatMon = new FormGiohang();
            btnDatMon.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
