package md56fac6201423a5e9b972e6bcd68b69584;


public class DividerItemDecorrection
	extends android.support.v7.widget.RecyclerView.ItemDecoration
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDrawOver:(Landroid/graphics/Canvas;Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/RecyclerView$State;)V:GetOnDrawOver_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"";
		mono.android.Runtime.register ("DataBaseApp.Alarmss.DividerItemDecorrection, VirtualCare", DividerItemDecorrection.class, __md_methods);
	}


	public DividerItemDecorrection ()
	{
		super ();
		if (getClass () == DividerItemDecorrection.class)
			mono.android.TypeManager.Activate ("DataBaseApp.Alarmss.DividerItemDecorrection, VirtualCare", "", this, new java.lang.Object[] {  });
	}

	public DividerItemDecorrection (android.content.Context p0)
	{
		super ();
		if (getClass () == DividerItemDecorrection.class)
			mono.android.TypeManager.Activate ("DataBaseApp.Alarmss.DividerItemDecorrection, VirtualCare", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onDrawOver (android.graphics.Canvas p0, android.support.v7.widget.RecyclerView p1, android.support.v7.widget.RecyclerView.State p2)
	{
		n_onDrawOver (p0, p1, p2);
	}

	private native void n_onDrawOver (android.graphics.Canvas p0, android.support.v7.widget.RecyclerView p1, android.support.v7.widget.RecyclerView.State p2);

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
