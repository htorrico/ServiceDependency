
using System.Collections.Generic;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio04
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextToSpeechDemo : ContentPage
	{
		public TextToSpeechDemo ()
		{
			InitializeComponent ();
            var stack = new StackLayout();
        

            // Text-to-Speech
            var speak = new Button
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var entry = new Entry();
            speak.Clicked += (sender, e) =>
            {
                DependencyService.Get<ITextToSpeech>().Speak(speak.Text);                
                //DependencyService.Get<ITextToSpeech>().SpeakHelloWorl();
            };

            stack.Children.Add(speak);
            stack.Children.Add(entry);

            Content = stack;
        }
    }
}