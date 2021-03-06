# Lark4Net

a Lark project corresponding to Lark(<https://github.com/OpenLark/Lark).>

推荐使用项目：

+ https://github.com/reactiveui/refit
+ https://github.com/dotnetcore/WebApiClient
+ https://github.com/restsharp/RestSharp

考虑采用的组件：

+ https://github.com/serilog/serilog
+ https://github.com/App-vNext/Polly

## Principle

+ 所有的特性除了特定信息类的特性外，全部采用“子为准”原则。
+ URL信息相关的特性，采取“父+子”原则。
+ 默认请求body：Json字符串。
+ GET Http：
    - 未指定 headerAttribute时参数优先判断作为路径参数，其次作为查询字符串.
+ POST 
    - Http: 未指定 headerAttribute/querystringAttribute 时优先判断作为路径参数，其次作为查询字符串。
    - 复杂对象默认序列化：Json
+ 对Header/Querystring的值进行处理:  
    - 基础类型通过调用器ToString()方法;
    - 复杂类型将进行解构Deconstruction;
+ 不支持cookie操作.
+ NameAttribute is not work for PathParaAttribute .
+ pathparaattribute、headerAttribute 只支持简单值类型。
+ 为了避免不清晰的绑定关系：
    - 任一绑定到pathpara、querystring、header的参数不支持绑定到body。

## Feigh4Net Attribute  

## test step

1、In the appsetting.json, http port：6346

``` cmd
cd src\TestAspNet
dotnet run
```

2、In broswer,open：

``` cmd
http://localhost:6346/api/student/sayhello
http://localhost:6346/api/student
```
