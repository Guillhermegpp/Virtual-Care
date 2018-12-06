package md56fac6201423a5e9b972e6bcd68b69584;


public class AlarmViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DataBaseApp.Alarmss.AlarmViewHolder, VirtualCare", AlarmViewHolder.class, __md_methods);
	}


	public AlarmViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == AlarmViewHolder.class)
			mono.android.TypeManager.Activate ("DataBaseApp.Alarmss.AlarmViewHolder, VirtualCare", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
