using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> _CarsReport = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dgvArticle.DataSource = _CarsReport;
        }

        //内容をリストに追加
        private void btAdd_Click(object sender, EventArgs e)
        {
            //オブジェクトの追加
            CarReport obj = new CarReport
            {
                CreatedDate = dtpCreatedDate.Value,
                Author = cbAuthor.Text,
                Maker = MakerSelect(),        
                Name = cbName.Text,
                Report = tbReport.Text,
                Picturt = pbImage.Image
            };

            //コンボボックスの入力候補に登録
            setComboBoxAuthorName(cbAuthor.Text,cbName.Text);

            _CarsReport.Insert(0,obj);  //リストの先頭

            //次の入力に備えて各項目をクリア
            inputItemAllClear();
        }

        //オブジェクトをクリア
        private void inputItemAllClear()
        {
            cbAuthor.Text = default;
            MakerSelect().Equals(default);
            cbName.Text = default;
            tbReport.Text = default;
            pbImage.Image = null;
        }

        //コンボボックスの入力候補登録(記録者と車名)
        private void setComboBoxAuthorName(string Author, string Name)
        {
            if (!cbAuthor.Items.Contains(Author)|| !cbName.Items.Contains(Name))
            {
                //コンボボックスの候補に追加
                cbAuthor.Items.Add(Author);
                cbName.Items.Add(Name);
            }
        }

        //画像を開く
        private void btOpenImage_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像を表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //画像のサイズ調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        //ボタン
        private CarMaker MakerSelect()
        {
            if (rbT.Checked == true)
            {
                return CarMaker.トヨタ;
            }
            else if (rbN.Checked == true)
            {
                return CarMaker.日産;
            }
            else if (rbH.Checked == true)
            {
                return CarMaker.ホンダ;
            }
            else if (rbS.Checked == true)
            {
                return CarMaker.スバル;
            }
            else if (rbG.Checked == true)
            {
                return CarMaker.外車;
            }
            else if (rbNull.Checked == true)
            {
                return CarMaker.その他;
            }
            else 
            {
                return CarMaker.DEFAULT;
            }       
            
        }

        //修正
        private void btRetouching_Click(object sender, EventArgs e)
        {
            CarReport selectCar = _CarsReport[dgvArticle.CurrentRow.Index];

            selectCar.CreatedDate = dtpCreatedDate.Value;
            selectCar.Author = cbAuthor.Text;
            selectCar.Maker = MakerSelect();
            selectCar.Name = cbName.Text;
            selectCar.Report = tbReport.Text;
            selectCar.Picturt = pbImage.Image;

            dgvArticle.Refresh();       //データグリッドビューの再描画
        }

        //削除
        private void btDeleteReport_Click(object sender, EventArgs e)
        {
            _CarsReport.RemoveAt(dgvArticle.CurrentRow.Index);
            //initButtons();
            inputItemAllClear();
            dgvArticle.ClearSelection();
        }

        //修正する行を表示
        private void dgvArticle_Click(object sender, EventArgs e)
        {
            CarReport selectCar = _CarsReport[dgvArticle.CurrentRow.Index];

            dtpCreatedDate.Value = selectCar.CreatedDate;
            cbAuthor.Text = selectCar.Author;
            MakerSelect().Equals(selectCar.Maker);
            cbName.Text = selectCar.Name;
            tbReport.Text = selectCar.Report;
            pbImage.Image = selectCar.Picturt;
        }

        //画像削除
        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        //終了
        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
