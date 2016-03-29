using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.IO;





namespace AutoConnectWebSite
{

    class Program
    {

        private static void fncGoUrl(string strURL)
        {
            System.Diagnostics.Process.Start(strURL);
        }

        private static void fncWailt(string strURL)
        {
            Console.ReadKey();
            //Console.WriteLine("----------If you want to go next press Enter---------");
            Console.WriteLine(strURL);
        }

        public static void DisplayTree(XmlNode node)
        {
            if (!node.HasChildNodes)
                Console.WriteLine(node.Value);
            else
                Console.WriteLine("<" + node.Name + ">");

            if (node.HasChildNodes)
            {
                node = node.FirstChild;
                while (node != null)
                {
                    DisplayTree(node);
                    node = node.NextSibling;
                }
            }
        }


        static void Main(string[] args)
        {

            //XmlDocument doc = null;
            string lvsXmlPath = "D:\\AutoWebsiteLauncher\\AutoWebsiteLauncher\\Url.xml";


            //XmlTextReader tr = new XmlTextReader("http://hahakbs.dothost.co.kr/rss");
            //XmlDocument xdoc = new XmlDocument();
            //xdoc.Load(tr);
            //DisplayTree(xdoc.DocumentElement);
            //tr.Close();
            

            //string lvsXmlPath2 = "D:\\_MY_Data\\AutoConnectWebSite DotNet\\AutoConnectWebSite\\sample.xml";
            ////string filePath = @"..\..\booklist.xml";
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load(lvsXmlPath2);

            //XmlElement eBook = xDoc.DocumentElement;
            //XmlElement eFirstBook = (XmlElement)eBook.FirstChild;
            //XmlNodeList nlChilds = eFirstBook.ChildNodes;

            //for (int i = 0; i < nlChilds.Count; i++)
            //{
            //    XmlElement eChild = (XmlElement)nlChilds[i];
            //    Console.WriteLine(eChild.Name + ":" + eChild.InnerText);
            //}



            //System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(lvsXmlPath);
            //string contents = "";
            //while (reader.Read())
            //{
            //    reader.MoveToContent();
            //    if (reader.NodeType == System.Xml.XmlNodeType.Element)
            //        contents += "<" + reader.Name + ">\n";
            //    if (reader.NodeType == System.Xml.XmlNodeType.Text)
            //        contents += reader.Value + "\n";
            //}
            //Console.Write(contents);



            //XmlDocument doc2 = new XmlDocument();
            //doc2.Load(lvsXmlPath);

            //// Create an XmlNamespaceManager to resolve the default namespace.
            //XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc2.NameTable);

            //// Select and display all book titles.
            //XmlNodeList nodeList;
            //XmlElement root2 = doc2.DocumentElement;
            //nodeList = root2.SelectNodes("/Doc/document", nsmgr);

            //for (int i = 0; i < root2.ChildNodes.Count; i++)
            //{
            //    for (int attributesi = 0; attributesi < root2.ChildNodes[i].ChildNodes.Count; attributesi++)
            //    {
            //        Console.WriteLine(
            //        root2.ChildNodes[i].Attributes[attributesi].Value);
            //    }


            //}

            //fncWailt("");
            //fncWailt("");
            //fncWailt("");


            //string txtContents = File.ReadAllText(lvsXmlPath, UTF8Encoding.UTF8); //읽어오기
            //File.WriteAllText(lvsXmlPath, txtContents.Replace("&", "&amp;")); //에러 발송하는 문자 변환하여 저장

            XPathDocument doc1 = new XPathDocument(lvsXmlPath);
            XPathNavigator nav = doc1.CreateNavigator();
            XPathNodeIterator it = nav.Select("/Doc/document");

            XmlDocument doc = new XmlDocument();
            doc.Load(lvsXmlPath);
            XmlElement root = doc.DocumentElement;
            XmlNodeList node_list = root.ChildNodes;


            // while (it.MoveNext()) 
            // {

            for (int k = 0; k < it.Count; k++)
            {

                if (node_list.Item(k).Name == "document")
                {
                    XmlAttributeCollection c_attr = node_list.Item(k).Attributes;

                    if (c_attr.Item(0).Value == "N")
                    {

                    }
                    else
                    {

                    }

                    fncWailt(c_attr.Item(1).Value);

                    fncGoUrl(c_attr.Item(1).Value);

                }

            }

            //}


        }

    }
}


/*
            //http://www.netpoints.co.kr/html/front/neo_earn/visit/visitList.jsp

            fncWailt();

            fncGoUrl("http://www.presstv.com/default.aspx");

            fncWailt();


            //옥션 이벤트

            fncGoUrl("http://event.auction.co.kr/event2009/everydaypoint/default.asp");

            fncWailt();

            fncGoUrl("http://promotion.auction.co.kr/promotion/MD/eventview.aspx?txtMD=02539EB1FF");

            fncWailt();

            fncGoUrl("http://review.auction.co.kr/Customer/Event/lottoframe.aspx");

            fncWailt();

            fncGoUrl("http://clubw.auction.co.kr/v3/");

            fncWailt();

            fncGoUrl("http://promotion.auction.co.kr/promotion/MD/eventview.aspx?txtMD=0277A21DE9&frm=widescreen2");

            fncWailt();

            fncGoUrl("http://promotion.auction.co.kr/promotion/MD/eventview.aspx?txtMD=027C41E9AF");

            fncWailt();

            fncGoUrl("http://openshopping.auction.co.kr/event/0912/event.aspx");

            fncWailt();

            
            //넷포인트 kssyy
            fncGoUrl("http://www.netpoints.co.kr/html/front/member/FP_MemberLogin.jsp?MUSER_ID=kssyy&PASSWD=npj1130&URL=/html/front/neo_earn/earn.jsp");

            fncWailt();

            //넷포인트 gyjeon
            fncGoUrl("http://www.netpoints.co.kr/html/front/member/FP_MemberLogin.jsp?MUSER_ID=gyjeon&PASSWD=npj1130&URL=/html/front/neo_earn/earn.jsp");

            fncWailt();

            //넷포인트 gyjeon1
            fncGoUrl("http://www.netpoints.co.kr/html/front/member/FP_MemberLogin.jsp?MUSER_ID=gyjeon1&PASSWD=npj1130&URL=/html/front/neo_earn/earn.jsp");

            fncWailt();

            //넷포인트 gyjeon2
            fncGoUrl("http://www.netpoints.co.kr/html/front/member/FP_MemberLogin.jsp?MUSER_ID=gyjeon2&PASSWD=npj1130&URL=/html/front/neo_earn/earn.jsp");

            fncWailt();

            //넷포인트sspirit
            fncGoUrl("http://www.netpoints.co.kr/html/front/member/FP_MemberLogin.jsp?MUSER_ID=sspirit&PASSWD=npj1130&URL=/html/front/neo_earn/earn.jsp");

            fncWailt();


            //아이템베이 바로가기
            fncGoUrl("http://www.itembay.com/Shortcut/Index.asp?strRedirectType=s");

            fncWailt();

            //로그아웃
            fncGoUrl("http://www.itembay.com/Member/ActMemberLogout.asp?fok=flogout");

            fncWailt();

            //아이템베이 바로가기
            fncGoUrl("http://www.itembay.com/Shortcut/Index.asp?strRedirectType=m");

            fncWailt();

            //로그아웃
            fncGoUrl("http://www.itembay.com/Member/ActMemberLogout.asp?fok=flogout");

            fncWailt();

            //아이템베이 바로가기
            fncGoUrl("http://www.itembay.com/Shortcut/Index.asp?strRedirectType=b");

            fncWailt();

            //로그아웃
            fncGoUrl("http://www.itembay.com/Member/ActMemberLogout.asp?fok=flogout");

            fncWailt();

            //아이템베이 바로가기
            fncGoUrl("http://www.itembay.com/Toolbar/index.asp?strRedirectType=Home");

            fncWailt();

            //로그아웃
            fncGoUrl("http://www.itembay.com/Member/ActMemberLogout.asp?fok=flogout");

            fncWailt();

            //아이템베이 바로가기
            fncGoUrl("http://www.itembay.com/Shortcut/Index.asp?strRedirectType=r");

            fncWailt();

            //로그아웃
            fncGoUrl("http://www.itembay.com/Member/ActMemberLogout.asp?fok=flogout");

            fncWailt();

            //아이템베이 바로가기
            fncGoUrl("http://www.itembay.com/Shortcut/Index.asp?strRedirectType=p");

            fncWailt();

            //fncGoUrl("http://shopping.daum.net/event/priceeyemain.daum?luckynum=H0VYPR#tab02");
            
            //fncWailt();
            
            //fncGoUrl("http://www.devpia.com/dExpert/index.aspx?Op=tall&Ob=A");

            fncGoUrl("http://gift.paran.com/event/all.asp?Posi=Home&AdType=Tag&Mode=Event&SMode=All&Cmd=&Cate_L=&Cate_S=&Page=1");

            fncGoUrl("http://www.smartplanet.com/");

            fncGoUrl("http://www.okgosu.net/zbxe/deveng");

            fncGoUrl("http://normalog.com/category/");
            
            fncWailt();

            fncGoUrl("http://channel9.msdn.com/");

            fncGoUrl("http://social.msdn.microsoft.com/Forums/ko-kr/categories/");

            fncGoUrl("http://msdn.microsoft.com/ko-kr/magazine/default.aspx");

            fncGoUrl("http://silverlight.net/riaservices/");

            fncGoUrl("http://www.codeplex.com/");

            fncWailt();

            fncGoUrl("http://www.devpia.com/dExpert/?Op=b6&Detail=2");

            fncGoUrl("http://www.taeyo.pe.kr/");

            fncGoUrl("http://www.okjsp.pe.kr/");

            //fncGoUrl("http://www.devpia.com/");

            fncGoUrl("http://www.hoons.kr/");

            fncWailt();

            fncGoUrl("http://www.codeproject.com/");

            fncGoUrl("http://sourceforge.net/");

            fncGoUrl("http://dev.naver.com/");

            fncGoUrl("http://www.simpleisbest.net/");

            fncGoUrl("http://code.google.com/hosting/");

            fncGoUrl("http://www.w3schools.com/");

            fncWailt();

            fncGoUrl("http://www.waglwagl.net/");

            //fncGoUrl("http://cafe.naver.com/teamsystem");

            fncGoUrl("http://www.cooolguy.net/");

            fncGoUrl("http://blogs.msdn.com/popcon/default.aspx");

            fncGoUrl("http://www.microsoft.com/web/");

            fncGoUrl("http://code.msdn.microsoft.com/Project/ProjectDirectory.aspx?TagName=WebAppToolkits");

            fncWailt();


            fncGoUrl("http://www.koreaherald.co.kr/service/opencast/");

            fncGoUrl("http://koreatimes.co.kr/");

            fncGoUrl("http://www.arirang.co.kr/");

            fncWailt();

            fncGoUrl("http://www.nytimes.com/");

            fncGoUrl("http://www.latimes.com/");

            fncGoUrl("http://www.cnn.com/");

            fncGoUrl("http://englishcentral.com/en/videos");

            //fncGoUrl("http://www.voanews.com/");

            fncGoUrl("http://www.myvoa.com/");

            fncWailt();

            fncGoUrl("http://www.bbc.co.uk/?ok");

            fncGoUrl("http://www.theaustralian.news.com.au/");

            fncGoUrl("http://www.bbc.co.uk/worldservice/learningenglish/language/wordsinthenews/");

            //fncGoUrl("http://www.koreatimes.co.kr/www/LT/learningtimes.asp");

            fncGoUrl("http://moneywatch.bnet.com/");

            //fncGoUrl("http://www.eby0579.com/bill/main.asp");

            fncWailt();

            fncGoUrl("http://www.workingus.com/");

            //okcashbag
            //fncGoUrl("http://en-mall.enclean.com/Event.do?cmd=ThreeColorEvent1");

            fncWailt();

            //Spicus
            fncGoUrl("http://www.spicus.com/community/event_list.asp?ing=y");

            //포커스
            fncGoUrl("http://event.fnn.co.kr/ingmain1.asp?isIngEvent=y&isFocusEvent=f");

            //메트로
            fncGoUrl("http://www.metroseoul.co.kr/");

            //능률영어사 이벤트
            fncGoUrl("http://www.et-house.com/html/common/custom/event_ing.asp");

            //Yes24
            fncGoUrl("http://www.yes24.com/eventworld/main.aspx");

            //맥스무비 출석하기
            fncGoUrl("http://www.maxmovie.com/event/");

            //우리아이
            fncGoUrl("http://www.urii.com/event/event.do?cmd=activeList");

            //남양아이
            fncGoUrl("http://www.namyangi.com/event/event_list.asp");


            //SBS 고릴라 //gyjeon1 j1130
            fncGoUrl("http://gorealra.sbs.co.kr/g2/event_list.jsp");

            //PointPark //gyjeon jj1130
            fncGoUrl("http://www.pointpark.com/html/ma/chargeMain.html");

            //Thiat
            fncGoUrl("http://www.thiat.com");

*/