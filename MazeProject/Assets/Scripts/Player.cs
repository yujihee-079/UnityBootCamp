
using System.Collections.Generic;
using UnityEngine;

class Pos
{
    public Pos(int y, int x) { Y = y; X = x; }

    public int Y;
    public int X;
}

public class Player : MonoBehaviour
{
    public int PosY { get; set; }
    public int PosX { get; set; }

    private Board _board;
    private bool _isBoardCreated = false;

    enum Dir
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
    }

    int _dir = (int)Dir.Up; // 0

    List<Pos> _points = new List<Pos>();
    
    public void Initialze(int posY, int posX, Board board)
    {
        PosY = posY;
        PosX = posX;
        _board = board;

        transform.position = new Vector3(posX, 0, -posY);

        // ���� �ٶ󺸴� ���� ���� �չ��� Ÿ���� Ȯ�� �ϱ� ���� ��ǥ
        int[] _frontY = new int[] { -1, 0, 1, 0 };
        int[] _frontX = new int[] { 0, -1, 0, 1 };

        // ���� �ٶ󺸴� ���� ���� ������ Ÿ���� Ȯ�� �ϱ����� ��ǥ
        int[] _rightY = new int[] { 0, -1, 0, 1 };
        int[] _rightX = new int[] { 1, 0, -1, 0 };

        _points.Add(new Pos(PosY, PosX));

        // ������ ����� ���� ��ӽ���
        while (PosY != board.DestY || PosX != board.DestX)
        {
            // 1. ���� �ٶ󺸴� ������ �������� ���������� �� �� �ִ��� Ȯ��

            // ���� ���� �ٶ� ���� �ִ� �������, ������ �� Ÿ���� Ȯ���ؾ��ϴϱ�
            if (board.Tile[PosY + _rightY[_dir], PosX + _rightX[_dir]] != TileType.Wall)
            {
                #region 
                // ������ �������� 90�� ȸ��
                // ��ⷯ ����(modular arithmetic)�� �̿��� ���� �ε���(circular index) ����
                // ��ⷯ ���� = ������ ���� %�� ����ؼ� ���� ������ �����ϴ� ������ ���.
                // ���� �ε��� = ������ ������ ��� �ε����� ������ �ʵ��� ���� �����ϸ� �ٽ� ó������ ���ư��� ����
                #endregion

                _dir = (_dir - 1 + 4) % 4;
                #region
                //   [ ]
                //[ ] P [*] 
                //   [^]

                //switch (_dir)
                //{
                //    case (int)Dir.Up:
                //        _dir = (int)Dir.Right;
                //        break;
                //    case (int)Dir.Left:
                //        _dir = (int)Dir.Up;
                //        break;
                //    case (int)Dir.Down:
                //        _dir = (int)Dir.Left;
                //        break;
                //    case (int)Dir.Right:
                //        _dir = (int)Dir.Down;
                //        break;
                //}


                // X: 1, Y: 1
                // ���� �ٶ󺸴� �������� ������ �Ѻ� ����
                //   [ ]
                //[ ] P [*] 
                //   [ ]


                #endregion

                PosY = PosY + _frontY[_dir];
                PosX = PosX + _frontX[_dir];

                _points.Add(new Pos(PosY, PosX));
            }
            // 2. ���� �ٶ󺸴� ������ �������� ������ �� �ִ��� Ȯ��
            else if (board.Tile[PosY + _frontY[_dir], PosX + _frontX[_dir]] != TileType.Wall)
            {
                // ������ �Ѻ� ����
                PosY = PosY + _frontY[_dir];
                PosX = PosX + _frontX[_dir];

                _points.Add(new Pos(PosY, PosX));
            }
            // 3. �� ������, �� �� ��� ���� �ִٸ�
            else
            {
                // ���� �������� 90�� ȸ�� �� �� �ѱ��
                _dir = (_dir + 1 + 4) % 4;
            }
        }

        _isBoardCreated = true;
    }

    // ����� - (�̷θ� Ż���ϱ� ����) ������ ��Ģ



    private const float MOVE_TICK = 0.1f;
    private float _sumTick = 0;
    private int _lastIndex = 0;

    private void Update()
    {
        if (_lastIndex >= _points.Count)
            return;

        if (_isBoardCreated == false)
            return;

        _sumTick += Time.deltaTime;
        if (_sumTick < MOVE_TICK)
            return;

        _sumTick = 0;

        //int dir = Random.Range(0, 4);

        //int NextY = PosY;
        //int NextX = PosX;

        //switch (dir)
        //{
        //    case 0:
        //        NextY = PosY - 1;
        //        break;
        //    case 1:
        //        NextY = PosY + 1;
        //        break;
        //    case 2:
        //        NextX = PosX - 1;
        //        break;
        //    case 3:
        //        NextX = PosX + 1;
        //        break;
        //}

        //if (NextY < 0 || NextY >= _board.Size) return;
        //if (NextX < 0 || NextX >= _board.Size) return;
        //if (_board.Tile[NextY, NextX] == TileType.Wall) return; 

        //PosY = NextY;
        //PosX = NextX;
        PosY = _points[_lastIndex].Y;
        PosX = _points[_lastIndex].X;
        _lastIndex++;

        transform.position = new Vector3(PosX, 0, -PosY);
    }

}
