## DBCHM-最简单、最实用的数据库表列批注维护工具

DBCHM支持SqlServer/MySql/Oracle/PostgreSQL等数据库的表列批注维护管理。

## DBCHM有以下几个功能
- 表，列的批注可以编辑保存到数据库。
- 表，列的批注支持通过pdm文件导入的方式进行更新到数据库。
- 基于数据库中的表列结构(列ID/列名/数据类型/长度/精度/是否可以为null/默认值/是否自增/是否是主键/列描述)，导出数据库CHM文档。
## 使用前提/注意事项
- 电脑需`htmlhelp.exe`，见附件（注：需安装到任意盘符下的 Program Files 文件夹）
- 电脑需`.net framework 4.5`
- 登陆账号要给予`sa级别`的权限，不然表结构查询权限不足，会查不出来数据
- 源码编印环境：`Visual Studio 2017 以上`版本
- 使用的MJTop.Data，源码获取方式：见 群共享 → 框架_类库_源码 → `MJTop.Data源码(DBCHM引用该组件)` 
- 对于表列批注，支持中文与英文，不支持gbk之外的不兼容编码。目前：如需要支持其他语言，Language(HHP中的一个属性)/html字符编码/html文件编码/html中的文字，相对应相兼容才可)；不过也不排除有更好的其他解决办法，如果有，欢迎进群讨论，共同完善该工具！

## DBCHM社群
- QQ交流群：[![加入QQ群](https://img.shields.io/badge/QQ群-132941648-blue.svg)](http://shang.qq.com/wpa/qunwpa?idkey=43619cbe3b2a10ded01b5354ac6928b30cc91bda45176f89a191796b7a7c0e26) ，推荐点击按钮入群，当然如果无法成功操作，请自行搜索群号132941648进行添加 ），其它疑问或idea欢迎入群交流！



DBCHM效果展示：
------------------------
###1.数据库连接管理
![数据库连接管理](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM001.png)

###2.表名模糊匹配
![表名模糊搜索](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM002.png)

###3.执行批注更新
![表批注更新](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM003.png)

###4.导出CHM文件
![导出CHM文件](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM004.png)

###5.表结构信息
![表结构信息](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/DBCHM005.png)


## 如果觉得还不错，请作者喝杯咖啡吧~
![捐赠二维码](https://gitee.com/lztkdr/DBCHM/raw/master/DBChm/Images/donate_qrcode.png)