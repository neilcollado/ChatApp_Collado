//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("ChatApp_Collado.Views.ConversationPage.xaml", "Views/ConversationPage.xaml", typeof(global::ChatApp_Collado.Views.ConversationPage))]

namespace ChatApp_Collado.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\ConversationPage.xaml")]
    public partial class ConversationPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ChatApp_Collado.Controls.ExtendedListView ChatList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ChatApp_Collado.Views.Partials.ChatInputBarView chatInput;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ConversationPage));
            ChatList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ChatApp_Collado.Controls.ExtendedListView>(this, "ChatList");
            chatInput = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ChatApp_Collado.Views.Partials.ChatInputBarView>(this, "chatInput");
        }
    }
}
