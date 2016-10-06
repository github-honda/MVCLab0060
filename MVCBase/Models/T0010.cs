using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBase.Models
{
    public class T0010
    {
        public string ms1 { get; set; }  // 編號
        public string ms2 { get; set; }  // 姓名
        public int mi1 { get; set; }     // 國文
        public int mi2 { get; set; }     // 英文
        public T0010 Read1Record(string id)
        {
            // 本函數模擬讀取一筆資料, 將來會改為實際從資料來源讀取.
            T0010 t1 = new T0010();
            t1.ms1 = "0007";
            t1.ms2 = "王碧聖";
            t1.mi1 = 95;
            t1.mi2 = 92;
            return t1;
        }
        public List<T0010> ReadList()
        {
            // 本函數模擬讀取一組清單資料, 將來會改為實際從資料來源讀取.
            List<T0010> oList = new List<T0010>();

            T0010 t1 = new T0010();
            t1.ms1 = "0005";
            t1.ms2 = "林家遊";
            t1.mi1 = 65;
            t1.mi2 = 44;
            oList.Add(t1);

            t1 = new T0010();
            t1.ms1 = "0002";
            t1.ms2 = "吳任書";
            t1.mi1 = 90;
            t1.mi2 = 43;
            oList.Add(t1);
            //return oList;

            t1 = new T0010();
            t1.ms1 = "0004";
            t1.ms2 = "張可樂";
            t1.mi1 = 52;
            t1.mi2 = 57;
            oList.Add(t1);

            t1 = new T0010();
            t1.ms1 = "0003";
            t1.ms2 = "陳萍萍";
            t1.mi1 = 72;
            t1.mi2 = 70;
            oList.Add(t1);
            return oList;
        }

    }
}