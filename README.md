<p align="center">
   <img alt="DBCHM" src="https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/dbchm.png">
</p>
<p align="center">
  让数据库文档生成更简单一些吧！
</p>
<p align="center">
<img alt="visual studio 2019" src="https://img.shields.io/badge/Visual Studio-2019-blue.svg">
<img alt="csharp" src="https://img.shields.io/badge/ language-csharp-brightgreen.svg">
<img alt="license" src="https://img.shields.io/badge/license-MIT-blue.svg">
</p>

## DBCHM - 最简单、最实用的数据库文档生成工具

### 项目介绍

DBHCM 是一个对数据库文档生成工具！
该工具从最初支持chm文档格式开始，通过开源，大家集思广益，不断改进，又陆续支持word、excel、pdf、html、xml、markdown等文档格式的导出。本项目力求做最简单、最实用的数据库文档(字典)生成工具！

### 支持的数据库
- [x] SqlServer
- [x] MySQL
- [x] Oracle
- [x] PostgreSQL
- [x] DB2
- [x] SQLite

### 主要功能
- 对数据库表，列的批注(注释) 获取、编辑、保存。
- 文档信息包含：序号 | 列名 | 数据类型 | 长度 | 小数位数 | 主键 | 自增 | 允许空 | 默认值 | 列说明
- 根据文件导入进行更新批注(注释)：
    - 	[x] pdm 由`powerdesigner`设计数据库时产生。
    - 	[x] xml 由`visual studio`设置 实体类库的项目属性，勾选  XML文档文件 后生成项目时产生。
    - 	[x] xml 由`dbchm`的 XML导出 而产生。
- 支持的导出的文件格式：
    - 	[x] chm
    - 	[x] word
    - 	[x] excel
    - 	[x] pdf
    - 	[x] html
    - 	[x] xml
    - 	[x] markdown

### 效果展示

#### 1 数据库连接配置示例
![数据库连接配置](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM000.png)

#### 2 数据库连接管理
![数据库连接管理](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM001.png)

#### 3 表名模糊匹配
![表名模糊搜索](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM002.png)

#### 4 执行批注更新
![表批注更新](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM003.png)

#### 5 导出CHM文件
![导出CHM文件](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM004.png)

#### 6 表结构信息
![表结构信息](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM005.png)

### 7 更多格式的效果，请[下载体验](https://gitee.com/lztkdr/DBCHM/releases)哈:wink:！！

### 贡献者
- @[trycache](https://gitee.com/trycache) 主要开发者
- @[空无一物](https://gitee.com/lztkdr/) 先驱者

###  下载使用
- **[下载最新发行版本](https://gitee.com/lztkdr/DBCHM/releases)**，下载解压后，双击运行 `DBCHM.exe`。

- 新功能内测，Bug修复早知道，最新功能尝鲜，请在[![加入QQ群](https://img.shields.io/badge/QQ群-132941648-blue.svg)](http://shang.qq.com/wpa/qunwpa?idkey=43619cbe3b2a10ded01b5354ac6928b30cc91bda45176f89a191796b7a7c0e26)共享中获取:yum:！

### 其他工具
- [htmlhelp](https://gitee.com/lztkdr/DBCHM/attach_files)，生成chm文件时，需提前安装。
- [PDMToCHM](https://gitee.com/lztkdr/DBCHM/attach_files)，将PDM表结构文件导出到CHM文件。


### 常见问题
- 连接不上，怎么办？
	1. `连接数据库`界面填写的`连接信息`真的正确无误?
	2. `数据库服务器`有`防火墙/安全组`限制？
	3. 用 [Navicat Premium](https://gitee.com/lztkdr/DBCHM/attach_files) 连接数据库服务器试试！
	
- 连接数据库时，点了 `连接/测试` ，半天没响应？<br/>
&emsp;可能是连接远程数据库网络不好的原因，可以把`连接超时`设置的小一些。
	
- dbchm可以连接上，但显示不了数据怎么办？
	- 导出文档前，数据库使用账号要给予`root级别`的权限，非root级别账号连接，可能会出现`表数据显示不全`或数据查询因权限不足，会`查不出来数据`！
	- dbchm有Bug， [提Issue](https://gitee.com/lztkdr/DBCHM/issues/new) 或 [进群里](http://shang.qq.com/wpa/qunwpa?idkey=43619cbe3b2a10ded01b5354ac6928b30cc91bda45176f89a191796b7a7c0e26) 反馈。
	
- 表列的批注数据我想迁移，怎么办？
	1. 使用 dbchm 的 `XML导出`，对当前数据库的批注数据 就会导出一个xml文件。
	2. 点`数据连接`， 切换至 目标数据库连
	3. 再用`批注上载` 就可以选择刚刚的xml文件，如果数据库表结构相同，批注就会更新到目标数据库服上。
	
- 数据库比较老，如  `Sql Server 2000 `，怎么使用dbchm？
	1. 下载安装 [Navicat Premium](https://gitee.com/lztkdr/DBCHM/attach_files)
	2. 连接上老旧的数据库服务器，将数据库表结构脚本导出。
	3. 找一台高版本的数据库服务器，新建一个临时数据库，将导出的脚本导入。
	4. 然后用dbchm连接高版本的数据库服务器。
	
- Oracle数据库连上之后，一直未响应，像卡死了一样，怎么办？<br/>
&emsp;因为Oracle的 `列是否自增` 的sql语句，查询效率比较低，查的比较慢，没有卡死！！请耐心等待！！<br/>
&emsp;PS：如果你有更好方法，欢迎提供改善建议，助力:fist:该工具越来越好使！

- Oracle 11g、Oracle 12c测试连接显示“[28040]ORA-28040:没有匹配的验证协议”，目前群里及isuues反馈的问题

	可能11g以后的版本均会出现此项问题。

	该问题描述：navicat等工具可以直接连接，但是本程序连接不上有上述问题。

	目前想到的解决问题办法是，需在sqlnet.ora添加设置

		SQLNET.ALLOWED_LOGON_VERSION=8
		SQLNET.ALLOWED_LOGON_VERSION_SERVER=8
		SQLNET.ALLOWED_LOGON_VERSION_CLIENT=8

	参数值可设置8、10等，使用者可根据需要自行设置。
	
	![ORA-28040修改兼容](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/ORA-28040.png)
	
	注意：改完后其他相关用户的密码必须重置,或直接更新为原来的密码也是可以的（修改密码sql示例：alter user System identified by oldpassword;），此项操作慎重。

	要么在建库的初期添加此参数，然后重置相关密码；要么新建测试环境，进行此项操作。

	如果你有更好的解决方法，欢迎提供改善建议

### 交流
- QQ交流群：[![加入QQ群](https://img.shields.io/badge/QQ群-132941648-blue.svg)](http://shang.qq.com/wpa/qunwpa?idkey=43619cbe3b2a10ded01b5354ac6928b30cc91bda45176f89a191796b7a7c0e26) ，推荐点击按钮入群，当然如果无法成功操作，请自行搜索群号132941648进行添加 ），其它疑问或idea欢迎入群交流！