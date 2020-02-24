using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 亲戚关系计算机_控制台_
{
    class FamilyGraph
    {
        Person me_startPoi;
        Person curr;
        int memberCount;
        public enum HowToFind { ByNAME, ByENCODE };
        public enum HowToDel { ByNAME, ByENCODE };
        public enum HowToAlt { ByNAME, ByENCODE };

        public FamilyGraph()
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
            else if (startPoi._mother != null)
            {
                p = startPoi._mother;
            }
            else if (startPoi._son != null)
            {
                p = startPoi._son;
            }
            else if (startPoi._daughter != null)
            {
                p = startPoi._daughter;
            }
            else if (startPoi._elderBrother != null)
            {
                p = startPoi._elderBrother;
            }
            else if (startPoi._elderSister != null)
            {
                p = startPoi._elderSister;
            }
            else if (startPoi._littleBrother != null)
            {
                p = startPoi._littleBrother;
            }
            else if (startPoi._littleSister != null)
            {
                p = startPoi._littleSister;
            }
            else if (startPoi._husband != null)
            {
                p = startPoi._husband;
            }
            else if (startPoi._wife != null)
            {
                p = startPoi._wife;
            }
            return p;
        }
        Person next(Person startPoi, Person nextPoi)
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
        }//目前亲戚编码只支持两层

        #region//深度遍历和广度遍历
        void DFS_withSetVisited(Person startPoi, List<Person> result)
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
            for (Person nextPoi = first(startPoi); nextPoi != null; nextPoi = next(startPoi, nextPoi))
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

                for (Person nextPoi = first(out_queue_item); nextPoi != null; nextPoi = next(out_queue_item, nextPoi))
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
            if (p._me != null)
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
        void setMark(Person p, bool mark)
        {
            p._me.isVisited = mark;
        }
        bool getMark(Person p)
        {
            return p._me.isVisited;
        }
        #endregion

        #region//编码解码以及根据编码移动指针
        void decode(string encodeStr, string decodeResult, string finalResult)
        {
            String decode = "";//迭代关系
            String result = "";//最终称呼
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 0;)
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://我
                        {
                            decode = result = "我";
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
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 2;)
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
                string gender = Console.ReadLine();
                string encodeStr = Console.ReadLine();
                string birthday = Console.ReadLine();
                string deathday = Console.ReadLine();
                string bornPlace = null;
                string eduBackground = null;
                string profession = null;
                string highestProfessionRank = null;
                p = new Person(name, gender, encodeStr, birthday, deathday, bornPlace, eduBackground, profession, highestProfessionRank);
            }
            else
            {
                string name = Console.ReadLine();
                string gender = Console.ReadLine();
                string encodeStr = Console.ReadLine();
                string birthday = Console.ReadLine();
                string bornPlace = null;
                string eduBackground = null;
                string profession = null;
                string highestProfessionRank = null;
                p = new Person(name, gender, encodeStr, birthday, bornPlace, eduBackground, profession, highestProfessionRank);
            }
            return p;
        }//输入模块
        public bool initMe()
        {
            me_startPoi = addPerson(false, "00");
            return true;
        }
        public Person addPerson(bool isDead, string encodeStr)
        {
            Person p = creatPerson(isDead);
            curr = setCurrToEncodeStrPosGoingToAdd(encodeStr);
            string unit = encodeStr.Substring(0, 2);
            switch (unit)
            {
                case "00":
                    {
                        break;
                    }
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
            return p;
        }
        //查找
        public bool findPerson(HowToFind howToFind, string input, List<Person> findedPersons)
        {
            if (howToFind == HowToFind.ByNAME)
            {
                string name = input;
                List<Person> BFSresult = new List<Person>();
                BFS_withoutSetVisited(me_startPoi, BFSresult);
                foreach (var i in BFSresult)
                {
                    if (i.name == input)
                    {
                        findedPersons.Add(i);
                    }
                }
                return true;
            }
            else if (howToFind == HowToFind.ByENCODE)
            {
                string encodeStr = input;
                List<Person> BFSresult = new List<Person>();
                BFS_withoutSetVisited(me_startPoi, BFSresult);
                foreach (var i in BFSresult)
                {
                    if (i.encodeStr == input)
                    {
                        findedPersons.Add(i);
                    }
                }
                return true;
            }
            return false;
        }
        private void showOnePersonMessage(Person p)
        {
            Console.WriteLine(p.name);
            Console.WriteLine(p.gender);
            Console.WriteLine(p.age);
            Console.WriteLine(p.birthday);
            if (p.isDead == true)
            {
                Console.WriteLine(p.deathday);
            }
            //Console.WriteLine(p.isDead);
            if (p.bornPlace != null)
            {
                Console.WriteLine(p.bornPlace);
            }
            if (p.eduBackground != null)
            {
                Console.WriteLine(p.eduBackground);
            }
            if (p.profession != null)
            {
                Console.WriteLine(p.profession);
            }
            if (p.highestProfessionRank != null)
            {
                Console.WriteLine(p.highestProfessionRank);
            }
            if (p.level != null)
            {
                Console.WriteLine(p.level);
            }
            if (p.encodeStr != null)
            {
                Console.WriteLine(p.encodeStr);
            }
            //Console.WriteLine(p.isVisited);
        }
        private void showAllPersonMessage(List<Person> persons)
        {
            foreach (var i in persons)
            {
                showOnePersonMessage(i);
            }
        }
        //删除
        public bool delPerson(HowToDel howToDel, string input)
        {
            if (howToDel == HowToDel.ByNAME)
            {
                List<Person> findedPersons = new List<Person>();
                findPerson(HowToFind.ByNAME, input, findedPersons);
                foreach (var i in findedPersons)
                {
                    Person p = setCurrToEncodeStrPosGoingToAdd(i.encodeStr);
                    Person q = setCurrToEncodeStrPos(i.encodeStr);
                    if (p == q && q == me_startPoi)
                    {
                        me_startPoi = null;
                    }
                    else
                    {
                        if (Person.isHusbandAndWife(p, q))
                        {
                            Person.unsetHusbandAndWife(p, q);
                        }
                        if (Person.isParentAndKid(p, q))
                        {
                            Person.unsetParentAndKid(p, q);
                        }
                        if (Person.isBrotherAndSister(p, q))
                        {
                            Person.unsetBrotherAndSister(p, q);
                        }
                    }
                }
                if (memberCount > 0)
                {
                    memberCount--;

                }
                return true;
            }
            else if (howToDel == HowToDel.ByENCODE)
            {
                List<Person> findedPersons = new List<Person>();
                findPerson(HowToFind.ByNAME, input, findedPersons);
                foreach (var i in findedPersons)
                {
                    Person p = setCurrToEncodeStrPosGoingToAdd(i.encodeStr);
                    Person q = setCurrToEncodeStrPos(i.encodeStr);
                    if (p == q && q == me_startPoi)
                    {
                        me_startPoi = null;
                    }
                    else
                    {
                        if (Person.isHusbandAndWife(p, q))
                        {
                            Person.unsetHusbandAndWife(p, q);
                        }
                        if (Person.isParentAndKid(p, q))
                        {
                            Person.unsetParentAndKid(p, q);
                        }
                        if (Person.isBrotherAndSister(p, q))
                        {
                            Person.unsetBrotherAndSister(p, q);
                        }
                    }
                }
                if (memberCount > 0)
                {
                    memberCount--;

                }
                return true;
            }


            return false;
        }
        //修改
        //private bool altPerson(HowToAlt howToDel, string input)
        //{
        //    return true;
        //}
    }
}
