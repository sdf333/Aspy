项目介绍：http://bytecarrot.com/aspy/

小工具用于查看网站session和cache，原作者已经很久不更新了。

2015.3.11
分支修复了对象序列化循环引用错误，以及添加了手动删除缓存功能。

使用方式：
1.Nuget命令行：Install-Package AspyPlus
2.MVC程序请在添加后在RouteConfig中添加：routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");
3.访问地址 /aspy.ashx