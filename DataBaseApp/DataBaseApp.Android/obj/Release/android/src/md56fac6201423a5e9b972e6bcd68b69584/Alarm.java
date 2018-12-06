package md56fac6201423a5e9b972e6bcd68b69584;


public class Alarm
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.os.Parcelable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_InitializeCreator:()Lmd56fac6201423a5e9b972e6bcd68b69584/Alarm_AlarmCreator;:__export__\n" +
			"n_hashCode:()I:GetGetHashCodeHandler\n" +
			"n_describeContents:()I:GetDescribeContentsHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_writeToParcel:(Landroid/os/Parcel;I)V:GetWriteToParcel_Landroid_os_Parcel_IHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("DataBaseApp.Alarmss.Alarm, VirtualCare", Alarm.class, __md_methods);
	}


	public Alarm ()
	{
		super ();
		if (getClass () == Alarm.class)
			mono.android.TypeManager.Activate ("DataBaseApp.Alarmss.Alarm, VirtualCare", "", this, new java.lang.Object[] {  });
	}

	public Alarm (android.os.Parcel p0)
	{
		super ();
		if (getClass () == Alarm.class)
			mono.android.TypeManager.Activate ("DataBaseApp.Alarmss.Alarm, VirtualCare", "Android.OS.Parcel, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public static md56fac6201423a5e9b972e6bcd68b69584.Alarm_AlarmCreator CREATOR = InitializeCreator ();

	public static md56fac6201423a5e9b972e6bcd68b69584.Alarm_AlarmCreator InitializeCreator ()
	{
		return n_InitializeCreator ();
	}

	private static native md56fac6201423a5e9b972e6bcd68b69584.Alarm_AlarmCreator n_InitializeCreator ();


	public int hashCode ()
	{
		return n_hashCode ();
	}

	private native int n_hashCode ();


	public int describeContents ()
	{
		return n_describeContents ();
	}

	private native int n_describeContents ();


	public void writeToParcel (android.os.Parcel p0, int p1)
	{
		n_writeToParcel (p0, p1);
	}

	private native void n_writeToParcel (android.os.Parcel p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
