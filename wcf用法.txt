0 添加  System.ServiceModel 
1 服务契约 ServiceContract
2 操作契约 OperationContract
3 定义接口  服务契约  [ServiceContract]
4 实现接口类  
5 宿主程序 Host  
  1 控制台   App.config配置 +serviceHost  |    多个service 得配置
  2 iis     App.config配置  +  <%@ ServiceHost Service="BLL.UserInfoService"  %>  一个.svc的文件

6 client 调用
  1 通过svcUtil 工具生成代理类 和配置文件  endpoint
  2 直接 添加服务引用方式  生产代理类 client+ 配置文件 endpoint

7 [DataContract]     数据契约  成员[DataMember] 序列化  [DataMember]
  [MessageContract]  消息契约  [MessageHeader]  [MesageBodyMember]
  默认 是数据契约 放在 消息契约的body内部
 

-------------------------------------------------------------------------------

  注意：  还有可以  ChanelFactory 方式  建立 客户端 和服务器端的通信
ChanelFactory   chanelFactory=new  ChanelFactory("UserInfoService");
     IUserInfoService chanel=chanelFactory.CreateChanel()//通过通信工厂创建通信通道
     chanel.Add(1,2);
     (IClientChannel)chanel.Close(); //关闭
    
      //捕获异常 catch( communicationException  ex  |TimeoutException ex)
      (IClientChannel)chanel.Abort(); //关闭
     

   





 