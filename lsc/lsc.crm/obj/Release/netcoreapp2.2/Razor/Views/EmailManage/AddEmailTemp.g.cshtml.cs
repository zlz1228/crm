#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\AddEmailTemp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e48ab768d4a1435f4ef04706b43c8700970c466c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailManage_AddEmailTemp), @"mvc.1.0.view", @"/Views/EmailManage/AddEmailTemp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmailManage/AddEmailTemp.cshtml", typeof(AspNetCore.Views_EmailManage_AddEmailTemp))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e48ab768d4a1435f4ef04706b43c8700970c466c", @"/Views/EmailManage/AddEmailTemp.cshtml")]
    public class Views_EmailManage_AddEmailTemp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lsc.Model.EmailTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\AddEmailTemp.cshtml"
  
    ViewData["Title"] = "添加邮件模板";
    Layout = "~/Pages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(114, 1392, true);
            WriteLiteral(@"<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>添加邮件模板</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"">
        <div class=""layui-col-md6"">
            <form class=""layui-form"">
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">邮箱标题</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" class=""layui-input"" name=""Title"" placeholder=""请输入邮箱标题"" required lay-verify=""required"" autocomplete=""off"" />
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">邮件模板</label>
                    <div class=""layui-input-block"">
                        <textarea class=""layui-textarea"" name=""EmailContent"" rows=""30"" placeholder=""请输入邮件模板"" required lay-verify=""required""></textarea>
                    </div>
                </div>
                <div class=""");
            WriteLiteral(@"layui-form-item"">
                    <div class=""layui-input-block"">
                        <button class=""layui-btn"" lay-submit lay-filter=""*"">立即提交</button>
                        <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1523, 846, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer;
        layui.use(['form', 'layer','element'], function () {
            var form = layui.form;
            var element = layui.element;
            layer = layer;

            form.on('submit(*)', function (data) {

                $.post('/EmailManage/SaveEmailTemp',
                    data.field,
                    function(res) {
                        if (res.code == 1) {
                            layer.msg('保存成功', { icon: 6 });
                            window.location = '/EmailManage/EmailTemplateList';
                        } else {
                            layer.msg('保存失败', { icon: 5 });
                        }
                    });
                return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
            });
        });

    </script>
");
                EndContext();
            }
            );
            BeginContext(2372, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lsc.Model.EmailTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591