using PuzzleGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challengeProject
{
    public partial class PuzzleGameForm: Form
    {
        int[] puzTable;            // 퍼즐의 상태를 확인할 테이블
        Image[] btnImage;          // 순서대로 정렬해둘 이미지
        Button[] btn;              // 버튼을 동적으로 할당하기 위한 배열
        bool flagInit = false;

        int PUZZLE_COL = 0;
        int PUZZLE_COUNT = 0;
        int IMG_SIZE = 0;
        
        int hdnNum = 0;
        public PuzzleGameForm()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if (flagInit)
            {
                flagInit = false;
                for (int i = 0; i < PUZZLE_COUNT; i++)
                    btn[i].Visible = false;
            }

            Setting mySet = new Setting();
            if (mySet.ShowDialog() != DialogResult.OK)
                return;

            PUZZLE_COL = mySet.colNum;
            PUZZLE_COUNT = PUZZLE_COL;
            IMG_SIZE = mySet.imgSize;
            string filename = mySet.filename;

            // 윈도창 크기 조절
            this.Width = PUZZLE_COL * IMG_SIZE + 100;
            this.Height = IMG_SIZE + 100;  // 1차원 퍼즐, 세로 1칸

            // 원본 이미지 로드
            Image orgImage = new Bitmap(filename);

            // 버튼 배열 초기화
            btn = new Button[PUZZLE_COUNT];
            btnImage = new Image[PUZZLE_COUNT];
            puzTable = new int[PUZZLE_COUNT];

            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                // 원본 이미지에서 i번째 퍼즐 조각 부분만 크롭
                int partWidth = orgImage.Width / PUZZLE_COUNT;
                int partHeight = orgImage.Height;

                Bitmap piece = new Bitmap(partWidth, partHeight);
                using (Graphics g = Graphics.FromImage(piece))
                {
                    g.DrawImage(orgImage,
                        new Rectangle(0, 0, partWidth, partHeight),
                        new Rectangle(i * partWidth, 0, partWidth, partHeight),
                        GraphicsUnit.Pixel);
                }

                // 직사각형용 ImgByScale 호출: 각 조각을 IMG_SIZE 크기로 리사이즈
                btnImage[i] = ImgByScale(piece, 1, IMG_SIZE, IMG_SIZE);

                // 버튼 생성 및 세팅
                btn[i] = new Button();
                btn[i].Size = new Size(IMG_SIZE, IMG_SIZE);
                btn[i].Location = new Point(i * IMG_SIZE, 50);
                btn[i].Image = btnImage[i];
                btn[i].Text = (i + 1).ToString();
                btn[i].TextAlign = ContentAlignment.MiddleCenter;
                btn[i].Font = new Font("굴림", 20, FontStyle.Bold);
                btn[i].Visible = true;

                btn[i].Click += OnBtnClick;
                this.Controls.Add(btn[i]);
            }
            flagInit = true;

        }










        private Image ImgByScale(Image image, int puzzleCols, int imgWidth, int imgHeight)
        {
            int srcWidth = image.Width;
            int srcHeight = image.Height;

            if (srcWidth <= 0 || srcHeight <= 0)
                throw new ArgumentException("잘못된 이미지입니다. 너비 또는 높이가 0입니다.");

            // puzzleCols는 여기선 1로 고정, 부분 이미지 리사이즈 목적임

            Bitmap resized = new Bitmap(imgWidth, imgHeight);

            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, new Rectangle(0, 0, imgWidth, imgHeight));
            }

            return resized;
        }







        private void btnSuffle_Click(object sender, EventArgs e)
        {
            if (!flagInit)
            {
                MessageBox.Show("게임을 즐기시려면 게임 초기화를 \n먼저 실행해 주시기 바랍니다.");
                return;
            }

            // 실제 카드를 섞는 메서드 호출
            ShufflePuzzle();
        }


        public void ShufflePuzzle()
        {
            // 1. puzTable 초기화 (1부터 PUZZLE_COUNT까지 순서대로)
            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                puzTable[i] = i + 1;
            }

            // 2. Fisher-Yates 셔플
            Random rand = new Random();
            for (int i = PUZZLE_COUNT - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = puzTable[i];
                puzTable[i] = puzTable[j];
                puzTable[j] = temp;
            }

            // 3. 버튼 UI 갱신 (puzTable 순서대로 이미지와 텍스트 셋팅)
            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                int idx = puzTable[i] - 1; // 퍼즐 번호를 인덱스로 변환
                btn[i].Image = btnImage[idx];
                btn[i].Text = puzTable[i].ToString();
                btn[i].Visible = true;
            }

            // 4. 마지막 퍼즐 조각 숨기기 (빈 칸)
            hdnNum = Array.IndexOf(puzTable, PUZZLE_COUNT); // 빈 칸 위치 찾기
            btn[hdnNum].Visible = false;
        }






        private void OnBtnClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int curIdx = -1;

            // 실제 배열상 인덱스를 찾는다 (Text가 아니라 위치 기준!)
            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                if (btn[i] == clickedButton)
                {
                    curIdx = i;
                    break;
                }
            }

            if (curIdx == -1)
                return; // 못 찾았으면 그냥 무시

            // 빈칸과 교환 (이제는 항상 허용한다고 가정)
            ChangeButton(curIdx, clickedButton.Text);

            // 완료 여부 확인
            if (IsSuccess())
            {
                DialogResult retry = MessageBox.Show(
                    "다시 하시겠습니까?",
                    "축하합니다!",
                    MessageBoxButtons.YesNo
                );

                if (retry == DialogResult.Yes)
                    ShufflePuzzle();
            }
        }


        private void ChangeButton(int curBtnName, string curBtnText)
        {
            if (curBtnName < 0 || curBtnName >= PUZZLE_COUNT)
            {
                MessageBox.Show("잘못된 버튼 인덱스입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. puzTable swap
            int tempNum = puzTable[curBtnName];
            puzTable[curBtnName] = puzTable[hdnNum];
            puzTable[hdnNum] = tempNum;

            // 2. 이미지와 텍스트 swap
            Image tempImg = btn[curBtnName].Image;
            string tempText = btn[curBtnName].Text;

            btn[curBtnName].Image = btn[hdnNum].Image;
            btn[curBtnName].Text = btn[hdnNum].Text;
            btn[curBtnName].Visible = false;

            btn[hdnNum].Image = tempImg;
            btn[hdnNum].Text = tempText;
            btn[hdnNum].Visible = true;

            // 3. 새로 빈 칸이 된 곳 갱신
            hdnNum = curBtnName;
        }



        private bool IsSuccess()
        {
            bool success = true;

            // 2차원 테이블의 순서와 동적 버튼의 Text 순서가 맞는지 확인
            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                if ((i + 1) != Convert.ToInt32(btn[i].Text))
                {
                    success = false;
                    break;
                }
            }

            // 결과를 반환
            return success;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

