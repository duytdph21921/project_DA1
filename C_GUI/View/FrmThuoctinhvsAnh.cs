using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using B_BUS.IService;
using B_BUS.Service;
using B_BUS.ViewModel;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace C_GUI.View
{
    public partial class FrmThuoctinhvsAnh : Form
    {
        IAnhService _IAnhservice;
        IMauSacService _IMauSacService;
        INsxService _INsxService;
        IDongCoService _IDongcoService;
        IKhoiDongService _IkhoiDongService;
        ILoaiXeService _IloaiXeService;
        IChucVuService _IChucVuService;
        // tạo 1 trường để lưu đường dẫn ảnh
        string imageUrl = "";
        Guid _IdChung;
        public FrmThuoctinhvsAnh()
        {
            InitializeComponent();
            _IAnhservice = new AnhService();
            _IChucVuService = new ChuVuService();
            _IMauSacService = new MauSacService();
            _IDongcoService = new DongCoService();
            _IkhoiDongService = new KhoiDongService();
            _IloaiXeService = new LoaiXeService();
            _INsxService = new NsxService();
            loadataa();
        }
        #region các radiobutton thuộc tính

        //
        // Loại Xe
        //
        private void RD_LoaiXe_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_LoaiXe.Checked == true)
            {
                PCB_Test.Visible = false;
                BTN_ThemAnh.Visible = false;
                loadataa();
            }
        }
        //
        // nhà Sản xuất
        //
        private void RD_NSX_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_NSX.Checked == true)
            {
                PCB_Test.Visible = false;
                BTN_ThemAnh.Visible = false;
                loadataa();
            }
        }
        //
        // Khởi Động
        //
        private void RD_KhoiDong_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_KhoiDong.Checked == true)
            {
                PCB_Test.Visible = false;
                BTN_ThemAnh.Visible = false;
                loadataa();
            }
        }
        //
        // Màu Sác
        //
        private void RD_MauSac_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_MauSac.Checked == true)
            {
                PCB_Test.Visible = false;
                BTN_ThemAnh.Visible = false;
                loadataa();
            }
        }
        //
        // Động cơ
        //
        private void RD_DongCo_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_DongCo.Checked == true)
            {
                PCB_Test.Visible = false;
                BTN_ThemAnh.Visible = false;
                loadataa();
            }
        }
        //
        // Ảnh
        //
        private void RD_Anh_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Anh.Checked == true)
            {
                PCB_Test.Visible = true;
                BTN_ThemAnh.Visible = true;
                loadataa();
            }
        }
        //
        // Chức Vụ
        //
        private void RD_ChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_ChucVu.Checked == true)
            {
                PCB_Test.Visible = false;
                BTN_ThemAnh.Visible = false;
                loadataa();
            }
        }

        #endregion
        #region lấy thuộc tính sửa xóa
        public AnhViewModel suaxoaanh()
        {
            AnhViewModel anhViewModel = new AnhViewModel()
            {
                id = _IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
                Link = imageUrl


            };
            return anhViewModel;
        }
        public ChuVuViewModel suaxoaCV()
        {
            ChuVuViewModel chuVuViewModel = new ChuVuViewModel()
            {
                id=_IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return chuVuViewModel;
        }
        public MauSacViewModel SuaXoaMs()
        {
            MauSacViewModel mauSac = new MauSacViewModel()
            {
                id = _IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return mauSac;
        }
      
        
       
        public DongCoviewmodel SuaXoaDc()
        {
            DongCoviewmodel dongCo = new DongCoviewmodel()
            {
                id= _IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return dongCo;
        }
        public LoaiXeViewModel suaXoaLX()
        {
            LoaiXeViewModel loaiXe = new LoaiXeViewModel()
            {
                id = _IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return loaiXe;
        }
        public NSXViewModel suaXoaNsx()
        {
            NSXViewModel nSX = new NSXViewModel()
            {
                id = _IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return nSX;
        }
        public KhoiDongViewModel SuaXoakd()
        {
            KhoiDongViewModel khoidong = new KhoiDongViewModel()
            {
                id = _IdChung,
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,

            };
            return khoidong;
        }
        #endregion 
        #region methow lấy  thuộc tính 
        public AnhViewModel them()
        {
            AnhViewModel anhViewModel = new AnhViewModel()
            {
                // Id = new Guid(),
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
                Link = imageUrl


            };
            return anhViewModel;
        }
        public ChuVuViewModel ThemCv()
        {
            ChuVuViewModel chuVuViewModel = new ChuVuViewModel()
            {
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return chuVuViewModel;
        }
        public MauSacViewModel ThemMS()
        {
            MauSacViewModel mauSac = new MauSacViewModel()
            {
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return mauSac;
        }
        public DongCoviewmodel ThemDc()
        {
            DongCoviewmodel dongCo = new DongCoviewmodel()
            {
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
         return dongCo;
        }
        public LoaiXeViewModel ThemLx()
        {
            LoaiXeViewModel loaiXe = new LoaiXeViewModel()
            {
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return loaiXe;
        }
        public NSXViewModel ThemNSx() 
        {
            NSXViewModel nSX = new NSXViewModel()
            {
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
            };
            return nSX;
        }
        public KhoiDongViewModel ThemKD()
        {
            KhoiDongViewModel khoidong = new KhoiDongViewModel()
            {
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,

            }; 
            return khoidong;
        }
        #endregion
        #region Loadata
        public void loadataa()
        {
            //dtg ảnh
            if (RD_Anh.Checked == true)
            {
                dtg_Show.ColumnCount = 4;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";
               dtg_Show.Columns[3].Name = "link";
                dtg_Show.Columns[0].Visible = false;
                //dtg_show.Columns[3].Visible = false;
                foreach (var item in _IAnhservice.GetAll())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten,item.Link);
                }
            }
          //dtg chức vụ
             if(RD_ChucVu.Checked == true)
            {
                dtg_Show.ColumnCount = 3;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";

                dtg_Show.Columns[0].Visible = false;
                foreach (var item in _IChucVuService.getall())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten);
                }
            }
            // dtg màu Sắc
            if (RD_MauSac.Checked == true)
            {
                dtg_Show.ColumnCount = 3;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";

                dtg_Show.Columns[0].Visible = false;
                foreach (var item in _IMauSacService.GetAll())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten);
                }
            }
            // dtg động cơ
            if (RD_DongCo.Checked == true)
            {
                dtg_Show.ColumnCount = 3;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";

                dtg_Show.Columns[0].Visible = false;
                foreach (var item in _IDongcoService.Getall())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten);
                }
            }
            //dtg khơi  động
            if (RD_KhoiDong.Checked == true)
            {
                dtg_Show.ColumnCount = 3;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";

                dtg_Show.Columns[0].Visible = false;
                foreach (var item in _IkhoiDongService.GetAll())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten);
                }
            }
            // dtg Loại Xe
            if (RD_LoaiXe.Checked == true)
            {
                dtg_Show.ColumnCount = 3;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";

                dtg_Show.Columns[0].Visible = false;
                foreach (var item in _IloaiXeService.GetAll())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten);
                }
            }
            // dtg nhà sản xuất 
            if (RD_NSX.Checked == true)
            {
                dtg_Show.ColumnCount = 3;
                dtg_Show.Rows.Clear();
                dtg_Show.Columns[0].Name = "id";
                dtg_Show.Columns[1].Name = "ma";
                dtg_Show.Columns[2].Name = "ten";

                dtg_Show.Columns[0].Visible = false;
                foreach (var item in _INsxService.GetAll())
                {
                    dtg_Show.Rows.Add(item.id, item.Ma, item.Ten);
                }
            }
        }
        #endregion
        #region Thêm btn thêm ảnh
        private void BTN_ThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "";
            ofd.ShowDialog(); //sau khi chọn file thì of chưa 1 đường dẫn 

            DialogResult result = MessageBox.Show("bạn có muốn đổi avatar không", " đổi avata", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                MessageBox.Show("thay ảnh thành công");
                PCB_Test.Image = Image.FromFile(ofd.FileName);

            }
            else
            {
                MessageBox.Show("bạn không thay nữa à");
            }
            imageUrl = ofd.FileName; // gán đường dẫn sau khi đã chọn
        }
        #endregion
        #region  thêm sửa xóa  database
        private void BTN_Them_Click(object sender, EventArgs e)
        {
            if (RD_Anh.Checked== true)
            {
                MessageBox.Show(_IAnhservice.add(them()));
                loadataa();
            }
            else if (RD_ChucVu.Checked == true)
            {
                MessageBox.Show(_IChucVuService.add(ThemCv()));
                loadataa();
            }
            else if (RD_MauSac.Checked == true)
            {
                MessageBox.Show(_IMauSacService.add( ThemMS()));
                loadataa();
            }
            else if (RD_DongCo.Checked ==true)
            {
                MessageBox.Show(_IDongcoService.add(ThemDc()));
                loadataa();
            }
            else if (RD_KhoiDong.Checked == true)
            {
                MessageBox.Show(_IkhoiDongService.add(ThemKD()));
                loadataa();
            }
            else if (RD_NSX.Checked == true)
            {
                MessageBox.Show(_INsxService.add(ThemNSx()));
                loadataa();
            }
            else if (RD_LoaiXe.Checked == true)
            {
                MessageBox.Show(_IloaiXeService.add(ThemLx())) ;
                loadataa();
            }
            
        }
      
        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            if (RD_Anh.Checked == true)
            {
                MessageBox.Show(_IAnhservice.update(suaxoaanh()));
                loadataa();
            }
            else if (RD_ChucVu.Checked == true)
            {
                MessageBox.Show(_IChucVuService.update(suaxoaCV()));
                loadataa();
            }
            else if (RD_MauSac.Checked == true)
            {
                MessageBox.Show(_IMauSacService.update(SuaXoaMs()));
                loadataa();
            }
            else if (RD_DongCo.Checked == true)
            {
                MessageBox.Show(_IDongcoService.update(SuaXoaDc()));
                loadataa();
            }
            else if (RD_KhoiDong.Checked == true)
            {
                MessageBox.Show(_IkhoiDongService.update(SuaXoakd()));
                loadataa();
            }
            else if (RD_NSX.Checked == true)
            {
                MessageBox.Show(_INsxService.update(suaXoaNsx()));
                loadataa();
            }
            else if (RD_LoaiXe.Checked == true)
            {
                MessageBox.Show(_IloaiXeService.update(suaXoaLX()));
                loadataa();
            }
        }
        private void BTN_Xoa_Click(object sender, EventArgs e)
        {

            if (RD_Anh.Checked == true)
            {
                MessageBox.Show(_IAnhservice.delete(suaxoaanh()));
                loadataa();
            }
            else if (RD_ChucVu.Checked == true)
            {
                MessageBox.Show(_IChucVuService.delete(suaxoaCV()));
                loadataa();
            }
            else if (RD_MauSac.Checked == true)
            {
                MessageBox.Show(_IMauSacService.delete(SuaXoaMs()));
                loadataa();
            }
            else if (RD_DongCo.Checked == true)
            {
                MessageBox.Show(_IDongcoService.delete(SuaXoaDc()));
                loadataa();
            }
            else if (RD_KhoiDong.Checked == true)
            {
                MessageBox.Show(_IkhoiDongService.delete(SuaXoakd()));
                loadataa();
            }
            else if (RD_NSX.Checked == true)
            {
                MessageBox.Show(_INsxService.delete(suaXoaNsx()));
                loadataa();
            }
            else if (RD_LoaiXe.Checked == true)
            {
                MessageBox.Show(_IloaiXeService.delete(suaXoaLX()));
                loadataa();
            }
        }
        #endregion
        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RD_Anh.Checked ==true)
            {
             
                _IdChung = Guid.Parse(dtg_Show.CurrentRow.Cells[0].Value.ToString());
                TB_Ma.Text = dtg_Show.CurrentRow.Cells[1].Value.ToString();
                TB_Ten.Text = dtg_Show.CurrentRow.Cells[2].Value.ToString();
                PCB_Test.Image = Image.FromFile(_IAnhservice.GetAll().FirstOrDefault(c => c.id == _IdChung).Link);
            }
            else if(RD_ChucVu.Checked==true || RD_NSX.Checked ==true || RD_MauSac.Checked ==true||RD_LoaiXe.Checked == true||RD_KhoiDong.Checked == true || RD_DongCo.Checked == true) 
            {
                _IdChung = Guid.Parse(dtg_Show.CurrentRow.Cells[0].Value.ToString());
                TB_Ma.Text = dtg_Show.CurrentRow.Cells[1].Value.ToString();
                TB_Ten.Text = dtg_Show.CurrentRow.Cells[2].Value.ToString();
            }
            
            

        }

       
    }
}
