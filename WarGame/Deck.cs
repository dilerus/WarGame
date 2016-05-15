using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Deck
    {
        //public List<Card> CardList;

       // public Deck()
       // {

        //     public List<Card> CardList;
        //CardList = new List<Card>();

        //    Card H2 = new Card();
        //    H2.Value = 2;
        //    H2.Code = "H2";
        //    CardList.Add(H2);

        //    Card H3 = new Card();
        //    H3.Value = 3;
        //    H3.Code = "H3";
        //    CardList.Add(H3);

        //    Card H4 = new Card();
        //    H4.Value = 4;
        //    H4.Code = "H4";
        //    CardList.Add(H4);

        //    Card H5 = new Card();
        //    H5.Value = 5;
        //    H5.Code = "H5";
        //    CardList.Add(H5);

        //    Card H6 = new Card();
        //    H6.Value = 6;
        //    H6.Code = "H6";
        //    CardList.Add(H6);

        //    Card H7 = new Card();
        //    H7.Value = 7;
        //    H7.Code = "H7";
        //    CardList.Add(H7);

        //    Card H8 = new Card();
        //    H8.Value = 8;
        //    H8.Code = "H8";
        //    CardList.Add(H8);

        //    Card H9 = new Card();
        //    H9.Value = 9;
        //    H9.Code = "H9";
        //    CardList.Add(H9);

        //    Card H10 = new Card();
        //    H10.Value = 10;
        //    H10.Code = "H10";
        //    CardList.Add(H10);

        //    Card HJ = new Card();
        //    HJ.Value = 11;
        //    HJ.Code = "HJ";
        //    CardList.Add(HJ);

        //    Card HQ = new Card();
        //    HQ.Value = 12;
        //    HQ.Code = "HQ";
        //    CardList.Add(HQ);

        //    Card HK = new Card();
        //    HK.Value = 13;
        //    HK.Code = "HK";
        //    CardList.Add(HK);

        //    Card HA = new Card();
        //    HA.Value = 14;
        //    HA.Code = "HA";
        //    CardList.Add(HA);




        //    Card D2 = new Card();
        //    D2.Value = 2;
        //    D2.Code = "D2";
        //    CardList.Add(D2);

        //    Card D3 = new Card();
        //    D3.Value = 3;
        //    D3.Code = "D3";
        //    CardList.Add(D3);

        //    Card D4 = new Card();
        //    D4.Value = 4;
        //    D4.Code = "D4";
        //    CardList.Add(D4);

        //    Card D5 = new Card();
        //    D5.Value = 5;
        //    D5.Code = "D5";
        //    CardList.Add(D5);

        //    Card D6 = new Card();
        //    D6.Value = 6;
        //    D6.Code = "D6";
        //    CardList.Add(D6);

        //    Card D7 = new Card();
        //    D7.Value = 7;
        //    D7.Code = "D7";
        //    CardList.Add(D7);

        //    Card D8 = new Card();
        //    D8.Value = 8;
        //    D8.Code = "D8";
        //    CardList.Add(D8);

        //    Card D9 = new Card();
        //    D9.Value = 9;
        //    D9.Code = "D9";
        //    CardList.Add(D9);

        //    Card D10 = new Card();
        //    D10.Value = 10;
        //    D10.Code = "D10";
        //    CardList.Add(D10);

        //    Card DJ = new Card();
        //    DJ.Value = 11;
        //    DJ.Code = "DJ";
        //    CardList.Add(DJ);

        //    Card DQ = new Card();
        //    DQ.Value = 12;
        //    DQ.Code = "DQ";
        //    CardList.Add(DQ);

        //    Card DK = new Card();
        //    DK.Value = 13;
        //    DK.Code = "DK";
        //    CardList.Add(DK);

        //    Card DA = new Card();
        //    DA.Value = 14;
        //    DA.Code = "DA";
        //    CardList.Add(DA);




        //    Card C2 = new Card();
        //    C2.Value = 2;
        //    C2.Code = "C2";
        //    CardList.Add(C2);

        //    Card C3 = new Card();
        //    C3.Value = 3;
        //    C3.Code = "C3";
        //    CardList.Add(C3);

        //    Card C4 = new Card();
        //    C4.Value = 4;
        //    C4.Code = "C4";
        //    CardList.Add(C4);

        //    Card C5 = new Card();
        //    C5.Value = 5;
        //    C5.Code = "C5";
        //    CardList.Add(C5);

        //    Card C6 = new Card();
        //    C6.Value = 6;
        //    C6.Code = "C6";
        //    CardList.Add(C6);

        //    Card C7 = new Card();
        //    C7.Value = 7;
        //    C7.Code = "C7";
        //    CardList.Add(C7);

        //    Card C8 = new Card();
        //    C8.Value = 8;
        //    C8.Code = "C8";
        //    CardList.Add(C8);

        //    Card C9 = new Card();
        //    C9.Value = 9;
        //    C9.Code = "C9";
        //    CardList.Add(C9);

        //    Card C10 = new Card();
        //    C10.Value = 10;
        //    C10.Code = "C10";
        //    CardList.Add(C10);

        //    Card CJ = new Card();
        //    CJ.Value = 11;
        //    CJ.Code = "CJ";
        //    CardList.Add(CJ);

        //    Card CQ = new Card();
        //    CQ.Value = 12;
        //    CQ.Code = "CQ";
        //    CardList.Add(CQ);

        //    Card CK = new Card();
        //    CK.Value = 13;
        //    CK.Code = "CK";
        //    CardList.Add(CK);

        //    Card CA = new Card();
        //    CA.Value = 14;
        //    CA.Code = "CA";
        //    CardList.Add(CA);




        //    Card S2 = new Card();
        //    S2.Value = 2;
        //    S2.Code = "S2";
        //    CardList.Add(S2);

        //    Card S3 = new Card();
        //    S3.Value = 3;
        //    S3.Code = "S3";
        //    CardList.Add(S3);

        //    Card S4 = new Card();
        //    S4.Value = 4;
        //    S4.Code = "S4";
        //    CardList.Add(S4);

        //    Card S5 = new Card();
        //    S5.Value = 5;
        //    S5.Code = "S5";
        //    CardList.Add(S5);

        //    Card S6 = new Card();
        //    S6.Value = 6;
        //    S6.Code = "S6";
        //    CardList.Add(S6);

        //    Card S7 = new Card();
        //    S7.Value = 7;
        //    S7.Code = "S7";
        //    CardList.Add(S7);

        //    Card S8 = new Card();
        //    S8.Value = 8;
        //    S8.Code = "S8";
        //    CardList.Add(S8);

        //    Card S9 = new Card();
        //    S9.Value = 9;
        //    S9.Code = "S9";
        //    CardList.Add(S9);

        //    Card S10 = new Card();
        //    S10.Value = 10;
        //    S10.Code = "S10";
        //    CardList.Add(S10);

        //    Card SJ = new Card();
        //    SJ.Value = 11;
        //    SJ.Code = "SJ";
        //    CardList.Add(SJ);

        //    Card SQ = new Card();
        //    SQ.Value = 12;
        //    SQ.Code = "SQ";
        //    CardList.Add(SQ);

        //    Card SK = new Card();
        //    SK.Value = 13;
        //    SK.Code = "SK";
        //    CardList.Add(SK);

        //    Card SA = new Card();
        //    SA.Value = 14;
        //    SA.Code = "SA";
        //    CardList.Add(SA);
       // }

    }
}
