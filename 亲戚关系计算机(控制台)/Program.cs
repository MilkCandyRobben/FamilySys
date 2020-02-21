using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 亲戚关系计算机_控制台_
{
    //static class PersonPointer
    //{
    //    static Person me_startPoi;
    //    static Person prePerson;
    //    static Person thisPerson;
    //    static Person nextPerson;
    //}
    class FamilyRelationGraph
    {
        Person me_startPoi;
        Person curr;
        int memberCount;
        public enum HowToFind { ByNAME,ByENCODE};

        private FamilyRelationGraph()
        {
            me_startPoi = null;
            curr = null;
            memberCount = 0;
        }

        Person first(Person startPoi)
        {
            Person p = null;
            if (startPoi._father != null)
            {
                p = startPoi._father;
            }
            else if(startPoi._mother != null)
            {
                p = startPoi._mother;
            }
            else if(startPoi._son != null)
            {
                p = startPoi._son;
            }
            else if(startPoi._daughter != null)
            {
                p = startPoi._daughter;
            }
            else if(startPoi._elderBrother != null)
            {
                p = startPoi._elderBrother;
            }
            else if(startPoi._elderSister != null)
            {
                p = startPoi._elderSister;
            }
            else if(startPoi._littleBrother != null)
            {
                p = startPoi._littleBrother;
            }
            else if(startPoi._littleSister != null)
            {
                p = startPoi._littleSister;
            }
            else if(startPoi._husband != null)
            {
                p = startPoi._husband;
            }
            else if(startPoi._wife != null)
            {
                p = startPoi._wife;
            }
            return p;
        }
        Person next(Person startPoi,Person nextPoi)
        {
            if (nextPoi == null)
            {
                return null;
            }
            else if (startPoi._father == nextPoi)
            {
                if (startPoi._mother != null)
                {
                    nextPoi = startPoi._mother;
                }
                else if (startPoi._son != null)
                {
                    nextPoi = startPoi._son;
                }
                else if (startPoi._daughter != null)
                {
                    nextPoi = startPoi._daughter;
                }
                else if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._mother == nextPoi)
            {
                if (startPoi._son != null)
                {
                    nextPoi = startPoi._son;
                }
                else if (startPoi._daughter != null)
                {
                    nextPoi = startPoi._daughter;
                }
                else if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._son == nextPoi)
            {
                if (startPoi._daughter != null)
                {
                    nextPoi = startPoi._daughter;
                }
                else if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._daughter == nextPoi)
            {
                if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._elderBrother == nextPoi)
            {
                if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._elderSister == nextPoi)
            {
                if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._littleBrother == nextPoi)
            {
                if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._littleSister == nextPoi)
            {
                if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._husband == nextPoi)
            {
                if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._wife == nextPoi)
            {
                nextPoi = null;
            }
            return nextPoi;
        }

        #region//深度遍历和广度遍历
        void DFS_withSetVisited(Person startPoi,List<Person> result)
        {
            if (getMark(startPoi) == false)
            {
                result.Add(startPoi);
                setMark(startPoi, true);
            }
            else
            {
                return;
            }
            for (Person nextPoi = first(startPoi); nextPoi !=null; nextPoi = next(startPoi, nextPoi))
            {
                DFS_withSetVisited(nextPoi, result);
            }
        }
        void DFS_withoutSetVisited(Person startPoi, List<Person> result)
        {
            DFS_withSetVisited(startPoi, result);
            cleanMark(startPoi);
        }
        void BFS_withSetVisited(Person startPoi, List<Person> result)
        {
            Queue<Person> help_queue = new Queue<Person>();
            if (getMark(startPoi) == false)
            {
                help_queue.Enqueue(startPoi);
                setMark(startPoi, true);
            }
            while (help_queue.Count() != 0)
            {
                Person out_queue_item = help_queue.Dequeue();
                result.Add(out_queue_item);

                for (Person nextPoi = first(out_queue_item); nextPoi !=null; nextPoi = next(out_queue_item, nextPoi))
                {
                    if (getMark(nextPoi) == false)
                    {
                        help_queue.Enqueue(nextPoi);
                        setMark(nextPoi, true);
                    }
                }
            }
        }
        void BFS_withoutSetVisited(Person startPoi, List<Person> result)
        {
            BFS_withSetVisited(startPoi, result);
            cleanMark(startPoi);
        }

        #endregion

        #region//设置访问标记
        void cleanMark(Person startPoi)//待改进，算法还会有重复访问
        {
            Person p = startPoi;
            if (p._me != null && p._me.isVisited == true) 
            {
                p.isVisited = false;
            }
            if (p._father != null)
            {
                cleanMark(p._father);
            }
            if (p._mother != null)
            {
                cleanMark(p._mother);
            }
            if (p._son != null)
            {
                cleanMark(p._son);
            }
            if (p._daughter != null)
            {
                cleanMark(p._daughter);
            }
            if (p._elderBrother != null)
            {
                cleanMark(p._elderBrother);
            }
            if (p._elderSister != null)
            {
                cleanMark(p._elderSister);
            }
            if (p._littleBrother != null)
            {
                cleanMark(p._littleBrother);
            }
            if (p._littleSister != null)
            {
                cleanMark(p._littleSister);
            }
            if (p._husband != null)
            {
                cleanMark(p._husband);
            }
            if (p._wife != null)
            {
                cleanMark(p._wife);
            }
        }
        void setMark(Person p,bool mark)
        {
            p._me.isVisited = mark;
        }
        bool getMark(Person p)
        {
            return p._me.isVisited;
        }
        #endregion

        #region//编码解码以及根据编码移动指针
        void decode(string encodeStr,string decodeResult,string finalResult)
        {
            String decode = "";
            String result = "";
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 0;)
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://我
                        {
                            break;
                        }
                    case "01"://父亲
                        {
                            decode += "父亲";
                            result = "父亲";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "爷爷";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "奶奶";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "我（男）、大哥、小弟";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "我（女）、大姐、小妹";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "伯父";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "姑妈";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "叔叔";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姑";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "母亲";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "02"://母亲
                        {
                            decode += "母亲";
                            result = "母亲";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "外公";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "外婆";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "我（男）、大哥、小弟";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "我（女）、大姐、小妹";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大舅";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "小舅";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "大姨";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姨";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "父亲";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "11"://儿子
                        {
                            decode += "儿子";
                            result = "儿子";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "我（男）、丈夫";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "我（女）、妻子";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "孙子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "孙女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "儿子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "女儿";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "儿子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "女儿";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "儿媳妇";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "12"://女儿
                        {
                            decode += "女儿";
                            result = "女儿";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "我（男）、丈夫";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "我（女）、妻子";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "孙子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "孙女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "儿子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "女儿";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "儿子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "女儿";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "女婿";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "21"://大哥
                        {
                            decode += "大哥";
                            result = "大哥";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "侄子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "侄女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大哥";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姐";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "我（男）、大哥、小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "我（女）、大姐、小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "嫂子";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "22"://大姐
                        {
                            decode += "大姐";
                            result = "大姐";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "外甥";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "外甥女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大哥";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姐";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "我（男）、大哥、小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "我（女）、大姐、小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "姐夫";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "31"://小弟
                        {
                            decode += "小弟";
                            result = "小弟";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "侄子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "侄女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "我（男）、大哥、小弟";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "我（女）、大姐、小妹";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "弟妹";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "32"://小妹
                        {
                            decode += "小妹";
                            result = "小妹";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "外甥";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "外甥女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "我（男）、大哥、小弟";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "我（女）、大姐、小妹";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "妹夫";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "41"://丈夫
                        {
                            decode += "丈夫";
                            result = "丈夫";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "公公";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "婆婆";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "儿子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "女儿";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大伯子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姑子";

                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小叔子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姑子";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "我（女）";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "42"://妻子
                        {
                            decode += "妻子";
                            result = "妻子";
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; encodeStr = encodeStr.Substring(2, encodeStr.Length - 2))
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "岳父";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "岳母";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "儿子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "女儿";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大舅子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姨子";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小舅子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姨子";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "我（男）";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                }
            }
            decodeResult = decode;
            finalResult = result;
        }
        Person setCurrToEncodeStrPos(string encodeStr)
        {
            Person p = me_startPoi;
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 0;)
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://我
                        {
                            p = p._me;
                            break;
                        }
                    case "01"://父亲
                        {
                            p = p._father;
                            break;
                        }
                    case "02"://母亲
                        {
                            p = p._mother;
                            break;
                        }
                    case "11"://儿子
                        {
                            p = p._son;
                            break;
                        }
                    case "12"://女儿
                        {
                            p = p._daughter;
                            break;
                        }
                    case "21"://大哥
                        {
                            p = p._elderBrother;
                            break;
                        }
                    case "22"://大姐
                        {
                            p = p._elderSister;
                            break;
                        }
                    case "31"://小弟
                        {
                            p = p._littleBrother;
                            break;
                        }
                    case "32"://小妹
                        {
                            p = p._littleSister;
                            break;
                        }
                    case "41"://丈夫
                        {
                            p = p._husband;
                            break;
                        }
                    case "42"://妻子
                        {
                            p = p._husband;
                            break;
                        }
                }
                if (encodeStr.Length > 2) 
                { 
                unit_0 = encodeStr.Substring(0, 2); 
                }
            }
            return p;
        }
        Person setCurrToEncodeStrPosGoingToAdd(string encodeStr)
        {
            Person p = me_startPoi;
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 2; )
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://我
                        {
                            p = p._me;
                            break;
                        }
                    case "01"://父亲
                        {
                            p = p._father;
                            break;
                        }
                    case "02"://母亲
                        {
                            p = p._mother;
                            break;
                        }
                    case "11"://儿子
                        {
                            p = p._son;
                            break;
                        }
                    case "12"://女儿
                        {
                            p = p._daughter;
                            break;
                        }
                    case "21"://大哥
                        {
                            p = p._elderBrother;
                            break;
                        }
                    case "22"://大姐
                        {
                            p = p._elderSister;
                            break;
                        }
                    case "31"://小弟
                        {
                            p = p._littleBrother;
                            break;
                        }
                    case "32"://小妹
                        {
                            p = p._littleSister;
                            break;
                        }
                    case "41"://丈夫
                        {
                            p = p._husband;
                            break;
                        }
                    case "42"://妻子
                        {
                            p = p._husband;
                            break;
                        }
                }
                if (encodeStr.Length > 2)
                {
                    unit_0 = encodeStr.Substring(0, 2);
                }
            }
            return p;
        }
        #endregion

        //增加
        private Person creatPerson(bool isDead)
        {
            Person p = null;
            //输入Person信息
            if (isDead)
            {
                string name = Console.ReadLine();
                string sex = Console.ReadLine();
                string encodeStr = Console.ReadLine();
                string birthday = Console.ReadLine();
                string deathday = Console.ReadLine();
                string bornPlace = null;
                string eduBackground = null;
                string job = null;
                string jobPosition = null;
                p = new Person(name, sex, encodeStr, birthday, deathday, bornPlace, eduBackground, job, jobPosition);
            }
            else
            {
                string name = Console.ReadLine();
                string sex = Console.ReadLine();
                string encodeStr = Console.ReadLine();
                string birthday = Console.ReadLine();
                string bornPlace = null;
                string eduBackground = null;
                string job = null;
                string jobPosition = null;
                p = new Person(name, sex, encodeStr, birthday, bornPlace, eduBackground, job, jobPosition);
            }
            return p;
        }//输入模块
        public bool addPerson(bool isDead, string encodeStr)
        {
            Person p = creatPerson(isDead);
            curr = setCurrToEncodeStrPosGoingToAdd(encodeStr);
            string unit = encodeStr.Substring(0, 2);
            switch (unit)
            {
                case "01":
                case "02":
                    {
                        Person.setParentAndKid(p, curr);
                        break;
                    }
                case "11":
                case "12":
                    {
                        Person.setParentAndKid(curr, p);
                        break;
                    }
                case "21":
                case "22":
                case "31":
                case "32":
                    {
                        Person.setBrotherAndSister(curr, p);
                        break;
                    }
                case "41":
                case "42":
                    {
                        Person.setHusbandAndWife(curr, p);
                        break;
                    }
            }
            memberCount++;
            return true;
        }
        //查找
        public bool findPerson(HowToFind howToFind, string input, List<Person> findedPersons)
        {
            if (howToFind == HowToFind.ByNAME)
            {
                string name = input;
                List<Person> result = new List<Person>();
                BFS_withoutSetVisited(me_startPoi, result);
                foreach(var i in result)
                {
                    if (i.name == input)
                    {

                    }
                }
                //
            }
            else if (howToFind == HowToFind.ByENCODE)
            {
                string encodeStr = input;
                List<Person> result = new List<Person>();
                BFS_withoutSetVisited(me_startPoi, result);
                foreach (var i in result)
                {
                    if (i.encodeStr == input)
                    {
                        findedPersons.Add(i);
                    }
                }
            }
            return true;
        }
        private void showOnePersonMessage(Person p)
        {
            Console.WriteLine(p.name);
            Console.WriteLine(p.sex);
            Console.WriteLine(p.age);
            Console.WriteLine(p.birthday);
            if (p.isDead == true) 
            {
                Console.WriteLine(p.deathday);
            }
            //Console.WriteLine(p.isDead);
            Console.WriteLine(p.bornPlace);
            Console.WriteLine(p.eduBackground);
            Console.WriteLine(p.job);
            Console.WriteLine(p.jobPosition);
            Console.WriteLine(p.level);
            Console.WriteLine(p.encodeStr);
            //Console.WriteLine(p.isVisited);
        }
        private void showAllPersonMessage(List<Person> persons)
        {
            foreach(var i in persons)
            {
                showOnePersonMessage(i);
            }
        }
        //删除
        private bool delPerson()
        {

            return true;

        }
        public bool delPerson(string encodeStr)
        {
            if (memberCount > 0)
            {
                memberCount--;

            }
            return true;
        }
        //public bool delPerson(string name)
        //{
        //    if (memberCount > 0)
        //    {
        //        memberCount--;
        //    }
        //    return true;

        //}
        //修改
        private bool altPerson()
        {
            return true;

        }
        public bool altPerson(string encodeStr)
        {
            return true;

        }

        //public bool altPerson(string name)
        //{
        //    return true;

        //}

    }

    class Person
    {
        #region//属性
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string birthday { get; set; }
        public string deathday { get; set; }
        public bool isDead { get; set; }
        public string bornPlace { get; set; }//出生地
        public string eduBackground { get; set; }//教育背景
        public string job { get; set; }
        public string jobPosition { get; set; }//职位
        public int level { get; set; }//家庭地位等级？可用于树结构
        public string encodeStr { get; set; }//关系编码

        public bool isVisited { get; set; }//该节点是否被访问过

        #endregion

        #region//亲戚关系
        public Person _me;             //encode:00
        public Person _father;         //encode:01
        public Person _mother;         //encode:02
        public Person _son;            //encode:11
        public Person _daughter;       //encode:12
        public Person  _elderBrother;   //encode:21
        public Person _elderSister;    //encode:22
        public Person  _littleBrother;  //encode:31
        public Person  _littleSister;   //encode:32
        public Person _husband;        //encode:41
        public Person  _wife;           //encode:42
        #endregion
        #region//关系编码
        /*
         * 基础关系：最短编码
         * 
         * 我 00
         * 父亲 01
         * 母亲 02
         * 儿子 11
         * 女儿 12
         * 大哥 21
         * 大姐 22
         * 小弟 31
         * 小妹 32
         * 丈夫 41
         * 妻子 42
         * 
         * 扩展关系：最短编码
         * 
         * 爷爷 父亲的父亲 0101
         * 奶奶 父亲的母亲 0102
         * 我（男）、大哥、小弟 父亲的儿子 0111
         * 我（女）、大姐、小妹 父亲的女儿 0112
         * 伯父 父亲的大哥 0121
         * 姑妈 父亲的大姐 0122
         * 叔叔 父亲的小弟 0131
         * 小姑 父亲的小妹 0132
         * 母亲 父亲的妻子 0142
         * 
         * 外公 母亲的父亲 0201
         * 外婆 母亲的母亲 0202
         * 我（男）、大哥、小弟 母亲的儿子 0211
         * 我（女）、大姐、小妹 母亲的女儿 0212
         * 大舅 母亲的大哥 0221
         * 小舅 母亲的大姐 0222
         * 大姨 母亲的小弟 0231
         * 小姨 母亲的小妹 0232
         * 父亲 母亲的丈夫 0241
         * 
         * 我(男)、老公 儿子的父亲 1101
         * 我(女)、老婆 儿子的母亲 1102
         * 孙子 儿子的儿子 1111
         * 孙女 儿子的女儿 1112
         * 儿子 儿子的大哥 1121
         * 女儿 儿子的大姐 1122
         * 儿子 儿子的小弟 1131
         * 女儿 儿子的小妹 1132
         * 儿媳妇 儿子的妻子 1142
         * 
         * 我(男)、老公 女儿的父亲 1201
         * 我(女)、老婆 女儿的母亲 1202
         * 孙子 女儿的儿子 1211
         * 孙女 女儿的女儿 1212
         * 儿子 女儿的大哥 1221
         * 女儿 女儿的大姐 1222
         * 儿子 女儿的小弟 1231
         * 女儿 女儿的小妹 1232
         * 女婿 女儿的丈夫 1241
         * 
         * 父亲 大哥的父亲 2101
         * 母亲 大哥的母亲 2102
         * 侄子 大哥的儿子 2111
         * 侄女 大哥的女儿 2112
         * 大哥 大哥的大哥 2121
         * 大姐 大哥的大姐 2122
         * 我（男）、大哥、小弟 大哥的小弟 2131
         * 我（女）、大姐、小妹 大哥的小妹 2132
         * 嫂子 大哥的妻子 2142
         * 
         * 父亲 大姐的父亲 2201
         * 母亲 大姐的母亲 2202
         * 外甥 大姐的儿子 2211
         * 外甥女 大姐的女儿 2212
         * 大哥 大姐的大哥 2221
         * 大姐 大姐的大姐 2222
         * 我（男）、大哥、小弟 大姐的小弟 2231
         * 我（女）、大姐、小妹 大姐的小妹 2232
         * 姐夫 大姐的丈夫 2241
         * 
         * 父亲 小弟的父亲 3101
         * 母亲 小弟的母亲 3102
         * 侄子 小弟的儿子 3111
         * 侄女 小弟的女儿 3112
         * 我（男）、大哥、小弟 小弟的大哥 3121
         * 我（女）、大姐、小妹 小弟的大姐 3122
         * 小弟 小弟的小弟 3131
         * 小妹 小弟的小妹 3132
         * 弟妹 小弟的妻子 3142
         * 
         * 父亲 小妹的父亲 3201
         * 母亲 小妹的母亲 3202
         * 外甥 小妹的儿子 3211
         * 外甥女 小妹的女儿 3212
         * 我（男）、大哥、小弟 小妹的大哥 3221
         * 我（女）、大姐、小妹 小妹的大姐 3222
         * 小弟 小妹的小弟 3231
         * 小妹 小妹的小妹 3232
         * 妹夫 小妹的丈夫 3241
         * 
         * 公公 丈夫的父亲 4101
         * 婆婆 丈夫的母亲 4102
         * 儿子 丈夫的儿子 4111
         * 小姑子 丈夫的女儿 4112
         * 大伯子 丈夫的大哥 4121
         * 大姑子 丈夫的大姐 4122
         * 小叔子 丈夫的小弟 4131
         * 小姑子 丈夫的小妹 4132
         * 我（女） 丈夫的妻子 4142
         *
         * 岳父 妻子的父亲 4201
         * 岳母 妻子的母亲 4202
         * 儿子 妻子的儿子 4211
         * 女儿 妻子的女儿 4212
         * 大舅子 妻子的大哥 4221
         * 大姨子 妻子的大姐 4222
         * 小舅子 妻子的小弟 4231
         * 小姨子 妻子的小妹 4232
         * 我（男） 妻子的丈夫 4241
         */
        #endregion

        #region//构造方法
        public Person()
        {
            _me = this;
            _father = null;
            _mother = null;
            _son = null;
            _daughter = null;
            _elderBrother = null;
            _elderSister = null;
            _littleBrother = null;
            _littleSister = null;
            //level

        }
        public Person(string name, int age, string sex, string encodeStr)
            : this()
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.encodeStr = encodeStr;

            this.isVisited = false;
        }
        public Person(string name, string sex, string encodeStr, string birthday, string deathday, string bornPlace = null, string eduBackground = null, string job = null, string jobPosition = null)
            : this()
        {
            this.isDead = true;
            this.name = name;
            this.sex = sex;
            this.encodeStr = encodeStr;
            this.birthday = birthday;
            this.deathday = deathday;
            string birthyear = birthday.Substring(0, 4);
            string deathyear = deathday.Substring(0, 4);
            this.age = int.Parse(deathyear) - int.Parse(birthyear);
            this.bornPlace = bornPlace;
            this.eduBackground = eduBackground;
            this.job = job;
            this.jobPosition = jobPosition;

            this.isVisited = false;

        }
        public Person(string name, string sex, string encodeStr, string birthday, string bornPlace = null, string eduBackground = null, string job = null, string jobPosition = null)
            : this()
        {
            this.isDead = false;
            this.name = name;
            this.sex = sex;
            this.encodeStr = encodeStr;
            this.birthday = birthday;
            string birthyear = birthday.Substring(0, 4);
            string nowyear = DateTime.Now.Year.ToString();
            this.age = int.Parse(nowyear) - int.Parse(birthyear);
            this.bornPlace = bornPlace;
            this.eduBackground = eduBackground;
            this.job = job;
            this.jobPosition = jobPosition;

            this.isVisited = false;

        }

        #endregion



        #region//设置亲戚关系
        private void setToBeFatherOf(Person p)
        {
            p._father=this;
            if (p.sex == "male")
            {
                this._son=p;
            }
            else if (p.sex == "female")
            {
                this._daughter=p;
            }
        }
        private void setToBeMotherOf(Person p)
        {
            p._mother=this;
            if (p.sex == "male")
            {
                this._son=p; ;
            }
            else if (p.sex == "female")
            {
                this._daughter=p; ;
            }
        }
        private void setToBeSonOf(Person p)
        {
            p._son=this; 
            if (p.sex == "male")
            {
                this._father=p;
            }
            else if (p.sex == "female")
            {
                this._mother=p;
            }
        }
        private void setToBeDaughterOf(Person p)
        {
            p._daughter=this;
            if (p.sex == "male")
            {
                this._father=p;
            }
            else if (p.sex == "female")
            {
                this._mother=p;
            }
        }
        private void setToBeElderBrotherOf(Person p)
        {
            p._elderBrother=this;
            if (p.sex == "male")
            {
                this._littleBrother=p;
            }
            else if (p.sex == "female")
            {
                this._littleSister=p;
            }
        }
        private void setToBeElderSisterOf(Person p)
        {
            p._elderSister=this;
            if (p.sex == "male")
            {
                this._littleBrother=p;
            }
            else if (p.sex == "female")
            {
                this._littleSister=p;
            }
        }
        private void setToBeLittleBrotherOf(Person p)
        {
            p._littleBrother=this;
            if (p.sex == "male")
            {
                this._elderBrother=p;
            }
            else if (p.sex == "female")
            {
                this._elderSister=p;
            }
        }
        private void setToBeLittleSisterOf(Person p)
        {
            p._littleSister=this;
            if (p.sex == "male")
            {
                this._elderBrother=p;
            }
            else if (p.sex == "female")
            {
                this._elderSister=p;
            }
        }
        private void setToBeHusbandOf(Person p)
        {
            this._wife=p;
            p._husband=this;
        }
        private void setToBeWifeOf(Person p)
        {
            this._husband=p;
            p._wife=this;
        }
        public static bool setHusbandAndWife(Person husband, Person wife)
        {
            if (husband.sex == "male" && wife.sex == "female")
            {
                husband.setToBeHusbandOf(wife);
                return true;
            }
            else if (husband.sex == "female" && wife.sex == "male")
            {
                husband.setToBeWifeOf(wife);
                return true;
            }
            else
            {
                Console.WriteLine("Person::setHusbandAndWife()输入有误");
                return false;
            }
        }
        public static bool setParentAndKid(Person parent, Person kid)
        {
            if (parent.sex == "male")
            {
                parent.setToBeFatherOf(kid);
                return true;
            }
            else if (parent.sex == "female")
            {
                parent.setToBeMotherOf(kid);
                return true;
            }
            else
            {
                Console.WriteLine("Person::setParentAndKid()输入有误");
                return false;
            }
        }
        public static bool setBrotherAndSister(Person elder, Person younger)
        {
            if (elder.age >= younger.age)
            {
                if (elder.sex == "male")
                {
                    elder.setToBeElderBrotherOf(younger);
                }
                else if (elder.sex == "female")
                {
                    elder.setToBeElderSisterOf(younger);
                }
                return true;
            }
            else if (elder.age < younger.age)
            {
                if (elder.sex == "male")
                {
                    elder.setToBeLittleBrotherOf(younger);
                }
                else if (elder.sex == "female")
                {
                    elder.setToBeLittleSisterOf(younger);
                }
                return true;
            }
            else if ((elder.birthday).CompareTo(younger.birthday) <= 0)
            {
                if (elder.sex == "male")
                {
                    elder.setToBeElderBrotherOf(younger);
                }
                else if (elder.sex == "female")
                {
                    elder.setToBeElderSisterOf(younger);
                }
                return true;
            }
            else if ((elder.birthday).CompareTo(younger.birthday) > 0)
            {
                if (elder.sex == "male")
                {
                    elder.setToBeLittleBrotherOf(younger);
                }
                else if (elder.sex == "female")
                {
                    elder.setToBeLittleSisterOf(younger);
                }
                return true;
            }
            else
            {
                Console.WriteLine("Person::setBrotherAndSister()输入有误");
                return false;
            }

        }
        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b;
            Console.WriteLine(a == b);

        }
    }
}
