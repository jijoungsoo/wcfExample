using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 클래스 이름 "Service1"을 변경할 수 있습니다.
    public class KiwoomOpenApiService : IKiwoomOpenApi
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string  주식기본정보_현재가(String 주식종목)
        {

            return "sdfsdf:"+주식종목;
            //axKHOpenAPI.SetInputValue("종목코드", txt종목코드.Text.Trim());
            //int nRet = axKHOpenAPI.CommRqData("주식기본정보", "OPT10001", 0, GetScrNum());

        }
        public String test()
        {
            return "asdffasdfasdf";
        }
    }
}
