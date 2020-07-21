using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            //dgvArticle.DataSource = _CarsReport;

        }

        //内容をリストに接続
        private void btAdd_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202015DataSet.CarReport);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvArticle.Columns[0].Visible = false;  //Idを非表示にする
            initButtons();

        }

        //オブジェクトをクリア
        private void inputItemAllClear()
        {
            cbAuthor.Text = default;
            cbName.Text = default;
            tbReport.Text = default;
            pbImage.Image = null;
        }

        private void GbMakerClear()
        {
            rbT.Checked = false;
            rbN.Checked = false;
            rbH.Checked = false;
            rbS.Checked = false;
            rbG.Checked = false;
            rbNull.Checked = false;
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
            dgvArticle.CurrentRow.Cells[1].Value = dtpCreatedDate.Value;
            dgvArticle.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvArticle.CurrentRow.Cells[3].Value = GetSelectRadioButton();
            dgvArticle.CurrentRow.Cells[4].Value = cbName.Text;
            dgvArticle.CurrentRow.Cells[5].Value = tbReport.Text;

            if (pbImage.Image == null)
            {
                dgvArticle.CurrentRow.Cells[6].Value = null;
            }
            else
            {
                dgvArticle.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            }


            //データベース反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202015DataSet);

            dgvArticle.Refresh();       //データグリッドビューの再描画
        }

        //削除
        private void btDeleteReport_Click(object sender, EventArgs e)
        {
            _CarsReport.RemoveAt(dgvArticle.CurrentRow.Index);
            initButtons();
            inputItemAllClear();
            dgvArticle.ClearSelection();
        }

        //修正する行を表示
        private void dgvArticle_Click(object sender, EventArgs e)
        {
            var test = dgvArticle.CurrentRow.Cells[2].Value;
            //CarReport selectCar = _CarsReport[dgvArticle.CurrentRow.Index];
            
            //dtpCreatedDate.Value = selectCar.CreatedDate;
            //cbAuthor.Text = selectCar.Author;
            //MakerSelectCheck();
            //cbName.Text = selectCar.Name;
            //tbReport.Text = selectCar.Report;
            //pbImage.Image = selectCar.Picturt;
            
        }

        //画像削除
        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
                return;
            if (MessageBox.Show("削除してよいですか。", "確認", MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question)==DialogResult.OK)
            {
                pbImage.Image = null;

            }
            
        }

        //修正と削除ボタンの表示・非表示
        private void initButtons()
        {
            if (_CarsReport.Count > 0)
            {
                //btDeleteReport.Enabled = true;
            }
            else
            {
                //btDeleteReport.Enabled = false;
            }
        }


        //ボタン比較
        private void MakerSelectCheck()
        {
            CarReport selectCar = _CarsReport[dgvArticle.CurrentRow.Index];

            if (selectCar.Maker == CarMaker.トヨタ)
            {
                rbT.Checked = true;
            }
            else if (selectCar.Maker == CarMaker.日産)
            {
                rbN.Checked = true;
            }
            else if (selectCar.Maker == CarMaker.ホンダ)
            {
                rbH.Checked = true;
            }
            else if (selectCar.Maker == CarMaker.スバル)
            {
                rbS.Checked = true;
            }
            else if (selectCar.Maker == CarMaker.外車)
            {
                rbG.Checked = true;
            }
            else if (selectCar.Maker == CarMaker.その他)
            {
                rbNull.Checked = true;
            }
        }

        //終了
        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _CarsReport);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //リストを開く
        private void btOpenArticle_Click(object sender, EventArgs e)
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _CarsReport = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvArticle.DataSource = _CarsReport;
                        //選択されている箇所を各コントロールへ表示
                        dgvArticle_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }


        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputItemAllClear();
            GbMakerClear();

        }

        private void 開くOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _CarsReport = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvArticle.DataSource = _CarsReport;
                        //選択されている箇所を各コントロールへ表示
                        dgvArticle_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }

        }

        private void 名前を付けて保存AToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _CarsReport);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }

        }

        private void 終了XToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //データベース更新　(反映)
        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202015DataSet);

        }

        //接続
        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202015DataSet.CarReport);

        }

        //ボタンを表示
        private void dgvCarReports_Click(object sender, EventArgs e)
        {

            try
            {   
                //選択したレコード（行）の、インデックスで指定した項目を取り出す
                var maker = dgvArticle.CurrentRow.Cells[3].Value;

                //選択したレコードを表示する
                dtpCreatedDate.Value = (DateTime)dgvArticle.CurrentRow.Cells[1].Value;
                cbAuthor.Text = (string)dgvArticle.CurrentRow.Cells[2].Value;
                cbName.Text = dgvArticle.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvArticle.CurrentRow.Cells[5].Value.ToString();

                //ラジオボタンの設定
                SetMakerRadioButtonSet((string)maker);
                pbImage.Image = ByteArrayToImage((byte[])dgvArticle.CurrentRow.Cells[6].Value);
            }
            catch (InvalidCastException)    //画像がDBに登録されていないとき
            {
                pbImage.Image = null;
            }
            catch (Exception ex)    //上記以外のデータ全て拾う
            {
                MessageBox.Show(ex.Message);
            }


        
        }

        // バイト配列をImageオブジェクトに変換(画面表示)
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換(データベースに保存)
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        //ラジオボタンの設定
        private void SetMakerRadioButtonSet(string carMaker)
        {

            switch (carMaker)
            {
                case "トヨタ":
                    rbT.Checked = true;
                    break;
                case "日産":
                    rbN.Checked = true;
                    break;
                case "ホンダ":
                    rbH.Checked = true;
                    break;
                case "スバル":
                    rbS.Checked = true;
                    break;
                case "外車":
                    rbG.Checked = true;
                    break;
                default:
                    rbNull.Checked = true;
                    break;
            }
        }

        //更新
        private void 更新RToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dgvArticle.CurrentRow.Cells[1].Value = dtpCreatedDate.Value;
            dgvArticle.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvArticle.CurrentRow.Cells[3].Value = GetSelectRadioButton();
            dgvArticle.CurrentRow.Cells[4].Value = cbName.Text;
            dgvArticle.CurrentRow.Cells[5].Value = tbReport.Text;

            if (pbImage.Image == null)
            {
                dgvArticle.CurrentRow.Cells[6].Value = null;
            }
            else
            {
                dgvArticle.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            }

            //データベース反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202015DataSet);
        }

        //修正のラジオボタン
        private string GetSelectRadioButton()
        {
            if (rbT.Checked)
            {
                return rbT.Text;
            }
            else if (rbN.Checked)
            {
                return rbN.Text;
            }
            else if (rbH.Checked)
            {
                return rbH.Text;
            }
            else if (rbS.Checked)
            {
                return rbS.Text;
            }
            else if (rbG.Checked)
            {
                return rbG.Text;
            }
            else 
            {
                return rbNull.Text;
            }
        }

    }
}
