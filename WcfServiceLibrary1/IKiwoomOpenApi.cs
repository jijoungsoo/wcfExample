﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WcfServiceLibrary
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 인터페이스 이름 "IService1"을 변경할 수 있습니다.
    [ServiceContract]
    public interface IKiwoomOpenApi
    {
        [OperationContract]
        string GetData(int value);



        [OperationContract]
        string 주식기본정보_현재가(String 주식종목);


        [OperationContract]
        [WebGet(UriTemplate="test", ResponseFormat = WebMessageFormat.Xml)]
        string test();

        // TODO: 여기에 서비스 작업을 추가합니다.
    }

    // 아래 샘플에 나타낸 것처럼 데이터 계약을 사용하여 복합 형식을 서비스 작업에 추가합니다.
    // XSD 파일을 프로젝트에 추가할 수 있습니다. 프로젝트를 빌드한 후 프로젝트에 정의된 데이터 타입을 네임스페이스 "WcfServiceLibrary1.ContractType"와 함께 직접 사용할 수 있습니다.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
