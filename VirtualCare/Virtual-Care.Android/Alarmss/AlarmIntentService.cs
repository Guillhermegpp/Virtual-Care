using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.Content;

namespace DataBaseApp.Alarmss
{
	/**
 	* IntentService to set off an alarm.
	*/
	[Service (Name = "com.xamarin.directboot.AlarmIntentService")]
	public class AlarmIntentService : IntentService
	{
		public static readonly string ALARM_WENT_OFF_ACTION = (typeof(AlarmIntentService)).Name + ".ALARM_WENT_OFF";
		public static readonly string ALARM_KEY = "alarm_instance";

		protected override void OnHandleIntent (Intent intent)
		{
			Context context = ApplicationContext;
			// var alarm = (Alarm)intent.GetParcelableExtra (ALARM_KEY);

			// TODO - workaround https://github.com/googlesamples/android-DirectBoot/issues/4
			Bundle bundle = intent.Extras;
			var alarm = new Alarm {
				Id = bundle.GetInt ("id"),
				Year = bundle.GetInt ("year"),
				Month = bundle.GetInt ("month"),
				Day = bundle.GetInt ("day"),
				Hour = bundle.GetInt ("hour"),
				Minute = bundle.GetInt ("minute")
			};

			var manager = context.GetSystemService (NotificationService).JavaCast<NotificationManager> ();
			var builder = new NotificationCompat.Builder (context)
												.SetCategory (Notification.CategoryAlarm)
												.SetSound (Settings.System.DefaultAlarmAlertUri)
												.SetContentTitle ("Alarme tocado as "+ alarm.Hour+ alarm.Minute);

			manager.Notify (alarm.Id, builder.Build ());
			var alarmStorage = new AlarmStorage (context);
			alarmStorage.DeleteAlarm (alarm);

			var wentoffIntent = new Intent (ALARM_WENT_OFF_ACTION);
			wentoffIntent.PutExtra (ALARM_KEY, alarm);
			LocalBroadcastManager.GetInstance (context).SendBroadcast (wentoffIntent);
		}
	}
}

