归纳WCF改用protobuf-net序列化的重点：

1、将WCF参数或结果用到的自订型别放到独立DLL专案，WCF Service及WCF Client改参照独立DLL
2、独立DLL、WCF Client、WCF Service都要参照protobuf-net（可用NuGet安装）
3、在自订型别加上[ProtoContract]、[ProtoMember]
4、修改WCF Service设定，最终要为Service Endpoint加上behaviorConfiguration
5、protonet-buf不支援阵列型别的序列化，若WCF参数或传回值用到阵列， 需改用List<T>或IEnumerable<T> ，并记得在参照WCF服务时修改Collection Type 为 System.Collections.Generic.List.
6、确认WCF Client的Endpoint设定也加上behaviorConfiguration
7、wcf服务需要在IIS中部署，并且要添加net.tcp绑定。