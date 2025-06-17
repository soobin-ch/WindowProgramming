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

namespace PuzzleGame_revised
{
    public partial class PuzzleGameForm: Form
    {
        int[,] puzTable;            // 퍼즐의 상태를 확인할 테이블
        Image[] btnImage;          // 순서대로 정렬해둘 이미지
        Button[] btn;              // 버튼을 동적으로 할당하기 위한 배열
        bool flagInit = false;

        int PUZZLE_COL = 0;
        int PUZZLE_COUNT = 0;
        int IMG_SIZE = 0;
        int hdnRow = 0;
        int hdnCol = 0;
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

            // 게임 설정 대화상자를 열어 정보를 가져옴
            Setting mySet = new Setting();

            // 설정윈도우에서 확인 버튼을 누르지 않은 경우, 리턴
            if (mySet.ShowDialog() != DialogResult.OK)
                return;


            // 이하에 오늘 코드 추가 예정
            // 대화상자 확인 버튼을 누른 경우 게임 설정정보 전달
            PUZZLE_COL = mySet.colNum;
            PUZZLE_COUNT = PUZZLE_COL * PUZZLE_COL;
            IMG_SIZE = mySet.imgSize;
            string filename = mySet.filename;

            // 윈도창의 크기 변경
            this.Width = PUZZLE_COL * IMG_SIZE + 16;
            this.Height = PUZZLE_COL * IMG_SIZE + 85;

            // 버튼의 생성 및 그래픽 이미지 처리
            double scale;   // 축소확대 비율

            // 이미지 생성
            Image orgImage = new Bitmap(filename);

            // 이미지 크기 조절
            if (orgImage.Width > orgImage.Height)
                scale = (double)PUZZLE_COL * IMG_SIZE / orgImage.Height;
            else
                scale = (double)PUZZLE_COL * IMG_SIZE / orgImage.Width;

            // 크기조절
            Image curImage = ImgByScale(orgImage, scale, mySet.criteriaHorizontal, mySet.criteriaVertical);

            // 배열 생성
            btn = new Button[PUZZLE_COUNT];
            btnImage = new Image[PUZZLE_COUNT];
            puzTable = new int[PUZZLE_COL, PUZZLE_COL];

            // m개의 동적 버튼 생성
            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                // 버튼의 생성 좌표 설정
                int x = (i % PUZZLE_COL) * IMG_SIZE;
                int y = (i / PUZZLE_COL) * IMG_SIZE;

                // 버튼의 속성 설정
                btn[i] = new Button();
                btn[i].Location = new Point(x, y + 45);                   // 좌표 설정
                btn[i].Size = new Size(IMG_SIZE, IMG_SIZE);               // 크기
                btn[i].Name = i.ToString();                               // 버튼 id, 할당 후 고정됨
                btn[i].Text = (i + 1).ToString();                         // 버튼 번호, 클릭할 때마다 변경
                btn[i].Visible = true;                                    // 화면에 보이느냐 여부
                btn[i].Font = new Font("굴림", 25f, FontStyle.Bold, GraphicsUnit.Point);




                // 버튼에 넣을 이미지 크기의 빈 그래픽 공간 생성
                Bitmap tempImage = new Bitmap(IMG_SIZE, IMG_SIZE);
                Graphics g = Graphics.FromImage(tempImage);

                g.DrawImage(curImage,
                    new Rectangle(0, 0, IMG_SIZE, IMG_SIZE),          // 잘라낸 이미지 영역
                    new Rectangle(x, y, IMG_SIZE, IMG_SIZE),          // 원본 이미지 영역
                    GraphicsUnit.Pixel);

                // 잘라온 이미지를 버튼에 추가
                this.btnImage[i] = btn[i].Image = tempImage;

                // 폼에 버튼을 추가
                this.Controls.Add(btn[i]);

                this.btn[i].Click += new System.EventHandler(this.OnBtnClick);

                // 초기화 실행 완료
                flagInit = true;
            }



        }

        private Image ImgByScale(Image image, double scale, int horizontal, int vertical)
        {
            // 원본, 출력 이미지 크기
            int orgSize, destSize;

            // 원본 이미지 크기
            int oWidth = image.Width;
            int oHeight = image.Height;

            // 사진의 시작 위치
            int x = 0, y = 0;

            if (oHeight > oWidth)
            {
                // 이미지 크기
                orgSize = oWidth;
                destSize = (int)(oWidth * scale);

                // 자르기 위치에 따른 지정
                x = 0;
                switch (vertical)
                {
                    case 0: // 위쪽 기준 자르기
                        y = 0;
                        break;
                    case 1: // 중간 기준 자르기
                        y = (oHeight - oWidth) / 2;
                        break;
                    case 2: // 아래쪽 기준 자르기
                        y = oHeight - oWidth;
                        break;
                }
            }
            else
            {
                // 이미지 크기
                orgSize = oHeight;
                destSize = (int)(oHeight * scale);

                // 자르기 위치에 따른 지정
                y = 0;
                switch (horizontal)
                {
                    case 0: // 왼쪽 기준 자르기
                        x = 0;
                        break;
                    case 1: // 중간 기준 자르기
                        x = (oWidth - oHeight) / 2;
                        break;
                    case 2: // 오른쪽 기준 자르기
                        x = oWidth - oHeight;
                        break;
                }
            }

            // 잘라낸 후 크기에 맞게 새 이미지 생성 및 리턴
            Bitmap destImage = new Bitmap(destSize, destSize);
            Graphics g = Graphics.FromImage(destImage);
            g.DrawImage(image,
                new Rectangle(0, 0, destSize, destSize),
                new Rectangle(x, y, orgSize, orgSize),
                GraphicsUnit.Pixel);
            g.Dispose();

            return destImage;
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
            for (int i = 0; i < PUZZLE_COUNT; i++)
            {
                btn[i].Image = btnImage[i];
                btn[i].Text = (i + 1).ToString();
                btn[i].Visible = true;

                int iRow = i / PUZZLE_COL;
                int iCol = i % PUZZLE_COL;
                puzTable[iRow, iCol] = i + 1;
            }

            // 마지막 퍼즐 조각은 숨김 처리
            int lastIdx = PUZZLE_COUNT - 1;
            hdnRow = lastIdx / PUZZLE_COL;
            hdnCol = lastIdx % PUZZLE_COL;
            hdnNum = lastIdx;
            btn[hdnNum].Visible = false;

            // 퍼즐을 섞을 때 가능한 방향 정의 (상, 하, 좌, 우)
            int[] dRow = { -1, 1, 0, 0 };
            int[] dCol = { 0, 0, -1, 1 };

            Random r = new Random();
            int shuffleCount = 1000;  // 이동 횟수

            for (int s = 0; s < shuffleCount; s++)
            {
                List<(int newRow, int newCol)> possibleMoves = new List<(int, int)>();

                // 가능한 이동 위치 찾기
                for (int dir = 0; dir < 4; dir++)
                {
                    int nRow = hdnRow + dRow[dir];
                    int nCol = hdnCol + dCol[dir];

                    if (nRow >= 0 && nRow < PUZZLE_COL && nCol >= 0 && nCol < PUZZLE_COL)
                    {
                        possibleMoves.Add((nRow, nCol));
                    }
                }

                // 무작위 이동 위치 선택
                var move = possibleMoves[r.Next(possibleMoves.Count)];
                int moveIdx = move.newRow * PUZZLE_COL + move.newCol;

                // hidden 버튼과 이동 버튼 교환
                puzTable[hdnRow, hdnCol] = Convert.ToInt32(btn[moveIdx].Text);
                puzTable[move.newRow, move.newCol] = PUZZLE_COUNT;

                btn[hdnNum].Image = btn[moveIdx].Image;
                btn[hdnNum].Text = btn[moveIdx].Text;
                btn[hdnNum].Visible = true;

                btn[moveIdx].Image = btnImage[PUZZLE_COUNT - 1];
                btn[moveIdx].Text = PUZZLE_COUNT.ToString();
                btn[moveIdx].Visible = false;

                hdnRow = move.newRow;
                hdnCol = move.newCol;
                hdnNum = moveIdx;
            }
        }

        private void OnBtnClick(object sender, EventArgs e)
        {
            // 클릭한 버튼 객체 지정
            Button clickedButton = (Button)sender;
            int curBtnName = Convert.ToInt32(clickedButton.Name);
            string curBtnText = clickedButton.Text;

            // 버튼의 행과 열 계산
            int i = curBtnName / PUZZLE_COL;
            int j = curBtnName % PUZZLE_COL;

            // (i, j)번째 버튼이 움직일 수 있는지 확인
            // 움직일 수 없으면 return
            if (!ChkMove(i, j))
                return;

            // 클릭된 버튼과 hidden button의 text와 image 교체
            ChangeButton(i, j, curBtnName, curBtnText);

            // 퍼즐을 다 맞추었는지 확인 후 재실행 여부 묻기
            if (IsSuccess())
            {
                DialogResult retry = MessageBox.Show(
                    "다시 한 번 하시겠습니까?",
                    "Congraturations!!!",
                    MessageBoxButtons.YesNo
                );

                if (retry == DialogResult.Yes)
                    ShufflePuzzle();
            }
        }

        private bool ChkMove(int row, int col)
        {
            // 움직일 수 있는지 여부를 표시하는 bool 변수
            bool moving = false;

            // 이 조건이 만족되면 같은 행에서 열이 인접 → 열 방향으로 움직일 수 있음
            if ((row == hdnRow) && (Math.Abs(col - hdnCol) == 1))
                moving = true;

            // 이 조건이 만족되면 같은 열에서 행이 인접 → 행 방향으로 움직일 수 있음
            if ((col == hdnCol) && (Math.Abs(row - hdnRow) == 1))
                moving = true;

            // 이동 가능 여부 반환
            return moving;
        }

        private void ChangeButton(int row, int col, int curBtnName, string curBtnText)
        {

            // 배열 인덱스가 유효한지 확인
            if (curBtnName < 0 || curBtnName >= PUZZLE_COUNT)
            {
                MessageBox.Show("잘못된 버튼 인덱스입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 버튼이 실제로 이동하는 것이 아니라 버튼에 할당된 값을 바꾸면 이동한 것처럼 보인다

            // 선택된 버튼 값을 Hidden으로 변경
            puzTable[hdnRow, hdnCol] = Convert.ToInt32(curBtnText);

            // Hidden Button을 현재 버튼으로 변경
            puzTable[row, col] = PUZZLE_COUNT;

            // Hidden Button에 현재 버튼의 속성을 전달
            btn[hdnNum].Image = btn[curBtnName].Image;
            btn[hdnNum].Text = curBtnText;
            btn[hdnNum].Visible = true;

            // 클릭한 버튼은 Hidden 값(PUZZLE_COUNT)을 부여하고 숨기기
            btn[curBtnName].Image = btnImage[PUZZLE_COUNT - 1];
            btn[curBtnName].Text = PUZZLE_COUNT.ToString();
            btn[curBtnName].Visible = false;

            // 현재 버튼을 Hidden 버튼으로 설정
            this.hdnRow = row;
            this.hdnCol = col;
            this.hdnNum = curBtnName;
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

