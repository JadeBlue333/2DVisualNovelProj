using System.Collections.Generic;
using System;

//이 스크립트에서는 진행도에 따라 선택지 세이브포인트를 스토리보드에 활성화해줄지 아닐지의 모든 변수와 이를 위한 함수를 관리한다.
public static class StoryProgress
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    //1주차 냇가 선택지 이동 버튼
    public static bool w1_s_op1 = false;
    public static bool w1_s_op2 = false;
    public static bool w1_s_op3 = false;
    public static bool w1_s_op4 = false;

    //1주차 냇가 가지 활성화
    public static bool w1_s_op1_1 = false;
    public static bool w1_s_op2_1 = false;
    public static bool w1_s_op2_2 = false;
    public static bool w1_s_op3_1 = false;
    public static bool w1_s_op3_2 = false;
    public static bool w1_s_op4_1 = false;
    public static bool w1_s_op4_2 = false;

    //1주차 냇가 엔딩 활성화
    public static bool w1_s_finish1 = false;
    public static bool w1_s_finish2 = false;
    public static bool w1_s_finish3 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //1주차 약방 선택지 이동 버튼
    public static bool w1_h_op1 = false;
    public static bool w1_h_op2 = false;
    public static bool w1_h_op3 = false;
    public static bool w1_h_op4 = false;

    //1주차 약방 가지 활성화
    public static bool w1_h_op1_1 = false;
    public static bool w1_h_op1_2 = false;
    public static bool w1_h_op1_3 = false;
    public static bool w1_h_op2_1 = false;
    public static bool w1_h_op3_1 = false;
    public static bool w1_h_op4_1 = false;
    public static bool w1_h_op4_2 = false;

    //1주차 약방 엔딩
    public static bool w1_h_finish1 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    //1주차 주막 선택지 이동 버튼
    public static bool w1_p_op1 = false;
    public static bool w1_p_op2 = false;

    //1주차 주막 냇가 가지 활성화
    public static bool w1_p_op1_1 = false;
    public static bool w1_p_op1_2 = false;
    public static bool w1_p_op2_1 = false;
    public static bool w1_p_op2_2 = false;

    //1주차 주막 엔딩
    public static bool w1_p_finish1 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //1주차 저잣거리1 선택지 이동 버튼
    public static bool w1_j1_op1 = false;
    public static bool w1_j1_op2 = false;
    public static bool w1_j1_op3 = false;
    public static bool w1_j1_op4 = false;

    public static bool w1_j1_op1_1 = false;
    public static bool w1_j1_op2_1 = false;
    public static bool w1_j1_op3_1 = false;
    public static bool w1_j1_op4_1 = false;
    public static bool w1_j1_op4_2 = false;

    //1주차 저잣거리1 엔딩
    public static bool w1_j1_finish1 = false;
    public static bool w1_j1_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //1주차 저잣거리2 선택지 이동 버튼
    public static bool w1_j2_op1 = false;
    public static bool w1_j2_op2 = false;
    public static bool w1_j2_op3 = false;

    public static bool w1_j2_op1_1 = false;
    public static bool w1_j2_op2_1 = false;
    public static bool w1_j2_op2_2 = false;
    public static bool w1_j2_op3_1 = false;
    public static bool w1_j2_op3_2 = false;

    //1주차 저잣거리2 엔딩
    public static bool w1_j2_finish1 = false;
    public static bool w1_j2_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //2주차 저잣거리2 선택지 이동 버튼
    public static bool w2_j2_op1 = false;
    public static bool w2_j2_op2 = false;
    public static bool w2_j2_op3 = false;

    public static bool w2_j2_op1_1 = false;
    public static bool w2_j2_op1_2 = false;
    public static bool w2_j2_op1_3 = false;
    public static bool w2_j2_op2_1 = false;
    public static bool w2_j2_op2_2 = false;
    public static bool w2_j2_op2_3 = false;
    public static bool w2_j2_op3_1 = false;
    public static bool w2_j2_op3_2 = false;
    public static bool w2_j2_op3_3 = false;

    //1주차 저잣거리2 엔딩
    public static bool w2_j2_finish1 = false;
    public static bool w2_j2_finish2 = false;
    public static bool w2_j2_finish3 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //2주차 주막 선택지 이동 버튼
    public static bool w2_p_op1 = false;
    public static bool w2_p_op2 = false;
    public static bool w2_p_op3 = false;
    public static bool w2_p_op4 = false;
    public static bool w2_p_op5 = false;
    public static bool w2_p_op6 = false;
    public static bool w2_p_op7 = false;

    public static bool w2_p_op1_1 = false;
    public static bool w2_p_op1_2 = false;
    public static bool w2_p_op2_1 = false;
    public static bool w2_p_op2_2 = false;
    public static bool w2_p_op2_3 = false;
    public static bool w2_p_op3_1 = false;
    public static bool w2_p_op3_2 = false;
    public static bool w2_p_op4_1 = false;
    public static bool w2_p_op4_2 = false;
    public static bool w2_p_op5_1 = false;
    public static bool w2_p_op5_2 = false;
    public static bool w2_p_op6_1 = false;
    public static bool w2_p_op6_2 = false;
    public static bool w2_p_op7_1 = false;
    public static bool w2_p_op7_2 = false;
    public static bool w2_p_op7_3 = false;

    //2주차 주막 엔딩
    public static bool w2_p_finish = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //2주차 약방 선택지 이동 버튼
    public static bool w2_h_op1 = false;
    public static bool w2_h_op2 = false;
    public static bool w2_h_op3 = false;
    public static bool w2_h_op4 = false;
    public static bool w2_h_op5 = false;

    public static bool w2_h_op1_1 = false;
    public static bool w2_h_op1_2 = false;
    public static bool w2_h_op2_1 = false;
    public static bool w2_h_op2_2 = false;
    public static bool w2_h_op2_3 = false;
    public static bool w2_h_op3_1 = false;
    public static bool w2_h_op3_2 = false;
    public static bool w2_h_op4_1 = false;
    public static bool w2_h_op4_2 = false;
    public static bool w2_h_op5_1 = false;
    public static bool w2_h_op5_2 = false;
    public static bool w2_h_op5_3 = false;

    //2주차 약방 엔딩
    public static bool w2_h_finish1 = false;
    public static bool w2_h_finish2 = false;
    public static bool w2_h_finish3 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //2주차 냇가 선택지 이동 버튼
    public static bool w2_s_op1 = false;
    public static bool w2_s_op2 = false;
    public static bool w2_s_op3 = false;
    public static bool w2_s_op4 = false;
    public static bool w2_s_op5 = false;

    public static bool w2_s_op1_1 = false;
    public static bool w2_s_op1_2 = false;
    public static bool w2_s_op2_1 = false;
    public static bool w2_s_op2_2 = false;
    public static bool w2_s_op2_3 = false;
    public static bool w2_s_op3_1 = false;
    public static bool w2_s_op3_2 = false;
    public static bool w2_s_op4_1 = false;
    public static bool w2_s_op4_2 = false;
    public static bool w2_s_op4_3 = false;
    public static bool w2_s_op5_1 = false;
    public static bool w2_s_op5_2 = false;

    //2주차 냇가 엔딩
    public static bool w2_s_finish = false;
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //2주차 저잣거리1 선택지 이동 버튼
    public static bool w2_j1_op1 = false;
    public static bool w2_j1_op2 = false;
    public static bool w2_j1_op3 = false;

    public static bool w2_j1_op1_1 = false;
    public static bool w2_j1_op1_2 = false;
    public static bool w2_j1_op1_3 = false;
    public static bool w2_j1_op2_1 = false;
    public static bool w2_j1_op3_1 = false;
    public static bool w2_j1_op3_2 = false;

    //2주차 저잣거리1 엔딩
    public static bool w2_j1_finish1 = false;
    public static bool w2_j1_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //2주차 밭 선택지 이동 버튼
    public static bool w2_f_op1 = false;
    public static bool w2_f_op2 = false;
    public static bool w2_f_op3 = false;

    public static bool w2_f_op1_1 = false;
    public static bool w2_f_op1_2 = false;
    public static bool w2_f_op2_1 = false;
    public static bool w2_f_op2_2 = false;
    public static bool w2_f_op2_3 = false;
    public static bool w2_f_op3_1 = false;
    public static bool w2_f_op3_2 = false;

    //2주차 밭 엔딩
    public static bool w2_f_finish = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //3주차 주막 선택지 이동 버튼
    public static bool w3_p_op1 = false;
    public static bool w3_p_op2 = false;
    public static bool w3_p_op3 = false;
    public static bool w3_p_op4 = false;
    public static bool w3_p_op5 = false;
    public static bool w3_p_op6 = false;

    public static bool w3_p_op1_1 = false;
    public static bool w3_p_op1_2 = false;
    public static bool w3_p_op1_3 = false;
    public static bool w3_p_op2_1 = false;
    public static bool w3_p_op2_2 = false;
    public static bool w3_p_op3_1 = false;
    public static bool w3_p_op3_2 = false;
    public static bool w3_p_op4_1 = false;
    public static bool w3_p_op4_2 = false;
    public static bool w3_p_op5_1 = false;
    public static bool w3_p_op5_2 = false;
    public static bool w3_p_op6_1 = false;
    public static bool w3_p_op6_2 = false;

    //3주차 주막 엔딩
    public static bool w3_p_finish1 = false;
    public static bool w3_p_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //3주차 저잣거리1 선택지 이동 버튼
    public static bool w3_j1_op1 = false;
    public static bool w3_j1_op2 = false;
    public static bool w3_j1_op3 = false;

    public static bool w3_j1_op1_1 = false;
    public static bool w3_j1_op1_2 = false;
    public static bool w3_j1_op1_3 = false;
    public static bool w3_j1_op2_1 = false;
    public static bool w3_j1_op2_2 = false;
    public static bool w3_j1_op3_1 = false;
    public static bool w3_j1_op3_2 = false;
    public static bool w3_j1_op3_3 = false;

    //3주차 저잣거리1 엔딩
    public static bool w3_j1_finish1 = false;
    public static bool w3_j1_finish2 = false;
    public static bool w3_j1_finish3 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //3주차 약방 선택지 이동 버튼
    public static bool w3_h_op1 = false;
    public static bool w3_h_op2 = false;

    public static bool w3_h_op1_1 = false;
    public static bool w3_h_op1_2 = false;
    public static bool w3_h_op2_1 = false;
    public static bool w3_h_op2_2 = false;
    public static bool w3_h_op2_3 = false;

    //3주차 약방 엔딩
    public static bool w3_h_finish = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //3주차 밭 선택지 이동 버튼
    public static bool w3_f_op1 = false;
    public static bool w3_f_op2 = false;
    public static bool w3_f_op3 = false;
    public static bool w3_f_op4 = false;

    public static bool w3_f_op1_1 = false;
    public static bool w3_f_op1_2 = false;
    public static bool w3_f_op1_3 = false;
    public static bool w3_f_op2_1 = false;
    public static bool w3_f_op2_2 = false;
    public static bool w3_f_op2_3 = false;
    public static bool w3_f_op3_1 = false;
    public static bool w3_f_op3_2 = false;
    public static bool w3_f_op4_1 = false;
    public static bool w3_f_op4_2 = false;

    //3주차 밭 엔딩
    public static bool w3_f_finish1 = false;
    public static bool w3_f_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //3주차 저잣거리2 선택지 이동 버튼
    public static bool w3_j2_op1 = false;
    public static bool w3_j2_op2 = false;
    public static bool w3_j2_op3 = false;

    public static bool w3_j2_op1_1 = false;
    public static bool w3_j2_op1_2 = false;
    public static bool w3_j2_op1_3 = false;
    public static bool w3_j2_op2_1 = false;
    public static bool w3_j2_op2_2 = false;
    public static bool w3_j2_op3_1 = false;
    public static bool w3_j2_op3_2 = false;

    //3주차 저잣거리2 엔딩
    public static bool w3_j2_finish = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //3주차 냇가 선택지 이동 버튼
    public static bool w3_s_op1 = false;
    public static bool w3_s_op2 = false;
    public static bool w3_s_op3 = false;

    public static bool w3_s_op1_1 = false;
    public static bool w3_s_op1_2 = false;
    public static bool w3_s_op1_3 = false;
    public static bool w3_s_op2_1 = false;
    public static bool w3_s_op2_2 = false;
    public static bool w3_s_op3_1 = false;
    public static bool w3_s_op3_2 = false;

    //3주차 냇가 엔딩
    public static bool w3_s_finish1 = false;
    public static bool w3_s_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //4주차 저잣거리 선택지 이동 버튼
    public static bool w4_s2_op1 = false;
    public static bool w4_s2_op2 = false;
    public static bool w4_s2_op3 = false;

    public static bool w4_s2_op1_1 = false;
    public static bool w4_s2_op1_2 = false;
    public static bool w4_s2_op2_1 = false;
    public static bool w4_s2_op2_2 = false;
    public static bool w4_s2_op2_3 = false;
    public static bool w4_s2_op3_1 = false;
    public static bool w4_s2_op3_2 = false;

    //4주차 저잣거리 엔딩
    public static bool w4_s2_finish = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //4주차 시장
    public static bool w4_m_op1 = false;
    public static bool w4_m_op2 = false;

    public static bool w4_m_op1_1 = false;
    public static bool w4_m_op1_2 = false;
    public static bool w4_m_op1_3 = false;
    public static bool w4_m_op2_1 = false;
    public static bool w4_m_op2_2 = false;
    public static bool w4_m_op2_3 = false;

    //4주차 시장 엔딩
    public static bool w4_m_finish1 = false;
    public static bool w4_m_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //4주차 냇가
    public static bool w4_s_op1 = false;
    public static bool w4_s_op2 = false;
    public static bool w4_s_op3 = false;
    public static bool w4_s_op4 = false;

    public static bool w4_s_op1_1 = false;
    public static bool w4_s_op1_2 = false;
    public static bool w4_s_op2_1 = false;
    public static bool w4_s_op2_2 = false;
    public static bool w4_s_op2_3 = false;
    public static bool w4_s_op3_1 = false;
    public static bool w4_s_op3_2 = false;
    public static bool w4_s_op3_3 = false;
    public static bool w4_s_op4_1 = false;
    public static bool w4_s_op4_2 = false;

    //4주차 냇가 엔딩
    public static bool w4_s_finish1 = false;
    public static bool w4_s_finish2 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //4주차 주막
    public static bool w4_p_op1 = false;
    public static bool w4_p_op2 = false;
    public static bool w4_p_op3 = false;
    public static bool w4_p_op4 = false;

    public static bool w4_p_op1_1 = false;
    public static bool w4_p_op1_2 = false;
    public static bool w4_p_op2_1 = false;
    public static bool w4_p_op2_2 = false;
    public static bool w4_p_op3_1 = false;
    public static bool w4_p_op3_2 = false;
    public static bool w4_p_op3_3 = false;
    public static bool w4_p_op4_1 = false;
    public static bool w4_p_op4_2 = false;

    //4주차 주막 엔딩
    public static bool w4_p_finish1 = false;
    public static bool w4_p_finish2 = false;
    public static bool w4_p_finish3 = false;
    public static bool w4_p_finish4 = false;

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Ink로부터 전달받은 tag string에 따라 true 혹은 false로 만드는 부분
    private static Dictionary<string, Action> Progress = new Dictionary<string, Action>()
    {
        //1주차 냇가
        { "w1_s_op1", () => w1_s_op1 = true },
        { "w1_s_op2", () => w1_s_op2 = true },
        { "w1_s_op3", () => w1_s_op3 = true },
        { "w1_s_op4", () => w1_s_op4 = true },
        { "w1_s_op1_1", () => w1_s_op1_1 = true },
        { "w1_s_op1_2", () => w1_s_op1_1 = false },
        { "w1_s_op2_1", () => w1_s_op2_1 = true },
        { "w1_s_op2_2", () => w1_s_op2_2 = true },

        //분리해야해서 .. ... .. .
        { "w1_s_op3_1", () => w1_s_op3_1 = true},
        { "w1_s_op3_2", () => w1_s_op3_2 = true},

        { "w1_s_op4_1", () => { w1_s_op4_1 = true; w1_s_op4_2 = false; } },
        { "w1_s_op4_2", () => { w1_s_op4_2 = true; w1_s_op4_1 = false; } },

        { "w1_s_finish1", () => w1_s_finish1 = true },
        { "w1_s_finish2", () => w1_s_finish2 = true },
        { "w1_s_finish3", () => w1_s_finish3 = true },

        //---------------------------------------------------------------------------------

        //1주차 약방
        { "w1_h_op1", () => w1_h_op1 = true },
        { "w1_h_op2", () => w1_h_op2 = true },
        { "w1_h_op3", () => w1_h_op3 = true },
        { "w1_h_op4", () => w1_h_op4 = true },
        { "w1_h_op1_1", () => w1_h_op1_1 = true },
        { "w1_h_op1_2", () => w1_h_op1_2 = true },
        { "w1_h_op1_3", () => w1_h_op1_3 = true },
        { "w1_h_op2_1", () => w1_h_op2_1 = true },
        { "w1_h_op2_2", () => w1_h_op2_1 = false },
        { "w1_h_op3_1", () => w1_h_op3_1 = true },
        { "w1_h_op3_2", () => w1_h_op3_1 = false },
        
        { "w1_h_op4_1", () => { w1_h_op4_1 = true; w1_h_op4_2 = false; } },
        { "w1_h_op4_2", () => { w1_h_op4_2 = true; w1_h_op4_1 = false; } },

        { "w1_h_finish1", () => w1_h_finish1 = true },

        //----------------------------------------------------------------------------------

        //1주차 주막
        { "w1_p_op1", () => w1_p_op1 = true },
        { "w1_p_op2", () => w1_p_op2 = true },

        { "w1_p_op1_1", () => w1_p_op1_1 = true},
        { "w1_p_op1_2", () => w1_p_op1_2 = true},

        { "w1_p_op2_1", () => { w1_p_op2_1 = true; w1_p_op2_2 = false; } },
        { "w1_p_op2_2", () => { w1_p_op2_2 = true; w1_p_op2_1 = false; } },

        { "w1_p_finish1", () => w1_p_finish1 = true },

        //----------------------------------------------------------------------------------

        //1주차 저잣거리1
        { "w1_j1_op1", () => w1_j1_op1 = true },
        { "w1_j1_op2", () => w1_j1_op2 = true },
        { "w1_j1_op3", () => w1_j1_op3 = true },
        { "w1_j1_op4", () => w1_j1_op4 = true },

        { "w1_j1_op1_1", () => w1_j1_op1_1 = true },
        { "w1_j1_op1_2", () => w1_j1_op1_1 = false },
        { "w1_j1_op2_1", () => w1_j1_op2_1 = true },
        { "w1_j1_op2_2", () => w1_j1_op2_1 = false },
        { "w1_j1_op3_1", () => w1_j1_op3_1 = true },
        { "w1_j1_op3_2", () => w1_j1_op3_1 = false },
        { "w1_j1_op4_1", () => { w1_j1_op4_1 = true; w1_j1_op4_2 = false; } },
        { "w1_j1_op4_2", () => { w1_j1_op4_2 = true; w1_j1_op4_1 = false; } },

        { "w1_j1_finish1", () => w1_j1_finish1 = true },
        { "w1_j1_finish2", () => w1_j1_finish2 = true },

        //----------------------------------------------------------------------------------

        //1주차 저잣거리 2
        { "w1_j2_op1", () => w1_j2_op1 = true },
        { "w1_j2_op2", () => w1_j2_op2 = true },
        { "w1_j2_op3", () => w1_j2_op3 = true },

        { "w1_j2_op1_1", () => w1_j2_op1_1 = true },
        { "w1_j2_op1_2", () => w1_j2_op1_1 = false },

        { "w1_j2_op2_1", () => w1_j2_op2_1 = true },
        { "w1_j2_op2_2", () => w1_j2_op2_2 = true },

        { "w1_j2_op3_1", () => { w1_j2_op3_1 = true; w1_j2_op3_2 = false; } },
        { "w1_j2_op3_2", () => { w1_j2_op3_2 = true; w1_j2_op3_1 = false; } },

        { "w1_j2_finish1", () => w1_j2_finish1 = true },
        { "w1_j2_finish2", () => w1_j2_finish2 = true },

        //----------------------------------------------------------------------------------

        //2주차 저잣거리2
        { "w2_j2_op1", () => w2_j2_op1 = true },
        { "w2_j2_op2", () => w2_j2_op2 = true },
        { "w2_j2_op3", () => w2_j2_op3 = true },

        { "w2_j2_op1_1", () => { w2_j2_op1_1 = true; w2_j2_op1_2 = false; w2_j2_op1_3 = false; }},
        { "w2_j2_op1_2", () => { w2_j2_op1_1 = false; w2_j2_op1_2 = true; w2_j2_op1_3 = false; }},
        { "w2_j2_op1_3", () => { w2_j2_op1_1 = false; w2_j2_op1_2 = false; w2_j2_op1_3 = true; }},

        { "w2_j2_op2_1", () => { w2_j2_op2_1 = true; w2_j2_op2_2 = false; w2_j2_op2_3 = false; }},
        { "w2_j2_op2_2", () => { w2_j2_op2_1 = false; w2_j2_op2_2 = true; w2_j2_op2_3 = false; }},
        { "w2_j2_op2_3", () => { w2_j2_op2_1 = false; w2_j2_op2_2 = false; w2_j2_op2_3 = true; }},

        { "w2_j2_op3_1", () => { w2_j2_op3_1 = true; w2_j2_op3_2 = false; w2_j2_op3_3 = false; }},
        { "w2_j2_op3_2", () => { w2_j2_op3_1 = false; w2_j2_op3_2 = true; w2_j2_op3_3 = false; }},
        { "w2_j2_op3_3", () => { w2_j2_op3_1 = false; w2_j2_op3_2 = false; w2_j2_op3_3 = true; }},

        { "w2_j2_finish1", () => w2_j2_finish1 = true },
        { "w2_j2_finish2", () => w2_j2_finish2 = true },
        { "w2_j2_finish3", () => w2_j2_finish3 = true },

        //----------------------------------------------------------------------------------

        //2주차 주막
        { "w2_p_op1", () => w2_p_op1 = true },
        { "w2_p_op2", () => w2_p_op2 = true },
        { "w2_p_op3", () => w2_p_op3 = true },
        { "w2_p_op4", () => w2_p_op4 = true },
        { "w2_p_op5", () => w2_p_op5 = true },
        { "w2_p_op6", () => w2_p_op6 = true },
        { "w2_p_op7", () => w2_p_op7 = true },

        { "w2_p_op1_1", () => { w2_p_op1_1 = true; w2_p_op1_2 = false; w2_p_op3 = false; w2_p_op4 = false; } },
        { "w2_p_op1_2", () => { w2_p_op1_2 = true; w2_p_op1_1 = false; w2_p_op2 = false; } },

        { "w2_p_op2_1", () => { w2_p_op2_1 = true; w2_p_op2_2 = false; w2_p_op2_3 = false; }},
        { "w2_p_op2_2", () => { w2_p_op2_1 = false; w2_p_op2_2 = true; w2_p_op2_3 = false; }},
        { "w2_p_op2_3", () => { w2_p_op2_1 = false; w2_p_op2_2 = false; w2_p_op2_3 = true; }},

        { "w2_p_op3_1", () => { w2_p_op3_1 = true; w2_p_op3_2 = false;} },
        { "w2_p_op3_2", () => { w2_p_op3_2 = true; w2_p_op3_1 = false; w2_p_op4 = false; } },

        { "w2_p_op4_1", () => { w2_p_op4_1 = true; w2_p_op4_2 = false; }},
        { "w2_p_op4_2", () => { w2_p_op4_1 = false; w2_p_op4_2 = true; } },

        { "w2_p_op5_1", () => { w2_p_op5_1 = true; w2_p_op5_2 = false ; w2_p_op6 = false; }},
        { "w2_p_op5_2", () => { w2_p_op5_1 = false; w2_p_op5_2 = true; }},

        { "w2_p_op6_1", () => { w2_p_op6_1 = true; w2_p_op6_2 = false; } },
        { "w2_p_op6_2", () => { w2_p_op6_1 = false; w2_p_op6_2 = true; }},

        { "w2_p_op7_1", () => { w2_p_op7_1 = true; w2_p_op7_2 = false; w2_p_op7_3 = false; }},
        { "w2_p_op7_2", () => { w2_p_op7_1 = false; w2_p_op7_2 = true; w2_p_op7_3 = false; }},
        { "w2_p_op7_3", () => { w2_p_op7_1 = false; w2_p_op7_2 = false; w2_p_op7_3 = true; }},

        { "w2_p_finish", () => w2_p_finish = true },

        //----------------------------------------------------------------------------------

        //2주차 약방
        { "w2_h_op1", () => w2_h_op1 = true },
        { "w2_h_op2", () => w2_h_op2 = true },
        { "w2_h_op3", () => w2_h_op3 = true },
        { "w2_h_op4", () => w2_h_op4 = true },
        { "w2_h_op5", () => w2_h_op5 = true },

        { "w2_h_op1_1", () => { w2_h_op1_1 = true; w2_h_op1_2 = false;} },
        { "w2_h_op1_2", () => { w2_h_op1_1 = false; w2_h_op1_2 = true;} },

        { "w2_h_op2_1", () => { w2_h_op2_1 = true; w2_h_op2_2 = false; w2_h_op2_3 = false; w2_h_op3 = false; w2_h_op4 = false; }},
        { "w2_h_op2_2", () => { w2_h_op2_1 = false; w2_h_op2_2 = true; w2_h_op2_3 = false; w2_h_op3 = false; w2_h_op4 = false; }},
        { "w2_h_op2_3", () => { w2_h_op2_1 = false; w2_h_op2_2 = false; w2_h_op2_3 = true; w2_h_op3 = false; w2_h_op4 = false; }},

        { "w2_h_op3_1", () => { w2_h_op3_1 = true; w2_h_op3_2 = false; w2_h_op4 = false; }},
        { "w2_h_op3_2", () => { w2_h_op3_1 = false; w2_h_op3_2 = true; w2_h_op4 = false; }},

        { "w2_h_op4_1", () => { w2_h_op4_1 = true; w2_h_op3 = false; }},
        { "w2_h_op4_2", () => { w2_h_op4_2 = true; w2_h_op3 = false; }},

        { "w2_h_op5_1", () => { w2_h_op5_1 = true; w2_h_op5_2 = false; w2_h_op5_3 = false; }},
        { "w2_h_op5_2", () => { w2_h_op5_1 = false; w2_h_op5_2 = true; w2_h_op5_3 = false; }},
        { "w2_h_op5_3", () => { w2_h_op5_1 = false; w2_h_op5_2 = false; w2_h_op5_3 = true; }},

        { "w2_h_finish1", () => w2_h_finish1 = true },
        { "w2_h_finish2", () => w2_h_finish2 = true },
        { "w2_h_finish3", () => w2_h_finish3 = true },

        //----------------------------------------------------------------------------------

        //2주차 냇가
        { "w2_s_op1", () => w2_s_op1 = true },
        { "w2_s_op2", () => w2_s_op2 = true },
        { "w2_s_op3", () => w2_s_op3 = true },
        { "w2_s_op4", () => w2_s_op4 = true },
        { "w2_s_op5", () => w2_s_op5 = true },

        { "w2_s_op1_1", () => { w2_s_op1_1 = true; w2_s_op1_2 = false; }},
        { "w2_s_op1_2", () => { w2_s_op1_1 = false; w2_s_op1_2 = true; }},

        { "w2_s_op2_1", () => { w2_s_op2_1 = true; w2_s_op2_2 = false; w2_s_op2_3 = false; }},
        { "w2_s_op2_2", () => { w2_s_op2_1 = false; w2_s_op2_2 = true; w2_s_op2_3 = false; w2_s_op3 = false; }},
        { "w2_s_op2_3", () => { w2_s_op2_1 = false; w2_s_op2_2 = false; w2_s_op2_3 = true; w2_s_op3 = false; }},

        { "w2_s_op3_1", () => { w2_s_op3_1 = true; w2_s_op3_2 = false; }},
        { "w2_s_op3_2", () => { w2_s_op3_1 = false; w2_s_op3_2 = true; }},

        { "w2_s_op4_1", () => { w2_s_op4_1 = true; w2_s_op4_2 = false; w2_s_op4_3 = false; }},
        { "w2_s_op4_2", () => { w2_s_op4_1 = false; w2_s_op4_2 = true; w2_s_op4_3 = false; }},
        { "w2_s_op4_3", () => { w2_s_op4_1 = false; w2_s_op4_2 = false; w2_s_op4_3 = true; }},

        { "w2_s_op5_1", () => { w2_s_op5_1 = true; w2_s_op5_2 = false; }},
        { "w2_s_op5_2", () => { w2_s_op5_1 = false; w2_s_op5_2 = true; }},

        //----------------------------------------------------------------------------------

        //2주차 저잣거리1
        { "w2_j1_op1", () => w2_j1_op1 = true },
        { "w2_j1_op2", () => w2_j1_op2 = true },
        { "w2_j1_op3", () => w2_j1_op3 = true },

        { "w2_j1_op1_1", () => { w2_j1_op1_1 = true; w2_j1_op1_2 = false; w2_j1_op1_3 = false; }},
        { "w2_j1_op1_2", () => { w2_j1_op1_1 = false; w2_j1_op1_2 = true; w2_j1_op1_3 = false; }},
        { "w2_j1_op1_3", () => { w2_j1_op1_1 = false; w2_j1_op1_2 = false; w2_j1_op1_3 = true; }},
        { "w2_j1_op2_1", () => w2_j1_op2_1 = true },
        { "w2_j1_op2_2", () => w2_j1_op2_1 = false },
        { "w2_j1_op3_1", () => { w2_j1_op3_1 = true; w2_j1_op3_2 = false; } },
        { "w2_j1_op3_2", () => { w2_j1_op3_2 = true; w2_j1_op3_1 = false; } },

        { "w2_j1_finish1", () => w2_j1_finish1 = true },
        { "w2_j1_finish2", () => w2_j1_finish2 = true },

        //----------------------------------------------------------------------------------

        //2주차 밭
        { "w2_f_op1", () => w2_f_op1 = true },
        { "w2_f_op2", () => w2_f_op2 = true },
        { "w2_f_op3", () => w2_f_op3 = true },

        { "w2_f_op1_1", () => { w2_f_op1_1 = true; w2_f_op1_2 = false; }},
        { "w2_f_op1_2", () => { w2_f_op1_1 = false; w2_f_op1_2 = true; }},

        { "w2_f_op2_1", () => { w2_f_op2_1 = true; w2_f_op2_2 = false; w2_f_op2_3 = false; }},
        { "w2_f_op2_2", () => { w2_f_op2_1 = false; w2_f_op2_2 = true; w2_f_op2_3 = false; }},
        { "w2_f_op2_3", () => { w2_f_op2_1 = false; w2_f_op2_2 = false; w2_f_op2_3 = true; }},

        { "w2_f_op3_1", () => { w2_f_op3_1 = true; }},
        { "w2_f_op3_2", () => { w2_f_op3_2 = true; }},

        //----------------------------------------------------------------------------------

        //3주차 주막
        { "w3_p_op1", () => w3_p_op1 = true },
        { "w3_p_op2", () => w3_p_op2 = true },
        { "w3_p_op3", () => w3_p_op3 = true },
        { "w3_p_op4", () => w3_p_op4 = true },
        { "w3_p_op5", () => w3_p_op5 = true },
        { "w3_p_op6", () => w3_p_op6 = true },

        { "w3_p_op1_1", () => { w3_p_op1_1 = true; }},
        { "w3_p_op1_2", () => { w3_p_op1_2 = true; }},
        { "w3_p_op1_3", () => { w3_p_op1_3 = true; }},

        { "w3_p_op2_1", () => { w3_p_op2_1 = true; }},
        { "w3_p_op2_2", () => { w3_p_op2_2 = true; }},

        { "w3_p_op3_1", () => { w3_p_op3_1 = true; }},
        { "w3_p_op3_2", () => { w3_p_op3_2 = true; }},

        { "w3_p_op4_1", () => { w3_p_op4_1 = true; }},
        { "w3_p_op4_2", () => { w3_p_op4_2 = true; }},

        { "w3_p_op5_1", () => { w3_p_op5_1 = true; }},
        { "w3_p_op5_2", () => { w3_p_op5_2 = true; }},

        { "w3_p_op6_1", () => { w3_p_op6_1 = true; w3_p_op6_2 = false; }},
        { "w3_p_op6_2", () => { w3_p_op6_1 = false; w3_p_op6_2 = true; }},

        { "w3_p_finish1", () => w3_p_finish1 = true },
        { "w3_p_finish2", () => w3_p_finish2 = true },

        //----------------------------------------------------------------------------------
        
        //3주차 저잣거리1
        { "w3_j1_op1", () => w3_j1_op1 = true },
        { "w3_j1_op2", () => w3_j1_op2 = true },
        { "w3_j1_op3", () => w3_j1_op3 = true },

        { "w3_j1_op1_1", () => { w3_j1_op1_1 = true; }},
        { "w3_j1_op1_2", () => { w3_j1_op1_2 = true; }},
        { "w3_j1_op1_3", () => { w3_j1_op1_3 = true; }},

        { "w3_j1_op2_1", () => { w3_j1_op2_1 = true; }},
        { "w3_j1_op2_2", () => { w3_j1_op2_2 = true; }},

        { "w3_j1_op3_1", () => { w3_j1_op3_1 = true; w3_j1_op3_2 = false; w3_j1_op3_3 = false; }},
        { "w3_j1_op3_2", () => { w3_j1_op3_2 = true; w3_j1_op3_1 = false; w3_j1_op3_3 = false; }},
        { "w3_j1_op3_3", () => { w3_j1_op3_3 = true; w3_j1_op3_1 = false; w3_j1_op3_2 = false; }},

        { "w3_j1_finish1", () => w3_j1_finish1 = true },
        { "w3_j1_finish2", () => w3_j1_finish2 = true },
        { "w3_j1_finish3", () => w3_j1_finish3 = true },

        //----------------------------------------------------------------------------------

        //3주차 약방
        { "w3_h_op1", () => w3_h_op1 = true },
        { "w3_h_op2", () => w3_h_op2 = true },

        { "w3_h_op1_1", () => { w3_h_op1_1 = true; }},
        { "w3_h_op1_2", () => { w3_h_op1_2 = true; }},

        { "w3_h_op2_1", () => { w3_h_op2_1 = true; }},
        { "w3_h_op2_2", () => { w3_h_op2_2 = true; }},
        { "w3_h_op2_3", () => { w3_h_op2_3 = true; }},

        { "w3_h_finish1", () => w3_h_finish = true },

        //----------------------------------------------------------------------------------

        //3주차 밭
        { "w3_f_op1", () => w3_f_op1 = true },
        { "w3_f_op2", () => w3_f_op2 = true },
        { "w3_f_op3", () => w3_f_op3 = true },
        { "w3_f_op4", () => w3_f_op4 = true },

        { "w3_f_op1_1", () => { w3_f_op1_1 = true; }},
        { "w3_f_op1_2", () => { w3_f_op1_2 = true; }},
        { "w3_f_op1_3", () => { w3_f_op1_3 = true; }},

        { "w3_f_op2_1", () => { w3_f_op2_1 = true; }},
        { "w3_f_op2_2", () => { w3_f_op2_2 = true; }},
        { "w3_f_op2_3", () => { w3_f_op2_3 = true; }},

        { "w3_f_op3_1", () => { w3_f_op3_1 = true; w3_f_op3_2 = false; }},
        { "w3_f_op3_2", () => { w3_f_op3_1 = false; w3_f_op3_2 = true; }},

        { "w3_f_op4_1", () => { w3_f_op4_1 = true; }},
        { "w3_f_op4_2", () => { w3_f_op4_2 = true; }},

        { "w3_f_finish1", () => w3_f_finish1 = true },
        { "w3_f_finish2", () => w3_f_finish2 = true },

        //----------------------------------------------------------------------------------

        //3주차 저잣거리2
        { "w3_j2_op1", () => w3_j2_op1 = true },
        { "w3_j2_op2", () => w3_j2_op2 = true },
        { "w3_j2_op3", () => w3_j2_op3 = true },

        { "w3_j2_op1_1", () => { w3_j2_op1_1 = true; w3_j2_op1_2 = false; w3_j2_op1_3 = false; }},
        { "w3_j2_op1_2", () => { w3_j2_op1_2 = true; w3_j2_op1_1 = false; w3_j2_op1_3 = false; }},
        { "w3_j2_op1_3", () => { w3_j2_op1_3 = true; w3_j2_op1_1 = false; w3_j2_op1_2 = false; }},

        { "w3_j2_op2_1", () => { w3_j2_op2_1 = true; w3_j2_op2_2 = false; }},
        { "w3_j2_op2_2", () => { w3_j2_op2_1 = false; w3_j2_op2_2 = true; }},

        { "w3_j2_op3_1", () => { w3_j2_op3_1 = true; }},
        { "w3_j2_op3_2", () => { w3_j2_op3_2 = true; }},

        { "w3_j2_finish1", () => w3_j2_finish = true },

        //----------------------------------------------------------------------------------

        //3주차 냇가
        { "w3_s_op1", () => w3_s_op1 = true },
        { "w3_s_op2", () => w3_s_op2 = true },
        { "w3_s_op3", () => w3_s_op3 = true },

        { "w3_s_op1_1", () => { w3_s_op1_1 = true; w3_s_op1_2 = false; w3_s_op1_3 = false; }},
        { "w3_s_op1_2", () => { w3_s_op1_2 = true; w3_s_op1_1 = false; w3_s_op1_3 = false; }},
        { "w3_s_op1_3", () => { w3_s_op1_3 = true; w3_s_op1_1 = false; w3_s_op1_2 = false; }},

        { "w3_s_op2_1", () => { w3_s_op2_1 = true; w3_s_op2_2 = false; }},
        { "w3_s_op2_2", () => { w3_s_op2_1 = false; w3_s_op2_2 = true; }},

        { "w3_s_op3_1", () => { w3_s_op3_1 = true; w3_s_op3_2 = false; }},
        { "w3_s_op3_2", () => { w3_s_op3_1 = false; w3_s_op3_2 = true; }},

        { "w3_s_finish1", () => w3_s_finish1 = true },
        { "w3_s_finish2", () => w3_s_finish2 = true },


        //----------------------------------------------------------------------------------

        //4주차 저잣거리
        { "w4_s2_op1", () => w4_s2_op1 = true },
        { "w4_s2_op2", () => w4_s2_op2 = true },
        { "w4_s2_op3", () => w4_s2_op3 = true },

        { "w4_s2_op1_1", () => { w4_s2_op1_1 = true; w4_s2_op1_2 = false; }},
        { "w4_s2_op1_2", () => { w4_s2_op1_1 = false; w4_s2_op1_2 = true; }},

        { "w4_s2_op2_1", () => { w4_s2_op2_1 = true; w4_s2_op2_2 = false; }},
        { "w4_s2_op2_2", () => { w4_s2_op2_1 = false; w4_s2_op2_2 = true; }},
        { "w4_s2_op2_3", () => w4_s2_op2_3 = true },

        { "w4_s2_op3_1", () => { w4_s2_op3_1 = true; w4_s2_op3_2 = false; }},
        { "w4_s2_op3_2", () => { w4_s2_op3_1 = false; w4_s2_op3_2 = true; }},

        { "w4_s2_finish", () => w4_s2_finish = true },

        //----------------------------------------------------------------------------------

        //4주차 시장
        { "w4_m_op1", () => w4_m_op1 = true },
        { "w4_m_op2", () => w4_m_op2 = true },

        { "w4_m_op1_1", () => { w4_m_op1_1 = true; w4_m_op1_2 = false; w4_m_op1_3 = false; }},
        { "w4_m_op1_2", () => { w4_m_op1_1 = false; w4_m_op1_2 = true; w4_m_op1_3 = false; }},
        { "w4_m_op1_3", () => { w4_m_op1_1 = false; w4_m_op1_2 = false; w4_m_op1_3 = true; }},

        { "w4_m_op2_1", () => { w4_m_op2_1 = true; w4_m_op2_3 = false; }},
        { "w4_m_op2_2", () => w4_m_op2_2 = true },
        { "w4_m_op2_3", () => { w4_m_op2_1 = false; w4_m_op2_3 = true; }},

        { "w4_m_finish1", () => { w4_m_finish1 = true; w4_m_finish2 = false; }},
        { "w4_m_finish2", () => { w4_m_finish1 = false; w4_m_finish2 = true; }},

        //----------------------------------------------------------------------------------

        //4주차 냇가
        { "w4_s_op1", () => w4_s_op1 = true },
        { "w4_s_op2", () => w4_s_op2 = true },
        { "w4_s_op3", () => w4_s_op3 = true },
        { "w4_s_op4", () => w4_s_op4 = true },

        { "w4_s_op1_1", () => { w4_s_op1_1 = true; w4_s_op1_2 = false; }},
        { "w4_s_op1_2", () => { w4_s_op1_1 = false; w4_s_op1_2 = true; }},

        { "w4_s_op2_1", () => { w4_s_op2_1 = true; w4_s_op2_2 = false; w4_s_op2_3 = false; }},
        { "w4_s_op2_2", () => { w4_s_op2_1 = false; w4_s_op2_2 = true; w4_s_op2_3 = false; }},
        { "w4_s_op2_3", () => { w4_s_op2_1 = false; w4_s_op2_2 = false; w4_s_op2_3 = true; }},

        //1이랑 3 둘다 죽는거라 배타적일 필요 없음
        { "w4_s_op3_1", () => w4_s_op3_1 = true },
        { "w4_s_op3_2", () => w4_s_op3_2 = true },
        { "w4_s_op3_3", () => w4_s_op3_3 = true },

        { "w4_s_op4_1", () => { w4_s_op4_1 = true; w4_s_op4_2 = false; }},
        { "w4_s_op4_2", () => { w4_s_op4_1 = false; w4_s_op4_2 = true; }},

        { "w4_s_finish1", () => { w4_s_finish1 = true; w4_s_finish2 = false; }},
        { "w4_s_finish2", () => { w4_s_finish1 = false; w4_s_finish2 = true; }},

        //----------------------------------------------------------------------------------

        //4주차 주막
        { "w4_p_op1", () => w4_p_op1 = true },
        { "w4_p_op2", () => w4_p_op2 = true },
        { "w4_p_op3", () => w4_p_op3 = true },
        { "w4_p_op4", () => w4_p_op4 = true },

        { "w4_p_op1_1", () => { w4_p_op1_1 = true; w4_p_op1_2 = false; }},
        { "w4_p_op1_2", () => { w4_p_op1_1 = false; w4_p_op1_2 = true; }},

        { "w4_p_op2_1", () => { w4_p_op2_1 = true; w4_p_op2_2 = false; }},
        { "w4_p_op2_2", () => { w4_p_op2_1 = false; w4_p_op2_2 = true; }},

        //3_1 고르면 소엔딩 나는 선택 초기화해야함
        { "w4_p_op3_1", () => { w4_p_op3_1 = true; w4_p_op3_2 = false; w4_p_op3_3 = false; w4_p_finish1 = false; w4_p_finish2 = false; }},
        { "w4_p_op3_2", () => { w4_p_op3_1 = false; w4_p_op3_2 = true; w4_p_op3_3 = false; w4_p_op4 = false; }},
        { "w4_p_op3_3", () => { w4_p_op3_1 = false; w4_p_op3_2 = false; w4_p_op3_3 = true; w4_p_op4 = false; }},

        { "w4_p_op4_1", () => { w4_p_op4_1 = true; w4_p_op4_2 = false; }},
        { "w4_p_op4_2", () => { w4_p_op4_1 = false; w4_p_op4_2 = true; }},

        { "w4_p_finish1", () => { w4_p_finish1 = true; w4_p_finish2 = false; w4_p_finish3 = false; w4_p_finish4 = false; }},
        { "w4_p_finish2", () => { w4_p_finish1 = false; w4_p_finish2 = true; w4_p_finish3 = false; w4_p_finish4 = false; }},
        { "w4_p_finish3", () => { w4_p_finish1 = false; w4_p_finish2 = false; w4_p_finish3 = true; w4_p_finish4 = false; }},
        { "w4_p_finish4", () => { w4_p_finish1 = false; w4_p_finish2 = false; w4_p_finish3 = false; w4_p_finish4 = true; }},

}; 

    // InkManager에서 태그 이름을 전달하면 처리
    public static void ApplyProgress(string tag)
    {
        if (Progress.TryGetValue(tag, out Action action))
        {
            action.Invoke();
        }
    }
}
