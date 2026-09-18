微软核心dll。

1.Microsoft.Csharp
2.Microsoft.Data.SqlClient
3.System
4.System.Configuration
5.System.Core
6.System.Data
7.System.Data.DataSetExtensions
8.System.Drawing
9.Systrm.Transactions
10.System.Xml
11.System.Xml.Lin1
12.WindowsBase


第一类：数据库与数据处理
Microsofy.Data.SqlClient:用于与SQL Server 数据库进行通信的核心驱动。有这个，实体类才能通过ADO.NET等方式直接从数据库读取或写入数据，
ADO.NET与数据库之间的通信：
C#代码->调用ADO.NET类库：SqlConnection.Open()（System.Daya.SqlClient/Microsoft.Data.SqlClient）->ADO.NET进行封装，底层调用操作系统的网络栈发送TCP包（默认端口1433）到数据库服务器。
SQL Server服务在Windows中运行，服务名：MSSQLSERVER监听在1433端口上，收到TCP的包，SQL Server服务解析包里的SQL语句，执行查询，把结果再封装成TCP回传给ADO.NET.
ADO.NET收到回传数据，转换成DataTable或DataReader返回代码。

DataTable与DataReader区别：
特性	DataTable	DataReader
连接模式	断开连接（Disconnected）——数据一次性拉到内存后，数据库连接即可关闭	保持连接（Connected）——读取期间数据库连接必须一直开着
读取方式	可以随意前后滚动、按索引访问任意行	只读、只向前（Read-Only, Forward-Only），像磁带一样只能往下走，不能回头
性能	较慢，因为要一次性把所有数据加载到内存	非常快，逐行流式读取，内存占用极小
能否修改	可以修改数据，并通过 DataAdapter 写回数据库	不能修改，只能读
数据量限制	受内存限制，数据量太大容易撑爆内存	几乎无限制，适合百万级大数据量
典型用法	DataAdapter.Fill(dataTable)	SqlCommand.ExecuteReader()

System.Data/System.Data.DataSetExtensions:
这是.NET基础的数据处理库，配合SQLClient使用，其中包含了DataTable\DataSet等经典的数据集结构

System.Configuration:
用于读取系统的配置文件，比如数据库链接字符串app.config里的链接配置

第二部分：.NET基础框架

System/System.Core:.NET最核心的库。提供字符串处理、集合（List,Dictionary）、日期时间（DataTime）、LINQ查询等最基本功能。

System.Xml/System.Xml.Linq:用于处理和解析XML格式的数据。用于处理DataSet.Xsd文件，因为其本质是XML文件。

System.Transations:用于管理数据库事务，比如在处理某个逻辑时包含多重逻辑，这是一个事务，要么同时成功，要么同时失败

第三部分：
System.Drawing/WindowsBase:这两个库是用于windows界面（UI）或图片处理相关内容。比如处理dashboard的相关内容。

Microsoft.CodeAnalysis.Analyzers：这是开发工具，用于写代码时进行实时的代码质量检查和提示，与实际运行业务无关。