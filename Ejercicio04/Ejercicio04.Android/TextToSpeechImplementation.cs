using Android.Speech.Tts;
using Xamarin.Forms;
using Ejercicio04.Droid;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace Ejercicio04.Droid
{

    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

#pragma warning disable S1123 // "Obsolete" attributes should include explanations
        [System.Obsolete]
#pragma warning restore S1123 // "Obsolete" attributes should include explanations
        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {

                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

       

        public void SpeakHelloWordl()
        {
            toSpeak = "Hellow world";
            if (speaker == null)
            {

                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
        #endregion
    }
}
